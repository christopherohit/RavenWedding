Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Polar
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
			Dim polarAxis1 As New Telerik.WinControls.UI.PolarAxis()
			Dim polarAxis2 As New Telerik.WinControls.UI.PolarAxis()
			Dim polarAxis3 As New Telerik.WinControls.UI.PolarAxis()
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New Point(994, 46)
			Me.settingsPanel.Size = New Size(160, 347)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaType = Telerik.WinControls.UI.ChartAreaType.Polar
			polarAxis1.IsPrimary = True
			polarAxis2.IsPrimary = True
			polarAxis3.IsPrimary = True
			Me.radChartView1.Axes.AddRange(New Telerik.WinControls.UI.Axis() { polarAxis1, polarAxis2, polarAxis3})
			Me.radChartView1.Dock = DockStyle.Fill
			Me.radChartView1.Location = New Point(0, 0)
			Me.radChartView1.MinimumSize = New Size(280, 320)
			Me.radChartView1.Name = "radChartView1"
			' 
			' 
			' 
			Me.radChartView1.RootElement.MinSize = New Size(280, 320)
			Me.radChartView1.Size = New Size(1158, 698)
			Me.radChartView1.TabIndex = 1
			Me.radChartView1.Text = "radChartView1"
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.Anchor = AnchorStyles.Top
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem1.Selected = True
			radListDataItem1.Text = "Line"
			radListDataItem1.TextWrap = True
			radListDataItem2.Text = "Area"
			radListDataItem2.TextWrap = True
			Me.radDropDownList1.Items.Add(radListDataItem1)
			Me.radDropDownList1.Items.Add(radListDataItem2)
			Me.radDropDownList1.Location = New Point(5, 37)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.Size = New Size(130, 20)
			Me.radDropDownList1.TabIndex = 1
			Me.radDropDownList1.Text = "Line"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radDropDownList1)
			Me.radGroupBox1.HeaderText = "Series type"
			Me.radGroupBox1.Location = New Point(10, 5)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New Size(140, 91)
			Me.radGroupBox1.TabIndex = 2
			Me.radGroupBox1.Text = "Series type"
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
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace