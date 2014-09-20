﻿using System;
using System.Windows.Forms;
using Sq1.Core;

namespace Sq1.Charting {
	public partial class ChartControl	{
		protected override void OnResize(EventArgs e) {
			if (this.ScrollLargeChange <= 0) {
				//Debugger.Break();	// HAPPENS_WHEN_WINDOW_IS_MINIMIZED... how to disable any OnPaint when app isn't visible?...
				return;
			}
		    this.hScrollBar.LargeChange = this.ScrollLargeChange;
		    base.OnResize(e);	// will invoke UserControlDoubleBuffered.OnResize() if you inherited so here you are DoubleBuffer-safe
		}
		
		protected override void OnMouseMove(MouseEventArgs e) {
			// it looks like parent should get mouse updates from the Panels?...
			int a = 1;
		}
		protected override void OnMouseWheel(MouseEventArgs e) {
			base.OnMouseWheel(e);
			if (e.Delta == 0) return;
			if (e.Delta > 0) {
				this.ScrollOnePageLeft();
			} else {
				this.ScrollOnePageRight();
			}
		}
		#region IsInputKey is a filter OnKeyDown should go together
		protected override bool IsInputKey(Keys keyData) {
			switch (keyData) {
				case Keys.Right:
				case Keys.Left:
				case Keys.Up:
				case Keys.Down:
					return true;
//				case Keys.Shift | Keys.Right:
//				case Keys.Shift | Keys.Left:
//				case Keys.Shift | Keys.Up:
//				case Keys.Shift | Keys.Down:
//					return true;
			}
			return base.IsInputKey(keyData);
		}
		protected override void OnKeyDown(KeyEventArgs keyEventArgs) {
			if (this.BarsEmpty) return;
			switch (keyEventArgs.KeyCode) {
				case Keys.Up:
					this.BarWidthIncrementAtKeyPressRate();
					break;
				case Keys.Down:
					this.BarWidthDecrementAtKeyPressRate();
					break;
				case Keys.Left:
					this.ScrollOneBarLeftAtKeyPressRate();
					break;
				case Keys.Right:
					this.ScrollOneBarRightAtKeyPressRate();
					break;
				case Keys.Home:
					this.scrollToBarSafely(0);
					break;
				case Keys.End:
					this.scrollToBarSafely(this.Bars.Count - 1);
					break;
				case Keys.PageDown:
					this.ScrollOnePageRight();
					break;
				case Keys.PageUp:
					this.ScrollOnePageLeft();
					break;
			}
			base.OnKeyDown(keyEventArgs);
		}
		#endregion		
		void splitContainerPriceVsVolume_SplitterMoved(object sender, SplitterEventArgs e) {
			//v1 this.ChartSettings.PriceVsVolumeSplitterDistance = this.splitContainerPriceVsVolume.SplitterDistance;
			//v2
			if (base.DesignMode) return;
			if (this.ChartSettings == null) return;	// may be redundant
			if (Assembler.InstanceInitialized.MainFormClosingIgnoreReLayoutDockedForms) return;
			if (Assembler.InstanceInitialized.MainFormDockFormsFullyDeserializedLayoutComplete == false) return;
			//if (this.ChartSettings.PriceVsVolumeSplitterDistance == e.SplitY) return;
			//this.ChartSettings.PriceVsVolumeSplitterDistance = e.SplitY;
			if (this.ChartSettings.PriceVsVolumeSplitterDistance == this.splitContainerPriceVsVolume.SplitterDistance) return;
			this.ChartSettings.PriceVsVolumeSplitterDistance = this.splitContainerPriceVsVolume.SplitterDistance;
			this.RaiseChartSettingsChangedContainerShouldSerialize();
		}
	}
}