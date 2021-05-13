using System;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.PageView.StripView.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        #region Fields

        private RadPageViewStripElement strip;

        #endregion

        #region Constructor/Initialization

        public Form1()
        {
            InitializeComponent();

            this.strip = this.radPageView1.ViewElement as RadPageViewStripElement;
            this.strip.StripButtons = StripViewButtons.None;

            this.PopulateSettingsCombo(this.alignCombo, typeof(StripViewAlignment), strip.StripAlignment);
            this.PopulateSettingsCombo(this.orientationCombo, typeof(PageViewContentOrientation), strip.ItemContentOrientation);
            this.PopulateSettingsCombo(this.buttonsCombo, typeof(StripViewButtons), strip.StripButtons);
        }

        private void PopulateSettingsCombo(RadDropDownList combo, Type enumType, object selected)
        {
            int selectedIndex = -1;
            int counter = 0;

            foreach (object value in Enum.GetValues(enumType))
            {
                RadListDataItem item = new RadListDataItem(value.ToString(), value);
                combo.Items.Add(item);
                if (object.Equals(selected, value))
                {
                    selectedIndex = counter;
                }

                counter++;
            }

            combo.SelectedIndex = selectedIndex;
        }

        #endregion

        #region Event Handlers

        private void alignCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = this.alignCombo.SelectedItem as RadListDataItem;
            this.strip.StripAlignment = (StripViewAlignment)item.Value;
        }

        private void orientationCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = this.orientationCombo.SelectedItem as RadListDataItem;
            this.strip.ItemContentOrientation = (PageViewContentOrientation)item.Value;
        }

        private void buttonsCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = this.buttonsCombo.SelectedItem as RadListDataItem;
            this.strip.StripButtons = (StripViewButtons)item.Value;
        }

        #endregion

        protected override void WireEvents()
        {
            this.alignCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.alignCombo_SelectedIndexChanged);
            this.buttonsCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.buttonsCombo_SelectedIndexChanged);
            this.orientationCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.orientationCombo_SelectedIndexChanged);
        }
    }
}
