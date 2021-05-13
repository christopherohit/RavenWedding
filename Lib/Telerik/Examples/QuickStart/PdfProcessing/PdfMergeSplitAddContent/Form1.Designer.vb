Namespace Telerik.Examples.WinControls.PdfProcessing.PdfMergeSplitAddContent
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.doubleBufferedFlowLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedFlowLayoutPanel()
            Me.mergePagesButton = New Telerik.WinControls.UI.RadButton()
            Me.splitPagesButton = New Telerik.WinControls.UI.RadButton()
            Me.appendContentButton = New Telerik.WinControls.UI.RadButton()
            Me.prependContentButton = New Telerik.WinControls.UI.RadButton()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.doubleBufferedFlowLayoutPanel1.SuspendLayout()
            CType(Me.mergePagesButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitPagesButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.appendContentButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.prependContentButton, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.doubleBufferedFlowLayoutPanel1.Controls.Add(Me.mergePagesButton)
            Me.doubleBufferedFlowLayoutPanel1.Controls.Add(Me.splitPagesButton)
            Me.doubleBufferedFlowLayoutPanel1.Controls.Add(Me.appendContentButton)
            Me.doubleBufferedFlowLayoutPanel1.Controls.Add(Me.prependContentButton)
            Me.doubleBufferedFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.doubleBufferedFlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.doubleBufferedFlowLayoutPanel1.Name = "doubleBufferedFlowLayoutPanel1"
            Me.doubleBufferedFlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(17)
            Me.doubleBufferedFlowLayoutPanel1.Size = New System.Drawing.Size(2011, 1157)
            Me.doubleBufferedFlowLayoutPanel1.TabIndex = 0
            Me.mergePagesButton.Location = New System.Drawing.Point(20, 20)
            Me.mergePagesButton.Name = "mergePagesButton"
            Me.mergePagesButton.Size = New System.Drawing.Size(110, 24)
            Me.mergePagesButton.TabIndex = 0
            Me.mergePagesButton.Text = "radButton1"
            AddHandler Me.mergePagesButton.Click, New System.EventHandler(AddressOf Me.MergePagesButton_Click)
            Me.splitPagesButton.Location = New System.Drawing.Point(136, 20)
            Me.splitPagesButton.Name = "splitPagesButton"
            Me.splitPagesButton.Size = New System.Drawing.Size(110, 24)
            Me.splitPagesButton.TabIndex = 1
            Me.splitPagesButton.Text = "radButton2"
            AddHandler Me.splitPagesButton.Click, New System.EventHandler(AddressOf Me.SplitPagesButton_Click)
            Me.appendContentButton.Location = New System.Drawing.Point(252, 20)
            Me.appendContentButton.Name = "appendContentButton"
            Me.appendContentButton.Size = New System.Drawing.Size(110, 24)
            Me.appendContentButton.TabIndex = 2
            Me.appendContentButton.Text = "radButton3"
            AddHandler Me.appendContentButton.Click, New System.EventHandler(AddressOf Me.AppendContentButton_Click)
            Me.prependContentButton.Location = New System.Drawing.Point(368, 20)
            Me.prependContentButton.Name = "prependContentButton"
            Me.prependContentButton.Size = New System.Drawing.Size(110, 24)
            Me.prependContentButton.TabIndex = 3
            Me.prependContentButton.Text = "radButton4"
            AddHandler Me.prependContentButton.Click, New System.EventHandler(AddressOf Me.PrependContentButton_Click)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.doubleBufferedFlowLayoutPanel1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2011, 1157)
            Me.Controls.SetChildIndex(Me.doubleBufferedFlowLayoutPanel1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.doubleBufferedFlowLayoutPanel1.ResumeLayout(False)
            CType(Me.mergePagesButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitPagesButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.appendContentButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.prependContentButton, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private doubleBufferedFlowLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedFlowLayoutPanel
        Private mergePagesButton As Telerik.WinControls.UI.RadButton
        Private splitPagesButton As Telerik.WinControls.UI.RadButton
        Private appendContentButton As Telerik.WinControls.UI.RadButton
        Private prependContentButton As Telerik.WinControls.UI.RadButton
    End Class
End Namespace
