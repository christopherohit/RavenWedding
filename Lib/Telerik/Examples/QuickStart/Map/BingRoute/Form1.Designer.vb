Namespace Telerik.Examples.WinControls.Map.BingRoute
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
			Me.radMap1 = New Telerik.WinControls.UI.RadMap()
			Me.radGroupBoxSetup = New Telerik.WinControls.UI.RadGroupBox()
			Me.radButtonCalculateRoute = New Telerik.WinControls.UI.RadButton()
			Me.radLabelEndPoint = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radTextBoxEndPoint = New Telerik.WinControls.UI.RadTextBox()
			Me.radTextBoxStartPoint = New Telerik.WinControls.UI.RadTextBox()
			Me.radGroupBoxTurnByTurnDirections = New Telerik.WinControls.UI.RadGroupBox()
			Me.radListView1 = New Telerik.WinControls.UI.RadListView()
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.splitPanel1 = New Telerik.WinControls.UI.SplitPanel()
			Me.splitPanel2 = New Telerik.WinControls.UI.SplitPanel()
			Me.radDropDownListMode = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownListOptimize = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabelOptimize = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownListAvoid = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabelAvoid = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownListUnits = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radMap1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBoxSetup, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBoxSetup.SuspendLayout()
			CType(Me.radButtonCalculateRoute, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelEndPoint, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBoxEndPoint, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTextBoxStartPoint, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBoxTurnByTurnDirections, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBoxTurnByTurnDirections.SuspendLayout()
			CType(Me.radListView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer1.SuspendLayout()
			CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel1.SuspendLayout()
			CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel2.SuspendLayout()
			CType(Me.radDropDownListMode, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownListOptimize, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelOptimize, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownListAvoid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelAvoid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownListUnits, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBoxSetup)
			Me.settingsPanel.Size = New Size(230, 710)
			Me.settingsPanel.TabStop = False
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxSetup, 0)
			' 
			' radMap1
			' 
			Me.radMap1.Dock = DockStyle.Fill
			Me.radMap1.Location = New Point(0, 0)
			Me.radMap1.Name = "radMap1"
			Me.radMap1.ShowLegend = False
			Me.radMap1.ShowMiniMap = False
			Me.radMap1.ShowSearchBar = False
			Me.radMap1.Size = New Size(1500, 1028)
			Me.radMap1.TabIndex = 0
			Me.radMap1.TabStop = False
			Me.radMap1.Text = "radMap1"
			' 
			' radGroupBoxSetup
			' 
			Me.radGroupBoxSetup.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBoxSetup.Anchor = AnchorStyles.Top
			Me.radGroupBoxSetup.Controls.Add(Me.radLabelAvoid)
			Me.radGroupBoxSetup.Controls.Add(Me.radDropDownListAvoid)
			Me.radGroupBoxSetup.Controls.Add(Me.radLabelOptimize)
			Me.radGroupBoxSetup.Controls.Add(Me.radDropDownListOptimize)
			Me.radGroupBoxSetup.Controls.Add(Me.radLabel5)
			Me.radGroupBoxSetup.Controls.Add(Me.radDropDownListUnits)
			Me.radGroupBoxSetup.Controls.Add(Me.radLabel2)
			Me.radGroupBoxSetup.Controls.Add(Me.radDropDownListMode)
			Me.radGroupBoxSetup.Controls.Add(Me.radButtonCalculateRoute)
			Me.radGroupBoxSetup.Controls.Add(Me.radLabelEndPoint)
			Me.radGroupBoxSetup.Controls.Add(Me.radLabel1)
			Me.radGroupBoxSetup.Controls.Add(Me.radTextBoxEndPoint)
			Me.radGroupBoxSetup.Controls.Add(Me.radTextBoxStartPoint)
			Me.radGroupBoxSetup.HeaderText = "Route calculation"
			Me.radGroupBoxSetup.Location = New Point(10, 33)
			Me.radGroupBoxSetup.Name = "radGroupBoxSetup"
			Me.radGroupBoxSetup.Size = New Size(210, 390)
			Me.radGroupBoxSetup.TabIndex = 1
			Me.radGroupBoxSetup.TabStop = False
			Me.radGroupBoxSetup.Text = "Route calculation"
			' 
			' radButtonCalculateRoute
			' 
			Me.radButtonCalculateRoute.Anchor = AnchorStyles.Top
			Me.radButtonCalculateRoute.Location = New Point(5, 335)
			Me.radButtonCalculateRoute.Name = "radButtonCalculateRoute"
			Me.radButtonCalculateRoute.Size = New Size(200, 42)
			Me.radButtonCalculateRoute.TabIndex = 2
			Me.radButtonCalculateRoute.Text = "Calculate route"
'			Me.radButtonCalculateRoute.Click += New System.EventHandler(Me.radButtonCalculateRoute_Click)
			' 
			' radLabelEndPoint
			' 
			Me.radLabelEndPoint.Anchor = AnchorStyles.Top
			Me.radLabelEndPoint.Location = New Point(5, 80)
			Me.radLabelEndPoint.Name = "radLabelEndPoint"
			Me.radLabelEndPoint.Size = New Size(53, 18)
			Me.radLabelEndPoint.TabIndex = 1
			Me.radLabelEndPoint.Text = "End point"
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(5, 30)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(74, 18)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Starting point"
			' 
			' radTextBoxEndPoint
			' 
			Me.radTextBoxEndPoint.Anchor = AnchorStyles.Top
			Me.radTextBoxEndPoint.Location = New Point(5, 101)
			Me.radTextBoxEndPoint.Name = "radTextBoxEndPoint"
			Me.radTextBoxEndPoint.Size = New Size(200, 20)
			Me.radTextBoxEndPoint.TabIndex = 1
			' 
			' radTextBoxStartPoint
			' 
			Me.radTextBoxStartPoint.Anchor = AnchorStyles.Top
			Me.radTextBoxStartPoint.Location = New Point(5, 51)
			Me.radTextBoxStartPoint.Name = "radTextBoxStartPoint"
			Me.radTextBoxStartPoint.Size = New Size(200, 20)
			Me.radTextBoxStartPoint.TabIndex = 0
			' 
			' radGroupBoxTurnByTurnDirections
			' 
			Me.radGroupBoxTurnByTurnDirections.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBoxTurnByTurnDirections.Controls.Add(Me.radListView1)
			Me.radGroupBoxTurnByTurnDirections.Dock = DockStyle.Fill
			Me.radGroupBoxTurnByTurnDirections.HeaderText = "Turn by turn directions"
			Me.radGroupBoxTurnByTurnDirections.Location = New Point(0, 0)
			Me.radGroupBoxTurnByTurnDirections.Name = "radGroupBoxTurnByTurnDirections"
			Me.radGroupBoxTurnByTurnDirections.Padding = New Padding(2, 25, 2, 2)
			Me.radGroupBoxTurnByTurnDirections.Size = New Size(384, 1028)
			Me.radGroupBoxTurnByTurnDirections.TabIndex = 2
			Me.radGroupBoxTurnByTurnDirections.TabStop = False
			Me.radGroupBoxTurnByTurnDirections.Text = "Turn by turn directions"
			' 
			' radListView1
			' 
			Me.radListView1.AllowEdit = False
			Me.radListView1.Dock = DockStyle.Fill
			Me.radListView1.Location = New Point(2, 25)
			Me.radListView1.Name = "radListView1"
			Me.radListView1.Size = New Size(380, 1001)
			Me.radListView1.TabIndex = 0
			Me.radListView1.TabStop = False
			Me.radListView1.Text = "radListView1"
'			Me.radListView1.SelectedIndexChanged += radListView1_SelectedIndexChanged
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1.Controls.Add(Me.splitPanel1)
			Me.radSplitContainer1.Controls.Add(Me.splitPanel2)
			Me.radSplitContainer1.Dock = DockStyle.Fill
			Me.radSplitContainer1.Location = New Point(0, 0)
			Me.radSplitContainer1.Name = "radSplitContainer1"
			' 
			' 
			' 
			Me.radSplitContainer1.RootElement.MinSize = New Size(0, 0)
			Me.radSplitContainer1.Size = New Size(1500, 1028)
			Me.radSplitContainer1.TabIndex = 3
			Me.radSplitContainer1.TabStop = False
			Me.radSplitContainer1.Text = "radSplitContainer1"
			' 
			' splitPanel1
			' 
			Me.splitPanel1.Controls.Add(Me.radMap1)
			Me.splitPanel1.Location = New Point(0, 0)
			Me.splitPanel1.Name = "splitPanel1"
			' 
			' 
			' 
			Me.splitPanel1.RootElement.MinSize = New Size(0, 0)
			Me.splitPanel1.Size = New Size(1500, 1028)
			Me.splitPanel1.SizeInfo.AutoSizeScale = New SizeF(0.2592477F, 0F)
			Me.splitPanel1.SizeInfo.SplitterCorrection = New Size(291, 0)
			Me.splitPanel1.TabIndex = 0
			Me.splitPanel1.TabStop = False
			Me.splitPanel1.Text = "splitPanel1"
			' 
			' splitPanel2
			' 
			Me.splitPanel2.Collapsed = True
			Me.splitPanel2.Controls.Add(Me.radGroupBoxTurnByTurnDirections)
			Me.splitPanel2.Location = New Point(1215, 0)
			Me.splitPanel2.Name = "splitPanel2"
			' 
			' 
			' 
			Me.splitPanel2.RootElement.MinSize = New Size(0, 0)
			Me.splitPanel2.Size = New Size(384, 1028)
			Me.splitPanel2.SizeInfo.AutoSizeScale = New SizeF(-0.25F, 0F)
			Me.splitPanel2.SizeInfo.SplitterCorrection = New Size(-291, 0)
			Me.splitPanel2.TabIndex = 1
			Me.splitPanel2.TabStop = False
			Me.splitPanel2.Text = "splitPanel2"
			' 
			' radDropDownListMode
			' 
			Me.radDropDownListMode.Anchor = AnchorStyles.Top
			Me.radDropDownListMode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownListMode.Location = New Point(5, 196)
			Me.radDropDownListMode.Name = "radDropDownListMode"
			Me.radDropDownListMode.Size = New Size(200, 20)
			Me.radDropDownListMode.TabIndex = 3
			Me.radDropDownListMode.Text = "radDropDownList1"
'			Me.radDropDownListMode.SelectedIndexChanged += radDropDownListMode_SelectedIndexChanged
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = AnchorStyles.Top
			Me.radLabel2.Location = New Point(5, 175)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(35, 18)
			Me.radLabel2.TabIndex = 4
			Me.radLabel2.Text = "Mode"
			' 
			' radDropDownListOptimize
			' 
			Me.radDropDownListOptimize.Anchor = AnchorStyles.Top
			Me.radDropDownListOptimize.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownListOptimize.Location = New Point(5, 246)
			Me.radDropDownListOptimize.Name = "radDropDownListOptimize"
			Me.radDropDownListOptimize.Size = New Size(200, 20)
			Me.radDropDownListOptimize.TabIndex = 3
			Me.radDropDownListOptimize.Text = "radDropDownList1"
			' 
			' radLabel3
			' 
			Me.radLabelOptimize.Anchor = AnchorStyles.Top
			Me.radLabelOptimize.Location = New Point(5, 225)
			Me.radLabelOptimize.Name = "radLabel3"
			Me.radLabelOptimize.Size = New Size(70, 18)
			Me.radLabelOptimize.TabIndex = 4
			Me.radLabelOptimize.Text = "Optimization"
			' 
			' radDropDownListAvoid
			' 
			Me.radDropDownListAvoid.Anchor = AnchorStyles.Top
			Me.radDropDownListAvoid.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownListAvoid.Location = New Point(5, 296)
			Me.radDropDownListAvoid.Name = "radDropDownListAvoid"
			Me.radDropDownListAvoid.Size = New Size(200, 20)
			Me.radDropDownListAvoid.TabIndex = 3
			Me.radDropDownListAvoid.Text = "radDropDownList1"
			' 
			' radLabel4
			' 
			Me.radLabelAvoid.Anchor = AnchorStyles.Top
			Me.radLabelAvoid.Location = New Point(5, 275)
			Me.radLabelAvoid.Name = "radLabel4"
			Me.radLabelAvoid.Size = New Size(57, 18)
			Me.radLabelAvoid.TabIndex = 4
			Me.radLabelAvoid.Text = "Avoidance"
			' 
			' radDropDownListUnits
			' 
			Me.radDropDownListUnits.Anchor = AnchorStyles.Top
			Me.radDropDownListUnits.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownListUnits.Location = New Point(5, 149)
			Me.radDropDownListUnits.Name = "radDropDownListUnits"
			Me.radDropDownListUnits.Size = New Size(200, 20)
			Me.radDropDownListUnits.TabIndex = 3
			Me.radDropDownListUnits.Text = "radDropDownList1"
			' 
			' radLabel5
			' 
			Me.radLabel5.Anchor = AnchorStyles.Top
			Me.radLabel5.Location = New Point(5, 130)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Size = New Size(75, 18)
			Me.radLabel5.TabIndex = 4
			Me.radLabel5.Text = "Distance units"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radSplitContainer1)
			Me.Name = "Form1"
			Me.Size = New Size(1510, 1038)
			Me.Controls.SetChildIndex(Me.radSplitContainer1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radMap1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBoxSetup, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBoxSetup.ResumeLayout(False)
			Me.radGroupBoxSetup.PerformLayout()
			CType(Me.radButtonCalculateRoute, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelEndPoint, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBoxEndPoint, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTextBoxStartPoint, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBoxTurnByTurnDirections, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBoxTurnByTurnDirections.ResumeLayout(False)
			CType(Me.radListView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer1.ResumeLayout(False)
			CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel1.ResumeLayout(False)
			CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel2.ResumeLayout(False)
			CType(Me.radDropDownListMode, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownListOptimize, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelOptimize, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownListAvoid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelAvoid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownListUnits, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radMap1 As Telerik.WinControls.UI.RadMap
		Private radGroupBoxSetup As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radButtonCalculateRoute As Telerik.WinControls.UI.RadButton
		Private radLabelEndPoint As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radTextBoxEndPoint As Telerik.WinControls.UI.RadTextBox
		Private radTextBoxStartPoint As Telerik.WinControls.UI.RadTextBox
		Private radGroupBoxTurnByTurnDirections As Telerik.WinControls.UI.RadGroupBox
        Private WithEvents radListView1 As Telerik.WinControls.UI.RadListView
		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private splitPanel1 As Telerik.WinControls.UI.SplitPanel
		Private splitPanel2 As Telerik.WinControls.UI.SplitPanel
		Private radLabelAvoid As Telerik.WinControls.UI.RadLabel
		Private radDropDownListAvoid As Telerik.WinControls.UI.RadDropDownList
		Private radLabelOptimize As Telerik.WinControls.UI.RadLabel
		Private radDropDownListOptimize As Telerik.WinControls.UI.RadDropDownList
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private WithEvents radDropDownListMode As Telerik.WinControls.UI.RadDropDownList
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private radDropDownListUnits As Telerik.WinControls.UI.RadDropDownList
	End Class
End Namespace