using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;
using Telerik.Charting;
using Telerik.Charting.Styles;

namespace Telerik.Examples.WinControls.PageView.StripView.StripButtons
{
    /// <summary>
    /// Example beautifying 
    /// </summary>
    public partial class Form1 : ExamplesForm
    {
        #region Fields

        private RadPageViewStripElement strip;
        private static string[] ChartSkins = new string[] { 
        "Default", "Blue", "Brick", "Classic", "Colorful", "ExcelClassic", "Gradient", "Green", "Pastel", "Web", "Office2007", "BabyBlue", "BlueStripes", "DeepBlue", "DeepGreen", "DeepGray", 
        "DeepRed", "GreenStripes", "GrayStripes", "LightBlue", "LightBrown", "LightGreen", "UltraGreen", "Vista", "Black", "Default2006", "Mac", "Inox", "Outlook", "Web20", "Telerik", "WebBlue", 
        "Desert", "Hay", "Marble", "Metal", "Wood", "Sunset", "Gray", "SkyBlue", "Forest"
     };


        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radPageView1.PageRemoved += radPageView1_PageRemoved;
            this.radPageView1.SelectedPageChanged += radPageView1_SelectedPageChanged;

            this.strip = this.radPageView1.ViewElement as RadPageViewStripElement;
            this.strip.StripButtons = StripViewButtons.All;
            this.animatedScrollingCheck.Checked = this.strip.AnimatedStripScrolling;

            this.PopulatePages();
            this.PopulateDropDownLists();
        }

        private void PopulateDropDownLists()
        {
            List<StripViewButtons> buttons = new List<StripViewButtons>();
            foreach (StripViewButtons button in Enum.GetValues(typeof(StripViewButtons)))
            {
                buttons.Add(button);
            }
            this.stripButtonsCombo.DataSource = buttons;
            this.stripButtonsCombo.SelectedValue = this.strip.StripButtons;

            this.selectedPageCombo.DisplayMember = "Text";
            this.selectedPageCombo.DataSource = this.radPageView1.Pages;
            this.selectedPageCombo.SelectedValue = this.radPageView1.SelectedPage;
        }

        private void PopulatePages()
        {
            int skinIndex = 0;
            foreach (ChartSeriesType seriesType in Enum.GetValues(typeof(ChartSeriesType)))
            {
                RadPageViewPage page = new RadPageViewPage();
                page.Text = seriesType.ToString();

#pragma warning disable 618
                RadChart chart = new RadChart();
                chart.DefaultType = seriesType;
                chart.Dock = DockStyle.Fill;
                chart.Skin = ChartSkins[skinIndex++];
                chart.SkinsOverrideStyles = true;

                Telerik.Charting.ChartSeries series = new Telerik.Charting.ChartSeries("StripMode");
                series.AddItem(10, series.Name);
                chart.Series.Add(series);

                series = new Telerik.Charting.ChartSeries("StackMode");
                series.AddItem(20, series.Name);
                chart.Series.Add(series);

                series = new Telerik.Charting.ChartSeries("OutlookMode");
                series.AddItem(30, series.Name);
                chart.Series.Add(series);

                page.Controls.Add(chart);
                this.radPageView1.Pages.Add(page);
            }
        }

        #endregion

        #region Event Handlers

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            this.selectedPageCombo.SelectedValue = this.radPageView1.SelectedPage;
        }

        private void radPageView1_PageRemoved(object sender, RadPageViewEventArgs e)
        {
            this.selectedPageCombo.DataSource = null;
            this.selectedPageCombo.DataSource = this.radPageView1.Pages;
            this.selectedPageCombo.DisplayMember = "Text";
            this.selectedPageCombo.SelectedValue = this.radPageView1.SelectedPage;
        }

        private void animatedScrollingCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.strip.AnimatedStripScrolling = this.animatedScrollingCheck.Checked;
        }

        private void stripButtonsCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.stripButtonsCombo.SelectedValue != null)
            {
                this.strip.StripButtons = (StripViewButtons)this.stripButtonsCombo.SelectedValue;
            }
        }

        private void selectedPageCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.selectedPageCombo.SelectedValue != null)
            {
                this.radPageView1.SelectedPage = (RadPageViewPage)this.selectedPageCombo.SelectedValue;
            }
        }

        #endregion

        protected override void WireEvents()
        {
            this.animatedScrollingCheck.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.animatedScrollingCheck_ToggleStateChanged);
            this.stripButtonsCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.stripButtonsCombo_SelectedIndexChanged);
            this.selectedPageCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.selectedPageCombo_SelectedIndexChanged);
        }
    }
}
