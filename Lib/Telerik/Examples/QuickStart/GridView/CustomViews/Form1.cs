using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Layouts;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.CustomViews
{
    public partial class Form1 : ExamplesForm
    {
        #region Fields

        private ColumnChooserGridViewElement columnChooserView;
        private GridViewDetailElement detailView;

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.InitializeGridControl();
        }

        #endregion

        #region Methods

        private void InitializeGridControl()
        {
            this.columnChooserView = new ColumnChooserGridViewElement();
            this.gridView.GridViewElement.Panel.Children.Insert(0, columnChooserView);
            columnChooserView.SetValue(DockLayoutPanel.DockProperty, Telerik.WinControls.Layouts.Dock.Right);

            this.gridView.TableElement.SetValue(DockLayoutPanel.DockProperty, Telerik.WinControls.Layouts.Dock.Top);
            
            this.detailView = new GridViewDetailElement();
            this.gridView.GridViewElement.Panel.Children.Insert(2, this.detailView);
            this.detailView.SetValue(DockLayoutPanel.DockProperty, Telerik.WinControls.Layouts.Dock.Bottom);

            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);

            this.gridView.Columns["LastName"].SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            this.gridView.Columns["City"].SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;

            foreach (GridViewColumn col in this.gridView.Columns)
            {
                if (ShouldBeVisibleColumn(col.Name))
                {
                    col.Width = 100;
                    continue;
                }

                col.IsVisible = false;

                if (col.Name == "Photo")
                {
                    this.gridView.Columns["Photo"].VisibleInColumnChooser = false;
                }
            }

            this.gridView.Rows[2].IsCurrent = true;
            this.gridView.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }

        private bool ShouldBeVisibleColumn(string column)
        {
            if (column == "FirstName" ||
                column == "LastName" ||
                column == "HireDate" ||
                column == "HomePhone" ||
                column == "PostalCode")
            {
                return true;
            }

            return false;
        }

        #endregion

        public override void OnThemeChanged()
        {
            base.OnThemeChanged();
            if (TelerikHelper.IsDarkTheme(this.CurrentThemeName))
            {
                columnChooserView.ForeColor = Color.White;
            }
            else
            {
                columnChooserView.ForeColor = Color.Black;
            }
        }

        protected override void WireEvents()
        {

        }
    }
}
