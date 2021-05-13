Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.Themes
Imports Telerik.WinControls.UI

Namespace DemoAppsHub
    Partial Public Class Form1
        Inherits RadForm

        Public Const WM_SIZE As Integer = 5
        Private examplePage As LightVisualElement
        Private backButton As RadButtonElement
        Private headerLabel As LightVisualElement
        Private titleBar As RadTitleBarElement
        Private isFormMoving As Boolean = False
        Private currentExample As String = String.Empty
        Private exampleControls As Dictionary(Of String, UserControl)

        Public Sub New()
            InitializeComponent()
            Dim theme As TelerikMetroBlueTheme = New TelerikMetroBlueTheme()
            ThemeResolutionService.LoadPackageResource("PanoramaDemo.tssp")
            Me.ThemeName = "PanoramaDemo"
            Me.radPanorama1.ThemeName = "PanoramaDemo"
            Me.radPanorama1.ScrollingBackground = True
            Me.radPanorama1.PanelImage = Resources.bg_pattern
            Me.radPanorama1.PanoramaElement.BackgroundImagePrimitive.ImageLayout = ImageLayout.Tile
            AddHandler Me.radPanorama1.SizeChanged, New EventHandler(AddressOf radTilePanel1_SizeChanged)
            Me.radPanorama1.ScrollBarAlignment = HorizontalScrollAlignment.Bottom
            Me.radPanorama1.ScrollBarThickness = 5
            Me.radPanorama1.PanoramaElement.GradientStyle = GradientStyles.Solid
            Me.radPanorama1.PanoramaElement.DrawFill = True
            Me.radPanorama1.PanoramaElement.BackColor = System.Drawing.Color.FromArgb(1, 23, 117)
            Me.FormElement.TitleBar.MaxSize = New Size(0, 1)
            Me.Text = "Demo Apps Hub"
            Me.LoadPhotoAlbumTileContent()
            Me.PrepareHeader()
            Me.PrepareTitleBar()
            Me.PrepareExamples()
            Me.SetupLinks()
        End Sub

        Private Sub SetupLinks()
            Me.linkTile1.Tag = "http://www.telerik.com/demos/"
            AddHandler Me.linkTile1.Click, New EventHandler(AddressOf linkTile_Click)
        End Sub

        Private Sub PrepareExamples()
            examplePage = New LightVisualElement()
            examplePage.DrawText = False
            examplePage.DrawFill = True
            examplePage.BackColor = Color.White
            examplePage.GradientStyle = GradientStyles.Solid
            examplePage.Visibility = ElementVisibility.Collapsed
            Me.radPanorama1.PanoramaElement.Children.Add(examplePage)
            examplePage.Margin = New Padding(0, 140, 0, 0)
            Me.exampleControls = New Dictionary(Of String, UserControl)()
            Me.exampleControls.Add("GridView", New DemoAppsHub.GridExample.GridExampleUserControl())
            Me.exampleControls.Add("TreeView", New DemoAppsHub.TreeExample.TreeExampleUserControl())
            Me.exampleControls.Add("ListView", New DemoAppsHub.ListViewExample.ListViewExampleUserControl())
            Me.exampleControls.Add("Scheduler", New DemoAppsHub.SchedulerExample.SchedulerExampleUserControl())
            Me.exampleControls.Add("Magnifier", New DemoAppsHub.MagnifierExample.MagnifierExampleUserControl())
            Me.exampleControls.Add("ChartViewRotate", New DemoAppsHub.ChartViewExample.ChartViewRotateExampleUserControl())
            Me.exampleControls.Add("ChartViewZoomScroll", New DemoAppsHub.ChartViewExample.ChartViewZoomScrollExampleUserControl())
            Me.PreloadControls()
        End Sub

        Private Sub PreloadControls()
            For Each entry As KeyValuePair(Of String, UserControl) In Me.exampleControls
                Me.Controls.Add(entry.Value)
                entry.Value.Location = New Point(120, 180)
            Next
        End Sub

        Private Sub PrepareTitleBar()
            titleBar = New RadTitleBarElement()
            titleBar.FillPrimitive.Visibility = ElementVisibility.Hidden
            titleBar.MaxSize = New Size(0, 50)
            titleBar.Children(1).Visibility = ElementVisibility.Hidden
            titleBar.CloseButton.Parent.PositionOffset = New SizeF(0, -10)
            titleBar.CloseButton.MinSize = New Size(50, 50)
            titleBar.CloseButton.ButtonFillElement.Visibility = ElementVisibility.Collapsed
            titleBar.MinimizeButton.MinSize = New Size(50, 50)
            titleBar.MinimizeButton.ButtonFillElement.Visibility = ElementVisibility.Collapsed
            titleBar.MaximizeButton.MinSize = New Size(50, 50)
            titleBar.MaximizeButton.ButtonFillElement.Visibility = ElementVisibility.Collapsed
            titleBar.CloseButton.SetValue(RadFormElement.IsFormActiveProperty, True)
            titleBar.MinimizeButton.SetValue(RadFormElement.IsFormActiveProperty, True)
            titleBar.MaximizeButton.SetValue(RadFormElement.IsFormActiveProperty, True)
            AddHandler titleBar.Close, AddressOf titleBar_Close
            AddHandler titleBar.Minimize, AddressOf titleBar_Minimize
            AddHandler titleBar.MaximizeRestore, AddressOf titleBar_MaximizeRestore
            AddHandler Me.radPanorama1.PanoramaElement.PanGesture, AddressOf radTilePanel1_PanGesture
            Me.radPanorama1.PanoramaElement.Children.Add(titleBar)
        End Sub

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            Me.radTilePanel1_SizeChanged(Me, EventArgs.Empty)

            For Each entry As KeyValuePair(Of String, UserControl) In Me.exampleControls
                entry.Value.PerformLayout()
                Me.Controls.Remove(entry.Value)
            Next

            MyBase.OnShown(e)
        End Sub

        Private Sub PrepareHeader()
            Dim headerLayout As StackLayoutElement = New StackLayoutElement()
            headerLayout.Orientation = Orientation.Horizontal
            headerLayout.Margin = New System.Windows.Forms.Padding(0, 35, 0, 0)
            headerLayout.NotifyParentOnMouseInput = True
            headerLayout.ShouldHandleMouseInput = False
            headerLayout.StretchHorizontally = False
            Me.backButton = New RadButtonElement() With {
                .StretchHorizontally = False
            }
            Me.backButton.Margin = New Padding(40, 0, 28, 0)
            AddHandler Me.backButton.Click, AddressOf backButton_Click
            Me.backButton.Visibility = ElementVisibility.Hidden
            headerLayout.Children.Add(Me.backButton)
            Me.headerLabel = New LightVisualElement()
            Me.headerLabel.Text = "Demo Apps Hub"
            Me.headerLabel.Font = New Font("Segoe UI Light", 42, GraphicsUnit.Point)
            Me.headerLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
            Me.headerLabel.ForeColor = Color.White
            Me.headerLabel.TextAlignment = ContentAlignment.MiddleLeft
            Me.headerLabel.MaxSize = New Size(630, 110)
            Me.headerLabel.NotifyParentOnMouseInput = True
            Me.headerLabel.ShouldHandleMouseInput = False
            Me.headerLabel.StretchHorizontally = False
            headerLayout.Children.Add(Me.headerLabel)
            Me.radPanorama1.PanoramaElement.Children.Add(headerLayout)
        End Sub

        Private Sub linkTile_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim senderTile As RadTileElement = TryCast(sender, RadTileElement)

            If senderTile IsNot Nothing Then
                Dim link As String = CStr(senderTile.Tag)
                System.Diagnostics.Process.Start(New ProcessStartInfo(link))
            End If
        End Sub

        Private Sub radTilePanel1_PanGesture(ByVal sender As Object, ByVal e As PanGestureEventArgs)
            If e.IsBegin AndAlso Me.titleBar.ControlBoundingRectangle.Contains(e.Location) Then
                isFormMoving = True
            End If

            If isFormMoving Then
                Me.Location = New Point(Me.Location.X + e.Offset.Width, Me.Location.Y + e.Offset.Height)
            Else
                e.Handled = False
            End If

            If e.IsEnd Then
                isFormMoving = False
            End If
        End Sub

        Private Sub qsfTile_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim path1 As String = Application.StartupPath & "\..\..\QuickStart\Bin\TelerikExamples.exe"
            Dim path2 As String = Application.StartupPath & "\..\..\..\Examples\Bin\TelerikExamples.exe"

            If File.Exists(path1) Then
                RunProcess(path1)
            Else
                RunProcess(path2)
            End If
        End Sub

        Private Sub vsbTile_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            If File.Exists(Application.StartupPath & "\..\..\..\Bin\VisualStyleBuilder.exe") Then
                RunProcess(Application.StartupPath & "\..\..\..\Bin\VisualStyleBuilder.exe")
            ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin40\VisualStyleBuilder.exe") Then
                RunProcess(Application.StartupPath & "\..\..\..\Bin40\VisualStyleBuilder.exe")
            ElseIf File.Exists(Application.StartupPath & "\..\..\..\..\..\Bin\VisualStyleBuilder.exe") Then
                RunProcess(Application.StartupPath & "\..\..\..\..\Bin\VisualStyleBuilder.exe")
            ElseIf File.Exists(Application.StartupPath & "\..\..\..\..\Bin\Release\VisualStyleBuilder.exe") Then
                RunProcess(Application.StartupPath & "\..\..\..\..\Bin\Release\VisualStyleBuilder.exe")
            ElseIf File.Exists(Application.StartupPath & "\..\..\..\..\Bin\ReleaseTrial\VisualStyleBuilder.exe") Then
                RunProcess(Application.StartupPath & "\..\..\..\..\Bin\ReleaseTrial\VisualStyleBuilder.exe")
            ElseIf File.Exists(Application.StartupPath & "\..\..\..\..\Bin\ReleaseTrial\net40\VisualStyleBuilder.exe") Then
                RunProcess(Application.StartupPath & "\..\..\..\..\Bin\ReleaseTrial\net40\VisualStyleBuilder.exe")
            ElseIf File.Exists(Application.StartupPath & "\..\..\..\..\Bin\Debug\VisualStyleBuilder.exe") Then
                RunProcess(Application.StartupPath & "\..\..\..\..\Bin\Debug\VisualStyleBuilder.exe")
            ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin\ReleaseTrial\VisualStyleBuilder.exe") Then
                RunProcess(Application.StartupPath & "\..\..\..\Bin\ReleaseTrial\VisualStyleBuilder.exe")
            Else
                RadMessageBox.Show("Could not locate executable!", "Error!", MessageBoxButtons.OK, RadMessageIcon.[Error])
            End If
        End Sub

        Private Sub themeViewerTile_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            If File.Exists(Application.StartupPath & "\..\..\Bin\ThemeViewer.exe") Then
                RunProcess(Application.StartupPath & "\..\..\Bin\ThemeViewer.exe")
            ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin\ThemeViewer.exe") Then
                RunProcess(Application.StartupPath & "\..\..\..\Bin\ThemeViewer.exe")
            ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin40\ThemeViewer.exe") Then
                RunProcess(Application.StartupPath & "\..\..\..\Bin40\ThemeViewer.exe")
            ElseIf File.Exists(Application.StartupPath & "\..\..\..\..\Bin\Release\ThemeViewer.exe") Then
                RunProcess(Application.StartupPath & "\..\..\..\..\Bin\Release\ThemeViewer.exe")
            ElseIf File.Exists(Application.StartupPath & "\..\..\..\..\Bin\Release\net40\ThemeViewer.exe") Then
                RunProcess(Application.StartupPath & "\..\..\..\..\Bin\Release\net40\ThemeViewer.exe")
            ElseIf File.Exists(Application.StartupPath & "\..\..\..\..\Bin\ReleaseTrial\ThemeViewer.exe") Then
                RunProcess(Application.StartupPath & "\..\..\..\..\Bin\ReleaseTrial\ThemeViewer.exe")
            ElseIf File.Exists(Application.StartupPath & "\..\..\..\..\Bin\ReleaseTrial\net40\ThemeViewer.exe") Then
                RunProcess(Application.StartupPath & "\..\..\..\..\Bin\ReleaseTrial\net40\ThemeViewer.exe")
            ElseIf File.Exists(Application.StartupPath & "\..\..\..\..\Bin\Debug\ThemeViewer.exe") Then
                RunProcess(Application.StartupPath & "\..\..\..\..\Bin\Debug\ThemeViewer.exe")
            ElseIf File.Exists(Application.StartupPath & "\..\..\..\Bin\ReleaseTrial\ThemeViewer.exe") Then
                RunProcess(Application.StartupPath & "\..\..\..\Bin\ReleaseTrial\ThemeViewer.exe")
            Else
                RadMessageBox.Show("Could not locate executable!", "Error!", MessageBoxButtons.OK, RadMessageIcon.[Error])
            End If
        End Sub

        Private Sub photoAlbumTile_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            RunProcess(Application.StartupPath & "\..\..\PhotoAlbum\Bin\PhotoAlbum.exe")
        End Sub

        Private Sub fileExplorerTile_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            RunProcess(Application.StartupPath & "\..\..\FileExplorer\Bin\FileExplorer.exe")
        End Sub

        Private Sub bugTrackerTile_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            RunProcess(Application.StartupPath & "\..\..\BugTracker\Bin\BugTracker.exe")
        End Sub

        Private Sub rssReaderTile_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            RunProcess(Application.StartupPath & "\..\..\RssReader\Bin\RssReader.exe")
        End Sub

        Private Sub RunProcess(ByVal executablePath As String)
            If File.Exists(executablePath) Then
                Dim proc As ProcessStartInfo = New ProcessStartInfo(executablePath)
                proc.WorkingDirectory = Path.GetDirectoryName(executablePath)
                Process.Start(proc)
            Else
                RadMessageBox.Show("Could not locate executable!", "Error!", MessageBoxButtons.OK, RadMessageIcon.[Error])
            End If
        End Sub

        Private Sub radTilePanel1_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim width As Integer = Me.radPanorama1.Width + CInt(Math.Max((Me.radPanorama1.PanoramaElement.ScrollBar.Maximum - Me.radPanorama1.Width) / 4, 1))
            Me.radPanorama1.PanelImageSize = New Size(width, 768)
            Me.radPanorama1.PanoramaElement.UpdateViewOnScroll()
            UpdateExampleControlPosition()
        End Sub

        Private Sub backButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            UnloadExample()
        End Sub

        Private Sub LoadPhotoAlbumTileContent()
            Me.photoAlbumTile.Text = ""
            Me.photoAlbumTile.ContentChangeInterval = 7000
            Me.photoAlbumTile.TransitionType = ContentTransitionType.SlideUp
            Me.photoAlbumTile.Items.Add(New LightVisualElement() With {
                .Image = Resources.img1,
                .ImageLayout = ImageLayout.Zoom,
                .ShouldHandleMouseInput = False,
                .NotifyParentOnMouseInput = True
            })
            Me.photoAlbumTile.Items.Add(New LightVisualElement() With {
                .Image = Resources.img2,
                .ImageLayout = ImageLayout.Zoom,
                .ShouldHandleMouseInput = False,
                .NotifyParentOnMouseInput = True
            })
            Me.photoAlbumTile.Items.Add(New LightVisualElement() With {
                .Image = Resources.img3,
                .ImageLayout = ImageLayout.Zoom,
                .ShouldHandleMouseInput = False,
                .NotifyParentOnMouseInput = True
            })
            Me.photoAlbumTile.Items.Add(New LightVisualElement() With {
                .Image = Resources.img4,
                .ImageLayout = ImageLayout.Zoom,
                .ShouldHandleMouseInput = False,
                .NotifyParentOnMouseInput = True
            })
            Me.photoAlbumTile.Items.Add(New LightVisualElement() With {
                .Image = Resources.img5,
                .ImageLayout = ImageLayout.Zoom,
                .ShouldHandleMouseInput = False,
                .NotifyParentOnMouseInput = True
            })
            Me.photoAlbumTile.Children.Add(New LightVisualElement() With {
                .Text = "Photo Album",
                .TextAlignment = ContentAlignment.BottomLeft,
                .ZIndex = 1000,
                .Padding = New Padding(10),
                .Font = New Font("Segoue UI Light", 9, GraphicsUnit.Point),
                .ShouldHandleMouseInput = False,
                .NotifyParentOnMouseInput = True
            })
            Me.photoAlbumTile.CurrentItem = Me.photoAlbumTile.Items(0)
        End Sub

        Private Sub titleBar_MaximizeRestore(ByVal sender As Object, ByVal args As EventArgs)
            If Me.WindowState <> FormWindowState.Maximized Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
        End Sub

        Private Sub titleBar_Minimize(ByVal sender As Object, ByVal args As EventArgs)
            Me.WindowState = FormWindowState.Minimized
        End Sub

        Private Sub titleBar_Close(ByVal sender As Object, ByVal args As EventArgs)
            Application.[Exit]()
        End Sub

        Private Sub gridTile_Click(ByVal sender As Object, ByVal e As EventArgs)
            LoadExample("GridView", CType(sender, RadTileElement))
        End Sub

        Private Sub treeViewTile_Click(ByVal sender As Object, ByVal e As EventArgs)
            LoadExample("TreeView", CType(sender, RadTileElement))
        End Sub

        Private Sub listViewTile_Click(ByVal sender As Object, ByVal e As EventArgs)
            LoadExample("ListView", CType(sender, RadTileElement))
        End Sub

        Private Sub schedulerTile_Click(ByVal sender As Object, ByVal e As EventArgs)
            LoadExample("Scheduler", CType(sender, RadTileElement))
        End Sub

        Private Sub magnifierTile_Click(ByVal sender As Object, ByVal e As EventArgs)
            LoadExample("Magnifier", CType(sender, RadTileElement))
        End Sub

        Private Sub chartViewRotateTile_Click(ByVal sender As Object, ByVal e As EventArgs)
            LoadExample("ChartViewRotate", CType(sender, RadTileElement))
        End Sub

        Private Sub chartViewZoomScrollTile_Click(ByVal sender As Object, ByVal e As EventArgs)
            LoadExample("ChartViewZoomScroll", CType(sender, RadTileElement))
        End Sub

        Private Sub LoadExample(ByVal exampleName As String, ByVal tile As RadTileElement)
            If currentExample <> String.Empty Then
                Return
            End If

            Me.currentExample = exampleName
            Me.headerLabel.Text = tile.Text
            Me.backButton.Visibility = ElementVisibility.Visible
            Me.examplePage.PositionOffset = New SizeF(-Me.radPanorama1.Width, 0)
            examplePage.Visibility = ElementVisibility.Visible
            Dim setting As AnimatedPropertySetting = New AnimatedPropertySetting(RadElement.PositionOffsetProperty, New SizeF(-Me.radPanorama1.Width, 0), SizeF.Empty, CInt((10.0R * 800.0R / Me.Width)), 10)
            AddHandler setting.AnimationFinished, AddressOf OnExampleOpened
            setting.ApplyValue(Me.examplePage)
        End Sub

        Private Sub UnloadExample()
            Me.Controls.Remove(Me.GetCurrentExampleControl())
            Me.backButton.Visibility = ElementVisibility.Hidden
            Me.headerLabel.Text = "Demo Apps Hub"
            Me.examplePage.PositionOffset = New SizeF(-Me.radPanorama1.Width, 0)
            examplePage.Visibility = ElementVisibility.Visible
            Dim setting As AnimatedPropertySetting = New AnimatedPropertySetting(RadElement.PositionOffsetProperty, SizeF.Empty, New SizeF(-Me.radPanorama1.Width, 0), CInt((10.0R * 800.0R / Me.Width)), 10)
            AddHandler setting.AnimationFinished, AddressOf OnExampleClosed
            setting.ApplyValue(Me.examplePage)
        End Sub

        Private Sub OnExampleOpened(ByVal sender As Object, ByVal e As AnimationStatusEventArgs)
            Dim ctrl As UserControl = Me.GetCurrentExampleControl()

            If ctrl IsNot Nothing Then
                Me.Controls.Add(ctrl)
                ctrl.BringToFront()
                Me.UpdateExampleControlPosition()
            End If
        End Sub

        Private Sub OnExampleClosed(ByVal sender As Object, ByVal e As AnimationStatusEventArgs)
            RemoveHandler CType(sender, AnimatedPropertySetting).AnimationFinished, AddressOf OnExampleClosed
            Me.examplePage.Visibility = ElementVisibility.Collapsed
            Me.currentExample = String.Empty
        End Sub

        Private Sub UpdateExampleControlPosition()
            Dim ctrl As UserControl = Me.GetCurrentExampleControl()

            If ctrl IsNot Nothing Then
                ctrl.Bounds = New Rectangle(New Point(120, Me.examplePage.ControlBoundingRectangle.Y + 60), New Size(Me.Width - 180, Me.Height - Me.examplePage.ControlBoundingRectangle.Y - 120))
            End If
        End Sub

        Private Function GetCurrentExampleControl() As UserControl
            If Me.currentExample <> "" AndAlso Me.exampleControls.ContainsKey(Me.currentExample) Then
                Return Me.exampleControls(Me.currentExample)
            End If

            Return Nothing
        End Function

        Protected Overrides Sub WndProc(ByRef m As Message)
            If m.Msg = WM_SIZE AndAlso titleBar IsNot Nothing Then
                titleBar.CloseButton.SetValue(RadFormElement.FormWindowStateProperty, Me.WindowState)
                titleBar.MinimizeButton.SetValue(RadFormElement.FormWindowStateProperty, Me.WindowState)
                titleBar.MaximizeButton.SetValue(RadFormElement.FormWindowStateProperty, Me.WindowState)
            End If

            MyBase.WndProc(m)
        End Sub

        Protected Overrides Function InitializeFormBehavior() As FormControlBehavior
            Return New MyFormBehavior(Me, True)
        End Function
    End Class

    Public Class MyFormBehavior
        Inherits RadFormBehavior

        Public Sub New(ByVal treeHandler As IComponentTreeHandler, ByVal shouldCreateChildren As Boolean)
            MyBase.New(treeHandler, shouldCreateChildren)
        End Sub

        Public Overrides ReadOnly Property BorderWidth As Padding
            Get
                Return New Padding(1)
            End Get
        End Property
    End Class
End Namespace