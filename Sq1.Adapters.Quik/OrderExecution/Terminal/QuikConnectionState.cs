﻿// QScalp source code was downloaded on Apr 2012 for free from http://www.qscalp.ru/download
// SquareOne uses QScalp's modified classes and keeps original author Name and URL
// Nikolay can tell me to remove your code completely => I'll rewrite borrowed pieces //worldexplorer 
//    Types.cs (c) 2012 Nikolay Moroshkin, http://www.moroshkin.com/
using System;

namespace Sq1.Adapters.Quik.Terminal {
	public enum QuikConnectionState {
		None,
		Exception,
		DllConnected,
		ConnectedUnsubscribed,
		ConnectedSubscribed,
//		Emulation
	}
}