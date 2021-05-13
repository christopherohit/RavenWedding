using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Tests;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.ChartView.TitleAndLegend
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private CustomShape customShape;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radChartView1.ShowTitle = true;
            this.radChartView1.ShowLegend = true;
            this.radChartView1.Title = "OS Platform Statistics Q1 2012";
            this.radTextBoxControlTitle.Text = this.radChartView1.Title;
            this.radChartView1.LegendTitle = "Legend";
            this.radChartView1.ChartElement.LegendElement.Alignment = ContentAlignment.TopCenter;
            this.radDropDownListTitlePosition.DataSource = Enum.GetValues(typeof(TitlePosition));
            this.radDropDownListLegendPosition.DataSource = Enum.GetValues(typeof(LegendPosition));

            DataSet set = new DataSet();

            DataTable windowsXPTable = new DataTable("WindowsXP");
            DataTable windows7Table = new DataTable("Windows7");
            DataTable linuxTable = new DataTable("Linux");
            DataTable macTable = new DataTable("Mac");

            set.Tables.Add(windowsXPTable);
            set.Tables.Add(windows7Table);
            set.Tables.Add(linuxTable);
            set.Tables.Add(macTable);

            foreach (DataTable table in set.Tables)
            {
                table.Columns.Add("Month");
                table.Columns.Add("Usage", typeof(double));
            }

            windowsXPTable.Rows.Add("January", 31.4);
            windowsXPTable.Rows.Add("February", 24.0);
            windowsXPTable.Rows.Add("March", 18.9);

            windows7Table.Rows.Add("January", 27.1);
            windows7Table.Rows.Add("February", 35.7);
            windows7Table.Rows.Add("March", 43.9);

            linuxTable.Rows.Add("January", 6.9);
            linuxTable.Rows.Add("February", 13.0);
            linuxTable.Rows.Add("March", 8.9);

            macTable.Rows.Add("January", 8.0);
            macTable.Rows.Add("February", 12.1);
            macTable.Rows.Add("March", 9.9);

            this.radChartView1.DataSource = set;

            BarSeries windowsXPSeries = new BarSeries("Usage", "Month");
            windowsXPSeries.DataMember = "WindowsXP";
            windowsXPSeries.LegendTitle = "Windows XP";
            BarSeries windows7Series = new BarSeries("Usage", "Month");
            windows7Series.DataMember = "Windows7";
            windows7Series.LegendTitle = "Windows 7";
            BarSeries linuxSeries = new BarSeries("Usage", "Month");
            linuxSeries.DataMember = "Linux";
            linuxSeries.LegendTitle = "Linux";
            BarSeries macSeries = new BarSeries("Usage", "Month");
            macSeries.DataMember = "Mac";
            macSeries.LegendTitle = "Mac";

            this.radChartView1.Series.AddRange(windowsXPSeries, windows7Series, linuxSeries, macSeries);

            this.customShape = new CustomShape();
            this.customShape.CreateClosedShape(CreateInitialShape(5, 100, 60));

            RadListDataItem item = new RadListDataItem("CustomShape");
            item.Value = typeof(CustomShape);
            this.radDropDownListShapes.Items.Add(item);
            item = new RadListDataItem("RectangleShape");
            item.Value = typeof(RoundRectShape);
            this.radDropDownListShapes.Items.Add(item);
            item = new RadListDataItem("RoundRectShape");
            item.Value = typeof(RoundRectShape);
            this.radDropDownListShapes.Items.Add(item);
            item = new RadListDataItem("EllipseShape");
            item.Value = typeof(EllipseShape);
            this.radDropDownListShapes.Items.Add(item);
            item = new RadListDataItem("DonutShape");
            item.Value = typeof(DonutShape);
            this.radDropDownListShapes.Items.Add(item);
            this.radDropDownListShapes.SelectedIndex = 1;

            this.radChartView1.Controllers.Add(new LassoZoomController());
            //this.radChartView1.Controllers.Add(new ChartSelectionController());
        }

        private List<PointF> CreateInitialShape(int vertices, double radius1, double radius2)
        {
            List<PointF> pts = new List<PointF>();

            for (int i = 0; i < vertices; i++)
            {
                double angle1 = ((4.0 * i - vertices) * Math.PI) / (2.0f * vertices);
                double angle2 = ((4.0 * i - vertices + 2) * Math.PI) / (2.0f * vertices);
                pts.Add(new PointF((float)(Math.Cos(angle1) * radius1), (float)(Math.Sin(angle1) * radius1)));
                pts.Add(new PointF((float)(Math.Cos(angle2) * radius2), (float)(Math.Sin(angle2) * radius2)));
            }

            return pts;
        }

        private void ApplyShapeToPoints(ElementShape shape)
        {
            foreach (LegendItemElement legendItem in this.radChartView1.ChartElement.LegendElement.StackElement.Children)
            {
                legendItem.MarkerElement.Shape = shape;
            }
        }

        private void radDropDownListTitlePosition_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radChartView1.ChartElement.TitlePosition = (TitlePosition)this.radDropDownListTitlePosition.SelectedValue;
        }

        private void radRadioButtonTitleOrientation_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (sender == this.radRadioButtonHorizontalTitle)
            {
                if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                {
                    this.radChartView1.ChartElement.TitleElement.TextOrientation = Orientation.Horizontal;
                }
                else
                {
                    this.radChartView1.ChartElement.TitleElement.TextOrientation = Orientation.Vertical;
                }
            }
        }

        private void radDropDownListLegendPosition_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            LegendPosition position = (LegendPosition)this.radDropDownListLegendPosition.SelectedValue;
            this.radChartView1.ChartElement.LegendPosition = position;

            if (position == LegendPosition.Float)
            {
                this.radSpinEditorLegendX.Enabled = true;
                this.radSpinEditorLegendY.Enabled = true;
            }
            else
            {
                this.radSpinEditorLegendX.Enabled = false;
                this.radSpinEditorLegendY.Enabled = false;
            }
        }

        private void radSpinEditorFloatingLegendPosition_ValueChanged(object sender, EventArgs e)
        {
            if (sender == this.radSpinEditorLegendX)
            {
                this.radChartView1.ChartElement.LegendOffset = new Point((int)this.radSpinEditorLegendX.Value, this.radChartView1.ChartElement.LegendOffset.Y);
            }
            else
            {
                this.radChartView1.ChartElement.LegendOffset = new Point(this.radChartView1.ChartElement.LegendOffset.X, (int)this.radSpinEditorLegendY.Value);
            }
        }

        private void radRadioButtonLegendOrientation_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (sender == this.radRadioButtonHorizontalLegend)
            {
                if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                {
                    this.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal;
                }
                else
                {
                    this.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Vertical;
                }
            }
        }

        private void radTextBoxControlTitle_TextChanged(object sender, EventArgs e)
        {
            this.radChartView1.Title = this.radTextBoxControlTitle.Text;
        }

        private void radCheckBoxFlipText_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radChartView1.ChartElement.TitleElement.FlipText = this.radCheckBoxFlipText.Checked;
            this.radChartView1.ChartElement.TitleElement.Invalidate();
        }

        private void radDropDownListMarkerShape_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (this.radDropDownListShapes.SelectedIndex)
            {
                case 0:
                    this.ApplyShapeToPoints(this.customShape);
                    this.radButtonEditShape.Enabled = true;
                    break;
                case 1:
                    this.ApplyShapeToPoints(new RoundRectShape(0));
                    this.radButtonEditShape.Enabled = false;
                    break;
                case 2:
                    this.ApplyShapeToPoints(new RoundRectShape(2));
                    this.radButtonEditShape.Enabled = false;
                    break;
                case 3:
                    this.ApplyShapeToPoints(new EllipseShape());
                    this.radButtonEditShape.Enabled = false;
                    break;
                case 4:
                    this.ApplyShapeToPoints(new DonutShape());
                    this.radButtonEditShape.Enabled = false;
                    break;
                case 5:
                    this.ApplyShapeToPoints(new TabOffice12Shape());
                    this.radButtonEditShape.Enabled = false;
                    break;
                case 6:
                    this.ApplyShapeToPoints(new TabVsShape());
                    this.radButtonEditShape.Enabled = false;
                    break;
            }
        }

        private void radButtonEditShape_Click(object sender, EventArgs e)
        {
            if (this.radDropDownListShapes.SelectedIndex == 0)
            {
                CustomShapeEditorForm editor = new CustomShapeEditorForm();
                this.customShape = editor.EditShape(this.customShape);
                this.ApplyShapeToPoints(this.customShape);
            }
        }

        protected override void WireEvents()
        {
            this.radCheckBoxFlipText.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxFlipText_ToggleStateChanged);
            this.radTextBoxControlTitle.TextChanged += new System.EventHandler(this.radTextBoxControlTitle_TextChanged);
            this.radDropDownListTitlePosition.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownListTitlePosition_SelectedIndexChanged);
            this.radRadioButtonHorizontalTitle.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonTitleOrientation_ToggleStateChanged);
            this.radRadioButtonVerticalTitle.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonTitleOrientation_ToggleStateChanged);
            this.radButtonEditShape.Click += new System.EventHandler(this.radButtonEditShape_Click);
            this.radDropDownListShapes.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownListMarkerShape_SelectedIndexChanged);
            this.radDropDownListLegendPosition.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownListLegendPosition_SelectedIndexChanged);
            this.radSpinEditorLegendX.ValueChanged += new System.EventHandler(this.radSpinEditorFloatingLegendPosition_ValueChanged);
            this.radRadioButtonVerticalLegend.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonLegendOrientation_ToggleStateChanged);
            this.radSpinEditorLegendY.ValueChanged += new System.EventHandler(this.radSpinEditorFloatingLegendPosition_ValueChanged);
            this.radRadioButtonHorizontalLegend.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonLegendOrientation_ToggleStateChanged);
        }
    }
}
