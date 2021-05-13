Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls.Themes.Design
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives

Namespace Telerik.Examples.WinControls.MenuStrip.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.radMenu1.MenuElement.MenuBorder.Visibility = ElementVisibility.Hidden
			Me.SelectedControl = radMenu1
			Me.radMenu1.MenuElement.MenuFill.Visibility = ElementVisibility.Collapsed

		End Sub



		Private Sub radMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			MessageBox.Show("The Menu item '" & (TryCast(sender, RadMenuItemBase)).Text & "' is clicked.")
		End Sub

		Private selectedButton As RadButtonElement = Nothing


		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.selectedButton IsNot Nothing Then
				selectedButton.BorderElement.ResetValue(RadItem.ForeColorProperty, ValueResetFlags.Local)
				selectedButton.BorderElement.ResetValue(RadItem.VisibilityProperty, ValueResetFlags.Local)
			End If

			Me.selectedButton = (TryCast(sender, RadButton)).ButtonElement

			selectedButton.BorderElement.Visibility = ElementVisibility.Visible
			selectedButton.BorderElement.ForeColor = Color.Red

			Me.menuBurn.Enabled = True
			Me.menuEmail.Enabled = True
			Me.menuOpenWidth.Enabled = True
			Me.menuPrint.Enabled = True
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radMenuItem17.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem18.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem22.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem1_1.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem2_1.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem2_2.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem2_3.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem2_4.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem2_5.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem4_1.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem4_2.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem5_1.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem1_3.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem1_4.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem1_5.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem1_6.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem1_7.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem1_8.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem2_6.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem2_7.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem3_1.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem3_2.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem3_3.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem4_3.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem5_2.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem6_1.Click, AddressOf radMenuItem_Click
			AddHandler radMenuItem6_2.Click, AddressOf radMenuItem_Click
			AddHandler radButton1.Click, AddressOf radButton1_Click
			AddHandler radButton2.Click, AddressOf radButton1_Click
			AddHandler radButton3.Click, AddressOf radButton1_Click
			AddHandler radButton4.Click, AddressOf radButton1_Click
			AddHandler radMenu1.ThemeNameChanged, AddressOf radMenu1_ThemeNameChanged
		End Sub

		Private Sub radMenu1_ThemeNameChanged(ByVal source As Object, ByVal args As ThemeNameChangedEventArgs)
			If Me.radMenu1.ThemeName = "Office2007Black" Then
				For Each item As RadMenuItem In Me.radMenu1.Items
					item.Layout.Text.ForeColor = Color.Black
				Next item
			Else
				For Each item As RadMenuItem In Me.radMenu1.Items
					item.Layout.Text.ResetValue(VisualElement.ForeColorProperty, ValueResetFlags.Local)
				Next item
			End If
		End Sub
	End Class
End Namespace