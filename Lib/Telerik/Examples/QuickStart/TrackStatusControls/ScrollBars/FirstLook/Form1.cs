using System;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TrackStatusControls.ScrollBars.FirstLook
{
	public partial class Form1 : EditorExampleBaseForm
	{
        private Control currentScrollBar = null;
		public Form1()
		{
			InitializeComponent();
			UpdateScrollbars();
            this.SelectedControl = this.radHScrollBar1;
        }

        #region Utility Methods
        private void UpdateGUIForProperties(Control ctl)
        {
                RadScrollBar sb = (RadScrollBar)ctl;

				spinMax.Value = sb.Maximum;
				spinMin.Value = sb.Minimum;
				spinLargeChange.Value = sb.LargeChange;
				spinSmallChange.Value = sb.SmallChange;
				spinValue.Value = sb.Value;

				spinThumbLength.Value = (decimal)sb.ThumbLengthProportion >= -1 && (decimal)sb.ThumbLengthProportion <=1 ? 
					(decimal)sb.ThumbLengthProportion : (decimal)0.1;
				spinThumbLength.Enabled = true;
				spinMinThumb.Value = sb.MinThumbLength;
				spinMinThumb.Enabled = true;
        }

        private void SetCurrentMaximum(int newValue)
        {
			
				((RadScrollBar)this.radHScrollBar1).Maximum = newValue;
				((RadScrollBar)this.radVScrollBar1).Maximum = newValue;
        }

        private void SetCurrentMinimum(int newValue)
        {
				((RadScrollBar)this.radHScrollBar1).Minimum = newValue;
				((RadScrollBar)this.radVScrollBar1).Minimum = newValue;
        }

        private void SetCurrentLargeChange(int newValue)
        {
            try
            {
					((RadScrollBar)this.radHScrollBar1).LargeChange = newValue;
					((RadScrollBar)this.radVScrollBar1).LargeChange = newValue;
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show(e.Message, "Wrong value",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetCurrentSmallChange(int newValue)
        {
            try
            {
					((RadScrollBar)this.radVScrollBar1).SmallChange = newValue;
					((RadScrollBar)this.radHScrollBar1).SmallChange = newValue;
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show(e.Message, "Wrong value",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetCurrentValue(int newValue)
        {
            try
            {
					((RadScrollBar)this.radVScrollBar1).Value = newValue;
					((RadScrollBar)this.radHScrollBar1).Value = newValue;
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show(e.Message, "Wrong value",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetCurrentMaximum()
        {
            if (this.currentScrollBar is ScrollBar)
                return ((ScrollBar)this.currentScrollBar).Maximum.ToString();
            else
                return ((RadScrollBar)this.currentScrollBar).Maximum.ToString();
        }

        private string GetCurrentMinimum()
        {
            if (this.currentScrollBar is ScrollBar)
                return ((ScrollBar)this.currentScrollBar).Minimum.ToString();
            else
                return ((RadScrollBar)this.currentScrollBar).Minimum.ToString();
        }

        private string GetCurrentLargeChange()
        {
            if (this.currentScrollBar is ScrollBar)
                return ((ScrollBar)this.currentScrollBar).LargeChange.ToString();
            else
                return ((RadScrollBar)this.currentScrollBar).LargeChange.ToString();
        }

        private string GetCurrentSmallChange()
        {
            if (this.currentScrollBar is ScrollBar)
                return ((ScrollBar)this.currentScrollBar).SmallChange.ToString();
            else
                return ((RadScrollBar)this.currentScrollBar).SmallChange.ToString();
        }

        private string GetCurrentValue()
        {
            if (this.currentScrollBar is ScrollBar)
                return ((ScrollBar)this.currentScrollBar).Value.ToString();
            else
                return ((RadScrollBar)this.currentScrollBar).Value.ToString();
        }
        #endregion

        #region Scroll Events

        private void radVScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            spinValue.Value = radVScrollBar1.Value;
			radHScrollBar1.Value = radVScrollBar1.Value;
        }

        private void radHScrollBar1_ValueChanged(object sender, EventArgs e)
        {
			spinValue.Value = radHScrollBar1.Value;
			radVScrollBar1.Value = radHScrollBar1.Value;
        }
        #endregion

        #region ScrollBar Context Menu
        private RadScrollBar GetScrollBar(object contextMenuEventSender)
        {
            ToolStripDropDownItem item = contextMenuEventSender as ToolStripDropDownItem;
            if (item == null)
                return null;

            ContextMenuStrip menu = item.Owner as ContextMenuStrip;
            if (menu == null)
                return null;

            return menu.SourceControl as RadScrollBar;
        }

        private void scrollToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadScrollBar scrollBar = GetScrollBar(sender);
            if (scrollBar != null)
                scrollBar.PerformScrollTo(Cursor.Position);
        }

        private void leftTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadScrollBar scrollBar = GetScrollBar(sender);
            if (scrollBar != null)
                scrollBar.PerformFirst();
        }

        private void rightBottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadScrollBar scrollBar = GetScrollBar(sender);
            if (scrollBar != null)
                scrollBar.PerformLast();
        }

        private void pageLeftUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadScrollBar scrollBar = GetScrollBar(sender);
            if (scrollBar != null)
                scrollBar.PerformLargeDecrement(1);
        }

        private void pageRightBottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadScrollBar scrollBar = GetScrollBar(sender);
            if (scrollBar != null)
                scrollBar.PerformLargeIncrement(1);
        }

        private void scrollLeftUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadScrollBar scrollBar = GetScrollBar(sender);
            if (scrollBar != null)
                scrollBar.PerformSmallDecrement(1);
        }

        private void scrollRightBottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadScrollBar scrollBar = GetScrollBar(sender);
            if (scrollBar != null)
                scrollBar.PerformSmallIncrement(1);
        }
        #endregion

        #region ScrollBar Properties Editing
        private void SetScrollBarValue(RadSpinEditor input)
        {
			int newValue = (int)input.Value;
            if (input == this.spinMax)
                SetCurrentMaximum(newValue);
            else if (input == this.spinMin)
				SetCurrentMinimum(newValue);
            else if (input == this.spinLargeChange)
				SetCurrentLargeChange(newValue);
            else if (input == this.spinSmallChange)
				SetCurrentSmallChange(newValue);
            else if (input == this.spinValue)
				SetCurrentValue(newValue);

			UpdateScrollbars();
        }

        #endregion

		#region ScrollBar Choosing

        private void UpdateScrollbars()
        {
            UpdateGUIForProperties(this.radVScrollBar1);
            UpdateGUIForProperties(this.radHScrollBar1);
        }
		#endregion

        protected override void WireEvents()
        {
            this.rightBottomToolStripMenuItem.Click += new System.EventHandler(this.rightBottomToolStripMenuItem_Click);
            this.scrollRightBottomToolStripMenuItem.Click += new System.EventHandler(this.scrollRightBottomToolStripMenuItem_Click);
            this.scrollLeftUpToolStripMenuItem.Click += new System.EventHandler(this.scrollLeftUpToolStripMenuItem_Click);
            this.radVScrollBar1.ValueChanged += new System.EventHandler(this.radVScrollBar1_ValueChanged);
            this.spinMin.ValueChanged += new System.EventHandler(this.spinMin_ValueChanged);
            this.spinSmallChange.ValueChanged += new System.EventHandler(this.spinSmallChange_ValueChanged);
            this.radHScrollBar1.ValueChanged += new System.EventHandler(this.radHScrollBar1_ValueChanged);
            this.spinMinThumb.ValueChanged += new System.EventHandler(this.spinMinThumb_ValueChanged);
            this.pageLeftUpToolStripMenuItem.Click += new System.EventHandler(this.pageLeftUpToolStripMenuItem_Click);
            this.pageRightBottomToolStripMenuItem.Click += new System.EventHandler(this.pageRightBottomToolStripMenuItem_Click);
            this.scrollToToolStripMenuItem.Click += new System.EventHandler(this.scrollToToolStripMenuItem_Click);
            this.leftTopToolStripMenuItem.Click += new System.EventHandler(this.leftTopToolStripMenuItem_Click);
            this.spinValue.ValueChanged += new System.EventHandler(this.spinValue_ValueChanged);
            this.spinThumbLength.ValueChanged += new System.EventHandler(this.spinThumbLength_ValueChanged);
            this.spinLargeChange.ValueChanged += new System.EventHandler(this.spinLargeChange_ValueChanged);
            this.spinMax.ValueChanged += new System.EventHandler(this.spinMax_ValueChanged);
        }

		private void spinMax_ValueChanged(object sender, EventArgs e)
		{
			SetScrollBarValue((RadSpinEditor)sender);
		}

		private void spinMin_ValueChanged(object sender, EventArgs e)
		{
			SetScrollBarValue((RadSpinEditor)sender);
		}

		private void spinLargeChange_ValueChanged(object sender, EventArgs e)
		{
			SetScrollBarValue((RadSpinEditor)sender);
		}

		private void spinSmallChange_ValueChanged(object sender, EventArgs e)
		{
			SetScrollBarValue((RadSpinEditor)sender);
		}

		private void spinValue_ValueChanged(object sender, EventArgs e)
		{
			SetScrollBarValue((RadSpinEditor)sender);
		}

		private void spinThumbLength_ValueChanged(object sender, EventArgs e)
		{
			double newValue = (double)spinThumbLength.Value;
				((RadScrollBar)this.radVScrollBar1).ThumbLengthProportion = newValue;
				((RadScrollBar)this.radHScrollBar1).ThumbLengthProportion = newValue;

			UpdateScrollbars();
		}

		private void spinMinThumb_ValueChanged(object sender, EventArgs e)
		{
			int newValue = (int)spinMinThumb.Value;
				((RadScrollBar)this.radVScrollBar1).MinThumbLength = newValue;
				((RadScrollBar)this.radHScrollBar1).MinThumbLength = newValue;

			UpdateScrollbars();
		}
	}
}