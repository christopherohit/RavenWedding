Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI.Docking

Namespace Telerik.Examples.WinControls.Docking.Serialization
	Partial Public Class Form1
		Inherits ExamplesRadForm
		Implements ISupportThemeName
		Private counter As Integer

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Function CreatePanel(ByVal caption As String, ByVal dockPosition As DockPosition, ByVal size As Size, ByVal backColor As Color) As ToolWindow
			counter += 1
			Dim panel As New ToolWindow()
			panel.CloseAction = DockWindowCloseAction.Close
			panel.Text = caption & " " & counter
			panel.BackColor = backColor
			panel.Size = size
			Me.radDock1.DockWindow(panel, dockPosition)

			Return panel
		End Function

		Protected Overrides Sub WireEvents()
			AddHandler radMenuItem1.Click, AddressOf radMenuItem1_Click
			AddHandler radMenuItem2.Click, AddressOf radMenuItem2_Click
			AddHandler radMenuItem3.Click, AddressOf radMenuItem3_Click
			AddHandler radMenuItem4.Click, AddressOf radMenuItem4_Click
			AddHandler radMenuItem9.Click, AddressOf radMenuItem9_Click
			AddHandler saveRadButton.Click, AddressOf radButton2_Click
			AddHandler radDock1.DockStateChanged, AddressOf dockingManager1_DockingStateChanged
			AddHandler radDock1.DockStateChanging, AddressOf dockingManager1_DockingStateChanging
			AddHandler radDock1.SavedToXml, AddressOf dockingManager1_LayoutSaved
			AddHandler radDock1.LoadedFromXml, AddressOf dockingManager1_LayoutLoaded
			AddHandler AddRandomRadButton.Click, AddressOf AddRandomRadButton_Click
			AddHandler removeAllRadButton.Click, AddressOf removeAllRadButton_Click
			AddHandler radMenuItem10.Click, AddressOf radMenuItem10_Click
			AddHandler removeAllRadButton.Click, AddressOf removeAllRadButton_Click
			AddHandler radMenuItem5.Click, AddressOf radMenuItem5_Click
			AddHandler AddRandomRadButton.Click, AddressOf AddRandomRadButton_Click
			AddHandler radMenuItem11.Click, AddressOf radMenuItem11_Click
			AddHandler radMenuItem8.Click, AddressOf radMenuItem8_Click
			AddHandler removeAllRadButton.Click, AddressOf removeAllRadButton_Click
			AddHandler loadRadButton.Click, AddressOf radButton1_Click
		End Sub

        Protected Overloads Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            CreatePanel("Tool Window", DockPosition.Right, New Size(Me.Width \ 2, Me.Height \ 2), Color.FromArgb(255, 192, 192))
            CreatePanel("Tool Window", DockPosition.Top, New Size(Me.Width \ 2, Me.Height \ 2), Color.FromArgb(192, 255, 192))
            CreatePanel("Tool Window", DockPosition.Left, New Size(Me.Width \ 2, 100), Color.FromArgb(192, 192, 255))
        End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "XML files|*.xml|All files|*.*"
			If dialog.ShowDialog() = DialogResult.OK Then
				radDock1.LoadFromXml(dialog.FileName)
			End If
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim dialog As New SaveFileDialog()
			dialog.Filter = "XML files|*.xml|All files|*.*"
			dialog.FileName = ""
			If dialog.ShowDialog() = DialogResult.OK Then
				radDock1.SaveToXml(dialog.FileName)
			End If
		End Sub

		Private Sub removeAllRadButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			radDock1.CloseWindows(radDock1.DockWindows)
		End Sub

		Private Sub radMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim random As New Random(Date.Now.Second)
			CreatePanel("Tool Window", DockPosition.Left, New Size(100, 100), Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random.Next(100, 255)))
		End Sub

		Private Sub radMenuItem2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim random As New Random(Date.Now.Second)
			CreatePanel("Tool Window", DockPosition.Right, New Size(100, 100), Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random.Next(100, 255)))
		End Sub

		Private Sub radMenuItem3_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim random As New Random(Date.Now.Second)
			CreatePanel("Tool Window", DockPosition.Top, New Size(100, 100), Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random.Next(100, 255)))
		End Sub

		Private Sub radMenuItem4_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim random As New Random(Date.Now.Second)
			CreatePanel("Tool Window", DockPosition.Bottom, New Size(100, 100), Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random.Next(100, 255)))
		End Sub

		Private Sub radMenuItem5_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim random As New Random(Date.Now.Second)
			Dim panel As ToolWindow = CreatePanel("Tool Window", DockPosition.Bottom, New Size(100, 100), Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random.Next(100, 255)))

			'Todo: change for release to use the appropriate Float method
			radDock1.FloatWindow(panel, Rectangle.Empty)
		End Sub

		Private Sub radMenuItem8_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim panel As ToolWindow = CreatePanel("Tool Window", DockPosition.Left, New Size(100, 100), Color.FromArgb(255, 192, 192))
			radDock1.AutoHideWindow(panel)
		End Sub

		Private Sub radMenuItem9_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim panel As ToolWindow = CreatePanel("Tool Window", DockPosition.Right, New Size(100, 100), Color.FromArgb(255, 192, 192))
			radDock1.AutoHideWindow(panel)
		End Sub

		Private Sub radMenuItem10_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim panel As ToolWindow = CreatePanel("Tool Window", DockPosition.Top, New Size(100, 100), Color.FromArgb(255, 192, 192))
			radDock1.AutoHideWindow(panel)
		End Sub

		Private Sub radMenuItem11_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim panel As ToolWindow = CreatePanel("Tool Window", DockPosition.Bottom, New Size(100, 100), Color.FromArgb(255, 192, 192))
			radDock1.AutoHideWindow(panel)
		End Sub

		Private Sub AddRandomRadButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim random As New Random(Date.Now.Second)
			Dim dockPos As DockPosition = DockPosition.Left
			Dim index As Integer = random.Next(1, 5)
			If index = 1 Then
				dockPos = DockPosition.Left
			ElseIf index = 2 Then
				dockPos = DockPosition.Right
			ElseIf index = 3 Then
				dockPos = DockPosition.Top
			ElseIf index = 4 Then
				dockPos = DockPosition.Bottom
			End If
			Dim window As ToolWindow = CreatePanel("Tool Window", dockPos, New Size(100, 100), Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random.Next(100, 255)))
		End Sub

		Private Sub dockingManager1_DockingStateChanged(ByVal sender As Object, ByVal e As DockWindowEventArgs)
			Dim message As String = "DockObject current state: "
			Dim window As DockWindow = e.DockWindow
			If window IsNot Nothing Then
				message = window.Text & " current state: "
			End If
			AddLog(message & e.DockWindow.DockState, True)
			AddLog("", True)
		End Sub

		Private Sub dockingManager1_DockingStateChanging(ByVal sender As Object, ByVal e As DockStateChangingEventArgs)
			Dim message As String = "DockObject previous state: "
			Dim window As DockWindow = e.NewWindow
			If window IsNot Nothing Then
				message = window.Text & " previous state: "
			End If
			AddLog(message & e.NewWindow.DockState, True)
		End Sub

		Private Sub AddLog(ByVal text As String, ByVal newLine As Boolean)
			logTextBox.Text += text & (If(newLine, vbCrLf, ""))
			logTextBox.Select(logTextBox.Text.Length, -1)
			logTextBox.ScrollToCaret()
		End Sub

		Private Sub dockingManager1_LayoutLoaded(ByVal sender As Object, ByVal e As EventArgs)
			counter = radDock1.DockWindows.Count
			AddLog("Docking Manager: LoadedFromXml", True)
		End Sub

		Private Sub dockingManager1_LayoutSaved(ByVal sender As Object, ByVal e As EventArgs)
			AddLog("Docking Manager: SavedToXml", True)
		End Sub

        Public Sub ApplyTheme(ByVal themeName As String) Implements ISupportThemeName.ApplyTheme
            ThemeResolutionService.ApplyThemeToControlTree(Me, themeName)
        End Sub
	End Class
End Namespace