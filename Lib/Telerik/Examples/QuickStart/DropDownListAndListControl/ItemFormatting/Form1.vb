Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports System.Globalization
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.ItemFormatting
	Partial Public Class Form1
		Inherits ExamplesForm
		Private Const NumberOfItems As Integer = 37

		Private bgColors() As String = { "#f3f3f3", "#eff1ea", "#ebefe0", "#e3eccf", "#dce9c0", "#d3e9a3", "#c7e97d" }

		Private textColors() As String = { "#85b949", "#9cb97b", "#a9b997", "#8d9c90", "#757575", "#575757", "#000000" }

		Public Sub New()
			InitializeComponent()

			Me.radListControl1.ListElement.AutoSizeItems = True
			Me.radDropDownList1.ListElement.AutoSizeItems = True
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Dim list(NumberOfItems - 1) As String
			For i As Integer = 0 To NumberOfItems - 1
				Dim text As String = "<html><color=" & textColors(i Mod 7) & "><size=" & (i + 8).ToString() & ">Item " & (i + 1).ToString()
				list(i) = text
			Next i

			Me.radListControl1.DataSource = list
			Me.radDropDownList1.DataSource = list
		End Sub

		Private Sub radListControl1_VisualItemFormatting(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.VisualItemFormattingEventArgs)
			Dim item As RadListVisualItem = args.VisualItem
			Dim rowIndex As Integer = item.Data.RowIndex
			Dim typeConverter As System.ComponentModel.TypeConverter = TypeDescriptor.GetConverter(GetType(Color))
			item.DrawFill = True
			item.BackColor = CType(typeConverter.ConvertFromString(Nothing, CultureInfo.InvariantCulture, bgColors(rowIndex Mod 7)), Color)
			item.GradientStyle = Telerik.WinControls.GradientStyles.Solid
			If item.Selected Then
				item.BorderColor = Color.Black
				item.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
				item.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
				item.DrawBorder = True
			Else
				item.ResetValue(RadListVisualItem.BorderColorProperty, ValueResetFlags.Local)
				item.ResetValue(RadListVisualItem.BorderGradientStyleProperty, ValueResetFlags.Local)
				item.ResetValue(RadListVisualItem.BorderBoxStyleProperty, ValueResetFlags.Local)
				item.ResetValue(RadListVisualItem.DrawBorderProperty, ValueResetFlags.Local)
			End If

		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radListControl1.VisualItemFormatting, AddressOf radListControl1_VisualItemFormatting
			AddHandler radDropDownList1.VisualListItemFormatting, AddressOf radListControl1_VisualItemFormatting
		End Sub
	End Class
End Namespace
