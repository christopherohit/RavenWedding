using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.ChartView.NullValues
{
    enum SeriesType
    {
        Line,
        Bar,
        Spline,
        Area,
        SplineArea
    }

    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        ExampleData exampleData;

        TileGroupElement group;
        RadTileElement winsTile;
        RadTileElement drawsTile;
        RadTileElement lossesTile;

        Font segoe21Font = new Font("Segoe UI", 21);

        public Form1()
        {
            InitializeComponent();

            exampleData = new ExampleData();

            radCheckBox1.CheckStateChanged += radCheckBox1_CheckStateChanged;

            radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radDropDownList1.SelectedIndexChanged += radDropDownList1_SelectedIndexChanged;
            radDropDownList1.DataSource = Enum.GetValues(typeof(SeriesType));

            SetupRadPanorama();
            SetupRadListView();
            SetupButtons();
            SetupRadChartView();
        }

        private void SetupRadChartView()
        {
            CartesianArea area = this.radChartView1.GetArea<CartesianArea>();
            area.ShowGrid = true;
            area.GridDesign.DrawVerticalStripes = false;

            CategoricalAxis axis1 = radChartView1.Axes[0] as CategoricalAxis;
            axis1.LabelFitMode = AxisLabelFitMode.Rotate;
            axis1.LabelRotationAngle = 315;
            axis1.ClipLabels = false;

            radChartView1.Axes[1].Title = "POINTS";
            this.radChartView1.Area.View.Palette = KnownPalette.Metro;
            this.radChartView1.View.Margin = new Padding(5);
            radChartView1.LabelFormatting += radChartView1_LabelFormatting;
        }

        private void SetupButtons()
        {
            leftButton.ButtonElement.TextOrientation = Orientation.Vertical;
            rightButton.ButtonElement.TextOrientation = Orientation.Vertical;
            rightButton.ButtonElement.FlipText = true;
        }

        private void SetupRadPanorama()
        {
            radPanorama1.ShowGroups = true;
            radPanorama1.PanelImage = null;
            radPanorama1.AllowDragDrop = false;
            radPanorama1.PanoramaElement.BackColor = Color.White;
            radPanorama1.PanoramaElement.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            radPanorama1.ScrollBarThickness = 15;

            group = new TileGroupElement();
            group.CellSize = new System.Drawing.Size(120, 120);
            group.Margin = Padding.Empty;
            group.Font = segoe21Font;
            group.ForeColor = Color.FromArgb(64, 64, 64);
            group.RowsCount = 2;
            radPanorama1.Groups.Add(group);

            winsTile = new RadTileElement();
            winsTile.Font = segoe21Font;
            winsTile.TextImageRelation = TextImageRelation.ImageBeforeText;
            winsTile.ImageLayout = ImageLayout.Zoom;
            winsTile.Image = Image.FromFile(@"..\\Resources\\SoccerTeamsLogos\\football_player.png");
            winsTile.ColSpan = 2;
            winsTile.Row = 0;
            winsTile.TextAlignment = ContentAlignment.BottomRight;
            winsTile.ImageAlignment = ContentAlignment.MiddleLeft;
            group.Items.Add(winsTile);

            drawsTile = new RadTileElement();
            drawsTile.Font = segoe21Font;
            drawsTile.Row = 1;
            drawsTile.TextAlignment = ContentAlignment.BottomRight;
            group.Items.Add(drawsTile);

            lossesTile = new RadTileElement();
            lossesTile.Font = segoe21Font;
            lossesTile.Row = 1;
            lossesTile.Column = 1;
            lossesTile.TextAlignment = ContentAlignment.BottomRight;
            group.Items.Add(lossesTile);
        }

        private void SetupRadListView()
        {
            radListView1.ItemDataBound += radListView1_ItemDataBound;
            radListView1.VisualItemFormatting += radListView1_VisualItemFormatting;
            radListView1.SelectedItemChanged += radListView1_SelectedItemChanged;
            radListView1.ListViewElement.DrawBorder = false;

            radListView1.ViewType = ListViewType.IconsView;
            radListView1.ListViewElement.ViewElement.Orientation = Orientation.Horizontal;
            radListView1.ItemSize = new Size(170, 170);
            radListView1.AllowEdit = false;
            radListView1.ItemSpacing = 15;
            radListView1.ListViewElement.ViewElement.HorizontalScrollState = ScrollState.AlwaysHide;

            radListView1.DataSource = exampleData.AccumulatedData;

            radListView1.SelectedItem = radListView1.Items[2];
        }

        private void UpdateView()
        {
            if (radListView1.SelectedItem != null && radDropDownList1.SelectedValue != null)
            {
                SeriesType seriesType = (SeriesType)Enum.Parse(typeof(SeriesType), radDropDownList1.SelectedValue.ToString());
                FootballTeam selectedTeam = (FootballTeam)radListView1.SelectedItem.DataBoundItem;

                SetupChartForTeam(selectedTeam.Stats, seriesType);
                SetupPanoramaForTeam(selectedTeam);
            }
        }

        private void SetupPanoramaForTeam(FootballTeam selectedTeam)
        {
            group.Text = selectedTeam.Name;
            winsTile.Text = selectedTeam.TotalWins + Environment.NewLine + "wins";
            drawsTile.Text = selectedTeam.TotalDraws + Environment.NewLine + "draws";
            lossesTile.Text = selectedTeam.TotalLosses + Environment.NewLine + "losses";
        }

        private void SetupChartForTeam(List<FootballTeamStats> selectedTeamStats, SeriesType seriesType)
        {
            this.radChartView1.Series.Clear();

            switch (seriesType)
            {
                case SeriesType.Bar:
                    BarSeries barSeries = new BarSeries();
                    barSeries.DataSource = selectedTeamStats;
                    barSeries.ValueMember = "Points";
                    barSeries.CategoryMember = "Season";
                    barSeries.ShowLabels = radCheckBox1.Checked;
                    this.radChartView1.Series.Add(barSeries);

                    break;
                case SeriesType.Line:
                    LineSeries lineSeries = new LineSeries();
                    lineSeries.DataSource = selectedTeamStats;
                    lineSeries.ValueMember = "Points";
                    lineSeries.CategoryMember = "Season";
                    lineSeries.ShowLabels = radCheckBox1.Checked;
                    lineSeries.PointSize = new SizeF(7, 7);
                    this.radChartView1.Series.Add(lineSeries);

                    break;
                case SeriesType.Spline:
                    LineSeries splineSeries = new LineSeries();
                    splineSeries.DataSource = selectedTeamStats;
                    splineSeries.ValueMember = "Points";
                    splineSeries.CategoryMember = "Season";
                    splineSeries.Spline = true;
                    splineSeries.ShowLabels = radCheckBox1.Checked;
                    splineSeries.PointSize = new SizeF(7, 7);
                    this.radChartView1.Series.Add(splineSeries);

                    break;
                case SeriesType.Area:
                    AreaSeries areaSeries = new AreaSeries();
                    areaSeries.DataSource = selectedTeamStats;
                    areaSeries.ValueMember = "Points";
                    areaSeries.CategoryMember = "Season";
                    areaSeries.ShowLabels = radCheckBox1.Checked;
                    this.radChartView1.Series.Add(areaSeries);

                    break;
                case SeriesType.SplineArea:
                    AreaSeries splineAreaSeries = new AreaSeries();
                    splineAreaSeries.DataSource = selectedTeamStats;
                    splineAreaSeries.ValueMember = "Points";
                    splineAreaSeries.CategoryMember = "Season";
                    splineAreaSeries.Spline = true;
                    splineAreaSeries.ShowLabels = radCheckBox1.Checked;
                    this.radChartView1.Series.Add(splineAreaSeries);

                    break;
            }
        }

        private void radChartView1_LabelFormatting(object sender, ChartViewLabelFormattingEventArgs e)
        {
            e.LabelElement.BackColor = Color.Transparent;
            e.LabelElement.BorderWidth = 0;
        }

        private void radListView1_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            e.VisualItem.DrawText = false;
            e.VisualItem.ImageAlignment = ContentAlignment.MiddleCenter;
        }

        private void radListView1_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            e.Item.Image = Image.FromFile((e.Item.DataBoundItem as FootballTeam).LogoPath);
        }

        private void radListView1_SelectedItemChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            UpdateView();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if (radListView1.SelectedIndex > 0)
            {
                radListView1.ListViewElement.ViewElement.Scroller.ScrollToItem(radListView1.Items[radListView1.SelectedIndex--]);
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (radListView1.SelectedIndex < radListView1.Items.Count - 1)
            {
                radListView1.ListViewElement.ViewElement.Scroller.ScrollToItem(radListView1.Items[radListView1.SelectedIndex++]);
            }
        }

        private void radCheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
            radChartView1.Series[0].ShowLabels = radCheckBox1.Checked;
        }
    }
}