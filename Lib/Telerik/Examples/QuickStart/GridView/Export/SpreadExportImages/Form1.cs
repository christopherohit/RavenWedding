using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.Export.SpreadExportImages
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.radGridView1.TableElement.RowHeight = 160;
            ExamplesForm.FillComboFromEnum(this.imageLayoutDropDownList, typeof(ImageLayout), ImageLayout.None);
            this.imageLayoutDropDownList.Items.RemoveAt(1); // Tile is not supported

            ExamplesForm.FillComboFromEnum(this.imageAlignmentDropDownList, typeof(ContentAlignment), ContentAlignment.TopLeft);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'furnitureDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.furnitureDataSet.Products);

            this.ResizeImages();
        }

        private void ResizeImages()
        {
            for (int productIndex = 0; productIndex < this.furnitureDataSet.Products.Count; productIndex++)
            {
                byte[] bytes = this.furnitureDataSet.Products[productIndex].Photo;

                object result = null;
                RadDataConverter.Instance.TryFormat(bytes, typeof(Image), this.radGridView1.Columns["Photo"], out result);
                Image image = result as Image;
                if (image != null)
                {
                    image = new Bitmap(image, new Size(200, 150));
                    bytes = GridExportUtils.ConvertImageToByteArray(image);
                    this.furnitureDataSet.Products[productIndex].Photo = bytes;
                }
            }
        }

        private void imageLayoutDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radGridView1.BeginUpdate();
            this.radGridView1.Columns["Photo"].ImageLayout = (ImageLayout)this.imageLayoutDropDownList.SelectedValue;
            this.imageAlignmentDropDownList.Enabled = this.radGridView1.Columns["Photo"].ImageLayout == ImageLayout.None;
            this.radGridView1.EndUpdate(true);
        }

        private void imageAlignmentDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radGridView1.BeginUpdate();
            (this.radGridView1.Columns["Photo"] as GridViewImageColumn).ImageAlignment = (ContentAlignment)this.imageAlignmentDropDownList.SelectedValue;
            this.radGridView1.EndUpdate(true);
        }

        private void exportButton_Click(object sender, EventArgs e)
        {            
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel (*.xls)|*.xlsx";
            saveDialog.FileName = "exportedFile";
            if (saveDialog.ShowDialog(this) == DialogResult.OK)
            {
                GridViewSpreadExport spreadExport = new GridViewSpreadExport(this.radGridView1);
                spreadExport.ExportVisualSettings = true;
                spreadExport.RunExport(saveDialog.FileName, new SpreadExportRenderer());
            }
        }
    }
}
