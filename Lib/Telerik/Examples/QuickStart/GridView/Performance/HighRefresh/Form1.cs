using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.Performance.HighRefresh
{
    public partial class Form1 : ExamplesForm
    {
        private const int COUNT = 15;
      
        // Fields
        private int count = 0;
        private System.Windows.Forms.Timer timer;
        private int refreshCount = 0;
        private int refreshInterval = 15;
        private int iterationsPerUpdate = 3;
        private Timer refreshRateTimer;

        private MockIntegerDataSource dataSource = null;

        public Form1()
        {
            InitializeComponent();

            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowCellContextMenu = false;
            this.radGridView1.MasterTemplate.AllowDeleteRow = false;
            this.radGridView1.MasterTemplate.AllowEditRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            this.radGridView1.EnableSorting = false;
            this.radGridView1.EnableFiltering = false;
            this.radGridView1.EnableGrouping = false;

			this.SelectedControl = this.radGridView1;
            this.refreshRateTimer = new Timer(this.components);
            this.refreshRateTimer.Interval = 1000;
            this.refreshRateTimer.Tick += new EventHandler(this.OnRefreshRateTimer_Tick);
            this.refreshRateTimer.Start();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dataSource = new MockIntegerDataSource(COUNT, COUNT);

            this.radGridView1.CellValueNeeded += new GridViewCellValueEventHandler(radGridView1_CellValueNeeded);

            radGridView1.VirtualMode = true;
            radGridView1.ColumnCount = this.dataSource.Columns;
            this.radGridView1.RowCount = this.dataSource.Rows;

            for (int columnIndex = 0; columnIndex < COUNT; columnIndex++)
            {
                this.radGridView1.Columns[columnIndex].HeaderText = (columnIndex + 1).ToString();
            }

            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer.Interval = refreshInterval;
            this.timer.Tick += new EventHandler(this.Refresh);
            this.timer.Start();
        }

        void radGridView1_CellValueNeeded(object sender, GridViewCellValueEventArgs e)
        {
            e.Value = this.dataSource.Source[e.RowIndex].Data[e.ColumnIndex];
        }

        private void Refresh(object sender, EventArgs args)
        {
            // RadGridView data refresh for all cells (virtual mode) 
            for (int n = 0; n < iterationsPerUpdate; n++)
            {
                this.dataSource.Refresh();
                this.radGridView1.MasterTemplate.Refresh(null);
                refreshCount++;
                this.radLblRefreshCount.Text = String.Format("Refreshed: {0} times", ++count);
            }
        }

        void OnRefreshRateTimer_Tick(object sender, EventArgs e)
        {
            this.radLblAverage.Text = "Refresh rate: " + refreshCount+ " refreshes/second";
            refreshCount = 0;
        }

        protected override void WireEvents()
        {
        }
    }
}
