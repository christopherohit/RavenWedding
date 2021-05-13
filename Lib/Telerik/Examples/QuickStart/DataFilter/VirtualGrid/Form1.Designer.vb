Namespace Telerik.Examples.WinControls.DataFilter.VirtualGrid
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
			Me.radDataFilter1 = New Telerik.WinControls.UI.RadDataFilter()
			Me.radVirtualGrid1 = New Telerik.WinControls.UI.RadVirtualGrid()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radDataFilter1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radVirtualGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1523, 108)
			Me.settingsPanel.Margin = New Padding(4)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Margin = New Padding(4)
			Me.settingsPanel.PanelContainer.Size = New Size(307, 202)
			Me.settingsPanel.Size = New Size(307, 202)
			' 
			' radDataFilter1
			' 
			Me.radDataFilter1.Dock = DockStyle.Left
			Me.radDataFilter1.Location = New Point(0, 0)
			Me.radDataFilter1.Margin = New Padding(4)
			Me.radDataFilter1.Name = "radDataFilter1"
			Me.radDataFilter1.Padding = New Padding(7, 5, 7, 5)
			Me.radDataFilter1.Size = New Size(572, 1083)
			Me.radDataFilter1.TabIndex = 3
			Me.radDataFilter1.TreeIndent = 26
			' 
			' radVirtualGrid1
			' 
			Me.radVirtualGrid1.Dock = DockStyle.Fill
			Me.radVirtualGrid1.Location = New Point(572, 0)
			Me.radVirtualGrid1.Margin = New Padding(4)
			Me.radVirtualGrid1.MasterViewInfo.ColumnWidth = 164
			Me.radVirtualGrid1.MasterViewInfo.MinColumnWidth = 7
			Me.radVirtualGrid1.MasterViewInfo.MinRowHeight = 7
			Me.radVirtualGrid1.MasterViewInfo.Padding = New Padding(12, 11, 12, 11)
			Me.radVirtualGrid1.Name = "radVirtualGrid1"
			Me.radVirtualGrid1.Size = New Size(1764, 1083)
			Me.radVirtualGrid1.TabIndex = 4
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaDesign = cartesianArea1
			Me.radChartView1.Dock = DockStyle.Bottom
			Me.radChartView1.Location = New Point(0, 1083)
			Me.radChartView1.Margin = New Padding(4)
			Me.radChartView1.Name = "radChartView1"
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.Size = New Size(2336, 369)
			Me.radChartView1.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radVirtualGrid1)
			Me.Controls.Add(Me.radDataFilter1)
			Me.Controls.Add(Me.radChartView1)
			Me.Name = "Form1"
			Me.Size = New Size(2349, 1464)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radChartView1, 0)
			Me.Controls.SetChildIndex(Me.radDataFilter1, 0)
			Me.Controls.SetChildIndex(Me.radVirtualGrid1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radDataFilter1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radVirtualGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radDataFilter1 As Telerik.WinControls.UI.RadDataFilter
		Private radVirtualGrid1 As Telerik.WinControls.UI.RadVirtualGrid
		Private radChartView1 As Telerik.WinControls.UI.RadChartView
	End Class
End Namespace