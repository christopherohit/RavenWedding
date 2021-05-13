Namespace Telerik.Examples.WinControls.TreeView.XMLSerialization
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
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			Me.btnAddRoot = New Telerik.WinControls.UI.RadButton()
			Me.btnAddChild = New Telerik.WinControls.UI.RadButton()
			Me.btnLoadFile = New Telerik.WinControls.UI.RadButton()
			Me.btnSaveFile = New Telerik.WinControls.UI.RadButton()
			Me.btnRemove = New Telerik.WinControls.UI.RadButton()
			Me.radGroupNodeOpts = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupXml = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnAddRoot, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnAddChild, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnLoadFile, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnSaveFile, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnRemove, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupNodeOpts, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupNodeOpts.SuspendLayout()
			CType(Me.radGroupXml, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupXml.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupXml)
			Me.settingsPanel.Controls.Add(Me.radGroupNodeOpts)
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(200, 735)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupNodeOpts, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupXml, 0)
			' 
			' radTreeView1
			' 
			Me.radTreeView1.AllowDragDrop = True
			Me.radTreeView1.AllowEdit = True
			Me.radTreeView1.Dock = DockStyle.Left
			Me.radTreeView1.Location = New Point(0, 0)
			Me.radTreeView1.Name = "radTreeView1"
			radTreeNode1.Expanded = True
			radTreeNode2.Expanded = True
			radTreeNode3.Text = "Node15"
			radTreeNode4.Text = "Node16"
			radTreeNode2.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode3, radTreeNode4})
			radTreeNode2.Text = "Node7"
			radTreeNode5.Expanded = True
			radTreeNode6.Text = "Node14"
			radTreeNode5.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode6})
			radTreeNode5.Text = "Node8"
			radTreeNode7.Text = "Node9"
			radTreeNode1.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode2, radTreeNode5, radTreeNode7})
			radTreeNode1.Text = "Node1"
			radTreeNode8.Expanded = True
			radTreeNode9.Text = "Node10"
			radTreeNode10.Text = "Node11"
			radTreeNode8.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode9, radTreeNode10})
			radTreeNode8.Text = "Node2"
			radTreeNode11.Text = "Node3"
			radTreeNode12.Expanded = True
			radTreeNode13.Text = "Node12"
			radTreeNode14.Text = "Node13"
			radTreeNode12.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode13, radTreeNode14})
			radTreeNode12.Text = "Node4"
			radTreeNode15.Text = "Node5"
			radTreeNode16.Text = "Node6"
			Me.radTreeView1.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode1, radTreeNode8, radTreeNode11, radTreeNode12, radTreeNode15, radTreeNode16})
			Me.radTreeView1.Size = New Size(290, 752)
			Me.radTreeView1.SpacingBetweenNodes = -1
			Me.radTreeView1.TabIndex = 0
			Me.radTreeView1.Text = "radTreeView1"
			' 
			' btnAddRoot
			' 
			Me.btnAddRoot.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.btnAddRoot.Location = New Point(14, 31)
			Me.btnAddRoot.Name = "btnAddRoot"
			Me.btnAddRoot.Size = New Size(153, 23)
			Me.btnAddRoot.TabIndex = 1
			Me.btnAddRoot.Text = "Add Root Node"

			' 
			' btnAddChild
			' 
			Me.btnAddChild.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.btnAddChild.Location = New Point(14, 60)
			Me.btnAddChild.Name = "btnAddChild"
			Me.btnAddChild.Size = New Size(153, 23)
			Me.btnAddChild.TabIndex = 2
			Me.btnAddChild.Text = "Add Child Node"

			' 
			' btnLoadFile
			' 
			Me.btnLoadFile.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.btnLoadFile.Location = New Point(14, 28)
			Me.btnLoadFile.Name = "btnLoadFile"
			Me.btnLoadFile.Size = New Size(153, 23)
			Me.btnLoadFile.TabIndex = 3
			Me.btnLoadFile.Text = "Load XML File"

			' 
			' btnSaveFile
			' 
			Me.btnSaveFile.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.btnSaveFile.Location = New Point(14, 57)
			Me.btnSaveFile.Name = "btnSaveFile"
			Me.btnSaveFile.Size = New Size(153, 23)
			Me.btnSaveFile.TabIndex = 4
			Me.btnSaveFile.Text = "Save XML File"

			' 
			' btnRemove
			' 
			Me.btnRemove.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.btnRemove.Location = New Point(14, 89)
			Me.btnRemove.Name = "btnRemove"
			Me.btnRemove.Size = New Size(153, 23)
			Me.btnRemove.TabIndex = 5
			Me.btnRemove.Text = "Remove Selected Node"

			' 
			' radGroupNodeOpts
			' 
			Me.radGroupNodeOpts.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupNodeOpts.Anchor = AnchorStyles.Top
			Me.radGroupNodeOpts.Controls.Add(Me.btnAddRoot)
			Me.radGroupNodeOpts.Controls.Add(Me.btnRemove)
			Me.radGroupNodeOpts.Controls.Add(Me.btnAddChild)
			Me.radGroupNodeOpts.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupNodeOpts.HeaderText = "Node Actions"
			Me.radGroupNodeOpts.Location = New Point(10, 6)
			Me.radGroupNodeOpts.Name = "radGroupNodeOpts"
			Me.radGroupNodeOpts.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupNodeOpts.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupNodeOpts.Size = New Size(180, 125)
			Me.radGroupNodeOpts.TabIndex = 0
			Me.radGroupNodeOpts.Text = "Node Actions"
			' 
			' radGroupXml
			' 
			Me.radGroupXml.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupXml.Anchor = AnchorStyles.Top
			Me.radGroupXml.Controls.Add(Me.btnLoadFile)
			Me.radGroupXml.Controls.Add(Me.btnSaveFile)
			Me.radGroupXml.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupXml.HeaderText = "XML Actions"
			Me.radGroupXml.Location = New Point(10, 151)
			Me.radGroupXml.Name = "radGroupXml"
			Me.radGroupXml.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupXml.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupXml.Size = New Size(180, 95)
			Me.radGroupXml.TabIndex = 1
			Me.radGroupXml.Text = "XML Actions"
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.radTreeView1)
			Me.Name = "Form1"
			Me.Size = New Size(1028, 762)
			Me.Controls.SetChildIndex(Me.radTreeView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnAddRoot, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnAddChild, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnLoadFile, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnSaveFile, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnRemove, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupNodeOpts, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupNodeOpts.ResumeLayout(False)
			CType(Me.radGroupXml, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupXml.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private btnAddRoot As Telerik.WinControls.UI.RadButton
		Private btnAddChild As Telerik.WinControls.UI.RadButton
		Private btnLoadFile As Telerik.WinControls.UI.RadButton
		Private btnSaveFile As Telerik.WinControls.UI.RadButton
		Private btnRemove As Telerik.WinControls.UI.RadButton
		Private radGroupXml As Telerik.WinControls.UI.RadGroupBox
		Private radGroupNodeOpts As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace