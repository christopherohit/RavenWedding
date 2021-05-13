using System;
using Telerik.WinControls.UI;
using System.ComponentModel;

namespace Telerik.Examples.WinControls.GridView.Rows.RowDetails
{
    public class RowDetailsGrid : RadGridView
    {
        private GridViewDataColumn detailsColumn;
        private int detailsRowHeight = 185;

        public RowDetailsGrid()
        {
            this.ViewDefinition = new RowDetailsViewDefinition();
        }
        
        public override string ThemeClassName
        {
            get 
            {
                return typeof(RadGridView).FullName; 
            }

            set 
            {
            }
        }

        public GridViewDataColumn DetailsColumn
        {
            get 
            {
                return this.detailsColumn; 
            }

            set
            {
                if (detailsColumn != value)
                {
                    detailsColumn = value;
                    if (detailsColumn != null)
                    {
                        detailsColumn.ReadOnly = true;
                    }
                    this.TableElement.UpdateView();
                }
            }
        }

        [DefaultValue(185)]
        public int DetailsRowHeight
        {
            get 
            {
                return this.detailsRowHeight; 
            }

            set
            {
                if (detailsRowHeight != value)
                {
                    detailsRowHeight = value;
                    TableElement.UpdateView();
                }
            }
        }

        protected override void OnCreateRow(object sender, GridViewCreateRowEventArgs e)
        {
            if (e.RowType == typeof(GridDataRowElement))
            {
                e.RowType = typeof(RowDetailsRowElement);
            }
            base.OnCreateRow(sender, e);
        }
    }
}