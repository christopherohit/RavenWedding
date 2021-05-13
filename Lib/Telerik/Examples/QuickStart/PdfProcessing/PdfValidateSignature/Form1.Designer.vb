Namespace Telerik.Examples.WinControls.PdfProcessing.PdfValidateSignature
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim radListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.splitPanel1 = New Telerik.WinControls.UI.SplitPanel()
            Me.openYourDocumentButton = New Telerik.WinControls.UI.RadButton()
            Me.signatureTypeListBox = New Telerik.WinControls.UI.RadListControl()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.splitPanel2 = New Telerik.WinControls.UI.SplitPanel()
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.tableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
            Me.statusImage = New Telerik.WinControls.UI.RadLabel()
            Me.textBlockIsDocumentModified = New Telerik.WinControls.UI.RadLabel()
            Me.textBlockIsCertificateValid = New Telerik.WinControls.UI.RadLabel()
            Me.textBlockSignerInformation = New Telerik.WinControls.UI.RadLabel()
            Me.textBlockHashAlgorithm = New Telerik.WinControls.UI.RadLabel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radSplitContainer1.SuspendLayout()
            CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitPanel1.SuspendLayout()
            CType(Me.openYourDocumentButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.signatureTypeListBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitPanel2.SuspendLayout()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.SuspendLayout()
            Me.tableLayoutPanel1.SuspendLayout()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.statusImage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textBlockIsDocumentModified, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textBlockIsCertificateValid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textBlockSignerInformation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textBlockHashAlgorithm, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(1778, 0)
            Me.radSplitContainer1.Controls.Add(Me.splitPanel1)
            Me.radSplitContainer1.Controls.Add(Me.splitPanel2)
            Me.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSplitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.radSplitContainer1.Name = "radSplitContainer1"
            Me.radSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.radSplitContainer1.Size = New System.Drawing.Size(2011, 1157)
            Me.radSplitContainer1.TabIndex = 0
            Me.radSplitContainer1.TabStop = False
            Me.splitPanel1.Controls.Add(Me.openYourDocumentButton)
            Me.splitPanel1.Controls.Add(Me.signatureTypeListBox)
            Me.splitPanel1.Controls.Add(Me.radLabel1)
            Me.splitPanel1.Location = New System.Drawing.Point(0, 0)
            Me.splitPanel1.Name = "splitPanel1"
            Me.splitPanel1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.splitPanel1.Size = New System.Drawing.Size(320, 1157)
            Me.splitPanel1.SizeInfo.AbsoluteSize = New System.Drawing.Size(320, 200)
            Me.splitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.2467532F, 0.0F)
            Me.splitPanel1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Absolute
            Me.splitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-286, 0)
            Me.splitPanel1.TabIndex = 0
            Me.splitPanel1.TabStop = False
            Me.splitPanel1.Text = "splitPanel1"
            Me.openYourDocumentButton.Location = New System.Drawing.Point(13, 232)
            Me.openYourDocumentButton.Name = "openYourDocumentButton"
            Me.openYourDocumentButton.Size = New System.Drawing.Size(283, 24)
            Me.openYourDocumentButton.TabIndex = 2
            Me.openYourDocumentButton.Text = "Open your document"
            AddHandler Me.openYourDocumentButton.Click, New System.EventHandler(AddressOf Me.openYourDocument_Click)
            radListDataItem4.Text = "Valid signature"
            radListDataItem5.Text = "Inavalid signature"
            radListDataItem6.Text = "Unknown signature"
            Me.signatureTypeListBox.Items.Add(radListDataItem4)
            Me.signatureTypeListBox.Items.Add(radListDataItem5)
            Me.signatureTypeListBox.Items.Add(radListDataItem6)
            Me.signatureTypeListBox.Location = New System.Drawing.Point(13, 52)
            Me.signatureTypeListBox.Name = "signatureTypeListBox"
            Me.signatureTypeListBox.Size = New System.Drawing.Size(283, 140)
            Me.signatureTypeListBox.TabIndex = 1
            Me.radLabel1.Location = New System.Drawing.Point(13, 13)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(111, 18)
            Me.radLabel1.TabIndex = 0
            Me.radLabel1.Text = "Load document with:"
            Me.splitPanel2.Controls.Add(Me.radPanel1)
            Me.splitPanel2.Location = New System.Drawing.Point(324, 0)
            Me.splitPanel2.Name = "splitPanel2"
            Me.splitPanel2.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.splitPanel2.Size = New System.Drawing.Size(1687, 1157)
            Me.splitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.2467533F, 0.0F)
            Me.splitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(286, 0)
            Me.splitPanel2.TabIndex = 1
            Me.splitPanel2.TabStop = False
            Me.splitPanel2.Text = "splitPanel2"
            Me.radPanel1.Controls.Add(Me.tableLayoutPanel1)
            Me.radPanel1.Location = New System.Drawing.Point(50, 50)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New System.Drawing.Size(314, 401)
            Me.radPanel1.TabIndex = 1
            Me.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
            Me.tableLayoutPanel1.ColumnCount = 2
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207.0F))
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel2, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel3, 0, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel4, 0, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel5, 0, 3)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel6, 0, 4)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel7, 0, 5)
            Me.tableLayoutPanel1.Controls.Add(Me.statusImage, 1, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.textBlockIsDocumentModified, 1, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.textBlockIsCertificateValid, 1, 3)
            Me.tableLayoutPanel1.Controls.Add(Me.textBlockSignerInformation, 1, 4)
            Me.tableLayoutPanel1.Controls.Add(Me.textBlockHashAlgorithm, 1, 5)
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 6
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.07767F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.92233F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 199.0F))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(314, 401)
            Me.tableLayoutPanel1.TabIndex = 0
            Me.tableLayoutPanel1.SetColumnSpan(Me.radLabel2, 2)
            Me.radLabel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel2.Font = New System.Drawing.Font("Segoe UI", 24.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.radLabel2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((192)))))), (CInt(((CByte((0)))))))
            Me.radLabel2.Location = New System.Drawing.Point(3, 3)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(424, 74)
            Me.radLabel2.TabIndex = 0
            Me.radLabel2.Text = "Validate Documents"
            Me.radLabel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radLabel3.Font = New System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.radLabel3.Location = New System.Drawing.Point(3, 83)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(217, 38)
            Me.radLabel3.TabIndex = 1
            Me.radLabel3.Text = "Signature Status:"
            Me.radLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.radLabel4.Location = New System.Drawing.Point(3, 127)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(149, 19)
            Me.radLabel4.TabIndex = 2
            Me.radLabel4.Text = "Is document modified:"
            Me.radLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.radLabel5.Location = New System.Drawing.Point(3, 152)
            Me.radLabel5.Name = "radLabel5"
            Me.radLabel5.Size = New System.Drawing.Size(121, 20)
            Me.radLabel5.TabIndex = 3
            Me.radLabel5.Text = "Is certificate valid:"
            Me.radLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.radLabel6.Location = New System.Drawing.Point(3, 178)
            Me.radLabel6.Name = "radLabel6"
            Me.radLabel6.Size = New System.Drawing.Size(130, 20)
            Me.radLabel6.TabIndex = 4
            Me.radLabel6.Text = "Signer information:"
            Me.radLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.radLabel7.Location = New System.Drawing.Point(3, 204)
            Me.radLabel7.Name = "radLabel7"
            Me.radLabel7.Size = New System.Drawing.Size(108, 21)
            Me.radLabel7.TabIndex = 5
            Me.radLabel7.Text = "Hash algorithm:"
            Me.statusImage.Dock = System.Windows.Forms.DockStyle.Fill
            Me.statusImage.Location = New System.Drawing.Point(226, 83)
            Me.statusImage.Name = "statusImage"
            Me.statusImage.Size = New System.Drawing.Size(201, 38)
            Me.statusImage.TabIndex = 6
            Me.statusImage.Text = "radLabel8"
            Me.textBlockIsDocumentModified.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.textBlockIsDocumentModified.Location = New System.Drawing.Point(226, 127)
            Me.textBlockIsDocumentModified.Name = "textBlockIsDocumentModified"
            Me.textBlockIsDocumentModified.Size = New System.Drawing.Size(65, 19)
            Me.textBlockIsDocumentModified.TabIndex = 7
            Me.textBlockIsDocumentModified.Text = "radLabel9"
            Me.textBlockIsCertificateValid.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.textBlockIsCertificateValid.Location = New System.Drawing.Point(226, 152)
            Me.textBlockIsCertificateValid.Name = "textBlockIsCertificateValid"
            Me.textBlockIsCertificateValid.Size = New System.Drawing.Size(72, 20)
            Me.textBlockIsCertificateValid.TabIndex = 8
            Me.textBlockIsCertificateValid.Text = "radLabel10"
            Me.textBlockSignerInformation.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.textBlockSignerInformation.Location = New System.Drawing.Point(226, 178)
            Me.textBlockSignerInformation.Name = "textBlockSignerInformation"
            Me.textBlockSignerInformation.Size = New System.Drawing.Size(72, 20)
            Me.textBlockSignerInformation.TabIndex = 9
            Me.textBlockSignerInformation.Text = "radLabel11"
            Me.textBlockHashAlgorithm.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.textBlockHashAlgorithm.Location = New System.Drawing.Point(226, 204)
            Me.textBlockHashAlgorithm.Name = "textBlockHashAlgorithm"
            Me.textBlockHashAlgorithm.Size = New System.Drawing.Size(72, 21)
            Me.textBlockHashAlgorithm.TabIndex = 10
            Me.textBlockHashAlgorithm.Text = "radLabel12"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radSplitContainer1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2011, 1157)
            Me.Controls.SetChildIndex(Me.radSplitContainer1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radSplitContainer1.ResumeLayout(False)
            CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitPanel1.ResumeLayout(False)
            Me.splitPanel1.PerformLayout()
            CType(Me.openYourDocumentButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.signatureTypeListBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitPanel2.ResumeLayout(False)
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.PerformLayout()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.statusImage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textBlockIsDocumentModified, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textBlockIsCertificateValid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textBlockSignerInformation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textBlockHashAlgorithm, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
        Private splitPanel1 As Telerik.WinControls.UI.SplitPanel
        Private openYourDocumentButton As Telerik.WinControls.UI.RadButton
        Private signatureTypeListBox As Telerik.WinControls.UI.RadListControl
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private splitPanel2 As Telerik.WinControls.UI.SplitPanel
        Private tableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private radLabel5 As Telerik.WinControls.UI.RadLabel
        Private radLabel6 As Telerik.WinControls.UI.RadLabel
        Private radLabel7 As Telerik.WinControls.UI.RadLabel
        Private statusImage As Telerik.WinControls.UI.RadLabel
        Private textBlockIsDocumentModified As Telerik.WinControls.UI.RadLabel
        Private textBlockIsCertificateValid As Telerik.WinControls.UI.RadLabel
        Private textBlockSignerInformation As Telerik.WinControls.UI.RadLabel
        Private textBlockHashAlgorithm As Telerik.WinControls.UI.RadLabel
        Private radPanel1 As Telerik.WinControls.UI.RadPanel
    End Class
End Namespace
