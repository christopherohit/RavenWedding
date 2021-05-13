using System;
using System.Collections.Generic;
using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.Rows.RowsDragDrop
{
    public partial class Form1 : ExamplesForm
    {
        private Font boldFont = null;

        public Form1()
        {
            InitializeComponent();

            this.SubscribeForGridEvents(this.gridBasket);
            this.SubscribeForGridEvents(this.gridViewProducts);
            this.gridBasket.SelectionChanged += new EventHandler(gridBasket_SelectionChanged);
        }

        private void PrepareGrid(RadGridView grid)
        {
            GridViewImageColumn imageColumn = new GridViewImageColumn("Image", "Image");
            imageColumn.Width = 50;
            imageColumn.HeaderText = String.Empty;
            GridViewTextBoxColumn nameColumn = new GridViewTextBoxColumn("Name", "Name");
            nameColumn.Width = 70;
            GridViewTextBoxColumn countryColumn = new GridViewTextBoxColumn("Country", "Country");
            countryColumn.Width = 90;
            GridViewDecimalColumn priceColumn = new GridViewDecimalColumn("Price", "Price");
            priceColumn.Width = 90;
            priceColumn.FormatString = "{0:c}";

            grid.Columns.Add(imageColumn);
            grid.Columns.Add(nameColumn);
            grid.Columns.Add(countryColumn);
            grid.Columns.Add(priceColumn);
            grid.TableElement.RowHeight = 50;
            grid.MasterTemplate.AllowRowReorder = true;
            grid.ReadOnly = true;
            grid.MultiSelect = true;
            grid.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            grid.GridBehavior = new CustomGridBehavior();
        }

        private void SubscribeForGridEvents(RadGridView grid)
        {
            RadDragDropService dragDropService = grid.GridViewElement.GetService<RadDragDropService>();
            dragDropService.PreviewDragOver += new EventHandler<RadDragOverEventArgs>(dragDropService_PreviewDragOver);
            dragDropService.PreviewDragDrop += new EventHandler<RadDropEventArgs>(dragDropService_PreviewDragDrop);
            dragDropService.PreviewDragHint += new EventHandler<PreviewDragHintEventArgs>(dragDropService_PreviewDragHint);
            grid.CellFormatting += new CellFormattingEventHandler(grid_CellFormatting);
            grid.Rows.CollectionChanged += new Telerik.WinControls.Data.NotifyCollectionChangedEventHandler(Rows_CollectionChanged);
        }

        private int GetTargetRowIndex(GridDataRowElement row, Point dropLocation)
        {
            int halfHeight = row.Size.Height / 2;
            int index = row.RowInfo.Index;

            if (dropLocation.Y > halfHeight)
            {
                index++;
            }

            return index;
        }

        private void MoveRows(RadGridView targetGrid, RadGridView dragGrid, IList<GridViewRowInfo> dragRows, int index)
        {
            for (int i = dragRows.Count - 1; i >= 0; i--)
            {
                GridViewRowInfo row = dragRows[i];

                if (row is GridViewSummaryRowInfo)
                {
                    continue;
                }

                GridViewRowInfo newRow = targetGrid.Rows.NewRow();
                this.InitializeRow(newRow, row);
                targetGrid.Rows.Insert(index, newRow);
                row.IsSelected = false;
                dragGrid.Rows.Remove(row);
                index++;
            }
        }

        private void InitializeRow(GridViewRowInfo destRow, GridViewRowInfo sourceRow)
        {
            destRow.Cells["Image"].Value = sourceRow.Cells["Image"].Value;
            destRow.Cells["Name"].Value = sourceRow.Cells["Name"].Value;
            destRow.Cells["Country"].Value = sourceRow.Cells["Country"].Value;
            destRow.Cells["Price"].Value = sourceRow.Cells["Price"].Value;
        }

        #region Event handlers

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.PrepareGrid(this.gridBasket);

            this.gridBasket.Rows.Add(this.imageList1.Images[0], "Banana", "Ecuador", 50);
            this.gridBasket.Rows.Add(this.imageList1.Images[1], "Eggplant", "Turkey", 5);

            GridViewSummaryRowItem summaryItem = new GridViewSummaryRowItem();
            summaryItem.Add(new GridViewSummaryItem("Price", "Total {0:c}", GridAggregateFunction.Sum));
            this.gridBasket.MasterTemplate.SummaryRowsBottom.Add(summaryItem);

            this.PrepareGrid(this.gridViewProducts);

            this.gridViewProducts.Rows.Add(this.imageList1.Images[2], "Mushroom", "Ecuador", 20);
            this.gridViewProducts.Rows.Add(this.imageList1.Images[3], "Onion", "Italy", 30);
            this.gridViewProducts.Rows.Add(this.imageList1.Images[4], "Pear", "China", 100);
            this.gridViewProducts.Rows.Add(this.imageList1.Images[5], "Watermelon", "Bulgaria", 10);
        }

        private void btnCheckoutSelectedProducts_Click(object sender, EventArgs e)
        {
            int index = this.gridBasket.RowCount > 0 ? this.gridBasket.RowCount - 1 : 0;
            this.MoveRows(this.gridBasket, this.gridViewProducts, new List<GridViewRowInfo>(this.gridViewProducts.SelectedRows), index);
        }

        private void btnCheckoutAllProducts_Click(object sender, EventArgs e)
        {
            int index = this.gridBasket.RowCount > 0 ? this.gridBasket.RowCount - 1 : 0;
            this.MoveRows(this.gridBasket, this.gridViewProducts, this.gridViewProducts.Rows, index);
        }

        private void btnReturnSelectedProducts_Click(object sender, EventArgs e)
        {
            int index = this.gridViewProducts.RowCount > 0 ? this.gridViewProducts.RowCount - 1 : 0;
            this.MoveRows(this.gridViewProducts, this.gridBasket, new List<GridViewRowInfo>(this.gridBasket.SelectedRows), index);
        }

        private void btnReturnAllProducts_Click(object sender, EventArgs e)
        {
            int index = this.gridViewProducts.RowCount > 0 ? this.gridViewProducts.RowCount - 1 : 0;
            this.MoveRows(this.gridViewProducts, this.gridBasket, this.gridBasket.Rows, index);
        }

        private void radPanel1_SizeChanged(object sender, EventArgs e)
        {
            int padding = 20;
            int width = (this.radPanel1.Size.Width - 3 * padding) / 2;
            int heigh = this.radPanel1.Size.Height - 2 * padding;

            this.gbProducts.Location = new Point(padding, padding);
            this.gbProducts.Size = new Size(width, heigh);
            this.gbBasket.Location = new Point(this.gbProducts.Right + padding, padding);
            this.gbBasket.Size = new Size(width, heigh);
        }

        private void Rows_CollectionChanged(object sender, Telerik.WinControls.Data.NotifyCollectionChangedEventArgs e)
        {
            GridViewRowCollection rows = sender as GridViewRowCollection;

            if (rows.Owner.MasterTemplate == this.gridBasket.MasterTemplate)
            {
                bool isSummaryRowOnlySelected = this.gridBasket.SelectedRows.Count == 1 && this.gridBasket.SelectedRows[0] is GridViewSummaryRowInfo;
                bool isEnabled = rows.Count > 0 && !isSummaryRowOnlySelected;

                btnReturnAllProducts.Enabled = isEnabled;
                btnReturnSelectedProducts.Enabled = isEnabled;
            }
            else
            {
                btnCheckoutAllProducts.Enabled = rows.Count > 0;
                btnCheckoutSelectedProducts.Enabled = rows.Count > 0;
            }
        }

        private void grid_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            GridDataCellElement dataCell = e.CellElement as GridDataCellElement;

            if (dataCell != null && dataCell.ColumnInfo.Name == "Name" && dataCell.RowElement is GridDataRowElement)
            {
                if (boldFont == null)
                {
                    boldFont = new Font(dataCell.Font, FontStyle.Bold);
                }

                dataCell.Font = boldFont;
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local);
            }
        }

        private void gridBasket_SelectionChanged(object sender, EventArgs e)
        {
            RadGridView grid = sender as RadGridView;

            btnReturnSelectedProducts.Enabled = true;
            btnReturnAllProducts.Enabled = true;

            if (grid == this.gridBasket)
            {
                bool isSummaryRowOnlySelected = this.gridBasket.SelectedRows.Count == 1 && this.gridBasket.SelectedRows[0] is GridViewSummaryRowInfo;
                btnReturnSelectedProducts.Enabled = !isSummaryRowOnlySelected;
            }
        }

        #endregion

        #region Drag & drop logic

        private void dragDropService_PreviewDragDrop(object sender, RadDropEventArgs e)
        {
            SnapshotDragItem dragInstance = e.DragInstance as SnapshotDragItem;

            if (dragInstance == null)
            {
                return;
            }

            RadItem dropTarget = e.HitTarget as RadItem;
            RadGridView targetGrid = dropTarget.ElementTree.Control as RadGridView;

            if (targetGrid == null)
            {
                return;
            }

            RadGridView dragGrid = dragInstance.Item.ElementTree.Control as RadGridView;

            if (targetGrid != dragGrid)
            {
                e.Handled = true;

                CustomGridBehavior behavior = (CustomGridBehavior)dragGrid.GridBehavior;
                GridDataRowElement dropTargetRow = dropTarget as GridDataRowElement;
                int index = dropTargetRow != null ? this.GetTargetRowIndex(dropTargetRow, e.DropLocation) : targetGrid.RowCount;
                this.MoveRows(targetGrid, dragGrid, behavior.SelectedRows, index);
            }
        }

        private void dragDropService_PreviewDragOver(object sender, RadDragOverEventArgs e)
        {
            if (e.DragInstance is SnapshotDragItem)
            {
                e.CanDrop = e.HitTarget is GridDataRowElement || e.HitTarget is GridTableElement || e.HitTarget is GridSummaryRowElement;
            }
        }

        private void dragDropService_PreviewDragHint(object sender, PreviewDragHintEventArgs e)
        {
            SnapshotDragItem dragInstance = e.DragInstance as SnapshotDragItem;

            if (dragInstance == null)
            {
                return;
            }

            GridViewRowInfo rowInfo = e.DragInstance.GetDataContext() as GridViewRowInfo;

            if (rowInfo != null && rowInfo.ViewTemplate.MasterTemplate.SelectedRows.Count > 1)
            {
                e.DragHint = new Bitmap(this.imageList1.Images[6]);
                e.UseDefaultHint = false;
            }
        }

        #endregion

        protected override void WireEvents()
        {
            this.radPanel1.SizeChanged += new System.EventHandler(this.radPanel1_SizeChanged);
            this.btnCheckoutSelectedProducts.Click += new System.EventHandler(this.btnCheckoutSelectedProducts_Click);
            this.btnCheckoutAllProducts.Click += new System.EventHandler(this.btnCheckoutAllProducts_Click);
            this.btnReturnSelectedProducts.Click += new System.EventHandler(this.btnReturnSelectedProducts_Click);
            this.btnReturnAllProducts.Click += new System.EventHandler(this.btnReturnAllProducts_Click);
        }
    }
}
