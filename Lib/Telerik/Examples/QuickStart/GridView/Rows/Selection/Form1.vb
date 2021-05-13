Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Rows.Selection
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radGridView1
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.BindGrid()

			Me.radGridView1.MultiSelect = True
			Me.radGridView1.EnableHotTracking = True
			Me.radGridView1.SelectionMode = GridViewSelectionMode.FullRowSelect
			Me.radComboSelectionMode.SelectedIndex = 0

			Me.LoadInitialSelection()
		End Sub

		Private Sub LoadInitialSelection()
			For rowsCount As Integer = 0 To 9
				Me.radGridView1.Rows(rowsCount).IsSelected = True
			Next rowsCount
		End Sub

		Private Sub BindGrid()
			aggregatesSampleTableTableAdapter.Fill(nwindRadGridView.EmployeeOrders)
			Me.radGridView1.DataSource = Me.aggregatesSampleTableBindingSource

			Me.radGridView1.Columns("UnitPrice").FormatString = "${0:F2}"
		End Sub

		Private Sub radComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			If Me.radComboSelectionMode.SelectedIndex = 0 Then
				Me.radGridView1.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.FullRowSelect
			Else
				Me.radGridView1.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.CellSelect
			End If
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radGridView1.MultiSelect = Me.radCheckMulti.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

        Private Sub radCheckBox3_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radGridView1.HideSelection = Me.radCheckHideSel.Checked
        End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridView1.SelectAll()
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridView1.ClearSelection()
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radComboSelectionMode.SelectedIndexChanged, AddressOf radComboBox1_SelectedIndexChanged
			AddHandler radCheckHideSel.ToggleStateChanged, AddressOf radCheckBox3_ToggleStateChanged
			AddHandler radButton1.Click, AddressOf radButton1_Click
			AddHandler radButton2.Click, AddressOf radButton2_Click
			AddHandler radCheckMulti.ToggleStateChanged, AddressOf radCheckBox1_ToggleStateChanged
		End Sub
	End Class
End Namespace