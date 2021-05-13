using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Examples.WinControls.DataSources;
using System.IO;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.Data;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.Layouts;

namespace DemoAppsHub.ListViewExample
{
    public partial class ListViewExampleUserControl : UserControl
    {
        List<string> features = new List<string>() { "AirConditioner", "Mp3Player", "DVDPlayer", "ABS", "ASR", "Navigation" };
        private bool updatingToggleState = false;

        public ListViewExampleUserControl()
        {
            InitializeComponent();

            this.radCommandBar1.ThemeName = "TelerikMetroBlue";
            this.radListView1.ThemeName = "TelerikMetroBlue";

            ImagePrimitive searchIcon = new ImagePrimitive();
            searchIcon.Image = DemoAppsHub.Properties.Resources.TV_search;
            searchIcon.Alignment = ContentAlignment.MiddleRight;
            
            this.commandBarTextBoxFilter.TextBoxElement.StretchHorizontally = true;
            this.commandBarTextBoxFilter.TextBoxElement.Alignment = ContentAlignment.MiddleRight;
            this.commandBarTextBoxFilter.TextBoxElement.Children.Add(searchIcon);
            this.commandBarTextBoxFilter.TextBoxElement.TextBoxItem.Alignment = ContentAlignment.MiddleLeft;
            this.commandBarTextBoxFilter.TextBoxElement.TextBoxItem.PropertyChanged += new PropertyChangedEventHandler(TextBoxItem_PropertyChanged);

            this.radListView1.VisualItemFormatting += new Telerik.WinControls.UI.ListViewVisualItemEventHandler(radListView1_VisualItemFormatting);
            this.radListView1.ViewTypeChanged += new EventHandler(radListView1_ViewTypeChanged);
            this.radListView1.CellFormatting += new Telerik.WinControls.UI.ListViewCellFormattingEventHandler(radListView1_CellFormatting);

            this.radListView1.AllowEdit = false;
            this.radListView1.AllowRemove = false;

            this.radListView1_ViewTypeChanged(this, EventArgs.Empty);

            this.commandBarToggleDetails.MinSize = new Size(35, 35);
            this.commandBarToggleList.MinSize = new Size(35, 35);
            this.commandBarToggleTiles.MinSize = new Size(35, 35);

            this.commandBarTextBoxFilter.StretchVertically = true;
            this.commandBarTextBoxFilter.TextBoxElement.StretchVertically = true;

            this.commandBarDropDownGroup.StretchVertically = true;
            this.commandBarDropDownGroup.DropDownListElement.ItemHeight = 35;
            this.commandBarDropDownSort.StretchVertically = true;
            this.commandBarDropDownSort.DropDownListElement.ItemHeight = 35;
            this.commandBarStripElement1.OverflowButton.MinSize = new Size(35, 0);

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
        
        #region Event handlers

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.carsRatesDataTableTableAdapter.Fill(this.sofiaCarRentalDataSet.CarsRatesDataTable);

            this.commandBarDropDownGroup.SelectedIndex = 1;
        }

        void radListView1_BindingCompleted(object sender, System.EventArgs e)
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

        void radListView1_ColumnCreating(object sender, ListViewColumnCreatingEventArgs e)
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

        void radListView1_CellFormatting(object sender, ListViewCellFormattingEventArgs e)
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
                e.CellElement.Text = "<html><span style=\"color:#161112;font-size:11.5pt;\">" + e.CellElement.Text + "</span>";
            }
            else if (this.features.Contains(e.CellElement.Data.FieldName))
            {
                bool containsFeature = this.ContainsFeature(((DetailListViewDataCellElement)e.CellElement).Row, e.CellElement.Data.FieldName);
                string color = (containsFeature) ? "#050F70" : "#B52822";
                e.CellElement.ForeColor = (Color)(new ColorConverter().ConvertFromString(color));
                e.CellElement.Font = new Font(e.CellElement.Font.FontFamily, 10, GraphicsUnit.Point);
                e.CellElement.Text = (containsFeature) ? "YES" : "NO";
            }
            else if (e.CellElement.Data.HeaderText != "Picture")
            {
                e.CellElement.ForeColor = (Color)(new ColorConverter().ConvertFromString("#050F70"));
                e.CellElement.Font = new Font(e.CellElement.Font.FontFamily, 10, GraphicsUnit.Point);
                e.CellElement.Text = e.CellElement.Text;
            }
        }

        void radListView1_ViewTypeChanged(object sender, EventArgs e)
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

        void radListView1_VisualItemCreating(object sender, Telerik.WinControls.UI.ListViewVisualItemCreatingEventArgs e)
        {
            if (this.radListView1.ViewType == ListViewType.ListView && !(e.VisualItem is BaseListViewGroupVisualItem))
            {
                e.VisualItem = new CarsListVisualItem();
            }
        }

        void radListView1_VisualItemFormatting(object sender, Telerik.WinControls.UI.ListViewVisualItemEventArgs e)
        {
            if (e.VisualItem is BaseListViewGroupVisualItem)
            {
                return;
            }

            if (this.radListView1.ViewType == ListViewType.IconsView)
            {
                e.VisualItem.Font = new System.Drawing.Font("Segoe UI", 12);
                e.VisualItem.ForeColor = Color.Black;
                e.VisualItem.Text = "<html>" +
                   "<span style=\"color:#040203;font-size:12pt;\">" + e.VisualItem.Data["Make"] + " " + e.VisualItem.Data["Model"] + "</span>" +
                   "<br><span style=\"color:#040203;font-size:9pt;\">" + e.VisualItem.Data["CarYear"] + ", " + e.VisualItem.Data["CategoryName"] + "</span>" +
                   "<br><br><span style=\"color:#112164;font-size:9pt;\">" + GetFeatures(e.VisualItem.Data) + "</span>";

                e.VisualItem.ImageLayout = ImageLayout.Center;
                e.VisualItem.ImageAlignment = ContentAlignment.MiddleCenter;
            } 

            if (this.radListView1.ViewType == ListViewType.ListView)
            {
                e.VisualItem.Padding = new Padding(5, 5, 0, 5);
                e.VisualItem.Layout.LeftPart.Margin = new Padding(0, 0, 5, 0);
            }
        }

        void radListView1_ItemDataBound(object sender, Telerik.WinControls.UI.ListViewItemEventArgs e)
        {
            e.Item.Image = Image.FromFile(Application.StartupPath + @"\CarRentalImages\" + e.Item["ImageFileName"]);
        }

        void viewToggleButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
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

        void viewToggleButton_ToggleStateChanging(object sender, StateChangingEventArgs args)
        {
            if (!updatingToggleState && args.OldValue == ToggleState.On)
            {
                args.Cancel = true;
            }
        }

        void commandBarDropDownSort_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
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
        }
        
        void commandBarDropDownGroup_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
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

        void commandBarTextBoxFilter_TextChanged(object sender, EventArgs e)
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

        void TextBoxItem_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Bounds")
            {
                commandBarTextBoxFilter.TextBoxElement.TextBoxItem.HostedControl.MaximumSize = new Size((int)commandBarTextBoxFilter.DesiredSize.Width - 28, 0);
            }
        }

        #endregion
    }
}
