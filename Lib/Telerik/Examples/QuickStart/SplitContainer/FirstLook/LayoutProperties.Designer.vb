Namespace Telerik.Examples.WinControls.SplitContainer.FirstLook
	Partial Public Class LayoutProperties
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
			Dim radTreeNode1 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode2 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode3 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode4 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode5 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode6 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode7 As New Telerik.WinControls.UI.RadTreeNode()
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			Me.splitContainerLayout = New Telerik.WinControls.UI.RadPanel()
			Me.radioVertical = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioHorizontal = New Telerik.WinControls.UI.RadRadioButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.splitPanelLayout = New Telerik.WinControls.UI.RadPanel()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.checkCollapsed = New Telerik.WinControls.UI.RadCheckBox()
			Me.checkFixed = New Telerik.WinControls.UI.RadCheckBox()
			Me.splitterLayout = New Telerik.WinControls.UI.RadPanel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.checkSplitterFixed = New Telerik.WinControls.UI.RadCheckBox()
			Me.initialPanel = New Telerik.WinControls.UI.RadPanel()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitContainerLayout, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerLayout.SuspendLayout()
			CType(Me.radioVertical, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioHorizontal, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitPanelLayout, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanelLayout.SuspendLayout()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkCollapsed, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkFixed, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitterLayout, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitterLayout.SuspendLayout()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkSplitterFixed, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.initialPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radTreeView1
			' 
			Me.radTreeView1.Cursor = Cursors.Default
			Me.radTreeView1.Dock = DockStyle.Left
			Me.radTreeView1.Font = New Font("Tahoma", 8.6F)
			Me.radTreeView1.Location = New Point(0, 0)
			Me.radTreeView1.Name = "radTreeView1"
			radTreeNode1.Expanded = True
			radTreeNode2.Text = "SplitPanel1"
			radTreeNode3.Text = "SplitPanel2"
			radTreeNode4.Expanded = True
			radTreeNode5.Expanded = True
			radTreeNode6.Text = "SplitPanel4"
			radTreeNode7.Text = "SplitPanel5"
			radTreeNode5.Nodes.Add(radTreeNode6)
			radTreeNode5.Nodes.Add(radTreeNode7)
			radTreeNode5.Text = "RadSplitContainer2"
			radTreeNode4.Nodes.Add(radTreeNode5)
			radTreeNode4.Text = "SplitPanel3"
			radTreeNode1.Nodes.Add(radTreeNode2)
			radTreeNode1.Nodes.Add(radTreeNode3)
			radTreeNode1.Nodes.Add(radTreeNode4)
			radTreeNode1.Text = "RadSplitContainer1"
			Me.radTreeView1.Nodes.Add(radTreeNode1)
			Me.radTreeView1.RightToLeft = RightToLeft.No
			Me.radTreeView1.Size = New Size(195, 211)
			Me.radTreeView1.TabIndex = 0
			Me.radTreeView1.Text = "radTreeView1"
			' 
			' splitContainerLayout
			' 
			Me.splitContainerLayout.Controls.Add(Me.radioVertical)
			Me.splitContainerLayout.Controls.Add(Me.radioHorizontal)
			Me.splitContainerLayout.Controls.Add(Me.radLabel1)
			Me.splitContainerLayout.Dock = DockStyle.Fill
			Me.splitContainerLayout.Location = New Point(195, 0)
			Me.splitContainerLayout.Name = "splitContainerLayout"
			Me.splitContainerLayout.Size = New Size(165, 211)
			Me.splitContainerLayout.TabIndex = 1
			CType(Me.splitContainerLayout.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			' 
			' radioVertical
			' 
			Me.radioVertical.Location = New Point(76, 12)
			Me.radioVertical.Name = "radioVertical"
			Me.radioVertical.Size = New Size(58, 18)
			Me.radioVertical.TabIndex = 2
			Me.radioVertical.Text = "Vertical"
			' 
			' radioHorizontal
			' 
			Me.radioHorizontal.Location = New Point(76, 35)
			Me.radioHorizontal.Name = "radioHorizontal"
			Me.radioHorizontal.Size = New Size(75, 18)
			Me.radioHorizontal.TabIndex = 1
			Me.radioHorizontal.Text = "Horizontal"
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(7, 13)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(63, 14)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Orientation:"
			Me.radLabel1.TextWrap = True
			' 
			' splitPanelLayout
			' 
			Me.splitPanelLayout.Controls.Add(Me.radLabel4)
			Me.splitPanelLayout.Controls.Add(Me.radLabel3)
			Me.splitPanelLayout.Controls.Add(Me.checkCollapsed)
			Me.splitPanelLayout.Controls.Add(Me.checkFixed)
			Me.splitPanelLayout.Dock = DockStyle.Fill
			Me.splitPanelLayout.Location = New Point(195, 0)
			Me.splitPanelLayout.Name = "splitPanelLayout"
			Me.splitPanelLayout.Size = New Size(165, 211)
			Me.splitPanelLayout.TabIndex = 3
			CType(Me.splitPanelLayout.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			' 
			' radLabel4
			' 
			Me.radLabel4.Location = New Point(4, 141)
			Me.radLabel4.MaximumSize = New Size(160, 0)
			Me.radLabel4.Name = "radLabel4"
			' 
			' 
			' 
			Me.radLabel4.RootElement.MaxSize = New Size(160, 0)
			Me.radLabel4.Size = New Size(160, 42)
			Me.radLabel4.TabIndex = 3
			Me.radLabel4.Text = "- When a SplitPanel is Collapsed, it is hidden from view"
			Me.radLabel4.TextWrap = True
			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New Point(4, 78)
			Me.radLabel3.MaximumSize = New Size(160, 0)
			Me.radLabel3.Name = "radLabel3"
			' 
			' 
			' 
			Me.radLabel3.RootElement.MaxSize = New Size(160, 0)
			Me.radLabel3.Size = New Size(160, 56)
			Me.radLabel3.TabIndex = 2
			Me.radLabel3.Text = "- When a SplitPanel is Fixed, it is not resized when the form is resized"
			Me.radLabel3.TextWrap = True
			' 
			' checkCollapsed
			' 
			Me.checkCollapsed.Location = New Point(11, 38)
			Me.checkCollapsed.Name = "checkCollapsed"
			Me.checkCollapsed.Size = New Size(100, 18)
			Me.checkCollapsed.TabIndex = 1
			Me.checkCollapsed.Text = "Collapsed"
			' 
			' checkFixed
			' 
			Me.checkFixed.Location = New Point(11, 13)
			Me.checkFixed.Name = "checkFixed"
			Me.checkFixed.Size = New Size(100, 18)
			Me.checkFixed.TabIndex = 0
			Me.checkFixed.Text = "Fixed"
			' 
			' splitterLayout
			' 
			Me.splitterLayout.Controls.Add(Me.radLabel2)
			Me.splitterLayout.Controls.Add(Me.checkSplitterFixed)
			Me.splitterLayout.Dock = DockStyle.Fill
			Me.splitterLayout.Location = New Point(195, 0)
			Me.splitterLayout.Name = "splitterLayout"
			Me.splitterLayout.Size = New Size(165, 211)
			Me.splitterLayout.TabIndex = 2
			CType(Me.splitterLayout.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New Point(3, 41)
			Me.radLabel2.MaximumSize = New Size(160, 0)
			Me.radLabel2.Name = "radLabel2"
			' 
			' 
			' 
			Me.radLabel2.RootElement.MaxSize = New Size(160, 0)
			Me.radLabel2.Size = New Size(160, 42)
			Me.radLabel2.TabIndex = 1
			Me.radLabel2.Text = "- When a Splitter is Fixed, it cannot be dragged and moved"
			Me.radLabel2.TextWrap = True
			' 
			' checkSplitterFixed
			' 
			Me.checkSplitterFixed.Location = New Point(11, 13)
			Me.checkSplitterFixed.Name = "checkSplitterFixed"
			Me.checkSplitterFixed.Size = New Size(100, 18)
			Me.checkSplitterFixed.TabIndex = 0
			Me.checkSplitterFixed.Text = "Fixed"
			' 
			' initialPanel
			' 
			Me.initialPanel.Dock = DockStyle.Fill
			Me.initialPanel.Location = New Point(195, 0)
			Me.initialPanel.Name = "initialPanel"
			Me.initialPanel.Size = New Size(165, 211)
			Me.initialPanel.TabIndex = 3
			Me.initialPanel.Text = "Select an element"
			CType(Me.initialPanel.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "Select an element"
			CType(Me.initialPanel.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			CType(Me.initialPanel.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Alignment = ContentAlignment.MiddleCenter
			' 
			' LayoutProperties
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.ClientSize = New Size(360, 211)
			Me.Controls.Add(Me.initialPanel)
			Me.Controls.Add(Me.splitterLayout)
			Me.Controls.Add(Me.splitPanelLayout)
			Me.Controls.Add(Me.splitContainerLayout)
			Me.Controls.Add(Me.radTreeView1)
			Me.FormBorderStyle = FormBorderStyle.FixedSingle
			Me.Name = "LayoutProperties"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "Layout Properties"
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitContainerLayout, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerLayout.ResumeLayout(False)
			Me.splitContainerLayout.PerformLayout()
			CType(Me.radioVertical, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioHorizontal, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitPanelLayout, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanelLayout.ResumeLayout(False)
			Me.splitPanelLayout.PerformLayout()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkCollapsed, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkFixed, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitterLayout, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitterLayout.ResumeLayout(False)
			Me.splitterLayout.PerformLayout()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkSplitterFixed, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.initialPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private splitContainerLayout As Telerik.WinControls.UI.RadPanel
		Private splitPanelLayout As Telerik.WinControls.UI.RadPanel
		Private radioVertical As Telerik.WinControls.UI.RadRadioButton
		Private radioHorizontal As Telerik.WinControls.UI.RadRadioButton
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private splitterLayout As Telerik.WinControls.UI.RadPanel
		Private checkSplitterFixed As Telerik.WinControls.UI.RadCheckBox
		Private checkCollapsed As Telerik.WinControls.UI.RadCheckBox
		Private checkFixed As Telerik.WinControls.UI.RadCheckBox
		Private initialPanel As Telerik.WinControls.UI.RadPanel
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace