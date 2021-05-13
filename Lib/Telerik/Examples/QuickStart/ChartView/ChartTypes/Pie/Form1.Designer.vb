Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Pie
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
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditor2 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinDonutRadius = New Telerik.WinControls.UI.RadSpinEditor()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinDonutRadius, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radSpinDonutRadius)
			Me.settingsPanel.Controls.Add(Me.radLabel4)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Controls.Add(Me.radDropDownList1)
			Me.settingsPanel.Controls.Add(Me.radLabel3)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Controls.Add(Me.radLabel2)
			Me.settingsPanel.Controls.Add(Me.radSpinEditor1)
			Me.settingsPanel.Controls.Add(Me.radCheckBox1)
			Me.settingsPanel.Controls.Add(Me.radSpinEditor2)
			Me.settingsPanel.Location = New Point(994, 46)
			Me.settingsPanel.Size = New Size(252, 364)
			Me.settingsPanel.Controls.SetChildIndex(Me.radSpinEditor2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radSpinEditor1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel3, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radDropDownList1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel4, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radSpinDonutRadius, 0)
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(10, 35)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(63, 18)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Start Angle:"
			' 
			' radSpinEditor1
			' 
			Me.radSpinEditor1.Anchor = AnchorStyles.Top
			Me.radSpinEditor1.Location = New Point(10, 56)
			Me.radSpinEditor1.Maximum = New Decimal(New Integer() { 360, 0, 0, 0})
			Me.radSpinEditor1.Name = "radSpinEditor1"
			' 
			' 
			' 
			Me.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditor1.Size = New Size(232, 20)
			Me.radSpinEditor1.TabIndex = 2
			Me.radSpinEditor1.TabStop = False
			Me.radSpinEditor1.Value = New Decimal(New Integer() { 270, 0, 0, 0})
			Me.radSpinEditor1.Wrap = True
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = AnchorStyles.Top
			Me.radLabel2.Location = New Point(10, 85)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(67, 18)
			Me.radLabel2.TabIndex = 3
			Me.radLabel2.Text = "Total Range:"
			' 
			' radSpinEditor2
			' 
			Me.radSpinEditor2.Anchor = AnchorStyles.Top
			Me.radSpinEditor2.Location = New Point(10, 106)
			Me.radSpinEditor2.Maximum = New Decimal(New Integer() { 360, 0, 0, 0})
			Me.radSpinEditor2.Minimum = New Decimal(New Integer() { 60, 0, 0, 0})
			Me.radSpinEditor2.Name = "radSpinEditor2"
			' 
			' 
			' 
			Me.radSpinEditor2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditor2.Size = New Size(232, 20)
			Me.radSpinEditor2.TabIndex = 4
			Me.radSpinEditor2.TabStop = False
			Me.radSpinEditor2.Value = New Decimal(New Integer() { 360, 0, 0, 0})
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.Anchor = AnchorStyles.Top
			Me.radCheckBox1.Location = New Point(10, 182)
			Me.radCheckBox1.Name = "radCheckBox1"
			Me.radCheckBox1.Size = New Size(82, 18)
			Me.radCheckBox1.TabIndex = 5
			Me.radCheckBox1.Text = "Show Labels"
			Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = AnchorStyles.Top
			Me.radLabel3.Location = New Point(10, 135)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(86, 18)
			Me.radLabel3.TabIndex = 6
			Me.radLabel3.Text = "Selection Mode:"
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.Anchor = AnchorStyles.Top
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownList1.Location = New Point(10, 156)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.NullText = "Choose selection mode"
			Me.radDropDownList1.Size = New Size(232, 20)
			Me.radDropDownList1.TabIndex = 7
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie
			Me.radChartView1.Dock = DockStyle.Fill
			Me.radChartView1.Location = New Point(0, 0)
			Me.radChartView1.MinimumSize = New Size(280, 320)
			Me.radChartView1.Name = "radChartView1"
			' 
			' 
			' 
			Me.radChartView1.RootElement.MinSize = New Size(280, 320)
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.Size = New Size(1158, 698)
			Me.radChartView1.TabIndex = 1
			Me.radChartView1.Text = "radChartView1"
			Me.radChartView1.Title = "Chart title"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radRadioButton2)
			Me.radGroupBox1.Controls.Add(Me.radRadioButton1)
			Me.radGroupBox1.HeaderText = "Chart type"
			Me.radGroupBox1.Location = New Point(10, 205)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New Size(232, 77)
			Me.radGroupBox1.TabIndex = 8
			Me.radGroupBox1.Text = "Chart type"
			' 
			' radRadioButton2
			' 
			Me.radRadioButton2.Anchor = AnchorStyles.Top
			Me.radRadioButton2.Location = New Point(5, 49)
			Me.radRadioButton2.Name = "radRadioButton2"
			Me.radRadioButton2.Size = New Size(51, 18)
			Me.radRadioButton2.TabIndex = 1
			Me.radRadioButton2.Text = "Donut"
			' 
			' radRadioButton1
			' 
			Me.radRadioButton1.Anchor = AnchorStyles.Top
			Me.radRadioButton1.Location = New Point(5, 25)
			Me.radRadioButton1.Name = "radRadioButton1"
			Me.radRadioButton1.Size = New Size(35, 18)
			Me.radRadioButton1.TabIndex = 0
			Me.radRadioButton1.TabStop = True
			Me.radRadioButton1.Text = "Pie"
			Me.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radLabel4
			' 
			Me.radLabel4.Anchor = AnchorStyles.Top
			Me.radLabel4.Location = New Point(10, 293)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New Size(104, 18)
			Me.radLabel4.TabIndex = 9
			Me.radLabel4.Text = "Donut radius factor:"
			' 
			' radSpinDonutRadius
			' 
			Me.radSpinDonutRadius.Anchor = AnchorStyles.Top
			Me.radSpinDonutRadius.Location = New Point(10, 314)
			Me.radSpinDonutRadius.Name = "radSpinDonutRadius"
			Me.radSpinDonutRadius.Size = New Size(232, 20)
			Me.radSpinDonutRadius.TabIndex = 10
			Me.radSpinDonutRadius.TabStop = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScrollMinSize = New Size(280, 320)
			Me.Controls.Add(Me.radChartView1)
			Me.Name = "Form1"
			Me.Size = New Size(1168, 708)
			Me.Controls.SetChildIndex(Me.radChartView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditor2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinDonutRadius, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radSpinEditor2 As Telerik.WinControls.UI.RadSpinEditor
		Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton1 As Telerik.WinControls.UI.RadRadioButton
		Private radSpinDonutRadius As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace