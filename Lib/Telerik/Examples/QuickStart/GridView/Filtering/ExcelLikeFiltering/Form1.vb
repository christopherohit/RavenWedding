Imports System.ComponentModel
Imports System.Text
Imports System.Data.OleDb
Imports System.IO
Imports Telerik.Data
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.UI.Export


Namespace Telerik.Examples.WinControls.GridView.Filtering.ExcelLikeFiltering
	Partial Public Class Form1
		Inherits ExamplesForm
		Private ReadOnly endDate As Date = Date.Today
		Private ReadOnly range As Integer = 730
		Private random As New Random()

		Public Sub New()
			InitializeComponent()
			Me.radGridView1.AutoGenerateColumns = False
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radGridView1.TableElement.BeginUpdate()
			Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)
			Me.radGridView1.EnableFiltering = True
			Me.radGridView1.AllowAddNewRow = False
			Me.radGridView1.ReadOnly = True
			Me.radGridView1.MasterTemplate.ShowHeaderCellButtons = True
			Me.radGridView1.MasterTemplate.ShowFilteringRow = False
			Me.radGridView1.TableElement.EndUpdate()
			AddHandler radGridView1.FilterPopupRequired, AddressOf radGridView1_FilterPopupRequired

			For Each row As GridViewRowInfo In Me.radGridView1.Rows
				row.Cells("Date").Value = GetRandomDate()
			Next row

			Me.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radGridView1_FilterPopupRequired(ByVal sender As Object, ByVal e As FilterPopupRequiredEventArgs)
			If Me.radRadioButton4.IsChecked Then
				e.FilterPopup = New RadSimpleListFilterPopup(e.Column)
			ElseIf e.Column.Name = "Date" Then
				If Me.radRadioButton1.IsChecked Then
					Return
				ElseIf Me.radRadioButton2.IsChecked Then
					e.FilterPopup = New RadListFilterPopup(e.Column)
				ElseIf Me.radRadioButton3.IsChecked Then
					e.FilterPopup = New RadListFilterPopup(e.Column, True)
				End If
			End If
		End Sub

		Private Function GetRandomDate() As Date
			Return Me.endDate.AddDays(-Me.random.Next(range))
		End Function

		Protected Overrides Sub WireEvents()
		End Sub
	End Class
End Namespace
