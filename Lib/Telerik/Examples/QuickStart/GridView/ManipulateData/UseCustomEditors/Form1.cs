using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.ManipulateData.UseCustomEditors
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.SelectedControl = this.radGridView1;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            string imagesPath = Path.Combine(Application.StartupPath, @"..\GridView\ManipulateData\UseCustomEditors\Images");
            string[] images = Directory.GetFiles(imagesPath, "*.jpg");

            Random r = new Random();
            DataTable table = new DataTable();

            table.Columns.Add("Image", typeof(Image));
            table.Columns.Add("FileName", typeof(string));
            table.Columns.Add("Opacity", typeof(int));

            for (int i = 0; i < images.Length; i++)
            {
                table.Rows.Add(Image.FromFile(images[i]), images[i], r.Next(100));
            }

            this.radGridView1.TableElement.BeginUpdate();

            this.radGridView1.DataSource = table;
            this.radGridView1.TableElement.RowHeight = 89;
            this.radGridView1.Columns[0].Width = 120;
            this.radGridView1.Columns[0].MaxWidth = 120;
            this.radGridView1.Columns[1].Width = 500;
            this.radGridView1.Columns[2].Width = 200;
            this.radGridView1.Columns[2].FormatString = "{0} %";

            this.radGridView1.TableElement.EndUpdate();
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.ValueChanged += new EventHandler(radGridView1_ValueChanged);
        }

        // use this event to replace the default editor for a specific cell
        private void radGridView1_EditorRequired(object sender, EditorRequiredEventArgs e)
        {
            if (e.EditorType == typeof(GridSpinEditor) && !this.radGridView1.Columns[0].IsCurrent)
            {
                e.EditorType = typeof(TrackBarEditor);
            }
            else if (e.EditorType == typeof(RadTextBoxEditor))
            {
                e.EditorType = typeof(BrowseEditor);
            }
        }

        // use the event to customize the cell appearance
        private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement is GridImageCellElement)
            {
                object opacityValue = e.CellElement.RowInfo.Cells["Opacity"].Value;
                int opacity = 0;

                if (opacityValue != null && !Convert.IsDBNull(opacityValue))
                {
                    opacity = Convert.ToInt32(opacityValue);
                }

                e.CellElement.ImageOpacity = (double)(opacity / 100.0);
                e.CellElement.ImageLayout = ImageLayout.Zoom;
            }
        }

        // Fires when the cell changes its value
        private void radGridView1_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            GridViewDataColumn column = e.Column as GridViewDataColumn;
            if (column != null && column.FieldName == "FileName")
            {
                object value = null;

                if (e.Value != null && !Convert.IsDBNull(e.Value))
                {
                    value = Image.FromFile(e.Value.ToString());
                }

                this.radGridView1.CurrentRow.Cells["Image"].Value = value;
            }
        }

        // Fires when the editor changes its value. The value is stored only inside the editor.
        void radGridView1_ValueChanged(object sender, EventArgs e)
        {
            TrackBarEditor editor = sender as TrackBarEditor;

            if (editor != null)
            {
                GridCellElement cell = this.radGridView1.TableElement.GetCellElement(this.radGridView1.CurrentRow, this.radGridView1.Columns["Opacity"]);

                if (cell != null)
                {
                    cell.Text = editor.Value + " %";
                }

                GridCellElement imageCell = this.radGridView1.TableElement.GetCellElement(this.radGridView1.CurrentRow, this.radGridView1.Columns["Image"]);

                if (imageCell != null)
                {
                    imageCell.ImageOpacity = (double)((float)editor.Value / 100.0);
                }
            }
        }

        protected override void WireEvents()
        {
            this.radGridView1.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView1_CellFormatting);
            this.radGridView1.EditorRequired += new Telerik.WinControls.UI.EditorRequiredEventHandler(this.radGridView1_EditorRequired);
            this.radGridView1.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellValueChanged);
        }
    }
}
