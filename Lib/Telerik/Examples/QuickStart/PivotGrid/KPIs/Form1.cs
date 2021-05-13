using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.Pivot.Adomd;

namespace Telerik.Examples.WinControls.PivotGrid.KPIs
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            radPivotGrid1.Dock = DockStyle.Fill;
        }

        private void SetupAdomdProvider()
        {
            AdomdDataProvider provider = new AdomdDataProvider();
            AdomdConnectionSettings settings = new AdomdConnectionSettings();
            
            settings.Cube = "Adventure Works";
            settings.Database = "Adventure Works DW 2008R2";
            settings.ConnectionString = "Data Source=https://demos.telerik.com/olap/msmdpump.dll;Catalog=Adventure Works DW 2008R2";

            provider.ConnectionSettings = settings;
            provider.AggregatesPosition = Pivot.Core.PivotAxis.Rows;
           
            provider.RowGroupDescriptions.Add(new AdomdGroupDescription() { MemberName = "[Product].[Category]" });
            provider.ColumnGroupDescriptions.Add(new AdomdGroupDescription() { MemberName = "[Date].[Fiscal Year]" });

            provider.AggregateDescriptions.Add(new AdomdAggregateDescription() { MemberName = "[Measures].[Internet Sales Amount]" });
            provider.AggregateDescriptions.Add(new AdomdAggregateDescription() { MemberName = "[Measures].[Internet Revenue Goal]" });
            provider.AggregateDescriptions.Add(new AdomdAggregateDescription() { MemberName = "[Measures].[Internet Revenue Status]" });
            provider.AggregateDescriptions.Add(new AdomdAggregateDescription() { MemberName = "[Measures].[Internet Revenue Trend]" });
       
            this.radPivotGrid1.PivotGridElement.DataProvider = provider;

            provider.DeferUpdates = false;

            provider.Refresh();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.radButton1.Parent.Controls.Remove(this.radButton1);
            this.SetupAdomdProvider();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (this.radButton1 != null && this.radPivotGrid1 != null)
            {
                this.radButton1.Location = new Point((this.radPivotGrid1.Width - this.radButton1.Width) / 2, (this.radPivotGrid1.Height - this.radButton1.Height) / 2);
            }
        }

        protected override void WireEvents()
        {
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
        }
    }
}
