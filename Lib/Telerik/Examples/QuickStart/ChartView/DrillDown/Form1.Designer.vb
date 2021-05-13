Namespace Telerik.Examples.WinControls.ChartView.DrillDown
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim cartesianArea1 As New Telerik.WinControls.UI.CartesianArea()
			Me.btnSpy = New Telerik.WinControls.UI.RadButton()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.bindingSource1 = New BindingSource(Me.components)
			Me.chartDataSet = New Telerik.Examples.WinControls.DataSources.ChartDataSet()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.btnSpy, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Size = New Size(200, 279)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' btnSpy
			' 
			Me.btnSpy.Anchor = AnchorStyles.Top
			Me.btnSpy.Image = (CType(resources.GetObject("btnSpy.Image"), Image))
			Me.btnSpy.Location = New Point(246, 7)
			Me.btnSpy.Name = "btnSpy"
			Me.btnSpy.Padding = New Padding(2, 0, 0, 0)
			Me.btnSpy.Size = New Size(120, 24)
			Me.btnSpy.TabIndex = 0
			Me.btnSpy.Text = "RadControl Spy "
			Me.btnSpy.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.btnSpy.ThemeName = "ControlDefault"
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaDesign = cartesianArea1
			Me.radChartView1.BackColor = SystemColors.ControlLightLight
			Me.radChartView1.Dock = DockStyle.Fill
			Me.radChartView1.Location = New Point(0, 0)
			Me.radChartView1.MinimumSize = New Size(450, 350)
			Me.radChartView1.Name = "radChartView1"
			' 
			' 
			' 
			Me.radChartView1.RootElement.ControlBounds = New Rectangle(0, 0, 480, 320)
			Me.radChartView1.RootElement.MinSize = New Size(450, 350)
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.Size = New Size(1158, 612)
			Me.radChartView1.TabIndex = 0
			Me.radChartView1.Text = "radChartView1"
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataSource = Me.chartDataSet
			Me.bindingSource1.Position = 0
			' 
			' chartDataSet
			' 
			Me.chartDataSet.DataSetName = "ChartDataSet"
			Me.chartDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.Anchor = AnchorStyles.Top
			Me.radDropDownList1.Location = New Point(5, 21)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.Size = New Size(170, 20)
			Me.radDropDownList1.TabIndex = 1
			Me.radDropDownList1.Text = "radDropDownList1"
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radDropDownList1)
			Me.radGroupBox1.HeaderText = "Drill Navigator Style"
			Me.radGroupBox1.Location = New Point(10, 46)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New Size(180, 58)
			Me.radGroupBox1.TabIndex = 2
			Me.radGroupBox1.Text = "Drill Navigator Style"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScrollMinSize = New Size(450, 350)
			Me.Controls.Add(Me.radChartView1)
			Me.Name = "Form1"
			Me.Size = New Size(1168, 622)
			Me.Controls.SetChildIndex(Me.radChartView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.btnSpy, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private bindingSource1 As BindingSource
		Private chartDataSet As Telerik.Examples.WinControls.DataSources.ChartDataSet
		Private btnSpy As Telerik.WinControls.UI.RadButton
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace