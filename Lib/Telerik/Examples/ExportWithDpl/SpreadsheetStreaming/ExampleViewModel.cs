using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.Documents.SpreadsheetStreaming;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI;

namespace ExportWithDpl.SpreadsheetStreaming
{
    public class ExampleViewModel : INotifyPropertyChanged
    {
        private static readonly int ColumnsCount = 8;

        private int exportedCellsCount;
        private double exportTime;
        private int rowIndex = -1;
        private int rowsCount;
        private SpreadStreamExportFormat selectedDocumentFormat;
        private int totalCellsCount;
        private DateTime exportStarted;
        private bool canExport;
        private long memory;
        private BindingSource data;
        private List<DocumentRow> rows;

        public ExampleViewModel()
        {
            this.data = new BindingSource();
            this.rows = new List<DocumentRow>();
            this.data.DataSource = this.rows;
            this.RowsCount = 5000;
            this.CanExport = true;

            this.AddRemoveData();
        }

        public BindingSource Data 
        {
            get { return this.data; }
        }

        public SpreadStreamExportFormat SelectedDocumentFormat
        {
            get
            {
                return this.selectedDocumentFormat;
            }
            set
            {
                if (this.selectedDocumentFormat != value)
                {
                    this.selectedDocumentFormat = value;
                    this.OnPropertyChanged("SelectedDocumentFormat");
                }
            }
        }

        public IEnumerable<SpreadStreamExportFormat> ExportFormats
        {
            get { return Enum.GetValues(typeof(SpreadStreamExportFormat)).Cast<SpreadStreamExportFormat>(); }
        }

        public int RowsCount
        {
            get
            {
                return this.rowsCount;
            }
            set
            {
                if (this.rowsCount != value)
                {
                    this.rowsCount = value;
                    this.ExportedCellsCount = 0;
                    this.TotalCellsCount = ColumnsCount * value;
                    this.AddRemoveData();
                    this.OnPropertyChanged("RowsCount");
                }
            }
        }

        public int ExportedCellsCount
        {
            get
            {
                return this.exportedCellsCount;
            }
            set
            {
                if (this.exportedCellsCount != value)
                {
                    this.exportedCellsCount = value;
                    this.OnPropertyChanged("ExportedCellsCount");
                }
            }
        }

        public int TotalCellsCount
        {
            get
            {
                return this.totalCellsCount;
            }
            set
            {
                if (this.totalCellsCount != value)
                {
                    this.totalCellsCount = value;
                    this.OnPropertyChanged("TotalCellsCount");
                }
            }
        }

        public double ExportTime
        {
            get
            {
                return this.exportTime;
            }
            set
            {
                if (this.exportTime != value)
                {
                    this.exportTime = value;
                    this.OnPropertyChanged("ExportTime");
                }
            }
        }

        public long Memory
        {
            get { return memory; }
            set
            {
                if (this.memory != value)
                {
                    this.memory = value;
                    this.OnPropertyChanged("Memory");
                }
            }
        }

        public bool CanExport
        {
            get
            {
                return this.canExport;
            }
            set
            {
                if (this.canExport != value)
                {
                    this.canExport = value;
                    this.OnPropertyChanged("CanExport");
                }
            }
        }

        private void AddRemoveData()
        {
            this.Data.SuspendBinding();

            while (this.rows.Count < this.RowsCount)
            {
                this.rows.Add(DocumentHelper.GenerateDocumentRow(rowsCount, this.rows.Count));
            }

            while (this.rows.Count > this.RowsCount)
            {
                this.rows.RemoveAt(this.rows.Count - 1);
            }

            this.Data.ResumeBinding();
            this.Data.ResetBindings(false);
        }

        public void Export(RadGridView gridToExport)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = String.Format("{0} files|*.{1}|All files (*.*)|*.*",
                this.SelectedDocumentFormat.ToString().ToLower(),
                this.SelectedDocumentFormat.ToString().ToLower());
            dialog.FileName = "GridViewSpreadStreamExport";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.CanExport = false;
                this.ExportedCellsCount = 0;
                this.ExportTime = 0;
                this.exportStarted = DateTime.Now;
                rowIndex = -1;

                GridViewSpreadStreamExport spreadStreamExport = new GridViewSpreadStreamExport(gridToExport);
                spreadStreamExport.ExportFormat = this.SelectedDocumentFormat;
                spreadStreamExport.RowCreated += spreadStreamExport_RowCreated;
                spreadStreamExport.RunExport(dialog.FileName, new SpreadStreamExportRenderer());
                this.CanExport = true;
            }
        }

        private void spreadStreamExport_RowCreated(object sender, SpreadStreamRowEventArgs e)
        {
            rowIndex += 1;

            if (rowIndex % (this.RowsCount / 100) == 0 || rowIndex == this.RowsCount - 1)
            {
                this.ExportTime = (DateTime.Now - this.exportStarted).TotalMilliseconds / 1000;
                this.ExportedCellsCount = ColumnsCount * rowIndex;
                this.Memory = GC.GetTotalMemory(false) / 1024 / 1024;
                Application.DoEvents();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
