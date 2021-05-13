Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Bar
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim cartesianArea2 As New Telerik.WinControls.UI.CartesianArea()
			Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem5 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem6 As New Telerik.WinControls.UI.RadListDataItem()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.showLabelsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
			Me.orientationCheckBox = New Telerik.WinControls.UI.RadCheckBox()
			Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.showLabelsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.orientationCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(0, 1)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
			Me.settingsPanel.PanelContainer.Size = New Size(228, 883)
			Me.settingsPanel.Size = New Size(228, 883)
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaDesign = cartesianArea2
			Me.radChartView1.Dock = DockStyle.Fill
			Me.radChartView1.Location = New Point(0, 0)
			Me.radChartView1.MinimumSize = New Size(550, 320)
			Me.radChartView1.Name = "radChartView1"
			' 
			' 
			' 
			Me.radChartView1.RootElement.MinSize = New Size(550, 320)
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.ShowToolTip = True
			Me.radChartView1.Size = New Size(1473, 786)
			Me.radChartView1.TabIndex = 1
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(3, 3)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(85, 18)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Combine mode:"
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New Point(3, 135)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(106, 18)
			Me.radLabel2.TabIndex = 1
			Me.radLabel2.Text = "Change Orientation:"
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.DropDownAnimationEnabled = False
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem4.Text = "Cluster"
			radListDataItem5.Text = "Stack"
			radListDataItem6.Text = "Stack100"
			Me.radDropDownList1.Items.Add(radListDataItem4)
			Me.radDropDownList1.Items.Add(radListDataItem5)
			Me.radDropDownList1.Items.Add(radListDataItem6)
			Me.radDropDownList1.Location = New Point(3, 47)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.Size = New Size(194, 20)
			Me.radDropDownList1.TabIndex = 2
			' 
			' showLabelsCheckBox
			' 
			Me.showLabelsCheckBox.Location = New Point(3, 91)
			Me.showLabelsCheckBox.Name = "showLabelsCheckBox"
			Me.showLabelsCheckBox.Size = New Size(82, 18)
			Me.showLabelsCheckBox.TabIndex = 3
			Me.showLabelsCheckBox.Text = "Show Labels"
			' 
			' orientationCheckBox
			' 
			Me.orientationCheckBox.Location = New Point(3, 179)
			Me.orientationCheckBox.Name = "orientationCheckBox"
			Me.orientationCheckBox.Size = New Size(72, 18)
			Me.orientationCheckBox.TabIndex = 4
			Me.orientationCheckBox.Text = "Horizontal"
			' 
			' tableLayoutPanel1
			' 
			Me.doubleBufferedTableLayoutPanel1.Anchor = AnchorStyles.Top
			Me.doubleBufferedTableLayoutPanel1.ColumnCount = 1
			Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 0)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radDropDownList1, 0, 1)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.orientationCheckBox, 0, 4)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.showLabelsCheckBox, 0, 2)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel2, 0, 3)
			Me.doubleBufferedTableLayoutPanel1.Location = New Point(5, 46)
			Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
			Me.doubleBufferedTableLayoutPanel1.RowCount = 5
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66667F))
			Me.doubleBufferedTableLayoutPanel1.Size = New Size(218, 223)
			Me.doubleBufferedTableLayoutPanel1.TabIndex = 5
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.AutoScrollMinSize = New Size(550, 320)
			Me.Controls.Add(Me.radChartView1)
			Me.Name = "Form1"
			Me.Size = New Size(1483, 796)
			Me.Controls.SetChildIndex(Me.radChartView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.showLabelsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.orientationCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
			Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
			Me.doubleBufferedTableLayoutPanel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private orientationCheckBox As Telerik.WinControls.UI.RadCheckBox
		Private showLabelsCheckBox As Telerik.WinControls.UI.RadCheckBox
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
	End Class
End Namespace
