using System;
using System.Data;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using System.Threading;
using Telerik.WinControls.UI;
using System.Drawing;
using Telerik.WinControls.UI.Export;
using Telerik.WinControls.UI.Export.ExcelML;

namespace Telerik.Examples.WinControls.GridView.Export.ExportMLWithEvents
{
    public partial class Form1 : ExamplesForm
    {
        DataSet dataSet1;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.InitializeGridAndDataSet();
            this.radComboBox1.SelectedIndex = 0;
            this.radGridView1.ThemeNameChanged += new ThemeNameChangedEventHandler(radGridView1_ThemeNameChanged);
            RadMessageBox.Instance.ThemeName = this.radGridView1.ThemeName;
        }

        void radGridView1_ThemeNameChanged(object source, ThemeNameChangedEventArgs args)
        {
            RadMessageBox.Instance.ThemeName = args.newThemeName;
        }

        void radButton1_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            saveDialog1.Filter = "Excel (*.xls)|*.xls";

            if (saveDialog1.ShowDialog(this) == DialogResult.OK)
            {

                this.radProgressBar1.Text = "Exporting to ExcelML...";
                this.radProgressBar1.Value1 = 0;
                this.radProgressBar1.Visible = true;
                this.radGridView1.Enabled = false;
                this.radComboBox1.Enabled = false;
                this.radButton1.Enabled = false;

                Thread thread2 = new Thread(new ParameterizedThreadStart(RunExportToExcelML));
                thread2.Start(saveDialog1.FileName);
            }
        }

        private void RunExportToExcelML(object fileName)
        {
            try
            {
                ExportToExcelML exporter = new ExportToExcelML(this.radGridView1);
                exporter.ExportVisualSettings = true;
                if (this.radRadioButton1.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                {
                    exporter.SheetMaxRows = ExcelMaxRows._1048576;
                }

                exporter.ExcelCellFormatting += new ExcelCellFormattingEventHandler(exporter_ExcelCellFormatting);
                exporter.ExcelTableCreated += new ExcelTableCreatedEventHandler(exporter_ExcelTableCreated);

                exporter.RunExport(fileName.ToString());

                string text = "Export finished successfully!";
                if (this.InvokeRequired)
                {
                    this.Invoke(new EventHandler(delegate
                    {
                        RadMessageBox.Show(this, text);
                    }));
                }
                else
                {
                    RadMessageBox.Show(this, text);
                }
            }
            catch (System.IO.IOException ex)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new EventHandler(delegate
                    {
                        RadMessageBox.Show(this, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);
                    }));
                }
                else
                {
                    RadMessageBox.Show(this, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);
                }
            }
            finally
            {
                this.WorkCompleted();
            }
        }

        /// <summary>
        /// using ExcelTableCreated event for adding custom header row
        /// </summary>
        void exporter_ExcelTableCreated(object sender, ExcelTableCreatedEventArgs e)
        {
            if (e.SheetIndex == 0) //add header row only for the first excel sheet 
            {
                SingleStyleElement style = ((ExportToExcelML)sender).AddCustomExcelRow(e.ExcelTableElement, 48, "TABLE's TITLE");
                style.AlignmentElement.HorizontalAlignment = HorizontalAlignmentType.Center;
                style.AlignmentElement.VerticalAlignment = VerticalAlignmentType.Center;

                style.InteriorStyle.Pattern = InteriorPatternType.Solid;
                style.InteriorStyle.Color = Color.Red;
                style.FontStyle.Color = Color.White;
                style.FontStyle.Bold = true;
                style.FontStyle.Size = 26;
            }
        }

        /// <summary>
        /// using ExcelCellFormatting event for updating progress bar and applying custom format in excel file
        /// </summary>
        void exporter_ExcelCellFormatting(object sender, ExcelCellFormattingEventArgs e)
        {

            if (e.GridRowInfoType == typeof(GridViewDataRowInfo))
            {
                //update progress bar
                int position = (int)(100 * (double)e.GridRowIndex / (double)(this.radGridView1.RowCount - 1));
                this.UpdateProgressBar(position);

                //do some formatting
                if (e.GridColumnIndex == 3 && (int)e.ExcelCellElement.Data.DataItem < 200)
                {
                    e.ExcelStyleElement.InteriorStyle.Color = Color.Yellow;
                }
            }
        }


        void radComboBox1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            int rowCount;

            switch (this.radComboBox1.SelectedIndex)
            {
                case 1:
                    rowCount = 1000;
                    break;
                case 2:
                    rowCount = 10000;
                    break;
                case 3:
                    rowCount = 100000;
                    break;
                default:
                    rowCount = 100;
                    break;
            }

            this.radProgressBar1.Text = "Adding data to the grid...";
            this.radProgressBar1.Value1 = 0;
            this.radProgressBar1.Visible = true;

            this.radGridView1.DataSource = null;
            this.radGridView1.Enabled = false;
            this.radComboBox1.Enabled = false;
            this.radButton1.Enabled = false;           

            Thread thread = new Thread(new ParameterizedThreadStart(PopulateData));
            thread.Start(rowCount);
        }

        private void PopulateData(object rowNumber)
        {            
            this.dataSet1.Clear();

            Random rdm = new Random();

            for (int i = 1; i <= (int)rowNumber; i++)
            {
                int position = (int)(100 * ((double)i / (int)rowNumber));
                this.UpdateProgressBar(position);


                int day = rdm.Next(1, 28);
                int month = rdm.Next(1, 12);
                int year = rdm.Next(1980, 2020);

                DateTime randomDate = new DateTime(year, month, day);

                int randomNumber = rdm.Next(1, 1000);
                this.dataSet1.Tables["Table1"].Rows.Add(i, String.Format("Row Number: {0}", i), randomDate, randomNumber);                
            }

            this.WorkCompleted();
        }

        private void InitializeGridAndDataSet()
        {
            //Initialize DataSet
            DataTable table1 = new DataTable("Table1");
            table1.Columns.Add(new DataColumn("Id", typeof(Int32)));
            table1.Columns.Add(new DataColumn("Description", typeof(String)));
            table1.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            table1.Columns.Add(new DataColumn("Random", typeof(Int32)));

            this.dataSet1 = new DataSet();
            dataSet1.Tables.Add(table1);

            //Initialize RadgridView
            this.radGridView1.TableElement.BeginUpdate();

            this.radGridView1.EnableGrouping = false;
            this.radGridView1.ReadOnly = true;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;

            this.radGridView1.Columns.Add(new GridViewTextBoxColumn("Id"));
            this.radGridView1.Columns.Add(new GridViewTextBoxColumn("Description"));
            this.radGridView1.Columns.Add(new GridViewTextBoxColumn("Date"));
            this.radGridView1.Columns.Add(new GridViewTextBoxColumn("Random"));

            this.radGridView1.Columns["Id"].Width = 100;
            this.radGridView1.Columns["Id"].HeaderText = "ID";

            this.radGridView1.Columns["Description"].Width = 200;
            this.radGridView1.Columns["Description"].HeaderText = "Text Column";

            this.radGridView1.Columns["Date"].Width = 120;
            this.radGridView1.Columns["Date"].FormatString = "{0:MM/dd/yyyy}";
            this.radGridView1.Columns["Date"].HeaderText = "Random Date";

            this.radGridView1.Columns["Date"].ExcelExportType = DisplayFormatType.Custom;
            this.radGridView1.Columns["Date"].ExcelExportFormatString = "dddd, dd.MM.yyyy";

            this.radGridView1.Columns["Random"].Width = 140;
            this.radGridView1.Columns["Random"].HeaderText = "Random Number";

            this.radGridView1.TableElement.EndUpdate();
        }

        private void UpdateProgressBar(int value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler(delegate
                {
                    if (value < 100)
                    {
                        this.radProgressBar1.Value1 = value;
                    }
                    else
                    {
                        this.radProgressBar1.Value1 = 100;
                    }
                }));
            }
            else
            {
                if (value < 100)
                {
                    this.radProgressBar1.Value1 = value;
                }
                else
                {
                    this.radProgressBar1.Value1 = 100;
                }
            }
        }

        private void WorkCompleted()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler(delegate
                {
                    this.radProgressBar1.Visible = false;
                    this.radGridView1.RootElement.UpdateLayout();
                    this.radGridView1.DataSource = this.dataSet1.Tables["Table1"];
                    
                    this.radGridView1.Enabled = true;
                    this.radComboBox1.Enabled = true;
                    this.radButton1.Enabled = true;
                }));
            }
            else
            {
                this.radProgressBar1.Visible = false;

                this.radGridView1.DataSource = this.dataSet1.Tables["Table1"];
                this.radGridView1.Enabled = true;
                this.radComboBox1.Enabled = true;
                this.radButton1.Enabled = true;
            }
        }

        protected override void WireEvents()
        {
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            this.radComboBox1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radComboBox1_SelectedIndexChanged);
        }
    }
}
