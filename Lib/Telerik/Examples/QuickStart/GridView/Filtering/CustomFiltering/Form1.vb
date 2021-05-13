Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Filtering.CustomFiltering
	Partial Public Class Form1
		Inherits ExamplesForm

		Public Sub New()
			InitializeComponent()

            Me.radGridView.EnableGrouping = False
			Me.radGridView.EnableHotTracking = True
			Me.radGridView.ShowFilteringRow = False
			Me.radGridView.EnableFiltering = True
			Me.radGridView.EnableCustomFiltering = True
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)

			Me.SelectedControl = Me.filterTextBox
		End Sub

		Private Sub radGridView1_CustomFiltering(ByVal sender As Object, ByVal e As GridViewCustomFilteringEventArgs)
            If String.IsNullOrEmpty(Me.filterTextBox.Text) Then
                radGridView.BeginUpdate()
                e.Visible = True
                For i As Integer = 0 To Me.radGridView.ColumnCount - 1
                    e.Row.Cells(i).Style.Reset()

                Next i
                radGridView.EndUpdate(False)
                Return
            End If
            radGridView.BeginUpdate()
			e.Visible = False
			For i As Integer = 0 To Me.radGridView.ColumnCount - 1
				Dim text As String = e.Row.Cells(i).Value.ToString()
				If text.IndexOf(Me.filterTextBox.Text, 0, StringComparison.InvariantCultureIgnoreCase) >= 0 Then
					e.Visible = True
					e.Row.Cells(i).Style.CustomizeFill = True
					e.Row.Cells(i).Style.DrawFill = True
					e.Row.Cells(i).Style.BackColor = Color.FromArgb(201, 252, 254)
				Else
                    e.Row.Cells(i).Style.Reset()
				End If
            Next i
            radGridView.EndUpdate(False)
		End Sub

		Private Sub filterTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridView.MasterTemplate.Refresh()
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radGridView.CustomFiltering, AddressOf radGridView1_CustomFiltering
			AddHandler filterTextBox.TextChanged, AddressOf filterTextBox_TextChanged
		End Sub
	End Class
End Namespace
