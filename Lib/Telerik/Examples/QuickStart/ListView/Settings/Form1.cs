using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.ListView.Settings
{
    public partial class Form1 : ListViewExamplesControl
    {
        public Form1()
        {
            InitializeComponent();

            this.radGroupBoxDetailView.Visible = false;
            this.radGroupBoxIconView.Visible = false;
            this.radGroupBoxIconView.Location = this.radGroupBoxDetailView.Location;

            SyncSettings();
        }

        protected override void WireEvents()
        {
            this.radCheckBoxShowCheckboxes.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxShowCheckboxes_ToggleStateChanged);
            this.radCheckBoxGroups.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxGroups_ToggleStateChanged);
            this.radCheckBoxFullRowSelect.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxFullRowSelect_ToggleStateChanged);
            this.radCheckBoxArbWidth.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxArbWidth_ToggleStateChanged);
            this.radCheckBoxArbHeight.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxArbHeight_ToggleStateChanged);
            this.radSpinEditorGroupHeight.ValueChanged += new System.EventHandler(this.radSpinEditorGroupHeight_ValueChanged);
            this.radSpinEditorItemHeight.ValueChanged += new System.EventHandler(this.radSpinEditorItemHeight_ValueChanged);
            this.radSpinEditorItemWidth.ValueChanged += new System.EventHandler(this.radSpinEditorItemWidth_ValueChanged);
            this.radSpinEditorGroupIndent.ValueChanged += new System.EventHandler(this.radSpinEditorGroupIndent_ValueChanged);
            this.radSpinEditorItemSpacing.ValueChanged += new System.EventHandler(this.radSpinEditorItemSpacing_ValueChanged);
            this.radSpinEditorHeaderHeight.ValueChanged += new System.EventHandler(this.radSpinEditorHeaderHeight_ValueChanged);
            this.radCheckBoxColHeaders.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxColHeaders_ToggleStateChanged);
            this.radCheckBoxColSort.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxColSort_ToggleStateChanged);
            this.radCheckBoxColReorder.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxColReorder_ToggleStateChanged);
            this.radCheckBoxColResize.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxColResize_ToggleStateChanged);
            this.radDropDownList2.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList2_SelectedIndexChanged);
            this.radDropDownListViewType.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownListViewType_SelectedIndexChanged);
            this.radListView1.ViewTypeChanged += new System.EventHandler(this.radListView1_ViewTypeChanged);
            this.radButtonBestFitColumns.Click += new EventHandler(radButtonBestFitColumns_Click);
        }

        private void radButtonBestFitColumns_Click(object sender, EventArgs e)
        {
            DetailListViewElement detailView = this.radListView1.ListViewElement.ViewElement as DetailListViewElement;

            if (detailView != null)
            {
                detailView.BestFitColumns(ListViewBestFitColumnMode.AllCells);
            }
        }

        private void radDropDownListViewType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (this.radDropDownListViewType.Text)
            {
                case "List View":
                    this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.ListView;
                    break;
                case "Icon View":
                    this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
                    break;
                case "Detail View":
                    this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
                    break;
            }
        }

        private void radCheckBoxShowCheckboxes_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            bool isChecked = this.radCheckBoxShowCheckboxes.Checked;
            this.radListView1.ShowCheckBoxes = isChecked;
            this.radDropDownListCheckOnClickMode.Enabled = isChecked;
            if (isChecked)
            {
                this.radCheckBoxAllowEdit.Checked = false;
                this.radDropDownListCheckOnClickMode.SelectedIndex = 2;
            }
        }

        private void radCheckBoxGroups_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.ShowGroups = this.radCheckBoxGroups.Checked;
        }

        private void radCheckBoxKeyboardNavigation_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radListView1.KeyboardSearchEnabled = this.radCheckBoxKeyboardNavigation.Checked;
        }

        private void radCheckBoxArbWidth_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.AllowArbitraryItemWidth = this.radCheckBoxArbWidth.Checked;
        }

        private void radCheckBoxArbHeight_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.AllowArbitraryItemHeight = this.radCheckBoxArbHeight.Checked;
        }

        private void radCheckBoxFullRowSelect_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.FullRowSelect = this.radCheckBoxFullRowSelect.Checked;
        }

        private void radCheckBoxColHeaders_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.ShowColumnHeaders = this.radCheckBoxColHeaders.Checked;
        }

        private void radCheckBoxColResize_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.AllowColumnResize = this.radCheckBoxColResize.Checked;
        }

        private void radCheckBoxColReorder_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.AllowColumnReorder = this.radCheckBoxColReorder.Checked;
        }

        private void radCheckBoxColSort_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.EnableColumnSort = this.radCheckBoxColSort.Checked;
        }

        private void radSpinEditorHeaderHeight_ValueChanged(object sender, EventArgs e)
        {
            this.radListView1.HeaderHeight = (float)this.radSpinEditorHeaderHeight.Value;
        }

        private void radSpinEditorGroupIndent_ValueChanged(object sender, EventArgs e)
        {
            this.radListView1.GroupIndent = (int)this.radSpinEditorGroupIndent.Value;
        }

        private void radSpinEditorItemSpacing_ValueChanged(object sender, EventArgs e)
        {
            this.radListView1.ItemSpacing = (int)this.radSpinEditorItemSpacing.Value;
        }

        private void radSpinEditorItemWidth_ValueChanged(object sender, EventArgs e)
        {
            this.radListView1.ItemSize = new Size(
                (int)this.radSpinEditorItemWidth.Value,
                TelerikDpiHelper.DescaleInt(this.radListView1.ItemSize.Height, this.radListView1.RootElement.DpiScaleFactor));
        }

        private void radSpinEditorItemHeight_ValueChanged(object sender, EventArgs e)
        {
            this.radListView1.ItemSize = new Size(
                TelerikDpiHelper.DescaleInt(this.radListView1.ItemSize.Width, this.radListView1.RootElement.DpiScaleFactor), 
                (int)this.radSpinEditorItemHeight.Value);
        }

        private void radSpinEditorGroupHeight_ValueChanged(object sender, EventArgs e)
        {
            this.radListView1.GroupItemSize = new Size(
                TelerikDpiHelper.DescaleInt(this.radListView1.GroupItemSize.Width, this.radListView1.RootElement.DpiScaleFactor),
                (int)this.radSpinEditorGroupHeight.Value);
        }

        private void radDropDownList2_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.radListView1.ViewType == Telerik.WinControls.UI.ListViewType.IconsView)
            {
                this.radListView1.ListViewElement.ViewElement.Orientation = (this.radDropDownList2.Text == "Vertical") ?
                    Orientation.Vertical : Orientation.Horizontal;
            }
        }

        private void radListView1_ViewTypeChanged(object sender, EventArgs e)
        {
            this.radGroupBoxDetailView.Visible = false;
            this.radGroupBoxIconView.Visible = false;

            if (this.radListView1.ViewType == Telerik.WinControls.UI.ListViewType.DetailsView)
            {
                this.radGroupBoxDetailView.Visible = true;
                this.radListView1.ItemSize = new Size(200, 32);
            }
            if (this.radListView1.ViewType == Telerik.WinControls.UI.ListViewType.IconsView)
            {
                this.radGroupBoxIconView.Visible = true;
                this.radListView1.ItemSize = new Size(155, 46);
            }
            if (this.radListView1.ViewType == Telerik.WinControls.UI.ListViewType.ListView)
            {
                this.radListView1.ItemSize = new Size(200, 32);
            }

            SyncSettings();
        }

        private void SyncSettings()
        {
            this.radCheckBoxArbWidth.Checked = this.radListView1.AllowArbitraryItemWidth;
            this.radCheckBoxArbHeight.Checked = this.radListView1.AllowArbitraryItemHeight;
            this.radCheckBoxFullRowSelect.Checked = this.radListView1.FullRowSelect;
            this.radCheckBoxKeyboardNavigation.Checked = this.radListView1.KeyboardSearchEnabled;

            SizeF scaleFactor = this.radListView1.RootElement.DpiScaleFactor;
            this.radSpinEditorItemSpacing.Value = TelerikDpiHelper.DescaleInt(this.radListView1.ItemSpacing, scaleFactor);
            this.radSpinEditorGroupIndent.Value = TelerikDpiHelper.DescaleInt(this.radListView1.GroupIndent, scaleFactor);

            this.radSpinEditorItemWidth.Value = TelerikDpiHelper.DescaleInt(this.radListView1.ItemSize.Width, scaleFactor);
            this.radSpinEditorItemHeight.Value = TelerikDpiHelper.DescaleInt(this.radListView1.ItemSize.Height, scaleFactor);

            this.radSpinEditorGroupHeight.Value = TelerikDpiHelper.DescaleInt(this.radListView1.GroupItemSize.Height, scaleFactor);
        }

        public override Control ContentControl
        {
            get
            {
                return this.radPanel2;
            }
        }

        private void radDropDownListCheckOnClickMode_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (this.radDropDownListCheckOnClickMode.Text)
            {
                case "Off":
                    this.radListView1.CheckOnClickMode = CheckOnClickMode.Off;
                    break;
                case "First Click":
                    this.radListView1.CheckOnClickMode = CheckOnClickMode.FirstClick;
                    break;
                case "Second Click":
                    this.radListView1.CheckOnClickMode = CheckOnClickMode.SecondClick;
                    break;
            }
        }

        private void radCheckBoxMultiSelect_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radListView1.MultiSelect = this.radCheckBoxMultiSelect.Checked;
        }

        private void radCheckBoxAllowEdit_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radListView1.AllowEdit = this.radCheckBoxAllowEdit.Checked;
            if (this.radCheckBoxAllowEdit.Checked)
            {
                this.radCheckBoxShowCheckboxes.Checked = false;
            }
        }

        private void radCheckBoxHotTracking_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radListView1.HotTracking = this.radCheckBoxHotTracking.Checked;
        }

        private void radCheckBoxLassoSelection_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radListView1.EnableLassoSelection = this.radCheckBoxLassoSelection.Checked;
            if (this.radCheckBoxLassoSelection.Checked)
            {
                this.radCheckBoxMultiSelect.Checked = true;
            }
        }
    }
}
