using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

namespace Telerik.Examples.WinControls.GridView.Rows.RowsReorder
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BindGrid()
        {
            this.radGridView1.Rows.Add(1, this.imageList1.Images["TaskCompleted.png"], "Call Linda", DateTime.Now.AddHours(5));
            this.radGridView1.Rows.Add(2, this.imageList1.Images["TaskCompleted.png"], "Change car oil", DateTime.Now.AddDays(5));
            this.radGridView1.Rows.Add(3, this.imageList1.Images["TaskCompleted.png"], "Pick up laundry", DateTime.Now.AddDays(1));
            this.radGridView1.Rows.Add(4, this.imageList1.Images["TaskCompleted.png"], "Buy Helloween costume", DateTime.Now.AddMonths(1));
            this.radGridView1.Rows.Add(5, this.imageList1.Images["TaskCompleted.png"], "Walk the dog", DateTime.Now.AddHours(3));
            this.radGridView1.Rows.Add(6, this.imageList1.Images["TaskNotCompleted.png"], "Repair John's computer", DateTime.Now.AddDays(2));
            this.radGridView1.Rows.Add(7, this.imageList1.Images["TaskNotCompleted.png"], "Go to the library", DateTime.Now.AddDays(4));
            this.radGridView1.Rows.Add(8, this.imageList1.Images["TaskNotCompleted.png"], "Buy present for Mike's birthday", DateTime.Now.AddDays(1));
            this.radGridView1.Rows.Add(9, this.imageList1.Images["TaskNotCompleted.png"], "Pay all bills", DateTime.Now.AddDays(9));
            this.radGridView1.Rows.Add(10, this.imageList1.Images["TaskCompleted.png"], "Moving a house", DateTime.Now.AddDays(10));
        }

        private void MoveRow(bool moveUp)
        {
            GridViewRowInfo currentRow = this.radGridView1.CurrentRow;

            if (currentRow == null)
            {
                return;
            }

            int index = moveUp ? currentRow.Index - 1 : currentRow.Index + 1;

            if (index < 0 || index >= this.radGridView1.RowCount)
            {
                return;
            }

            this.radGridView1.Rows.Move(index, currentRow.Index);
            this.radGridView1.CurrentRow = this.radGridView1.Rows[index];
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radGridView1.TableElement.RowHeight = 50;
            this.radGridView1.AllowAddNewRow = false;
            this.radGridView1.AllowRowReorder = true;
            this.radGridView1.ReadOnly = true;
            this.radGridView1.Rows.CollectionChanged += new NotifyCollectionChangedEventHandler(Rows_CollectionChanged);

            GridViewImageColumn imageColumn = new GridViewImageColumn("Image", "Image");
            imageColumn.Width = 50;
            imageColumn.HeaderText = String.Empty;

            GridViewDecimalColumn priorityColumn = new GridViewDecimalColumn(typeof(int), "Priority", "Priority");
            priorityColumn.HeaderText = "#";
            priorityColumn.Width = 50;
            priorityColumn.ReadOnly = true;

            GridViewTextBoxColumn taskColumn = new GridViewTextBoxColumn("Task", "Task");
            taskColumn.Width = 180;

            GridViewDateTimeColumn dueDateColumn = new GridViewDateTimeColumn("DueDate", "Due Date");
            dueDateColumn.Width = 120;

            this.radGridView1.Columns.Add(priorityColumn);
            this.radGridView1.Columns.Add(imageColumn);
            this.radGridView1.Columns.Add(taskColumn);
            this.radGridView1.Columns.Add(dueDateColumn);

            this.BindGrid();

            this.btnMoveUp.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText;
            this.btnMoveUp.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.btnMoveDown.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText;
            this.btnMoveDown.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            this.MoveRow(true);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            this.MoveRow(false);
        }

        private void Rows_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Move)
            {
                for (int i = 0; i < this.radGridView1.Rows.Count; i++)
                {
                    this.radGridView1.Rows[i].Cells["Priority"].Value = i + 1;
                }
            }
        }

        protected override void WireEvents()
        {
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
        }
    }
}
