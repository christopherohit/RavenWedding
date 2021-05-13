Imports Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters
Imports Telerik.Examples.WinControls.DataSources
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports Telerik.Examples.WinControls.Editors

Namespace Telerik.Examples.WinControls.MultiColumnComboBox.Settings
    Partial Public Class Form1
        Inherits EditorExampleBaseForm
        Private extender As New RadMultiColumnComboBoxSelectionExtender()

        Public Sub New()
            InitializeComponent()

            Me.SelectedControl = Me.radMultiColumnComboBox1
            Me.radMultiColumnComboBox1.AutoSizeDropDownToBestFit = True

            Dim multiColumnComboElement As RadMultiColumnComboBoxElement = Me.radMultiColumnComboBox1.MultiColumnComboBoxElement
            multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom
            multiColumnComboElement.DropDownMinSize = New Size(420, 300)

            multiColumnComboElement.EditorControl.MasterTemplate.AutoGenerateColumns = False

            Dim column As New GridViewTextBoxColumn("CustomerID")
            column.HeaderText = "Customer ID"
            multiColumnComboElement.Columns.Add(column)
            column = New GridViewTextBoxColumn("ContactName")
            column.HeaderText = "Contact Name"
            multiColumnComboElement.Columns.Add(column)
            column = New GridViewTextBoxColumn("ContactTitle")
            column.HeaderText = "Contact Title"
            multiColumnComboElement.Columns.Add(column)
            column = New GridViewTextBoxColumn("Country")
            column.HeaderText = "Country"
            multiColumnComboElement.Columns.Add(column)
            column = New GridViewTextBoxColumn("Phone")
            column.HeaderText = "Phone"
            multiColumnComboElement.Columns.Add(column)

            Me.radMultiColumnComboBox1.MultiColumnComboBoxElement.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        End Sub

        Private Sub OnTextBoxItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radMultiColumnComboBox1.MultiColumnComboBoxElement.ShowPopup()
        End Sub

        Protected Overrides Sub WireEvents()
            AddHandler radCheckRotate.ToggleStateChanged, AddressOf OnCheckRotate_ToggleStateChanged
            AddHandler radCheckRTL.ToggleStateChanged, AddressOf OnCheckBoxRTL_ToggleStateChanged
            AddHandler Me.radMultipleSelectionCheckBox.ToggleStateChanged, AddressOf radMultipleSelectionCheckBox_ToggleStateChanged
            AddHandler radComboAutoCompl.SelectedIndexChanged, AddressOf radComboAutoCompl_SelectedIndexChanged
            Me.radComboAutoCompl.SelectedIndex = 3
        End Sub

        Private Sub radMultipleSelectionCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)

            If Me.radMultipleSelectionCheckBox.IsChecked Then
                Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.Refresh()
                Me.extender.AssociatedRadMultiColumnComboBox = Me.radMultiColumnComboBox1
                Me.extender.AutoCompleteBoxElement.Text = "ALFKI;ANATR;"
                Me.radMultiColumnComboBox1.MultiColumnComboBoxElement.ShowPopup()
                Me.radCheckRotate.Enabled = False
                Me.radCheckRTL.Enabled = False
                Me.radComboAutoCompl.Enabled = False
            Else
                Me.extender.AssociatedRadMultiColumnComboBox = Nothing
                Me.radMultiColumnComboBox1.Text = String.Empty
                Me.radMultiColumnComboBox1.EditorControl.MasterTemplate.Refresh()
                Me.radCheckRotate.Enabled = True
                Me.radCheckRTL.Enabled = True
                Me.radComboAutoCompl.Enabled = True
            End If
        End Sub

        Private Sub radComboAutoCompl_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Select Case Me.radComboAutoCompl.SelectedIndex
                Case 0
                    Me.radMultiColumnComboBox1.AutoCompleteMode = AutoCompleteMode.None
                Case 1
                    Me.radMultiColumnComboBox1.AutoCompleteMode = AutoCompleteMode.Suggest
                Case 2
                    Me.radMultiColumnComboBox1.AutoCompleteMode = AutoCompleteMode.Append
                Case 3
                    Me.radMultiColumnComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            End Select
        End Sub


        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            Dim nwindDataSet As New NorthwindDataSet()
            Dim customersTableAdapter As New CustomersTableAdapter()
            customersTableAdapter.Fill(nwindDataSet.Customers)

            Me.radMultiColumnComboBox1.DataSource = nwindDataSet.Customers


            Dim descriptor As New FilterDescriptor(Me.radMultiColumnComboBox1.DisplayMember, FilterOperator.StartsWith, String.Empty)
            Me.radMultiColumnComboBox1.EditorControl.FilterDescriptors.Add(descriptor)
            Me.radMultiColumnComboBox1.DropDownStyle = RadDropDownStyle.DropDown
            ' Filtering END
        End Sub

        Private Sub OnCheckBoxRTL_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radMultiColumnComboBox1.RightToLeft = If(Me.radCheckRTL.Checked, RightToLeft.Yes, RightToLeft.No)
        End Sub

        Private Sub OnCheckRotate_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radMultiColumnComboBox1.DblClickRotate = Me.radCheckRotate.Checked
        End Sub
    End Class

End Namespace
