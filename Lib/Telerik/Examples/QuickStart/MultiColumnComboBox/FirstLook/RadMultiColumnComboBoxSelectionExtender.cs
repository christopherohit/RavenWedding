using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.MultiColumnComboBox.FirstLook
{
    [ToolboxItem(false)]
    public class RadMultiColumnComboBoxSelectionExtender : Component
    {
        private RadAutoCompleteBoxElement autoCompleteBoxElement;
        private Dictionary<string, GridViewRowInfo> rows = new Dictionary<string, GridViewRowInfo>();
        private RadMultiColumnComboBox associatedRadMultiColumnComboBox;
        private Size originalSize = Size.Empty;

        public RadAutoCompleteBoxElement AutoCompleteBoxElement
        {
            get
            {
                return this.autoCompleteBoxElement;
            }
        }

        /// <summary>
        /// Gets the tokenized items.
        /// </summary>
        public RadTokenizedTextItemCollection Items
        {
            get { return this.autoCompleteBoxElement.Items; }
        }

        public RadMultiColumnComboBox AssociatedRadMultiColumnComboBox
        {
            get
            {
                return this.associatedRadMultiColumnComboBox;
            }
            set
            {
                this.SetAssociatedRadMultiColumnComboBox(value);
            }
        }

        private void SetAssociatedRadMultiColumnComboBox(RadMultiColumnComboBox radMultiColumnComboBox)
        {
            if (radMultiColumnComboBox == null && this.associatedRadMultiColumnComboBox != null)
            {
                this.SetAssociatedRadMultiColumnComboBoxCoreToNull();
            }

            this.SetAssociatedRadMultiColumnComboBoxCore(radMultiColumnComboBox);
        }

        private void SetAssociatedRadMultiColumnComboBoxCoreToNull()
        {
            this.associatedRadMultiColumnComboBox.HandleCreated -= associatedRadMultiColumnComboBox_HandleCreated;
            this.associatedRadMultiColumnComboBox.DataBindingComplete -= associatedRadMultiColumnComboBox_DataBindingComplete;
            this.associatedRadMultiColumnComboBox.EditorControl.ViewCellFormatting -= EditorControl_ViewCellFormatting;
            this.associatedRadMultiColumnComboBox.DropDownClosing -= radMultiColumnCombobox1_DropDownClosing;
            this.associatedRadMultiColumnComboBox.MultiColumnComboBoxElement.TextBoxElement.Visibility = ElementVisibility.Visible;
            this.associatedRadMultiColumnComboBox.MultiColumnComboBoxElement.Children[2].Children.Remove(autoCompleteBoxElement);
            this.autoCompleteBoxElement.MaxSize = new Size(0, 0);
            this.autoCompleteBoxElement.AutoCompleteDataSource = null;
            this.associatedRadMultiColumnComboBox.Size = this.originalSize;
            foreach (GridViewRowInfo item in this.associatedRadMultiColumnComboBox.EditorControl.Rows)
            {
                item.Tag = null;
            }

            this.autoCompleteBoxElement.CreateTextBlock -= autoCompleteBoxElement_CreateTextBlock;
            this.autoCompleteBoxElement.TokenValidating -= autoCompleteBoxElement_TokenValidating;
            this.autoCompleteBoxElement.Text = this.associatedRadMultiColumnComboBox.Text;
            this.autoCompleteBoxElement.KeyDown -= autoCompleteBoxElement_KeyDown;
            this.associatedRadMultiColumnComboBox = null;
            this.rows.Clear();
        }

        private void SetAssociatedRadMultiColumnComboBoxCore(RadMultiColumnComboBox radMultiColumnComboBox)
        {
            if (radMultiColumnComboBox == null)
            {
                return;
            }

            this.originalSize = radMultiColumnComboBox.Size;
            this.associatedRadMultiColumnComboBox = radMultiColumnComboBox;
            this.associatedRadMultiColumnComboBox.HandleCreated += associatedRadMultiColumnComboBox_HandleCreated;
            this.associatedRadMultiColumnComboBox.DataBindingComplete += associatedRadMultiColumnComboBox_DataBindingComplete;
            this.associatedRadMultiColumnComboBox.EditorControl.ViewCellFormatting += EditorControl_ViewCellFormatting;
            this.associatedRadMultiColumnComboBox.DropDownClosing += radMultiColumnCombobox1_DropDownClosing;
            this.autoCompleteBoxElement = new RadAutoCompleteBoxElement();
            this.autoCompleteBoxElement.MaxSize = new Size(256, 0);
            this.autoCompleteBoxElement.DrawBorder = false;
            this.autoCompleteBoxElement.KeyDown += autoCompleteBoxElement_KeyDown;
            this.autoCompleteBoxElement.NullText = this.associatedRadMultiColumnComboBox.NullText;
            this.associatedRadMultiColumnComboBox.MultiColumnComboBoxElement.ArrowButton.ZIndex = 1;
            this.associatedRadMultiColumnComboBox.MultiColumnComboBoxElement.TextBoxElement.Visibility = ElementVisibility.Collapsed;
            this.associatedRadMultiColumnComboBox.MultiColumnComboBoxElement.ComboboxLayoutPanel.Content = this.autoCompleteBoxElement;
            this.autoCompleteBoxElement.AutoCompleteDataSource = new System.Collections.Generic.List<string>(GetAutoCompleteItems());
            this.autoCompleteBoxElement.Margin = new System.Windows.Forms.Padding(0);
            this.autoCompleteBoxElement.NullTextViewElement.Padding = new Padding(2, 6, 2, 6);
            this.autoCompleteBoxElement.CreateTextBlock += autoCompleteBoxElement_CreateTextBlock;
            this.autoCompleteBoxElement.TokenValidating += autoCompleteBoxElement_TokenValidating;
            this.PopulateItems();
        }

        void autoCompleteBoxElement_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.F4)
            {
                associatedRadMultiColumnComboBox.MultiColumnComboBoxElement.ShowPopup();
            }
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                associatedRadMultiColumnComboBox.MultiColumnComboBoxElement.ClosePopup(RadPopupCloseReason.CloseCalled);
            }
        }

        void associatedRadMultiColumnComboBox_DataBindingComplete(object sender, GridViewBindingCompleteEventArgs e)
        {
            autoCompleteBoxElement.AutoCompleteDataSource = new System.Collections.Generic.List<string>(GetAutoCompleteItems());
        }

        void associatedRadMultiColumnComboBox_HandleCreated(object sender, EventArgs e)
        {
            autoCompleteBoxElement.AutoCompleteDataSource = new System.Collections.Generic.List<string>(GetAutoCompleteItems());
        }

        private void PopulateItems()
        {
            foreach (GridViewRowInfo row in this.associatedRadMultiColumnComboBox.EditorControl.Rows)
            {
                string value = row.Cells[this.associatedRadMultiColumnComboBox.DisplayMember].Value.ToString().Trim();
                if (!rows.ContainsKey(value))
                {
                    this.rows.Add(value, row);
                }
            }
        }

        private System.Collections.Generic.IEnumerable<string> GetAutoCompleteItems()
        {
            foreach (GridViewRowInfo row in this.associatedRadMultiColumnComboBox.EditorControl.Rows)
            {
                string value = row.Cells[this.associatedRadMultiColumnComboBox.DisplayMember].Value.ToString().Trim();
                if (!rows.ContainsKey(value))
                {
                    this.rows.Add(value, row);
                }
                yield return (value);
            }
        }

        void radMultiColumnCombobox1_DropDownClosing(object sender, RadPopupClosingEventArgs args)
        {
            args.Cancel = (args.CloseReason == RadPopupCloseReason.Mouse &&
                         this.associatedRadMultiColumnComboBox.EditorControl.ElementTree.GetElementAtPoint<RadCheckBoxElement>(this.associatedRadMultiColumnComboBox.EditorControl.PointToClient(System.Windows.Forms.Cursor.Position)) != null);
            this.SyncCollection();
        }

        void EditorControl_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.ColumnIndex != -1 || e.CellElement.RowIndex == -1)
            {
                return;
            }

            if (e.CellElement.Children.Count == 1)
            {
                RadCheckBoxElement checkBoxElement = new RadCheckBoxElement();
                checkBoxElement.Padding = new System.Windows.Forms.Padding(0, 3, 1, 0);
                checkBoxElement.Alignment = ContentAlignment.MiddleCenter;
                checkBoxElement.NotifyParentOnMouseInput = false;
                e.CellElement.Children.Add(checkBoxElement);
            }

            RadCheckBoxElement checkBox = e.CellElement.FindDescendant<RadCheckBoxElement>();
            checkBox.CheckStateChanged -= checkBox_CheckStateChanged;
            checkBox.IsChecked = e.Row.Tag != null && e.Row.Tag.ToString() == Boolean.TrueString;
            checkBox.CheckStateChanged += checkBox_CheckStateChanged;
        }

        void SyncCollection()
        {
            this.associatedRadMultiColumnComboBox.MultiColumnComboBoxElement.TextBoxElement.SuspendPropertyNotifications();
            this.associatedRadMultiColumnComboBox.Text = string.Empty;
            foreach (GridViewRowInfo item in this.associatedRadMultiColumnComboBox.EditorControl.Rows)
            {
                if (item.Tag != null && item.Tag.ToString() == Boolean.TrueString)
                {
                    this.associatedRadMultiColumnComboBox.Text += item.Cells[this.associatedRadMultiColumnComboBox.DisplayMember].Value + "; ";
                }
            }

            this.associatedRadMultiColumnComboBox.MultiColumnComboBoxElement.TextBoxElement.ResumePropertyNotifications();
            autoCompleteBoxElement.CreateTextBlock -= autoCompleteBoxElement_CreateTextBlock;
            autoCompleteBoxElement.TokenValidating -= autoCompleteBoxElement_TokenValidating;
            autoCompleteBoxElement.Text = this.associatedRadMultiColumnComboBox.Text;
            autoCompleteBoxElement.TokenValidating += autoCompleteBoxElement_TokenValidating;
            autoCompleteBoxElement.CreateTextBlock += autoCompleteBoxElement_CreateTextBlock;
        }

        void autoCompleteBoxElement_TokenValidating(object sender, TokenValidatingEventArgs e)
        {
            if (this.rows.ContainsKey(e.Text))
            {
                if (this.rows[e.Text].Tag + "" == Boolean.TrueString)
                {
                    e.IsValidToken = false;
                }
            }
            else
            {
                e.IsValidToken = false;
            }
        }

        void autoCompleteBoxElement_CreateTextBlock(object sender, CreateTextBlockEventArgs e)
        {
            if (this.rows.ContainsKey(e.Text) && e.TextBlock is TokenizedTextBlockElement)
            {
                this.rows[e.Text].Tag = Boolean.TrueString;
                this.rows[e.Text].InvalidateRow();
            }
        }

        public void UpdateItems(object sender, Telerik.WinControls.Data.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove)
            {
                this.PopulateItems();

                foreach (RadTokenizedTextItem item in e.NewItems)
                {
                    if (this.rows.ContainsKey(item.Text.Trim()))
                    {
                        string itemText = item.Text.Trim();
                        this.rows[itemText].Tag = Boolean.FalseString;
                        this.rows[itemText].InvalidateRow();
                    }
                }
            }
        }

        void checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            RadCheckBoxElement checkBox = sender as RadCheckBoxElement;
            GridRowElement row = checkBox.FindAncestor<GridRowElement>();
            row.RowInfo.Tag = checkBox.IsChecked.ToString();
        }
    }
}