Namespace Telerik.Examples.WinControls.TreeView.ManipulateData.OptionsTree
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

		#Region "Component Designer generated code"

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
			Dim radTreeNode17 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode18 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode19 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode20 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode21 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode22 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode23 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode24 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode25 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode26 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode27 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode28 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode29 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode30 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode31 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode32 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode33 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode34 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode35 As New Telerik.WinControls.UI.RadTreeNode()
			Me.headerPanel = New TreeExampleHeaderPanel()
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.rrbNone = New Telerik.WinControls.UI.RadRadioButton()
			Me.rrbShowRadioButton = New Telerik.WinControls.UI.RadRadioButton()
			Me.rrbShowCheckBox = New Telerik.WinControls.UI.RadRadioButton()
			Me.rcbTriState = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.headerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.rrbNone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rrbShowRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rrbShowCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rcbTriState, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.settingsPanel.BackColor = Color.Transparent
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Controls.Add(Me.rcbTriState)
			Me.settingsPanel.ForeColor = SystemColors.ControlText
			Me.settingsPanel.Location = New Point(990, 1)
			Me.settingsPanel.Size = New Size(340, 752)
			Me.settingsPanel.Controls.SetChildIndex(Me.rcbTriState, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' headerPanel
			' 
			Me.headerPanel.Location = New Point(0, 0)
			Me.headerPanel.Name = "headerPanel"
			Me.headerPanel.Size = New Size(200, 100)
			Me.headerPanel.TabIndex = 1
			' 
			' radTreeView1
			' 
			Me.radTreeView1.Cursor = Cursors.Default
			Me.radTreeView1.Dock = DockStyle.Left
			Me.radTreeView1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radTreeView1.Location = New Point(0, 0)
			Me.radTreeView1.Name = "radTreeView1"
			radTreeNode1.Name = "Node1"
			radTreeNode2.CheckType = Telerik.WinControls.UI.CheckType.RadioButton
			radTreeNode2.Name = "Node7"
			radTreeNode2.Text = "Lexus IS"
			radTreeNode3.CheckType = Telerik.WinControls.UI.CheckType.RadioButton
			radTreeNode3.Name = "Node8"
			radTreeNode3.Text = "BMW Touring"
			radTreeNode4.CheckType = Telerik.WinControls.UI.CheckType.RadioButton
			radTreeNode4.Name = "Node9"
			radTreeNode4.Text = "Mercedes-Benz CL"
			radTreeNode5.Checked = True
			radTreeNode5.CheckState = Telerik.WinControls.Enumerations.ToggleState.On
			radTreeNode5.CheckType = Telerik.WinControls.UI.CheckType.RadioButton
			radTreeNode5.Name = "Node10"
			radTreeNode5.Text = "Aston Martin DBS"
			radTreeNode1.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode2, radTreeNode3, radTreeNode4, radTreeNode5})
			radTreeNode1.Text = "Model"
			radTreeNode6.Name = "Node2"
			radTreeNode7.CheckType = Telerik.WinControls.UI.CheckType.RadioButton
			radTreeNode7.Name = "Node11"
			radTreeNode7.Text = "2.0L Petrol"
			radTreeNode8.CheckType = Telerik.WinControls.UI.CheckType.RadioButton
			radTreeNode8.Name = "Node12"
			radTreeNode8.Text = "3.5L Diesel"
			radTreeNode9.CheckType = Telerik.WinControls.UI.CheckType.RadioButton
			radTreeNode9.Name = "Node13"
			radTreeNode9.Text = "6.0L V12 "
			radTreeNode10.CheckType = Telerik.WinControls.UI.CheckType.RadioButton
			radTreeNode10.Name = "Node14"
			radTreeNode10.Text = "3.0 TDI"
			radTreeNode6.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode7, radTreeNode8, radTreeNode9, radTreeNode10})
			radTreeNode6.Text = "Engine"
			radTreeNode11.Name = "Node3"
			radTreeNode12.CheckType = Telerik.WinControls.UI.CheckType.CheckBox
			radTreeNode12.Name = "Node15"
			radTreeNode12.Text = "Alpine White"
			radTreeNode13.CheckType = Telerik.WinControls.UI.CheckType.CheckBox
			radTreeNode13.Name = "Node16"
			radTreeNode13.Text = "Graphite Black"
			radTreeNode14.Checked = True
			radTreeNode14.CheckState = Telerik.WinControls.Enumerations.ToggleState.On
			radTreeNode14.CheckType = Telerik.WinControls.UI.CheckType.CheckBox
			radTreeNode14.Name = "Node17"
			radTreeNode14.Text = "Sparkling Bronze"
			radTreeNode15.CheckType = Telerik.WinControls.UI.CheckType.CheckBox
			radTreeNode15.Name = "Node18"
			radTreeNode15.Text = "Pearl Silver Metallic"
			radTreeNode11.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode12, radTreeNode13, radTreeNode14, radTreeNode15})
			radTreeNode11.Text = "Exterior"
			radTreeNode16.Name = "Node4"
			radTreeNode17.CheckType = Telerik.WinControls.UI.CheckType.RadioButton
			radTreeNode17.Name = "Node19"
			radTreeNode18.CheckType = Telerik.WinControls.UI.CheckType.CheckBox
			radTreeNode18.Name = "Node21"
			radTreeNode18.Text = "Peluche"
			radTreeNode19.CheckType = Telerik.WinControls.UI.CheckType.CheckBox
			radTreeNode19.Name = "Node22"
			radTreeNode19.Text = "Cadiffe"
			radTreeNode20.CheckType = Telerik.WinControls.UI.CheckType.RadioButton
			radTreeNode20.Name = "Node23"
			radTreeNode20.Text = "Poliester"
			radTreeNode21.CheckType = Telerik.WinControls.UI.CheckType.RadioButton
			radTreeNode21.Name = "Node27"
			radTreeNode21.Text = "Wool"
			radTreeNode17.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode18, radTreeNode19, radTreeNode20, radTreeNode21})
			radTreeNode17.Text = "Textile"
			radTreeNode22.CheckType = Telerik.WinControls.UI.CheckType.RadioButton
			radTreeNode22.Name = "Node20"
			radTreeNode23.CheckType = Telerik.WinControls.UI.CheckType.RadioButton
			radTreeNode23.Name = "Node24"
			radTreeNode23.Text = "Oyster Nevada Leather"
			radTreeNode24.CheckType = Telerik.WinControls.UI.CheckType.RadioButton
			radTreeNode24.Name = "Node25"
			radTreeNode24.Text = "Black Exclusive Nappa Leather"
			radTreeNode25.CheckType = Telerik.WinControls.UI.CheckType.CheckBox
			radTreeNode25.Name = "Node26"
			radTreeNode25.Text = "Alcantara Leather"
			radTreeNode22.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode23, radTreeNode24, radTreeNode25})
			radTreeNode22.Text = "Leather"
			radTreeNode16.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode17, radTreeNode22})
			radTreeNode16.Text = "Interior"
			radTreeNode26.Name = "Node5"
			radTreeNode27.CheckType = Telerik.WinControls.UI.CheckType.RadioButton
			radTreeNode27.Name = "Node28"
			radTreeNode27.Text = "Media Package"
			radTreeNode28.CheckType = Telerik.WinControls.UI.CheckType.RadioButton
			radTreeNode28.Name = "Node29"
			radTreeNode28.Text = "Dynamic Package"
			radTreeNode26.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode27, radTreeNode28})
			radTreeNode26.Text = "Packages"
			radTreeNode29.Name = "Node6"
			radTreeNode30.CheckType = Telerik.WinControls.UI.CheckType.CheckBox
			radTreeNode30.Name = "Node30"
			radTreeNode30.Text = "DVD System"
			radTreeNode31.CheckType = Telerik.WinControls.UI.CheckType.CheckBox
			radTreeNode31.Name = "Node31"
			radTreeNode31.Text = "Head-up Display"
			radTreeNode32.CheckType = Telerik.WinControls.UI.CheckType.CheckBox
			radTreeNode32.Name = "Node32"
			radTreeNode32.Text = "Voice Control"
			radTreeNode33.CheckType = Telerik.WinControls.UI.CheckType.CheckBox
			radTreeNode33.Name = "Node33"
			radTreeNode33.Text = "BOSE Sound System"
			radTreeNode34.CheckType = Telerik.WinControls.UI.CheckType.CheckBox
			radTreeNode34.Name = "Node34"
			radTreeNode34.Text = "Navigation System"
			radTreeNode35.CheckType = Telerik.WinControls.UI.CheckType.CheckBox
			radTreeNode35.Name = "Node35"
			radTreeNode35.Text = "Universal Remote Control"
			radTreeNode29.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode30, radTreeNode31, radTreeNode32, radTreeNode33, radTreeNode34, radTreeNode35})
			radTreeNode29.Text = "Optional Equipment"
			Me.radTreeView1.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode1, radTreeNode6, radTreeNode11, radTreeNode16, radTreeNode26, radTreeNode29})
			Me.radTreeView1.RightToLeft = RightToLeft.No
			Me.radTreeView1.Size = New Size(324, 754)
			Me.radTreeView1.SpacingBetweenNodes = -1
			Me.radTreeView1.TabIndex = 2
			Me.radTreeView1.Text = "radTreeView1"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.rrbNone)
			Me.radGroupBox1.Controls.Add(Me.rrbShowRadioButton)
			Me.radGroupBox1.Controls.Add(Me.rrbShowCheckBox)
			Me.radGroupBox1.HeaderText = "Node Check Type"
			Me.radGroupBox1.Location = New Point(80, 77)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 100)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Node Check Type"
			' 
			' rrbNone
			' 
			Me.rrbNone.Location = New Point(22, 76)
			Me.rrbNone.Name = "rrbNone"
			Me.rrbNone.Size = New Size(48, 18)
			Me.rrbNone.TabIndex = 2
			Me.rrbNone.Text = "None"

			' 
			' rrbShowRadioButton
			' 
			Me.rrbShowRadioButton.Location = New Point(22, 51)
			Me.rrbShowRadioButton.Name = "rrbShowRadioButton"
			Me.rrbShowRadioButton.Size = New Size(86, 18)
			Me.rrbShowRadioButton.TabIndex = 1
			Me.rrbShowRadioButton.Text = "Radio Button"

			' 
			' rrbShowCheckBox
			' 
			Me.rrbShowCheckBox.Location = New Point(22, 26)
			Me.rrbShowCheckBox.Name = "rrbShowCheckBox"
			Me.rrbShowCheckBox.Size = New Size(72, 18)
			Me.rrbShowCheckBox.TabIndex = 0
			Me.rrbShowCheckBox.Text = "Check Box"

			' 
			' rcbTriState
			' 
			Me.rcbTriState.Anchor = AnchorStyles.Top
			Me.rcbTriState.Location = New Point(80, 48)
			Me.rcbTriState.Name = "rcbTriState"
			Me.rcbTriState.Size = New Size(125, 18)
			Me.rcbTriState.TabIndex = 2
			Me.rcbTriState.Text = "Tri-state check boxes"

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radTreeView1)
			Me.Name = "Form1"
			Me.Size = New Size(1331, 754)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radTreeView1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.headerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.rrbNone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rrbShowRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rrbShowCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rcbTriState, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private rrbNone As Telerik.WinControls.UI.RadRadioButton
		Private rrbShowRadioButton As Telerik.WinControls.UI.RadRadioButton
		Private rrbShowCheckBox As Telerik.WinControls.UI.RadRadioButton
		Private rcbTriState As Telerik.WinControls.UI.RadCheckBox
		Private headerPanel As TreeExampleHeaderPanel
	End Class
End Namespace
