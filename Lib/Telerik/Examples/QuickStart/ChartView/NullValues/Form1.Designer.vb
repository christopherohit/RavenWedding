Namespace Telerik.Examples.WinControls.ChartView.NullValues
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
			Me.tableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.tableLayoutPanel2 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.leftButton = New Telerik.WinControls.UI.RadButton()
			Me.rightButton = New Telerik.WinControls.UI.RadButton()
			Me.radListView1 = New Telerik.WinControls.UI.RadListView()
			Me.tableLayoutPanel3 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.radPanorama1 = New Telerik.WinControls.UI.RadPanorama()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			Me.tableLayoutPanel1.SuspendLayout()
			Me.tableLayoutPanel2.SuspendLayout()
			CType(Me.leftButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rightButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radListView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tableLayoutPanel3.SuspendLayout()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanorama1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(0, 0)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBox1)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radDropDownList1)
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 1
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel3, 0, 1)
			Me.tableLayoutPanel1.Dock = DockStyle.Fill
			Me.tableLayoutPanel1.Location = New Point(0, 0)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 2
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 185F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
			Me.tableLayoutPanel1.Size = New Size(1473, 786)
			Me.tableLayoutPanel1.TabIndex = 3
			' 
			' tableLayoutPanel2
			' 
			Me.tableLayoutPanel2.ColumnCount = 3
			Me.tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 2F))
			Me.tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 96F))
			Me.tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 2F))
			Me.tableLayoutPanel2.Controls.Add(Me.leftButton, 0, 0)
			Me.tableLayoutPanel2.Controls.Add(Me.rightButton, 2, 0)
			Me.tableLayoutPanel2.Controls.Add(Me.radListView1, 1, 0)
			Me.tableLayoutPanel2.Dock = DockStyle.Fill
			Me.tableLayoutPanel2.Location = New Point(3, 3)
			Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
			Me.tableLayoutPanel2.RowCount = 1
			Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 179F))
			Me.tableLayoutPanel2.Size = New Size(1467, 179)
			Me.tableLayoutPanel2.TabIndex = 0
			' 
			' leftButton
			' 
			Me.leftButton.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Right), AnchorStyles))
			Me.leftButton.Location = New Point(11, 3)
			Me.leftButton.Name = "leftButton"
			Me.leftButton.Size = New Size(15, 173)
			Me.leftButton.TabIndex = 0
			Me.leftButton.Text = "▼"
'			Me.leftButton.Click += New System.EventHandler(Me.leftButton_Click)
			' 
			' rightButton
			' 
			Me.rightButton.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left), AnchorStyles))
			Me.rightButton.Location = New Point(1440, 3)
			Me.rightButton.Name = "rightButton"
			Me.rightButton.Size = New Size(16, 173)
			Me.rightButton.TabIndex = 1
			Me.rightButton.Text = "▼"
'			Me.rightButton.Click += New System.EventHandler(Me.rightButton_Click)
			' 
			' radListView1
			' 
			Me.radListView1.Dock = DockStyle.Fill
			Me.radListView1.Location = New Point(32, 3)
			Me.radListView1.Name = "radListView1"
			Me.radListView1.Size = New Size(1402, 173)
			Me.radListView1.TabIndex = 2
			' 
			' tableLayoutPanel3
			' 
			Me.tableLayoutPanel3.ColumnCount = 2
			Me.tableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 69.87048F))
			Me.tableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.12952F))
			Me.tableLayoutPanel3.Controls.Add(Me.radChartView1, 0, 0)
			Me.tableLayoutPanel3.Controls.Add(Me.radPanorama1, 1, 0)
			Me.tableLayoutPanel3.Dock = DockStyle.Fill
			Me.tableLayoutPanel3.Location = New Point(3, 188)
			Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
			Me.tableLayoutPanel3.RowCount = 1
			Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
			Me.tableLayoutPanel3.Size = New Size(1467, 595)
			Me.tableLayoutPanel3.TabIndex = 1
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaDesign = cartesianArea1
			Me.radChartView1.Dock = DockStyle.Fill
			Me.radChartView1.Location = New Point(3, 3)
			Me.radChartView1.Name = "radChartView1"
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.Size = New Size(1018, 589)
			Me.radChartView1.TabIndex = 0
			' 
			' radPanorama1
			' 
			Me.radPanorama1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radPanorama1.Location = New Point(1027, 3)
			Me.radPanorama1.Name = "radPanorama1"
			Me.radPanorama1.Size = New Size(437, 589)
			Me.radPanorama1.TabIndex = 1
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.Anchor = AnchorStyles.Top
			Me.radDropDownList1.DropDownAnimationEnabled = False
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownList1.Location = New Point(5, 65)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.Size = New Size(220, 20)
			Me.radDropDownList1.TabIndex = 0
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.Anchor = AnchorStyles.Top
			Me.radCheckBox1.Location = New Point(5, 103)
			Me.radCheckBox1.Name = "radCheckBox1"
			Me.radCheckBox1.Size = New Size(82, 18)
			Me.radCheckBox1.TabIndex = 0
			Me.radCheckBox1.Text = "Show Labels"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.tableLayoutPanel1)
			Me.Name = "Form1"
			Me.Size = New Size(1483, 796)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.tableLayoutPanel1, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.tableLayoutPanel2.ResumeLayout(False)
			CType(Me.leftButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rightButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radListView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tableLayoutPanel3.ResumeLayout(False)
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanorama1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents leftButton As Telerik.WinControls.UI.RadButton
		Private WithEvents rightButton As Telerik.WinControls.UI.RadButton
		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radPanorama1 As Telerik.WinControls.UI.RadPanorama
		Private radListView1 As Telerik.WinControls.UI.RadListView
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private tableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
		Private tableLayoutPanel2 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
		Private tableLayoutPanel3 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
	End Class
End Namespace