Imports Telerik.WinControls.UI
Namespace Telerik.Examples.WinControls.ChartView.LabelFormatting
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
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(0, 19)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBox1)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBox2)
			Me.settingsPanel.PanelContainer.Size = New Size(304, 832)
			Me.settingsPanel.Size = New Size(304, 832)
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaDesign = cartesianArea1
			Me.radChartView1.Dock = DockStyle.Fill
			Me.radChartView1.Location = New Point(0, 0)
			Me.radChartView1.Name = "radChartView1"
			' 
			' 
			' 
			Me.radChartView1.RootElement.MinSize = New Size(0, 0)
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.ShowTitle = True
			Me.radChartView1.Size = New Size(1217, 786)
			Me.radChartView1.TabIndex = 1
			Me.radChartView1.Title = "Stock Index"
			CType(Me.radChartView1.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.ChartTitleElement).Text = "Stock Index"
			CType(Me.radChartView1.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.ChartTitleElement).Font = New Font("Segoe UI Light", 20F)
			CType(Me.radChartView1.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.ChartTitleElement).Margin = New Padding(10, 0, 0, 0)
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.Anchor = AnchorStyles.Top
			Me.radCheckBox1.CheckState = CheckState.Checked
			Me.radCheckBox1.Location = New Point(10, 56)
			Me.radCheckBox1.Name = "radCheckBox1"
			Me.radCheckBox1.Size = New Size(82, 18)
			Me.radCheckBox1.TabIndex = 1
			Me.radCheckBox1.Text = "Show Labels"
			Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radCheckBox2
			' 
			Me.radCheckBox2.Anchor = AnchorStyles.Top
			Me.radCheckBox2.CheckState = CheckState.Checked
			Me.radCheckBox2.Location = New Point(10, 96)
			Me.radCheckBox2.Name = "radCheckBox2"
			Me.radCheckBox2.Size = New Size(154, 18)
			Me.radCheckBox2.TabIndex = 2
			Me.radCheckBox2.Text = "Enable custom appearance"
			Me.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScrollMinSize = New Size(680, 420)
			Me.Controls.Add(Me.radChartView1)
			Me.Name = "Form1"
			Me.Size = New Size(1227, 796)
			Me.Controls.SetChildIndex(Me.radChartView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private radChartView1 As Telerik.WinControls.UI.RadChartView
	End Class
End Namespace