Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

Namespace Telerik.Examples.WinControls.SplitContainer.Layouts
	Partial Public Class Form1
		Inherits ExamplesRadForm
		Implements ISupportThemeName
		#Region "Fields"

		Private random As Random

		#End Region

		#Region "Constructor"

		Public Sub New()
			InitializeComponent()

			Me.random = New Random()

			Me.Size = New Size(800, 600)
			Me.StartPosition = FormStartPosition.CenterParent
		End Sub

		#End Region

		#Region "Implementation"

		Private Sub BeginLayout()
			ControlHelper.BeginUpdate(Me.rootContainer)
			Me.rootContainer.SuspendLayout()
			Me.DisposeChildPanels()
		End Sub

		Private Sub EndLayout()
			Me.rootContainer.ResumeLayout(True)
			ControlHelper.EndUpdate(Me.rootContainer, True)
		End Sub

		Private Sub DisposeChildPanels()
			Dim count As Integer = Me.rootContainer.SplitPanels.Count
			For i As Integer = count - 1 To 0 Step -1
				rootContainer.SplitPanels(0).Dispose()
			Next i
		End Sub

		Private Function CreateSplitPanel() As SplitPanel
			Dim panel As New SplitPanel()
			Dim back As Color = Color.FromArgb(Me.random.Next(155, 255), Me.random.Next(155, 255), Me.random.Next(155, 255))
			Dim fill As FillPrimitive = TryCast(panel.SplitPanelElement.Children(0), FillPrimitive)
			fill.BackColor = back
			fill.GradientStyle = GradientStyles.Solid

			Return panel
		End Function

		Private Sub CreateLine(ByVal count As Integer, ByVal orientation As Orientation)
			Me.BeginLayout()

			Me.rootContainer.Orientation = orientation

			For i As Integer = 0 To count - 1
				Me.rootContainer.SplitPanels.Add(Me.CreateSplitPanel())
			Next i

			Me.rootContainer.ResumeLayout(True)

			Me.EndLayout()
		End Sub

		Private Sub CreateGrid(ByVal cols As Integer, ByVal rows As Integer, ByVal centerFill As Boolean)
			Me.CreateGrid(cols, rows, Orientation.Horizontal, centerFill)
		End Sub

		Private Sub CreateGrid(ByVal cols As Integer, ByVal rows As Integer, ByVal orientation As Orientation, ByVal centerFill As Boolean)
			Me.BeginLayout()

			Me.rootContainer.Orientation = orientation

			For i As Integer = 0 To rows - 1
				Dim container As New RadSplitContainer()
				container.Orientation = Orientation.Vertical
				container.SizeInfo.AbsoluteSize = New Size(100, 100)

				For j As Integer = 0 To cols - 1
					Dim panel As SplitPanel = Me.CreateSplitPanel()
					panel.SizeInfo.AbsoluteSize = New Size(100, 100)
					container.SplitPanels.Add(panel)
				Next j

				Me.rootContainer.SplitPanels.Add(container)
			Next i

			If centerFill Then
				TryCast(Me.rootContainer.SplitPanels(rows \ 2), RadSplitContainer).SplitPanels(cols \ 2).SizeInfo.SizeMode = SplitPanelSizeMode.Fill
			End If

			Me.EndLayout()
		End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            Me.CreateGrid(5, 5, True)
        End Sub

#End Region

#Region "Event Handlers"

        Private Sub colX9Button_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.CreateLine(9, Orientation.Horizontal)
		End Sub

		Private Sub rowX9_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.CreateLine(9, Orientation.Vertical)
		End Sub

		Private Sub gridX9Button_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.CreateGrid(3, 3, False)
		End Sub

		Private Sub gridX25Button_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.CreateGrid(5, 5, False)
		End Sub

		Private Sub grixX25FillButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.CreateGrid(5, 5, True)
		End Sub

		Private Sub absHorizontalButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.BeginLayout()
			Me.CreateLine(3, Orientation.Horizontal)

			Dim sizeInfo As SplitPanelSizeInfo = Me.rootContainer.SplitPanels(0).SizeInfo
			sizeInfo.SizeMode = SplitPanelSizeMode.Absolute
			sizeInfo.AbsoluteSize = New Size(200, 100)

			sizeInfo = Me.rootContainer.SplitPanels(Me.rootContainer.SplitPanels.Count - 1).SizeInfo
			sizeInfo.SizeMode = SplitPanelSizeMode.Absolute
			sizeInfo.AbsoluteSize = New Size(200, 100)

			Me.EndLayout()
		End Sub

		Private Sub absVerticalButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.BeginLayout()
			Me.CreateLine(3, Orientation.Vertical)

			Dim sizeInfo As SplitPanelSizeInfo = Me.rootContainer.SplitPanels(0).SizeInfo
			sizeInfo.SizeMode = SplitPanelSizeMode.Absolute
			sizeInfo.AbsoluteSize = New Size(100, 200)

			sizeInfo = Me.rootContainer.SplitPanels(Me.rootContainer.SplitPanels.Count - 1).SizeInfo
			sizeInfo.SizeMode = SplitPanelSizeMode.Absolute
			sizeInfo.AbsoluteSize = New Size(100, 200)

			Me.EndLayout()
		End Sub

		Private Sub minMaxButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.CreateLine(3, Orientation.Vertical)

			Dim sizeInfo As SplitPanelSizeInfo = Me.rootContainer.SplitPanels(1).SizeInfo
			sizeInfo.MinimumSize = New Size(200, 0)
			sizeInfo.MaximumSize = New Size(300, 0)

			Dim label As New Label()
			label.AutoSize = False
			label.Dock = DockStyle.Top
			label.Height = 100
			label.BackColor = Color.Transparent
			label.Text = "SizeInfo.MinimumSize = [200, 0]" & vbCrLf & "SizeInfo.MaximumSize = [300, 0]"
			Me.rootContainer.SplitPanels(1).Padding = New Padding(1)
			Me.rootContainer.SplitPanels(1).Controls.Add(label)

		End Sub

		Private Sub AddThreePanels()
			Dim rootContainer As New RadSplitContainer()
			For i As Integer = 0 To 2
				rootContainer.SplitPanels.Add(New SplitPanel())
			Next i
		End Sub

		#End Region

		Protected Overrides Sub WireEvents()
			AddHandler absVerticalButton.Click, AddressOf absVerticalButton_Click
			AddHandler absHorizontalButton.Click, AddressOf absHorizontalButton_Click
			AddHandler rowX9.Click, AddressOf rowX9_Click
			AddHandler colX9Button.Click, AddressOf colX9Button_Click
			AddHandler grixX25FillButton.Click, AddressOf grixX25FillButton_Click
			AddHandler gridX9Button.Click, AddressOf gridX9Button_Click
			AddHandler gridX25Button.Click, AddressOf gridX25Button_Click
			AddHandler minMaxButton.Click, AddressOf minMaxButton_Click
		End Sub

        Public Sub ApplyTheme(ByVal themeName As String) Implements ISupportThemeName.ApplyTheme
            ThemeResolutionService.ApplyThemeToControlTree(Me, themeName)
        End Sub
    End Class
End Namespace
