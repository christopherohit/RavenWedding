Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.CardView.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			AddHandler Me.radCardView1.CardViewItemFormatting, AddressOf radCardView1_CardViewItemFormatting
			Me.radCardView1.CardViewElement.DrawBorder = False
		End Sub

		Private Sub radCardView1_CardViewItemFormatting(ByVal sender As Object, ByVal e As CardViewItemFormattingEventArgs)
			Dim cardViewItem As CardViewItem = TryCast(e.Item, CardViewItem)
			If cardViewItem IsNot Nothing Then
				If cardViewItem.FieldName = "Notes" Then
					cardViewItem.EditorItem.TextWrap = True
					cardViewItem.EditorItem.AutoEllipsis = True
				Else
					cardViewItem.EditorItem.ResetValue(LightVisualElement.TextWrapProperty, Telerik.WinControls.ValueResetFlags.Local)
				End If

				If cardViewItem.FieldName = "TitleOfCourtesy" OrElse cardViewItem.FieldName = "FirstName" OrElse cardViewItem.FieldName = "LastName" Then
					cardViewItem.Font = New Font(cardViewItem.Font.FontFamily, 10.5f, FontStyle.Regular)
				Else
					Dim itemFont As New Font(cardViewItem.Font.FontFamily, cardViewItem.Font.Size, FontStyle.Bold)
					Dim editorFont As New Font(cardViewItem.Font.FontFamily, cardViewItem.Font.Size, FontStyle.Regular)

					cardViewItem.Font = itemFont
					cardViewItem.EditorItem.Font = editorFont
				End If
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.employeesTableAdapter.Fill(Me.northwindDataSet.Employees)
		End Sub
	End Class
End Namespace
