using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;
using Telerik.Examples.WinControls.Properties;

namespace Telerik.Examples.WinControls.GridView.PopulateWithData.UnboundMode
{
    public partial class Form1 : ExamplesForm
    {
        #region Fields

        private const int InitialRowsNum = 5;
        private List<Bitmap> bitmaps = new List<Bitmap>();

        private int columnNum;
        private string[] columnTypes = new string[] {
            "Text",
            "NumericText",
            "Decimal",
            "DateTime",
            "Image",
            "ComboBox",
            "Command",
            "CheckBox"
        };
        private string[] comboItems = new string[] {
            "Sales Representative",
            "Owner",
            "Order Administrator",
            "Accounting Manager",
            "Sales Manger"
        };
        #endregion

        public Form1()
        {
			InitializeComponent();
            this.radGridView1.MasterTemplate.EnableSorting = true;
            this.radGridView1.TableElement.RowHeight = 35;

            Bitmap bmp = new Bitmap(Resources.msoffice_menu_blog);
            bmp.MakeTransparent(Color.Magenta);
            bitmaps.Add(bmp);

            bmp = new Bitmap(Resources.msoffice_menu_digitalsignature);
            bmp.MakeTransparent(Color.Magenta);
            bitmaps.Add(bmp);

            bmp = new Bitmap(Resources.msoffice_menu_documentworkspace);
            bmp.MakeTransparent(Color.Magenta);
            bitmaps.Add(bmp);

            bmp = new Bitmap(Resources.msoffice_menu_encryptdocument);
            bmp.MakeTransparent(Color.Magenta);
            bitmaps.Add(bmp);

			this.SelectedControl = this.radGridView1;
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            for (int i = 0; i < bitmaps.Count; i++)
            {
                bitmaps[i].Dispose();
            }

            bitmaps.Clear();

            base.OnHandleDestroyed(e);
        }

        private void InitializeGrid()
        {
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.EnableGrouping = false;

            for (int i = 0; i < this.columnTypes.Length; i++)
            {
                AppendNewColumn(this.columnTypes[i], false);
            }

            DateTime date = DateTime.Now;
            //add new unbound rows solution I
            GridViewRowInfo rowInfo = this.radGridView1.Rows.AddNew();
            rowInfo.Cells[0].Value = "Maria Anders";
            rowInfo.Cells[1].Value = 1000;
            rowInfo.Cells[2].Value = 10000.01f;
            rowInfo.Cells[3].Value = date.AddDays(1); 
            rowInfo.Cells[4].Value = bitmaps[0];
            rowInfo.Cells[5].Value = "Sales Representative";
            rowInfo.Cells[6].Value = "Command Button 1";
            rowInfo.Cells[7].Value = true;

            rowInfo = this.radGridView1.Rows.AddNew();
            rowInfo.Cells[0].Value = "Hanna Moos";
            rowInfo.Cells[1].Value = 2000;
            rowInfo.Cells[2].Value = 20000.02f;
            rowInfo.Cells[3].Value = date.AddDays(2);
            rowInfo.Cells[4].Value = bitmaps[1];
            rowInfo.Cells[5].Value = "Owner";
            rowInfo.Cells[6].Value = "Command Button 2";
            rowInfo.Cells[7].Value = false;

            //add new unbound rows solution II
            this.radGridView1.Rows.Add("Roland Mendel", 3000, 30000.03f, date.AddDays(3), bitmaps[2], "Order Administrator", "Command Button 3", true);
            this.radGridView1.Rows.Add("Diego Roel", 4000, 40000.04f, date.AddDays(4), bitmaps[3], "Accounting Manager", "Command Button 4", false);
            this.radGridView1.Rows.Add("Janine Labrune", 5000, 50000.05f, date.AddDays(5), bitmaps[0], "Sales Manger", "Command Button 5", true);

            this.radGridView1.MasterTemplate.BestFitColumns();
            
            this.radGridView1.CurrentRow = this.radGridView1.Rows[0];
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radComboBox1.DataSource = this.columnTypes;
            this.radComboBox1.SelectedIndex = 0;
            InitializeGrid();
            this.LoadColumnsComboBox();
            this.radGridView1.CellBeginEdit += new GridViewCellCancelEventHandler(radGridView1_CellBeginEdit);
        }

        void radGridView1_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            if (this.radGridView1.ActiveEditor != null)
            {
                if (this.radGridView1.ActiveEditor is RadDropDownListEditor)
                {
                    RadDropDownListEditor comboboxEditor = this.radGridView1.ActiveEditor as RadDropDownListEditor;
                    comboboxEditor.EditorElement.Alignment = ContentAlignment.MiddleCenter;
                    comboboxEditor.EditorElement.StretchVertically = false;
                    this.radGridView1.CurrentCell.Alignment = ContentAlignment.MiddleCenter;
                }
                else if (this.radGridView1.ActiveEditor is RadDateTimeEditor)
                {
                    RadDateTimeEditor comboboxEditor = this.radGridView1.ActiveEditor as RadDateTimeEditor;
                    comboboxEditor.EditorElement.Alignment = ContentAlignment.MiddleCenter;
                    comboboxEditor.EditorElement.StretchVertically = false;
                    this.radGridView1.CurrentCell.Alignment = ContentAlignment.MiddleCenter;
                }
            }
        }

        private void LoadColumnsComboBox()
        {
            this.radComboColumnsRemove.Items.Clear();
            foreach (GridViewDataColumn column in this.radGridView1.Columns)
            {
                RadListDataItem comboItem = new RadListDataItem(column.HeaderText);
                comboItem.Tag = column;
                this.radComboColumnsRemove.Items.Add(comboItem);
            }

            this.radComboColumnsRemove.SelectedIndex = this.radComboColumnsRemove.Items.Count - 1;
        }

        #region Event Handlers
        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            GridViewDataColumn col = AppendNewColumn(this.radComboBox1.SelectedItem.Text, true);
            this.LoadColumnsComboBox();
        } 

        private void btnRemoveColumn_Click(object sender, EventArgs e)
        {
            if (this.radGridView1.Columns.Count == 0)
            {
                return;
            }

            GridViewDataColumn selectedColumn = this.radComboColumnsRemove.SelectedItem.Tag as GridViewDataColumn; 
            this.radGridView1.Columns.Remove(selectedColumn);
            this.LoadColumnsComboBox();
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            this.radGridView1.Rows.Add(null, null);
        }

        private void btnRemoveSelectedRows_Click(object sender, EventArgs e)
        {
            GridViewRowInfo[] selectedRows = new GridViewRowInfo[this.radGridView1.SelectedRows.Count];
            this.radGridView1.SelectedRows.CopyTo(selectedRows, 0);

            this.radGridView1.TableElement.BeginUpdate();
            for (int i = 0; i < selectedRows.Length; i++)
            {
                this.radGridView1.Rows.Remove(selectedRows[i] as GridViewDataRowInfo);
            }
            this.radGridView1.TableElement.EndUpdate();
        }

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.MasterTemplate.AllowAddNewRow = args.ToggleState == ToggleState.On;
        }

        private void radGridView1_RowsChanging(object sender, GridViewCollectionChangingEventArgs e)
        {
            Console.WriteLine("Rows changing action:{0}", e.Action);
        }

        private void radGridView1_RowsChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            Console.WriteLine("Rows changed action:{0}", e.Action);
        }

        #endregion Event Handlers

        private GridViewDataColumn AppendNewColumn(string columnType, bool numberInTheHeader)
        {
            GridViewDataColumn newColumn = null;
            switch (columnType)
            {
                case "Text":
                    newColumn = new GridViewTextBoxColumn();
                    newColumn.FieldName = "Text";
                    break;
                case "NumericText":
                    newColumn = new GridViewMaskBoxColumn();
                    ((GridViewMaskBoxColumn)newColumn).Mask = "f";
                    newColumn.TextAlignment = ContentAlignment.MiddleLeft;
                    newColumn.FieldName = "NumericText";
                    break;
                case "Decimal":
                    newColumn = new GridViewDecimalColumn();
                    newColumn.TextAlignment = ContentAlignment.MiddleRight;
                    newColumn.FieldName = "Decimal";
                    break;
                case "DateTime":
                    newColumn = new GridViewDateTimeColumn();
                    newColumn.FormatString = "{0:MM-dd-yyyy}";
                    newColumn.TextAlignment = ContentAlignment.MiddleRight;
                    newColumn.FieldName = "DateTime";
                    break;
                case "Image":
                    newColumn = new GridViewImageColumn();
                    ((GridViewImageColumn)newColumn).ImageLayout = ImageLayout.Center;
                    newColumn.Width = 40;
                    newColumn.FieldName = "Image";
                    break;
                case "ComboBox":
                    newColumn = new GridViewComboBoxColumn();
                    ((GridViewComboBoxColumn)newColumn).DataSource = this.comboItems;
                    newColumn.Width = 100;
                    newColumn.FieldName = "ComboBox";
                    break;
                case "Command":
                    newColumn = new GridViewCommandColumn();
                    ((GridViewCommandColumn)newColumn).TextAlignment = ContentAlignment.MiddleCenter;
                    newColumn.FieldName = "Command";
                    break;
                case "CheckBox":
                    newColumn = new GridViewCheckBoxColumn();
                    newColumn.Width = 50;
                    newColumn.FieldName = "CheckBox";
                    break;
            }

            if (numberInTheHeader)
            {
                newColumn.HeaderText = (this.columnNum++).ToString() + " - " + columnType;
            }
            else
            {
                newColumn.HeaderText = columnType;
            }

            this.radGridView1.Columns.Add(newColumn);            
            return newColumn;
        }

        protected override void WireEvents()
        {
            this.radGridView1.RowsChanging += new Telerik.WinControls.UI.GridViewCollectionChangingEventHandler(this.radGridView1_RowsChanging);
            this.radGridView1.RowsChanged += new Telerik.WinControls.UI.GridViewCollectionChangedEventHandler(this.radGridView1_RowsChanged);
            this.radBtnRmRows.Click += new System.EventHandler(this.btnRemoveSelectedRows_Click);
            this.radBtnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            this.radBtnRmCol.Click += new System.EventHandler(this.btnRemoveColumn_Click);
            this.radBtnAddCol.Click += new System.EventHandler(this.btnAddColumn_Click);
            this.radCheckShowNewRow.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
        }
    }
}