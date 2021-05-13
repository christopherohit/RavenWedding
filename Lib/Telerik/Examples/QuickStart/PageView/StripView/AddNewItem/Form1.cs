using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.PageView.StripView.AddNewItem
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
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.strip = this.radPageView1.ViewElement as RadPageViewStripElement;

            for (int i = 0; i < 5; i++)
            {
                RadPageViewPage page = new RadPageViewPage();
                page.Text = PageViewImages.Names[i];
                page.Image = PageViewImages.Images[i];

                this.radPageView1.Pages.Add(page);
            }

            this.radPageView1.NewPageRequested += radPageView1_NewPageRequested;

            this.newItemVisibilityCombo.DataSource = Enum.GetValues(typeof(StripViewNewItemVisibility));
            this.stripAlignCombo.DataSource = Enum.GetValues(typeof(StripViewAlignment));

            this.newItemVisibilityCombo.SelectedValue = StripViewNewItemVisibility.End;
            this.stripAlignCombo.SelectedValue = this.strip.StripAlignment;
           
            this.shrinkItemsCheck.Checked = false;
        }

        #endregion

        #region Event Handlers

        private void radPageView1_NewPageRequested(object sender, EventArgs e)
        {
            RadPageViewPage page = new RadPageViewPage();
            page.Text = "Page " + (strip.Items.Count + 1);

            if (this.imageIndex == PageViewImages.Images.Length)
            {
                this.imageIndex = 0;
            }

            page.Image = PageViewImages.Images[this.imageIndex++];
            page.Controls.Add(PageViewLabels.CreateLabel(this.radPageView1.RootElement.DpiScaleFactor));

            this.radPageView1.Pages.Add(page);
            this.radPageView1.SelectedPage = page;
            this.radPageView1.ViewElement.EnsureItemVisible(this.strip.NewItem);
        }

        private void newItemVisibilityCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (e.Position != -1)
            {
                this.strip.NewItemVisibility = (StripViewNewItemVisibility)this.newItemVisibilityCombo.SelectedValue;
            }
        }

        private void stripAlignCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (e.Position != -1)
            {
                this.strip.StripAlignment = (StripViewAlignment)this.stripAlignCombo.SelectedValue;
            }
        }

        private void shrinkItemsCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.strip.ItemFitMode = this.shrinkItemsCheck.Checked ? StripViewItemFitMode.Shrink : StripViewItemFitMode.None;
        }

        #endregion

        protected override void WireEvents()
        {
            this.stripAlignCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.stripAlignCombo_SelectedIndexChanged);
            this.newItemVisibilityCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.newItemVisibilityCombo_SelectedIndexChanged);
            this.shrinkItemsCheck.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.shrinkItemsCheck_ToggleStateChanged);
        }
    }
}
