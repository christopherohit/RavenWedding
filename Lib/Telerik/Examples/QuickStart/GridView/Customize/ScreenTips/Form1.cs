using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Reflection;
using System.IO;
//using Telerik.WinControls.UI.Export;

namespace Telerik.Examples.WinControls.GridView.Customize.ScreenTips
{
    public partial class Form1 : ExamplesForm
    {
        private Assembly executingAssembly;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;
            this.radGridView1.EnableFiltering = false;
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            this.radGridView1.ScreenTipNeeded += new Telerik.WinControls.ScreenTipNeededEventHandler(radGridView1_ScreenTipNeeded);
            this.radGridView1.TableElement.RowHeight = 60;
            this.radGridView1.TableElement.TableHeaderHeight = 35;

            this.BindGrid();

            this.radGridView1.CurrentRow = this.radGridView1.Rows[0];
        }

        private void BindGrid()
        {
            GridViewImageColumn imageColumn = new GridViewImageColumn("CarPicture");
            imageColumn.ImageLayout = ImageLayout.Zoom;
            imageColumn.MaxWidth = 80;
            imageColumn.MinWidth = 80;
            imageColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter;
            imageColumn.HeaderText = "Car Picture";
            
            GridViewTextBoxColumn carNameColumn = new GridViewTextBoxColumn("CarName");
            carNameColumn.Width = 300;
            carNameColumn.HeaderText = "Car";
            carNameColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter;

            GridViewDecimalColumn priceColumn = new GridViewDecimalColumn("Price");
            priceColumn.HeaderText = "Price";
            priceColumn.Width = 100;
            priceColumn.FormatString = "${0:N0}";
            priceColumn.TextAlignment = ContentAlignment.MiddleRight;
            priceColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter;

            GridViewDecimalColumn maxSpeedColumn = new GridViewDecimalColumn("MaxSpeed");
            maxSpeedColumn.TextAlignment = ContentAlignment.MiddleRight;
            maxSpeedColumn.HeaderText = "Max Speed";
            maxSpeedColumn.FormatString = "{0} mph";
            maxSpeedColumn.Width = 100;
            maxSpeedColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter;

            GridViewTextBoxColumn companyColumn = new GridViewTextBoxColumn("CompanyName");
            companyColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter;
            companyColumn.HeaderText = "Manufacturer";
            companyColumn.Width = 300;

            this.radGridView1.Columns.Add(imageColumn);
            this.radGridView1.Columns.Add(carNameColumn);
            this.radGridView1.Columns.Add(companyColumn);
            this.radGridView1.Columns.Add(priceColumn);
            this.radGridView1.Columns.Add(maxSpeedColumn);

            radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            this.radGridView1.DataSource = CreateDataTable();
        }
       
        private DataTable CreateDataTable()
        {
            DataTable table = new DataTable("Cars");

            table.Columns.Add("CarID", typeof(int));
            table.Columns.Add("CarPicture", typeof(Image));
            table.Columns.Add("CarName", typeof(string));
            table.Columns.Add("MaxSpeed", typeof(int));
            table.Columns.Add("Acceleration", typeof(string));
            table.Columns.Add("HorsePower", typeof(string));
            table.Columns.Add("Price", typeof(double));
            table.Columns.Add("CompanyName", typeof(string));

            table.Rows.Add(1, this.GetImageFromResource("SSC Ultimate Aero.png"),
                "SSC Ultimate Aero", 257, 2.7f, "1,183", 654400, "America’s Shelby Supercars");
            table.Rows.Add(2, this.GetImageFromResource("Bugatti Veyron.png"),
                "Bugatti Veyron", 253, 2.5f, "1,001", 1148600, "Bugatti Automobiles SAS");
            table.Rows.Add(3, this.GetImageFromResource("Koenigsegg CCX.png"),
                "Koenigsegg CCX", 250, 3.2f, 806, 695000, "Koenigsegg");
            table.Rows.Add(4, this.GetImageFromResource("Saleen S7 Twin-Turbo.png"),
                "Saleen S7 Twin-Turbo", 248, 3.2f, 750, 555000, "Saleen, Hidden Creek Industries");
            table.Rows.Add(5, this.GetImageFromResource("McLaren F1.png"),
                "McLaren F1", 240, 3.2f, 627, 970000, "McLaren Automotive");
            table.Rows.Add(6, this.GetImageFromResource("Ferrari Enzo.png"),
                "Ferrari Enzo", 217, 3.4f, 660, 670000, "Ferrari");
            table.Rows.Add(7, this.GetImageFromResource("Jaguar XJ220.png"),
                "Jaguar XJ220", 217, 4.0f, 542, 345000, "Jaguar");
            table.Rows.Add(8, this.GetImageFromResource("Pagani Zonda F.png"),
                "Pagani Zonda F", 215, 3.5f, 650, 741000, "Pagani");
            table.Rows.Add(9, this.GetImageFromResource("Lamborghini Murcielago LP640.png"),
                "Lamborghini Murcielago LP640", 213, 3.3f, 640, 430000, "Lamborghini");
            table.Rows.Add(10, this.GetImageFromResource("Porsche Carrera GT.png"),
                "Porsche Carrera GT", 209, 3.9f, 612, 440000, "Porsche AG");

            return table;
        }

        private Image GetImageFromResource(string imageFileName)
        {
            Image img;
            Stream imageStream;

            if (executingAssembly == null)
            {
                this.executingAssembly = Assembly.GetExecutingAssembly();
            }

            imageStream = this.executingAssembly.GetManifestResourceStream(
                String.Format("Telerik.Examples.WinControls.Resources.CarPictures.{0}", imageFileName));
            img = Bitmap.FromStream(imageStream);

            if (img == null)
            {
                imageStream = this.executingAssembly.GetManifestResourceStream(
                String.Format(imageFileName));
                img = Bitmap.FromStream(imageStream);
            }

            return img;
        }

        private void ShowScreenTipForCell(GridDataCellElement cell)
        {
            DataRowView row = (DataRowView)cell.RowInfo.DataBoundItem;

            RadOffice2007ScreenTipElement screenTip = new RadOffice2007ScreenTipElement();
            screenTip.CaptionLabel.Margin = new Padding(3);

            Image carImage = (Image)row["CarPicture"];
            screenTip.MainTextLabel.Image = carImage;
            screenTip.MainTextLabel.ImageAlignment = ContentAlignment.MiddleCenter;
            //screenTip.MainTextLabel.Margin = new Padding(1, 0, 1, 0);
            //screenTip.MainTextLabel.Padding = new Padding(0, 0, 0, 3);

            String text =
                String.Format("<html><b>MaxSpeed:</b> {0}mph<br><b>Acceleration 0-62mph:</b> {1}sec<br><b>Horse Power:</b> {2} bhp",
                    row["MaxSpeed"], row["Acceleration"], row["HorsePower"]);
            screenTip.CaptionLabel.Text = text;

            screenTip.MainTextLabel.Text = string.Empty;
            screenTip.EnableCustomSize = false;

            cell.ScreenTip = screenTip;
        }

        #region Event handling

        private void radGridView1_ScreenTipNeeded(object sender, Telerik.WinControls.ScreenTipNeededEventArgs e)
        {
            GridDataCellElement cell = e.Item as GridDataCellElement;

            if (cell != null)
            {
                this.ShowScreenTipForCell(cell);
            }
        }

        private void OnRadGridViewDemo_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.RowElement.RowInfo is GridViewTableHeaderRowInfo)
            {
                if (e.CellElement.ColumnIndex == 0)
                {
                    e.CellElement.ToolTipText = "This is a picture column";
                }
                else if (e.CellElement.ColumnIndex == 1)
                {
                    e.CellElement.ToolTipText = "This is a text column";
                }
                else if (e.CellElement.ColumnIndex == 2)
                {
                    e.CellElement.ToolTipText = "This is a text column";
                }
                else if (e.CellElement.ColumnIndex == 3)
                {
                    e.CellElement.ToolTipText = "This is a decimal column";
                }
                else if (e.CellElement.ColumnIndex == 4)
                {
                    e.CellElement.ToolTipText = "This is a decimal column";
                }
            }
        }

        #endregion

        protected override void WireEvents()
        {
            this.radGridView1.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.OnRadGridViewDemo_ViewCellFormatting);
        }
    }
}
