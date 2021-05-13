using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.ListView.FirstLook
{
    public partial class Form1 : ListViewExamplesControl
    {
        public override Control ContentControl
        {
            get
            {
                return this.radPanel1;
            }
        }

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
            this.commandBarTextBoxFilter.TextBoxElement.TextBoxItem.PropertyChanged += new PropertyChangedEventHandler(TextBoxItem_PropertyChanged);

            this.radListView1.VisualItemFormatting += new ListViewVisualItemEventHandler(radListView1_VisualItemFormatting);
            this.radListView1.ViewTypeChanged += new EventHandler(radListView1_ViewTypeChanged);
            this.radListView1.CellFormatting += new ListViewCellFormattingEventHandler(radListView1_CellFormatting);
            this.radListView1.SortDescriptors.CollectionChanged += new NotifyCollectionChangedEventHandler(SortDescriptors_CollectionChanged);

            this.radListView1.AllowEdit = false;
            this.radListView1.AllowRemove = false;

            this.radListView1_ViewTypeChanged(this, EventArgs.Empty);
        }

        protected override void WireEvents()
        {
            this.radListView1.BindingCompleted += new EventHandler(this.radListView1_BindingCompleted);
            this.radListView1.VisualItemCreating += new ListViewVisualItemCreatingEventHandler(this.radListView1_VisualItemCreating);
            this.radListView1.ItemDataBound += new ListViewItemEventHandler(this.radListView1_ItemDataBound);
            this.radListView1.ColumnCreating += new ListViewColumnCreatingEventHandler(this.radListView1_ColumnCreating);
            this.commandBarToggleDetails.ToggleStateChanging += new StateChangingEventHandler(this.ViewToggleButton_ToggleStateChanging);
            this.commandBarToggleDetails.ToggleStateChanged += new StateChangedEventHandler(this.ViewToggleButton_ToggleStateChanged);
            this.commandBarToggleTiles.ToggleStateChanging += new StateChangingEventHandler(this.ViewToggleButton_ToggleStateChanging);
            this.commandBarToggleTiles.ToggleStateChanged += new StateChangedEventHandler(this.ViewToggleButton_ToggleStateChanged);
            this.commandBarToggleList.ToggleStateChanging += new StateChangingEventHandler(this.ViewToggleButton_ToggleStateChanging);
            this.commandBarToggleList.ToggleStateChanged += new StateChangedEventHandler(this.ViewToggleButton_ToggleStateChanged);
            this.commandBarTextBoxFilter.TextChanged += new EventHandler(this.commandBarTextBoxFilter_TextChanged);
            this.commandBarDropDownSort.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.commandBarDropDownSort_SelectedIndexChanged);
            this.commandBarDropDownGroup.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.commandBarDropDownGroup_SelectedIndexChanged);
        }

        private void SortDescriptors_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (this.radListView1.SortDescriptors.Count == 0)
            {
                this.commandBarDropDownSort.SelectedIndex = 0;
                return;
            }

            string columnName = this.radListView1.Columns[this.radListView1.SortDescriptors[0].PropertyName].HeaderText;
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

        private void radListView1_BindingCompleted(object sender, EventArgs e)
        {
            this.radListView1.Columns["ImageFileName"].Width = 180;
            this.radListView1.Columns["ImageFileName"].MinWidth = 180;
            this.radListView1.Columns["Make"].Width = 90;
            this.radListView1.Columns["Make"].MinWidth = 90;
            this.radListView1.Columns["Model"].Width = 110;
            this.radListView1.Columns["Model"].MinWidth = 110;
            this.radListView1.Columns["CarYear"].Width = 90;
            this.radListView1.Columns["CarYear"].MinWidth = 90;
            this.radListView1.Columns["CategoryName"].Width = 90;
            this.radListView1.Columns["CategoryName"].MinWidth = 90;

            int pictureColumnIndex = this.radListView1.Columns.IndexOf("ImageFileName");
            this.radListView1.Columns.Move(pictureColumnIndex, 0);
        }

        private void radListView1_ColumnCreating(object sender, ListViewColumnCreatingEventArgs e)
        {
            if (e.Column.FieldName == "CarID")
                e.Column.Visible = false;

            if (e.Column.FieldName == "ImageFileName")
                e.Column.HeaderText = "Picture";

            if (e.Column.FieldName == "CarYear")
                e.Column.HeaderText = "Manufactured";

            if (e.Column.FieldName == "CategoryName")
                e.Column.HeaderText = "Category";

            if (e.Column.FieldName == "Mp3Player")
                e.Column.HeaderText = "MP3";

            if (e.Column.FieldName == "DVDPlayer")
                e.Column.HeaderText = "DVD";

            if (e.Column.FieldName == "AirConditioner")
            {
                e.Column.HeaderText = "Air Cond.";
                e.Column.Width = 90;
                e.Column.MinWidth = 90;
            }

            if (e.Column.FieldName == "Daily" || e.Column.FieldName == "Weekly" || e.Column.FieldName == "Monthly" || e.Column.FieldName == "Available")
                e.Column.Visible = false;

            if (features.Contains(e.Column.FieldName))
            {
                e.Column.Width = 55;
                e.Column.MinWidth = 55;
            }
        }

        private void radListView1_CellFormatting(object sender, ListViewCellFormattingEventArgs e)
        {
            if (e.CellElement is DetailListViewHeaderCellElement)
            {
                return;
            }

            if (e.CellElement.Data.HeaderText == "Picture")
            {
                ((DetailListViewDataCellElement)e.CellElement).Image = ((DetailListViewDataCellElement)e.CellElement).Row.Image;
                e.CellElement.Text = "";
                e.CellElement.ImageAlignment = ContentAlignment.MiddleCenter;
                e.CellElement.TextImageRelation = TextImageRelation.Overlay;
            }
            else
            {
                e.CellElement.Image = null;
            }

            if (e.CellElement.Data.HeaderText == "Make" || e.CellElement.Data.HeaderText == "Model")
            {
                string color = "#161112";
                if (TelerikHelper.IsDarkTheme(this.radListView1.ThemeName))
                {
                    color = "#FFFFFF";
                }

                e.CellElement.Text = "<html><span style=\"color:" + color + ";font-size:11.5pt;\">" + e.CellElement.Text + "</span>";
            }
            else if (this.features.Contains(e.CellElement.Data.FieldName))
            {
                bool containsFeature = this.ContainsFeature(((DetailListViewDataCellElement)e.CellElement).Row, e.CellElement.Data.FieldName);
                string color = (containsFeature) ? "#4C7C37" : "#B52822";
                e.CellElement.ForeColor = (Color)(new ColorConverter().ConvertFromString(color));
                e.CellElement.Font = new Font(e.CellElement.Font.FontFamily, 10, GraphicsUnit.Point);
                e.CellElement.Text = (containsFeature) ? "YES" : "NO";
            }
            else if (e.CellElement.Data.HeaderText != "Picture")
            {
                string color = "#050F70";
                if (TelerikHelper.IsDarkTheme(this.radListView1.ThemeName))
                {
                    color = "#FFFFFF";
                }

                e.CellElement.ForeColor = (Color)(new ColorConverter().ConvertFromString(color));
                e.CellElement.Font = new Font(e.CellElement.Font.FontFamily, 10, GraphicsUnit.Point);
                e.CellElement.Text = e.CellElement.Text;
            }
        }

        private void radListView1_ViewTypeChanged(object sender, EventArgs e)
        {
            switch (radListView1.ViewType)
            {
                case ListViewType.ListView:
                    SetupSimpleListView();
                    break;
                case ListViewType.IconsView:
                    SetupIconsView();
                    break;
                case ListViewType.DetailsView:
                    SetupDetailsView();
                    break;
            }
        }

        private void SetupDetailsView()
        {
            this.radListView1.ItemSize = new Size(0, 110);
        }

        private void SetupIconsView()
        {
            this.radListView1.ItemSize = new Size(295, 120);
            this.radListView1.ItemSpacing = 5;
            this.radListView1.GroupIndent = 0;
        }

        private void SetupSimpleListView()
        {
            this.radListView1.AllowArbitraryItemHeight = true;

        }

        private List<string> features = new List<string>() { "AirConditioner", "Mp3Player", "DVDPlayer", "ABS", "ASR", "Navigation" };

        private bool ContainsFeature(ListViewDataItem item, string feature)
        {
            return item[feature] != null && Convert.ToInt32(item[feature]) != 0;
        }

        private string GetFeatures(ListViewDataItem item)
        {
            StringBuilder featuresString = new StringBuilder();

            foreach (string feature in this.features)
            {
                if (ContainsFeature(item, feature))
                {
                    featuresString.Append(feature + ", ");
                }
            }

            if (featuresString.Length > 1)
            {
                featuresString.Remove(featuresString.Length - 2, 2);
            }

            return featuresString.ToString();
        }

        private void radListView1_VisualItemCreating(object sender, Telerik.WinControls.UI.ListViewVisualItemCreatingEventArgs e)
        {
            if (this.radListView1.ViewType == ListViewType.ListView && !(e.VisualItem is BaseListViewGroupVisualItem))
            {
                e.VisualItem = new CarsListVisualItem();
            }
        }

        private void radListView1_VisualItemFormatting(object sender, Telerik.WinControls.UI.ListViewVisualItemEventArgs e)
        {
            if (e.VisualItem is BaseListViewGroupVisualItem)
            {
                return;
            }

            if (this.radListView1.ViewType == ListViewType.IconsView)
            {
                string color = "#112164";
                if (TelerikHelper.IsDarkTheme(this.radListView1.ThemeName))
                {
                    color = "#FFFFFF";
                }

                e.VisualItem.Text = "<html>" +
                    "<span style=\"font-size:12pt;\">" + e.VisualItem.Data["Make"] + " " + e.VisualItem.Data["Model"] + "</span>" +
                   "<br><span style=\"font-size:9pt;\">" + e.VisualItem.Data["CarYear"] + ", " + e.VisualItem.Data["CategoryName"] + "</span>" +
                   "<br><br><span style=\"color:" + color + ";font-size:9pt;\">" + GetFeatures(e.VisualItem.Data) + "</span>";

                e.VisualItem.ImageLayout = ImageLayout.Center;
                e.VisualItem.ImageAlignment = ContentAlignment.MiddleCenter;
            }

            if (this.radListView1.ViewType == ListViewType.ListView)
            {
                e.VisualItem.Padding = new Padding(5, 5, 0, 5);
                e.VisualItem.Layout.LeftPart.Margin = new Padding(0, 0, 5, 0);
            }
        }

        private void radListView1_ItemDataBound(object sender, Telerik.WinControls.UI.ListViewItemEventArgs e)
        {
            e.Item.Image = Image.FromFile(Application.StartupPath + @"\Resources\CarRentalImages\" + e.Item["ImageFileName"]);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.carsRatesDataTableTableAdapter.Fill(this.sofiaCarRentalDataSet.CarsRatesDataTable);

            this.commandBarDropDownGroup.SelectedIndex = 1;
        }

        private bool updatingToggleState = false;

        private void ViewToggleButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (updatingToggleState)
            {
                return;
            }

            this.updatingToggleState = true;

            if (this.commandBarToggleDetails != sender)
            {
                this.commandBarToggleDetails.ToggleState = ToggleState.Off;
            }

            if (this.commandBarToggleList != sender)
            {
                this.commandBarToggleList.ToggleState = ToggleState.Off;
            }

            if (this.commandBarToggleTiles != sender)
            {
                this.commandBarToggleTiles.ToggleState = ToggleState.Off;
            }

            this.updatingToggleState = false;

            if (this.commandBarToggleDetails.ToggleState == ToggleState.On)
            {
                this.radListView1.ViewType = ListViewType.DetailsView;
            }

            if (this.commandBarToggleList.ToggleState == ToggleState.On)
            {
                this.radListView1.ViewType = ListViewType.ListView;
            }

            if (this.commandBarToggleTiles.ToggleState == ToggleState.On)
            {
                this.radListView1.ViewType = ListViewType.IconsView;
            }
        }

        private void ViewToggleButton_ToggleStateChanging(object sender, StateChangingEventArgs args)
        {
            if (!updatingToggleState && args.OldValue == ToggleState.On)
            {
                args.Cancel = true;
            }
        }

        private void commandBarDropDownSort_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radListView1.SortDescriptors.CollectionChanged -= SortDescriptors_CollectionChanged;

            this.radListView1.SortDescriptors.Clear();
            switch (this.commandBarDropDownSort.Text)
            {
                case "Make":
                    this.radListView1.SortDescriptors.Add(new SortDescriptor("Make", ListSortDirection.Ascending));
                    this.radListView1.EnableSorting = true;
                    break;
                case "Model":
                    this.radListView1.SortDescriptors.Add(new SortDescriptor("Model", ListSortDirection.Ascending));
                    this.radListView1.EnableSorting = true;
                    break;
                case "Category":
                    this.radListView1.SortDescriptors.Add(new SortDescriptor("CategoryName", ListSortDirection.Ascending));
                    this.radListView1.EnableSorting = true;
                    break;
                case "Year":
                    this.radListView1.SortDescriptors.Add(new SortDescriptor("CarYear", ListSortDirection.Ascending));
                    this.radListView1.EnableSorting = true;
                    break;
            }

            this.radListView1.SortDescriptors.CollectionChanged += SortDescriptors_CollectionChanged;
        }

        private void commandBarDropDownGroup_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radListView1.GroupDescriptors.Clear();
            switch (this.commandBarDropDownGroup.Text)
            {
                case "None":
                    this.radListView1.EnableGrouping = false;
                    this.radListView1.ShowGroups = false;
                    break;
                case "Make":
                    this.radListView1.GroupDescriptors.Add(new GroupDescriptor(
                        new SortDescriptor[] { new SortDescriptor("Make", ListSortDirection.Ascending) }));
                    this.radListView1.EnableGrouping = true;
                    this.radListView1.ShowGroups = true;
                    break;
                case "Category":
                    this.radListView1.GroupDescriptors.Add(new GroupDescriptor(
                        new SortDescriptor[] { new SortDescriptor("CategoryName", ListSortDirection.Ascending) }));
                    this.radListView1.EnableGrouping = true;
                    this.radListView1.ShowGroups = true;
                    break;
                case "Year":
                    this.radListView1.GroupDescriptors.Add(new GroupDescriptor(
                        new SortDescriptor[] { new SortDescriptor("CarYear", ListSortDirection.Ascending) }));
                    this.radListView1.EnableGrouping = true;
                    this.radListView1.ShowGroups = true;
                    break;
            }
        }

        private void commandBarTextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            this.radListView1.FilterDescriptors.Clear();

            if (String.IsNullOrEmpty(this.commandBarTextBoxFilter.Text))
            {
                this.radListView1.EnableFiltering = false;
            }
            else
            {
                this.radListView1.FilterDescriptors.LogicalOperator = FilterLogicalOperator.Or;
                this.radListView1.FilterDescriptors.Add("Make", FilterOperator.Contains, this.commandBarTextBoxFilter.Text);
                this.radListView1.FilterDescriptors.Add("Model", FilterOperator.Contains, this.commandBarTextBoxFilter.Text);
                this.radListView1.EnableFiltering = true;
            }
        }

        private void TextBoxItem_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Bounds")
            {
                commandBarTextBoxFilter.TextBoxElement.TextBoxItem.HostedControl.MaximumSize = new Size((int)commandBarTextBoxFilter.DesiredSize.Width - 28, 0);
            }
        }
    }

    public class CarsListVisualItem : SimpleListViewVisualItem
    {
        private LightVisualElement element1;
        private LightVisualElement element2;
        private LightVisualElement element3;
        private LightVisualElement element4;
        private StackLayoutPanel layout;

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.layout = new StackLayoutPanel();
            this.layout.EqualChildrenWidth = true;
            this.layout.Margin = new Padding(180, 30, 0, 0);

            this.element1 = new LightVisualElement();
            element1.TextAlignment = ContentAlignment.MiddleLeft;
            element1.MinSize = new Size(170, 0);
            element1.NotifyParentOnMouseInput = true;
            element1.ShouldHandleMouseInput = false;
            this.layout.Children.Add(this.element1);

            this.element2 = new LightVisualElement();
            element2.TextAlignment = ContentAlignment.MiddleLeft;
            element2.MinSize = new Size(170, 0);
            element2.NotifyParentOnMouseInput = true;
            element2.ShouldHandleMouseInput = false;
            this.layout.Children.Add(this.element2);

            this.element3 = new LightVisualElement();
            element3.TextAlignment = ContentAlignment.MiddleLeft;
            element3.MinSize = new Size(170, 0);
            element3.NotifyParentOnMouseInput = true;
            element3.ShouldHandleMouseInput = false;
            this.layout.Children.Add(this.element3);

            this.element4 = new LightVisualElement();
            element4.TextAlignment = ContentAlignment.MiddleLeft;
            element4.MinSize = new Size(170, 0);
            element4.NotifyParentOnMouseInput = true;
            element4.ShouldHandleMouseInput = false;
            this.layout.Children.Add(this.element4);

            this.Children.Add(this.layout);
        }

        private bool ContainsFeature(ListViewDataItem item, string feature)
        {
            return item[feature] != null && Convert.ToInt32(item[feature]) != 0;
        }

        protected override void SynchronizeProperties()
        {
            base.SynchronizeProperties();

            RadElement element = this.FindAncestor<RadListViewElement>();

            if (element == null)
            {
                return;
            }

            string theme = (element.ElementTree.Control as RadListView).ThemeName;
            string color1 = "#141718";
            string color2 = "#010102";
            if (TelerikHelper.IsDarkTheme(theme))
            {
                color1 = "#FFFFFF";
                color2 = "#FFFFFF";
            }

            this.Text = "<html><span style=\"color:" + color1 + ";font-size:14.5pt;\">" + this.Data["Make"] + " " + this.Data["Model"] + "</span>";

            this.element1.Text = string.Format(cardTermplate, color2) +
                "Manufactured:<span style=\"color:" + color2 + ";font-family:Segoe UI;\">" + this.Data["CarYear"] + "</span>" +
                "<br>Category:<span style=\"color:" + color2 + ";font-family:Segoe UI;\">" + this.Data["CategoryName"] + "</span></span>";

            this.element2.Text = string.Format(cardTermplate, color2) +
                "ABS:" + this.GetContainsFeatureText("ABS") +
                "<br>ESR:" + this.GetContainsFeatureText("ESR") + "</span>";

            this.element3.Text = string.Format(cardTermplate, color2) +
                "MP3 Player:" + this.GetContainsFeatureText("Mp3Player") +
                "<br>DVD Player:" + this.GetContainsFeatureText("DVDPlayer") + "</span>";

            this.element4.Text = string.Format(cardTermplate, color2) +
                "Air Conditioner:" + this.GetContainsFeatureText("AirConditioner") +
                "<br>Navigation:" + this.GetContainsFeatureText("Navigation") + "</span>";
            this.TextAlignment = ContentAlignment.TopLeft;
        }

        string cardTermplate = "<html><span style=\"color:{0};font-size:10.5pt;font-family:Segoe UI Semibold;\">";
        string yesTemplate = "<span style=\"color:#4C7C37;font-family:Segoe UI;\">YES</span>";
        string noTemplate = "<span style=\"color:#D71B0E;\">NO</span>";
        private string GetContainsFeatureText(string feature)
        {
            if (this.ContainsFeature(this.Data, feature))
            {
                return yesTemplate;
            }
            else
            {
                return noTemplate;
            }
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(SimpleListViewVisualItem);
            }
        }
    }
}
