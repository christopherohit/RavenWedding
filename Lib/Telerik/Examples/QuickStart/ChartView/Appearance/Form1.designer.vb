Namespace Telerik.Examples.WinControls.ChartView.Appearance
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
			Dim cartesianArea3 As New Telerik.WinControls.UI.CartesianArea()
			Dim cartesianArea4 As New Telerik.WinControls.UI.CartesianArea()
			Me.radListControl1 = New Telerik.WinControls.UI.RadListControl()
			Me.tableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.radChartView2 = New Telerik.WinControls.UI.RadChartView()
			Me.radChartView3 = New Telerik.WinControls.UI.RadChartView()
			Me.radChartView4 = New Telerik.WinControls.UI.RadChartView()
			Me.radChartView5 = New Telerik.WinControls.UI.RadChartView()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
			Me.radPanel3 = New Telerik.WinControls.UI.RadPanel()
			Me.radPanel4 = New Telerik.WinControls.UI.RadPanel()
			Me.radPanel5 = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tableLayoutPanel1.SuspendLayout()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radChartView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radChartView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radChartView4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radChartView5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radListControl1)
			Me.settingsPanel.Location = New Point(1501, 19)
			Me.settingsPanel.Size = New Size(100, 885)
			Me.settingsPanel.Controls.SetChildIndex(Me.radListControl1, 0)
			' 
			' radListControl1
			' 
			Me.radListControl1.Anchor = AnchorStyles.Top
			Me.radListControl1.Location = New Point(10, 7)
			Me.radListControl1.Name = "radListControl1"
			Me.radListControl1.Size = New Size(80, 345)
			Me.radListControl1.TabIndex = 1
			Me.radListControl1.Text = "radListControl1"
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 6
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.66667F))
			Me.tableLayoutPanel1.Controls.Add(Me.radChartView1, 0, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.radChartView2, 2, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.radChartView3, 4, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.radChartView4, 0, 3)
			Me.tableLayoutPanel1.Controls.Add(Me.radChartView5, 3, 3)
			Me.tableLayoutPanel1.Controls.Add(Me.radPanel1, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.radPanel2, 2, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.radPanel3, 4, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.radPanel4, 0, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.radPanel5, 3, 2)
			Me.tableLayoutPanel1.Dock = DockStyle.Fill
			Me.tableLayoutPanel1.Location = New Point(0, 0)
			Me.tableLayoutPanel1.Margin = New Padding(0)
			Me.tableLayoutPanel1.MinimumSize = New Size(460, 400)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 2
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Me.tableLayoutPanel1.Size = New Size(1158, 680)
			Me.tableLayoutPanel1.TabIndex = 1
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaDesign = cartesianArea1
			Me.tableLayoutPanel1.SetColumnSpan(Me.radChartView1, 2)
			Me.radChartView1.Dock = DockStyle.Fill
			Me.radChartView1.Location = New Point(0, 30)
			Me.radChartView1.Margin = New Padding(0)
			Me.radChartView1.Name = "radChartView1"
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.Size = New Size(384, 310)
			Me.radChartView1.TabIndex = 0
			Me.radChartView1.Text = "radChartView1"
			' 
			' radChartView2
			' 
			Me.radChartView2.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie
			Me.tableLayoutPanel1.SetColumnSpan(Me.radChartView2, 2)
			Me.radChartView2.Dock = DockStyle.Fill
			Me.radChartView2.Location = New Point(384, 30)
			Me.radChartView2.Margin = New Padding(0)
			Me.radChartView2.Name = "radChartView2"
			Me.radChartView2.ShowGrid = False
			Me.radChartView2.Size = New Size(384, 310)
			Me.radChartView2.TabIndex = 1
			Me.radChartView2.Text = "radChartView2"
			' 
			' radChartView3
			' 
			Me.radChartView3.AreaDesign = cartesianArea2
			Me.tableLayoutPanel1.SetColumnSpan(Me.radChartView3, 2)
			Me.radChartView3.Dock = DockStyle.Fill
			Me.radChartView3.Location = New Point(768, 30)
			Me.radChartView3.Margin = New Padding(0)
			Me.radChartView3.Name = "radChartView3"
			Me.radChartView3.ShowGrid = False
			Me.radChartView3.Size = New Size(390, 310)
			Me.radChartView3.TabIndex = 2
			Me.radChartView3.Text = "radChartView3"
			' 
			' radChartView4
			' 
			Me.radChartView4.AreaDesign = cartesianArea3
			Me.tableLayoutPanel1.SetColumnSpan(Me.radChartView4, 3)
			Me.radChartView4.Dock = DockStyle.Fill
			Me.radChartView4.Location = New Point(0, 370)
			Me.radChartView4.Margin = New Padding(0)
			Me.radChartView4.Name = "radChartView4"
			Me.radChartView4.ShowGrid = False
			Me.radChartView4.Size = New Size(576, 310)
			Me.radChartView4.TabIndex = 3
			Me.radChartView4.Text = "radChartView4"
			' 
			' radChartView5
			' 
			Me.radChartView5.AreaDesign = cartesianArea4
			Me.tableLayoutPanel1.SetColumnSpan(Me.radChartView5, 3)
			Me.radChartView5.Dock = DockStyle.Fill
			Me.radChartView5.Location = New Point(576, 370)
			Me.radChartView5.Margin = New Padding(0)
			Me.radChartView5.Name = "radChartView5"
			Me.radChartView5.ShowGrid = False
			Me.radChartView5.Size = New Size(582, 310)
			Me.radChartView5.TabIndex = 4
			Me.radChartView5.Text = "radChartView5"
			' 
			' radPanel1
			' 
			Me.radPanel1.BackColor = Color.White
			Me.tableLayoutPanel1.SetColumnSpan(Me.radPanel1, 2)
			Me.radPanel1.Dock = DockStyle.Fill
			Me.radPanel1.Font = New Font("Segoe UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radPanel1.Location = New Point(0, 0)
			Me.radPanel1.Margin = New Padding(0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(384, 30)
			Me.radPanel1.TabIndex = 4
			Me.radPanel1.TextAlignment = ContentAlignment.MiddleCenter
			CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "Bar Chart"
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = Color.White
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = ContentAlignment.MiddleCenter
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = Color.Black
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Margin = New Padding(0, 10, 0, 0)
			' 
			' radPanel2
			' 
			Me.radPanel2.BackColor = Color.White
			Me.tableLayoutPanel1.SetColumnSpan(Me.radPanel2, 2)
			Me.radPanel2.Dock = DockStyle.Fill
			Me.radPanel2.Font = New Font("Segoe UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radPanel2.Location = New Point(384, 0)
			Me.radPanel2.Margin = New Padding(0)
			Me.radPanel2.Name = "radPanel2"
			Me.radPanel2.Size = New Size(384, 30)
			Me.radPanel2.TabIndex = 4
			Me.radPanel2.TextAlignment = ContentAlignment.MiddleCenter
			CType(Me.radPanel2.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "Pie Chart"
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = Color.White
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = ContentAlignment.MiddleCenter
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = Color.Black
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Margin = New Padding(0, 10, 0, 0)
			' 
			' radPanel3
			' 
			Me.radPanel3.BackColor = Color.White
			Me.tableLayoutPanel1.SetColumnSpan(Me.radPanel3, 2)
			Me.radPanel3.Dock = DockStyle.Fill
			Me.radPanel3.Font = New Font("Segoe UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radPanel3.Location = New Point(768, 0)
			Me.radPanel3.Margin = New Padding(0)
			Me.radPanel3.Name = "radPanel3"
			Me.radPanel3.Size = New Size(390, 30)
			Me.radPanel3.TabIndex = 4
			Me.radPanel3.TextAlignment = ContentAlignment.MiddleCenter
			CType(Me.radPanel3.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "Radar Chart"
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = Color.White
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = ContentAlignment.MiddleCenter
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = Color.Black
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Margin = New Padding(0, 10, 0, 0)
			' 
			' radPanel4
			' 
			Me.radPanel4.BackColor = Color.White
			Me.tableLayoutPanel1.SetColumnSpan(Me.radPanel4, 3)
			Me.radPanel4.Dock = DockStyle.Fill
			Me.radPanel4.Font = New Font("Segoe UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radPanel4.Location = New Point(0, 340)
			Me.radPanel4.Margin = New Padding(0)
			Me.radPanel4.Name = "radPanel4"
			Me.radPanel4.Size = New Size(576, 30)
			Me.radPanel4.TabIndex = 4
			Me.radPanel4.TextAlignment = ContentAlignment.MiddleCenter
			CType(Me.radPanel4.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "Line Chart"
			CType(Me.radPanel4.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = Color.White
			CType(Me.radPanel4.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radPanel4.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = ContentAlignment.MiddleCenter
			CType(Me.radPanel4.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = Color.Black
			CType(Me.radPanel4.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Margin = New Padding(0, 10, 0, 0)
			' 
			' radPanel5
			' 
			Me.radPanel5.BackColor = Color.White
			Me.tableLayoutPanel1.SetColumnSpan(Me.radPanel5, 3)
			Me.radPanel5.Dock = DockStyle.Fill
			Me.radPanel5.Font = New Font("Segoe UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radPanel5.Location = New Point(576, 340)
			Me.radPanel5.Margin = New Padding(0)
			Me.radPanel5.Name = "radPanel5"
			Me.radPanel5.Size = New Size(582, 30)
			Me.radPanel5.TabIndex = 4
			Me.radPanel5.TextAlignment = ContentAlignment.MiddleCenter
			CType(Me.radPanel5.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "Spline Area Chart"
			CType(Me.radPanel5.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = Color.White
			CType(Me.radPanel5.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radPanel5.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = ContentAlignment.MiddleCenter
			CType(Me.radPanel5.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = Color.Black
			CType(Me.radPanel5.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Margin = New Padding(0, 10, 0, 0)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScrollMinSize = New Size(460, 400)
			Me.Controls.Add(Me.tableLayoutPanel1)
			Me.Name = "Form1"
			Me.Size = New Size(1168, 690)
			Me.Controls.SetChildIndex(Me.tableLayoutPanel1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radListControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tableLayoutPanel1.ResumeLayout(False)
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radChartView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radChartView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radChartView4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radChartView5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radListControl1 As Telerik.WinControls.UI.RadListControl
		Private tableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radChartView2 As Telerik.WinControls.UI.RadChartView
		Private radChartView3 As Telerik.WinControls.UI.RadChartView
		Private radChartView4 As Telerik.WinControls.UI.RadChartView
		Private radChartView5 As Telerik.WinControls.UI.RadChartView
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radPanel2 As Telerik.WinControls.UI.RadPanel
		Private radPanel3 As Telerik.WinControls.UI.RadPanel
		Private radPanel4 As Telerik.WinControls.UI.RadPanel
		Private radPanel5 As Telerik.WinControls.UI.RadPanel

	End Class
End Namespace
