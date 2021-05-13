Namespace Telerik.Examples.WinControls.Buttons.ToggleButton
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.radToggleButton1 = New Telerik.WinControls.UI.RadToggleButton()
            Me.radToggleButton2 = New Telerik.WinControls.UI.RadToggleButton()
            Me.radToggleButton3 = New Telerik.WinControls.UI.RadToggleButton()
            Me.radToggleButton6 = New Telerik.WinControls.UI.RadToggleButton()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.label1 = New Telerik.WinControls.UI.RadLabel()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radToggleButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radToggleButton2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radToggleButton3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radToggleButton6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.label1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radPanelDemoHolder
            '
            Me.radPanelDemoHolder.Controls.Add(Me.radToggleButton6)
            Me.radPanelDemoHolder.Controls.Add(Me.label1)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.ForeColor = System.Drawing.Color.Black
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(404, 285)
            '
            '
            '
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(466, 288)
            '
            'settingsPanel
            '
            Me.settingsPanel.Location = New System.Drawing.Point(973, 1)
            '
            'settingsPanel.PanelContainer
            '
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(250, 534)
            Me.settingsPanel.Size = New System.Drawing.Size(250, 534)
            '
            'radToggleButton1
            '
            Me.radToggleButton1.Location = New System.Drawing.Point(42, 38)
            Me.radToggleButton1.Name = "radToggleButton1"
            Me.radToggleButton1.Size = New System.Drawing.Size(96, 16)
            Me.radToggleButton1.TabIndex = 0
            Me.radToggleButton1.Text = "radToggleButton1"
            Me.radToggleButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            '
            'radToggleButton2
            '
            Me.radToggleButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radToggleButton2.Location = New System.Drawing.Point(42, 79)
            Me.radToggleButton2.Name = "radToggleButton2"
            Me.radToggleButton2.Size = New System.Drawing.Size(113, 19)
            Me.radToggleButton2.TabIndex = 1
            Me.radToggleButton2.Text = "radToggleButton2"
            Me.radToggleButton2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            '
            'radToggleButton3
            '
            Me.radToggleButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radToggleButton3.Location = New System.Drawing.Point(42, 120)
            Me.radToggleButton3.Name = "radToggleButton3"
            Me.radToggleButton3.Size = New System.Drawing.Size(139, 23)
            Me.radToggleButton3.TabIndex = 1
            Me.radToggleButton3.Text = "radToggleButton3"
            Me.radToggleButton3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            '
            'radToggleButton6
            '
            Me.radToggleButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.radToggleButton6.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radToggleButton6.ImageIndex = 3
            Me.radToggleButton6.ImageList = Me.imageList1
            Me.radToggleButton6.Location = New System.Drawing.Point(171, 122)
            Me.radToggleButton6.Name = "radToggleButton6"
            Me.radToggleButton6.Size = New System.Drawing.Size(125, 23)
            Me.radToggleButton6.TabIndex = 2
            Me.radToggleButton6.Text = "Toggle Button"
            Me.radToggleButton6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radToggleButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            CType(Me.radToggleButton6.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            CType(Me.radToggleButton6.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).ImageIndex = 3
            CType(Me.radToggleButton6.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            CType(Me.radToggleButton6.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.radToggleButton6.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            CType(Me.radToggleButton6.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Text = "Toggle Button"
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Fuchsia
            Me.imageList1.Images.SetKeyName(0, "print.gif")
            Me.imageList1.Images.SetKeyName(1, "bulb_on.GIF")
            Me.imageList1.Images.SetKeyName(2, "bulb_off.GIF")
            Me.imageList1.Images.SetKeyName(3, "iconToggleOff.bmp")
            Me.imageList1.Images.SetKeyName(4, "iconToggleOn.bmp")
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(168, 169)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(103, 18)
            Me.label1.TabIndex = 3
            Me.label1.Text = "Button Toggled Off"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1425, 1170)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.radPanelDemoHolder.PerformLayout()
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radToggleButton1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radToggleButton2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radToggleButton3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radToggleButton6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.label1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radToggleButton1 As Telerik.WinControls.UI.RadToggleButton
		Private radToggleButton2 As Telerik.WinControls.UI.RadToggleButton
		Private radToggleButton3 As Telerik.WinControls.UI.RadToggleButton
		Private radToggleButton6 As Telerik.WinControls.UI.RadToggleButton
		Private imageList1 As ImageList
        Private label1 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace