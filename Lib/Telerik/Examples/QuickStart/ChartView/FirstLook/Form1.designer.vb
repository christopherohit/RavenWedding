Imports Telerik.WinControls
Namespace Telerik.Examples.WinControls.ChartView.FirstLook
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
			Dim tableViewDefinition1 As New Telerik.WinControls.UI.TableViewDefinition()
			Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.radChartView2 = New Telerik.WinControls.UI.RadChartView()
			Me.radChartView3 = New Telerik.WinControls.UI.RadChartView()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
			Me.radPanel3 = New Telerik.WinControls.UI.RadPanel()
			Me.radPanel4 = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radChartView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radChartView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(0, 19)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Size = New Size(0, 0)
			Me.settingsPanel.Size = New Size(0, 0)
			' 
			' tableLayoutPanel1
			' 
			Me.doubleBufferedTableLayoutPanel1.ColumnCount = 4
			Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
			Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 151F))
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radChartView1, 0, 2)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radChartView2, 2, 2)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radChartView3, 0, 4)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radGridView1, 2, 4)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radPanel1, 0, 0)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radPanel2, 0, 1)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radPanel3, 2, 1)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radPanel4, 0, 3)
			Me.doubleBufferedTableLayoutPanel1.Dock = DockStyle.Fill
			Me.doubleBufferedTableLayoutPanel1.Location = New Point(0, 0)
			Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
			Me.doubleBufferedTableLayoutPanel1.RowCount = 5
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 45F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Me.doubleBufferedTableLayoutPanel1.Size = New Size(1207, 786)
			Me.doubleBufferedTableLayoutPanel1.TabIndex = 1
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaDesign = cartesianArea1
			Me.radChartView1.Dock = DockStyle.Fill
			Me.radChartView1.Location = New Point(0, 75)
			Me.radChartView1.Margin = New Padding(0)
			Me.radChartView1.Name = "radChartView1"
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.Size = New Size(478, 340)
			Me.radChartView1.TabIndex = 0
			' 
			' radChartView2
			' 
			Me.radChartView2.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie
			Me.radChartView2.Dock = DockStyle.Fill
			Me.radChartView2.Location = New Point(578, 75)
			Me.radChartView2.Margin = New Padding(0)
			Me.radChartView2.Name = "radChartView2"
			Me.radChartView2.ShowGrid = False
			Me.radChartView2.Size = New Size(478, 340)
			Me.radChartView2.TabIndex = 1
			' 
			' radChartView3
			' 
			Me.radChartView3.AreaDesign = cartesianArea2
			Me.radChartView3.Dock = DockStyle.Fill
			Me.radChartView3.Location = New Point(0, 445)
			Me.radChartView3.Margin = New Padding(0)
			Me.radChartView3.Name = "radChartView3"
			Me.radChartView3.ShowGrid = False
			Me.radChartView3.Size = New Size(478, 341)
			Me.radChartView3.TabIndex = 2
			' 
			' radGridView1
			' 
			Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radGridView1, 2)
			Me.radGridView1.Dock = DockStyle.Fill
			Me.radGridView1.Location = New Point(578, 445)
			Me.radGridView1.Margin = New Padding(0)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.AllowCellContextMenu = False
			Me.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New Size(629, 341)
			Me.radGridView1.TabIndex = 0
			CType(Me.radGridView1.GetChildAt(0), Telerik.WinControls.UI.RadGridViewElement).BorderColor = Color.White
			' 
			' radPanel1
			' 
			Me.radPanel1.BackColor = Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(239)))), (CInt((CByte(238)))))
			Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radPanel1, 4)
			Me.radPanel1.Dock = DockStyle.Fill
			Me.radPanel1.Location = New Point(0, 0)
			Me.radPanel1.Margin = New Padding(0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(1207, 45)
			Me.radPanel1.TabIndex = 4
			Me.radPanel1.Text = "SALES DASHBOARD 2012"
			CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "SALES DASHBOARD 2012"
			CType(Me.radPanel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(239)))), (CInt((CByte(238)))))
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = False
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Margin = New Padding(10, 0, 0, 0)
			' 
			' radPanel2
			' 
			Me.radPanel2.BackColor = Color.White
			Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radPanel2, 2)
			Me.radPanel2.Dock = DockStyle.Fill
			Me.radPanel2.Font = New Font("Segoe UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radPanel2.Location = New Point(0, 45)
			Me.radPanel2.Margin = New Padding(0)
			Me.radPanel2.Name = "radPanel2"
			' 
			' 
			' 
			Me.radPanel2.RootElement.EnableElementShadow = False
			Me.radPanel2.Size = New Size(578, 30)
			Me.radPanel2.TabIndex = 4
			Me.radPanel2.Text = "SALES DASHBOARD 2012"
			CType(Me.radPanel2.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "Total sales by product"
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = Color.White
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = False
			CType(Me.radPanel2.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Margin = New Padding(10, 0, 0, 0)
			' 
			' radPanel3
			' 
			Me.radPanel3.BackColor = Color.White
			Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radPanel3, 2)
			Me.radPanel3.Dock = DockStyle.Fill
			Me.radPanel3.Font = New Font("Segoe UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radPanel3.Location = New Point(578, 45)
			Me.radPanel3.Margin = New Padding(0)
			Me.radPanel3.Name = "radPanel3"
			' 
			' 
			' 
			Me.radPanel3.RootElement.EnableElementShadow = False
			Me.radPanel3.Size = New Size(629, 30)
			Me.radPanel3.TabIndex = 4
			Me.radPanel3.Text = "SALES DASHBOARD 2012"
			CType(Me.radPanel3.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "Sales breakdown by region"
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = Color.White
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = False
			CType(Me.radPanel3.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Margin = New Padding(10, 0, 0, 0)
			' 
			' radPanel4
			' 
			Me.radPanel4.BackColor = Color.White
			Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radPanel4, 4)
			Me.radPanel4.Dock = DockStyle.Fill
			Me.radPanel4.Font = New Font("Segoe UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radPanel4.Location = New Point(0, 415)
			Me.radPanel4.Margin = New Padding(0)
			Me.radPanel4.Name = "radPanel4"
			' 
			' 
			' 
			Me.radPanel4.RootElement.EnableElementShadow = False
			Me.radPanel4.Size = New Size(1207, 30)
			Me.radPanel4.TabIndex = 4
			Me.radPanel4.Text = "SALES DASHBOARD 2012"
			CType(Me.radPanel4.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "Percent of target"
			CType(Me.radPanel4.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = Color.White
			CType(Me.radPanel4.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = False
			CType(Me.radPanel4.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Margin = New Padding(10, 0, 0, 0)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScrollMinSize = New Size(1148, 610)
			Me.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
			Me.Name = "Form1"
			Me.Size = New Size(1227, 796)
			Me.Controls.SetChildIndex(Me.doubleBufferedTableLayoutPanel1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radChartView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radChartView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radChartView2 As Telerik.WinControls.UI.RadChartView
		Private radChartView3 As Telerik.WinControls.UI.RadChartView
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radPanel2 As Telerik.WinControls.UI.RadPanel
		Private radPanel3 As Telerik.WinControls.UI.RadPanel
		Private radPanel4 As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace
