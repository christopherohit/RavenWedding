Imports Telerik.Examples.WinControls.Editors

Namespace Telerik.Examples.WinControls.Buttons.RepeatButton
	''' <summary>
	''' Main class for the repeat button example
	''' </summary>
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Public Sub New()
			InitializeComponent()

            Me.CenterPanel = True
            Me.radProgressBar1.Text = ""
		End Sub
		Public Overrides Sub OnThemeChanged()
			MyBase.OnThemeChanged()
			If Me.CurrentThemeName = "VisualStudio2012Dark" Then
				Me.radPanelDemoHolder.PanelElement.PanelFill.BackColor = Color.Black
				Me.radPanelDemoHolder.PanelElement.PanelFill.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Else
				Me.radPanelDemoHolder.PanelElement.PanelFill.BackColor = Color.Transparent
				Me.radPanelDemoHolder.PanelElement.PanelFill.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			End If
		End Sub
		Private Sub radRepeatButton3_ButtonClick(ByVal sender As Object, ByVal e As EventArgs)
			If Me.radProgressBar1.Value1 < Me.radProgressBar1.Maximum Then
				Me.radProgressBar1.Value1 += 1
			Else
				Me.radProgressBar1.Value1 = Me.radProgressBar1.Minimum
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radRepeatButton3.ButtonClick, AddressOf radRepeatButton3_ButtonClick
		End Sub
	End Class
End Namespace