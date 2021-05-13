using System.Data.OleDb;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.Filtering.CustomFilterRow
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.radGridView1.CreateCell += new GridViewCreateCellEventHandler(radGridView1_CreateCell);
            this.radGridView1.CellBeginEdit += new GridViewCellCancelEventHandler(radGridView1_CellBeginEdit);

            this.WireEvents();

            this.radGridView1.EnableFiltering = true;
            this.radGridView1.EnableCustomFiltering = true;            
        }    

        private void radGridView1_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            if (e.Row is GridViewFilteringRowInfo)
            {
                this.radGridView1.EnableCustomFiltering = false;
            }
        }

        private void radGridView1_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.CellType == typeof(GridRowHeaderCellElement) && e.Row.RowInfo is ExpandableGridViewFilteringRowInfo)
            {
                e.CellType = typeof(GridFilterExpandableCellElement);
            }
        }

        private void MasterTemplate_CreateRowInfo(object sender, GridViewCreateRowInfoEventArgs e)
        {
            if (e.RowInfo is GridViewFilteringRowInfo)
            {
                e.RowInfo = new ExpandableGridViewFilteringRowInfo(e.ViewInfo);
            }
        }

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);

            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = true;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            this.radGridView1.TableElement.BeginUpdate();

           using (OleDbCommand command = new OleDbCommand("SELECT ShipName, ShipAddress, ShipCity, ShippedDate, Freight FROM Orders"))
            {
                command.Connection = new OleDbConnection(Properties.Settings.Default.NwindConnectionString);
                command.Connection.Open();
                this.radGridView1.MasterTemplate.LoadFrom(command.ExecuteReader());
                command.Connection.Close();
            }

            this.radGridView1.Columns["ShipName"].HeaderText = "Ship Name";
            this.radGridView1.Columns["ShipAddress"].HeaderText = "Ship Address";
            this.radGridView1.Columns["ShipCity"].HeaderText = "Ship City";
            this.radGridView1.Columns["ShippedDate"].HeaderText = "Shipped Date";

            this.radGridView1.TableElement.EndUpdate();
            this.radGridView1.CurrentRow = this.radGridView1.Rows[0];
            this.radGridView1.Rows[0].IsSelected = true;
        }

        public override void OnThemeChanged()
        {
            base.OnThemeChanged();
            if (TelerikHelper.IsMaterialTheme(this.CurrentThemeName))
            {
                var filterRow = radGridView1.MasterView.TableFilteringRow as ExpandableGridViewFilteringRowInfo;
                filterRow.ChildRows[0].MinHeight = 140;
            }
        }
    }
}
