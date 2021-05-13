
Namespace Telerik.Examples.WinControls.ListView.Settings
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
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
            Dim listViewDetailColumn1 As New Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "File Name")
            Dim listViewDetailColumn2 As New Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Total Size")
            Dim listViewDetailColumn3 As New Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Type")
            Dim listViewDetailColumn4 As New Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Free Space")
            Dim listViewDataItemGroup1 As New Telerik.WinControls.UI.ListViewDataItemGroup("Files Stored on This Computer")
            Dim listViewDataItemGroup2 As New Telerik.WinControls.UI.ListViewDataItemGroup("Hard Disk Drives")
            Dim listViewDataItemGroup3 As New Telerik.WinControls.UI.ListViewDataItemGroup("Devices with Removable Storage")
            Dim listViewDataItem1 As New Telerik.WinControls.UI.ListViewDataItem("Shared Documents", New String() {"Shared Documents", "", "File Folder"})
            Dim listViewDataItem2 As New Telerik.WinControls.UI.ListViewDataItem("Administrator's Documents", New String() {"Administrator's Documents", "", "File Folder"})
            Dim listViewDataItem3 As New Telerik.WinControls.UI.ListViewDataItem("3.5 Floppy (A:)", New String() {"3.5 Floppy (A:)", "1.44 MB", "Floppy Drive", "203 KB"})
            Dim listViewDataItem4 As New Telerik.WinControls.UI.ListViewDataItem("Local Disk (C:)", New String() {"Local Disk (C:)", "160.4 GB", "Local Disk", "31.02 GB"})
            Dim listViewDataItem5 As New Telerik.WinControls.UI.ListViewDataItem("Local Disk (D:)", New String() {"Local Disk (D:)", "136.2 GB", "Local Disk", "57.52 GB"})
            Dim listViewDataItem6 As New Telerik.WinControls.UI.ListViewDataItem("Local Disk (E:)", New String() {"Local Disk (E:)", "40.00 GB", "Local Disk", "13.37 GB"})
            Dim listViewDataItem7 As New Telerik.WinControls.UI.ListViewDataItem("Local Disk (F:)", New String() {"Local Disk (F:)", "0.99 TB", "Local Disk", "357.37 GB"})
            Dim listViewDataItem8 As New Telerik.WinControls.UI.ListViewDataItem("DVD/CD-RW Drive (G:)", New String() {"DVD/CD-RW (G:)", "4.7 GB", "DVD Drive", "0 KB"})
            Dim listViewDataItem9 As New Telerik.WinControls.UI.ListViewDataItem("CD-RW Drive (H:)", New String() {"CD-RW (G:)", "", "CD Drive"})
            Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem7 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem8 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem5 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem6 As New Telerik.WinControls.UI.RadListDataItem()
            Me.radListView1 = New Telerik.WinControls.UI.RadListView()
            Me.radCheckBoxShowCheckboxes = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxGroups = New Telerik.WinControls.UI.RadCheckBox()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radCheckBoxLassoSelection = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxHotTracking = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxAllowEdit = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxMultiSelect = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxKeyboardNavigation = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxFullRowSelect = New Telerik.WinControls.UI.RadCheckBox()
            Me.radLabel9 = New Telerik.WinControls.UI.RadLabel()
            Me.radDropDownListCheckOnClickMode = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.radCheckBox4 = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxArbWidth = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxArbHeight = New Telerik.WinControls.UI.RadCheckBox()
            Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditorGroupHeight = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radSpinEditorItemHeight = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radSpinEditorItemWidth = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radSpinEditorGroupIndent = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radSpinEditorItemSpacing = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radGroupBoxDetailView = New Telerik.WinControls.UI.RadGroupBox()
            Me.radButtonBestFitColumns = New Telerik.WinControls.UI.RadButton()
            Me.radSpinEditorHeaderHeight = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radCheckBoxColHeaders = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxColSort = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxColReorder = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxColResize = New Telerik.WinControls.UI.RadCheckBox()
            Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
            Me.radGroupBoxIconView = New Telerik.WinControls.UI.RadGroupBox()
            Me.radDropDownList2 = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
            Me.radGroupBox5 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radDropDownListViewType = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.radPanel1 = New Telerik.Examples.WinControls.TreeView.TreeExampleHeaderPanel()
            Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
            Me.radGroupBoxCheckedListBox = New Telerik.WinControls.UI.RadGroupBox()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.radListView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBoxShowCheckboxes, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBoxGroups, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            DirectCast(Me.radCheckBoxLassoSelection, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBoxHotTracking, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBoxAllowEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBoxMultiSelect, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBoxKeyboardNavigation, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBoxFullRowSelect, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radDropDownListCheckOnClickMode, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radLabel5.SuspendLayout()
            DirectCast(Me.radCheckBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBoxArbWidth, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBoxArbHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox2.SuspendLayout()
            DirectCast(Me.radLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radSpinEditorGroupHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radSpinEditorItemHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radSpinEditorItemWidth, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radSpinEditorGroupIndent, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radSpinEditorItemSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupBoxDetailView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBoxDetailView.SuspendLayout()
            DirectCast(Me.radButtonBestFitColumns, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radSpinEditorHeaderHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBoxColHeaders, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBoxColSort, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBoxColReorder, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radCheckBoxColResize, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupBoxIconView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBoxIconView.SuspendLayout()
            DirectCast(Me.radDropDownList2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox5.SuspendLayout()
            DirectCast(Me.radDropDownListViewType, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel2.SuspendLayout()
            DirectCast(Me.radGroupBoxCheckedListBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBoxCheckedListBox.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radGroupBoxCheckedListBox)
            Me.settingsPanel.Controls.Add(Me.radGroupBox5)
            Me.settingsPanel.Controls.Add(Me.radGroupBox2)
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.Controls.Add(Me.radGroupBoxIconView)
            Me.settingsPanel.Controls.Add(Me.radGroupBoxDetailView)
            Me.settingsPanel.Location = New System.Drawing.Point(1032, 1)
            Me.settingsPanel.Size = New System.Drawing.Size(200, 803)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxDetailView, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxIconView, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox5, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxCheckedListBox, 0)
            ' 
            ' radListView1
            ' 
            listViewDetailColumn1.HeaderText = "File Name"
            listViewDetailColumn2.HeaderText = "Total Size"
            listViewDetailColumn3.HeaderText = "Type"
            listViewDetailColumn4.HeaderText = "Free Space"
            Me.radListView1.Columns.AddRange(New Telerik.WinControls.UI.ListViewDetailColumn() {listViewDetailColumn1, listViewDetailColumn2, listViewDetailColumn3, listViewDetailColumn4})
            Me.radListView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radListView1.EnableCustomGrouping = True
            Me.radListView1.EnableSorting = True
            listViewDataItemGroup1.Text = "Files Stored on This Computer"
            listViewDataItemGroup2.Text = "Hard Disk Drives"
            listViewDataItemGroup3.Text = "Devices with Removable Storage"
            Me.radListView1.Groups.AddRange(New Telerik.WinControls.UI.ListViewDataItemGroup() {listViewDataItemGroup1, listViewDataItemGroup2, listViewDataItemGroup3})
            listViewDataItem1.Group = listViewDataItemGroup1
            listViewDataItem1.Image = Global.My.Resources.folder_xp
            listViewDataItem1.Text = "Shared Documents"
            listViewDataItem2.Group = listViewDataItemGroup1
            listViewDataItem2.Image = Global.My.Resources.folder_xp
            listViewDataItem2.Text = "Administrator's Documents"
            listViewDataItem3.Group = listViewDataItemGroup3
            listViewDataItem3.Image = Global.My.Resources.floppy_drive
            listViewDataItem3.Text = "3.5 Floppy (A:)"
            listViewDataItem4.Group = listViewDataItemGroup2
            listViewDataItem4.Image = Global.My.Resources.hard_drive
            listViewDataItem4.Text = "Local Disk (C:)"
            listViewDataItem5.Group = listViewDataItemGroup2
            listViewDataItem5.Image = Global.My.Resources.hard_drive
            listViewDataItem5.Text = "Local Disk (D:)"
            listViewDataItem6.Group = listViewDataItemGroup2
            listViewDataItem6.Image = Global.My.Resources.hard_drive
            listViewDataItem6.Text = "Local Disk (E:)"
            listViewDataItem7.Group = listViewDataItemGroup2
            listViewDataItem7.Image = Global.My.Resources.hard_drive
            listViewDataItem7.Text = "Local Disk (F:)"
            listViewDataItem8.Group = listViewDataItemGroup3
            listViewDataItem8.Image = Global.My.Resources.cd_drive
            listViewDataItem8.Text = "DVD/CD-RW Drive (G:)"
            listViewDataItem9.Group = listViewDataItemGroup3
            listViewDataItem9.Image = Global.My.Resources.cd_drive
            listViewDataItem9.Text = "CD-RW Drive (H:)"
            Me.radListView1.Items.AddRange(New Telerik.WinControls.UI.ListViewDataItem() {listViewDataItem1, listViewDataItem2, listViewDataItem3, listViewDataItem4, listViewDataItem5, listViewDataItem6, _
                listViewDataItem7, listViewDataItem8, listViewDataItem9})
            Me.radListView1.ItemSize = New System.Drawing.Size(200, 32)
            Me.radListView1.KeyboardSearchEnabled = True
            Me.radListView1.Location = New System.Drawing.Point(0, 30)
            Me.radListView1.Name = "radListView1"
            Me.radListView1.Size = New System.Drawing.Size(561, 342)
            Me.radListView1.TabIndex = 1
            Me.radListView1.Text = "radListView1"
            ' 
            ' radCheckBoxShowCheckboxes
            ' 
            Me.radCheckBoxShowCheckboxes.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxShowCheckboxes.Location = New System.Drawing.Point(5, 22)
            Me.radCheckBoxShowCheckboxes.Name = "radCheckBoxShowCheckboxes"
            Me.radCheckBoxShowCheckboxes.Size = New System.Drawing.Size(113, 18)
            Me.radCheckBoxShowCheckboxes.TabIndex = 2
            Me.radCheckBoxShowCheckboxes.Text = "Show Check Boxes"
            ' 
            ' radCheckBoxGroups
            ' 
            Me.radCheckBoxGroups.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxGroups.Location = New System.Drawing.Point(5, 166)
            Me.radCheckBoxGroups.Name = "radCheckBoxGroups"
            Me.radCheckBoxGroups.Size = New System.Drawing.Size(87, 18)
            Me.radCheckBoxGroups.TabIndex = 4
            Me.radCheckBoxGroups.Text = "Show Groups"
            ' 
            ' radGroupBox1
            ' 
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox1.Controls.Add(Me.radCheckBoxLassoSelection)
            Me.radGroupBox1.Controls.Add(Me.radCheckBoxHotTracking)
            Me.radGroupBox1.Controls.Add(Me.radCheckBoxAllowEdit)
            Me.radGroupBox1.Controls.Add(Me.radCheckBoxMultiSelect)
            Me.radGroupBox1.Controls.Add(Me.radCheckBoxKeyboardNavigation)
            Me.radGroupBox1.Controls.Add(Me.radCheckBoxGroups)
            Me.radGroupBox1.Controls.Add(Me.radCheckBoxFullRowSelect)
            Me.radGroupBox1.HeaderText = "General Settings"
            Me.radGroupBox1.Location = New System.Drawing.Point(10, 89)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New System.Drawing.Size(180, 190)
            Me.radGroupBox1.TabIndex = 7
            Me.radGroupBox1.Text = "General Settings"
            ' 
            ' radCheckBoxLassoSelection
            ' 
            Me.radCheckBoxLassoSelection.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxLassoSelection.Location = New System.Drawing.Point(5, 142)
            Me.radCheckBoxLassoSelection.Name = "radCheckBoxLassoSelection"
            Me.radCheckBoxLassoSelection.Size = New System.Drawing.Size(132, 18)
            Me.radCheckBoxLassoSelection.TabIndex = 20
            Me.radCheckBoxLassoSelection.Text = "Enable Lasso Selection"
            AddHandler Me.radCheckBoxLassoSelection.ToggleStateChanged, AddressOf Me.radCheckBoxLassoSelection_ToggleStateChanged
            ' 
            ' radCheckBoxHotTracking
            ' 
            Me.radCheckBoxHotTracking.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxHotTracking.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxHotTracking.Location = New System.Drawing.Point(5, 118)
            Me.radCheckBoxHotTracking.Name = "radCheckBoxHotTracking"
            Me.radCheckBoxHotTracking.Size = New System.Drawing.Size(120, 18)
            Me.radCheckBoxHotTracking.TabIndex = 19
            Me.radCheckBoxHotTracking.Text = "Enable Hot Tracking"
            Me.radCheckBoxHotTracking.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBoxHotTracking.ToggleStateChanged, AddressOf Me.radCheckBoxHotTracking_ToggleStateChanged
            ' 
            ' radCheckBoxAllowEdit
            ' 
            Me.radCheckBoxAllowEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxAllowEdit.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxAllowEdit.Location = New System.Drawing.Point(5, 21)
            Me.radCheckBoxAllowEdit.Name = "radCheckBoxAllowEdit"
            Me.radCheckBoxAllowEdit.Size = New System.Drawing.Size(103, 18)
            Me.radCheckBoxAllowEdit.TabIndex = 18
            Me.radCheckBoxAllowEdit.Text = "Enable AllowEdit"
            Me.radCheckBoxAllowEdit.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBoxAllowEdit.ToggleStateChanged, AddressOf Me.radCheckBoxAllowEdit_ToggleStateChanged
            ' 
            ' radCheckBoxMultiSelect
            ' 
            Me.radCheckBoxMultiSelect.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxMultiSelect.Location = New System.Drawing.Point(5, 93)
            Me.radCheckBoxMultiSelect.Name = "radCheckBoxMultiSelect"
            Me.radCheckBoxMultiSelect.Size = New System.Drawing.Size(112, 18)
            Me.radCheckBoxMultiSelect.TabIndex = 15
            Me.radCheckBoxMultiSelect.Text = "Enable MultiSelect"
            AddHandler Me.radCheckBoxMultiSelect.ToggleStateChanged, AddressOf Me.radCheckBoxMultiSelect_ToggleStateChanged
            ' 
            ' radCheckBoxKeyboardNavigation
            ' 
            Me.radCheckBoxKeyboardNavigation.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxKeyboardNavigation.Location = New System.Drawing.Point(5, 69)
            Me.radCheckBoxKeyboardNavigation.Name = "radCheckBoxKeyboardNavigation"
            Me.radCheckBoxKeyboardNavigation.Size = New System.Drawing.Size(162, 18)
            Me.radCheckBoxKeyboardNavigation.TabIndex = 5
            Me.radCheckBoxKeyboardNavigation.Text = "Enable Keyboard Navigation"
            AddHandler Me.radCheckBoxKeyboardNavigation.ToggleStateChanged, AddressOf Me.radCheckBoxKeyboardNavigation_ToggleStateChanged
            ' 
            ' radCheckBoxFullRowSelect
            ' 
            Me.radCheckBoxFullRowSelect.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxFullRowSelect.Location = New System.Drawing.Point(5, 45)
            Me.radCheckBoxFullRowSelect.Name = "radCheckBoxFullRowSelect"
            Me.radCheckBoxFullRowSelect.Size = New System.Drawing.Size(125, 18)
            Me.radCheckBoxFullRowSelect.TabIndex = 14
            Me.radCheckBoxFullRowSelect.Text = "Enable FullRowSelect"
            ' 
            ' radLabel9
            ' 
            Me.radLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel9.Location = New System.Drawing.Point(5, 44)
            Me.radLabel9.Name = "radLabel9"
            Me.radLabel9.Size = New System.Drawing.Size(37, 18)
            Me.radLabel9.TabIndex = 16
            Me.radLabel9.Text = "Mode:"
            ' 
            ' radDropDownListCheckOnClickMode
            ' 
            Me.radDropDownListCheckOnClickMode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListCheckOnClickMode.Enabled = False
            radListDataItem1.Text = "Off"
            radListDataItem2.Text = "First Click"
            radListDataItem3.Text = "Second Click"
            Me.radDropDownListCheckOnClickMode.Items.Add(radListDataItem1)
            Me.radDropDownListCheckOnClickMode.Items.Add(radListDataItem2)
            Me.radDropDownListCheckOnClickMode.Items.Add(radListDataItem3)
            Me.radDropDownListCheckOnClickMode.Location = New System.Drawing.Point(53, 42)
            Me.radDropDownListCheckOnClickMode.Name = "radDropDownListCheckOnClickMode"
            Me.radDropDownListCheckOnClickMode.Size = New System.Drawing.Size(122, 20)
            Me.radDropDownListCheckOnClickMode.TabIndex = 17
            Me.radDropDownListCheckOnClickMode.Tag = "Right"
            Me.radDropDownListCheckOnClickMode.Text = "Off"
            AddHandler Me.radDropDownListCheckOnClickMode.SelectedIndexChanged, AddressOf Me.radDropDownListCheckOnClickMode_SelectedIndexChanged
            ' 
            ' radLabel2
            ' 
            Me.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel2.Location = New System.Drawing.Point(5, 21)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(61, 18)
            Me.radLabel2.TabIndex = 8
            Me.radLabel2.Text = "Item Width"
            ' 
            ' radLabel3
            ' 
            Me.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel3.Location = New System.Drawing.Point(5, 73)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(70, 18)
            Me.radLabel3.TabIndex = 9
            Me.radLabel3.Text = "Item Spacing"
            ' 
            ' radLabel4
            ' 
            Me.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel4.Location = New System.Drawing.Point(5, 99)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(73, 18)
            Me.radLabel4.TabIndex = 10
            Me.radLabel4.Text = "Group Height"
            ' 
            ' radLabel5
            ' 
            Me.radLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel5.Controls.Add(Me.radCheckBox4)
            Me.radLabel5.Location = New System.Drawing.Point(5, 126)
            Me.radLabel5.Name = "radLabel5"
            Me.radLabel5.Size = New System.Drawing.Size(72, 18)
            Me.radLabel5.TabIndex = 11
            Me.radLabel5.Text = "Group Indent"
            ' 
            ' radCheckBox4
            ' 
            Me.radCheckBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBox4.Location = New System.Drawing.Point(0, 22)
            Me.radCheckBox4.Name = "radCheckBox4"
            Me.radCheckBox4.Size = New System.Drawing.Size(154, 18)
            Me.radCheckBox4.TabIndex = 12
            Me.radCheckBox4.Text = "Allow Arbitrary Item Width"
            ' 
            ' radCheckBoxArbWidth
            ' 
            Me.radCheckBoxArbWidth.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxArbWidth.Location = New System.Drawing.Point(5, 149)
            Me.radCheckBoxArbWidth.Name = "radCheckBoxArbWidth"
            Me.radCheckBoxArbWidth.Size = New System.Drawing.Size(154, 18)
            Me.radCheckBoxArbWidth.TabIndex = 12
            Me.radCheckBoxArbWidth.Text = "Allow Arbitrary Item Width"
            ' 
            ' radCheckBoxArbHeight
            ' 
            Me.radCheckBoxArbHeight.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxArbHeight.Location = New System.Drawing.Point(5, 172)
            Me.radCheckBoxArbHeight.Name = "radCheckBoxArbHeight"
            Me.radCheckBoxArbHeight.Size = New System.Drawing.Size(157, 18)
            Me.radCheckBoxArbHeight.TabIndex = 13
            Me.radCheckBoxArbHeight.Text = "Allow Arbitrary Item Height"
            ' 
            ' radGroupBox2
            ' 
            Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox2.Controls.Add(Me.radLabel8)
            Me.radGroupBox2.Controls.Add(Me.radSpinEditorGroupHeight)
            Me.radGroupBox2.Controls.Add(Me.radSpinEditorItemHeight)
            Me.radGroupBox2.Controls.Add(Me.radSpinEditorItemWidth)
            Me.radGroupBox2.Controls.Add(Me.radSpinEditorGroupIndent)
            Me.radGroupBox2.Controls.Add(Me.radSpinEditorItemSpacing)
            Me.radGroupBox2.Controls.Add(Me.radLabel2)
            Me.radGroupBox2.Controls.Add(Me.radLabel3)
            Me.radGroupBox2.Controls.Add(Me.radCheckBoxArbHeight)
            Me.radGroupBox2.Controls.Add(Me.radLabel4)
            Me.radGroupBox2.Controls.Add(Me.radCheckBoxArbWidth)
            Me.radGroupBox2.Controls.Add(Me.radLabel5)
            Me.radGroupBox2.HeaderText = "Sizing Settings"
            Me.radGroupBox2.Location = New System.Drawing.Point(10, 362)
            Me.radGroupBox2.Name = "radGroupBox2"
            Me.radGroupBox2.Size = New System.Drawing.Size(180, 194)
            Me.radGroupBox2.TabIndex = 15
            Me.radGroupBox2.Text = "Sizing Settings"
            ' 
            ' radLabel8
            ' 
            Me.radLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel8.Location = New System.Drawing.Point(5, 47)
            Me.radLabel8.Name = "radLabel8"
            Me.radLabel8.Size = New System.Drawing.Size(64, 18)
            Me.radLabel8.TabIndex = 24
            Me.radLabel8.Text = "Item Height"
            ' 
            ' radSpinEditorGroupHeight
            ' 
            Me.radSpinEditorGroupHeight.Location = New System.Drawing.Point(90, 97)
            Me.radSpinEditorGroupHeight.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.radSpinEditorGroupHeight.Name = "radSpinEditorGroupHeight"
            ' 
            ' 
            ' 
            Me.radSpinEditorGroupHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radSpinEditorGroupHeight.Size = New System.Drawing.Size(85, 20)
            Me.radSpinEditorGroupHeight.TabIndex = 23
            Me.radSpinEditorGroupHeight.TabStop = False
            Me.radSpinEditorGroupHeight.Tag = "Right"
            ' 
            ' radSpinEditorItemHeight
            ' 
            Me.radSpinEditorItemHeight.Location = New System.Drawing.Point(90, 45)
            Me.radSpinEditorItemHeight.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.radSpinEditorItemHeight.Name = "radSpinEditorItemHeight"
            ' 
            ' 
            ' 
            Me.radSpinEditorItemHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radSpinEditorItemHeight.Size = New System.Drawing.Size(85, 20)
            Me.radSpinEditorItemHeight.TabIndex = 21
            Me.radSpinEditorItemHeight.TabStop = False
            Me.radSpinEditorItemHeight.Tag = "Right"
            ' 
            ' radSpinEditorItemWidth
            ' 
            Me.radSpinEditorItemWidth.Location = New System.Drawing.Point(90, 19)
            Me.radSpinEditorItemWidth.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.radSpinEditorItemWidth.Name = "radSpinEditorItemWidth"
            ' 
            ' 
            ' 
            Me.radSpinEditorItemWidth.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radSpinEditorItemWidth.Size = New System.Drawing.Size(85, 20)
            Me.radSpinEditorItemWidth.TabIndex = 20
            Me.radSpinEditorItemWidth.TabStop = False
            Me.radSpinEditorItemWidth.Tag = "Right"
            ' 
            ' radSpinEditorGroupIndent
            ' 
            Me.radSpinEditorGroupIndent.Location = New System.Drawing.Point(90, 124)
            Me.radSpinEditorGroupIndent.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.radSpinEditorGroupIndent.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
            Me.radSpinEditorGroupIndent.Name = "radSpinEditorGroupIndent"
            ' 
            ' 
            ' 
            Me.radSpinEditorGroupIndent.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radSpinEditorGroupIndent.Size = New System.Drawing.Size(85, 20)
            Me.radSpinEditorGroupIndent.TabIndex = 19
            Me.radSpinEditorGroupIndent.TabStop = False
            Me.radSpinEditorGroupIndent.Tag = "Right"
            ' 
            ' radSpinEditorItemSpacing
            ' 
            Me.radSpinEditorItemSpacing.Location = New System.Drawing.Point(90, 71)
            Me.radSpinEditorItemSpacing.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.radSpinEditorItemSpacing.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
            Me.radSpinEditorItemSpacing.Name = "radSpinEditorItemSpacing"
            ' 
            ' 
            ' 
            Me.radSpinEditorItemSpacing.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radSpinEditorItemSpacing.Size = New System.Drawing.Size(85, 20)
            Me.radSpinEditorItemSpacing.TabIndex = 18
            Me.radSpinEditorItemSpacing.TabStop = False
            Me.radSpinEditorItemSpacing.Tag = "Right"
            ' 
            ' radGroupBoxDetailView
            ' 
            Me.radGroupBoxDetailView.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBoxDetailView.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBoxDetailView.Controls.Add(Me.radButtonBestFitColumns)
            Me.radGroupBoxDetailView.Controls.Add(Me.radSpinEditorHeaderHeight)
            Me.radGroupBoxDetailView.Controls.Add(Me.radCheckBoxColHeaders)
            Me.radGroupBoxDetailView.Controls.Add(Me.radCheckBoxColSort)
            Me.radGroupBoxDetailView.Controls.Add(Me.radCheckBoxColReorder)
            Me.radGroupBoxDetailView.Controls.Add(Me.radCheckBoxColResize)
            Me.radGroupBoxDetailView.Controls.Add(Me.radLabel6)
            Me.radGroupBoxDetailView.HeaderText = "Detail View Settings"
            Me.radGroupBoxDetailView.Location = New System.Drawing.Point(10, 562)
            Me.radGroupBoxDetailView.Name = "radGroupBoxDetailView"
            Me.radGroupBoxDetailView.Size = New System.Drawing.Size(180, 175)
            Me.radGroupBoxDetailView.TabIndex = 16
            Me.radGroupBoxDetailView.Text = "Detail View Settings"
            ' 
            ' radButtonBestFitColumns
            ' 
            Me.radButtonBestFitColumns.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radButtonBestFitColumns.Location = New System.Drawing.Point(5, 142)
            Me.radButtonBestFitColumns.Name = "radButtonBestFitColumns"
            Me.radButtonBestFitColumns.Size = New System.Drawing.Size(170, 24)
            Me.radButtonBestFitColumns.TabIndex = 20
            Me.radButtonBestFitColumns.Text = "Best Fit Columns"
            ' 
            ' radSpinEditorHeaderHeight
            ' 
            Me.radSpinEditorHeaderHeight.Location = New System.Drawing.Point(90, 21)
            Me.radSpinEditorHeaderHeight.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
            Me.radSpinEditorHeaderHeight.Name = "radSpinEditorHeaderHeight"
            ' 
            ' 
            ' 
            Me.radSpinEditorHeaderHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radSpinEditorHeaderHeight.Size = New System.Drawing.Size(85, 20)
            Me.radSpinEditorHeaderHeight.TabIndex = 19
            Me.radSpinEditorHeaderHeight.TabStop = False
            Me.radSpinEditorHeaderHeight.Tag = "Right"
            Me.radSpinEditorHeaderHeight.Value = New Decimal(New Integer() {35, 0, 0, 0})
            ' 
            ' radCheckBoxColHeaders
            ' 
            Me.radCheckBoxColHeaders.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxColHeaders.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxColHeaders.Location = New System.Drawing.Point(5, 45)
            Me.radCheckBoxColHeaders.Name = "radCheckBoxColHeaders"
            Me.radCheckBoxColHeaders.Size = New System.Drawing.Size(134, 18)
            Me.radCheckBoxColHeaders.TabIndex = 16
            Me.radCheckBoxColHeaders.Text = "Show Column Headers"
            Me.radCheckBoxColHeaders.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            ' 
            ' radCheckBoxColSort
            ' 
            Me.radCheckBoxColSort.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxColSort.Location = New System.Drawing.Point(5, 117)
            Me.radCheckBoxColSort.Name = "radCheckBoxColSort"
            Me.radCheckBoxColSort.Size = New System.Drawing.Size(119, 18)
            Me.radCheckBoxColSort.TabIndex = 15
            Me.radCheckBoxColSort.Text = "Enable Column Sort"
            ' 
            ' radCheckBoxColReorder
            ' 
            Me.radCheckBoxColReorder.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxColReorder.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxColReorder.Location = New System.Drawing.Point(5, 93)
            Me.radCheckBoxColReorder.Name = "radCheckBoxColReorder"
            Me.radCheckBoxColReorder.Size = New System.Drawing.Size(138, 18)
            Me.radCheckBoxColReorder.TabIndex = 14
            Me.radCheckBoxColReorder.Text = "Enable Column Reorder"
            Me.radCheckBoxColReorder.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            ' 
            ' radCheckBoxColResize
            ' 
            Me.radCheckBoxColResize.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radCheckBoxColResize.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxColResize.Location = New System.Drawing.Point(5, 69)
            Me.radCheckBoxColResize.Name = "radCheckBoxColResize"
            Me.radCheckBoxColResize.Size = New System.Drawing.Size(130, 18)
            Me.radCheckBoxColResize.TabIndex = 13
            Me.radCheckBoxColResize.Text = "Enable Column Resize"
            Me.radCheckBoxColResize.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            ' 
            ' radLabel6
            ' 
            Me.radLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel6.Location = New System.Drawing.Point(5, 21)
            Me.radLabel6.Name = "radLabel6"
            Me.radLabel6.Size = New System.Drawing.Size(78, 18)
            Me.radLabel6.TabIndex = 9
            Me.radLabel6.Text = "Header Height"
            ' 
            ' radGroupBoxIconView
            ' 
            Me.radGroupBoxIconView.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBoxIconView.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBoxIconView.Controls.Add(Me.radDropDownList2)
            Me.radGroupBoxIconView.Controls.Add(Me.radLabel7)
            Me.radGroupBoxIconView.HeaderText = "Icon View Settings"
            Me.radGroupBoxIconView.Location = New System.Drawing.Point(10, 743)
            Me.radGroupBoxIconView.Name = "radGroupBoxIconView"
            Me.radGroupBoxIconView.Size = New System.Drawing.Size(180, 48)
            Me.radGroupBoxIconView.TabIndex = 17
            Me.radGroupBoxIconView.Text = "Icon View Settings"
            ' 
            ' radDropDownList2
            ' 
            Me.radDropDownList2.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            radListDataItem7.Text = "Vertical"
            radListDataItem8.Text = "Horizontal"
            Me.radDropDownList2.Items.Add(radListDataItem7)
            Me.radDropDownList2.Items.Add(radListDataItem8)
            Me.radDropDownList2.Location = New System.Drawing.Point(69, 21)
            Me.radDropDownList2.Name = "radDropDownList2"
            Me.radDropDownList2.Size = New System.Drawing.Size(106, 20)
            Me.radDropDownList2.TabIndex = 11
            Me.radDropDownList2.Tag = "Right"
            Me.radDropDownList2.Text = "Vertical"
            ' 
            ' radLabel7
            ' 
            Me.radLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel7.Location = New System.Drawing.Point(5, 22)
            Me.radLabel7.Name = "radLabel7"
            Me.radLabel7.Size = New System.Drawing.Size(62, 18)
            Me.radLabel7.TabIndex = 10
            Me.radLabel7.Text = "Orientation"
            ' 
            ' radGroupBox5
            ' 
            Me.radGroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox5.Controls.Add(Me.radDropDownListViewType)
            Me.radGroupBox5.Controls.Add(Me.radLabel1)
            Me.radGroupBox5.HeaderText = "View Type"
            Me.radGroupBox5.Location = New System.Drawing.Point(10, 29)
            Me.radGroupBox5.Name = "radGroupBox5"
            Me.radGroupBox5.Size = New System.Drawing.Size(180, 51)
            Me.radGroupBox5.TabIndex = 18
            Me.radGroupBox5.Text = "View Type"
            ' 
            ' radDropDownListViewType
            ' 
            Me.radDropDownListViewType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            radListDataItem4.Text = "List View"
            radListDataItem5.Text = "Icon View"
            radListDataItem6.Text = "Detail View"
            Me.radDropDownListViewType.Items.Add(radListDataItem4)
            Me.radDropDownListViewType.Items.Add(radListDataItem5)
            Me.radDropDownListViewType.Items.Add(radListDataItem6)
            Me.radDropDownListViewType.Location = New System.Drawing.Point(53, 23)
            Me.radDropDownListViewType.Name = "radDropDownListViewType"
            Me.radDropDownListViewType.Size = New System.Drawing.Size(122, 20)
            Me.radDropDownListViewType.TabIndex = 3
            Me.radDropDownListViewType.Tag = "Right"
            Me.radDropDownListViewType.Text = "List View"
            ' 
            ' radLabel1
            ' 
            Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel1.Location = New System.Drawing.Point(5, 25)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(32, 18)
            Me.radLabel1.TabIndex = 2
            Me.radLabel1.Text = "View:"
            ' 
            ' radPanel1
            ' 
            Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radPanel1.Location = New System.Drawing.Point(0, 0)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New System.Drawing.Size(561, 30)
            Me.radPanel1.TabIndex = 2
            Me.radPanel1.Text = "My Computer"
            DirectCast(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "My Computer"
            DirectCast(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Font = New System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Bold)
            DirectCast(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Padding = New System.Windows.Forms.Padding(8, 4, 2, 2)
            DirectCast(Me.radPanel1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.Gray
            ' 
            ' radPanel2
            ' 
            Me.radPanel2.Controls.Add(Me.radListView1)
            Me.radPanel2.Controls.Add(Me.radPanel1)
            Me.radPanel2.Location = New System.Drawing.Point(0, 0)
            Me.radPanel2.Name = "radPanel2"
            Me.radPanel2.Size = New System.Drawing.Size(561, 372)
            Me.radPanel2.TabIndex = 3
            Me.radPanel2.Text = "radPanel2"
            ' 
            ' radGroupBoxCheckedListBox
            ' 
            Me.radGroupBoxCheckedListBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBoxCheckedListBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBoxCheckedListBox.Controls.Add(Me.radDropDownListCheckOnClickMode)
            Me.radGroupBoxCheckedListBox.Controls.Add(Me.radLabel9)
            Me.radGroupBoxCheckedListBox.Controls.Add(Me.radCheckBoxShowCheckboxes)
            Me.radGroupBoxCheckedListBox.HeaderText = "Checked ListBox"
            Me.radGroupBoxCheckedListBox.Location = New System.Drawing.Point(10, 286)
            Me.radGroupBoxCheckedListBox.Name = "radGroupBoxCheckedListBox"
            Me.radGroupBoxCheckedListBox.Size = New System.Drawing.Size(180, 70)
            Me.radGroupBoxCheckedListBox.TabIndex = 19
            Me.radGroupBoxCheckedListBox.Text = "Checked ListBox"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.radPanel2)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1460, 1000)
            Me.Controls.SetChildIndex(Me.radPanel2, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            DirectCast(Me.radListView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBoxShowCheckboxes, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBoxGroups, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            DirectCast(Me.radCheckBoxLassoSelection, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBoxHotTracking, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBoxAllowEdit, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBoxMultiSelect, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBoxKeyboardNavigation, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBoxFullRowSelect, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabel9, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radDropDownListCheckOnClickMode, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radLabel5.ResumeLayout(False)
            Me.radLabel5.PerformLayout()
            DirectCast(Me.radCheckBox4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBoxArbWidth, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBoxArbHeight, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox2.ResumeLayout(False)
            Me.radGroupBox2.PerformLayout()
            DirectCast(Me.radLabel8, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radSpinEditorGroupHeight, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radSpinEditorItemHeight, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radSpinEditorItemWidth, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radSpinEditorGroupIndent, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radSpinEditorItemSpacing, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupBoxDetailView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBoxDetailView.ResumeLayout(False)
            Me.radGroupBoxDetailView.PerformLayout()
            DirectCast(Me.radButtonBestFitColumns, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radSpinEditorHeaderHeight, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBoxColHeaders, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBoxColSort, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBoxColReorder, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radCheckBoxColResize, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupBoxIconView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBoxIconView.ResumeLayout(False)
            Me.radGroupBoxIconView.PerformLayout()
            DirectCast(Me.radDropDownList2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox5.ResumeLayout(False)
            Me.radGroupBox5.PerformLayout()
            DirectCast(Me.radDropDownListViewType, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel2.ResumeLayout(False)
            DirectCast(Me.radGroupBoxCheckedListBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBoxCheckedListBox.ResumeLayout(False)
            Me.radGroupBoxCheckedListBox.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radListView1 As Telerik.WinControls.UI.RadListView
        Private radCheckBoxShowCheckboxes As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxGroups As Telerik.WinControls.UI.RadCheckBox
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private radLabel5 As Telerik.WinControls.UI.RadLabel
        Private radCheckBox4 As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxArbWidth As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxArbHeight As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxFullRowSelect As Telerik.WinControls.UI.RadCheckBox
        Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
        Private radGroupBoxDetailView As Telerik.WinControls.UI.RadGroupBox
        Private radLabel6 As Telerik.WinControls.UI.RadLabel
        Private radCheckBoxColResize As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxColReorder As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxColSort As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxColHeaders As Telerik.WinControls.UI.RadCheckBox
        Private radGroupBoxIconView As Telerik.WinControls.UI.RadGroupBox
        Private radLabel7 As Telerik.WinControls.UI.RadLabel
        Private radGroupBox5 As Telerik.WinControls.UI.RadGroupBox
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radDropDownListViewType As Telerik.WinControls.UI.RadDropDownList
        Private radSpinEditorItemSpacing As Telerik.WinControls.UI.RadSpinEditor
        Private radSpinEditorGroupIndent As Telerik.WinControls.UI.RadSpinEditor
        Private radDropDownList2 As Telerik.WinControls.UI.RadDropDownList
        Private radSpinEditorHeaderHeight As Telerik.WinControls.UI.RadSpinEditor
        Private radSpinEditorItemWidth As Telerik.WinControls.UI.RadSpinEditor
        Private radSpinEditorItemHeight As Telerik.WinControls.UI.RadSpinEditor
        Private radSpinEditorGroupHeight As Telerik.WinControls.UI.RadSpinEditor
        Private radLabel8 As Telerik.WinControls.UI.RadLabel
        Private radPanel1 As Telerik.Examples.WinControls.TreeView.TreeExampleHeaderPanel
        Private radPanel2 As Telerik.WinControls.UI.RadPanel
        Private radButtonBestFitColumns As Telerik.WinControls.UI.RadButton
        Private radCheckBoxKeyboardNavigation As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxMultiSelect As Telerik.WinControls.UI.RadCheckBox
        Private radDropDownListCheckOnClickMode As Telerik.WinControls.UI.RadDropDownList
        Private radLabel9 As Telerik.WinControls.UI.RadLabel
        Private radCheckBoxAllowEdit As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxHotTracking As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxLassoSelection As Telerik.WinControls.UI.RadCheckBox
        Private radGroupBoxCheckedListBox As Telerik.WinControls.UI.RadGroupBox
    End Class
End Namespace