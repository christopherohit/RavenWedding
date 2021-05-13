'using Telerik.Examples.WinControls.ChartView.FirstLook;
Namespace Telerik.Examples.WinControls.ChartView.LiveData
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
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.exampleCustomShapeControl4 = New Telerik.Examples.WinControls.ChartView.LiveData.ExampleCustomShapeControl()
			Me.radChartView2 = New Telerik.WinControls.UI.RadChartView()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
			Me.radPanel4 = New Telerik.WinControls.UI.RadPanel()
			Me.radPanel3 = New Telerik.WinControls.UI.RadPanel()
			Me.exampleCustomShapeControl1 = New Telerik.Examples.WinControls.ChartView.LiveData.ExampleCustomShapeControl()
			Me.exampleCustomShapeControl2 = New Telerik.Examples.WinControls.ChartView.LiveData.ExampleCustomShapeControl()
			Me.exampleCustomShapeControl3 = New Telerik.Examples.WinControls.ChartView.LiveData.ExampleCustomShapeControl()
			Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radChartView1.SuspendLayout()
			CType(Me.exampleCustomShapeControl4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radChartView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel2.SuspendLayout()
			CType(Me.radPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel4.SuspendLayout()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel3.SuspendLayout()
			CType(Me.exampleCustomShapeControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.exampleCustomShapeControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.exampleCustomShapeControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(0, 19)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radRadioButton2)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radRadioButton1)
			Me.settingsPanel.PanelContainer.Size = New Size(164, 360)
			Me.settingsPanel.Size = New Size(164, 360)
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaDesign = cartesianArea1
			Me.radChartView1.Controls.Add(Me.exampleCustomShapeControl4)
			Me.radChartView1.Dock = DockStyle.Fill
			Me.radChartView1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radChartView1.Location = New Point(0, 0)
			Me.radChartView1.Name = "radChartView1"
			' 
			' 
			' 
			Me.radChartView1.RootElement.MinSize = New Size(0, 0)
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.ShowTitle = True
			Me.radChartView1.Size = New Size(1217, 552)
			Me.radChartView1.TabIndex = 1
			Me.radChartView1.Title = "Messages Sent/Received"
			' 
			' exampleCustomShapeControl4
			' 
			Me.exampleCustomShapeControl4.Anchor = AnchorStyles.Top
			Me.exampleCustomShapeControl4.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.exampleCustomShapeControl4.LeftText = "..."
			Me.exampleCustomShapeControl4.Location = New Point(557, 49)
			Me.exampleCustomShapeControl4.Name = "exampleCustomShapeControl4"
			Me.exampleCustomShapeControl4.RightText = "  FPS"
			Me.exampleCustomShapeControl4.Size = New Size(144, 45)
			Me.exampleCustomShapeControl4.TabIndex = 0
			Me.exampleCustomShapeControl4.Text = "exampleCustomShapeControl1"
			CType(Me.exampleCustomShapeControl4.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.LightVisualElement).Text = "  FPS"
			CType(Me.exampleCustomShapeControl4.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.LightVisualElement).ForeColor = Color.White
			' 
			' radChartView2
			' 
			Me.radChartView2.AreaDesign = cartesianArea2
			Me.radChartView2.Dock = DockStyle.Fill
			Me.radChartView2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radChartView2.Location = New Point(0, 0)
			Me.radChartView2.Name = "radChartView2"
			Me.radChartView2.ShowGrid = False
			Me.radChartView2.ShowTitle = True
			Me.radChartView2.Size = New Size(938, 234)
			Me.radChartView2.TabIndex = 2
			Me.radChartView2.Title = "Site Activity by Time of Day"
			' 
			' radPanel1
			' 
			Me.radPanel1.Controls.Add(Me.radChartView1)
			Me.radPanel1.Dock = DockStyle.Fill
			Me.radPanel1.Location = New Point(0, 0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(1217, 552)
			Me.radPanel1.TabIndex = 3
			' 
			' radPanel2
			' 
			Me.radPanel2.Controls.Add(Me.radPanel4)
			Me.radPanel2.Controls.Add(Me.radPanel3)
			Me.radPanel2.Dock = DockStyle.Bottom
			Me.radPanel2.Location = New Point(0, 552)
			Me.radPanel2.Name = "radPanel2"
			Me.radPanel2.Size = New Size(1217, 234)
			Me.radPanel2.TabIndex = 4
			' 
			' radPanel4
			' 
			Me.radPanel4.Controls.Add(Me.radChartView2)
			Me.radPanel4.Dock = DockStyle.Fill
			Me.radPanel4.Location = New Point(0, 0)
			Me.radPanel4.Name = "radPanel4"
			Me.radPanel4.Size = New Size(938, 234)
			Me.radPanel4.TabIndex = 1
			' 
			' radPanel3
			' 
			Me.radPanel3.BackColor = Color.White
			Me.radPanel3.Controls.Add(Me.exampleCustomShapeControl1)
			Me.radPanel3.Controls.Add(Me.exampleCustomShapeControl2)
			Me.radPanel3.Controls.Add(Me.exampleCustomShapeControl3)
			Me.radPanel3.Dock = DockStyle.Right
			Me.radPanel3.Location = New Point(938, 0)
			Me.radPanel3.Name = "radPanel3"
			Me.radPanel3.Size = New Size(279, 234)
			Me.radPanel3.TabIndex = 0
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = Color.White
			' 
			' exampleCustomShapeControl1
			' 
			Me.exampleCustomShapeControl1.Font = New Font("Segoe UI", 8.25F)
			Me.exampleCustomShapeControl1.LeftText = "1,200"
			Me.exampleCustomShapeControl1.Location = New Point(90, 45)
			Me.exampleCustomShapeControl1.Name = "exampleCustomShapeControl1"
			Me.exampleCustomShapeControl1.RightText = "AVG Messages per second"
			Me.exampleCustomShapeControl1.Size = New Size(190, 45)
			Me.exampleCustomShapeControl1.TabIndex = 0
			Me.exampleCustomShapeControl1.Text = "exampleCustomShapeControl1"
			' 
			' exampleCustomShapeControl2
			' 
			Me.exampleCustomShapeControl2.Font = New Font("Segoe UI", 8.25F)
			Me.exampleCustomShapeControl2.LeftText = "53,210"
			Me.exampleCustomShapeControl2.Location = New Point(65, 100)
			Me.exampleCustomShapeControl2.Name = "exampleCustomShapeControl2"
			Me.exampleCustomShapeControl2.RightText = "AVG Messages per minute"
			Me.exampleCustomShapeControl2.Size = New Size(215, 45)
			Me.exampleCustomShapeControl2.TabIndex = 0
			Me.exampleCustomShapeControl2.Text = "exampleCustomShapeControl2"
			' 
			' exampleCustomShapeControl3
			' 
			Me.exampleCustomShapeControl3.Font = New Font("Segoe UI", 8.25F)
			Me.exampleCustomShapeControl3.LeftText = "3,729,600"
			Me.exampleCustomShapeControl3.Location = New Point(40, 155)
			Me.exampleCustomShapeControl3.Name = "exampleCustomShapeControl3"
			Me.exampleCustomShapeControl3.RightText = "AVG Messages per hour"
			Me.exampleCustomShapeControl3.Size = New Size(240, 45)
			Me.exampleCustomShapeControl3.TabIndex = 0
			Me.exampleCustomShapeControl3.Text = "exampleCustomShapeControl3"
			' 
			' radRadioButton1
			' 
			Me.radRadioButton1.Anchor = AnchorStyles.Top
			Me.radRadioButton1.Location = New Point(5, 33)
			Me.radRadioButton1.Name = "radRadioButton1"
			Me.radRadioButton1.Size = New Size(73, 18)
			Me.radRadioButton1.TabIndex = 1
			Me.radRadioButton1.TabStop = False
			Me.radRadioButton1.Text = "Line Series"
'			Me.radRadioButton1.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton1_ToggleStateChanged)
			' 
			' radRadioButton2
			' 
			Me.radRadioButton2.Anchor = AnchorStyles.Top
			Me.radRadioButton2.CheckState = CheckState.Checked
			Me.radRadioButton2.Location = New Point(5, 57)
			Me.radRadioButton2.Name = "radRadioButton2"
			Me.radRadioButton2.Size = New Size(96, 18)
			Me.radRadioButton2.TabIndex = 1
			Me.radRadioButton2.Text = "Fast Line Series"
			Me.radRadioButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radRadioButton2.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton2_ToggleStateChanged)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScrollMinSize = New Size(600, 240)
			Me.Controls.Add(Me.radPanel1)
			Me.Controls.Add(Me.radPanel2)
			Me.Name = "Form1"
			Me.Size = New Size(1227, 796)
			Me.Controls.SetChildIndex(Me.radPanel2, 0)
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radChartView1.ResumeLayout(False)
			CType(Me.exampleCustomShapeControl4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radChartView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel2.ResumeLayout(False)
			CType(Me.radPanel4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel4.ResumeLayout(False)
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel3.ResumeLayout(False)
			CType(Me.exampleCustomShapeControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.exampleCustomShapeControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.exampleCustomShapeControl3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radChartView2 As Telerik.WinControls.UI.RadChartView
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radPanel2 As Telerik.WinControls.UI.RadPanel
		Private radPanel4 As Telerik.WinControls.UI.RadPanel
		Private radPanel3 As Telerik.WinControls.UI.RadPanel
		Private exampleCustomShapeControl1 As ExampleCustomShapeControl
		Private exampleCustomShapeControl2 As ExampleCustomShapeControl
		Private exampleCustomShapeControl3 As ExampleCustomShapeControl
		Private WithEvents radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioButton1 As Telerik.WinControls.UI.RadRadioButton
		Private exampleCustomShapeControl4 As ExampleCustomShapeControl
	End Class
End Namespace