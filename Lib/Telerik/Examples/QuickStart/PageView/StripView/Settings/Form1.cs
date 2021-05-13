using System;
using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.PageView.StripView.Settings
{
    public partial class Form1 : ExamplesForm
    {
        #region Fields

        private RadPageViewStripElement strip;
        private int imageIndex;

        #endregion

        #region Constructor/Initialization

        public Form1()
        {
            InitializeComponent();

            this.strip = this.radPageView1.ViewElement as RadPageViewStripElement;
            this.strip.ItemDragMode = PageViewItemDragMode.Preview;

            ExamplesForm.FillComboFromEnum(this.stripAlignCombo, typeof(StripViewAlignment), this.strip.StripAlignment);
            ExamplesForm.FillComboFromEnum(this.itemAlignCombo, typeof(StripViewItemAlignment), this.strip.ItemAlignment);
            ExamplesForm.FillComboFromEnum(this.fitModeCombo, typeof(StripViewItemFitMode), this.strip.ItemFitMode);
            ExamplesForm.FillComboFromEnum(this.sizeModeCombo, typeof(PageViewItemSizeMode), this.strip.ItemSizeMode);
            ExamplesForm.FillComboFromEnum(this.orientationCombo, typeof(PageViewContentOrientation), this.strip.ItemContentOrientation);
            ExamplesForm.FillComboFromEnum(this.multiLineFitCombo, typeof(MultiLineItemFitMode), this.strip.MultiLineItemFitMode);

            this.spacingSpin.Value = this.strip.ItemSpacing;

            foreach (RadPageViewPage page in this.radPageView1.Pages)
            {
                page.Image = PageViewImages.Images[this.imageIndex++];
                page.Controls.Add(PageViewLabels.CreateLabel(this.radPageView1.RootElement.DpiScaleFactor));
            }

            this.radPageView1.NewPageRequested += radPageView1_NewPageRequested;
        }

        protected override void OnLoad(EventArgs e)
        {
            this.radPageView1.Location = Point.Empty;

            base.OnLoad(e);
        }

        #endregion

        #region Event Handlers

        private void radPageView1_NewPageRequested(object sender, EventArgs e)
        {
            this.addPageButton_Click(null, EventArgs.Empty);
        }

        private void stripAlignCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = this.stripAlignCombo.SelectedItem as RadListDataItem;
            this.strip.StripAlignment = (StripViewAlignment)item.Value;
        }

        private void itemAlignCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = this.itemAlignCombo.SelectedItem as RadListDataItem;
            this.strip.ItemAlignment = (StripViewItemAlignment)item.Value;
        }

        private void fitModeCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = this.fitModeCombo.SelectedItem as RadListDataItem;
            this.strip.ItemFitMode = (StripViewItemFitMode)item.Value;
            if (this.strip.ItemFitMode != StripViewItemFitMode.MultiLine)
            {
                this.multiLineFitCombo.Enabled = false;
            }
            else 
            {
                this.multiLineFitCombo.Enabled = true;
            }
        }

        private void sizeModeCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = this.sizeModeCombo.SelectedItem as RadListDataItem;
            this.strip.ItemSizeMode = (PageViewItemSizeMode)item.Value;
        }

        private void orientationCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = this.orientationCombo.SelectedItem as RadListDataItem;
            this.strip.ItemContentOrientation = (PageViewContentOrientation)item.Value;
        }

        void multiLineFitCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = this.multiLineFitCombo.SelectedItem as RadListDataItem;
            this.strip.MultiLineItemFitMode = (MultiLineItemFitMode)item.Value;
        }

        private void spacingSpin_ValueChanged(object sender, EventArgs e)
        {
            strip.ItemSpacing = (int)this.spacingSpin.Value;
        }

        private void addPageButton_Click(object sender, EventArgs e)
        {
            RadPageViewPage page = new RadPageViewPage();
            page.Text = "Page " + (strip.Items.Count + 1);

            if(this.imageIndex == PageViewImages.Images.Length)
            {
                this.imageIndex = 0;
            }

            page.Image = PageViewImages.Images[this.imageIndex++];
            page.Controls.Add(PageViewLabels.CreateLabel(this.radPageView1.RootElement.DpiScaleFactor));

            this.radPageView1.Pages.Add(page);
        }

        #endregion

        protected override void WireEvents()
        {
            this.stripAlignCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.stripAlignCombo_SelectedIndexChanged);
            this.itemAlignCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.itemAlignCombo_SelectedIndexChanged);
            this.fitModeCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.fitModeCombo_SelectedIndexChanged);
            this.sizeModeCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.sizeModeCombo_SelectedIndexChanged);
            this.orientationCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.orientationCombo_SelectedIndexChanged);
            this.multiLineFitCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(multiLineFitCombo_SelectedIndexChanged);
            this.spacingSpin.ValueChanged += new System.EventHandler(this.spacingSpin_ValueChanged);
            this.addPageButton.Click += new System.EventHandler(this.addPageButton_Click);
        }
    }
}
