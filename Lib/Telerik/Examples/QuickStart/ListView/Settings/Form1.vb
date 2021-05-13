Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ListView.Settings
    Partial Public Class Form1
        Inherits ListViewExamplesControl
        Public Sub New()
            InitializeComponent()

            Me.radGroupBoxDetailView.Visible = False
            Me.radGroupBoxIconView.Visible = False
            Me.radGroupBoxIconView.Location = Me.radGroupBoxDetailView.Location

            SyncSettings()
        End Sub

        Protected Overrides Sub WireEvents()
            AddHandler Me.radCheckBoxShowCheckboxes.ToggleStateChanged, AddressOf Me.radCheckBoxShowCheckboxes_ToggleStateChanged
            AddHandler Me.radCheckBoxGroups.ToggleStateChanged, AddressOf Me.radCheckBoxGroups_ToggleStateChanged
            AddHandler Me.radCheckBoxFullRowSelect.ToggleStateChanged, AddressOf Me.radCheckBoxFullRowSelect_ToggleStateChanged
            AddHandler Me.radCheckBoxArbWidth.ToggleStateChanged, AddressOf Me.radCheckBoxArbWidth_ToggleStateChanged
            AddHandler Me.radCheckBoxArbHeight.ToggleStateChanged, AddressOf Me.radCheckBoxArbHeight_ToggleStateChanged
            AddHandler Me.radSpinEditorGroupHeight.ValueChanged, AddressOf radSpinEditorGroupHeight_ValueChanged
            AddHandler Me.radSpinEditorItemHeight.ValueChanged, AddressOf radSpinEditorItemHeight_ValueChanged
            AddHandler Me.radSpinEditorItemWidth.ValueChanged, AddressOf radSpinEditorItemWidth_ValueChanged
            AddHandler Me.radSpinEditorGroupIndent.ValueChanged, AddressOf radSpinEditorGroupIndent_ValueChanged
            AddHandler Me.radSpinEditorItemSpacing.ValueChanged, AddressOf radSpinEditorItemSpacing_ValueChanged
            AddHandler Me.radSpinEditorHeaderHeight.ValueChanged, AddressOf radSpinEditorHeaderHeight_ValueChanged
            AddHandler Me.radCheckBoxColHeaders.ToggleStateChanged, AddressOf Me.radCheckBoxColHeaders_ToggleStateChanged
            AddHandler Me.radCheckBoxColSort.ToggleStateChanged, AddressOf Me.radCheckBoxColSort_ToggleStateChanged
            AddHandler Me.radCheckBoxColReorder.ToggleStateChanged, AddressOf Me.radCheckBoxColReorder_ToggleStateChanged
            AddHandler Me.radCheckBoxColResize.ToggleStateChanged, AddressOf Me.radCheckBoxColResize_ToggleStateChanged
            AddHandler Me.radDropDownList2.SelectedIndexChanged, AddressOf Me.radDropDownList2_SelectedIndexChanged
            AddHandler Me.radDropDownListViewType.SelectedIndexChanged, AddressOf Me.radDropDownListViewType_SelectedIndexChanged
            AddHandler Me.radListView1.ViewTypeChanged, AddressOf Me.radListView1_ViewTypeChanged
            AddHandler Me.radButtonBestFitColumns.Click, AddressOf radButtonBestFitColumns_Click
        End Sub

        Private Sub radButtonBestFitColumns_Click(sender As Object, e As EventArgs)
            Dim detailView As DetailListViewElement = TryCast(Me.radListView1.ListViewElement.ViewElement, DetailListViewElement)

            If detailView IsNot Nothing Then
                detailView.BestFitColumns(ListViewBestFitColumnMode.AllCells)
            End If
        End Sub

        Private Sub radDropDownListViewType_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Select Case Me.radDropDownListViewType.Text
                Case "List View"
                    Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.ListView
                    Exit Select
                Case "Icon View"
                    Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView
                    Exit Select
                Case "Detail View"
                    Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
                    Exit Select
            End Select
        End Sub

        Private Sub radCheckBoxShowCheckboxes_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs)
            Dim isChecked As Boolean = Me.radCheckBoxShowCheckboxes.Checked
            Me.radListView1.ShowCheckBoxes = isChecked
            Me.radDropDownListCheckOnClickMode.Enabled = isChecked
            If isChecked Then
                Me.radCheckBoxAllowEdit.Checked = False
                Me.radDropDownListCheckOnClickMode.SelectedIndex = 2
            End If
        End Sub

        Private Sub radCheckBoxGroups_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.radListView1.ShowGroups = Me.radCheckBoxGroups.Checked
        End Sub

        Private Sub radCheckBoxKeyboardNavigation_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radListView1.KeyboardSearchEnabled = Me.radCheckBoxKeyboardNavigation.Checked
        End Sub

        Private Sub radCheckBoxArbWidth_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.radListView1.AllowArbitraryItemWidth = Me.radCheckBoxArbWidth.Checked
        End Sub

        Private Sub radCheckBoxArbHeight_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.radListView1.AllowArbitraryItemHeight = Me.radCheckBoxArbHeight.Checked
        End Sub

        Private Sub radCheckBoxFullRowSelect_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.radListView1.FullRowSelect = Me.radCheckBoxFullRowSelect.Checked
        End Sub

        Private Sub radCheckBoxColHeaders_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.radListView1.ShowColumnHeaders = Me.radCheckBoxColHeaders.Checked
        End Sub

        Private Sub radCheckBoxColResize_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.radListView1.AllowColumnResize = Me.radCheckBoxColResize.Checked
        End Sub

        Private Sub radCheckBoxColReorder_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.radListView1.AllowColumnReorder = Me.radCheckBoxColReorder.Checked
        End Sub

        Private Sub radCheckBoxColSort_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.radListView1.EnableColumnSort = Me.radCheckBoxColSort.Checked
        End Sub

        Private Sub radSpinEditorHeaderHeight_ValueChanged(sender As Object, e As EventArgs)
            Me.radListView1.HeaderHeight = CSng(Me.radSpinEditorHeaderHeight.Value)
        End Sub

        Private Sub radSpinEditorGroupIndent_ValueChanged(sender As Object, e As EventArgs)
            Me.radListView1.GroupIndent = CInt(Me.radSpinEditorGroupIndent.Value)
        End Sub

        Private Sub radSpinEditorItemSpacing_ValueChanged(sender As Object, e As EventArgs)
            Me.radListView1.ItemSpacing = CInt(Me.radSpinEditorItemSpacing.Value)
        End Sub

        Private Sub radSpinEditorItemWidth_ValueChanged(sender As Object, e As EventArgs)
            Me.radListView1.ItemSize = New Size(
                CInt(Me.radSpinEditorItemWidth.Value),
                TelerikDpiHelper.DescaleInt(Me.radListView1.ItemSize.Height, Me.radListView1.RootElement.DpiScaleFactor))
        End Sub

        Private Sub radSpinEditorItemHeight_ValueChanged(sender As Object, e As EventArgs)
            Me.radListView1.ItemSize = New Size(
                TelerikDpiHelper.DescaleInt(Me.radListView1.ItemSize.Width, Me.radListView1.RootElement.DpiScaleFactor),
                CInt(Me.radSpinEditorItemHeight.Value))
        End Sub

        Private Sub radSpinEditorGroupHeight_ValueChanged(sender As Object, e As EventArgs)
            Me.radListView1.GroupItemSize = New Size(
                TelerikDpiHelper.DescaleInt(Me.radListView1.GroupItemSize.Width, Me.radListView1.RootElement.DpiScaleFactor),
                CInt(Me.radSpinEditorGroupHeight.Value))
        End Sub

        Private Sub radDropDownList2_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            If Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView Then
                Me.radListView1.ListViewElement.ViewElement.Orientation = If((Me.radDropDownList2.Text = "Vertical"), Orientation.Vertical, Orientation.Horizontal)
            End If
        End Sub

        Private Sub radListView1_ViewTypeChanged(sender As Object, e As EventArgs)
            Me.radGroupBoxDetailView.Visible = False
            Me.radGroupBoxIconView.Visible = False

            If Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView Then
                Me.radGroupBoxDetailView.Visible = True
                Me.radListView1.ItemSize = New Size(200, 32)
            End If
            If Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView Then
                Me.radGroupBoxIconView.Visible = True
                Me.radListView1.ItemSize = New Size(155, 46)
            End If
            If Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.ListView Then
                Me.radListView1.ItemSize = New Size(200, 32)
            End If

            SyncSettings()
        End Sub

        Private Sub SyncSettings()
            Me.radCheckBoxArbWidth.Checked = Me.radListView1.AllowArbitraryItemWidth
            Me.radCheckBoxArbHeight.Checked = Me.radListView1.AllowArbitraryItemHeight
            Me.radCheckBoxFullRowSelect.Checked = Me.radListView1.FullRowSelect
            Me.radCheckBoxKeyboardNavigation.Checked = Me.radListView1.KeyboardSearchEnabled

            Dim scaleFactor As SizeF = Me.radListView1.RootElement.DpiScaleFactor
            Me.radSpinEditorItemSpacing.Value = TelerikDpiHelper.DescaleInt(Me.radListView1.ItemSpacing, scaleFactor)
            Me.radSpinEditorGroupIndent.Value = TelerikDpiHelper.DescaleInt(Me.radListView1.GroupIndent, scaleFactor)

            Me.radSpinEditorItemWidth.Value = TelerikDpiHelper.DescaleInt(Me.radListView1.ItemSize.Width, scaleFactor)
            Me.radSpinEditorItemHeight.Value = TelerikDpiHelper.DescaleInt(Me.radListView1.ItemSize.Height, scaleFactor)

            Me.radSpinEditorGroupHeight.Value = TelerikDpiHelper.DescaleInt(Me.radListView1.GroupItemSize.Height, scaleFactor)
        End Sub

        Public Overrides ReadOnly Property ContentControl() As Control
            Get
                Return Me.radPanel2
            End Get
        End Property

        Private Sub radDropDownListCheckOnClickMode_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Select Case Me.radDropDownListCheckOnClickMode.Text
                Case "Off"
                    Me.radListView1.CheckOnClickMode = CheckOnClickMode.Off
                    Exit Select
                Case "First Click"
                    Me.radListView1.CheckOnClickMode = CheckOnClickMode.FirstClick
                    Exit Select
                Case "Second Click"
                    Me.radListView1.CheckOnClickMode = CheckOnClickMode.SecondClick
                    Exit Select
            End Select
        End Sub

        Private Sub radCheckBoxMultiSelect_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radListView1.MultiSelect = Me.radCheckBoxMultiSelect.Checked
        End Sub

        Private Sub radCheckBoxAllowEdit_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radListView1.AllowEdit = Me.radCheckBoxAllowEdit.Checked
            If Me.radCheckBoxAllowEdit.Checked Then
                Me.radCheckBoxShowCheckboxes.Checked = False
            End If
        End Sub

        Private Sub radCheckBoxHotTracking_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radListView1.HotTracking = Me.radCheckBoxHotTracking.Checked
        End Sub

        Private Sub radCheckBoxLassoSelection_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radListView1.EnableLassoSelection = Me.radCheckBoxLassoSelection.Checked
            If Me.radCheckBoxLassoSelection.Checked Then
                Me.radCheckBoxMultiSelect.Checked = True
            End If
        End Sub
    End Class
End Namespace