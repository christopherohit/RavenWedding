using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.Events
{
    public partial class Form1 : ExamplesForm
    {
        //additional custom columns
        protected GridViewComboBoxColumn lookUpColumn = null;
        protected GridViewCommandColumn commandColumn = null;

        public Form1()
        {
            InitializeComponent();
            this.SelectedControl = this.radGridView1;
            this.radGridView1.EnableHotTracking = true;
            this.radLabel4.Text = "";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.carsTableAdapter.Fill(this.nwindDataSet.Cars);
            radGridView1.DataSource = this.carsBindingSource;
            this.radGridView1.Columns[1].IsVisible = false;
            this.radGridView1.Columns[4].IsVisible = false;
            this.radGridView1.Columns["Picture"].IsVisible = false;

            //add new lookup column
            DataTable table = new DataTable();
            table.Columns.Add("KBytes");
            table.Rows.Add(21);
            table.Rows.Add(30);
            table.Rows.Add(99);
            table.Rows.Add(50);

            lookUpColumn = new GridViewComboBoxColumn();
            radGridView1.MasterTemplate.Columns.Add(lookUpColumn);
            lookUpColumn.HeaderText = "ComboBox";
            lookUpColumn.TextAlignment = ContentAlignment.MiddleRight;
            lookUpColumn.DataSource = table;
            lookUpColumn.FieldName = "KBytes";
            lookUpColumn.ValueMember = "KBytes";
            lookUpColumn.Name = "comboColumnKBytes";

            radGridView1.Columns["Date"].TextAlignment = ContentAlignment.MiddleRight;
            //add button column
            commandColumn = new GridViewCommandColumn();
            commandColumn.HeaderText = "Command";
            radGridView1.MasterTemplate.Columns.Add(commandColumn);

            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            //add command click event
            radGridView1.CommandCellClick += new CommandCellClickEventHandler(radGridView1_CommandCellClick);
            radGridView1.CellFormatting += new CellFormattingEventHandler(radGridView1_CellFormatting);
            radGridView1.CellBeginEdit += new GridViewCellCancelEventHandler(radGridView1_CellBeginEdit);
            radGridView1.CellEndEdit += new GridViewCellEventHandler(radGridView1_CellEndEdit);
            radGridView1.EditorRequired += new EditorRequiredEventHandler(radGridView1_EditorRequired);
            radGridView1.DoubleClick += new EventHandler(radGridView1_DoubleClick);
        }
        public override void OnThemeChanged()
        {
            base.OnThemeChanged();
            this.radPanel1.PanelElement.PanelFill.BackColor = radGridView1.TableElement.BackColor;
        }

        void radGridView1_EditorRequired(object sender, EditorRequiredEventArgs e)
        {
            AddTextToListBox("     EditorRequired  " + e.EditorType.ToString());
        }

        #region Events

        void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement is GridCommandCellElement)
            {
                e.CellElement.Text = "Btn " + e.CellElement.RowInfo.Cells["Id"].Value;
            }
            else if (e.CellElement is GridDateTimeCellElement)
            {
                GridDateTimeCellElement dateTimeCell = e.CellElement as GridDateTimeCellElement;

                dateTimeCell.Text = String.Format("{0:ddd, MM/dd}", dateTimeCell.Value);
            }
        }

        #region Cell edit
        void radGridView1_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            AddTextToListBox(string.Format(" Cell end edit column:{0}, row:{1}", e.ColumnIndex, e.RowIndex));
        }

        void radGridView1_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            AddTextToListBox(string.Format(" Cell begin edit column:{0}, row:{1}", e.ColumnIndex, e.RowIndex));
        }
        #endregion

        #region Click Events

        private void radGridView1_Click(object sender, EventArgs e)
        {
            AddEventRoot("Click");
        }

        private void radGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (radGridView1.MasterView.CurrentRow != null)
            {
                RadMessageBox.Instance.ThemeName = this.CurrentThemeName;
                RadMessageBox.Show(radGridView1.MasterView.CurrentRow.Cells[1].Value.ToString(), "Current Row");
            }
        }

        private void radGridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            AddEventRoot("CellClick");
            AddTextToListBox(string.Format("    Cell value: {0}", (sender as GridCellElement).Text));
        }

        private void radGridView1_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            AddEventRoot("CellDoubleClick");
            AddTextToListBox(string.Format("    Cell value: {0}", (sender as GridCellElement).Text));
        }

        private void radGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            AddEventRoot("MouseClick");
            AddTextToListBox(string.Format("    MouseClick {0}, btn: {1}", e.Location, e.Button));
        }

        private void radGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddEventRoot("MouseDoubleClick");
            AddTextToListBox(string.Format("    MouseClick {0}, btn: {1}", e.Location, e.Button));
        }

        void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            GridCommandCellElement clickedCommandColumn = sender as GridCommandCellElement;

            AddEventRoot("CommandCellClick");
            AddTextToListBox(string.Format("    CommandCellClick on row with id = {0}", clickedCommandColumn.RowInfo.Cells["Id"].Value));
        }

        #endregion

        #region MouseMove Events

        private void radGridView1_CellMouseMove(object sender, MouseEventArgs e)
        {
            GridDataCellElement cell = sender as GridDataCellElement;
            if (cell == null)
            {
                return;
            }

            radLabel4.Text = string.Format("{0} [{1}, btn: {2}]", cell.Value, e.Location, e.Button);
        }

        #endregion

        #region CurrentRowChanging and CurrentRowChanged event handlers

        private bool messageBoxShow = true;

        private void radGridView1_CurrentRowChanging(object sender, CurrentRowChangingEventArgs e)
        {
            if (e.NewRow == null)
            {
                AddEventRoot("CurrentRowChanging");
                AddTextToListBox("   non-data-bound row");

                return;
            }

            if (e.NewRow.Cells["Id"].Value == null)
                return;

            if (!(e.NewRow.Cells["Id"].Value is int))
                return;

            int value = (int)e.NewRow.Cells["Id"].Value;
            RadListDataItem label = new RadListDataItem();
            
            if (value == 3)
            {
                e.Cancel = true;
                label.Text = string.Format("   CurrentRowChanging, row (Id = 3) selection cancelled.");
                label.ForeColor = Color.Orange;
                if (this.messageBoxShow)
                {
                    RadMessageBox.Instance.ThemeName = this.CurrentThemeName;
                    RadMessageBox.Show("The column with Id = 3 selection is cancelled.", "Selection cancellation though CurrentRowChanging event", MessageBoxButtons.OK, RadMessageIcon.Info);
                    this.messageBoxShow = false;
                }
                else
                {
                    this.messageBoxShow = true;
                }
            }
            else
            {
                if (e.CurrentRow != null)
                    label.Text = string.Format("   CurrentRowChanging, current Id = {0}, new Id = {1}", e.CurrentRow.Cells["Id"].Value, value);
                else
                    label.Text = string.Format("   CurrentRowChanging, new Id = {0}", value);
            }
            
            AddEventRoot("CurrentRowChanging");
            AddTextToListBox(label);
        }

        private void radGridView1_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            string text;

            if (e.CurrentRow == null)
            {
                if (e.OldRow != null)
                    text = string.Format("   CurrentRowChanged, old Id = {0}, current row is non-data-bound", e.OldRow.Cells["Id"].Value);
                else
                    text = "   CurrentRowChanged, old and current rows are non-data-bound";
            }
            else
            {
                if (e.OldRow != null)
                    text = string.Format("   CurrentRowChanged, old Id = {0}, current Id = {1}", e.OldRow.Cells["Id"].Value, e.CurrentRow.Cells["Id"].Value);
                else
                    text = string.Format("   CurrentRowChanged, current Id = {0}", e.CurrentRow.Cells["Id"].Value);
            }

            AddEventRoot("CurrentRowChanged");
            AddTextToListBox(text);
        }

        #endregion

        private void radButton1_Click(object sender, EventArgs e)
        {
            radListBoxEvents.Items.Clear();
            insertIndex = 0;
        }

        #endregion

        #region Helper Methods
        int insertIndex = 0;
        private void AddEventRoot(string text)
        {
            RadListDataItem item = new RadListDataItem();
            item.Text = text;
            this.AddEventRoot(item);
        }

        private void AddEventRoot(RadListDataItem item)
        {
            item.Font =
                new System.Drawing.Font("Microsoft Sans Serif",
                                        8.25F,
                                        System.Drawing.FontStyle.Bold,
                                        System.Drawing.GraphicsUnit.Point,
                                        ((byte)(204)));
            radListBoxEvents.Items.Insert(insertIndex, item);
            insertIndex++;
        }

        private void AddTextToListBox(RadListDataItem item)
        {
            if (radListBoxEvents.Items.Count > 100)
            {
                radListBoxEvents.Items.Clear();
                insertIndex = 0;
            }

            radListBoxEvents.Items.Insert(insertIndex, item);
            insertIndex++;
        }

        private void AddTextToListBox(string text)
        {
            RadListDataItem label = new RadListDataItem();
            label.Text = text;
            AddTextToListBox(label);
        }

        #endregion

        protected override void WireEvents()
        {
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            this.radGridView1.CellMouseMove += new Telerik.WinControls.UI.CellMouseMoveEventHandler(this.radGridView1_CellMouseMove);
            this.radGridView1.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellDoubleClick);
            this.radGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.radGridView1_MouseDoubleClick);
            this.radGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radGridView1_MouseClick);
            this.radGridView1.Click += new System.EventHandler(this.radGridView1_Click);
            this.radGridView1.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellClick);
            this.radGridView1.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.radGridView1_CurrentRowChanged);
            this.radGridView1.CurrentRowChanging += new Telerik.WinControls.UI.CurrentRowChangingEventHandler(this.radGridView1_CurrentRowChanging);
        }
    }
}
