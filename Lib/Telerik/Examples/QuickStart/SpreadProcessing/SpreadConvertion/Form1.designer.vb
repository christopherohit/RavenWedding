Namespace Telerik.Examples.WinControls.SpreadProcessing.SpreadConvertion
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim radListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.label1 = New Telerik.WinControls.UI.RadLabel()
            Me.pictureBox2 = New System.Windows.Forms.PictureBox()
            Me.loadCustomDocumentButton = New Telerik.WinControls.UI.RadButton()
            Me.loadSampleDocumentButton = New Telerik.WinControls.UI.RadButton()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.fileNameLabel = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.fileExtensionsDropDownList = New Telerik.WinControls.UI.RadDropDownList()
            Me.saveButton = New Telerik.WinControls.UI.RadButton()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.label1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.loadCustomDocumentButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.loadSampleDocumentButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.fileNameLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.fileExtensionsDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.saveButton, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pictureBox1.Image = (CType((resources.GetObject("pictureBox1.Image")), System.Drawing.Image))
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.Location = New System.Drawing.Point(20, 20)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(262, 200)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            Me.label1.Location = New System.Drawing.Point(289, 109)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(40, 18)
            Me.label1.TabIndex = 1
            Me.label1.Text = "- OR - "
            Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pictureBox2.Image = (CType((resources.GetObject("pictureBox2.Image")), System.Drawing.Image))
            Me.pictureBox2.Location = New System.Drawing.Point(333, 20)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.Size = New System.Drawing.Size(262, 200)
            Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox2.TabIndex = 2
            Me.pictureBox2.TabStop = False
            Me.loadCustomDocumentButton.Location = New System.Drawing.Point(20, 236)
            Me.loadCustomDocumentButton.Name = "loadCustomDocumentButton"
            Me.loadCustomDocumentButton.Size = New System.Drawing.Size(262, 24)
            Me.loadCustomDocumentButton.TabIndex = 3
            Me.loadCustomDocumentButton.Text = "Load Custom Document"
            AddHandler Me.loadCustomDocumentButton.Click, New System.EventHandler(AddressOf Me.loadCustomDocumentButton_Click)
            Me.loadSampleDocumentButton.Location = New System.Drawing.Point(333, 236)
            Me.loadSampleDocumentButton.Name = "loadSampleDocumentButton"
            Me.loadSampleDocumentButton.Size = New System.Drawing.Size(262, 24)
            Me.loadSampleDocumentButton.TabIndex = 4
            Me.loadSampleDocumentButton.Text = "Load Sample Document"
            AddHandler Me.loadSampleDocumentButton.Click, New System.EventHandler(AddressOf Me.loadSampleDocumentButton_Click)
            Me.radLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold)
            Me.radLabel1.Location = New System.Drawing.Point(20, 287)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(31, 18)
            Me.radLabel1.TabIndex = 5
            Me.radLabel1.Text = "File: "
            Me.fileNameLabel.Location = New System.Drawing.Point(57, 287)
            Me.fileNameLabel.Name = "fileNameLabel"
            Me.fileNameLabel.Size = New System.Drawing.Size(2, 2)
            Me.fileNameLabel.TabIndex = 6
            Me.radLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold)
            Me.radLabel2.Location = New System.Drawing.Point(20, 333)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(64, 18)
            Me.radLabel2.TabIndex = 7
            Me.radLabel2.Text = "Extension: "
            Me.fileExtensionsDropDownList.DropDownAnimationEnabled = False
            Me.fileExtensionsDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            radListDataItem1.Text = "Xlsx"
            radListDataItem2.Text = "Csv"
            radListDataItem3.Text = "Txt"
            Me.fileExtensionsDropDownList.Items.Add(radListDataItem1)
            Me.fileExtensionsDropDownList.Items.Add(radListDataItem2)
            Me.fileExtensionsDropDownList.Items.Add(radListDataItem3)
            Me.fileExtensionsDropDownList.Location = New System.Drawing.Point(90, 330)
            Me.fileExtensionsDropDownList.Name = "fileExtensionsDropDownList"
            Me.fileExtensionsDropDownList.Size = New System.Drawing.Size(192, 20)
            Me.fileExtensionsDropDownList.TabIndex = 8
            Me.saveButton.Enabled = False
            Me.saveButton.Location = New System.Drawing.Point(20, 375)
            Me.saveButton.Name = "saveButton"
            Me.saveButton.Size = New System.Drawing.Size(575, 24)
            Me.saveButton.TabIndex = 9
            Me.saveButton.Text = "Save"
            AddHandler Me.saveButton.Click, New System.EventHandler(AddressOf Me.saveButton_Click)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(829, 560)
            Me.Controls.Add(Me.saveButton)
            Me.Controls.Add(Me.fileExtensionsDropDownList)
            Me.Controls.Add(Me.radLabel2)
            Me.Controls.Add(Me.fileNameLabel)
            Me.Controls.Add(Me.radLabel1)
            Me.Controls.Add(Me.loadSampleDocumentButton)
            Me.Controls.Add(Me.loadCustomDocumentButton)
            Me.Controls.Add(Me.pictureBox2)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.pictureBox1)
            Me.Name = "Form1"
            Me.Text = "Convert Documents"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.label1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.loadCustomDocumentButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.loadSampleDocumentButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.fileNameLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.fileExtensionsDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.saveButton, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private label1 As Telerik.WinControls.UI.RadLabel
        Private pictureBox2 As System.Windows.Forms.PictureBox
        Private loadCustomDocumentButton As Telerik.WinControls.UI.RadButton
        Private loadSampleDocumentButton As Telerik.WinControls.UI.RadButton
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private fileNameLabel As Telerik.WinControls.UI.RadLabel
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private fileExtensionsDropDownList As Telerik.WinControls.UI.RadDropDownList
        Private saveButton As Telerik.WinControls.UI.RadButton
    End Class
End Namespace
