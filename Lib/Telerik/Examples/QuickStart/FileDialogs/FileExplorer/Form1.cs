using System;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinControls.FileDialogs;

namespace Telerik.Examples.WinControls.FileDialogs.FileExplorer
{
    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            InitializeComponent();

            this.explorerControl1.Filter = "Word Documents|*.doc;*.docx" +
                                        "|Excel Worksheets|*.xls;*.xlsx" +
                                        "|PowerPoint Presentations|*.ppt;*.pptx" +
                                        "|Office Files|*.doc;*.docx*.xls;*.xlsx;*.ppt*.pptx" +
                                        "|Image Files|*.jpg;*.png;*.bmp" +
                                        "|Text Files|*.txt;" +
                                        "|Archives Files|*.zip;*.rar" +
                                        "|All Files|*.*";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.filterDescriptorsDropDownList.DisplayMember = "FilterName";
            this.filterDescriptorsDropDownList.DataSource = this.explorerControl1.FilterDescriptors;
            this.explorerControl1.ViewModel.PropertyChanged += this.ViewModel_PropertyChanged;
            var selectableModel = this.explorerControl1.ViewModel as IMultiSelectable;
            if (selectableModel != null)
            {
                selectableModel.SelectedFileSystemInfoWrappers.CollectionChanged += (o, u) =>
                {
                    this.UpdateSafeFileNames();
                };
            }

            this.filterDescriptorsDropDownList.SelectedIndex = this.explorerControl1.FilterDescriptors.Count - 1;
            this.multiSelectCheckBox.IsChecked = true;
        }

        private void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "SelectedFileSystemObject" ||
                e.PropertyName == "SelectedFileSystemInfoWrappers" ||
                e.PropertyName == "MultiSelect")
            {
                this.UpdateSafeFileNames();
            }
        }

        private void UpdateSafeFileNames()
        {
            this.safeFileNamesListControl.DataSource = this.explorerControl1.SelectedSafeFileNames;
        }

        private void MultiSelectCheckBox_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.explorerControl1.MultiSelect = this.multiSelectCheckBox.IsChecked;
        }

        private void DragdropCheckBox_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.explorerControl1.IsDragDropEnabled = this.dragdropCheckBox.IsChecked;
        }

        private void ExpandToCurrDirCheckBox_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.explorerControl1.ExpandToCurrentDirectory = this.expandToCurrDirCheckBox.IsChecked;
        }

        private void ShowHiddenFilesCheckBox_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.explorerControl1.ShowHiddenFiles = this.showHiddenFilesCheckBox.IsChecked;
        }

        private void FilterDescriptorsDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.explorerControl1.FilterIndex = this.filterDescriptorsDropDownList.SelectedIndex;
        }
    }
}