using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Telerik.Examples.WinControls.PropertyGrid.Settings
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (this.radPropertyGrid1 != null)
            {
                int width = this.ClientSize.Width;
                int height = this.ClientSize.Height;
                this.radPropertyGrid1.Location =Point.Empty;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.AutoScroll = false;

            this.radPropertyGrid1.HelpVisible = true;
            this.radPropertyGrid1.ToolbarVisible = true;
            this.radPropertyGrid1.KeyboardSearchEnabled = true;

            this.radPropertyGrid1.SelectedObject = new RadPropertyGrid();

            this.radCheckBoxHelpVisible.IsChecked = this.radPropertyGrid1.HelpVisible;
            this.radCheckBoxSearchVisible.IsChecked = this.radPropertyGrid1.ToolbarVisible;
            this.radCheckBoxReadOnly.IsChecked = this.radPropertyGrid1.ReadOnly;
            this.radCheckBoxAutoExpandGroups.IsChecked = this.radPropertyGrid1.AutoExpandGroups;
            this.radCheckBoxKeyboardSearch.IsChecked = this.radPropertyGrid1.KeyboardSearchEnabled;
            this.radSpinEditorItemHeight.Value = this.radPropertyGrid1.ItemHeight;
            this.radSpinEditorItemIndent.Value = this.radPropertyGrid1.ItemIndent;
            this.radSpinEditorItemSpacing.Value = this.radPropertyGrid1.ItemSpacing;
            this.radDropDownListPropertySort.DataSource = Enum.GetValues(typeof(PropertySort));
            this.radDropDownListPropertySort.SelectedValue = this.radPropertyGrid1.PropertySort;

            this.radPropertyGrid1.PropertyGridElement.PropertyChanged += new PropertyChangedEventHandler(Element_PropertyChanged);
            this.radPropertyGrid1.PropertyGridElement.SplitElement.PropertyChanged += new PropertyChangedEventHandler(Element_PropertyChanged);
            this.radPropertyGrid1.PropertyGridElement.SplitElement.PropertyTableElement.PropertyChanged += new PropertyChangedEventHandler(Element_PropertyChanged);
        
            this.radPropertyGrid1.PropertySort = PropertySort.CategorizedAlphabetical;
            this.WireEvents();
        }

        private void Element_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "SearchBarVisible")
            {
                this.radCheckBoxSearchVisible.IsChecked = this.radPropertyGrid1.ToolbarVisible;
            }
            else if (e.PropertyName == "HelpVisible")
            {
                this.radCheckBoxHelpVisible.IsChecked = this.radPropertyGrid1.HelpVisible;
            }
            else if (e.PropertyName == "PropertySort")
            {
                this.radDropDownListPropertySort.SelectedValue = this.radPropertyGrid1.PropertySort;
            }
        }

        private void radCheckBoxHelpVisible_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radPropertyGrid1.HelpVisible = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxSearchVisible_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radPropertyGrid1.ToolbarVisible = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxReadOnly_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radPropertyGrid1.ReadOnly = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxAutoExpandGroups_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radPropertyGrid1.AutoExpandGroups = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxKeyboardSearch_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radPropertyGrid1.KeyboardSearchEnabled = args.ToggleState == ToggleState.On;
        }

        private void radSpinEditorItemHeight_ValueChanged(object sender, EventArgs e)
        {
            this.radPropertyGrid1.ItemHeight = (int)this.radSpinEditorItemHeight.Value;
        }

        private void radSpinEditorItemIndent_ValueChanged(object sender, EventArgs e)
        {
            this.radPropertyGrid1.ItemIndent = (int)this.radSpinEditorItemIndent.Value;
        }

        private void radSpinEditorItemSpacing_ValueChanged(object sender, EventArgs e)
        {
            this.radPropertyGrid1.ItemSpacing = (int)this.radSpinEditorItemSpacing.Value;
        }

        private void radDropDownListPropertySort_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radPropertyGrid1.PropertySort = (PropertySort)this.radDropDownListPropertySort.SelectedValue;
        }

        protected override void WireEvents()
        {
            this.radDropDownListPropertySort.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownListPropertySort_SelectedIndexChanged);
            this.radSpinEditorItemSpacing.ValueChanged += new System.EventHandler(this.radSpinEditorItemSpacing_ValueChanged);
            this.radSpinEditorItemIndent.ValueChanged += new System.EventHandler(this.radSpinEditorItemIndent_ValueChanged);
            this.radSpinEditorItemHeight.ValueChanged += new System.EventHandler(this.radSpinEditorItemHeight_ValueChanged);
            this.radCheckBoxAutoExpandGroups.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxAutoExpandGroups_ToggleStateChanged);
            this.radCheckBoxReadOnly.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxReadOnly_ToggleStateChanged);
            this.radCheckBoxSearchVisible.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxSearchVisible_ToggleStateChanged);
            this.radCheckBoxHelpVisible.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxHelpVisible_ToggleStateChanged);
        }
    }
}
