Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.PageView.StackView.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.radioPositionBottom.Tag = StackViewPosition.Bottom
			Me.radioPositionTop.Tag = StackViewPosition.Top
			Me.radioPositionLeft.Tag = StackViewPosition.Left
			Me.radioPositionRight.Tag = StackViewPosition.Right
			Me.radioContentWithSelected.Tag = StackViewItemSelectionMode.ContentWithSelected
			Me.radioContentAfterSelected.Tag = StackViewItemSelectionMode.ContentAfterSelected
			Me.radioStandard.Tag = StackViewItemSelectionMode.Standard

			Me.radSpinEditor1.Value = 1

			Me.radioPositionBottom.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radioStandard.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.showHeaderCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub OnRadioSelectionSetting_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Dim radioButton As RadRadioButton = TryCast(sender, RadRadioButton)
			If radioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				TryCast(Me.pageView1.ViewElement, RadPageViewStackElement).ItemSelectionMode = CType(radioButton.Tag, StackViewItemSelectionMode)
			End If
		End Sub

		Private Sub OnRadioStackPositionSetting_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Dim radioButton As RadRadioButton = TryCast(sender, RadRadioButton)
			If radioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				TryCast(Me.pageView1.ViewElement, RadPageViewStackElement).StackPosition = CType(radioButton.Tag, StackViewPosition)
			End If
		End Sub

		Private Sub OnShowHeader_Checked(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.pageView1.ViewElement.Header.Visibility = If(Me.showHeaderCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On, ElementVisibility.Visible, ElementVisibility.Collapsed)
		End Sub

		Private Sub OnShowFooter_Checked(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.pageView1.ViewElement.Footer.Visibility = If(Me.showFooterCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On, ElementVisibility.Visible, ElementVisibility.Collapsed)
		End Sub

		Private Sub OnItemSpacing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.pageView1.ViewElement.ItemSpacing = CInt(Fix(Me.radSpinEditor1.Value))
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radioContentWithSelected.ToggleStateChanged, AddressOf OnRadioSelectionSetting_ToggleStateChanged
			AddHandler radioContentAfterSelected.ToggleStateChanged, AddressOf OnRadioSelectionSetting_ToggleStateChanged
			AddHandler radioStandard.ToggleStateChanged, AddressOf OnRadioSelectionSetting_ToggleStateChanged
			AddHandler radioPositionRight.ToggleStateChanged, AddressOf OnRadioStackPositionSetting_ToggleStateChanged
			AddHandler radioPositionLeft.ToggleStateChanged, AddressOf OnRadioStackPositionSetting_ToggleStateChanged
			AddHandler radioPositionBottom.ToggleStateChanged, AddressOf OnRadioStackPositionSetting_ToggleStateChanged
			AddHandler radioPositionTop.ToggleStateChanged, AddressOf OnRadioStackPositionSetting_ToggleStateChanged
			AddHandler showHeaderCheck.ToggleStateChanged, AddressOf OnShowHeader_Checked
			AddHandler showFooterCheck.ToggleStateChanged, AddressOf OnShowFooter_Checked
			AddHandler radSpinEditor1.ValueChanged, AddressOf OnItemSpacing_ValueChanged
		End Sub
	End Class
End Namespace
