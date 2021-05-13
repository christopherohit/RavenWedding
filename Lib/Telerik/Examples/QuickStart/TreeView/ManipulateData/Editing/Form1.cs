using System;
using System.Data;
using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;


namespace Telerik.Examples.WinControls.TreeView.ManipulateData.Editing
{
    /// <summary>
    /// Form code
    /// </summary>
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.SelectedControl = this.radTreeView1;
        }

        private void LoadData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("ParentID", typeof(int));
            table.Columns.Add("PropertyName", typeof(string));
            table.Columns.Add("PropertyValue", typeof(PropertyHelper));

            this.radPanel1.PanelElement.PanelText.ForeColor = Color.White;

            table.Rows.Add(0, null, "Panel", null);
            table.Rows.Add(1, 0, "Text", new PropertyHelper(radPanel1, "Text"));
            table.Rows.Add(2, 0, "Appearance", null);
            table.Rows.Add(3, 0, "Shape", null);
            table.Rows.Add(4, 2, "Fore color", new PropertyHelper(radPanel1.PanelElement.PanelText, "ForeColor"));
            table.Rows.Add(5, 2, "Back color", new PropertyHelper(radPanel1.PanelElement.PanelFill, "BackColor"));
            table.Rows.Add(6, 2, "Border color", new PropertyHelper(radPanel1.PanelElement.PanelBorder, "ForeColor"));
            table.Rows.Add(7, 2, "Border width", new PropertyHelper(radPanel1.PanelElement.PanelBorder, "Width"));
            table.Rows.Add(8, 3, "Corner radius", new PropertyHelper(radPanel1.PanelElement, "Shape"));

            this.radTreeView1.ChildMember = "ID";
            this.radTreeView1.ParentMember = "ParentID";
            this.radTreeView1.DisplayMember = "PropertyValue";
            this.radTreeView1.DataSource = table;
        }

        protected override void OnLoad(EventArgs e)
        {
            this.AutoScroll = false;

            base.OnLoad(e);
            LoadData();
            this.radTreeView1.NodeFormatting += new TreeNodeFormattingEventHandler(radTreeView1_NodeFormatting);
            this.radTreeView1.ValueChanging += new TreeNodeValueChangingEventHandler(radTreeView1_ValueChanging);
            this.radTreeView1.Editing += new TreeNodeEditingEventHandler(radTreeView1_Editing);
            this.radTreeView1.EditorInitialized += new TreeNodeEditorInitializedEventHandler(radTreeView1_EditorInitialized);
            this.radTreeView1.EditorRequired += new RadTreeView.EditorRequiredHandler(radTreeView1_EditorRequired);
            this.radTreeView1.ItemHeight = 27;
            this.radTreeView1.AllowAdd = false;
            this.radTreeView1.AllowRemove = false;
            this.radTreeView1.ExpandAnimation = ExpandAnimation.None;
            this.radTreeView1.AllowDefaultContextMenu = true;
            this.radTreeView1.ExpandAll();
        }

        void radTreeView1_Editing(object sender, TreeNodeEditingEventArgs e)
        {
            PropertyHelper helper = e.Node.Value as PropertyHelper;
            if (helper == null)
            {
                e.Cancel = true;
            }
        }

        private void radCheckBoxAllowEdit_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radTreeView1.AllowEdit = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void radTreeView1_NodeFormatting(object sender, TreeNodeFormattingEventArgs args)
        {
            DataRowView rowView = (DataRowView)args.Node.DataBoundItem;
            string propertyName = (string)rowView["PropertyName"];
            object propertyValue = rowView["PropertyValue"];

            if (propertyValue != DBNull.Value)
            {
                if (args.NodeElement.Children.Count == 4)
                {
                    LightVisualElement descriptionElement = new LightVisualElement();
                    descriptionElement.StretchHorizontally = false;
                    descriptionElement.Font = ((LightVisualElement)args.NodeElement.Children[3]).Font;
                    descriptionElement.TextAlignment = ContentAlignment.MiddleLeft;
                    args.NodeElement.Children.Insert(3, descriptionElement);
                }

                ((LightVisualElement)args.NodeElement.Children[3]).Text = propertyName + ":  ";
                args.NodeElement.ContentElement.ForeColor = Color.Blue;
                args.NodeElement.ContentElement.Text = propertyValue.ToString();
            }
            else
            {
                if (args.NodeElement.Children.Count == 5)
                {
                    args.NodeElement.Children.RemoveAt(3);
                }
                args.NodeElement.ContentElement.Text = "<html><b>" + propertyName;
            }
        }

        private void radTreeView1_ValueChanging(object sender, TreeNodeValueChangingEventArgs e)
        {
            PropertyHelper helper = (PropertyHelper)e.OldValue;

            if (helper.ValueType == typeof(System.Single))
            {
                helper.Value = Convert.ToSingle(e.NewValue);
            }
            else if (helper.ValueType == typeof(Color))
            {
                helper.Value = Color.FromName(Convert.ToString(e.NewValue));
            }
            else if (helper.ValueType == typeof(ElementShape))
            {
                helper.Value = new RoundRectShape(Convert.ToInt32(e.NewValue));
            }
            else
            {
                helper.Value = e.NewValue;
            }

            e.NewValue = helper;
        }

        private void radTreeView1_EditorInitialized(object sender, TreeNodeEditorInitializedEventArgs e)
        {
            TreeViewDropDownListEditor editor = e.Editor as TreeViewDropDownListEditor;
            if (editor != null)
            {
                RadDropDownListElement listElement = (RadDropDownListElement)editor.EditorElement;
                listElement.DropDownStyle = RadDropDownStyle.DropDownList;
                if (listElement.Items.Count == 0)
                {
                    listElement.Items.Add(new RadListDataItem("White", "White"));
                    listElement.Items.Add(new RadListDataItem("Black", "Black"));
                    listElement.Items.Add(new RadListDataItem("Gray", "Gray"));
                    listElement.Items.Add(new RadListDataItem("Red", "Red"));
                    listElement.Items.Add(new RadListDataItem("Blue", "Blue"));
                    listElement.Items.Add(new RadListDataItem("Green", "Green"));
                    listElement.Items.Add(new RadListDataItem("Yellow", "Yellow"));
                }
                listElement.SelectedValue = ((PropertyHelper)e.Node.Value).ToString();
            }
        }

        private void radTreeView1_EditorRequired(object sender, TreeNodeEditorRequiredEventArgs e)
        {
            if (e.Node.Value == DBNull.Value)
            {
                return;
            }

            PropertyHelper helper = (PropertyHelper)e.Node.Value;
            if (helper != null)
            {
                if (helper.ValueType == typeof(System.Single) || helper.ValueType == typeof(ElementShape))
                {
                    e.EditorType = typeof(TreeViewSpinEditor);
                }
                else if (helper.ValueType == typeof(string))
                {
                    e.EditorType = typeof(TreeViewTextBoxEditor);
                }
                else if (helper.ValueType == typeof(Color))
                {
                    e.EditorType = typeof(TreeViewDropDownListEditor);
                }
            }
        }

        protected override void WireEvents()
        {
            this.radCheckBoxAllowEdit.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxAllowEdit_ToggleStateChanged);
        }
    }
}
