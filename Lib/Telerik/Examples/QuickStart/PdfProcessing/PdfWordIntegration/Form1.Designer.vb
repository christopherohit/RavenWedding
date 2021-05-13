Namespace Telerik.Examples.WinControls.PdfProcessing.PdfWordIntegration
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim radListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.pictureBox2 = New System.Windows.Forms.PictureBox()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.loadCustomDocButton = New Telerik.WinControls.UI.RadButton()
            Me.loadSampleDocButton = New Telerik.WinControls.UI.RadButton()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.documentPathLabel = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
            Me.saveButton = New Telerik.WinControls.UI.RadButton()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.loadCustomDocButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.loadSampleDocButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.documentPathLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.saveButton, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(693, 45)
            Me.pictureBox1.Location = New System.Drawing.Point(20, 20)
            Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(200, 250)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            Me.pictureBox2.Location = New System.Drawing.Point(281, 20)
            Me.pictureBox2.Margin = New System.Windows.Forms.Padding(4)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.Size = New System.Drawing.Size(200, 250)
            Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox2.TabIndex = 1
            Me.pictureBox2.TabStop = False
            Me.radLabel1.Location = New System.Drawing.Point(231, 137)
            Me.radLabel1.Margin = New System.Windows.Forms.Padding(4)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(37, 18)
            Me.radLabel1.TabIndex = 2
            Me.radLabel1.Text = "- OR -"
            Me.loadCustomDocButton.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.loadCustomDocButton.Location = New System.Drawing.Point(10, 10)
            Me.loadCustomDocButton.Margin = New System.Windows.Forms.Padding(10)
            Me.loadCustomDocButton.Name = "loadCustomDocButton"
            Me.loadCustomDocButton.Size = New System.Drawing.Size(209, 24)
            Me.loadCustomDocButton.TabIndex = 3
            Me.loadCustomDocButton.Text = "Load Custom Document"
            AddHandler Me.loadCustomDocButton.Click, New System.EventHandler(AddressOf Me.loadCustomDocButton_Click)
            Me.loadSampleDocButton.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.loadSampleDocButton.Location = New System.Drawing.Point(239, 10)
            Me.loadSampleDocButton.Margin = New System.Windows.Forms.Padding(10)
            Me.loadSampleDocButton.Name = "loadSampleDocButton"
            Me.loadSampleDocButton.Size = New System.Drawing.Size(209, 24)
            Me.loadSampleDocButton.TabIndex = 4
            Me.loadSampleDocButton.Text = "Load Sample Document"
            AddHandler Me.loadSampleDocButton.Click, New System.EventHandler(AddressOf Me.loadSampleDocButton_Click)
            Me.radLabel2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.radLabel2.Location = New System.Drawing.Point(194, 91)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(32, 21)
            Me.radLabel2.TabIndex = 5
            Me.radLabel2.Text = "File:"
            Me.documentPathLabel.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.documentPathLabel.Location = New System.Drawing.Point(232, 91)
            Me.documentPathLabel.Name = "documentPathLabel"
            Me.documentPathLabel.Size = New System.Drawing.Size(2, 2)
            Me.documentPathLabel.TabIndex = 6
            Me.radLabel4.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.radLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.radLabel4.Location = New System.Drawing.Point(157, 179)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(69, 21)
            Me.radLabel4.TabIndex = 7
            Me.radLabel4.Text = "Export to:"
            Me.radDropDownList1.DropDownAnimationEnabled = False
            radListDataItem1.Text = "Pdf"
            Me.radDropDownList1.Items.Add(radListDataItem1)
            Me.radDropDownList1.Location = New System.Drawing.Point(232, 179)
            Me.radDropDownList1.Name = "radDropDownList1"
            Me.radDropDownList1.Size = New System.Drawing.Size(132, 20)
            Me.radDropDownList1.TabIndex = 8
            Me.saveButton.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.saveButton, 2)
            Me.saveButton.Location = New System.Drawing.Point(3, 267)
            Me.saveButton.Name = "saveButton"
            Me.saveButton.Size = New System.Drawing.Size(452, 24)
            Me.saveButton.TabIndex = 9
            Me.saveButton.Text = "Save"
            AddHandler Me.saveButton.Click, New System.EventHandler(AddressOf Me.saveButton_Click)
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 2
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.loadCustomDocButton, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.loadSampleDocButton, 1, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.saveButton, 0, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel2, 0, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radDropDownList1, 1, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel4, 0, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.documentPathLabel, 1, 1)
            Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(23, 293)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 4
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(458, 352)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 10
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.Controls.Add(Me.radLabel1)
            Me.Controls.Add(Me.pictureBox2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2011, 1157)
            Me.Controls.SetChildIndex(Me.pictureBox1, 0)
            Me.Controls.SetChildIndex(Me.pictureBox2, 0)
            Me.Controls.SetChildIndex(Me.radLabel1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.doubleBufferedTableLayoutPanel1, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.loadCustomDocButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.loadSampleDocButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.documentPathLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.saveButton, System.ComponentModel.ISupportInitialize).EndInit()
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private pictureBox2 As System.Windows.Forms.PictureBox
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private loadCustomDocButton As Telerik.WinControls.UI.RadButton
        Private loadSampleDocButton As Telerik.WinControls.UI.RadButton
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private documentPathLabel As Telerik.WinControls.UI.RadLabel
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
        Private saveButton As Telerik.WinControls.UI.RadButton
        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
    End Class
End Namespace
