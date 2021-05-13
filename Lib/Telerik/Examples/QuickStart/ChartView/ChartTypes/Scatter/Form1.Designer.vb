Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Scatter
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim cartesianArea1 As New Telerik.WinControls.UI.CartesianArea()
			Me.employeeBindingSource = New BindingSource(Me.components)
			Me.adventureLT2008DataSet = New Telerik.Examples.WinControls.DataSources.AdventureLT2008DataSet()
			Me.imageList1 = New ImageList(Me.components)
			Me.employeeTableAdapter = New Telerik.Examples.WinControls.DataSources.AdventureLT2008DataSetTableAdapters.EmployeeTableAdapter()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radCheckBoxSpline = New Telerik.WinControls.UI.RadCheckBox()
			Me.radDropDownListSeriesType = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditorPointRadius = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radButtonEditShape = New Telerik.WinControls.UI.RadButton()
			Me.radDropDownListShapes = New Telerik.WinControls.UI.RadDropDownList()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.employeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.adventureLT2008DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radCheckBoxSpline, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownListSeriesType, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorPointRadius, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonEditShape, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownListShapes, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(0, 216)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.PanelContainer.Size = New Size(220, 624)
			Me.settingsPanel.Size = New Size(220, 624)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' employeeBindingSource
			' 
			Me.employeeBindingSource.DataMember = "Employee"
			Me.employeeBindingSource.DataSource = Me.adventureLT2008DataSet
			' 
			' adventureLT2008DataSet
			' 
			Me.adventureLT2008DataSet.DataSetName = "AdventureLT2008DataSet"
			Me.adventureLT2008DataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "User Business Male.png")
			' 
			' employeeTableAdapter
			' 
			Me.employeeTableAdapter.ClearBeforeFill = True
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaDesign = cartesianArea1
			Me.radChartView1.Dock = DockStyle.Fill
			Me.radChartView1.ImageList = Me.imageList1
			Me.radChartView1.Location = New Point(0, 0)
			Me.radChartView1.MinimumSize = New Size(550, 320)
			Me.radChartView1.Name = "radChartView1"
			' 
			' 
			' 
			Me.radChartView1.RootElement.MinSize = New Size(550, 320)
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.Size = New Size(1230, 786)
			Me.radChartView1.TabIndex = 1
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radCheckBoxSpline)
			Me.radGroupBox1.Controls.Add(Me.radDropDownListSeriesType)
			Me.radGroupBox1.Controls.Add(Me.radLabel4)
			Me.radGroupBox1.HeaderText = "Series"
			Me.radGroupBox1.Location = New Point(3, 43)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New Size(210, 117)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Series"
			' 
			' radCheckBoxSpline
			' 
			Me.radCheckBoxSpline.Anchor = AnchorStyles.Top
			Me.radCheckBoxSpline.Location = New Point(5, 85)
			Me.radCheckBoxSpline.Name = "radCheckBoxSpline"
			Me.radCheckBoxSpline.Size = New Size(51, 18)
			Me.radCheckBoxSpline.TabIndex = 5
			Me.radCheckBoxSpline.Text = "Spline"
			' 
			' radDropDownListSeriesType
			' 
			Me.radDropDownListSeriesType.Anchor = AnchorStyles.Top
			Me.radDropDownListSeriesType.DropDownAnimationEnabled = False
			Me.radDropDownListSeriesType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownListSeriesType.Location = New Point(5, 45)
			Me.radDropDownListSeriesType.Name = "radDropDownListSeriesType"
			Me.radDropDownListSeriesType.Size = New Size(200, 20)
			Me.radDropDownListSeriesType.TabIndex = 4
			Me.radDropDownListSeriesType.Text = "radDropDownList1"
			' 
			' radLabel4
			' 
			Me.radLabel4.Anchor = AnchorStyles.Top
			Me.radLabel4.Location = New Point(5, 21)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New Size(60, 18)
			Me.radLabel4.TabIndex = 2
			Me.radLabel4.Text = "Series type"
			' 
			' radSpinEditorPointRadius
			' 
			Me.radSpinEditorPointRadius.Anchor = AnchorStyles.Top
			Me.radSpinEditorPointRadius.Location = New Point(5, 123)
			Me.radSpinEditorPointRadius.Name = "radSpinEditorPointRadius"
			Me.radSpinEditorPointRadius.NullableValue = New Decimal(New Integer() { 1, 0, 0, 0})
			' 
			' 
			' 
			Me.radSpinEditorPointRadius.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorPointRadius.Size = New Size(200, 20)
			Me.radSpinEditorPointRadius.TabIndex = 3
			Me.radSpinEditorPointRadius.TabStop = False
			Me.radSpinEditorPointRadius.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = AnchorStyles.Top
			Me.radLabel3.Location = New Point(5, 99)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(53, 18)
			Me.radLabel3.TabIndex = 2
			Me.radLabel3.Text = "Point size"
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(5, 35)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(36, 18)
			Me.radLabel1.TabIndex = 2
			Me.radLabel1.Text = "Shape"
			' 
			' radButtonEditShape
			' 
			Me.radButtonEditShape.Anchor = AnchorStyles.Top
			Me.radButtonEditShape.Location = New Point(5, 163)
			Me.radButtonEditShape.Name = "radButtonEditShape"
			Me.radButtonEditShape.Size = New Size(200, 30)
			Me.radButtonEditShape.TabIndex = 1
			Me.radButtonEditShape.Text = "Edit shape"
			' 
			' radDropDownListShapes
			' 
			Me.radDropDownListShapes.Anchor = AnchorStyles.Top
			Me.radDropDownListShapes.DropDownAnimationEnabled = False
			Me.radDropDownListShapes.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownListShapes.Location = New Point(5, 59)
			Me.radDropDownListShapes.Name = "radDropDownListShapes"
			Me.radDropDownListShapes.Size = New Size(200, 20)
			Me.radDropDownListShapes.TabIndex = 0
			Me.radDropDownListShapes.Text = "radDropDownList1"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Anchor = AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.radLabel1)
			Me.radGroupBox2.Controls.Add(Me.radDropDownListShapes)
			Me.radGroupBox2.Controls.Add(Me.radSpinEditorPointRadius)
			Me.radGroupBox2.Controls.Add(Me.radButtonEditShape)
			Me.radGroupBox2.Controls.Add(Me.radLabel3)
			Me.radGroupBox2.HeaderText = "Data points"
			Me.radGroupBox2.Location = New Point(3, 177)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Size = New Size(210, 198)
			Me.radGroupBox2.TabIndex = 3
			Me.radGroupBox2.Text = "Data points"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.AutoScrollMinSize = New Size(550, 320)
			Me.Controls.Add(Me.radChartView1)
			Me.Name = "Form1"
			Me.Size = New Size(1240, 796)
			Me.Controls.SetChildIndex(Me.radChartView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.employeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.adventureLT2008DataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radCheckBoxSpline, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownListSeriesType, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorPointRadius, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonEditShape, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownListShapes, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private employeeBindingSource As BindingSource
		Private adventureLT2008DataSet As DataSources.AdventureLT2008DataSet
		Private employeeTableAdapter As DataSources.AdventureLT2008DataSetTableAdapters.EmployeeTableAdapter
		Private imageList1 As ImageList
		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radDropDownListShapes As Telerik.WinControls.UI.RadDropDownList
		Private radButtonEditShape As Telerik.WinControls.UI.RadButton
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radSpinEditorPointRadius As Telerik.WinControls.UI.RadSpinEditor
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radCheckBoxSpline As Telerik.WinControls.UI.RadCheckBox
		Private radDropDownListSeriesType As Telerik.WinControls.UI.RadDropDownList
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace
