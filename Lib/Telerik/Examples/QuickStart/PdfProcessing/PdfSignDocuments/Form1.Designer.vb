Namespace Telerik.Examples.WinControls.PdfProcessing.PdfSignDocuments
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.splitPanel1 = New Telerik.WinControls.UI.SplitPanel()
            Me.radButton1 = New Telerik.WinControls.UI.RadButton()
            Me.splitPanel2 = New Telerik.WinControls.UI.SplitPanel()
            Me.radPdfViewer1 = New Telerik.WinControls.UI.RadPdfViewer()
            Me.radPdfViewerNavigator1 = New Telerik.WinControls.UI.RadPdfViewerNavigator()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radSplitContainer1.SuspendLayout()
            CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitPanel1.SuspendLayout()
            CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitPanel2.SuspendLayout()
            CType(Me.radPdfViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPdfViewerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radSplitContainer1.Controls.Add(Me.splitPanel1)
            Me.radSplitContainer1.Controls.Add(Me.splitPanel2)
            Me.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSplitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.radSplitContainer1.Name = "radSplitContainer1"
            Me.radSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.radSplitContainer1.Size = New System.Drawing.Size(1492, 732)
            Me.radSplitContainer1.TabIndex = 0
            Me.radSplitContainer1.TabStop = False
            Me.radSplitContainer1.Text = "radSplitContainer1"
            Me.splitPanel1.Controls.Add(Me.radButton1)
            Me.splitPanel1.Location = New System.Drawing.Point(0, 0)
            Me.splitPanel1.Name = "splitPanel1"
            Me.splitPanel1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.splitPanel1.Size = New System.Drawing.Size(297, 732)
            Me.splitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.3004032F, 0.0F)
            Me.splitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-327, 0)
            Me.splitPanel1.TabIndex = 0
            Me.splitPanel1.TabStop = False
            Me.splitPanel1.Text = "splitPanel1"
            Me.radButton1.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Top
            Me.radButton1.Location = New System.Drawing.Point(20, 20)
            Me.radButton1.Name = "radButton1"
            Me.radButton1.Size = New System.Drawing.Size(260, 24)
            Me.radButton1.TabIndex = 0
            Me.radButton1.Text = "Sign Document"
            AddHandler Me.radButton1.Click, New System.EventHandler(AddressOf Me.radButton1_Click)
            Me.splitPanel2.Controls.Add(Me.radPdfViewer1)
            Me.splitPanel2.Controls.Add(Me.radPdfViewerNavigator1)
            Me.splitPanel2.Location = New System.Drawing.Point(301, 0)
            Me.splitPanel2.Name = "splitPanel2"
            Me.splitPanel2.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.splitPanel2.Size = New System.Drawing.Size(1191, 732)
            Me.splitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.3004032F, 0.0F)
            Me.splitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(327, 0)
            Me.splitPanel2.TabIndex = 1
            Me.splitPanel2.TabStop = False
            Me.splitPanel2.Text = "splitPanel2"
            Me.radPdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPdfViewer1.Location = New System.Drawing.Point(0, 38)
            Me.radPdfViewer1.Name = "radPdfViewer1"
            Me.radPdfViewer1.Size = New System.Drawing.Size(1191, 694)
            Me.radPdfViewer1.TabIndex = 1
            Me.radPdfViewer1.Text = "radPdfViewer1"
            Me.radPdfViewer1.ThumbnailsScaleFactor = 0.15F
            Me.radPdfViewerNavigator1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radPdfViewerNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.radPdfViewerNavigator1.Name = "radPdfViewerNavigator1"
            Me.radPdfViewerNavigator1.Size = New System.Drawing.Size(1191, 38)
            Me.radPdfViewerNavigator1.TabIndex = 0
            Me.radPdfViewerNavigator1.Text = "radPdfViewerNavigator1"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radSplitContainer1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1502, 742)
            Me.Controls.SetChildIndex(Me.radSplitContainer1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radSplitContainer1.ResumeLayout(False)
            CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitPanel1.ResumeLayout(False)
            CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitPanel2.ResumeLayout(False)
            Me.splitPanel2.PerformLayout()
            CType(Me.radPdfViewer1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPdfViewerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
        Private splitPanel1 As Telerik.WinControls.UI.SplitPanel
        Private radButton1 As Telerik.WinControls.UI.RadButton
        Private splitPanel2 As Telerik.WinControls.UI.SplitPanel
        Private radPdfViewer1 As Telerik.WinControls.UI.RadPdfViewer
        Private radPdfViewerNavigator1 As Telerik.WinControls.UI.RadPdfViewerNavigator
    End Class
End Namespace
