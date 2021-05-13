Namespace Telerik.Examples.WinControls.ChartView.SmartLabels
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
			Dim cartesianArea1 As New Telerik.WinControls.UI.CartesianArea()
			Dim cartesianArea2 As New Telerik.WinControls.UI.CartesianArea()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox3 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox4 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.doubleBufferedTableLayoutPanel2 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.radChartView2 = New Telerik.WinControls.UI.RadChartView()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.doubleBufferedTableLayoutPanel2.SuspendLayout()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radChartView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(0, 3)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.PanelContainer.Size = New Size(208, 493)
			Me.settingsPanel.Size = New Size(208, 493)
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.CheckState = CheckState.Checked
			Me.radCheckBox1.Location = New Point(3, 37)
			Me.radCheckBox1.Name = "radCheckBox1"
			Me.radCheckBox1.Size = New Size(126, 18)
			Me.radCheckBox1.TabIndex = 1
			Me.radCheckBox1.Text = "Draw connecting line"
			Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radCheckBox2
			' 
			Me.radCheckBox2.CheckState = CheckState.Checked
			Me.radCheckBox2.Location = New Point(3, 71)
			Me.radCheckBox2.Name = "radCheckBox2"
			Me.radCheckBox2.Size = New Size(115, 18)
			Me.radCheckBox2.TabIndex = 1
			Me.radCheckBox2.Text = "Draw labels border"
			Me.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radCheckBox3
			' 
			Me.radCheckBox3.CheckState = CheckState.Checked
			Me.radCheckBox3.Location = New Point(3, 139)
			Me.radCheckBox3.Name = "radCheckBox3"
			Me.radCheckBox3.Size = New Size(124, 18)
			Me.radCheckBox3.TabIndex = 1
			Me.radCheckBox3.Text = "Sync labels line color"
			Me.radCheckBox3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radCheckBox4
			' 
			Me.radCheckBox4.CheckState = CheckState.Checked
			Me.radCheckBox4.Location = New Point(3, 105)
			Me.radCheckBox4.Name = "radCheckBox4"
			Me.radCheckBox4.Size = New Size(140, 18)
			Me.radCheckBox4.TabIndex = 1
			Me.radCheckBox4.Text = "Sync labels border color"
			Me.radCheckBox4.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
			Me.radGroupBox1.HeaderText = "Settings"
			Me.radGroupBox1.Location = New Point(3, 43)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New Size(198, 289)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Settings"
			' 
			' tableLayoutPanel1
			' 
			Me.doubleBufferedTableLayoutPanel1.Anchor = AnchorStyles.Top
			Me.doubleBufferedTableLayoutPanel1.ColumnCount = 1
			Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radSpinEditor1, 0, 6)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 5)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radCheckBox1, 0, 1)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radCheckBox2, 0, 2)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radCheckBox3, 0, 4)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radCheckBox4, 0, 3)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radDropDownList1, 0, 0)
			Me.doubleBufferedTableLayoutPanel1.Location = New Point(15, 43)
			Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
			Me.doubleBufferedTableLayoutPanel1.RowCount = 7
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28531F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28531F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28531F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28531F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28531F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28531F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28816F))
			Me.doubleBufferedTableLayoutPanel1.Size = New Size(169, 241)
			Me.doubleBufferedTableLayoutPanel1.TabIndex = 5
			' 
			' radSpinEditor1
			' 
			Me.radSpinEditor1.Location = New Point(3, 207)
			Me.radSpinEditor1.Maximum = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.radSpinEditor1.Minimum = New Decimal(New Integer() { 20, 0, 0, -2147483648})
			Me.radSpinEditor1.Name = "radSpinEditor1"
			Me.radSpinEditor1.Size = New Size(163, 20)
			Me.radSpinEditor1.TabIndex = 3
			Me.radSpinEditor1.TabStop = False
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(3, 173)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(89, 18)
			Me.radLabel1.TabIndex = 4
			Me.radLabel1.Text = "Distance to label"
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.DropDownAnimationEnabled = False
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownList1.Location = New Point(3, 3)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.Size = New Size(163, 20)
			Me.radDropDownList1.TabIndex = 2
			Me.radDropDownList1.Text = "radDropDownList1"
			' 
			' customTableLayoutPanel1
			' 
			Me.doubleBufferedTableLayoutPanel2.ColumnCount = 2
			Me.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radChartView1, 0, 0)
			Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.radChartView2, 1, 0)
			Me.doubleBufferedTableLayoutPanel2.Dock = DockStyle.Fill
			Me.doubleBufferedTableLayoutPanel2.Location = New Point(0, 0)
			Me.doubleBufferedTableLayoutPanel2.MinimumSize = New Size(500, 350)
			Me.doubleBufferedTableLayoutPanel2.Name = "doubleBufferedTableLayoutPanel1"
			Me.doubleBufferedTableLayoutPanel2.RowCount = 1
			Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Me.doubleBufferedTableLayoutPanel2.Size = New Size(1473, 786)
			Me.doubleBufferedTableLayoutPanel2.TabIndex = 1
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaDesign = cartesianArea1
			Me.radChartView1.Dock = DockStyle.Fill
			Me.radChartView1.Location = New Point(3, 3)
			Me.radChartView1.Name = "radChartView1"
			Me.radChartView1.Padding = New Padding(0, 0, 3, 0)
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.Size = New Size(730, 780)
			Me.radChartView1.TabIndex = 0
			' 
			' radChartView2
			' 
			Me.radChartView2.AreaDesign = cartesianArea2
			Me.radChartView2.Dock = DockStyle.Fill
			Me.radChartView2.Location = New Point(739, 3)
			Me.radChartView2.Name = "radChartView2"
			Me.radChartView2.Padding = New Padding(0, 0, 3, 0)
			Me.radChartView2.ShowGrid = False
			Me.radChartView2.Size = New Size(731, 780)
			Me.radChartView2.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScrollMinSize = New Size(500, 350)
			Me.Controls.Add(Me.doubleBufferedTableLayoutPanel2)
			Me.Name = "Form1"
			Me.Size = New Size(1483, 796)
			Me.Controls.SetChildIndex(Me.doubleBufferedTableLayoutPanel2, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
			Me.doubleBufferedTableLayoutPanel1.PerformLayout()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.doubleBufferedTableLayoutPanel2.ResumeLayout(False)
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radChartView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private doubleBufferedTableLayoutPanel2 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radChartView2 As Telerik.WinControls.UI.RadChartView
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBox3 As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBox4 As Telerik.WinControls.UI.RadCheckBox
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
		Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
	End Class
End Namespace