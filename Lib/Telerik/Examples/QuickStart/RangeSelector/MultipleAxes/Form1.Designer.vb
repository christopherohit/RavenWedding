Namespace Telerik.Examples.WinControls.RangeSelector.MultipleAxes
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
			Me.radRangeSelector1 = New Telerik.WinControls.UI.RadRangeSelector()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.radRangeSelector2 = New Telerik.WinControls.UI.RadRangeSelector()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRangeSelector1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRangeSelector2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(860, 16)
			' 
			' radRangeSelector1
			' 
			Me.radRangeSelector1.Dock = DockStyle.Top
			Me.radRangeSelector1.Location = New Point(0, 0)
			Me.radRangeSelector1.Name = "radRangeSelector1"
			Me.radRangeSelector1.Size = New Size(1158, 150)
			Me.radRangeSelector1.TabIndex = 0
			Me.radRangeSelector1.Text = "radRangeSelector1"
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaDesign = cartesianArea1
			Me.radChartView1.Dock = DockStyle.Fill
			Me.radChartView1.Location = New Point(0, 150)
			Me.radChartView1.Name = "radChartView1"
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.Size = New Size(1158, 390)
			Me.radChartView1.TabIndex = 0
			Me.radChartView1.Text = "radChartView1"
			' 
			' radRangeSelector2
			' 
			Me.radRangeSelector2.Dock = DockStyle.Bottom
			Me.radRangeSelector2.Location = New Point(0, 540)
			Me.radRangeSelector2.Name = "radRangeSelector2"
			Me.radRangeSelector2.Size = New Size(1158, 158)
			Me.radRangeSelector2.TabIndex = 0
			Me.radRangeSelector2.Text = "radRangeSelector2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScrollMinSize = New Size(780, 350)
			Me.Controls.Add(Me.radChartView1)
			Me.Controls.Add(Me.radRangeSelector2)
			Me.Controls.Add(Me.radRangeSelector1)
			Me.Name = "Form1"
			Me.Size = New Size(1168, 708)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radRangeSelector1, 0)
			Me.Controls.SetChildIndex(Me.radRangeSelector2, 0)
			Me.Controls.SetChildIndex(Me.radChartView1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRangeSelector1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRangeSelector2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radRangeSelector1 As Telerik.WinControls.UI.RadRangeSelector
		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radRangeSelector2 As Telerik.WinControls.UI.RadRangeSelector
	End Class
End Namespace