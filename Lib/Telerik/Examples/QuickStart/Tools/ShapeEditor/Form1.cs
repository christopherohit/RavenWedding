using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Tests;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Tools.ShapeEditor
{
    public partial class Form1 : ExamplesForm
    {
        private ShapedForm shapedForm = new ShapedForm();

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.InitButtonPreview();

            this.radButton1.Focus();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            this.CenterControl(this.radPanel2);
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (this.radDropDownList1.SelectedIndex)
            {
                case 0:
                    this.radButton1.RootElement.Children[0].Shape = customShape1;
                    editShapeButton1.Enabled = true;
                    break;
                case 1:
                    this.radButton1.RootElement.Children[0].Shape = new RoundRectShape();
                    editShapeButton1.Enabled = false;
                    break;
                case 2:
                    this.radButton1.RootElement.Children[0].Shape = new ChamferedRectShape();
                    editShapeButton1.Enabled = false;
                    break;
                case 3:
                    this.radButton1.RootElement.Children[0].Shape = new EllipseShape();
                    editShapeButton1.Enabled = false;
                    break;
                case 4:
                    this.radButton1.RootElement.Children[0].Shape = new DonutShape();
                    editShapeButton1.Enabled = false;
                    break;
                case 5:
                    this.radButton1.RootElement.Children[0].Shape = new TabOffice12Shape();
                    editShapeButton1.Enabled = false;
                    break;
                case 6:
                    this.radButton1.RootElement.Children[0].Shape = new TabVsShape();
                    editShapeButton1.Enabled = false;
                    break;
            }
        }

        private void editShapeButton_Click(object sender, EventArgs e)
        {
            if (this.radButton1.RootElement.Children[0].Shape is CustomShape)
            {
                CustomShapeEditorForm editor = new CustomShapeEditorForm();
                this.radButton1.RootElement.Children[0].Shape = editor.EditShape(this.radButton1.RootElement.Children[0].Shape as CustomShape);
            }
        }

        private void InitButtonPreview()
        {
            customShape1.CreateClosedShape(this.CreateInitialShape(5, 100, 60));

            RadListDataItem item = new RadListDataItem("customShape1");
            item.Value = customShape1;
            radDropDownList1.Items.Add(item);
            item = new RadListDataItem("RoundRectShape");
            item.Value = typeof(RoundRectShape);
            radDropDownList1.Items.Add(item);
            item = new RadListDataItem("ChamferedRectShape");
            item.Value = typeof(ChamferedRectShape);
            radDropDownList1.Items.Add(item);
            item = new RadListDataItem("EllipseShape");
            item.Value = typeof(EllipseShape);
            radDropDownList1.Items.Add(item);
            item = new RadListDataItem("DonutShape");
            item.Value = typeof(DonutShape);
            radDropDownList1.Items.Add(item);
            item = new RadListDataItem("TabOffice12Shape");
            item.Value = typeof(TabOffice12Shape);
            radDropDownList1.Items.Add(item);
            item = new RadListDataItem("TabVsShape");
            item.Value = typeof(TabVsShape);
            radDropDownList1.Items.Add(item);
            radDropDownList1.BindingContext = this.BindingContext;
            radDropDownList1.SelectedIndex = -1;
            radDropDownList1.SelectedIndex = 0;
        }

        private List<PointF> CreateInitialShape(int vertices, double radius1, double radius2)
        {
            List<PointF> pts = new List<PointF>();

            if (radius1 == 0 || radius2 == 0)
            {
                return null;
            }

            for (int i = 0; i < vertices; i++)
            {
                double angle1 = ((4.0 * i - vertices) * Math.PI) / (2.0f * vertices);
                double angle2 = ((4.0 * i - vertices + 2) * Math.PI) / (2.0f * vertices);
                pts.Add(new PointF((float)(Math.Cos(angle1) * radius1), (float)(Math.Sin(angle1) * radius1)));
                pts.Add(new PointF((float)(Math.Cos(angle2) * radius2), (float)(Math.Sin(angle2) * radius2)));
            }
            return pts;
        }

        protected override void WireEvents()
        {
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDropDownList1_SelectedIndexChanged);
            this.editShapeButton1.Click += new EventHandler(this.editShapeButton_Click);
        }
    }
}