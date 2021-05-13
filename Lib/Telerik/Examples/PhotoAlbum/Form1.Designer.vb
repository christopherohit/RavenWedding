Imports Microsoft.VisualBasic
Imports System

Namespace PhotoAlbumVB
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            Me.radRadPhotoAlbumViewer1 = New RadPhotoAlbumViewer()
            Me.radButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radButtonElement2 = New Telerik.WinControls.UI.RadButtonElement()
            CType(Me.radRadPhotoAlbumViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'imageList2
            '
            Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList2.Images.SetKeyName(0, "ribbon_minimize.png")
            Me.imageList2.Images.SetKeyName(1, "ribbon_maximize.png")
            Me.imageList2.Images.SetKeyName(2, "ribbon_close.png")
            '
            'radRadPhotoAlbumViewer1
            '
            '
            '
            '
            Me.radRadPhotoAlbumViewer1.AlbumElement.OriginalItemSize = New System.Drawing.Size(250, 150)
            Me.radRadPhotoAlbumViewer1.BackColor = System.Drawing.Color.Transparent
            Me.radRadPhotoAlbumViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radRadPhotoAlbumViewer1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radButtonElement1, Me.radButtonElement2})
            Me.radRadPhotoAlbumViewer1.Location = New System.Drawing.Point(0, 0)
            Me.radRadPhotoAlbumViewer1.Name = "radRadPhotoAlbumViewer1"
            Me.radRadPhotoAlbumViewer1.Size = New System.Drawing.Size(792, 573)
            Me.radRadPhotoAlbumViewer1.TabIndex = 0
            Me.radRadPhotoAlbumViewer1.Text = "radButton1"
            Me.radRadPhotoAlbumViewer1.ThemeName = "no theme"
            CType(Me.radRadPhotoAlbumViewer1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
            CType(Me.radRadPhotoAlbumViewer1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(183, Byte), Integer))
            CType(Me.radRadPhotoAlbumViewer1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 3
            CType(Me.radRadPhotoAlbumViewer1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Radial
            CType(Me.radRadPhotoAlbumViewer1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Transparent
            CType(Me.radRadPhotoAlbumViewer1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            '
            'radButtonElement1
            '
            Me.radButtonElement1.AccessibleDescription = "radButtonElement1"
            Me.radButtonElement1.AccessibleName = "radButtonElement1"
            Me.radButtonElement1.AngleTransform = 35.0!
            Me.radButtonElement1.AutoSize = False
            Me.radButtonElement1.Bounds = New System.Drawing.Rectangle(504, 205, 250, 150)
            Me.radButtonElement1.CanFocus = True
            Me.radButtonElement1.ClipDrawing = True
            Me.radButtonElement1.Name = "radButtonElement1"
            Me.radButtonElement1.ShowBorder = False
            Me.radButtonElement1.Text = "radButtonElement1"
            Me.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radButtonElement1.ZIndex = 2
            '
            'radButtonElement2
            '
            Me.radButtonElement2.AccessibleDescription = "radButtonElement2"
            Me.radButtonElement2.AccessibleName = "radButtonElement2"
            Me.radButtonElement2.AngleTransform = 15.0!
            Me.radButtonElement2.AutoSize = False
            Me.radButtonElement2.Bounds = New System.Drawing.Rectangle(342, 182, 250, 150)
            Me.radButtonElement2.CanFocus = True
            Me.radButtonElement2.ClipDrawing = True
            Me.radButtonElement2.Name = "radButtonElement2"
            Me.radButtonElement2.ShowBorder = False
            Me.radButtonElement2.Text = "radButtonElement2"
            Me.radButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radButtonElement2.ZIndex = 1
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.Size = new System.Drawing.Size(960, 680)
            Me.Controls.Add(Me.radRadPhotoAlbumViewer1)
            Me.Name = "Form1"
            Me.Text = "Photo album viewer"
            CType(Me.radRadPhotoAlbumViewer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radRadPhotoAlbumViewer1 As RadPhotoAlbumViewer
        Private radButtonElement1 As Telerik.WinControls.UI.RadButtonElement
        Private radButtonElement2 As Telerik.WinControls.UI.RadButtonElement
        Private imageList2 As System.Windows.Forms.ImageList
    End Class
End Namespace