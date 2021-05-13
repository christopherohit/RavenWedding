using System;
using System.Drawing;
using System.IO;
using Telerik.Examples.WinControls.DataSources;
using Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.VirtualGrid.Editors
{
    public partial class Form1 : ExamplesForm
    {
        NorthwindDataSet set = new NorthwindDataSet();
        private string[] columns;
        private string[] fields;
        private Color[] colors;
        private string[] filePaths;
        private int[] opacities;

        public Form1()
        {
            InitializeComponent();

            this.radVirtualGrid1.TableElement.ColumnWidth = 150;
            this.radVirtualGrid1.TableElement.RowHeight = 80;

            EmployeesTableAdapter employees = new EmployeesTableAdapter();
            employees.Fill(set.Employees);

            this.columns = new string[] { "Decimal", "Text", "Image", "LookUp", "Date", "Color", "Browse", "Custom" };
            this.fields = new string[] { "EmployeeID", "LastName", "Photo", "TitleOfCourtesy", "HireDate" };
            this.colors = new Color[] { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet, Color.White, Color.Black };
            this.filePaths = new string[] {
                @"C:\Music\Sting\If You Love Somebody Set Them Free.wav",
                @"C:\Music\Sting\Russians.wav",
                @"C:\Music\Sting\Fortress Around Your Heart.wav",
                @"C:\Music\Sting\Love Is the Seventh Wave.wav",
                @"C:\Music\Sheryl Crow\Run, Baby, Run.wav",
                @"C:\Music\Sheryl Crow\Leaving Las Vegas.wav",
                @"C:\Music\Sheryl Crow\Strong Enough.wav",
                @"C:\Music\Sheryl Crow\Maybe Angels.wav",
                @"C:\Music\Sheryl Crow\A Change Would Do You Good.wav"
            };

            this.opacities = new int[] { 100, 75, 100, 75, 20, 50, 75, 10, 75 };

            this.radVirtualGrid1.ColumnCount = this.columns.Length;
            this.radVirtualGrid1.RowCount = set.Employees.Rows.Count;
            this.radVirtualGrid1.VirtualGridElement.SetColumnWidth(75, 0, 1, 2);
            this.radVirtualGrid1.AllowAddNewRow = false;

            this.radVirtualGrid1.CellFormatting += radVirtualGrid1_CellFormatting;
            this.radVirtualGrid1.CellValueNeeded += radVirtualGrid1_CellValueNeeded;
            this.radVirtualGrid1.CellValuePushed += radVirtualGrid1_CellValuePushed;
            this.radVirtualGrid1.EditorRequired += radVirtualGrid1_EditorRequired;
        }

        private void radVirtualGrid1_EditorRequired(object sender, VirtualGridEditorRequiredEventArgs e)
        {
            string columnName = this.columns[e.ColumnIndex];

            switch (columnName)
            {
                case "Decimal":
                    e.Editor = new VirtualGridSpinEditor();
                    break;
                case "Text":
                    e.Editor = new VirtualGridTextBoxEditor();                    
                    break;
                case "LookUp":
                    VirtualGridDropDownListEditor ddl = new VirtualGridDropDownListEditor();
                    RadDropDownListEditorElement element = ddl.EditorElement as RadDropDownListEditorElement;
                    element.DataSource = new string[] { "Mr.", "Mrs.", "Ms.", "Dr." };
                    e.Editor = ddl;
                    break;
                case "Color":
                    e.Editor = new VirtualGridColorPickerEditor();
                    break;
                case "Date":
                    e.Editor = new VirtualGridDateTimeEditor();
                    break;
                case "Browse":
                    e.Editor = new VirtualGridBrowseEditor();
                    break;
                case "Custom":
                    e.Editor = new VirtualGridTrackBarEditor();
                    break;
                case "Image":
                    e.Cancel = true;
                    break;
            }
        }

        private void radVirtualGrid1_CellFormatting(object sender, VirtualGridCellElementEventArgs e)
        {
            if (e.CellElement.RowIndex < 0 || e.CellElement.ColumnIndex < 0)
            {
                return;
            }

            string columnName = this.columns[e.CellElement.ColumnIndex];

            switch (columnName)
            {
                case "Date":
                    if (e.CellElement.Value != null && e.CellElement.Value != DBNull.Value)
                    {
                        e.CellElement.Text = ((DateTime)e.CellElement.Value).ToLongDateString();
                    }

                    e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
                    break;
                case "Image":
                    ImageConverter converter = new ImageConverter();
                    object result = converter.ConvertFrom(e.CellElement.Value);
                    e.CellElement.Image = result as Image;
                    e.CellElement.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    e.CellElement.Text = String.Empty;
                    e.CellElement.ImageOpacity = ((double)this.opacities[e.CellElement.RowIndex] / 100.0);
                    break;
                case "Decimal":
                    e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
                    break;
                case "Custom":
                    e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
                    e.CellElement.Text = string.Format("{0} %", e.CellElement.Value);
                    break;
                case "Text":
                case "LookUp":
                case "Color":
                case "Browse":
                    e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
                    break;
            }

            if (columnName != "Image")
            {
                e.CellElement.ResetValue(LightVisualElement.ImageProperty, Telerik.WinControls.ValueResetFlags.Local);
            }
        }

        private void radVirtualGrid1_CellValueNeeded(object sender, VirtualGridCellValueNeededEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }

            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = this.columns[e.ColumnIndex];
            }

            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex < this.fields.Length)
            {
                e.Value = this.set.Employees.Rows[e.RowIndex][this.fields[e.ColumnIndex]];
            }
            else if (this.columns[e.ColumnIndex] == "Color")
            {
                e.Value = this.colors[e.RowIndex];
            }
            else if (this.columns[e.ColumnIndex] == "Browse")
	        {
                e.Value = this.filePaths[e.RowIndex];
            }
            else if (this.columns[e.ColumnIndex] == "Custom")
            {
                e.Value = this.opacities[e.RowIndex];
            }
        }

        private void radVirtualGrid1_CellValuePushed(object sender, VirtualGridCellValuePushedEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < this.fields.Length)
                {
                    this.set.Employees.Rows[e.RowIndex][this.fields[e.ColumnIndex]] = e.Value;
                }
                else if (this.columns[e.ColumnIndex] == "Color")
                {
                    this.colors[e.RowIndex] = (Color)e.Value;
                }
                else if (this.columns[e.ColumnIndex] == "Browse")
                {
                    this.filePaths[e.RowIndex] = Convert.ToString(e.Value);
                }
                else if (this.columns[e.ColumnIndex] == "Custom")
                {
                    this.opacities[e.RowIndex] = Convert.ToInt32(e.Value);
                }
            }
            catch (Exception)
            {
                //Indicate error
            }
        }
    }
}
