Imports Telerik.WinControls.UI
Namespace Telerik.Examples.WinControls.Docking.VisualStudioIDE
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
			Me.components = New System.ComponentModel.Container()
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem5 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem6 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem7 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem8 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem9 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem10 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem11 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem12 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem13 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem14 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem15 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem16 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem17 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem18 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem19 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem20 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem21 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem22 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem23 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem24 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radTreeNode1 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode2 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode3 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode4 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode5 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode6 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode7 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode8 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode9 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode10 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode11 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode12 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode13 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode14 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode15 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode16 As New Telerik.WinControls.UI.RadTreeNode()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim sortDescriptor1 As New Telerik.WinControls.Data.SortDescriptor()
			Dim tableViewDefinition1 As New Telerik.WinControls.UI.TableViewDefinition()
			Dim radListDataItem25 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem26 As New Telerik.WinControls.UI.RadListDataItem()
			Dim gridViewImageColumn1 As New Telerik.WinControls.UI.GridViewImageColumn()
			Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn6 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn7 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn8 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn9 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn10 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim sortDescriptor2 As New Telerik.WinControls.Data.SortDescriptor()
			Dim tableViewDefinition2 As New Telerik.WinControls.UI.TableViewDefinition()
			Me.radDock1 = New Telerik.WinControls.UI.Docking.RadDock()
			Me.toolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.radListBox1 = New Telerik.WinControls.UI.RadListControl()
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.toolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.documentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
			Me.toolTabStrip4 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			Me.ImageList1 = New ImageList(Me.components)
			Me.toolTabStrip5 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow3 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.radPanel3 = New Telerik.WinControls.UI.RadPanel()
			Me.richTextBoxOutput = New Telerik.WinControls.UI.RadTextBoxControl()
			Me.toolWindow4 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.radGridViewTasks = New Telerik.WinControls.UI.RadGridView()
			Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
			Me.radComboBox1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.toolWindow5 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.radGridViewErrors = New Telerik.WinControls.UI.RadGridView()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radButton3 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radDock1.SuspendLayout()
			Me.toolWindow1.SuspendLayout()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer1.SuspendLayout()
			CType(Me.toolTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip3.SuspendLayout()
			CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toolTabStrip4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip4.SuspendLayout()
			Me.toolWindow2.SuspendLayout()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toolTabStrip5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip5.SuspendLayout()
			Me.toolWindow3.SuspendLayout()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel3.SuspendLayout()
			CType(Me.richTextBoxOutput, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolWindow4.SuspendLayout()
			CType(Me.radGridViewTasks, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridViewTasks.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel2.SuspendLayout()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolWindow5.SuspendLayout()
			CType(Me.radGridViewErrors, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridViewErrors.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radDock1
			' 
			Me.radDock1.ActiveWindow = Me.toolWindow1
			Me.radDock1.AutoHideAnimation = Telerik.WinControls.UI.Docking.AutoHideAnimateMode.AnimateHide
			Me.radDock1.CausesValidation = False
			Me.radDock1.Controls.Add(Me.radSplitContainer1)
			Me.radDock1.Controls.Add(Me.toolTabStrip5)
			Me.radDock1.Dock = DockStyle.Fill
			Me.radDock1.IsCleanUpTarget = True
			Me.radDock1.Location = New Point(0, 0)
			Me.radDock1.MainDocumentContainer = Me.documentContainer1
			Me.radDock1.Name = "radDock1"
			Me.radDock1.Orientation = Orientation.Horizontal
			' 
			' 
			' 
			Me.radDock1.RootElement.MinSize = New Size(0, 0)
			Me.radDock1.ShowDocumentCloseButton = True
			Me.radDock1.ShowDocumentPinButton = True
			Me.radDock1.Size = New Size(1115, 755)
			Me.radDock1.TabIndex = 0
			Me.radDock1.TabStop = False
			Me.radDock1.Text = "radDock1"
			' 
			' toolWindow1
			' 
			Me.toolWindow1.Caption = Nothing
			Me.toolWindow1.Controls.Add(Me.radListBox1)
			Me.toolWindow1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.toolWindow1.Location = New Point(1, 24)
			Me.toolWindow1.Name = "toolWindow1"
			Me.toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
			Me.toolWindow1.Size = New Size(217, 515)
			Me.toolWindow1.Text = "Toolbox"
			' 
			' radListBox1
			' 
			Me.radListBox1.BackColor = Color.Transparent
			Me.radListBox1.Dock = DockStyle.Fill
			Me.radListBox1.FormatString = "{0}"
			Me.radListBox1.ItemHeight = 20
			radListDataItem1.Image = My.Resources.RadButton
			radListDataItem1.Text = "RadButton"
			radListDataItem2.Image = My.Resources.RadCalendar
			radListDataItem2.Text = "RadCalendar"
			radListDataItem3.Image = My.Resources.RadLabel
			radListDataItem3.Text = "RadLabel"
			radListDataItem4.Image = My.Resources.RadCarousel
			radListDataItem4.Text = "RadCarousel"
			radListDataItem5.Image = My.Resources.RadRadioButton
			radListDataItem5.Text = "RadRadioButton"
			radListDataItem6.Image = My.Resources.RadCheckBox
			radListDataItem6.Text = "RadCheckBox"
			radListDataItem7.Image = My.Resources.RadPanel
			radListDataItem7.Text = "RadPanel"
			radListDataItem8.Image = My.Resources.RadProgressBar
			radListDataItem8.Text = "RadProgressBar"
			radListDataItem9.Image = My.Resources.RadTextBox
			radListDataItem9.Text = "RadTextBox"
			radListDataItem10.Image = My.Resources.RadPanelBar
			radListDataItem10.Text = "RadPanelBar"
			radListDataItem11.Image = My.Resources.RadTabStrip
			radListDataItem11.Text = "RadTabStrip"
			radListDataItem12.Image = My.Resources.RadMenu
			radListDataItem12.Text = "RadMenu"
			radListDataItem13.Image = My.Resources.RadContextMenuManager
			radListDataItem13.Text = "RadContextMenu"
			radListDataItem14.Image = My.Resources.RadSplitContainer
			radListDataItem14.Text = "RadSplitContainer"
			radListDataItem15.Image = My.Resources.RadTrackBar
			radListDataItem15.Text = "RadTrackBar"
			radListDataItem16.Image = My.Resources.RadRibbonBar
			radListDataItem16.Text = "RadRibbonBar"
			radListDataItem17.Image = My.Resources.RadRepeatButton
			radListDataItem17.Text = "RadRepeatButton"
			radListDataItem18.Image = My.Resources.RadGroupBox
			radListDataItem18.Text = "RadGroupBox"
			radListDataItem19.Image = My.Resources.RadSplitButton
			radListDataItem19.Text = "RadSplitButton"
			radListDataItem20.Image = My.Resources.RadForm
			radListDataItem20.Text = "RadForm"
			radListDataItem21.Image = My.Resources.RadMaskedEditBox
			radListDataItem21.Text = "RadMaskedEditBox"
			radListDataItem22.Image = My.Resources.RadComboBox
			radListDataItem22.Text = "RadComboxBox"
			radListDataItem23.Image = My.Resources.RadDropDownButton
			radListDataItem23.Text = "RadDropDownButton"
			radListDataItem24.Image = My.Resources.RadDateTimePicker
			radListDataItem24.Text = "RadDateTimePicker"
			Me.radListBox1.Items.Add(radListDataItem1)
			Me.radListBox1.Items.Add(radListDataItem2)
			Me.radListBox1.Items.Add(radListDataItem3)
			Me.radListBox1.Items.Add(radListDataItem4)
			Me.radListBox1.Items.Add(radListDataItem5)
			Me.radListBox1.Items.Add(radListDataItem6)
			Me.radListBox1.Items.Add(radListDataItem7)
			Me.radListBox1.Items.Add(radListDataItem8)
			Me.radListBox1.Items.Add(radListDataItem9)
			Me.radListBox1.Items.Add(radListDataItem10)
			Me.radListBox1.Items.Add(radListDataItem11)
			Me.radListBox1.Items.Add(radListDataItem12)
			Me.radListBox1.Items.Add(radListDataItem13)
			Me.radListBox1.Items.Add(radListDataItem14)
			Me.radListBox1.Items.Add(radListDataItem15)
			Me.radListBox1.Items.Add(radListDataItem16)
			Me.radListBox1.Items.Add(radListDataItem17)
			Me.radListBox1.Items.Add(radListDataItem18)
			Me.radListBox1.Items.Add(radListDataItem19)
			Me.radListBox1.Items.Add(radListDataItem20)
			Me.radListBox1.Items.Add(radListDataItem21)
			Me.radListBox1.Items.Add(radListDataItem22)
			Me.radListBox1.Items.Add(radListDataItem23)
			Me.radListBox1.Items.Add(radListDataItem24)
			Me.radListBox1.Location = New Point(0, 0)
			Me.radListBox1.Name = "radListBox1"
			Me.radListBox1.Padding = New Padding(2)
			Me.radListBox1.Size = New Size(217, 515)
			Me.radListBox1.TabIndex = 0
			Me.radListBox1.Text = "RadPanel"
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1.CausesValidation = False
			Me.radSplitContainer1.Controls.Add(Me.toolTabStrip3)
			Me.radSplitContainer1.Controls.Add(Me.documentContainer1)
			Me.radSplitContainer1.Controls.Add(Me.toolTabStrip4)
			Me.radSplitContainer1.IsCleanUpTarget = True
			Me.radSplitContainer1.Location = New Point(5, 5)
			Me.radSplitContainer1.Name = "radSplitContainer1"
			Me.radSplitContainer1.Padding = New Padding(5)
			' 
			' 
			' 
			Me.radSplitContainer1.RootElement.MinSize = New Size(0, 0)
			Me.radSplitContainer1.Size = New Size(1105, 541)
			Me.radSplitContainer1.TabIndex = 0
			Me.radSplitContainer1.TabStop = False
			' 
			' toolTabStrip3
			' 
			Me.toolTabStrip3.CanUpdateChildIndex = True
			Me.toolTabStrip3.CausesValidation = False
			Me.toolTabStrip3.Controls.Add(Me.toolWindow1)
			Me.toolTabStrip3.Location = New Point(0, 0)
			Me.toolTabStrip3.Name = "toolTabStrip3"
			' 
			' 
			' 
			Me.toolTabStrip3.RootElement.MinSize = New Size(0, 0)
			Me.toolTabStrip3.SelectedIndex = 0
			Me.toolTabStrip3.Size = New Size(219, 541)
			Me.toolTabStrip3.SizeInfo.AbsoluteSize = New Size(219, 200)
			Me.toolTabStrip3.SizeInfo.SplitterCorrection = New Size(19, 0)
			Me.toolTabStrip3.TabIndex = 1
			Me.toolTabStrip3.TabStop = False
			' 
			' documentContainer1
			' 
			Me.documentContainer1.Name = "documentContainer1"
			' 
			' 
			' 
			Me.documentContainer1.RootElement.MinSize = New Size(0, 0)
			Me.documentContainer1.SizeInfo.AbsoluteSize = New Size(608, 200)
			Me.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
			Me.documentContainer1.SizeInfo.SplitterCorrection = New Size(-89, 0)
			Me.documentContainer1.TabIndex = 2
			' 
			' toolTabStrip4
			' 
			Me.toolTabStrip4.CanUpdateChildIndex = True
			Me.toolTabStrip4.Controls.Add(Me.toolWindow2)
			Me.toolTabStrip4.Location = New Point(835, 0)
			Me.toolTabStrip4.Name = "toolTabStrip4"
			' 
			' 
			' 
			Me.toolTabStrip4.RootElement.MinSize = New Size(0, 0)
			Me.toolTabStrip4.SelectedIndex = 0
			Me.toolTabStrip4.Size = New Size(270, 541)
			Me.toolTabStrip4.SizeInfo.AbsoluteSize = New Size(270, 200)
			Me.toolTabStrip4.SizeInfo.SplitterCorrection = New Size(70, 0)
			Me.toolTabStrip4.TabIndex = 2
			Me.toolTabStrip4.TabStop = False
			' 
			' toolWindow2
			' 
			Me.toolWindow2.Caption = Nothing
			Me.toolWindow2.Controls.Add(Me.radTreeView1)
			Me.toolWindow2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.toolWindow2.Location = New Point(1, 24)
			Me.toolWindow2.Name = "toolWindow2"
			Me.toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
			Me.toolWindow2.Size = New Size(268, 515)
			Me.toolWindow2.Text = "Solution Explorer - Solution 'ProjectTracker' (4 project)"
			' 
			' radTreeView1
			' 
			Me.radTreeView1.Cursor = Cursors.Arrow
			Me.radTreeView1.Dock = DockStyle.Fill
			Me.radTreeView1.Font = New Font("Segoe UI", 8.25F)
			Me.radTreeView1.ImageList = Me.ImageList1
			Me.radTreeView1.Location = New Point(0, 0)
			Me.radTreeView1.Name = "radTreeView1"
			radTreeNode1.Expanded = True
			radTreeNode1.Image = (CType(resources.GetObject("radTreeNode1.Image"), Image))
			radTreeNode1.ImageIndex = 7
			radTreeNode2.Image = (CType(resources.GetObject("radTreeNode2.Image"), Image))
			radTreeNode2.ImageIndex = 6
			radTreeNode2.Text = "Common"
			radTreeNode3.Image = (CType(resources.GetObject("radTreeNode3.Image"), Image))
			radTreeNode3.ImageIndex = 6
			radTreeNode3.Text = "DataAccess"
			radTreeNode4.Image = (CType(resources.GetObject("radTreeNode4.Image"), Image))
			radTreeNode4.ImageIndex = 6
			radTreeNode4.Text = "Business"
			radTreeNode5.Expanded = True
			radTreeNode5.Image = (CType(resources.GetObject("radTreeNode5.Image"), Image))
			radTreeNode5.ImageIndex = 6
			radTreeNode6.Expanded = True
			radTreeNode6.Image = (CType(resources.GetObject("radTreeNode6.Image"), Image))
			radTreeNode6.ImageIndex = 9
			radTreeNode7.Image = (CType(resources.GetObject("radTreeNode7.Image"), Image))
			radTreeNode7.ImageIndex = 0
			radTreeNode7.Text = "AssemblyInfo.cs"
			radTreeNode6.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode7})
			radTreeNode6.Text = "Properties"
			radTreeNode8.Expanded = True
			radTreeNode8.Image = (CType(resources.GetObject("radTreeNode8.Image"), Image))
			radTreeNode8.ImageIndex = 8
			radTreeNode9.Image = (CType(resources.GetObject("radTreeNode9.Image"), Image))
			radTreeNode9.ImageIndex = 10
			radTreeNode9.Text = "System"
			radTreeNode10.Image = (CType(resources.GetObject("radTreeNode10.Image"), Image))
			radTreeNode10.ImageIndex = 10
			radTreeNode10.Text = "System.Data"
			radTreeNode11.Image = (CType(resources.GetObject("radTreeNode11.Image"), Image))
			radTreeNode11.ImageIndex = 10
			radTreeNode11.Text = "System.Xml"
			radTreeNode8.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode9, radTreeNode10, radTreeNode11})
			radTreeNode8.Text = "References"
			radTreeNode12.Expanded = True
			radTreeNode12.Image = (CType(resources.GetObject("radTreeNode12.Image"), Image))
			radTreeNode12.ImageIndex = 4
			radTreeNode13.Expanded = True
			radTreeNode13.Image = (CType(resources.GetObject("radTreeNode13.Image"), Image))
			radTreeNode13.ImageIndex = 3
			radTreeNode14.Image = (CType(resources.GetObject("radTreeNode14.Image"), Image))
			radTreeNode14.ImageIndex = 15
			radTreeNode14.Text = "Form1.Designer.cs"
			radTreeNode15.Image = (CType(resources.GetObject("radTreeNode15.Image"), Image))
			radTreeNode15.ImageIndex = 15
			radTreeNode15.Text = "Form1.resx"
			radTreeNode13.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode14, radTreeNode15})
			radTreeNode13.Text = "Form1.cs"
			radTreeNode12.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode13})
			radTreeNode12.Text = "Forms"
			radTreeNode16.Image = (CType(resources.GetObject("radTreeNode16.Image"), Image))
			radTreeNode16.ImageIndex = 0
			radTreeNode16.Text = "Program.cs"
			radTreeNode5.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode6, radTreeNode8, radTreeNode12, radTreeNode16})
			radTreeNode5.Text = "UI"
			radTreeNode1.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode2, radTreeNode3, radTreeNode4, radTreeNode5})
			radTreeNode1.Text = "Solution 'ProjectTracker' (4 projects)"
			Me.radTreeView1.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode1})
			Me.radTreeView1.RightToLeft = RightToLeft.No
			Me.radTreeView1.Size = New Size(268, 515)
			Me.radTreeView1.SpacingBetweenNodes = -1
			Me.radTreeView1.TabIndex = 0
			Me.radTreeView1.Text = "radTreeView1"
			Me.radTreeView1.ToggleMode = Telerik.WinControls.UI.ToggleMode.None
'			Me.radTreeView1.SelectedNodeChanged += New Telerik.WinControls.UI.RadTreeView.RadTreeViewEventHandler(Me.radTreeView1_SelectedNodeChanged)
'			Me.radTreeView1.NodeMouseDoubleClick += New Telerik.WinControls.UI.RadTreeView.TreeViewEventHandler(Me.radTreeView1_NodeMouseDoubleClick)
'			Me.radTreeView1.NodeExpandedChanged += New Telerik.WinControls.UI.RadTreeView.TreeViewEventHandler(Me.radTreeView1_NodeExpandedChanged)
			' 
			' ImageList1
			' 
			Me.ImageList1.ImageStream = (CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer))
			Me.ImageList1.TransparentColor = Color.Transparent
			Me.ImageList1.Images.SetKeyName(0, "vss_csfile.ico")
			Me.ImageList1.Images.SetKeyName(1, "vss_error.bmp")
			Me.ImageList1.Images.SetKeyName(2, "vss_folder.png")
			Me.ImageList1.Images.SetKeyName(3, "vss_form.ico")
			Me.ImageList1.Images.SetKeyName(4, "vss_open_folder.png")
			Me.ImageList1.Images.SetKeyName(5, "vss_output.bmp")
			Me.ImageList1.Images.SetKeyName(6, "vss_project.ico")
			Me.ImageList1.Images.SetKeyName(7, "vss_solution.ico")
			Me.ImageList1.Images.SetKeyName(8, "vss_referencesfolder.png")
			Me.ImageList1.Images.SetKeyName(9, "vss_propertiesfolder.png")
			Me.ImageList1.Images.SetKeyName(10, "vss_refassembly.ico")
			Me.ImageList1.Images.SetKeyName(11, "Control_ErrorProvider.png")
			Me.ImageList1.Images.SetKeyName(12, "vss_Warning.png")
			Me.ImageList1.Images.SetKeyName(13, "vss_Information.png")
			Me.ImageList1.Images.SetKeyName(14, "vss_Task.png")
			Me.ImageList1.Images.SetKeyName(15, "vss_formbehind.png")
			' 
			' toolTabStrip5
			' 
			Me.toolTabStrip5.CanUpdateChildIndex = True
			Me.toolTabStrip5.Controls.Add(Me.toolWindow3)
			Me.toolTabStrip5.Controls.Add(Me.toolWindow4)
			Me.toolTabStrip5.Controls.Add(Me.toolWindow5)
			Me.toolTabStrip5.Location = New Point(5, 550)
			Me.toolTabStrip5.Name = "toolTabStrip5"
			' 
			' 
			' 
			Me.toolTabStrip5.RootElement.MinSize = New Size(0, 0)
			Me.toolTabStrip5.SelectedIndex = 0
			Me.toolTabStrip5.Size = New Size(1105, 200)
			Me.toolTabStrip5.TabIndex = 3
			Me.toolTabStrip5.TabStop = False
			' 
			' toolWindow3
			' 
			Me.toolWindow3.Caption = Nothing
			Me.toolWindow3.Controls.Add(Me.radPanel3)
			Me.toolWindow3.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.toolWindow3.Location = New Point(1, 24)
			Me.toolWindow3.Name = "toolWindow3"
			Me.toolWindow3.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
			Me.toolWindow3.Size = New Size(1103, 150)
			Me.toolWindow3.Text = "Output"
			' 
			' radPanel3
			' 
			Me.radPanel3.Controls.Add(Me.richTextBoxOutput)
			Me.radPanel3.Dock = DockStyle.Fill
			Me.radPanel3.Location = New Point(0, 0)
			Me.radPanel3.Name = "radPanel3"
			Me.radPanel3.Padding = New Padding(1)
			Me.radPanel3.Size = New Size(1103, 150)
			Me.radPanel3.TabIndex = 1
			Me.radPanel3.Text = "radPanel3"
			' 
			' richTextBoxOutput
			' 
			Me.richTextBoxOutput.AcceptsReturn = True
			Me.richTextBoxOutput.BackColor = Color.FromArgb((CInt((CByte(230)))), (CInt((CByte(231)))), (CInt((CByte(232)))))
			Me.richTextBoxOutput.Dock = DockStyle.Fill
			Me.richTextBoxOutput.ForeColor = Color.FromArgb((CInt((CByte(30)))), (CInt((CByte(30)))), (CInt((CByte(30)))))
			Me.richTextBoxOutput.IsReadOnly = True
			Me.richTextBoxOutput.Location = New Point(1, 1)
			Me.richTextBoxOutput.Multiline = True
			Me.richTextBoxOutput.Name = "richTextBoxOutput"
			Me.richTextBoxOutput.Size = New Size(1101, 148)
			Me.richTextBoxOutput.TabIndex = 0
			' 
			' toolWindow4
			' 
			Me.toolWindow4.Caption = Nothing
			Me.toolWindow4.Controls.Add(Me.radGridViewTasks)
			Me.toolWindow4.Controls.Add(Me.radPanel2)
			Me.toolWindow4.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.toolWindow4.Location = New Point(1, 17)
			Me.toolWindow4.Name = "toolWindow4"
			Me.toolWindow4.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
			Me.toolWindow4.Size = New Size(790, 162)
			Me.toolWindow4.Text = "Task List"
			' 
			' radGridViewTasks
			' 
			Me.radGridViewTasks.BackColor = Color.FromArgb((CInt((CByte(191)))), (CInt((CByte(219)))), (CInt((CByte(254)))))
			Me.radGridViewTasks.Cursor = Cursors.Arrow
			Me.radGridViewTasks.Dock = DockStyle.Fill
			Me.radGridViewTasks.ForeColor = SystemColors.ControlText
			Me.radGridViewTasks.ImeMode = ImeMode.NoControl
			Me.radGridViewTasks.Location = New Point(0, 28)
			' 
			' 
			' 
			Me.radGridViewTasks.MasterTemplate.AllowAddNewRow = False
			Me.radGridViewTasks.MasterTemplate.AllowColumnReorder = False
			gridViewTextBoxColumn1.AllowGroup = False
			gridViewTextBoxColumn1.FieldName = "firstColumn"
			gridViewTextBoxColumn1.HeaderText = "!"
			gridViewTextBoxColumn1.MaxWidth = 20
			gridViewTextBoxColumn1.MinWidth = 20
			gridViewTextBoxColumn1.Name = "firstColumn"
			gridViewTextBoxColumn1.ReadOnly = True
			gridViewTextBoxColumn1.Width = 20
			gridViewTextBoxColumn2.AllowGroup = False
			gridViewTextBoxColumn2.FieldName = "Description"
			gridViewTextBoxColumn2.HeaderText = "Description"
			gridViewTextBoxColumn2.Name = "Description"
			gridViewTextBoxColumn2.ReadOnly = True
			gridViewTextBoxColumn2.Width = 239
			gridViewTextBoxColumn3.AllowGroup = False
			gridViewTextBoxColumn3.FieldName = "File"
			gridViewTextBoxColumn3.HeaderText = "File"
			gridViewTextBoxColumn3.MaxWidth = 100
			gridViewTextBoxColumn3.MinWidth = 100
			gridViewTextBoxColumn3.Name = "File"
			gridViewTextBoxColumn3.ReadOnly = True
			gridViewTextBoxColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
			gridViewTextBoxColumn3.Width = 100
			gridViewTextBoxColumn4.AllowGroup = False
			gridViewTextBoxColumn4.FieldName = "Line"
			gridViewTextBoxColumn4.HeaderText = "Line"
			gridViewTextBoxColumn4.MaxWidth = 80
			gridViewTextBoxColumn4.MinWidth = 80
			gridViewTextBoxColumn4.Name = "Line"
			gridViewTextBoxColumn4.ReadOnly = True
			gridViewTextBoxColumn4.Width = 80
			Me.radGridViewTasks.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewTextBoxColumn4})
			sortDescriptor1.PropertyName = "File"
			Me.radGridViewTasks.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() { sortDescriptor1})
			Me.radGridViewTasks.MasterTemplate.ViewDefinition = tableViewDefinition1
			Me.radGridViewTasks.Name = "radGridViewTasks"
			Me.radGridViewTasks.ReadOnly = True
			Me.radGridViewTasks.RightToLeft = RightToLeft.No
			Me.radGridViewTasks.ShowGroupPanel = False
			Me.radGridViewTasks.Size = New Size(790, 134)
			Me.radGridViewTasks.TabIndex = 1
			' 
			' radPanel2
			' 
			Me.radPanel2.Controls.Add(Me.radComboBox1)
			Me.radPanel2.Dock = DockStyle.Top
			Me.radPanel2.Location = New Point(0, 0)
			Me.radPanel2.Name = "radPanel2"
			Me.radPanel2.Size = New Size(790, 28)
			Me.radPanel2.TabIndex = 0
			' 
			' radComboBox1
			' 
			Me.radComboBox1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboBox1.FormatString = "{0}"
			radListDataItem25.Text = "User Tasks"
			radListDataItem26.Text = "Comments"
			Me.radComboBox1.Items.Add(radListDataItem25)
			Me.radComboBox1.Items.Add(radListDataItem26)
			Me.radComboBox1.Location = New Point(3, 3)
			Me.radComboBox1.Name = "radComboBox1"
			' 
			' 
			' 
			Me.radComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboBox1.Size = New Size(162, 20)
			Me.radComboBox1.TabIndex = 0
			Me.radComboBox1.Text = "Comments"
			' 
			' toolWindow5
			' 
			Me.toolWindow5.Caption = Nothing
			Me.toolWindow5.Controls.Add(Me.radGridViewErrors)
			Me.toolWindow5.Controls.Add(Me.radPanel1)
			Me.toolWindow5.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.toolWindow5.Location = New Point(1, 17)
			Me.toolWindow5.Name = "toolWindow5"
			Me.toolWindow5.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
			Me.toolWindow5.Size = New Size(790, 162)
			Me.toolWindow5.Text = "Error List"
			' 
			' radGridViewErrors
			' 
			Me.radGridViewErrors.BackColor = Color.FromArgb((CInt((CByte(191)))), (CInt((CByte(219)))), (CInt((CByte(254)))))
			Me.radGridViewErrors.Cursor = Cursors.Arrow
			Me.radGridViewErrors.Dock = DockStyle.Fill
			Me.radGridViewErrors.ForeColor = SystemColors.ControlText
			Me.radGridViewErrors.ImeMode = ImeMode.NoControl
			Me.radGridViewErrors.Location = New Point(0, 31)
			' 
			' 
			' 
			Me.radGridViewErrors.MasterTemplate.AllowAddNewRow = False
			Me.radGridViewErrors.MasterTemplate.AllowColumnReorder = False
			gridViewImageColumn1.FieldName = "columnImage"
			gridViewImageColumn1.HeaderText = "columnImage"
			gridViewImageColumn1.MaxWidth = 20
			gridViewImageColumn1.MinWidth = 20
			gridViewImageColumn1.Name = "columnImage"
			gridViewImageColumn1.Width = 20
			gridViewTextBoxColumn5.AllowGroup = False
			gridViewTextBoxColumn5.FieldName = "columnNumber"
			gridViewTextBoxColumn5.HeaderText = "columnNumber"
			gridViewTextBoxColumn5.MaxWidth = 20
			gridViewTextBoxColumn5.MinWidth = 20
			gridViewTextBoxColumn5.Name = "columnNumber"
			gridViewTextBoxColumn5.ReadOnly = True
			gridViewTextBoxColumn5.Width = 20
			gridViewTextBoxColumn6.AllowGroup = False
			gridViewTextBoxColumn6.FieldName = "Description"
			gridViewTextBoxColumn6.HeaderText = "Description"
			gridViewTextBoxColumn6.Name = "Description"
			gridViewTextBoxColumn6.ReadOnly = True
			gridViewTextBoxColumn6.Width = 200
			gridViewTextBoxColumn7.AllowGroup = False
			gridViewTextBoxColumn7.FieldName = "File"
			gridViewTextBoxColumn7.HeaderText = "File"
			gridViewTextBoxColumn7.MaxWidth = 80
			gridViewTextBoxColumn7.MinWidth = 80
			gridViewTextBoxColumn7.Name = "File"
			gridViewTextBoxColumn7.ReadOnly = True
			gridViewTextBoxColumn7.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
			gridViewTextBoxColumn7.Width = 80
			gridViewTextBoxColumn8.AllowGroup = False
			gridViewTextBoxColumn8.FieldName = "Line"
			gridViewTextBoxColumn8.HeaderText = "Line"
			gridViewTextBoxColumn8.MaxWidth = 50
			gridViewTextBoxColumn8.MinWidth = 50
			gridViewTextBoxColumn8.Name = "Line"
			gridViewTextBoxColumn8.ReadOnly = True
			gridViewTextBoxColumn9.AllowGroup = False
			gridViewTextBoxColumn9.FieldName = "Column"
			gridViewTextBoxColumn9.HeaderText = "Column"
			gridViewTextBoxColumn9.MaxWidth = 96
			gridViewTextBoxColumn9.MinWidth = 96
			gridViewTextBoxColumn9.Name = "Column"
			gridViewTextBoxColumn9.ReadOnly = True
			gridViewTextBoxColumn9.Width = 96
			gridViewTextBoxColumn10.AllowGroup = False
			gridViewTextBoxColumn10.FieldName = "Project"
			gridViewTextBoxColumn10.HeaderText = "Project"
			gridViewTextBoxColumn10.MaxWidth = 104
			gridViewTextBoxColumn10.MinWidth = 104
			gridViewTextBoxColumn10.Name = "Project"
			gridViewTextBoxColumn10.ReadOnly = True
			gridViewTextBoxColumn10.Width = 104
			Me.radGridViewErrors.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewImageColumn1, gridViewTextBoxColumn5, gridViewTextBoxColumn6, gridViewTextBoxColumn7, gridViewTextBoxColumn8, gridViewTextBoxColumn9, gridViewTextBoxColumn10})
			sortDescriptor2.PropertyName = "File"
			Me.radGridViewErrors.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() { sortDescriptor2})
			Me.radGridViewErrors.MasterTemplate.ViewDefinition = tableViewDefinition2
			Me.radGridViewErrors.Name = "radGridViewErrors"
			Me.radGridViewErrors.ReadOnly = True
			Me.radGridViewErrors.RightToLeft = RightToLeft.No
			Me.radGridViewErrors.ShowGroupPanel = False
			Me.radGridViewErrors.Size = New Size(790, 131)
			Me.radGridViewErrors.TabIndex = 1
			' 
			' radPanel1
			' 
			Me.radPanel1.Controls.Add(Me.radButton3)
			Me.radPanel1.Controls.Add(Me.radButton2)
			Me.radPanel1.Controls.Add(Me.radButton1)
			Me.radPanel1.Dock = DockStyle.Top
			Me.radPanel1.Location = New Point(0, 0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(790, 31)
			Me.radPanel1.TabIndex = 0
			' 
			' radButton3
			' 
			Me.radButton3.ImageIndex = 13
			Me.radButton3.ImageKey = "vss_Information.png"
			Me.radButton3.ImageList = Me.ImageList1
			Me.radButton3.Location = New Point(165, 3)
			Me.radButton3.Name = "radButton3"
			Me.radButton3.Size = New Size(83, 23)
			Me.radButton3.TabIndex = 2
			Me.radButton3.Text = "0 Messages"
			Me.radButton3.TextAlignment = ContentAlignment.MiddleLeft
			Me.radButton3.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radButton2
			' 
			Me.radButton2.ImageIndex = 12
			Me.radButton2.ImageList = Me.ImageList1
			Me.radButton2.Location = New Point(78, 3)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New Size(81, 23)
			Me.radButton2.TabIndex = 1
			Me.radButton2.Text = "0 Warnings"
			Me.radButton2.TextAlignment = ContentAlignment.MiddleLeft
			Me.radButton2.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' radButton1
			' 
			Me.radButton1.ImageIndex = 11
			Me.radButton1.ImageList = Me.ImageList1
			Me.radButton1.Location = New Point(11, 3)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(61, 23)
			Me.radButton1.TabIndex = 0
			Me.radButton1.Text = "1 Error"
			Me.radButton1.TextAlignment = ContentAlignment.MiddleLeft
			Me.radButton1.TextImageRelation = TextImageRelation.ImageBeforeText
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(1115, 755)
			Me.Controls.Add(Me.radDock1)
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "Telerik Studio"
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radDock1.ResumeLayout(False)
			Me.toolWindow1.ResumeLayout(False)
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer1.ResumeLayout(False)
			CType(Me.toolTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip3.ResumeLayout(False)
			CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toolTabStrip4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip4.ResumeLayout(False)
			Me.toolWindow2.ResumeLayout(False)
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toolTabStrip5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip5.ResumeLayout(False)
			Me.toolWindow3.ResumeLayout(False)
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel3.ResumeLayout(False)
			CType(Me.richTextBoxOutput, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolWindow4.ResumeLayout(False)
			CType(Me.radGridViewTasks.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridViewTasks, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel2.ResumeLayout(False)
			Me.radPanel2.PerformLayout()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolWindow5.ResumeLayout(False)
			CType(Me.radGridViewErrors.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridViewErrors, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radDock1 As Telerik.WinControls.UI.Docking.RadDock
		Private toolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
		Private documentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
		Private toolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
		Private toolWindow5 As Telerik.WinControls.UI.Docking.ToolWindow
		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private toolTabStrip3 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolTabStrip4 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolTabStrip5 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow3 As Telerik.WinControls.UI.Docking.ToolWindow
		Private toolWindow4 As Telerik.WinControls.UI.Docking.ToolWindow
		Private radListBox1 As Telerik.WinControls.UI.RadListControl
		Private ImageList1 As ImageList
		Private richTextBoxOutput As Telerik.WinControls.UI.RadTextBoxControl
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radButton3 As Telerik.WinControls.UI.RadButton
		Private radButton2 As Telerik.WinControls.UI.RadButton
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radGridViewErrors As Telerik.WinControls.UI.RadGridView
		Private radGridViewTasks As Telerik.WinControls.UI.RadGridView
		Private radPanel2 As Telerik.WinControls.UI.RadPanel
		Private radComboBox1 As Telerik.WinControls.UI.RadDropDownList
		Private WithEvents radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private radPanel3 As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace

