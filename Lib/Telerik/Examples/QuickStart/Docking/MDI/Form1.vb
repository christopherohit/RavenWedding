Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI.Docking

Namespace Telerik.Examples.WinControls.Docking.MDI
	Partial Public Class Form1
		Inherits ExamplesRadForm
		Implements ISupportThemeName
		Private Shared count As Integer

		Public Sub New()
			InitializeComponent()

			Me.radDock1.AutoDetectMdiChildren = True
			AddHandler radDock1.DockStateChanging, AddressOf radDock1_DockStateChanging
			AddHandler radDock1.DockStateChanged, AddressOf radDock1_DockStateChanged
			AddHandler radDock1.ActiveWindowChanging, AddressOf radDock1_ActiveWindowChanging
			AddHandler radDock1.ActiveWindowChanged, AddressOf radDock1_ActiveWindowChanged
			Me.documentContainer1.SendToBack()
			Me.radDock1.DockWindow(Me.toolWindow2, DockPosition.Bottom)
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler reportMDIRadButton.Click, AddressOf reportMDIRadButton_Click
			AddHandler orderMDIRadButton.Click, AddressOf orderMDIRadButton_Click
			AddHandler customerMDIRadButton.Click, AddressOf customerMDIRadButton_Click
			AddHandler newMDIRadButton.Click, AddressOf newRadButton_Click
			AddHandler imageMDIRadButton.Click, AddressOf imageMDIRadButton_Click
		End Sub

		Private Sub radDock1_ActiveWindowChanged(ByVal sender As Object, ByVal e As DockWindowEventArgs)
            Me.AddLog("Active window changed; new active window: " & e.DockWindow.ToString(), True)
		End Sub

		Private Sub radDock1_ActiveWindowChanging(ByVal sender As Object, ByVal e As DockWindowCancelEventArgs)
            Me.AddLog("Active window changing; current active window: " & e.NewWindow.ToString(), True)
		End Sub

		Private Sub radDock1_DockStateChanged(ByVal sender As Object, ByVal e As DockWindowEventArgs)
            Me.AddLog("Dock State for window " & e.DockWindow.ToString() & " changed to " & e.DockWindow.DockState, True)
		End Sub

		Private Sub radDock1_DockStateChanging(ByVal sender As Object, ByVal e As DockStateChangingEventArgs)
            Me.AddLog("Window " & e.NewWindow.ToString() & " DockState changing to " & e.NewDockState & "; current state: " & e.NewWindow.DockState, True)
		End Sub

		Private Sub newRadButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim form As New Form()
            count = count + 1
			form.Text = "Demo Form" & count.ToString()
			form.MdiParent = Me
			form.Show()
		End Sub

		Private Sub AddLog(ByVal text As String, ByVal newLine As Boolean)
			logRadTextBox.Text += text & (If(newLine, vbCrLf, ""))
			logRadTextBox.Select(logRadTextBox.Text.Length, -1)
			logRadTextBox.ScrollToCaret()
		End Sub

		Private Sub customerMDIRadButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim form As New CustomerForm()
            count = count + 1
			form.Text = "Customer Form" & count.ToString()
			form.MdiParent = Me
			form.Show()
			ThemeResolutionService.ApplyThemeToControlTree(form, Me.ThemeName)
		End Sub

		Private Sub orderMDIRadButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim form As New OrderForm()
            count = count + 1
			form.Text = "Order Form" & count.ToString()
			form.MdiParent = Me
			form.Show()
			ThemeResolutionService.ApplyThemeToControlTree(form, Me.ThemeName)
		End Sub

		Private Sub reportMDIRadButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim form As New ReportForm()
            count = count + 1
			form.Text = "Report Form" & count.ToString()
			form.MdiParent = Me
			form.Show()
		End Sub

		Private Sub imageMDIRadButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim form As New ImageForm()
            count = count + 1
			form.Text = "Image Form" & count.ToString()
			form.MdiParent = Me
			form.Show()
		End Sub

        Public Sub ApplyTheme(ByVal themeName As String) Implements ISupportThemeName.ApplyTheme
            Me.ThemeName = themeName
            ThemeResolutionService.ApplyThemeToControlTree(Me, themeName)
        End Sub
	End Class
End Namespace