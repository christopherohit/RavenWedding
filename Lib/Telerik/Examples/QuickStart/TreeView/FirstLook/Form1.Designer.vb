Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TreeView.FirstLook
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
            Me.radDropDownButton1 = New Telerik.WinControls.UI.RadDropDownButton()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Location = New System.Drawing.Point(982, 1)
            '
            'settingsPanel.PanelContainer
            '
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(200, 747)
            Me.settingsPanel.Size = New System.Drawing.Size(200, 747)
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "folder_feed.png")
            Me.imageList1.Images.SetKeyName(1, "feed.png")
            '
            'radTreeView1
            '
            Me.radTreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radTreeView1, 3)
            Me.radTreeView1.ImageIndex = 0
            Me.radTreeView1.ImageList = Me.imageList1
            Me.radTreeView1.Location = New System.Drawing.Point(3, 75)
            Me.radTreeView1.Name = "radTreeView1"
            Me.radTreeView1.Size = New System.Drawing.Size(470, 522)
            Me.radTreeView1.SpacingBetweenNodes = -1
            Me.radTreeView1.TabIndex = 3
            '
            'radDropDownButton1
            '
            Me.radDropDownButton1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.radDropDownButton1.Location = New System.Drawing.Point(296, 9)
            Me.radDropDownButton1.Name = "radDropDownButton1"
            Me.radDropDownButton1.Size = New System.Drawing.Size(140, 24)
            Me.radDropDownButton1.TabIndex = 4
            Me.radDropDownButton1.Text = "None"
            '
            'radLabel1
            '
            Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.radLabel1.Location = New System.Drawing.Point(251, 12)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(29, 18)
            Me.radLabel1.TabIndex = 2
            Me.radLabel1.Text = "Sort:"
            '
            'radTextBox1
            '
            Me.radTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.radTextBox1.Location = New System.Drawing.Point(3, 11)
            Me.radTextBox1.Name = "radTextBox1"
            Me.radTextBox1.NullText = "Type here to filter"
            Me.radTextBox1.Size = New System.Drawing.Size(232, 20)
            Me.radTextBox1.TabIndex = 0
            Me.radTextBox1.TabStop = False
            '
            'doubleBufferedTableLayoutPanel1
            '
            Me.doubleBufferedTableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 3
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248.0!))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radTreeView1, 0, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radDropDownButton1, 2, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel2, 0, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel1, 1, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radTextBox1, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(744, 20)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 3
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(476, 600)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 3
            '
            'radLabel2
            '
            Me.radLabel2.AutoSize = False
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radLabel2, 3)
            Me.radLabel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel2.Location = New System.Drawing.Point(3, 45)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(470, 24)
            Me.radLabel2.TabIndex = 0
            Me.radLabel2.Text = "Subscriptions"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2011, 1157)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.doubleBufferedTableLayoutPanel1, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownButton1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.PerformLayout()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private imageList1 As System.Windows.Forms.ImageList
        Private radTreeView1 As RadTreeView
        Private radLabel1 As RadLabel
        Private radTextBox1 As RadTextBox
        Private radDropDownButton1 As RadDropDownButton
        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private radLabel2 As RadLabel
    End Class
End Namespace
