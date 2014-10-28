﻿using System;
using System.Threading;
using Sq1.Core;

namespace Sq1.QuikAdapter.StreamingDdeApi {
	public class DdeChannelLastQuoteMock {	//: DdeChannelLastQuote
		protected MockStreamingProvider providerMock;
		protected string quoteSource = "QUIK_DDE";
		protected string symbol = "RIZ2";

		bool running = false;
		public int nextQuoteDelayMs = 500;
		double secondsInBar = 60;
		double barsGrow = 1.2;
		double priceStartFrom = 158000;
		double priceLimitUpper = 159000;
		double priceLimitLower = 157000;
		double priceLimitUpperSliding = 159000;
		double priceLimitLowerSliding = 157000;
		double priceIncrement = 15;
		double tickSize = 5;
		double volumeStartFrom = 200;
		double volumeIncrement = 5;
		double spread = 20;

		Thread pokerThread;
		int pokesLimit = 0;
		int pokesDone = 0;
		int QuoteAbsnoPriceMutatedToZero = 3;

		Random rnd;
		bool prevRandWasPositive = true;

		public DdeChannelLastQuoteMock(MockStreamingProvider providerMock, string SymbolSubscribing) {
			//: base(streamingProvider, SymbolSubscribing)
			this.providerMock = providerMock;
			this.symbol = SymbolSubscribing;

			this.initializeFromMiddle();
			rnd = new Random();
			if (barsGrow > 0) {
				double quotesPerBar = secondsInBar / nextQuoteDelayMs * 1000;
				quotesPerBar *= 0.2; // for zigZagIncrement
				this.priceLimitUpperSliding = priceStartFrom + priceIncrement * quotesPerBar * barsGrow;
				this.priceLimitLowerSliding = priceStartFrom - priceIncrement * quotesPerBar * barsGrow;
			};

			pokerThread = new Thread(startMock);
			pokerThread.Name = "DdeChannelQuoteMock::pokerThread";
			pokerThread.Start();
			//startMock();
			//Thread.Sleep(nextQuoteDelayMs);
			//Console.WriteLine("Quote delivered, rescheduling Timer for " + nextQuoteDelayMs + "ms...");
		}

		void initializeFromMiddle() {
			nextQuoteDelayMs = 500;
			secondsInBar = 60;
			barsGrow = 1.2;
			priceStartFrom = 158000;
			priceLimitUpper = 159000;
			priceLimitLower = 157000;
			priceLimitUpperSliding = 159000;
			priceLimitLowerSliding = 157000;
			priceIncrement = 15;
			tickSize = 5;
			volumeStartFrom = 200;
			volumeIncrement = 5;
			spread = 20;
			pokesLimit = 0;
			pokesDone = 0;
			QuoteAbsnoPriceMutatedToZero = 3;
		}

		void initializeFromBottom() {
			nextQuoteDelayMs = 500;
			secondsInBar = 60;
			barsGrow = 1.2;
			priceStartFrom = 157200;
			priceLimitUpper = 159000;
			priceLimitLower = 157000;
			priceLimitUpperSliding = 159000;
			priceLimitLowerSliding = 157000;
			priceIncrement = 15;
			tickSize = 5;
			volumeStartFrom = 200;
			volumeIncrement = 5;
			spread = 20;
			pokesLimit = 0;
			pokesDone = 0;
			QuoteAbsnoPriceMutatedToZero = 3;
		}

		public void setNextQuoteDelayMs(int nextQuoteDelayMs) {
			if (nextQuoteDelayMs == 0) {
				Assembler.PopupException("Can't set nextQuoteDelayMs[" + nextQuoteDelayMs + "], most likely Covert.ToInt32 returned 0 for an unparseable string; this.nextQuoteDelayMs[" + this.nextQuoteDelayMs + "], still");
				return;
			}
			this.nextQuoteDelayMs = nextQuoteDelayMs;
		}

		public void startMock() {
			//Assembler.PopupException("startMock(" + pokesDone + "/" + pokesLimit + "): starting timer nextQuoteDelayMs=" + nextQuoteDelayMs + " period=0...");
			Timer t = new Timer(new TimerCallback(pokeWithNewQuote));
			t.Change(nextQuoteDelayMs, 0);
			this.running = true;
		}

		public void stopMock() {
			if (running == false) return;
			running = false;
		}

		public void pokeWithNewQuote(object state) {
			if (Thread.CurrentThread.Name != "DdeChannelQuoteMock::pokeWithNewQuote") Thread.CurrentThread.Name = "DdeChannelQuoteMock::pokeWithNewQuote";
			Timer t = (Timer)state;
			if (pokesLimit > 0 && pokesDone++ > pokesLimit) {
				Assembler.PopupException("pokeWithNewQuote(" + pokesDone + "/" + pokesLimit + "): no more quotes to generate"
					+ ", pokesDone[" + pokesDone + "]>=pokesLimit[" + pokesLimit + "]");
				running = false;
			}
			if (running == false) {
				t.Dispose();
				pokerThread.Abort();
				Assembler.PopupException("Timer stopped");
				return;
			}
			//Assembler.PopupException("pokeWithNewQuote(" + pokesDone + "/" + pokesLimit + "): generating new bar");
			QuikQuote quikQuote = new QuikQuote();
			quikQuote.Source = quoteSource;
			quikQuote.Symbol = symbol;
			//quote.SymbolClass = providerMock.SettingsManager.Get("QuikStreamingProvider.SymbolClass", "SPBFUT");
			quikQuote.SymbolClass = "SPBFUT";
			//quote.ServerTime = DateTime.Now.AddHours(8);
			quikQuote.FortsDepositBuy = 10000 + rnd.Next(10, 99);
			quikQuote.FortsDepositSell = 10000 + rnd.Next(10, 99);
			quikQuote.FortsPriceMax = this.priceLimitUpper + 1000;
			quikQuote.FortsPriceMin = this.priceLimitLower - 1000;

			int rand = rnd.Next(0, (int) Math.Abs(priceIncrement));
			if (priceIncrement < 0) rand = -rand;
			double zigZagIncrement = priceIncrement + rand;
			if (prevRandWasPositive) {
				zigZagIncrement = -zigZagIncrement * 0.8;	// half step back
			}
			prevRandWasPositive = !prevRandWasPositive;
			priceStartFrom += zigZagIncrement;
			priceStartFrom = (priceIncrement > 0)
				? Math.Ceiling(priceStartFrom / tickSize) * tickSize
				: Math.Floor(priceStartFrom / tickSize) * tickSize;
			quikQuote.PriceLastDeal = priceStartFrom;

			quikQuote.Size = volumeIncrement;
			if (quikQuote.Absno == this.QuoteAbsnoPriceMutatedToZero && quikQuote.Source == "QUIK_DDE_MOCK") {
				quikQuote.PriceLastDeal = 0;
				Assembler.PopupException("MOCK_TEST_ONCE: setting Price=0 for quote[" + quikQuote + "]; watch CHART skipping it and ORDER with an ERROR");
			}
			quikQuote.Bid = quikQuote.PriceLastDeal - spread / 2;
			quikQuote.Ask = quikQuote.PriceLastDeal + spread / 2;
			this.providerMock.PropagateGeneratedQuoteCallback(quikQuote);
			//streamingProvider.putBestBidAskForSymbol(symbol, quote.Price - spread / 2, quote.Price + spread / 2);

			t.Change(nextQuoteDelayMs, 0);
			//Assembler.PopupException("Quote fillPrice=[" + priceStartFrom + "] size=[" + volumeStartFrom + "] delivered"
			//	+ ", rescheduling timer nextQuoteDelayMs=" + nextQuoteDelayMs + " period=0");
			if (priceStartFrom > priceLimitUpperSliding) {
				priceStartFrom -= priceIncrement * 4;
				priceIncrement = -priceIncrement;
			}
			if (priceStartFrom < priceLimitLowerSliding) {
				priceStartFrom -= priceIncrement * 4;
				priceIncrement = -priceIncrement;
			}
		}

		public override string ToString() {
			return "MockStreamingProvider[" + providerMock + "] quoteSource[" + quoteSource + "] symbol[" + symbol + "]";
		}
	}
}