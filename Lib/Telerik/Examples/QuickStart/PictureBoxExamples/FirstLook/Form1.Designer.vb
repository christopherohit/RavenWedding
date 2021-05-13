Namespace Telerik.Examples.WinControls.PictureBoxExamples.FirstLook
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radButtonNewAlbum = New Telerik.WinControls.UI.RadButton()
            Me.radButtonMailingsAlbum = New Telerik.WinControls.UI.RadButton()
            Me.radButtonPageLayoutAlbum = New Telerik.WinControls.UI.RadButton()
            Me.radButtonInsertAlbum = New Telerik.WinControls.UI.RadButton()
            Me.radButtonAllAlbums = New Telerik.WinControls.UI.RadButton()
            Me.radLabelApplicationAlbums = New Telerik.WinControls.UI.RadLabel()
            Me.radButtonAddAlbum = New Telerik.WinControls.UI.RadButton()
            Me.radScrollablePanel1 = New Telerik.WinControls.UI.RadScrollablePanel()
            Me.doubleBufferedFlowLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedFlowLayoutPanel()
            Me.doubleBufferedTableLayoutPanel2 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radLabelSelectedAlbum = New Telerik.WinControls.UI.RadLabel()
            Me.radButtonAddImage = New Telerik.WinControls.UI.RadButton()
            Me.radButtonSaveImage = New Telerik.WinControls.UI.RadButton()
            Me.radButtonDownloadImage = New Telerik.WinControls.UI.RadButton()
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            CType((Me.radButtonNewAlbum), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radButtonMailingsAlbum), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radButtonPageLayoutAlbum), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radButtonInsertAlbum), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radButtonAllAlbums), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabelApplicationAlbums), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radButtonAddAlbum), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radScrollablePanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radScrollablePanel1.PanelContainer.SuspendLayout()
            Me.radScrollablePanel1.SuspendLayout()
            Me.doubleBufferedTableLayoutPanel2.SuspendLayout()
            CType((Me.radLabelSelectedAlbum), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radButtonAddImage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radButtonSaveImage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radButtonDownloadImage), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radPanelDemoHolder.Controls.Add(Me.radScrollablePanel1)
            Me.radPanelDemoHolder.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(147, 85)
            Me.radPanelDemoHolder.Padding = New System.Windows.Forms.Padding(20)
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(740, 530)
            Me.settingsPanel.Location = New System.Drawing.Point(1170, 55)
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 7
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41.0F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.95735F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.95735F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.95735F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.95735F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.95735F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.213269F))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radButtonNewAlbum, 5, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radButtonMailingsAlbum, 4, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radButtonPageLayoutAlbum, 3, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radButtonInsertAlbum, 2, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radButtonAllAlbums, 1, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabelApplicationAlbums, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radButtonAddAlbum, 0, 1)
            Me.doubleBufferedTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(20, 20)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 2
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0F))
            Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(700, 80)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 0
            Me.radButtonNewAlbum.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonNewAlbum.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.radButtonNewAlbum.Location = New System.Drawing.Point(542, 34)
            Me.radButtonNewAlbum.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
            Me.radButtonNewAlbum.Name = "radButtonNewAlbum"
            Me.radButtonNewAlbum.Padding = New System.Windows.Forms.Padding(2)
            Me.radButtonNewAlbum.Size = New System.Drawing.Size(114, 36)
            Me.radButtonNewAlbum.TabIndex = 6
            Me.radButtonNewAlbum.Text = " New Album"
            Me.radButtonNewAlbum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radButtonNewAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radButtonNewAlbum.Visible = False
            AddHandler Me.radButtonNewAlbum.Click, AddressOf RadButtonNewAlbum_Click
            Me.radButtonMailingsAlbum.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonMailingsAlbum.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.radButtonMailingsAlbum.Location = New System.Drawing.Point(418, 34)
            Me.radButtonMailingsAlbum.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
            Me.radButtonMailingsAlbum.Name = "radButtonMailingsAlbum"
            Me.radButtonMailingsAlbum.Padding = New System.Windows.Forms.Padding(2)
            Me.radButtonMailingsAlbum.Size = New System.Drawing.Size(114, 36)
            Me.radButtonMailingsAlbum.TabIndex = 5
            Me.radButtonMailingsAlbum.Text = " Mailings"
            Me.radButtonMailingsAlbum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radButtonMailingsAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            AddHandler Me.radButtonMailingsAlbum.Click, AddressOf Me.RadButtonMailingsAlbum_Click
            Me.radButtonPageLayoutAlbum.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonPageLayoutAlbum.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.radButtonPageLayoutAlbum.Location = New System.Drawing.Point(294, 34)
            Me.radButtonPageLayoutAlbum.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
            Me.radButtonPageLayoutAlbum.Name = "radButtonPageLayoutAlbum"
            Me.radButtonPageLayoutAlbum.Padding = New System.Windows.Forms.Padding(2)
            Me.radButtonPageLayoutAlbum.Size = New System.Drawing.Size(114, 36)
            Me.radButtonPageLayoutAlbum.TabIndex = 4
            Me.radButtonPageLayoutAlbum.Text = " Page Layout"
            Me.radButtonPageLayoutAlbum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radButtonPageLayoutAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            AddHandler Me.radButtonPageLayoutAlbum.Click, AddressOf RadButtonPageLayoutAlbum_Click
            Me.radButtonInsertAlbum.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonInsertAlbum.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.radButtonInsertAlbum.Location = New System.Drawing.Point(170, 34)
            Me.radButtonInsertAlbum.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
            Me.radButtonInsertAlbum.Name = "radButtonInsertAlbum"
            Me.radButtonInsertAlbum.Padding = New System.Windows.Forms.Padding(2)
            Me.radButtonInsertAlbum.Size = New System.Drawing.Size(114, 36)
            Me.radButtonInsertAlbum.TabIndex = 3
            Me.radButtonInsertAlbum.Text = " Insert"
            Me.radButtonInsertAlbum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radButtonInsertAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            AddHandler Me.radButtonInsertAlbum.Click, AddressOf Me.RadButtonInsertAlbum_Click
            Me.radButtonAllAlbums.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonAllAlbums.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.radButtonAllAlbums.Location = New System.Drawing.Point(46, 34)
            Me.radButtonAllAlbums.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
            Me.radButtonAllAlbums.Name = "radButtonAllAlbums"
            Me.radButtonAllAlbums.Padding = New System.Windows.Forms.Padding(2)
            Me.radButtonAllAlbums.Size = New System.Drawing.Size(114, 36)
            Me.radButtonAllAlbums.TabIndex = 2
            Me.radButtonAllAlbums.Text = " All Images"
            Me.radButtonAllAlbums.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radButtonAllAlbums.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            AddHandler Me.radButtonAllAlbums.Click, AddressOf Me.RadButtonAllAlbums_Click
            Me.radLabelApplicationAlbums.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radLabelApplicationAlbums.AutoSize = False
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radLabelApplicationAlbums, 7)
            Me.radLabelApplicationAlbums.Font = New System.Drawing.Font("Segoe UI", 12.0F)
            Me.radLabelApplicationAlbums.Location = New System.Drawing.Point(0, 0)
            Me.radLabelApplicationAlbums.Margin = New System.Windows.Forms.Padding(0)
            Me.radLabelApplicationAlbums.Name = "radLabelApplicationAlbums"
            Me.radLabelApplicationAlbums.Size = New System.Drawing.Size(700, 24)
            Me.radLabelApplicationAlbums.TabIndex = 0
            Me.radLabelApplicationAlbums.Text = "Application Albums"
            CType((Me.radLabelApplicationAlbums.GetChildAt(0)), Telerik.WinControls.UI.RadLabelElement).Text = "Application Albums"
            CType((Me.radLabelApplicationAlbums.GetChildAt(0).GetChildAt(2).GetChildAt(1)), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = True
            CType((Me.radLabelApplicationAlbums.GetChildAt(0).GetChildAt(2).GetChildAt(1)), Telerik.WinControls.Primitives.TextPrimitive).Margin = New System.Windows.Forms.Padding(-3, 0, 3, 0)
            Me.radButtonAddAlbum.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonAddAlbum.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radButtonAddAlbum.Location = New System.Drawing.Point(1, 34)
            Me.radButtonAddAlbum.Margin = New System.Windows.Forms.Padding(1, 0, 4, 0)
            Me.radButtonAddAlbum.Name = "radButtonAddAlbum"
            Me.radButtonAddAlbum.Padding = New System.Windows.Forms.Padding(2)
            Me.radButtonAddAlbum.Size = New System.Drawing.Size(36, 36)
            Me.radButtonAddAlbum.TabIndex = 1
            AddHandler Me.radButtonAddAlbum.Click, AddressOf Me.RadButtonAddAlbum_Click
            Me.radScrollablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radScrollablePanel1.Location = New System.Drawing.Point(20, 100)
            Me.radScrollablePanel1.Name = "radScrollablePanel1"
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.doubleBufferedFlowLayoutPanel1)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.doubleBufferedTableLayoutPanel2)
            Me.radScrollablePanel1.PanelContainer.Size = New System.Drawing.Size(698, 408)
            Me.radScrollablePanel1.RootElement.EnableElementShadow = False
            Me.radScrollablePanel1.Size = New System.Drawing.Size(700, 410)
            Me.radScrollablePanel1.TabIndex = 1
            Me.doubleBufferedFlowLayoutPanel1.AutoSize = True
            Me.doubleBufferedFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.doubleBufferedFlowLayoutPanel1.Location = New System.Drawing.Point(0, 40)
            Me.doubleBufferedFlowLayoutPanel1.Name = "doubleBufferedFlowLayoutPanel1"
            Me.doubleBufferedFlowLayoutPanel1.Size = New System.Drawing.Size(698, 0)
            Me.doubleBufferedFlowLayoutPanel1.TabIndex = 1
            Me.doubleBufferedTableLayoutPanel2.ColumnCount = 5
            Me.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0F))
            Me.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0F))
            Me.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0F))
            Me.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0F))
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radLabelSelectedAlbum, 0, 0)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radButtonAddImage, 1, 0)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radButtonSaveImage, 2, 0)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radButtonDownloadImage, 3, 0)
            Me.doubleBufferedTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.doubleBufferedTableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
            Me.doubleBufferedTableLayoutPanel2.Name = "doubleBufferedTableLayoutPanel2"
            Me.doubleBufferedTableLayoutPanel2.RowCount = 1
            Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.doubleBufferedTableLayoutPanel2.Size = New System.Drawing.Size(698, 40)
            Me.doubleBufferedTableLayoutPanel2.TabIndex = 0
            Me.radLabelSelectedAlbum.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radLabelSelectedAlbum.AutoSize = False
            Me.radLabelSelectedAlbum.Font = New System.Drawing.Font("Segoe UI", 12.0F)
            Me.radLabelSelectedAlbum.Location = New System.Drawing.Point(5, 3)
            Me.radLabelSelectedAlbum.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
            Me.radLabelSelectedAlbum.Name = "radLabelSelectedAlbum"
            Me.radLabelSelectedAlbum.Size = New System.Drawing.Size(558, 34)
            Me.radLabelSelectedAlbum.TabIndex = 1
            Me.radLabelSelectedAlbum.Text = "All"
            Me.radLabelSelectedAlbum.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.radButtonAddImage.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonAddImage.Location = New System.Drawing.Point(571, 11)
            Me.radButtonAddImage.Margin = New System.Windows.Forms.Padding(5, 8, 5, 0)
            Me.radButtonAddImage.Name = "radButtonAddImage"
            Me.radButtonAddImage.Padding = New System.Windows.Forms.Padding(2)
            Me.radButtonAddImage.RootElement.ControlDefaultSize = New System.Drawing.Size(0, 26)
            Me.radButtonAddImage.Size = New System.Drawing.Size(26, 26)
            Me.radButtonAddImage.TabIndex = 2
            AddHandler Me.radButtonAddImage.Click, AddressOf RadButtonAddImage_Click
            Me.radButtonSaveImage.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonSaveImage.Location = New System.Drawing.Point(607, 11)
            Me.radButtonSaveImage.Margin = New System.Windows.Forms.Padding(5, 8, 5, 0)
            Me.radButtonSaveImage.Name = "radButtonSaveImage"
            Me.radButtonSaveImage.Padding = New System.Windows.Forms.Padding(2)
            Me.radButtonSaveImage.RootElement.ControlDefaultSize = New System.Drawing.Size(0, 26)
            Me.radButtonSaveImage.Size = New System.Drawing.Size(26, 26)
            Me.radButtonSaveImage.TabIndex = 3
            AddHandler Me.radButtonSaveImage.Click, AddressOf RadButtonSaveImage_Click
            Me.radButtonDownloadImage.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radButtonDownloadImage.Location = New System.Drawing.Point(643, 11)
            Me.radButtonDownloadImage.Margin = New System.Windows.Forms.Padding(5, 8, 5, 0)
            Me.radButtonDownloadImage.Name = "radButtonDownloadImage"
            Me.radButtonDownloadImage.Padding = New System.Windows.Forms.Padding(2)
            Me.radButtonDownloadImage.RootElement.ControlDefaultSize = New System.Drawing.Size(0, 26)
            Me.radButtonDownloadImage.Size = New System.Drawing.Size(26, 26)
            Me.radButtonDownloadImage.TabIndex = 4
            AddHandler Me.radButtonDownloadImage.Click, AddressOf RadButtonDownloadImage_Click
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(20)
            Me.Size = New System.Drawing.Size(1454, 788)
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            CType((Me.radButtonNewAlbum), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radButtonMailingsAlbum), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radButtonPageLayoutAlbum), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radButtonInsertAlbum), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radButtonAllAlbums), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabelApplicationAlbums), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radButtonAddAlbum), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radScrollablePanel1.PanelContainer.ResumeLayout(False)
            Me.radScrollablePanel1.PanelContainer.PerformLayout()
            CType((Me.radScrollablePanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radScrollablePanel1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel2.ResumeLayout(False)
            CType((Me.radLabelSelectedAlbum), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radButtonAddImage), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radButtonSaveImage), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radButtonDownloadImage), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radScrollablePanel1 As Telerik.WinControls.UI.RadScrollablePanel
        Private doubleBufferedTableLayoutPanel2 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private doubleBufferedFlowLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedFlowLayoutPanel
        Private radButtonNewAlbum As Telerik.WinControls.UI.RadButton
        Private radButtonMailingsAlbum As Telerik.WinControls.UI.RadButton
        Private radButtonPageLayoutAlbum As Telerik.WinControls.UI.RadButton
        Private radButtonInsertAlbum As Telerik.WinControls.UI.RadButton
        Private radButtonAllAlbums As Telerik.WinControls.UI.RadButton
        Private radLabelApplicationAlbums As Telerik.WinControls.UI.RadLabel
        Private radButtonAddAlbum As Telerik.WinControls.UI.RadButton
        Private radLabelSelectedAlbum As Telerik.WinControls.UI.RadLabel
        Private radButtonAddImage As Telerik.WinControls.UI.RadButton
        Private radButtonSaveImage As Telerik.WinControls.UI.RadButton
        Private radButtonDownloadImage As Telerik.WinControls.UI.RadButton
    End Class
End Namespace
