using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TrackStatusControls.TrackBar
{
    public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();

            SetupTrackBars();
            SetupSettings();
     
		}

        private void SetupSettings()
        {
            EnumToListBox(typeof(TickStyles), this.radDropDownList1);
            EnumToListBox(typeof(TrackBarLabelStyle), this.radDropDownList2);
            EnumToListBox(typeof(TrackBarSnapModes), this.radDropDownList3);

            this.radDropDownList1.SelectedIndex = 3;
            this.radDropDownList2.SelectedIndex = 3;
            this.radDropDownList3.SelectedIndex = 1;
            this.radSpinEditor1.Value = this.radTrackBar1.LargeTickFrequency;
            this.radSpinEditor2.Value = this.radTrackBar1.SmallTickFrequency;
            this.radSpinEditor3.Value = this.radTrackBar1.ThumbSize.Width;
            this.radSpinEditor4.Value = this.radTrackBar1.ThumbSize.Height;

            if (this.radTrackBar1.Orientation == Orientation.Horizontal)
            {
                this.radRadioButton1.IsChecked = true;
            }
            else 
            {
                this.radRadioButton2.IsChecked = true;
            }

            if(this.radTrackBar1.RightToLeft == System.Windows.Forms.RightToLeft.Yes)
            {
                this.radCheckBox1.IsChecked = true;
            }
            else
            {
                this.radCheckBox1.IsChecked = false;
            }

            this.radCheckBox2.IsChecked = this.radTrackBar1.ShowSlideArea;
            this.radCheckBox3.IsChecked = this.radTrackBar1.ShowButtons;
        }

        static public void EnumToListBox(Type EnumType, RadDropDownList TheListBox)
        {
            Array Values = System.Enum.GetValues(EnumType);

            foreach (int Value in Values)
            {
                string Display = Enum.GetName(EnumType, Value);

                RadListDataItem Item = new RadListDataItem(Display, Value.ToString());

                TheListBox.Items.Add(Item);
            }
        }

        private void SetupTrackBars()
        {
            //TrackBar1
            this.radTrackBar1.SnapFrequency = TrackBarSnapFrequency.Ticks;
            this.radTrackBar1.TrackBarMode = TrackBarRangeMode.SingleThumb;
            this.radTrackBar1.Value = 7;

            //TrackBar2
            this.radTrackBar2.SnapFrequency = TrackBarSnapFrequency.Ticks;
            this.radTrackBar2.TrackBarMode = TrackBarRangeMode.Range;

            this.radTrackBar2.Ranges[0].End = 10;
            this.radTrackBar2.Ranges[0].Start = 5;


            //TrackBar3
            this.radTrackBar3.SnapFrequency = TrackBarSnapFrequency.Ticks;
            this.radTrackBar3.TrackBarMode = TrackBarRangeMode.Range;
            this.radTrackBar3.Ranges.Add(new TrackBarRange(12,18));

            this.radTrackBar3.Ranges[0].End = 10;
            this.radTrackBar3.Ranges[0].Start = 5;

            //TrackBar4
            this.radTrackBar4.SnapFrequency = TrackBarSnapFrequency.Ticks;
            this.radTrackBar4.TrackBarMode = TrackBarRangeMode.StartFromTheBeginning;

            this.radTrackBar4.Ranges.Add(new TrackBarRange(0, 8));
            this.radTrackBar4.Ranges.Add(new TrackBarRange(5, 12));
        }

        public override void OnThemeChanged()
        {
            base.OnThemeChanged();
            if (this.CurrentThemeName == "VisualStudio2012Dark")
            {
                this.radTrackBar1.TrackBarElement.BodyElement.ScaleContainerElement.ForeColor = Color.White;
                this.radTrackBar2.TrackBarElement.BodyElement.ScaleContainerElement.ForeColor = Color.White;
                this.radTrackBar3.TrackBarElement.BodyElement.ScaleContainerElement.ForeColor = Color.White;
                this.radTrackBar4.TrackBarElement.BodyElement.ScaleContainerElement.ForeColor = Color.White;
            }
            else
            {
                this.radTrackBar1.TrackBarElement.BodyElement.ScaleContainerElement.ResetValue(RadItem.ForeColorProperty, ValueResetFlags.Local);
                this.radTrackBar2.TrackBarElement.BodyElement.ScaleContainerElement.ResetValue(RadItem.ForeColorProperty, ValueResetFlags.Local);
                this.radTrackBar3.TrackBarElement.BodyElement.ScaleContainerElement.ResetValue(RadItem.ForeColorProperty, ValueResetFlags.Local);
                this.radTrackBar4.TrackBarElement.BodyElement.ScaleContainerElement.ResetValue(RadItem.ForeColorProperty, ValueResetFlags.Local);
            }
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radTrackBar1.TickStyle = (TickStyles)e.Position;
            this.radTrackBar2.TickStyle = (TickStyles)e.Position;
            this.radTrackBar3.TickStyle = (TickStyles)e.Position;
            this.radTrackBar4.TickStyle = (TickStyles)e.Position;
        }

        private void radDropDownList2_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radTrackBar1.LabelStyle = (TrackBarLabelStyle)e.Position;
            this.radTrackBar2.LabelStyle = (TrackBarLabelStyle)e.Position;
            this.radTrackBar3.LabelStyle = (TrackBarLabelStyle)e.Position;
            this.radTrackBar4.LabelStyle = (TrackBarLabelStyle)e.Position;
        }


        private void radDropDownList3_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radTrackBar1.SnapMode = (TrackBarSnapModes)e.Position;
            this.radTrackBar2.SnapMode = (TrackBarSnapModes)e.Position;
            this.radTrackBar3.SnapMode = (TrackBarSnapModes)e.Position;
            this.radTrackBar4.SnapMode = (TrackBarSnapModes)e.Position;
        }

        private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            this.radTrackBar1.LargeTickFrequency = (int)this.radSpinEditor1.Value;
            this.radTrackBar2.LargeTickFrequency = (int)this.radSpinEditor1.Value;
            this.radTrackBar3.LargeTickFrequency = (int)this.radSpinEditor1.Value;
            this.radTrackBar4.LargeTickFrequency = (int)this.radSpinEditor1.Value;
        }

        private void radSpinEditor2_ValueChanged(object sender, EventArgs e)
        {
            this.radTrackBar1.SmallTickFrequency = (int)this.radSpinEditor2.Value;
            this.radTrackBar2.SmallTickFrequency = (int)this.radSpinEditor2.Value;
            this.radTrackBar3.SmallTickFrequency = (int)this.radSpinEditor2.Value;
            this.radTrackBar4.SmallTickFrequency = (int)this.radSpinEditor2.Value;
        }

        private void radSpinEditor3_ValueChanged(object sender, EventArgs e)
        {
            this.radTrackBar1.ThumbSize = new Size((int)this.radSpinEditor3.Value, this.radTrackBar1.ThumbSize.Height);
            this.radTrackBar2.ThumbSize = new Size((int)this.radSpinEditor3.Value, this.radTrackBar2.ThumbSize.Height);
            this.radTrackBar3.ThumbSize = new Size((int)this.radSpinEditor3.Value, this.radTrackBar3.ThumbSize.Height);
            this.radTrackBar4.ThumbSize = new Size((int)this.radSpinEditor3.Value, this.radTrackBar4.ThumbSize.Height);

        }

        private void radSpinEditor4_ValueChanged(object sender, EventArgs e)
        {
            this.radTrackBar1.ThumbSize = new Size(this.radTrackBar1.ThumbSize.Width, (int)this.radSpinEditor4.Value);
            this.radTrackBar2.ThumbSize = new Size(this.radTrackBar2.ThumbSize.Width, (int)this.radSpinEditor4.Value);
            this.radTrackBar3.ThumbSize = new Size(this.radTrackBar3.ThumbSize.Width, (int)this.radSpinEditor4.Value);
            this.radTrackBar4.ThumbSize = new Size(this.radTrackBar4.ThumbSize.Width, (int)this.radSpinEditor4.Value);
        }

        private void radRadioButton1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radTrackBar1.Orientation = Orientation.Horizontal;
            this.radTrackBar2.Orientation = Orientation.Horizontal;
            this.radTrackBar3.Orientation = Orientation.Horizontal;
            this.radTrackBar4.Orientation = Orientation.Horizontal;

            this.radTrackBar1.Width = 500;
            this.radTrackBar2.Width = 500;
            this.radTrackBar3.Width = 500;
            this.radTrackBar4.Width = 500;

            this.radLabel1.Location = new System.Drawing.Point(120, 40);
            this.radTrackBar1.Location = new System.Drawing.Point(120, 60);

            this.radLabel2.Location = new System.Drawing.Point(120, 160);
            this.radTrackBar2.Location = new System.Drawing.Point(120, 180);

            this.radLabel3.Location = new System.Drawing.Point(120, 280);
            this.radTrackBar3.Location = new System.Drawing.Point(120, 300);

            this.radLabel4.Location = new System.Drawing.Point(120, 400);
            this.radTrackBar4.Location = new System.Drawing.Point(120, 420);
        }

        private void radRadioButton2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radTrackBar1.Orientation = Orientation.Vertical;
            this.radTrackBar2.Orientation = Orientation.Vertical;
            this.radTrackBar3.Orientation = Orientation.Vertical;
            this.radTrackBar4.Orientation = Orientation.Vertical;

            this.radTrackBar1.Height = 500;
            this.radTrackBar2.Height = 500;
            this.radTrackBar3.Height = 500;
            this.radTrackBar4.Height = 500;

            this.radLabel1.Location = new System.Drawing.Point(35, 15);
            this.radTrackBar1.Location = new System.Drawing.Point(50, 40);

            this.radLabel2.Location = new System.Drawing.Point(200, 15);
            this.radTrackBar2.Location = new System.Drawing.Point(260, 40);

            this.radLabel3.Location = new System.Drawing.Point(410, 15);
            this.radTrackBar3.Location = new System.Drawing.Point(470, 40);

            this.radLabel4.Location = new System.Drawing.Point(635, 15);
            this.radTrackBar4.Location = new System.Drawing.Point(680, 40);
        }

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radCheckBox1.IsChecked)
            {
                this.radTrackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.radTrackBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.radTrackBar3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.radTrackBar4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            }
            else 
            {
                this.radTrackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
                this.radTrackBar2.RightToLeft = System.Windows.Forms.RightToLeft.No;
                this.radTrackBar3.RightToLeft = System.Windows.Forms.RightToLeft.No;
                this.radTrackBar4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            }
        }

        private void radCheckBox2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radTrackBar1.ShowSlideArea = this.radCheckBox2.IsChecked;
            this.radTrackBar2.ShowSlideArea = this.radCheckBox2.IsChecked;
            this.radTrackBar3.ShowSlideArea = this.radCheckBox2.IsChecked;
            this.radTrackBar4.ShowSlideArea = this.radCheckBox2.IsChecked;
        }

        private void radCheckBox3_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radTrackBar1.ShowButtons = this.radCheckBox3.IsChecked;
            this.radTrackBar2.ShowButtons = this.radCheckBox3.IsChecked;
            this.radTrackBar3.ShowButtons = this.radCheckBox3.IsChecked;
            this.radTrackBar4.ShowButtons = this.radCheckBox3.IsChecked;
        }

        protected override void WireEvents()
        {
            this.radSpinEditor4.ValueChanged += new System.EventHandler(this.radSpinEditor4_ValueChanged);
            this.radSpinEditor3.ValueChanged += new System.EventHandler(this.radSpinEditor3_ValueChanged);
            this.radSpinEditor1.ValueChanged += new System.EventHandler(this.radSpinEditor1_ValueChanged);
            this.radSpinEditor2.ValueChanged += new System.EventHandler(this.radSpinEditor2_ValueChanged);
            this.radCheckBox2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox2_ToggleStateChanged);
            this.radRadioButton1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            this.radRadioButton2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton2_ToggleStateChanged);
            this.radDropDownList2.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList2_SelectedIndexChanged);
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList1_SelectedIndexChanged);
            this.radDropDownList3.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList3_SelectedIndexChanged);
            this.radCheckBox3.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox3_ToggleStateChanged);
        }
	}
}