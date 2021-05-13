using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.CardView.CustomItems
{
    public partial class Form1 : ExamplesForm
    {
        private List<string> features;
        Font makeFont = new Font("Segoe UI Light", 18f);
        Font yearFont = new Font("Segoe UI", 13.5f);
        Font checkBoxFont = new Font("Segoe UI", 10.5f);

        public Form1()
        {
            InitializeComponent();

            ImagePrimitive searchIcon = new ImagePrimitive();
            searchIcon.Image = Telerik.Examples.WinControls.Properties.Resources.TV_search;
            searchIcon.Alignment = ContentAlignment.MiddleRight;
            this.commandBarTextBoxFilter.TextBoxElement.StretchHorizontally = true;
            this.commandBarTextBoxFilter.TextBoxElement.Alignment = ContentAlignment.MiddleRight;
            this.commandBarTextBoxFilter.TextBoxElement.ButtonsStack.Children.Add(searchIcon);
            this.commandBarTextBoxFilter.TextBoxElement.TextBoxItem.Alignment = ContentAlignment.MiddleLeft;
            this.commandBarTextBoxFilter.TextBoxElement.TextBoxItem.PropertyChanged += TextBoxItem_PropertyChanged;
            this.radCardView1.AllowEdit = false;
            this.features = new List<string>() { "AirConditioner", "Mp3Player", "DVDPlayer", "ABS", "ASR", "Navigation" };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.carsRatesDataTableTableAdapter.Fill(this.sofiaCarRentalDataSet.CarsRatesDataTable);

            this.commandBarDropDownGroup.SelectedIndex = 1;
        }

        protected override void WireEvents()
        {
            base.WireEvents();
            this.radCardView1.CardViewItemCreating += radCardView1_CardViewItemCreating;
            this.radCardView1.CardViewItemFormatting += radCardView1_CardViewItemFormatting;
            this.radCardView1.SortDescriptors.CollectionChanged += SortDescriptors_CollectionChanged;
            this.commandBarTextBoxFilter.TextChanged += commandBarTextBoxFilter_TextChanged;
            this.commandBarDropDownSort.SelectedIndexChanged += commandBarDropDownSort_SelectedIndexChanged;
            this.commandBarDropDownGroup.SelectedIndexChanged += commandBarDropDownGroup_SelectedIndexChanged;
        }

        private bool ContainsFeature(ListViewDataItem item, string feature)
        {
            return item[feature] != null && Convert.ToInt32(item[feature]) != 0;
        }

        Font checkBoxItemsFont = new Font("Segoe UI", 10.5f);
        void radCardView1_CardViewItemCreating(object sender, CardViewItemCreatingEventArgs e)
        {
            CardViewGroupItem groupItem = e.NewItem as CardViewGroupItem;
            if (groupItem != null)
            {
                groupItem.DrawText = true;
                groupItem.Font = this.checkBoxItemsFont;
                groupItem.Text = "Extras";
            }

            CardViewItem cardViewItem = e.NewItem as CardViewItem;
            if (cardViewItem == null || string.IsNullOrEmpty(cardViewItem.FieldName))
            {
                return;
            }

            if (this.features.Contains(cardViewItem.FieldName))
            {
                CheckBoxCardViewItem checkBoxItem = new CheckBoxCardViewItem();
                checkBoxItem.FieldName = cardViewItem.FieldName;
                e.NewItem = checkBoxItem;
            }
        }

        void radCardView1_CardViewItemFormatting(object sender, CardViewItemFormattingEventArgs e)
        {
            CardViewItem cardViewItem = e.Item as CardViewItem;
            if (cardViewItem == null || string.IsNullOrEmpty(cardViewItem.FieldName))
            {
                return;
            }

            if (cardViewItem.FieldName == "ImageFileName")
            {
                cardViewItem.TextSizeMode = LayoutItemTextSizeMode.Fixed;
                cardViewItem.TextFixedSize = 0;
                cardViewItem.EditorItem.DrawText = false;
                cardViewItem.EditorItem.DrawImage = true;
                Image image = Image.FromFile(Application.StartupPath + @"\Resources\CarRentalImages\" + 
                    e.VisualItem.Data["ImageFileName"]);
                float factor = 160 / (float)image.Height;
                Bitmap resizedImage = new Bitmap(image, new SizeF(factor * image.Width, factor * image.Height).ToSize());
                cardViewItem.EditorItem.Image = resizedImage;
            }
            else if (cardViewItem.FieldName == "Make")
            {
                cardViewItem.EditorItem.Font = makeFont;
                cardViewItem.EditorItem.Text = e.VisualItem.Data["Make"] + "  " + e.VisualItem.Data["Model"];
            }
            else if(cardViewItem.FieldName == "CarYear" || cardViewItem.FieldName == "CategoryName")
            {
                cardViewItem.EditorItem.Font = yearFont;
            }

            CheckBoxCardViewItem checkBoxItem = e.Item as CheckBoxCardViewItem;
            if (checkBoxItem != null)
            {
                (checkBoxItem.EditorItem as CheckBoxEditorItem).Font = checkBoxFont;
            }
        }

        private void commandBarDropDownSort_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radCardView1.SortDescriptors.CollectionChanged -= SortDescriptors_CollectionChanged;

            this.radCardView1.SortDescriptors.Clear();
            switch (this.commandBarDropDownSort.Text)
            {
                case "Make":
                    this.radCardView1.SortDescriptors.Add(new SortDescriptor("Make", ListSortDirection.Ascending));
                    this.radCardView1.EnableSorting = true;
                    break;
                case "Model":
                    this.radCardView1.SortDescriptors.Add(new SortDescriptor("Model", ListSortDirection.Ascending));
                    this.radCardView1.EnableSorting = true;
                    break;
                case "Category":
                    this.radCardView1.SortDescriptors.Add(new SortDescriptor("CategoryName", ListSortDirection.Ascending));
                    this.radCardView1.EnableSorting = true;
                    break;
                case "Year":
                    this.radCardView1.SortDescriptors.Add(new SortDescriptor("CarYear", ListSortDirection.Ascending));
                    this.radCardView1.EnableSorting = true;
                    break;
            }

            this.radCardView1.SortDescriptors.CollectionChanged += SortDescriptors_CollectionChanged;
        }

        private void commandBarDropDownGroup_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radCardView1.GroupDescriptors.Clear();
            switch (this.commandBarDropDownGroup.Text)
            {
                case "None":
                    this.radCardView1.EnableGrouping = false;
                    this.radCardView1.ShowGroups = false;
                    break;
                case "Make":
                    this.radCardView1.GroupDescriptors.Add(new GroupDescriptor(
                        new SortDescriptor[] { new SortDescriptor("Make", ListSortDirection.Ascending) }));
                    this.radCardView1.EnableGrouping = true;
                    this.radCardView1.ShowGroups = true;
                    break;
                case "Category":
                    this.radCardView1.GroupDescriptors.Add(new GroupDescriptor(
                        new SortDescriptor[] { new SortDescriptor("CategoryName", ListSortDirection.Ascending) }));
                    this.radCardView1.EnableGrouping = true;
                    this.radCardView1.ShowGroups = true;
                    break;
                case "Year":
                    this.radCardView1.GroupDescriptors.Add(new GroupDescriptor(
                        new SortDescriptor[] { new SortDescriptor("CarYear", ListSortDirection.Ascending) }));
                    this.radCardView1.EnableGrouping = true;
                    this.radCardView1.ShowGroups = true;
                    break;
            }
        }

        private void commandBarTextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            this.radCardView1.FilterDescriptors.Clear();

            if (String.IsNullOrEmpty(this.commandBarTextBoxFilter.Text))
            {
                this.radCardView1.EnableFiltering = false;
            }
            else
            {
                this.radCardView1.FilterDescriptors.LogicalOperator = FilterLogicalOperator.Or;
                this.radCardView1.FilterDescriptors.Add("Make", FilterOperator.Contains, this.commandBarTextBoxFilter.Text);
                this.radCardView1.FilterDescriptors.Add("Model", FilterOperator.Contains, this.commandBarTextBoxFilter.Text);
                this.radCardView1.EnableFiltering = true;
            }
        }

        private void TextBoxItem_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Bounds")
            {
                commandBarTextBoxFilter.TextBoxElement.TextBoxItem.HostedControl.MaximumSize = new Size((int)commandBarTextBoxFilter.DesiredSize.Width - 28, 0);
            }
        }

        private void SortDescriptors_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (this.radCardView1.SortDescriptors.Count == 0)
            {
                this.commandBarDropDownSort.SelectedIndex = 0;
                return;
            }

            string columnName = this.radCardView1.Columns[this.radCardView1.SortDescriptors[0].PropertyName].HeaderText;
            if (columnName == "Manufactured")
            {
                columnName = "Year";
            }
            RadListDataItem item = this.commandBarDropDownSort.ListElement.FindItemExact(columnName, false);
            if (item != null)
            {
                this.commandBarDropDownSort.SelectedItem = item;
            }
        }
    }
    
    public class CheckBoxCardViewItem : CardViewItem
    {
        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            this.TextSizeMode = LayoutItemTextSizeMode.Proportional;
            this.TextProportionalSize = 0;
        }

        protected override CardViewEditorItem CreateEditorItem()
        {
            return new CheckBoxEditorItem();
        }

        public override void Synchronize()
        {
            CardListViewVisualItem cardVisualItem = this.FindAncestor<CardListViewVisualItem>();
            if (this.CardField == null || cardVisualItem == null || cardVisualItem.Data == null)
            {
                return;
            }
            
            RadCheckBoxElement checkBox = (this.EditorItem as CheckBoxEditorItem).Checkbox;
            checkBox.Text = this.CardField.HeaderText;
            object data = cardVisualItem.Data[this.CardField];
            checkBox.Checked = this.ContainsFeature(cardVisualItem.Data, this.FieldName);
        }

        private bool ContainsFeature(ListViewDataItem item, string feature)
        {
            return item[feature] != null && Convert.ToInt32(item[feature]) != 0;
        }
    }

    public class CheckBoxEditorItem : CardViewEditorItem
    {
        private RadCheckBoxElement checkbox;

        public RadCheckBoxElement Checkbox
        {
            get { return this.checkbox; }
            set { this.checkbox = value; }
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            this.checkbox = new RadCheckBoxElement();
            this.Children.Add(this.checkbox);
            this.checkbox.ToggleStateChanged += checkbox_ToggleStateChanged;
        }

        void checkbox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            // on check box value changed we need to change the value in DataSource
        }
    }
}
