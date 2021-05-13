using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TrackStatusControls.Rating
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            SetupSettings();
        }

        private void SetupSettings()
        {
            this.radRating1.SelectionMode = RatingSelectionMode.HalfItem;
            this.radRating2.SelectionMode = RatingSelectionMode.HalfItem;
            this.radRating3.SelectionMode = RatingSelectionMode.HalfItem;
            this.radRating4.SelectionMode = RatingSelectionMode.HalfItem;

            this.radRating1.AutoSize = true;
            this.radRating2.AutoSize = true;
            this.radRating3.AutoSize = true;
            this.radRating4.AutoSize = true;

            EnumToListBox(typeof(RatingSelectionMode), this.radDropDownList1);

            this.radDropDownList1.SelectedIndex = 2;

            this.radSpinEditor1.Value = (int)this.radRating1.Minimum;
            this.radSpinEditor2.Value = (int)this.radRating1.Maximum;

            if (this.radRating1.Direction == RatingDirection.Standard)
            {
                this.radRadioButton1.IsChecked = true;
            }
            else
            {
                this.radRadioButton2.IsChecked = true;
            }

            if (this.radRating1.RightToLeft == System.Windows.Forms.RightToLeft.Yes)
            {
                this.radCheckBox1.IsChecked = true;
            }
            else
            {
                this.radCheckBox1.IsChecked = false;
            }

            this.radCheckBox2.IsChecked = this.radRating1.ReadOnly;
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

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radRating1.SelectionMode = (RatingSelectionMode)e.Position;
            this.radRating2.SelectionMode = (RatingSelectionMode)e.Position;
            this.radRating3.SelectionMode = (RatingSelectionMode)e.Position;
            this.radRating4.SelectionMode = (RatingSelectionMode)e.Position;
        }
    
        private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            this.radSpinEditor2.Minimum = this.radSpinEditor1.Value + 1;
            this.radRating1.Minimum = (int)this.radSpinEditor1.Value;
            this.radRating2.Minimum = (int)this.radSpinEditor1.Value;
            this.radRating3.Minimum = (int)this.radSpinEditor1.Value;
            this.radRating4.Minimum = (int)this.radSpinEditor1.Value;
        }

        private void radSpinEditor2_ValueChanged(object sender, EventArgs e)
        {
            this.radSpinEditor1.Maximum = this.radSpinEditor2.Value - 1;
            this.radRating1.Maximum = (int)this.radSpinEditor2.Value;
            this.radRating2.Maximum = (int)this.radSpinEditor2.Value;
            this.radRating3.Maximum = (int)this.radSpinEditor2.Value;
            this.radRating4.Maximum = (int)this.radSpinEditor2.Value;
        }

        private void radRadioButton1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radRating1.Direction = RatingDirection.Standard;
            this.radRating2.Direction = RatingDirection.Standard;
            this.radRating3.Direction = RatingDirection.Standard;
            this.radRating4.Direction = RatingDirection.Standard;
        }

        private void radRadioButton2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radRating1.Direction = RatingDirection.Reversed;
            this.radRating2.Direction = RatingDirection.Reversed;
            this.radRating3.Direction = RatingDirection.Reversed;
            this.radRating4.Direction = RatingDirection.Reversed;
        }

        void radRadioButton3_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radRating1.Location = new System.Drawing.Point(50, 50);
            this.radRating2.Location = new System.Drawing.Point(50, 120);
            this.radRating3.Location = new System.Drawing.Point(250, 50);
            this.radRating4.Location = new System.Drawing.Point(250, 120);
            this.radRating1.Orientation = Orientation.Horizontal;
            this.radRating2.Orientation = Orientation.Horizontal;
            this.radRating3.Orientation = Orientation.Horizontal;
            this.radRating4.Orientation = Orientation.Horizontal;
        }

        void radRadioButton4_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radRating1.Location = new System.Drawing.Point(48, 49);
            this.radRating2.Location = new System.Drawing.Point(48, 240);
            this.radRating3.Location = new System.Drawing.Point(248, 49);
            this.radRating4.Location = new System.Drawing.Point(254, 240);
            this.radRating1.Orientation = Orientation.Vertical;
            this.radRating2.Orientation = Orientation.Vertical;
            this.radRating3.Orientation = Orientation.Vertical;
            this.radRating4.Orientation = Orientation.Vertical;
        }

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radCheckBox1.IsChecked)
            {
                this.radRating1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.radRating2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.radRating3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.radRating4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            }
            else
            {
                this.radRating1.RightToLeft = System.Windows.Forms.RightToLeft.No;
                this.radRating2.RightToLeft = System.Windows.Forms.RightToLeft.No;
                this.radRating3.RightToLeft = System.Windows.Forms.RightToLeft.No;
                this.radRating4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            }
        }

        private void radCheckBox2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radRating1.ReadOnly = this.radCheckBox2.IsChecked;
            this.radRating2.ReadOnly = this.radCheckBox2.IsChecked;
            this.radRating3.ReadOnly = this.radCheckBox2.IsChecked;
            this.radRating4.ReadOnly = this.radCheckBox2.IsChecked;
        }
   
        protected override void WireEvents()
        {
            this.radSpinEditor1.ValueChanged += new System.EventHandler(this.radSpinEditor1_ValueChanged);
            this.radSpinEditor2.ValueChanged += new System.EventHandler(this.radSpinEditor2_ValueChanged);
            this.radCheckBox2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox2_ToggleStateChanged);
            this.radRadioButton1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            this.radRadioButton2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton2_ToggleStateChanged);
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList1_SelectedIndexChanged);
            this.radRadioButton3.ToggleStateChanged += new StateChangedEventHandler(radRadioButton3_ToggleStateChanged);
            this.radRadioButton4.ToggleStateChanged += new StateChangedEventHandler(radRadioButton4_ToggleStateChanged);
        }
        public override void OnThemeChanged()
        {
            base.OnThemeChanged();
            if (TelerikHelper.IsDarkTheme(this.CurrentThemeName))
            {
                radRating1.RatingElement.CaptionElement.ForeColor = Color.White;
                radRating2.RatingElement.CaptionElement.ForeColor = Color.White;
                radRating3.RatingElement.CaptionElement.ForeColor = Color.White;
                radRating4.RatingElement.CaptionElement.ForeColor = Color.White;
            }
            else
            {
                radRating1.RatingElement.CaptionElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local);
                radRating2.RatingElement.CaptionElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local);
                radRating3.RatingElement.CaptionElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local);
                radRating4.RatingElement.CaptionElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local);
            }
        }
    }
}
