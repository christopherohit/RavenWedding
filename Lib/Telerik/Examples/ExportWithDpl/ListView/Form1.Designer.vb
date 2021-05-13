Imports Microsoft.VisualBasic
Imports System
Namespace ExportWithDpl.ListView
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim ListViewDetailColumn1 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "File Name")
            Dim ListViewDetailColumn2 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Total Size")
            Dim ListViewDetailColumn3 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Type")
            Dim ListViewDetailColumn4 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Free Space")
            Dim ListViewDataItemGroup1 As Telerik.WinControls.UI.ListViewDataItemGroup = New Telerik.WinControls.UI.ListViewDataItemGroup("Files Stored on This Computer")
            Dim ListViewDataItemGroup2 As Telerik.WinControls.UI.ListViewDataItemGroup = New Telerik.WinControls.UI.ListViewDataItemGroup("Hard Disk Drives")
            Dim ListViewDataItemGroup3 As Telerik.WinControls.UI.ListViewDataItemGroup = New Telerik.WinControls.UI.ListViewDataItemGroup("Devices with Removable Storage")
            Dim ListViewDataItem1 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Shared Documents", New String() {"Shared Documents", "", "File Folder"})
            Dim ListViewDataItem2 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Administrator's Documents", New String() {"Administrator's Documents", "", "File Folder"})
            Dim ListViewDataItem3 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("3.5 Floppy (A:)", New String() {"3.5 Floppy (A:)", "1.44 MB", "Floppy Drive", "203 KB"})
            Dim ListViewDataItem4 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Local Disk (C:)", New String() {"Local Disk (C:)", "160.4 GB", "Local Disk", "31.02 GB"})
            Dim ListViewDataItem5 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Local Disk (D:)", New String() {"Local Disk (D:)", "136.2 GB", "Local Disk", "57.52 GB"})
            Dim ListViewDataItem6 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Local Disk (E:)", New String() {"Local Disk (E:)", "40.00 GB", "Local Disk", "13.37 GB"})
            Dim ListViewDataItem7 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Local Disk (F:)", New String() {"Local Disk (F:)", "0.99 TB", "Local Disk", "357.37 GB"})
            Dim ListViewDataItem8 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("DVD/CD-RW Drive (G:)", New String() {"DVD/CD-RW (G:)", "4.7 GB", "DVD Drive", "0 KB"})
            Dim ListViewDataItem9 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("CD-RW Drive (H:)", New String() {"CD-RW (G:)", "", "CD Drive"})
            Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Me.radListView1 = New Telerik.WinControls.UI.RadListView()
            Me.settingsPanel = New Telerik.WinControls.UI.RadPanel()
            Me.listViewShowGroupsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.groupChildItemsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.exportImagesCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.exportVisualSettingsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.customizeVisualSettingsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
            Me.collapsedOptionDoNotExportRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.collapsedOptionExportAsHiddenRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.collapsedOptionExportAlwaysRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.exportFormatTxtRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.exportFormatCsvRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.exportFormatPdfRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.exportFormatXlsxRadioButton = New Telerik.WinControls.UI.RadRadioButton()
            Me.exportButton = New Telerik.WinControls.UI.RadButton()
            Me.listViewTypeDropDownList = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            CType(Me.radListView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.listViewShowGroupsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupChildItemsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportImagesCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportVisualSettingsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.customizeVisualSettingsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox2.SuspendLayout()
            CType(Me.collapsedOptionDoNotExportRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.collapsedOptionExportAsHiddenRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.collapsedOptionExportAlwaysRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType(Me.exportFormatTxtRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportFormatCsvRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportFormatPdfRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportFormatXlsxRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.listViewTypeDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radListView1
            '
            Me.radListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            ListViewDetailColumn1.HeaderText = "File Name"
            ListViewDetailColumn1.Width = 180.0!
            ListViewDetailColumn2.HeaderText = "Total Size"
            ListViewDetailColumn2.Width = 150.0!
            ListViewDetailColumn3.HeaderText = "Type"
            ListViewDetailColumn3.Width = 180.0!
            ListViewDetailColumn4.HeaderText = "Free Space"
            ListViewDetailColumn4.Width = 150.0!
            Me.radListView1.Columns.AddRange(New Telerik.WinControls.UI.ListViewDetailColumn() {ListViewDetailColumn1, ListViewDetailColumn2, ListViewDetailColumn3, ListViewDetailColumn4})
            Me.radListView1.EnableCustomGrouping = True
            ListViewDataItemGroup1.Text = "Files Stored on This Computer"
            ListViewDataItemGroup2.Text = "Hard Disk Drives"
            ListViewDataItemGroup3.Text = "Devices with Removable Storage"
            Me.radListView1.Groups.AddRange(New Telerik.WinControls.UI.ListViewDataItemGroup() {ListViewDataItemGroup1, ListViewDataItemGroup2, ListViewDataItemGroup3})
            ListViewDataItem1.Group = ListViewDataItemGroup1
            ListViewDataItem1.Image = Global.My.Resources.Resources.folder_xp
            ListViewDataItem1.Text = "Shared Documents"
            ListViewDataItem2.Group = ListViewDataItemGroup1
            ListViewDataItem2.Image = Global.My.Resources.Resources.folder_xp
            ListViewDataItem2.Text = "Administrator's Documents"
            ListViewDataItem3.Group = ListViewDataItemGroup3
            ListViewDataItem3.Image = Global.My.Resources.Resources.floppy_drive
            ListViewDataItem3.Text = "3.5 Floppy (A:)"
            ListViewDataItem4.Group = ListViewDataItemGroup2
            ListViewDataItem4.Image = Global.My.Resources.Resources.hard_drive
            ListViewDataItem4.Text = "Local Disk (C:)"
            ListViewDataItem5.Group = ListViewDataItemGroup2
            ListViewDataItem5.Image = Global.My.Resources.Resources.hard_drive
            ListViewDataItem5.Text = "Local Disk (D:)"
            ListViewDataItem6.Group = ListViewDataItemGroup2
            ListViewDataItem6.Image = Global.My.Resources.Resources.hard_drive
            ListViewDataItem6.Text = "Local Disk (E:)"
            ListViewDataItem7.Group = ListViewDataItemGroup2
            ListViewDataItem7.Image = Global.My.Resources.Resources.hard_drive
            ListViewDataItem7.Text = "Local Disk (F:)"
            ListViewDataItem8.Group = ListViewDataItemGroup3
            ListViewDataItem8.Image = Global.My.Resources.Resources.cd_drive
            ListViewDataItem8.Text = "DVD/CD-RW Drive (G:)"
            ListViewDataItem9.Group = ListViewDataItemGroup3
            ListViewDataItem9.Image = Global.My.Resources.Resources.cd_drive
            ListViewDataItem9.Text = "CD-RW Drive (H:)"
            Me.radListView1.Items.AddRange(New Telerik.WinControls.UI.ListViewDataItem() {ListViewDataItem1, ListViewDataItem2, ListViewDataItem3, ListViewDataItem4, ListViewDataItem5, ListViewDataItem6, ListViewDataItem7, ListViewDataItem8, ListViewDataItem9})
            Me.radListView1.ItemSize = New System.Drawing.Size(200, 32)
            Me.radListView1.Location = New System.Drawing.Point(0, 0)
            Me.radListView1.Name = "radListView1"
            Me.radListView1.ShowGroups = True
            Me.radListView1.Size = New System.Drawing.Size(681, 470)
            Me.radListView1.TabIndex = 0
            Me.radListView1.Text = "radListView1"
            '
            'settingsPanel
            '
            Me.settingsPanel.Controls.Add(Me.listViewShowGroupsCheckBox)
            Me.settingsPanel.Controls.Add(Me.groupChildItemsCheckBox)
            Me.settingsPanel.Controls.Add(Me.exportImagesCheckBox)
            Me.settingsPanel.Controls.Add(Me.exportVisualSettingsCheckBox)
            Me.settingsPanel.Controls.Add(Me.customizeVisualSettingsCheckBox)
            Me.settingsPanel.Controls.Add(Me.radGroupBox2)
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.Controls.Add(Me.exportButton)
            Me.settingsPanel.Controls.Add(Me.listViewTypeDropDownList)
            Me.settingsPanel.Controls.Add(Me.radLabel1)
            Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.settingsPanel.Location = New System.Drawing.Point(681, 0)
            Me.settingsPanel.Name = "settingsPanel"
            Me.settingsPanel.Size = New System.Drawing.Size(211, 470)
            Me.settingsPanel.TabIndex = 1
            '
            'listViewShowGroupsCheckBox
            '
            Me.listViewShowGroupsCheckBox.Location = New System.Drawing.Point(6, 69)
            Me.listViewShowGroupsCheckBox.Name = "listViewShowGroupsCheckBox"
            Me.listViewShowGroupsCheckBox.Size = New System.Drawing.Size(86, 18)
            Me.listViewShowGroupsCheckBox.TabIndex = 8
            Me.listViewShowGroupsCheckBox.Text = "Show groups"
            '
            'groupChildItemsCheckBox
            '
            Me.groupChildItemsCheckBox.Location = New System.Drawing.Point(6, 182)
            Me.groupChildItemsCheckBox.Name = "groupChildItemsCheckBox"
            Me.groupChildItemsCheckBox.Size = New System.Drawing.Size(149, 18)
            Me.groupChildItemsCheckBox.TabIndex = 7
            Me.groupChildItemsCheckBox.Text = "ExportChildItemsGrouped"
            '
            'exportImagesCheckBox
            '
            Me.exportImagesCheckBox.Location = New System.Drawing.Point(6, 158)
            Me.exportImagesCheckBox.Name = "exportImagesCheckBox"
            Me.exportImagesCheckBox.Size = New System.Drawing.Size(88, 18)
            Me.exportImagesCheckBox.TabIndex = 6
            Me.exportImagesCheckBox.Text = "ExportImages"
            '
            'exportVisualSettingsCheckBox
            '
            Me.exportVisualSettingsCheckBox.Location = New System.Drawing.Point(6, 134)
            Me.exportVisualSettingsCheckBox.Name = "exportVisualSettingsCheckBox"
            Me.exportVisualSettingsCheckBox.Size = New System.Drawing.Size(122, 18)
            Me.exportVisualSettingsCheckBox.TabIndex = 6
            Me.exportVisualSettingsCheckBox.Text = "ExportVisualSettings"
            '
            'customizeVisualSettingsCheckBox
            '
            Me.customizeVisualSettingsCheckBox.AutoSize = False
            Me.customizeVisualSettingsCheckBox.Location = New System.Drawing.Point(6, 93)
            Me.customizeVisualSettingsCheckBox.Name = "customizeVisualSettingsCheckBox"
            Me.customizeVisualSettingsCheckBox.Size = New System.Drawing.Size(193, 35)
            Me.customizeVisualSettingsCheckBox.TabIndex = 5
            Me.customizeVisualSettingsCheckBox.Text = "Customize visual settings when exporting"
            Me.customizeVisualSettingsCheckBox.TextWrap = True
            '
            'radGroupBox2
            '
            Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox2.Controls.Add(Me.collapsedOptionDoNotExportRadioButton)
            Me.radGroupBox2.Controls.Add(Me.collapsedOptionExportAsHiddenRadioButton)
            Me.radGroupBox2.Controls.Add(Me.collapsedOptionExportAlwaysRadioButton)
            Me.radGroupBox2.HeaderText = "Collapsed item option"
            Me.radGroupBox2.Location = New System.Drawing.Point(6, 290)
            Me.radGroupBox2.Name = "radGroupBox2"
            Me.radGroupBox2.Size = New System.Drawing.Size(193, 100)
            Me.radGroupBox2.TabIndex = 4
            Me.radGroupBox2.Text = "Collapsed item option"
            '
            'collapsedOptionDoNotExportRadioButton
            '
            Me.collapsedOptionDoNotExportRadioButton.Location = New System.Drawing.Point(6, 46)
            Me.collapsedOptionDoNotExportRadioButton.Name = "collapsedOptionDoNotExportRadioButton"
            Me.collapsedOptionDoNotExportRadioButton.Size = New System.Drawing.Size(86, 18)
            Me.collapsedOptionDoNotExportRadioButton.TabIndex = 1
            Me.collapsedOptionDoNotExportRadioButton.Text = "DoNotExport"
            '
            'collapsedOptionExportAsHiddenRadioButton
            '
            Me.collapsedOptionExportAsHiddenRadioButton.Location = New System.Drawing.Point(6, 70)
            Me.collapsedOptionExportAsHiddenRadioButton.Name = "collapsedOptionExportAsHiddenRadioButton"
            Me.collapsedOptionExportAsHiddenRadioButton.Size = New System.Drawing.Size(101, 18)
            Me.collapsedOptionExportAsHiddenRadioButton.TabIndex = 1
            Me.collapsedOptionExportAsHiddenRadioButton.Text = "ExportAsHidden"
            '
            'collapsedOptionExportAlwaysRadioButton
            '
            Me.collapsedOptionExportAlwaysRadioButton.Location = New System.Drawing.Point(6, 22)
            Me.collapsedOptionExportAlwaysRadioButton.Name = "collapsedOptionExportAlwaysRadioButton"
            Me.collapsedOptionExportAlwaysRadioButton.Size = New System.Drawing.Size(86, 18)
            Me.collapsedOptionExportAlwaysRadioButton.TabIndex = 0
            Me.collapsedOptionExportAlwaysRadioButton.Text = "ExportAlways"
            '
            'radGroupBox1
            '
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Controls.Add(Me.exportFormatTxtRadioButton)
            Me.radGroupBox1.Controls.Add(Me.exportFormatCsvRadioButton)
            Me.radGroupBox1.Controls.Add(Me.exportFormatPdfRadioButton)
            Me.radGroupBox1.Controls.Add(Me.exportFormatXlsxRadioButton)
            Me.radGroupBox1.HeaderText = "Export format"
            Me.radGroupBox1.Location = New System.Drawing.Point(6, 206)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New System.Drawing.Size(193, 77)
            Me.radGroupBox1.TabIndex = 3
            Me.radGroupBox1.Text = "Export format"
            '
            'exportFormatTxtRadioButton
            '
            Me.exportFormatTxtRadioButton.Location = New System.Drawing.Point(82, 46)
            Me.exportFormatTxtRadioButton.Name = "exportFormatTxtRadioButton"
            Me.exportFormatTxtRadioButton.Size = New System.Drawing.Size(39, 18)
            Me.exportFormatTxtRadioButton.TabIndex = 1
            Me.exportFormatTxtRadioButton.Text = "TXT"
            '
            'exportFormatCsvRadioButton
            '
            Me.exportFormatCsvRadioButton.Location = New System.Drawing.Point(6, 46)
            Me.exportFormatCsvRadioButton.Name = "exportFormatCsvRadioButton"
            Me.exportFormatCsvRadioButton.Size = New System.Drawing.Size(40, 18)
            Me.exportFormatCsvRadioButton.TabIndex = 1
            Me.exportFormatCsvRadioButton.Text = "CSV"
            '
            'exportFormatPdfRadioButton
            '
            Me.exportFormatPdfRadioButton.Location = New System.Drawing.Point(82, 22)
            Me.exportFormatPdfRadioButton.Name = "exportFormatPdfRadioButton"
            Me.exportFormatPdfRadioButton.Size = New System.Drawing.Size(40, 18)
            Me.exportFormatPdfRadioButton.TabIndex = 1
            Me.exportFormatPdfRadioButton.Text = "PDF"
            '
            'exportFormatXlsxRadioButton
            '
            Me.exportFormatXlsxRadioButton.Location = New System.Drawing.Point(6, 22)
            Me.exportFormatXlsxRadioButton.Name = "exportFormatXlsxRadioButton"
            Me.exportFormatXlsxRadioButton.Size = New System.Drawing.Size(45, 18)
            Me.exportFormatXlsxRadioButton.TabIndex = 0
            Me.exportFormatXlsxRadioButton.Text = "XLSX"
            '
            'exportButton
            '
            Me.exportButton.Location = New System.Drawing.Point(6, 12)
            Me.exportButton.Name = "exportButton"
            Me.exportButton.Size = New System.Drawing.Size(193, 24)
            Me.exportButton.TabIndex = 2
            Me.exportButton.Text = "Export"
            '
            'listViewTypeDropDownList
            '
            RadListDataItem1.Selected = True
            RadListDataItem1.Text = "List View"
            RadListDataItem2.Text = "Icon View"
            RadListDataItem3.Text = "Detail View"
            Me.listViewTypeDropDownList.Items.Add(RadListDataItem1)
            Me.listViewTypeDropDownList.Items.Add(RadListDataItem2)
            Me.listViewTypeDropDownList.Items.Add(RadListDataItem3)
            Me.listViewTypeDropDownList.Location = New System.Drawing.Point(89, 42)
            Me.listViewTypeDropDownList.Name = "listViewTypeDropDownList"
            Me.listViewTypeDropDownList.Size = New System.Drawing.Size(110, 20)
            Me.listViewTypeDropDownList.TabIndex = 0
            Me.listViewTypeDropDownList.Text = "List View"
            '
            'radLabel1
            '
            Me.radLabel1.Location = New System.Drawing.Point(4, 44)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(76, 18)
            Me.radLabel1.TabIndex = 1
            Me.radLabel1.Text = "ListViewType: "
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(892, 470)
            Me.Controls.Add(Me.settingsPanel)
            Me.Controls.Add(Me.radListView1)
            Me.Name = "Form1"
            '
            '
            '
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "Export with DPL"
            CType(Me.radListView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            CType(Me.listViewShowGroupsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupChildItemsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportImagesCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportVisualSettingsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.customizeVisualSettingsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox2.ResumeLayout(False)
            Me.radGroupBox2.PerformLayout()
            CType(Me.collapsedOptionDoNotExportRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.collapsedOptionExportAsHiddenRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.collapsedOptionExportAlwaysRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            CType(Me.exportFormatTxtRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportFormatCsvRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportFormatPdfRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportFormatXlsxRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.listViewTypeDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private radListView1 As Telerik.WinControls.UI.RadListView
		Private settingsPanel As Telerik.WinControls.UI.RadPanel
		Private listViewTypeDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents exportButton As Telerik.WinControls.UI.RadButton
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private exportFormatTxtRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private exportFormatCsvRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private exportFormatPdfRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private exportFormatXlsxRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private groupChildItemsCheckBox As Telerik.WinControls.UI.RadCheckBox
		Private exportImagesCheckBox As Telerik.WinControls.UI.RadCheckBox
		Private exportVisualSettingsCheckBox As Telerik.WinControls.UI.RadCheckBox
		Private customizeVisualSettingsCheckBox As Telerik.WinControls.UI.RadCheckBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private collapsedOptionDoNotExportRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private collapsedOptionExportAsHiddenRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private collapsedOptionExportAlwaysRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private listViewShowGroupsCheckBox As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace