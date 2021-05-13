Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI.Docking
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Docking.AutoHide
	Partial Public Class Form1
		Inherits ExamplesForm
		Private nextWindowToChange As Integer = 0
		Private newWindowState As DockState = Telerik.WinControls.UI.Docking.DockState.AutoHide
		Private demoMode As Integer = 0

		Public Sub New()
			InitializeComponent()

			Me.WireEvents()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			'ThemeResolutionService.ApplyThemeToControlTree(this.settingsPanel, MainForm.DefaultTheme);
			Me.timer1.Start()
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Dim toolWindows() As DockWindow = Me.radDock1.DockWindows.ToolWindows
			If nextWindowToChange >= toolWindows.Length Then
				Me.timer1.Stop()
				nextWindowToChange = 0
				EnableButtons(True)
				Return
			End If

			If demoMode = 0 Then
				toolWindows(nextWindowToChange).DockState = newWindowState
			ElseIf demoMode = 1 Then
				'if (nextWindowToChange > 0)
				'{
				'    this.radDock1.HideWindow(toolWindows[nextWindowToChange - 1]);
				'}

				Me.radDock1.DisplayWindow(toolWindows(nextWindowToChange))
			End If

			If demoMode = 2 Then
				Me.radDock1.CloseWindow(toolWindows(nextWindowToChange))
			End If

			nextWindowToChange += 1
		End Sub

		Private Sub StartDemo(ByVal demoMode As Integer, ByVal dockState As DockState)
			If timer1.Enabled Then
				Return
			End If

			EnableButtons(False)

			Me.demoMode = demoMode
			Me.newWindowState = dockState
			Me.timer1.Start()
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			StartDemo(0, DockState.Hidden)
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
			StartDemo(1, DockState.Docked)
		End Sub

		Private Sub radButton3_Click(ByVal sender As Object, ByVal e As EventArgs)
			StartDemo(0, DockState.Docked)
		End Sub

		Private Sub radButton4_Click(ByVal sender As Object, ByVal e As EventArgs)
			StartDemo(0, DockState.AutoHide)
		End Sub

		Private Sub EnableButtons(ByVal enabledState As Boolean)
			Me.radButton1.Enabled = enabledState
			Me.radButton2.Enabled = enabledState
			Me.radButton3.Enabled = enabledState
			Me.radButton4.Enabled = enabledState
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler timer1.Tick, AddressOf timer1_Tick
			AddHandler radButton1.Click, AddressOf radButton1_Click
			AddHandler radButton2.Click, AddressOf radButton2_Click
			AddHandler radButton3.Click, AddressOf radButton3_Click
			AddHandler radButton4.Click, AddressOf radButton4_Click
		End Sub
	End Class
End Namespace