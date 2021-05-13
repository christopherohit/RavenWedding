Namespace Telerik.Examples.WinControls.TreeView.Customize.ContextMenus
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
			Me.radContextMenu1 = New Telerik.WinControls.UI.RadContextMenu(Me.components)
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.imageList1 = New ImageList(Me.components)
			Me.radTreeViewDemo = New Telerik.WinControls.UI.RadTreeView()
			Me.radGroupInfoPane = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLblSelectedItem = New Telerik.WinControls.UI.RadLabel()
			Me.radLblItem = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLblSelectedNode = New Telerik.WinControls.UI.RadLabel()
			Me.radLblNode = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radTreeViewDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupInfoPane, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupInfoPane.SuspendLayout()
			CType(Me.radLblSelectedItem, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblItem, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblSelectedNode, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblNode, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupInfoPane)
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupInfoPane, 0)
			' 
			' radContextMenu1
			' 
			Me.radContextMenu1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem4, Me.radMenuItem5})
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.AccessibleDescription = "Edit"
			Me.radMenuItem1.AccessibleName = "Edit"
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Text = "Edit"
			Me.radMenuItem1.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.AccessibleDescription = "Disable"
			Me.radMenuItem2.AccessibleName = "Disable"
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Text = "Disable"
			Me.radMenuItem2.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.AccessibleDescription = "Delete Node"
			Me.radMenuItem4.AccessibleName = "Delete Node"
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Text = "Delete Node"
			Me.radMenuItem4.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.AccessibleDescription = "New Folder"
			Me.radMenuItem5.AccessibleName = "New Folder"
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.Text = "New Folder"
			Me.radMenuItem5.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.AccessibleDescription = "Copy node(Clone)"
			Me.radMenuItem3.AccessibleName = "Copy node(Clone)"
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Text = "Copy node(Clone)"
			Me.radMenuItem3.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Fuchsia
			Me.imageList1.Images.SetKeyName(0, "0_Personal_Folders.gif")
			Me.imageList1.Images.SetKeyName(1, "1_Deleted_Items.gif")
			Me.imageList1.Images.SetKeyName(2, "2_Drafts.gif")
			Me.imageList1.Images.SetKeyName(3, "3_Inbox.gif")
			Me.imageList1.Images.SetKeyName(4, "4_Junk_E-mail.gif")
			Me.imageList1.Images.SetKeyName(5, "5_Outbox.gif")
			Me.imageList1.Images.SetKeyName(6, "6_Rss_Feeds.gif")
			Me.imageList1.Images.SetKeyName(7, "7_Sent_Items.gif")
			Me.imageList1.Images.SetKeyName(8, "8.1_Search.gif")
			Me.imageList1.Images.SetKeyName(9, "8_Search.gif")
			' 
			' radTreeViewDemo
			' 
			Me.radTreeViewDemo.Cursor = Cursors.Default
			Me.radTreeViewDemo.Dock = DockStyle.Left
			Me.radTreeViewDemo.ImageList = Me.imageList1
			Me.radTreeViewDemo.ItemHeight = 27
			Me.radTreeViewDemo.Location = New Point(0, 0)
			Me.radTreeViewDemo.Name = "radTreeViewDemo"
			radTreeNode1.ContextMenu = Me.radContextMenu1
			radTreeNode1.Expanded = True
			radTreeNode1.Image = (CType(resources.GetObject("radTreeNode1.Image"), Image))
			radTreeNode1.ImageIndex = 0
			radTreeNode2.ContextMenu = Me.radContextMenu1
			radTreeNode2.Image = (CType(resources.GetObject("radTreeNode2.Image"), Image))
			radTreeNode2.ImageIndex = 1
			radTreeNode2.Text = "Deleted Items(6)"
			radTreeNode3.ContextMenu = Me.radContextMenu1
			radTreeNode3.Image = (CType(resources.GetObject("radTreeNode3.Image"), Image))
			radTreeNode3.ImageKey = "2_Drafts.gif"
			radTreeNode3.Text = "Drafts"
			radTreeNode4.ContextMenu = Me.radContextMenu1
			radTreeNode4.Image = (CType(resources.GetObject("radTreeNode4.Image"), Image))
			radTreeNode4.ImageIndex = 3
			radTreeNode4.Text = "Invoices"
			radTreeNode5.ContextMenu = Me.radContextMenu1
			radTreeNode5.Image = (CType(resources.GetObject("radTreeNode5.Image"), Image))
			radTreeNode5.ImageKey = "5_Outbox.gif"
			radTreeNode5.Text = "Junk e-mail"
			radTreeNode6.ContextMenu = Me.radContextMenu1
			radTreeNode6.Image = (CType(resources.GetObject("radTreeNode6.Image"), Image))
			radTreeNode6.ImageIndex = 5
			radTreeNode6.Text = "OutBox"
			radTreeNode7.ContextMenu = Me.radContextMenu1
			radTreeNode7.Expanded = True
			radTreeNode7.Image = (CType(resources.GetObject("radTreeNode7.Image"), Image))
			radTreeNode7.ImageKey = "7_Sent_Items.gif"
			radTreeNode7.Text = "Sent Items"
			radTreeNode8.ContextMenu = Me.radContextMenu1
			radTreeNode8.Expanded = True
			radTreeNode8.Image = (CType(resources.GetObject("radTreeNode8.Image"), Image))
			radTreeNode8.ImageKey = "8_Search.gif"
			radTreeNode9.ContextMenu = Me.radContextMenu1
			radTreeNode9.Image = (CType(resources.GetObject("radTreeNode9.Image"), Image))
			radTreeNode9.ImageKey = "8.1_Search.gif"
			radTreeNode9.Text = "Form Follow Up"
			radTreeNode10.ContextMenu = Me.radContextMenu1
			radTreeNode10.Image = (CType(resources.GetObject("radTreeNode10.Image"), Image))
			radTreeNode10.ImageKey = "8.1_Search.gif"
			radTreeNode10.Text = "Large Mail"
			radTreeNode11.ContextMenu = Me.radContextMenu1
			radTreeNode11.Image = (CType(resources.GetObject("radTreeNode11.Image"), Image))
			radTreeNode11.ImageKey = "8.1_Search.gif"
			radTreeNode11.Text = "Unread Mail"
			radTreeNode8.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode9, radTreeNode10, radTreeNode11})
			radTreeNode8.Text = "Search Folders"
			radTreeNode1.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode2, radTreeNode3, radTreeNode4, radTreeNode5, radTreeNode6, radTreeNode7, radTreeNode8})
			radTreeNode1.Text = "Personal Folders"
			Me.radTreeViewDemo.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode1})
			Me.radTreeViewDemo.Size = New Size(246, 506)
			Me.radTreeViewDemo.SpacingBetweenNodes = -1
			Me.radTreeViewDemo.TabIndex = 0
			Me.radTreeViewDemo.Text = "radTreeView1"
			' 
			' radGroupInfoPane
			' 
			Me.radGroupInfoPane.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupInfoPane.Controls.Add(Me.radLblSelectedItem)
			Me.radGroupInfoPane.Controls.Add(Me.radLblItem)
			Me.radGroupInfoPane.Controls.Add(Me.radLabel2)
			Me.radGroupInfoPane.Controls.Add(Me.radLblSelectedNode)
			Me.radGroupInfoPane.Controls.Add(Me.radLblNode)
			Me.radGroupInfoPane.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupInfoPane.HeaderText = " Info Pane "
			Me.radGroupInfoPane.Location = New Point(15, 6)
			Me.radGroupInfoPane.Name = "radGroupInfoPane"
			' 
			' 
			' 
			Me.radGroupInfoPane.RootElement.Padding = New Padding(2, 18, 2, 2)
			Me.radGroupInfoPane.Size = New Size(162, 100)
			Me.radGroupInfoPane.TabIndex = 0
			Me.radGroupInfoPane.Text = " Info Pane "
			' 
			' radLblSelectedItem
			' 
			Me.radLblSelectedItem.ForeColor = Color.Red
			Me.radLblSelectedItem.Location = New Point(4, 74)
			Me.radLblSelectedItem.Name = "radLblSelectedItem"
			Me.radLblSelectedItem.Size = New Size(55, 18)
			Me.radLblSelectedItem.TabIndex = 1
			Me.radLblSelectedItem.Text = "radLabel2"
			' 
			' radLblItem
			' 
			Me.radLblItem.Location = New Point(4, 56)
			Me.radLblItem.Name = "radLblItem"
			Me.radLblItem.Size = New Size(119, 18)
			Me.radLblItem.TabIndex = 1
			Me.radLblItem.Text = "Context Item Selected:"
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New Point(3, 58)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(55, 18)
			Me.radLabel2.TabIndex = 1
			Me.radLabel2.Text = "radLabel2"
			' 
			' radLblSelectedNode
			' 
			Me.radLblSelectedNode.ForeColor = Color.Red
			Me.radLblSelectedNode.Location = New Point(4, 36)
			Me.radLblSelectedNode.Name = "radLblSelectedNode"
			Me.radLblSelectedNode.Size = New Size(55, 18)
			Me.radLblSelectedNode.TabIndex = 0
			Me.radLblSelectedNode.Text = "radLabel1"
			' 
			' radLblNode
			' 
			Me.radLblNode.Location = New Point(4, 20)
			Me.radLblNode.Name = "radLblNode"
			Me.radLblNode.Size = New Size(82, 18)
			Me.radLblNode.TabIndex = 0
			Me.radLblNode.Text = "Node Selected:"
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radTreeViewDemo)
			Me.Name = "Form1"
			Me.Size = New Size(1288, 516)
			Me.Controls.SetChildIndex(Me.radTreeViewDemo, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radTreeViewDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupInfoPane, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupInfoPane.ResumeLayout(False)
			Me.radGroupInfoPane.PerformLayout()
			CType(Me.radLblSelectedItem, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblItem, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblSelectedNode, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblNode, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private imageList1 As ImageList
		Private radContextMenu1 As Telerik.WinControls.UI.RadContextMenu
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5 As Telerik.WinControls.UI.RadMenuItem
		Private radTreeViewDemo As Telerik.WinControls.UI.RadTreeView
		Private radGroupInfoPane As Telerik.WinControls.UI.RadGroupBox
		Private radLblSelectedItem As Telerik.WinControls.UI.RadLabel
		Private radLblItem As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLblSelectedNode As Telerik.WinControls.UI.RadLabel
		Private radLblNode As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace