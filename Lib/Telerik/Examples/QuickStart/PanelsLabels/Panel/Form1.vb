Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Primitives
Imports Telerik.Examples.WinControls.Editors

Namespace Telerik.Examples.WinControls.PanelsLabels.Panel
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private border As BorderPrimitive = Nothing
		Private fill As FillPrimitive = Nothing

		Public Sub New()
			InitializeComponent()

			border = CType(Me.radPanel1.PanelElement.Children(1), BorderPrimitive)
			fill = CType(Me.radPanel1.PanelElement.Children(0), FillPrimitive)
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radRadioButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioButton5.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

			border.Width = 1
			border.ForeColor = Color.FromArgb(7, 81, 172)
			border.GradientStyle = Telerik.WinControls.GradientStyles.Solid

			fill.BackColor = Color.FromArgb(47, 152, 247)
			fill.GradientStyle = Telerik.WinControls.GradientStyles.Solid
		End Sub

		Private Sub radRadioButton1_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			fill.BackColor = Color.Transparent
			fill.BackColor2 = Color.Transparent
			fill.BackColor3 = Color.Transparent
			fill.BackColor4 = Color.Transparent
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radRadioButton3.ToggleStateChanged, AddressOf radRadioButton3_ToggleStateChanged
			AddHandler radRadioButton2.ToggleStateChanged, AddressOf radRadioButton2_ToggleStateChanged
			AddHandler radRadioButton1.ToggleStateChanged, AddressOf radRadioButton1_ToggleStateChanged
			AddHandler radRadioButton4.ToggleStateChanged, AddressOf radRadioButton4_ToggleStateChanged
			AddHandler radRadioButton5.ToggleStateChanged, AddressOf radRadioButton5_ToggleStateChanged
			AddHandler radSpinEditor1.ValueChanged, AddressOf radSpinEditor1_ValueChanged
			AddHandler radRadioButton6.ToggleStateChanged, AddressOf radRadioButton6_ToggleStateChanged
		End Sub

		Private Sub radRadioButton2_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			fill.BackColor = Color.FromArgb(47, 152, 247)
			fill.GradientStyle = Telerik.WinControls.GradientStyles.Solid
		End Sub

		Private Sub radRadioButton3_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			fill.BackColor2 = Color.FromArgb(47, 152, 247)
			fill.BackColor = Color.FromArgb(213, 234, 253)
			fill.GradientStyle = Telerik.WinControls.GradientStyles.Linear
		End Sub

		Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			border.Width = CSng(Me.radSpinEditor1.Value)
		End Sub

		Private Sub radRadioButton4_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			border.ForeColor = Color.Transparent
			border.ForeColor2 = Color.Transparent
			border.ForeColor3 = Color.Transparent
			border.ForeColor4 = Color.Transparent
		End Sub

		Private Sub radRadioButton5_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			border.ForeColor = Color.FromArgb(7, 81, 172)
			border.GradientStyle = Telerik.WinControls.GradientStyles.Solid
		End Sub

		Private Sub radRadioButton6_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			border.ForeColor = Color.FromArgb(7, 81, 172)
			border.ForeColor2 = Color.FromArgb(7, 81, 172)
			border.ForeColor3 = Color.FromArgb(212, 0, 176)
			border.ForeColor4 = Color.FromArgb(212, 0, 176)
			border.GradientStyle = Telerik.WinControls.GradientStyles.Linear
		End Sub
	End Class
End Namespace
