using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.Charting.Styles;
using Telerik.WinControls.UI;
using Telerik.WinControls.Themes;

namespace DemoAppsHub.GridExample
{
    public partial class GridExampleUserControl : UserControl
    {
        public GridExampleUserControl()
        {
            InitializeComponent();            
        }

        #region Event handlers

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radGridView1.ThemeName = "TelerikMetroBlue";
            this.radGridView1.CreateRow += new GridViewCreateRowEventHandler(radGridView1_CreateRow);
            this.radGridView1.MasterTemplate.CreateRowInfo += new GridViewCreateRowInfoEventHandler(MasterTemplate_CreateRowInfo);

            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
            this.radGridView1.TableElement.RowHeight = 45;
        }

        void MasterTemplate_CreateRowInfo(object sender, GridViewCreateRowInfoEventArgs e)
        {
            e.RowInfo.MinHeight = 45;
        }

        void radGridView1_CreateRow(object sender, GridViewCreateRowEventArgs e)
        {
            if (e.RowType == typeof(GridDataRowElement))
            {
                e.RowType = typeof(GridCustomRowElement);
            }
        }

        #endregion
    }
}
