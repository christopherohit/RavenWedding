Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI

Namespace PhotoAlbumVB
    Partial Public Class Form1
        Inherits RadForm
        Private titleBar As RadTitleBarElement
        Public Const WM_SIZE As Integer = 5

        Public Sub New()
            InitializeComponent()
            ThemeResolutionService.LoadPackageResource("PhotoAlbumVB.PhotoAlbumDemo.tssp")
            ThemeResolutionService.ApplyThemeToControlTree(Me, "PhotoAlbumDemo")

            Me.Text = "Photo album viewer"
            Me.FormElement.TitleBar.MaxSize = New Size(0, 3)
            PrepareTitleBar()
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
            Me.radRadPhotoAlbumViewer1.BackgroundImage = Image.FromFile("background.jpg")
            Me.radRadPhotoAlbumViewer1.Items.Clear()
            For Each file As String In Directory.GetFiles("Photos\", "*.jpg")
                Dim img As Image = Image.FromFile(file)
                Dim imageItem As New PhotoElement()
                imageItem.ToolTipText = "Double click to resize"
                imageItem.Image = img
                AddHandler imageItem.MouseHover, AddressOf imageItem_MouseHover
                AddHandler imageItem.MouseLeave, AddressOf imageItem_MouseLeave
                Me.radRadPhotoAlbumViewer1.Items.Add(imageItem)
            Next
        End Sub

        Private Sub imageItem_MouseLeave(sender As Object, e As EventArgs)
            Cursor = Cursors.[Default]
        End Sub

        Private Sub imageItem_MouseHover(sender As Object, e As EventArgs)
            Cursor = Cursors.Hand
        End Sub


        Private Sub PrepareTitleBar()
            titleBar = New RadTitleBarElement()
            titleBar.Text = "<html><span style=""font-family:segoe ui light;font-size:24"">Photo Album </span><span style=""font-family:segoe ui;font-size:24"">Viewer</span>"
            titleBar.ForeColor = Color.FromArgb(255, 67, 44, 18)

            titleBar.FillPrimitive.Visibility = ElementVisibility.Hidden
            titleBar.CaptionElement.Margin = New Padding(35, 5, 0, 0)
            titleBar.MaxSize = New Size(0, 45)
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
            Me.radRadPhotoAlbumViewer1.AlbumElement.Children.Add(titleBar)
        End Sub

        Private Sub titleBar_MaximizeRestore(sender As Object, args As EventArgs)
            If Me.WindowState <> FormWindowState.Maximized Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
        End Sub

        Private Sub titleBar_Minimize(sender As Object, args As EventArgs)
            Me.WindowState = FormWindowState.Minimized
        End Sub

        Private Sub titleBar_Close(sender As Object, args As EventArgs)
            Application.[Exit]()
        End Sub

        Protected Overrides Sub WndProc(ByRef m As Message)
            If m.Msg = WM_SIZE Then
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
        Public Sub New(treeHandler As IComponentTreeHandler, shouldCreateChildren As Boolean)
            MyBase.New(treeHandler, shouldCreateChildren)
        End Sub

        Public Overrides ReadOnly Property BorderWidth() As Padding
            Get
                Return New Padding(1)
            End Get
        End Property
    End Class

End Namespace