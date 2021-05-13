Namespace Telerik.Examples.WinControls.ListView.AutoSizeColumnsMode
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim listViewDetailColumn1 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "File Name")
            Dim listViewDetailColumn2 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Total Size")
            Dim listViewDetailColumn3 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Type")
            Dim listViewDetailColumn4 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Free Space")
            Dim listViewDataItemGroup1 As Telerik.WinControls.UI.ListViewDataItemGroup = New Telerik.WinControls.UI.ListViewDataItemGroup("Files Stored on This Computer")
            Dim listViewDataItemGroup2 As Telerik.WinControls.UI.ListViewDataItemGroup = New Telerik.WinControls.UI.ListViewDataItemGroup("Hard Disk Drives")
            Dim listViewDataItemGroup3 As Telerik.WinControls.UI.ListViewDataItemGroup = New Telerik.WinControls.UI.ListViewDataItemGroup("Devices with Removable Storage")
            Dim listViewDataItem1 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Shared Documents", New String() {"Shared Documents", "", "File Folder"})
            Dim listViewDataItem2 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Administrator's Documents", New String() {"Administrator's Documents", "", "File Folder"})
            Dim listViewDataItem3 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("3.5 Floppy (A:)", New String() {"3.5 Floppy (A:)", "1.44 MB", "Floppy Drive", "203 KB"})
            Dim listViewDataItem4 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Local Disk (C:)", New String() {"Local Disk (C:)", "160.4 GB", "Local Disk", "31.02 GB"})
            Dim listViewDataItem5 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Local Disk (D:)", New String() {"Local Disk (D:)", "136.2 GB", "Local Disk", "57.52 GB"})
            Dim listViewDataItem6 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Local Disk (E:)", New String() {"Local Disk (E:)", "40.00 GB", "Local Disk", "13.37 GB"})
            Dim listViewDataItem7 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Local Disk (F:)", New String() {"Local Disk (F:)", "0.99 TB", "Local Disk", "357.37 GB"})
            Dim listViewDataItem8 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("DVD/CD-RW Drive (G:)", New String() {"DVD/CD-RW (G:)", "4.7 GB", "DVD Drive", "0 KB"})
            Dim listViewDataItem9 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("CD-RW Drive (H:)", New String() {"CD-RW (G:)", "", "CD Drive"})
            Me.radListView1 = New Telerik.WinControls.UI.RadListView()
            Me.radGroupBox5 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radLabelMyComputer = New Telerik.WinControls.UI.RadLabel()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radListView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox5.SuspendLayout()
            CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelMyComputer, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radPanelDemoHolder.Controls.Add(Me.radListView1)
            Me.radPanelDemoHolder.Controls.Add(Me.radLabelMyComputer)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(28, 5)
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(561, 372)
            Me.settingsPanel.Location = New System.Drawing.Point(1032, 1)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox5)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(200, 803)
            Me.settingsPanel.Size = New System.Drawing.Size(200, 803)
            Me.optionsLabel.Location = New System.Drawing.Point(113, 118)
            Me.radListView1.AutoSizeColumnsMode = Telerik.WinControls.UI.ListViewAutoSizeColumnsMode.Fill
            listViewDetailColumn1.HeaderText = "File Name"
            listViewDetailColumn1.MinWidth = 150.0F
            listViewDetailColumn1.Width = 283.9235F
            listViewDetailColumn2.HeaderText = "Total Size"
            listViewDetailColumn2.Width = 79.29031F
            listViewDetailColumn3.HeaderText = "Type"
            listViewDetailColumn3.Width = 91.81257F
            listViewDetailColumn4.HeaderText = "Free Space"
            listViewDetailColumn4.Width = 106.9736F
            Me.radListView1.Columns.AddRange(New Telerik.WinControls.UI.ListViewDetailColumn() {listViewDetailColumn1, listViewDetailColumn2, listViewDetailColumn3, listViewDetailColumn4})
            Me.radListView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radListView1.EnableCustomGrouping = True
            Me.radListView1.EnableSorting = True
            listViewDataItemGroup1.Text = "Files Stored on This Computer"
            listViewDataItemGroup2.Text = "Hard Disk Drives"
            listViewDataItemGroup3.Text = "Devices with Removable Storage"
            Me.radListView1.Groups.AddRange(New Telerik.WinControls.UI.ListViewDataItemGroup() {listViewDataItemGroup1, listViewDataItemGroup2, listViewDataItemGroup3})
            listViewDataItem1.Group = listViewDataItemGroup1
            listViewDataItem1.Image = My.Resources.folder_xp
            listViewDataItem1.Text = "Shared Documents"
            listViewDataItem2.Group = listViewDataItemGroup1
            listViewDataItem2.Image = My.Resources.folder_xp
            listViewDataItem2.Text = "Administrator's Documents"
            listViewDataItem3.Group = listViewDataItemGroup3
            listViewDataItem3.Image = My.Resources.floppy_drive
            listViewDataItem3.Text = "3.5 Floppy (A:)"
            listViewDataItem4.Group = listViewDataItemGroup2
            listViewDataItem4.Image = My.Resources.hard_drive
            listViewDataItem4.Text = "Local Disk (C:)"
            listViewDataItem5.Group = listViewDataItemGroup2
            listViewDataItem5.Image = My.Resources.hard_drive
            listViewDataItem5.Text = "Local Disk (D:)"
            listViewDataItem6.Group = listViewDataItemGroup2
            listViewDataItem6.Image = My.Resources.hard_drive
            listViewDataItem6.Text = "Local Disk (E:)"
            listViewDataItem7.Group = listViewDataItemGroup2
            listViewDataItem7.Image = My.Resources.hard_drive
            listViewDataItem7.Text = "Local Disk (F:)"
            listViewDataItem8.Group = listViewDataItemGroup3
            listViewDataItem8.Image = My.Resources.cd_drive
            listViewDataItem8.Text = "DVD/CD-RW Drive (G:)"
            listViewDataItem9.Group = listViewDataItemGroup3
            listViewDataItem9.Image = My.Resources.cd_drive
            listViewDataItem9.Text = "CD-RW Drive (H:)"
            Me.radListView1.Items.AddRange(New Telerik.WinControls.UI.ListViewDataItem() {listViewDataItem1, listViewDataItem2, listViewDataItem3, listViewDataItem4, listViewDataItem5, listViewDataItem6, listViewDataItem7, listViewDataItem8, listViewDataItem9})
            Me.radListView1.ItemSize = New System.Drawing.Size(200, 34)
            Me.radListView1.ItemSpacing = -1
            Me.radListView1.KeyboardSearchEnabled = True
            Me.radListView1.Location = New System.Drawing.Point(0, 30)
            Me.radListView1.Name = "radListView1"
            Me.radListView1.Size = New System.Drawing.Size(561, 342)
            Me.radListView1.TabIndex = 1
            Me.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
            AddHandler Me.radListView1.CellFormatting, New Telerik.WinControls.UI.ListViewCellFormattingEventHandler(AddressOf Me.RadListView1_CellFormatting)
            Me.radGroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox5.Controls.Add(Me.radRadioButton2)
            Me.radGroupBox5.Controls.Add(Me.radRadioButton1)
            Me.radGroupBox5.HeaderText = "AutoSize Columns Mode"
            Me.radGroupBox5.Location = New System.Drawing.Point(4, 7)
            Me.radGroupBox5.Name = "radGroupBox5"
            Me.radGroupBox5.Size = New System.Drawing.Size(193, 82)
            Me.radGroupBox5.TabIndex = 18
            Me.radGroupBox5.Text = "AutoSize Columns Mode"
            Me.radRadioButton2.Location = New System.Drawing.Point(9, 53)
            Me.radRadioButton2.Name = "radRadioButton2"
            Me.radRadioButton2.Size = New System.Drawing.Size(48, 18)
            Me.radRadioButton2.TabIndex = 1
            Me.radRadioButton2.TabStop = False
            Me.radRadioButton2.Text = "None"
            Me.radRadioButton1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radRadioButton1.Location = New System.Drawing.Point(9, 27)
            Me.radRadioButton1.Name = "radRadioButton1"
            Me.radRadioButton1.Size = New System.Drawing.Size(34, 18)
            Me.radRadioButton1.TabIndex = 0
            Me.radRadioButton1.Text = "Fill"
            Me.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radRadioButton1.ToggleStateChanged, New Telerik.WinControls.UI.StateChangedEventHandler(AddressOf Me.RadRadioButton1_ToggleStateChanged)
            Me.radLabelMyComputer.AutoSize = False
            Me.radLabelMyComputer.Dock = System.Windows.Forms.DockStyle.Top
            Me.radLabelMyComputer.Font = New System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Bold)
            Me.radLabelMyComputer.ForeColor = System.Drawing.Color.Gray
            Me.radLabelMyComputer.Location = New System.Drawing.Point(0, 0)
            Me.radLabelMyComputer.Name = "radLabelMyComputer"
            Me.radLabelMyComputer.Padding = New System.Windows.Forms.Padding(8, 4, 2, 2)
            Me.radLabelMyComputer.Size = New System.Drawing.Size(561, 30)
            Me.radLabelMyComputer.TabIndex = 2
            Me.radLabelMyComputer.Text = "My Computer"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1454, 788)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radListView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox5.ResumeLayout(False)
            Me.radGroupBox5.PerformLayout()
            CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelMyComputer, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radListView1 As Telerik.WinControls.UI.RadListView
        Private radGroupBox5 As Telerik.WinControls.UI.RadGroupBox
        Private radLabelMyComputer As Telerik.WinControls.UI.RadLabel
        Private radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButton1 As Telerik.WinControls.UI.RadRadioButton
    End Class
End Namespace
