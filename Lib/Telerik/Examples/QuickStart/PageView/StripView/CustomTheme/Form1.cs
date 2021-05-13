using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.PageView.StripView.CustomTheme
{
    public partial class Form1 : ExamplesForm
    {
        #region Fields

        private RadPageView view;
        private RadPageViewStripElement strip;

        #endregion

        #region Constructor

        public Form1()
        {
            this.view = new Telerik.WinControls.UI.RadPageView();
            this.view.Size = new Size(500, 400);
            this.view.Parent = this;
            this.view.Location = new Point(20, 20);
            this.strip = this.view.ViewElement as RadPageViewStripElement;
            this.view.SelectedPageChanged += new EventHandler(view_SelectedPageChanged);

            PageViewLabels.currIndex = 0;

            this.strip.StripButtons = StripViewButtons.Scroll | StripViewButtons.ItemList;

            InitializeComponent();

            for (int i = 0; i < 9; i++)
            {
                RadPageViewPage page = new RadPageViewPage();
                page.Text = PageViewImages.Names[i];
                page.Image = PageViewImages.Images[i];
                page.Controls.Add(PageViewLabels.CreateLabel(this.view.RootElement.DpiScaleFactor));

                this.view.Pages.Add(page);
            }

            this.enableAnimationCheck.Checked = strip.AnimatedStripScrolling;
        }

        static Form1()
        {
            ThemeResolutionService.LoadPackageResource("Telerik.Examples.WinControls.PageView.StripView.CustomTheme.StripViewCheckButtons.tssp");
        }

        #endregion

        #region Overrides

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ExamplesForm.FillComboFromEnum(this.animationTypeCombo, typeof(RadEasingType), this.strip.StripScrollingAnimation);
        }

        protected override string GetExampleDefaultTheme()
        {
            return "StripViewCheckButtons";
        }

        #endregion

        #region Event Handlers

        private void view_SelectedPageChanged(object sender, EventArgs e)
        {
            this.strip.Header.Image = this.view.SelectedPage.Image;
        }

        private void enableAnimationCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.strip.AnimatedStripScrolling = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void animationTypeCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = this.animationTypeCombo.SelectedItem as RadListDataItem;
            this.strip.StripScrollingAnimation = (RadEasingType)item.Value;
        }

        private void shrinkItemsCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.strip.ItemFitMode = StripViewItemFitMode.Shrink;
            }
            else
            {
                this.strip.ItemFitMode = StripViewItemFitMode.None;
            }
        }

        #endregion

        protected override void WireEvents()
        {
            this.enableAnimationCheck.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.enableAnimationCheck_ToggleStateChanged);
            this.animationTypeCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.animationTypeCombo_SelectedIndexChanged);
            this.shrinkItemsCheck.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.shrinkItemsCheck_ToggleStateChanged);
        }
    }
}
