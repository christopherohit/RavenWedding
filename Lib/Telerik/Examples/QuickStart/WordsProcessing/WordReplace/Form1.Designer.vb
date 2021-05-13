Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.WordsProcessing.WordReplace
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
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.openSampleDoc = New Telerik.WinControls.UI.RadButton()
            Me.loadcustomDoc = New Telerik.WinControls.UI.RadButton()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.docName = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.selectOption = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
            Me.findWhat = New Telerik.WinControls.UI.RadTextBox()
            Me.replaceWith = New Telerik.WinControls.UI.RadTextBox()
            Me.matchCase = New Telerik.WinControls.UI.RadCheckBox()
            Me.matchWholeWord = New Telerik.WinControls.UI.RadCheckBox()
            Me.useRegex = New Telerik.WinControls.UI.RadCheckBox()
            Me.replaceAndSave = New Telerik.WinControls.UI.RadButton()
            Me.doubleBufferedTableLayoutPanel2 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.openSampleDoc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.loadcustomDoc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.docName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.selectOption, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.findWhat, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.replaceWith, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.matchCase, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.matchWholeWord, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.useRegex, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.replaceAndSave, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.doubleBufferedTableLayoutPanel2.SuspendLayout()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(832, 13)
            Me.pictureBox1.Image = (CType((resources.GetObject("pictureBox1.Image")), System.Drawing.Image))
            Me.pictureBox1.Location = New System.Drawing.Point(20, 20)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(570, 250)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            Me.openSampleDoc.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.openSampleDoc.Location = New System.Drawing.Point(178, 12)
            Me.openSampleDoc.Name = "openSampleDoc"
            Me.openSampleDoc.Size = New System.Drawing.Size(213, 24)
            Me.openSampleDoc.TabIndex = 1
            Me.openSampleDoc.Text = "Load Sample Document"
            AddHandler Me.openSampleDoc.Click, New System.EventHandler(AddressOf Me.LoadSampleDoc_Click)
            Me.loadcustomDoc.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.loadcustomDoc.Location = New System.Drawing.Point(178, 86)
            Me.loadcustomDoc.Name = "loadcustomDoc"
            Me.loadcustomDoc.Size = New System.Drawing.Size(213, 24)
            Me.loadcustomDoc.TabIndex = 2
            Me.loadcustomDoc.Text = "Load Custom Document"
            AddHandler Me.loadcustomDoc.Click, New System.EventHandler(AddressOf Me.LoadCustomDoc_Click)
            Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.radLabel1.Location = New System.Drawing.Point(266, 52)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(37, 18)
            Me.radLabel1.TabIndex = 3
            Me.radLabel1.Text = "- OR -"
            Me.docName.Location = New System.Drawing.Point(70, 417)
            Me.docName.Name = "docName"
            Me.docName.Size = New System.Drawing.Size(55, 18)
            Me.docName.TabIndex = 5
            Me.docName.Text = "radLabel2"
            Me.radLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.radLabel3.Location = New System.Drawing.Point(20, 417)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(34, 18)
            Me.radLabel3.TabIndex = 6
            Me.radLabel3.Text = "FILE: "
            Me.radLabel4.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles))
            Me.radLabel4.Location = New System.Drawing.Point(3, 24)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(48, 18)
            Me.radLabel4.TabIndex = 7
            Me.radLabel4.Text = "Method:"
            Me.selectOption.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.selectOption.DropDownAnimationEnabled = False
            Me.selectOption.Location = New System.Drawing.Point(3, 48)
            Me.selectOption.Name = "selectOption"
            Me.selectOption.Size = New System.Drawing.Size(184, 20)
            Me.selectOption.TabIndex = 8
            Me.selectOption.Text = "radDropDownList1"
            AddHandler Me.selectOption.SelectedIndexChanged, New Telerik.WinControls.UI.Data.PositionChangedEventHandler(AddressOf Me.SelectOption_SelectedIndexChanged)
            Me.radLabel5.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles))
            Me.radLabel5.Location = New System.Drawing.Point(193, 24)
            Me.radLabel5.Name = "radLabel5"
            Me.radLabel5.Size = New System.Drawing.Size(57, 18)
            Me.radLabel5.TabIndex = 9
            Me.radLabel5.Text = "Find what:"
            Me.radLabel6.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles))
            Me.radLabel6.Location = New System.Drawing.Point(383, 24)
            Me.radLabel6.Name = "radLabel6"
            Me.radLabel6.Size = New System.Drawing.Size(72, 18)
            Me.radLabel6.TabIndex = 10
            Me.radLabel6.Text = "Replace with:"
            Me.findWhat.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.findWhat.Location = New System.Drawing.Point(193, 48)
            Me.findWhat.Name = "findWhat"
            Me.findWhat.Size = New System.Drawing.Size(184, 20)
            Me.findWhat.TabIndex = 11
            Me.replaceWith.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.replaceWith.Location = New System.Drawing.Point(383, 48)
            Me.replaceWith.Name = "replaceWith"
            Me.replaceWith.Size = New System.Drawing.Size(184, 20)
            Me.replaceWith.TabIndex = 12
            Me.matchCase.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.matchCase.Location = New System.Drawing.Point(3, 103)
            Me.matchCase.Name = "matchCase"
            Me.matchCase.Size = New System.Drawing.Size(78, 18)
            Me.matchCase.TabIndex = 13
            Me.matchCase.Text = "Match Case"
            Me.matchWholeWord.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.matchWholeWord.Location = New System.Drawing.Point(193, 103)
            Me.matchWholeWord.Name = "matchWholeWord"
            Me.matchWholeWord.Size = New System.Drawing.Size(118, 18)
            Me.matchWholeWord.TabIndex = 14
            Me.matchWholeWord.Text = "Match Whole Word"
            Me.useRegex.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.useRegex.Location = New System.Drawing.Point(383, 103)
            Me.useRegex.Name = "useRegex"
            Me.useRegex.Size = New System.Drawing.Size(136, 18)
            Me.useRegex.TabIndex = 15
            Me.useRegex.Text = "Use Regular Expression"
            Me.replaceAndSave.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.doubleBufferedTableLayoutPanel2.SetColumnSpan(Me.replaceAndSave, 3)
            Me.replaceAndSave.Location = New System.Drawing.Point(6, 141)
            Me.replaceAndSave.Margin = New System.Windows.Forms.Padding(6)
            Me.replaceAndSave.Name = "replaceAndSave"
            Me.replaceAndSave.Size = New System.Drawing.Size(558, 33)
            Me.replaceAndSave.TabIndex = 16
            Me.replaceAndSave.Text = "Replace and Save"
            AddHandler Me.replaceAndSave.Click, New System.EventHandler(AddressOf Me.ReplaceAndSave_Click)
            Me.doubleBufferedTableLayoutPanel2.ColumnCount = 3
            Me.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
            Me.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
            Me.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radLabel4, 0, 0)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radLabel5, 1, 0)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.replaceAndSave, 0, 3)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radLabel6, 2, 0)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.useRegex, 2, 2)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.selectOption, 0, 1)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.matchWholeWord, 1, 2)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.findWhat, 1, 1)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.matchCase, 0, 2)
            Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.replaceWith, 2, 1)
            Me.doubleBufferedTableLayoutPanel2.Location = New System.Drawing.Point(20, 452)
            Me.doubleBufferedTableLayoutPanel2.Name = "doubleBufferedTableLayoutPanel2"
            Me.doubleBufferedTableLayoutPanel2.RowCount = 4
            Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F))
            Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F))
            Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F))
            Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F))
            Me.doubleBufferedTableLayoutPanel2.Size = New System.Drawing.Size(570, 180)
            Me.doubleBufferedTableLayoutPanel2.TabIndex = 17
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 1
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.openSampleDoc, 0, 0)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.loadcustomDoc, 0, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 1)
            Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(20, 275)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 3
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0F))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0F))
            Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(570, 124)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 18
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.Controls.Add(Me.doubleBufferedTableLayoutPanel2)
            Me.Controls.Add(Me.radLabel3)
            Me.Controls.Add(Me.docName)
            Me.Controls.Add(Me.pictureBox1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2011, 1157)
            Me.Controls.SetChildIndex(Me.pictureBox1, 0)
            Me.Controls.SetChildIndex(Me.docName, 0)
            Me.Controls.SetChildIndex(Me.radLabel3, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.doubleBufferedTableLayoutPanel2, 0)
            Me.Controls.SetChildIndex(Me.doubleBufferedTableLayoutPanel1, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.openSampleDoc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.loadcustomDoc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.docName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.selectOption, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.findWhat, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.replaceWith, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.matchCase, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.matchWholeWord, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.useRegex, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.replaceAndSave, System.ComponentModel.ISupportInitialize).EndInit()
            Me.doubleBufferedTableLayoutPanel2.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel2.PerformLayout()
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private openSampleDoc As Telerik.WinControls.UI.RadButton
        Private loadcustomDoc As Telerik.WinControls.UI.RadButton
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private docName As Telerik.WinControls.UI.RadLabel
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private selectOption As Telerik.WinControls.UI.RadDropDownList
        Private radLabel5 As Telerik.WinControls.UI.RadLabel
        Private radLabel6 As Telerik.WinControls.UI.RadLabel
        Private findWhat As Telerik.WinControls.UI.RadTextBox
        Private replaceWith As Telerik.WinControls.UI.RadTextBox
        Private matchCase As Telerik.WinControls.UI.RadCheckBox
        Private matchWholeWord As Telerik.WinControls.UI.RadCheckBox
        Private useRegex As Telerik.WinControls.UI.RadCheckBox
        Private replaceAndSave As Telerik.WinControls.UI.RadButton
        Private doubleBufferedTableLayoutPanel2 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
    End Class
End Namespace
