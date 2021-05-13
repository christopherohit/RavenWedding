Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.MenuStrip.MenuWithHeaderColumn
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radMenuItem1.DropDown.HeaderText = "RadMenuStrip Header"
			Dim popupElement As RadDropDownMenuElement = TryCast(Me.radMenuItem1.DropDown.PopupElement, RadDropDownMenuElement)
			If popupElement IsNot Nothing Then
				popupElement.HeaderColumn.TextImageRelation = TextImageRelation.ImageBeforeText
				popupElement.HeaderColumnBorder.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
				popupElement.HeaderColumnFill.BackColor = Color.FromArgb(238, 238, 213)
				popupElement.HeaderColumnFill.BackColor2 = Color.FromArgb(153, 208, 221)
				popupElement.HeaderColumnFill.NumberOfColors = 2
				popupElement.HeaderColumnText.ForeColor = Color.White
				popupElement.HeaderColumn.TextAlignment = ContentAlignment.MiddleLeft
				popupElement.HeaderColumnText.Font = New Font("Comic Sans", 16f, FontStyle.Bold)
			End If
		End Sub

		Protected Overrides Sub WireEvents()
		End Sub
	End Class
End Namespace
