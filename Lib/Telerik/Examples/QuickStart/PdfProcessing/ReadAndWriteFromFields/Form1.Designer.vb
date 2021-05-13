Namespace Telerik.Examples.WinControls.PdfProcessing.ReadAndWriteFromFields
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim listViewDataItem5 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Choice 1")
            Dim listViewDataItem6 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Choice 2")
            Dim listViewDataItem7 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Choice 3")
            Dim listViewDataItem8 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Choice 4")
            Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.splitPanel1 = New Telerik.WinControls.UI.SplitPanel()
            Me.tableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.checkBox3 = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBox2 = New Telerik.WinControls.UI.RadCheckBox()
            Me.checkBox1 = New Telerik.WinControls.UI.RadCheckBox()
            Me.radRadioButton3 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
            Me.clearAllButton = New Telerik.WinControls.UI.RadButton()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radListView1 = New Telerik.WinControls.UI.RadListView()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.addNewButton = New Telerik.WinControls.UI.RadButton()
            Me.saveButton = New Telerik.WinControls.UI.RadButton()
            Me.loadTemplateButton = New Telerik.WinControls.UI.RadButton()
            Me.splitPanel2 = New Telerik.WinControls.UI.SplitPanel()
            Me.radScrollablePanel1 = New Telerik.WinControls.UI.RadScrollablePanel()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radSplitContainer1.SuspendLayout()
            CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitPanel1.SuspendLayout()
            Me.tableLayoutPanel1.SuspendLayout()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.SuspendLayout()
            CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.clearAllButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radListView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.addNewButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.saveButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.loadTemplateButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitPanel2.SuspendLayout()
            CType(Me.radScrollablePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radScrollablePanel1.PanelContainer.SuspendLayout()
            Me.radScrollablePanel1.SuspendLayout()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radSplitContainer1.Controls.Add(Me.splitPanel1)
            Me.radSplitContainer1.Controls.Add(Me.splitPanel2)
            Me.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSplitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.radSplitContainer1.Name = "radSplitContainer1"
            Me.radSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.radSplitContainer1.Size = New System.Drawing.Size(2011, 1157)
            Me.radSplitContainer1.TabIndex = 0
            Me.radSplitContainer1.TabStop = False
            Me.splitPanel1.Controls.Add(Me.tableLayoutPanel1)
            Me.splitPanel1.Controls.Add(Me.saveButton)
            Me.splitPanel1.Controls.Add(Me.loadTemplateButton)
            Me.splitPanel1.Location = New System.Drawing.Point(0, 0)
            Me.splitPanel1.Name = "splitPanel1"
            Me.splitPanel1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.splitPanel1.Size = New System.Drawing.Size(300, 1157)
            Me.splitPanel1.SizeInfo.AbsoluteSize = New System.Drawing.Size(300, 200)
            Me.splitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.2528548F, 0.0F)
            Me.splitPanel1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Absolute
            Me.splitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-42, 0)
            Me.splitPanel1.TabIndex = 0
            Me.splitPanel1.TabStop = False
            Me.splitPanel1.Text = "splitPanel1"
            Me.tableLayoutPanel1.ColumnCount = 2
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.radTextBox1, 0, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel2, 0, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.radPanel1, 0, 6)
            Me.tableLayoutPanel1.Controls.Add(Me.clearAllButton, 1, 4)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel4, 1, 5)
            Me.tableLayoutPanel1.Controls.Add(Me.radListView1, 0, 3)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabel3, 0, 5)
            Me.tableLayoutPanel1.Controls.Add(Me.addNewButton, 0, 4)
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(13, 4)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 7
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.186858F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.008214F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.776181F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.70226F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.26694F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.13347F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.36345F))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(245, 531)
            Me.tableLayoutPanel1.TabIndex = 11
            Me.radLabel1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles))
            Me.radLabel1.Location = New System.Drawing.Point(3, 16)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(54, 18)
            Me.radLabel1.TabIndex = 0
            Me.radLabel1.Text = "Text field:"
            Me.radTextBox1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.tableLayoutPanel1.SetColumnSpan(Me.radTextBox1, 2)
            Me.radTextBox1.Location = New System.Drawing.Point(3, 40)
            Me.radTextBox1.Name = "radTextBox1"
            Me.radTextBox1.Size = New System.Drawing.Size(239, 20)
            Me.radTextBox1.TabIndex = 4
            Me.radLabel2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles))
            Me.radLabel2.Location = New System.Drawing.Point(3, 92)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(67, 18)
            Me.radLabel2.TabIndex = 1
            Me.radLabel2.Text = "Choice field:"
            Me.tableLayoutPanel1.SetColumnSpan(Me.radPanel1, 2)
            Me.radPanel1.Controls.Add(Me.checkBox3)
            Me.radPanel1.Controls.Add(Me.checkBox2)
            Me.radPanel1.Controls.Add(Me.checkBox1)
            Me.radPanel1.Controls.Add(Me.radRadioButton3)
            Me.radPanel1.Controls.Add(Me.radRadioButton2)
            Me.radPanel1.Controls.Add(Me.radRadioButton1)
            Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanel1.Location = New System.Drawing.Point(3, 376)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New System.Drawing.Size(239, 152)
            Me.radPanel1.TabIndex = 6
            Me.checkBox3.Location = New System.Drawing.Point(135, 92)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(78, 18)
            Me.checkBox3.TabIndex = 5
            Me.checkBox3.Text = "CheckBox 3"
            Me.checkBox2.Location = New System.Drawing.Point(135, 57)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(78, 18)
            Me.checkBox2.TabIndex = 4
            Me.checkBox2.Text = "CheckBox 2"
            Me.checkBox1.Location = New System.Drawing.Point(135, 19)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(78, 18)
            Me.checkBox1.TabIndex = 3
            Me.checkBox1.Text = "CheckBox 1"
            Me.radRadioButton3.Location = New System.Drawing.Point(4, 92)
            Me.radRadioButton3.Name = "radRadioButton3"
            Me.radRadioButton3.Size = New System.Drawing.Size(64, 18)
            Me.radRadioButton3.TabIndex = 2
            Me.radRadioButton3.Text = "Option 3"
            Me.radRadioButton2.Location = New System.Drawing.Point(4, 58)
            Me.radRadioButton2.Name = "radRadioButton2"
            Me.radRadioButton2.Size = New System.Drawing.Size(64, 18)
            Me.radRadioButton2.TabIndex = 1
            Me.radRadioButton2.Text = "Option 2"
            Me.radRadioButton1.Location = New System.Drawing.Point(4, 20)
            Me.radRadioButton1.Name = "radRadioButton1"
            Me.radRadioButton1.Size = New System.Drawing.Size(64, 18)
            Me.radRadioButton1.TabIndex = 0
            Me.radRadioButton1.Text = "Option 1"
            Me.clearAllButton.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.clearAllButton.Location = New System.Drawing.Point(125, 308)
            Me.clearAllButton.Name = "clearAllButton"
            Me.clearAllButton.Size = New System.Drawing.Size(117, 24)
            Me.clearAllButton.TabIndex = 8
            Me.clearAllButton.Text = "Clear All"
            AddHandler Me.clearAllButton.Click, New System.EventHandler(AddressOf Me.ClearAllButton_Click)
            Me.radLabel4.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles))
            Me.radLabel4.Location = New System.Drawing.Point(125, 352)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(87, 18)
            Me.radLabel4.TabIndex = 3
            Me.radLabel4.Text = "Checkbox fields:"
            Me.radListView1.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.tableLayoutPanel1.SetColumnSpan(Me.radListView1, 2)
            listViewDataItem5.Text = "Choice 1"
            listViewDataItem6.Text = "Choice 2"
            listViewDataItem7.Text = "Choice 3"
            listViewDataItem8.Text = "Choice 4"
            Me.radListView1.Items.AddRange(New Telerik.WinControls.UI.ListViewDataItem() {listViewDataItem5, listViewDataItem6, listViewDataItem7, listViewDataItem8})
            Me.radListView1.Location = New System.Drawing.Point(3, 116)
            Me.radListView1.Name = "radListView1"
            Me.radListView1.Size = New System.Drawing.Size(239, 175)
            Me.radListView1.TabIndex = 5
            Me.radLabel3.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles))
            Me.radLabel3.Location = New System.Drawing.Point(3, 352)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(62, 18)
            Me.radLabel3.TabIndex = 2
            Me.radLabel3.Text = "Radio field:"
            Me.addNewButton.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.addNewButton.Location = New System.Drawing.Point(3, 308)
            Me.addNewButton.Name = "addNewButton"
            Me.addNewButton.Size = New System.Drawing.Size(116, 24)
            Me.addNewButton.TabIndex = 7
            Me.addNewButton.Text = "Add New"
            AddHandler Me.addNewButton.Click, New System.EventHandler(AddressOf Me.AddNewButton_Click)
            Me.saveButton.Location = New System.Drawing.Point(13, 592)
            Me.saveButton.Name = "saveButton"
            Me.saveButton.Size = New System.Drawing.Size(245, 24)
            Me.saveButton.TabIndex = 10
            Me.saveButton.Text = "Save Result PDF"
            AddHandler Me.saveButton.Click, New System.EventHandler(AddressOf Me.SaveButton_Click)
            Me.loadTemplateButton.Location = New System.Drawing.Point(13, 550)
            Me.loadTemplateButton.Name = "loadTemplateButton"
            Me.loadTemplateButton.Size = New System.Drawing.Size(245, 24)
            Me.loadTemplateButton.TabIndex = 9
            Me.loadTemplateButton.Text = "Load Template PDF"
            AddHandler Me.loadTemplateButton.Click, New System.EventHandler(AddressOf Me.LoadTemplateButton_Click)
            Me.splitPanel2.Controls.Add(Me.radScrollablePanel1)
            Me.splitPanel2.Location = New System.Drawing.Point(304, 0)
            Me.splitPanel2.Name = "splitPanel2"
            Me.splitPanel2.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.splitPanel2.Size = New System.Drawing.Size(1707, 1157)
            Me.splitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.2528548F, 0.0F)
            Me.splitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(42, 0)
            Me.splitPanel2.TabIndex = 1
            Me.splitPanel2.TabStop = False
            Me.splitPanel2.Text = "splitPanel2"
            Me.radScrollablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radScrollablePanel1.Location = New System.Drawing.Point(0, 0)
            Me.radScrollablePanel1.Name = "radScrollablePanel1"
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radLabel5)
            Me.radScrollablePanel1.PanelContainer.Size = New System.Drawing.Size(1705, 1155)
            Me.radScrollablePanel1.Size = New System.Drawing.Size(1707, 1157)
            Me.radScrollablePanel1.TabIndex = 0
            Me.radLabel5.Location = New System.Drawing.Point(20, 20)
            Me.radLabel5.Name = "radLabel5"
            Me.radLabel5.Size = New System.Drawing.Size(2, 2)
            Me.radLabel5.TabIndex = 0
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
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.PerformLayout()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            Me.radPanel1.PerformLayout()
            CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.clearAllButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radListView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.addNewButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.saveButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.loadTemplateButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitPanel2.ResumeLayout(False)
            Me.radScrollablePanel1.PanelContainer.ResumeLayout(False)
            Me.radScrollablePanel1.PanelContainer.PerformLayout()
            CType(Me.radScrollablePanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radScrollablePanel1.ResumeLayout(False)
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
        Private splitPanel1 As Telerik.WinControls.UI.SplitPanel
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private splitPanel2 As Telerik.WinControls.UI.SplitPanel
        Private clearAllButton As Telerik.WinControls.UI.RadButton
        Private addNewButton As Telerik.WinControls.UI.RadButton
        Private radPanel1 As Telerik.WinControls.UI.RadPanel
        Private radListView1 As Telerik.WinControls.UI.RadListView
        Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
        Private saveButton As Telerik.WinControls.UI.RadButton
        Private loadTemplateButton As Telerik.WinControls.UI.RadButton
        Private checkBox3 As Telerik.WinControls.UI.RadCheckBox
        Private checkBox2 As Telerik.WinControls.UI.RadCheckBox
        Private checkBox1 As Telerik.WinControls.UI.RadCheckBox
        Private radRadioButton3 As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButton1 As Telerik.WinControls.UI.RadRadioButton
        Private tableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private radScrollablePanel1 As Telerik.WinControls.UI.RadScrollablePanel
        Private radLabel5 As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace
