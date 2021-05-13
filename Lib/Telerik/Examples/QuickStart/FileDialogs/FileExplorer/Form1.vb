Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls.FileDialogs

Namespace Telerik.Examples.WinControls.FileDialogs.FileExplorer
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Public Sub New()
            InitializeComponent()

            Me.explorerControl1.Filter = "Word Documents|*.doc;*.docx" & "|Excel Worksheets|*.xls;*.xlsx" & "|PowerPoint Presentations|*.ppt;*.pptx" & "|Office Files|*.doc;*.docx*.xls;*.xlsx;*.ppt*.pptx" & "|Image Files|*.jpg;*.png;*.bmp" & "|Text Files|*.txt;" & "|Archives Files|*.zip;*.rar" & "|All Files|*.*"
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Me.filterDescriptorsDropDownList.DisplayMember = "FilterName"
            Me.filterDescriptorsDropDownList.DataSource = Me.explorerControl1.FilterDescriptors
            AddHandler Me.explorerControl1.ViewModel.PropertyChanged, AddressOf Me.ViewModel_PropertyChanged
            Dim selectableModel As IMultiSelectable = TryCast(Me.explorerControl1.ViewModel, IMultiSelectable)

            If selectableModel IsNot Nothing Then
                AddHandler selectableModel.SelectedFileSystemInfoWrappers.CollectionChanged, Sub(o, u)
                                                                                                 Me.UpdateSafeFileNames()
                                                                                             End Sub
            End If

            Me.filterDescriptorsDropDownList.SelectedIndex = Me.explorerControl1.FilterDescriptors.Count - 1
            Me.multiSelectCheckBox.IsChecked = True
        End Sub

        Private Sub ViewModel_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs)
            If e.PropertyName = "SelectedFileSystemObject" OrElse e.PropertyName = "SelectedFileSystemInfoWrappers" OrElse e.PropertyName = "MultiSelect" Then
                Me.UpdateSafeFileNames()
            End If
        End Sub

        Private Sub UpdateSafeFileNames()
            Me.safeFileNamesListControl.DataSource = Me.explorerControl1.SelectedSafeFileNames
        End Sub

        Private Sub MultiSelectCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.explorerControl1.MultiSelect = Me.multiSelectCheckBox.IsChecked
        End Sub

        Private Sub DragdropCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.explorerControl1.IsDragDropEnabled = Me.dragdropCheckBox.IsChecked
        End Sub

        Private Sub ExpandToCurrDirCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.explorerControl1.ExpandToCurrentDirectory = Me.expandToCurrDirCheckBox.IsChecked
        End Sub

        Private Sub ShowHiddenFilesCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.explorerControl1.ShowHiddenFiles = Me.showHiddenFilesCheckBox.IsChecked
        End Sub

        Private Sub FilterDescriptorsDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.explorerControl1.FilterIndex = Me.filterDescriptorsDropDownList.SelectedIndex
        End Sub
    End Class
End Namespace
