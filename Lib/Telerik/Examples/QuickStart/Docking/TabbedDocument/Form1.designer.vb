Namespace Telerik.Examples.WinControls.Docking.TabbedDocument
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
			Dim guidToNameMapping1 As New Telerik.WinControls.UI.Docking.GuidToNameMapping()
			Dim guidToNameMapping2 As New Telerik.WinControls.UI.Docking.GuidToNameMapping()
			Dim guidToNameMapping3 As New Telerik.WinControls.UI.Docking.GuidToNameMapping()
			Dim guidToNameMapping4 As New Telerik.WinControls.UI.Docking.GuidToNameMapping()
			Dim guidToNameMapping5 As New Telerik.WinControls.UI.Docking.GuidToNameMapping()
			Dim guidToNameMapping6 As New Telerik.WinControls.UI.Docking.GuidToNameMapping()
			Dim treeNode1 As New TreeNode("Node0")
			Dim treeNode2 As New TreeNode("Node1")
			Dim treeNode3 As New TreeNode("Node8")
			Dim treeNode4 As New TreeNode("Node9")
			Dim treeNode5 As New TreeNode("Node11")
			Dim treeNode6 As New TreeNode("Node12")
			Dim treeNode7 As New TreeNode("Node13")
			Dim treeNode8 As New TreeNode("Node10", New TreeNode() { treeNode5, treeNode6, treeNode7})
			Dim treeNode9 As New TreeNode("Node2", New TreeNode() { treeNode3, treeNode4, treeNode8})
			Dim treeNode10 As New TreeNode("Node3")
			Dim treeNode11 As New TreeNode("Node4")
			Dim treeNode12 As New TreeNode("Node14")
			Dim treeNode13 As New TreeNode("Node15")
			Dim treeNode14 As New TreeNode("Node16")
			Dim treeNode15 As New TreeNode("Node5", New TreeNode() { treeNode12, treeNode13, treeNode14})
			Dim treeNode16 As New TreeNode("Node17")
			Dim treeNode17 As New TreeNode("Node18")
			Dim treeNode18 As New TreeNode("Node6", New TreeNode() { treeNode16, treeNode17})
			Dim treeNode19 As New TreeNode("Node7")
			Dim listViewGroup1 As New ListViewGroup("ListViewGroup", HorizontalAlignment.Left)
			Dim listViewGroup2 As New ListViewGroup("ListViewGroup", HorizontalAlignment.Left)
			Dim listViewItem1 As New ListViewItem("Demo1")
			Dim listViewItem2 As New ListViewItem("Demo2")
			Dim listViewItem3 As New ListViewItem("Demo3")
			Me.openFileDialog = New OpenFileDialog()
			Me.saveFileDialog = New SaveFileDialog()
			Me.radDock1 = New Telerik.WinControls.UI.Docking.RadDock()
			Me.toolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.currentRadComboBox = New Telerik.WinControls.UI.RadDropDownList()
			Me.label1 = New Telerik.WinControls.UI.RadLabel()
			Me.contextRadDropDownButton = New Telerik.WinControls.UI.RadDropDownButton()
			Me.newRadButton = New Telerik.WinControls.UI.RadButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.toolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.logRadTextBox = New Telerik.WinControls.UI.RadTextBox()
			Me.documentContainer2 = New Telerik.WinControls.UI.Docking.DocumentContainer()
			Me.documentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
			Me.documentWindow4 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.webBrowser1 = New WebBrowser()
			Me.documentWindow3 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.webBrowser2 = New WebBrowser()
            Me.documentWindow2 = New Telerik.WinControls.UI.Docking.DocumentWindow()
            Me.treeView1 = New System.Windows.Forms.TreeView()
            Me.documentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
            Me.listView1 = New System.Windows.Forms.ListView()
			Me.columnHeader1 = (CType(New ColumnHeader(), ColumnHeader))
			Me.columnHeader2 = (CType(New ColumnHeader(), ColumnHeader))
			Me.columnHeader3 = (CType(New ColumnHeader(), ColumnHeader))
			Me.columnHeader4 = (CType(New ColumnHeader(), ColumnHeader))
			Me.columnHeader5 = (CType(New ColumnHeader(), ColumnHeader))
			Me.tableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radDock1.SuspendLayout()
			Me.toolWindow1.SuspendLayout()
			CType(Me.currentRadComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.contextRadDropDownButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.newRadButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer1.SuspendLayout()
			CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip1.SuspendLayout()
			CType(Me.toolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip2.SuspendLayout()
			Me.toolWindow2.SuspendLayout()
			CType(Me.logRadTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.documentContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentContainer2.SuspendLayout()
			CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentTabStrip1.SuspendLayout()
			Me.documentWindow4.SuspendLayout()
			Me.documentWindow3.SuspendLayout()
			Me.documentWindow2.SuspendLayout()
			Me.documentWindow1.SuspendLayout()
			Me.tableLayoutPanel1.SuspendLayout()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' openFileDialog
			' 
			Me.openFileDialog.FileName = "openFileDialog"
			' 
			' radDock1
			' 
			Me.radDock1.ActiveWindow = Me.toolWindow1
			Me.radDock1.Controls.Add(Me.radSplitContainer1)
			Me.radDock1.Controls.Add(Me.documentContainer2)
			Me.radDock1.Dock = DockStyle.Fill
			guidToNameMapping1.Guid = New Guid("3e428570-705e-4bed-9d7b-62cc6f7ea32f")
			guidToNameMapping1.Name = "toolWindow1"
			guidToNameMapping2.Guid = New Guid("b489d229-833b-49fa-92e1-e7992b2fcc56")
			guidToNameMapping2.Name = "toolWindow2"
			guidToNameMapping3.Guid = New Guid("bca4ebcf-49c1-4bd5-a677-9b8d3ab70b33")
			guidToNameMapping3.Name = "toolWindow3"
			guidToNameMapping4.Guid = New Guid("2b65334f-bb61-458c-981a-c70f140d0663")
			guidToNameMapping4.Name = "toolWindow4"
			guidToNameMapping5.Guid = New Guid("bfe80d29-985e-44f0-b0c6-a35c0c8da9dd")
			guidToNameMapping5.Name = "documentWindow1"
			guidToNameMapping6.Guid = New Guid("628b5fc4-ce79-4af1-8839-e1fd3d77a86c")
			guidToNameMapping6.Name = "documentWindow2"
			Me.radDock1.GuidToNameMappings.Add(guidToNameMapping1)
			Me.radDock1.GuidToNameMappings.Add(guidToNameMapping2)
			Me.radDock1.GuidToNameMappings.Add(guidToNameMapping3)
			Me.radDock1.GuidToNameMappings.Add(guidToNameMapping4)
			Me.radDock1.GuidToNameMappings.Add(guidToNameMapping5)
			Me.radDock1.GuidToNameMappings.Add(guidToNameMapping6)
			Me.radDock1.IsCleanUpTarget = True
			Me.radDock1.Location = New Point(0, 0)
			Me.radDock1.MainDocumentContainer = Me.documentContainer2
			Me.radDock1.Name = "radDock1"
			' 
			' 
			' 
			Me.radDock1.RootElement.MinSize = New Size(25, 25)
			Me.radDock1.Size = New Size(1099, 698)
			Me.radDock1.TabIndex = 0
			Me.radDock1.TabStop = False
			' 
			' toolWindow1
			' 
			Me.toolWindow1.Caption = Nothing
			Me.toolWindow1.Controls.Add(Me.tableLayoutPanel1)
			Me.toolWindow1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.toolWindow1.Location = New Point(1, 24)
			Me.toolWindow1.Name = "toolWindow1"
			Me.toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
			Me.toolWindow1.Size = New Size(297, 316)
			Me.toolWindow1.Text = "Settings"
			' 
			' currentRadComboBox
			' 
			Me.currentRadComboBox.AutoSize = False
			Me.currentRadComboBox.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.currentRadComboBox.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.currentRadComboBox.Location = New Point(3, 83)
			Me.currentRadComboBox.Name = "currentRadComboBox"
			Me.currentRadComboBox.Size = New Size(206, 25)
			Me.currentRadComboBox.TabIndex = 7
			' 
			' label1
			' 

			Me.label1.Location = New Point(3, 160)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(206, 100)
			Me.label1.TabIndex = 6
			Me.label1.AutoSize = False
			Me.label1.TextWrap = True
			Me.label1.Text = "Right click on tab or drag and drop tabbed document item to show context menu."
			' 
			' contextRadDropDownButton
			' 
			Me.contextRadDropDownButton.Location = New Point(3, 123)
			Me.contextRadDropDownButton.Name = "contextRadDropDownButton"
			Me.contextRadDropDownButton.Size = New Size(140, 23)
			Me.contextRadDropDownButton.TabIndex = 3
			Me.contextRadDropDownButton.Text = "Context Commands"
			' 
			' newRadButton
			' 
			Me.newRadButton.Image = My.Resources.msIcon1
			Me.newRadButton.ImageAlignment = ContentAlignment.MiddleCenter
			Me.newRadButton.Location = New Point(3, 3)
			Me.newRadButton.Name = "newRadButton"
			Me.newRadButton.Size = New Size(140, 27)
			Me.newRadButton.TabIndex = 0
			Me.newRadButton.Text = "New document"
			Me.newRadButton.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
			Me.radLabel1.Location = New Point(3, 59)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(139, 18)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Current tabbed document:"
			Me.radLabel1.TextAlignment = ContentAlignment.TopLeft
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1.Controls.Add(Me.toolTabStrip1)
			Me.radSplitContainer1.Controls.Add(Me.toolTabStrip2)
			Me.radSplitContainer1.IsCleanUpTarget = True
			Me.radSplitContainer1.Location = New Point(5, 5)
			Me.radSplitContainer1.Name = "radSplitContainer1"
			Me.radSplitContainer1.Orientation = Orientation.Horizontal
			Me.radSplitContainer1.Padding = New Padding(5)
			' 
			' 
			' 
			Me.radSplitContainer1.RootElement.MinSize = New Size(25, 25)
			Me.radSplitContainer1.Size = New Size(299, 688)
			Me.radSplitContainer1.SizeInfo.AbsoluteSize = New Size(299, 200)
			Me.radSplitContainer1.SizeInfo.SplitterCorrection = New Size(99, 0)
			Me.radSplitContainer1.TabIndex = 0
			Me.radSplitContainer1.TabStop = False
			' 
			' toolTabStrip1
			' 
			Me.toolTabStrip1.CanUpdateChildIndex = True
			Me.toolTabStrip1.Controls.Add(Me.toolWindow1)
			Me.toolTabStrip1.Location = New Point(0, 0)
			Me.toolTabStrip1.Name = "toolTabStrip1"
			' 
			' 
			' 
			Me.toolTabStrip1.RootElement.MinSize = New Size(25, 25)
			Me.toolTabStrip1.SelectedIndex = 0
			Me.toolTabStrip1.Size = New Size(299, 342)
			Me.toolTabStrip1.TabIndex = 0
			Me.toolTabStrip1.TabStop = False
			' 
			' toolTabStrip2
			' 
			Me.toolTabStrip2.CanUpdateChildIndex = True
			Me.toolTabStrip2.Controls.Add(Me.toolWindow2)
			Me.toolTabStrip2.Location = New Point(0, 346)
			Me.toolTabStrip2.Name = "toolTabStrip2"
			' 
			' 
			' 
			Me.toolTabStrip2.RootElement.MinSize = New Size(25, 25)
			Me.toolTabStrip2.SelectedIndex = 0
			Me.toolTabStrip2.Size = New Size(299, 342)
			Me.toolTabStrip2.TabIndex = 1
			Me.toolTabStrip2.TabStop = False
			' 
			' toolWindow2
			' 
			Me.toolWindow2.Caption = Nothing
			Me.toolWindow2.Controls.Add(Me.logRadTextBox)
			Me.toolWindow2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.toolWindow2.Location = New Point(1, 24)
			Me.toolWindow2.Name = "toolWindow2"
			Me.toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
			Me.toolWindow2.Size = New Size(297, 316)
			Me.toolWindow2.Text = "Log"
			' 
			' logRadTextBox
			' 
			Me.logRadTextBox.AutoSize = False
			Me.logRadTextBox.Dock = DockStyle.Fill
			Me.logRadTextBox.Location = New Point(0, 0)
			Me.logRadTextBox.Multiline = True
			Me.logRadTextBox.Name = "logRadTextBox"
			' 
			' 
			' 
			Me.logRadTextBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.logRadTextBox.ScrollBars = ScrollBars.Vertical
			Me.logRadTextBox.Size = New Size(297, 316)
			Me.logRadTextBox.TabIndex = 0
			Me.logRadTextBox.TabStop = False
			' 
			' documentContainer2
			' 
			Me.documentContainer2.Controls.Add(Me.documentTabStrip1)
			Me.documentContainer2.Name = "documentContainer2"
			' 
			' 
			' 
			Me.documentContainer2.RootElement.MinSize = New Size(25, 25)
			Me.documentContainer2.SizeInfo.AbsoluteSize = New Size(786, 200)
			Me.documentContainer2.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
			Me.documentContainer2.SizeInfo.SplitterCorrection = New Size(-99, 0)
			Me.documentContainer2.TabIndex = 1
			' 
			' documentTabStrip1
			' 
			Me.documentTabStrip1.CanUpdateChildIndex = True
			Me.documentTabStrip1.Controls.Add(Me.documentWindow4)
			Me.documentTabStrip1.Controls.Add(Me.documentWindow3)
			Me.documentTabStrip1.Controls.Add(Me.documentWindow2)
			Me.documentTabStrip1.Controls.Add(Me.documentWindow1)
			Me.documentTabStrip1.Location = New Point(0, 0)
			Me.documentTabStrip1.Name = "documentTabStrip1"
			' 
			' 
			' 
			Me.documentTabStrip1.RootElement.MinSize = New Size(25, 25)
			Me.documentTabStrip1.SelectedIndex = 0
			Me.documentTabStrip1.Size = New Size(786, 688)
			Me.documentTabStrip1.TabIndex = 0
			Me.documentTabStrip1.TabStop = False
			' 
			' documentWindow4
			' 
			Me.documentWindow4.Controls.Add(Me.webBrowser1)
			Me.documentWindow4.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.documentWindow4.Location = New Point(6, 29)
			Me.documentWindow4.Name = "documentWindow4"
			Me.documentWindow4.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
			Me.documentWindow4.Size = New Size(774, 653)
			Me.documentWindow4.Text = "Document 4"
			' 
			' webBrowser1
			' 
			Me.webBrowser1.Dock = DockStyle.Fill
			Me.webBrowser1.Location = New Point(0, 0)
			Me.webBrowser1.MinimumSize = New Size(20, 20)
			Me.webBrowser1.Name = "webBrowser1"
			Me.webBrowser1.Size = New Size(774, 653)
			Me.webBrowser1.TabIndex = 0
			Me.webBrowser1.Url = New Uri("http://www.telerik.com/", UriKind.Absolute)
			' 
			' documentWindow3
			' 
			Me.documentWindow3.Controls.Add(Me.webBrowser2)
			Me.documentWindow3.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.documentWindow3.Location = New Point(0, 0)
			Me.documentWindow3.Name = "documentWindow3"
			Me.documentWindow3.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
			Me.documentWindow3.Size = New Size(0, 0)
			Me.documentWindow3.Text = "Document 3"
			' 
			' webBrowser2
			' 
			Me.webBrowser2.Dock = DockStyle.Fill
			Me.webBrowser2.Location = New Point(0, 0)
			Me.webBrowser2.MinimumSize = New Size(20, 20)
			Me.webBrowser2.Name = "webBrowser2"
			Me.webBrowser2.Size = New Size(20, 20)
			Me.webBrowser2.TabIndex = 1
			Me.webBrowser2.Url = New Uri("http://www.telerik.com/products/winforms.aspx", UriKind.Absolute)
			' 
			' documentWindow2
			' 
			Me.documentWindow2.Controls.Add(Me.treeView1)
			Me.documentWindow2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.documentWindow2.Location = New Point(0, 0)
			Me.documentWindow2.Name = "documentWindow2"
			Me.documentWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
			Me.documentWindow2.Size = New Size(0, 0)
			Me.documentWindow2.Text = "Document 2"
			' 
			' treeView1
			' 
			Me.treeView1.Dock = DockStyle.Fill
			Me.treeView1.Location = New Point(0, 0)
			Me.treeView1.Name = "treeView1"
			treeNode1.Name = "Node0"
			treeNode1.Text = "Node0"
			treeNode2.Name = "Node1"
			treeNode2.Text = "Node1"
			treeNode3.Name = "Node8"
			treeNode3.Text = "Node8"
			treeNode4.Name = "Node9"
			treeNode4.Text = "Node9"
			treeNode5.Name = "Node11"
			treeNode5.Text = "Node11"
			treeNode6.Name = "Node12"
			treeNode6.Text = "Node12"
			treeNode7.Name = "Node13"
			treeNode7.Text = "Node13"
			treeNode8.Name = "Node10"
			treeNode8.Text = "Node10"
			treeNode9.Name = "Node2"
			treeNode9.Text = "Node2"
			treeNode10.Name = "Node3"
			treeNode10.Text = "Node3"
			treeNode11.Name = "Node4"
			treeNode11.Text = "Node4"
			treeNode12.Name = "Node14"
			treeNode12.Text = "Node14"
			treeNode13.Name = "Node15"
			treeNode13.Text = "Node15"
			treeNode14.Name = "Node16"
			treeNode14.Text = "Node16"
			treeNode15.Name = "Node5"
			treeNode15.Text = "Node5"
			treeNode16.Name = "Node17"
			treeNode16.Text = "Node17"
			treeNode17.Name = "Node18"
			treeNode17.Text = "Node18"
			treeNode18.Name = "Node6"
			treeNode18.Text = "Node6"
			treeNode19.Name = "Node7"
			treeNode19.Text = "Node7"
			Me.treeView1.Nodes.AddRange(New TreeNode() { treeNode1, treeNode2, treeNode9, treeNode10, treeNode11, treeNode15, treeNode18, treeNode19})
			Me.treeView1.Size = New Size(0, 0)
			Me.treeView1.TabIndex = 0
			' 
			' documentWindow1
			' 
			Me.documentWindow1.Controls.Add(Me.listView1)
			Me.documentWindow1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.documentWindow1.Location = New Point(0, 0)
			Me.documentWindow1.Name = "documentWindow1"
			Me.documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
			Me.documentWindow1.Size = New Size(0, 0)
			Me.documentWindow1.Text = "Document 1"
			' 
			' listView1
			' 
			Me.listView1.Columns.AddRange(New ColumnHeader() { Me.columnHeader1, Me.columnHeader2, Me.columnHeader3, Me.columnHeader4, Me.columnHeader5})
			Me.listView1.Dock = DockStyle.Fill
			listViewGroup1.Header = "ListViewGroup"
			listViewGroup1.Name = "listViewGroup1"
			listViewGroup2.Header = "ListViewGroup"
			listViewGroup2.Name = "listViewGroup2"
			Me.listView1.Groups.AddRange(New ListViewGroup() { listViewGroup1, listViewGroup2})
			Me.listView1.Items.AddRange(New ListViewItem() { listViewItem1, listViewItem2, listViewItem3})
			Me.listView1.Location = New Point(0, 0)
			Me.listView1.Name = "listView1"
			Me.listView1.Size = New Size(0, 0)
			Me.listView1.TabIndex = 1
			Me.listView1.UseCompatibleStateImageBehavior = False
			Me.listView1.View = View.Details
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 1
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.tableLayoutPanel1.Controls.Add(Me.newRadButton, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.label1, 0, 4)
			Me.tableLayoutPanel1.Controls.Add(Me.currentRadComboBox, 0, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.contextRadDropDownButton, 0, 3)
			Me.tableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 1)
			Me.tableLayoutPanel1.Dock = DockStyle.Fill
			Me.tableLayoutPanel1.Location = New Point(0, 0)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 5
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.83988F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.83988F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.83988F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.83988F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 48.64048F))
			Me.tableLayoutPanel1.Size = New Size(297, 316)
			Me.tableLayoutPanel1.TabIndex = 8
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.ClientSize = New Size(1099, 698)
			Me.Controls.Add(Me.radDock1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "TabbedDocument"
			Me.ThemeName = "Fluent"
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radDock1.ResumeLayout(False)
			Me.toolWindow1.ResumeLayout(False)
			CType(Me.currentRadComboBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.contextRadDropDownButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.newRadButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer1.ResumeLayout(False)
			CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip1.ResumeLayout(False)
			CType(Me.toolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip2.ResumeLayout(False)
			Me.toolWindow2.ResumeLayout(False)
			CType(Me.logRadTextBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.documentContainer2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentContainer2.ResumeLayout(False)
			CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentTabStrip1.ResumeLayout(False)
			Me.documentWindow4.ResumeLayout(False)
			Me.documentWindow3.ResumeLayout(False)
			Me.documentWindow2.ResumeLayout(False)
			Me.documentWindow1.ResumeLayout(False)
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.tableLayoutPanel1.PerformLayout()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private newRadButton As Telerik.WinControls.UI.RadButton
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private contextRadDropDownButton As Telerik.WinControls.UI.RadDropDownButton
		Private logRadTextBox As Telerik.WinControls.UI.RadTextBox
		Private label1 As Telerik.WinControls.UI.RadLabel
		Private openFileDialog As OpenFileDialog
		Private saveFileDialog As SaveFileDialog
        Private currentRadComboBox As Telerik.WinControls.UI.RadDropDownList
        Private treeView1 As System.Windows.Forms.TreeView
        Private listView1 As System.Windows.Forms.ListView
		Private columnHeader1 As ColumnHeader
		Private columnHeader2 As ColumnHeader
		Private columnHeader3 As ColumnHeader
		Private columnHeader4 As ColumnHeader
		Private columnHeader5 As ColumnHeader
		Private radDock1 As Telerik.WinControls.UI.Docking.RadDock
		Private toolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private toolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
		Private documentContainer2 As Telerik.WinControls.UI.Docking.DocumentContainer
		Private documentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
		Private documentWindow2 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private documentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private documentWindow4 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private documentWindow3 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private webBrowser1 As WebBrowser
		Private webBrowser2 As WebBrowser
		Private tableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
	End Class
End Namespace