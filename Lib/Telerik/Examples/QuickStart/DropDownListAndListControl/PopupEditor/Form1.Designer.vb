Namespace Telerik.Examples.WinControls.DropDownListAndListControl.PopupEditor
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
            Dim cartesianArea2 As New Telerik.WinControls.UI.CartesianArea()
            Dim categoricalAxis2 As New Telerik.WinControls.UI.CategoricalAxis()
            Dim linearAxis2 As New Telerik.WinControls.UI.LinearAxis()
            Dim barSeries3 As New Telerik.WinControls.UI.BarSeries()
            Dim categoricalDataPoint11 As New Telerik.Charting.CategoricalDataPoint()
            Dim categoricalDataPoint12 As New Telerik.Charting.CategoricalDataPoint()
            Dim categoricalDataPoint13 As New Telerik.Charting.CategoricalDataPoint()
            Dim categoricalDataPoint14 As New Telerik.Charting.CategoricalDataPoint()
            Dim categoricalDataPoint15 As New Telerik.Charting.CategoricalDataPoint()
            Dim barSeries4 As New Telerik.WinControls.UI.BarSeries()
            Dim categoricalDataPoint16 As New Telerik.Charting.CategoricalDataPoint()
            Dim categoricalDataPoint17 As New Telerik.Charting.CategoricalDataPoint()
            Dim categoricalDataPoint18 As New Telerik.Charting.CategoricalDataPoint()
            Dim categoricalDataPoint19 As New Telerik.Charting.CategoricalDataPoint()
            Dim categoricalDataPoint20 As New Telerik.Charting.CategoricalDataPoint()
            Me.radPopupEditor1 = New Telerik.WinControls.UI.RadPopupEditor()
            Me.radPopupContainer1 = New Telerik.WinControls.UI.RadPopupContainer()
            Me.radClock1 = New Telerik.WinControls.UI.RadClock()
            Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.radPopupContainer2 = New Telerik.WinControls.UI.RadPopupContainer()
            Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
            Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
            Me.northwindDataSetBindingSource = New BindingSource(Me.components)
            Me.radPopupEditor2 = New Telerik.WinControls.UI.RadPopupEditor()
            Me.radPopupContainer3 = New Telerik.WinControls.UI.RadPopupContainer()
            Me.radTrackBar3 = New Telerik.WinControls.UI.RadTrackBar()
            Me.radTrackBar2 = New Telerik.WinControls.UI.RadTrackBar()
            Me.radTrackBar1 = New Telerik.WinControls.UI.RadTrackBar()
            Me.radPopupEditor3 = New Telerik.WinControls.UI.RadPopupEditor()
            CType(Me.radPopupEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPopupContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPopupContainer1.PanelContainer.SuspendLayout()
            Me.radPopupContainer1.SuspendLayout()
            CType(Me.radClock1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPopupContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPopupContainer2.PanelContainer.SuspendLayout()
            Me.radPopupContainer2.SuspendLayout()
            CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.northwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPopupEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPopupContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPopupContainer3.PanelContainer.SuspendLayout()
            Me.radPopupContainer3.SuspendLayout()
            CType(Me.radTrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPopupEditor3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' radPopupEditor1
            ' 
            Me.radPopupEditor1.AssociatedControl = Me.radPopupContainer1
            Me.radPopupEditor1.Location = New Point(0, 80)
            Me.radPopupEditor1.Name = "radPopupEditor1"
            Me.radPopupEditor1.ShowTextBox = False
            Me.radPopupEditor1.Size = New Size(155, 20)
            Me.radPopupEditor1.TabIndex = 0
            Me.radPopupEditor1.Text = "radPopupEditor1"
            ' 
            ' radPopupContainer1
            ' 
            Me.radPopupContainer1.Location = New Point(3, 23)
            Me.radPopupContainer1.Name = "radPopupContainer1"
            ' 
            ' radPopupContainer1.PanelContainer
            ' 
            Me.radPopupContainer1.PanelContainer.Controls.Add(Me.radClock1)
            Me.radPopupContainer1.PanelContainer.Controls.Add(Me.radCalendar1)
            Me.radPopupContainer1.PanelContainer.Size = New Size(383, 196)
            Me.radPopupContainer1.Size = New Size(385, 198)
            Me.radPopupContainer1.TabIndex = 1
            Me.radPopupContainer1.Text = "radPopupContainer1"
            ' 
            ' radClock1
            ' 
            Me.radClock1.Location = New Point(242, 29)
            Me.radClock1.Name = "radClock1"
            Me.radClock1.Size = New Size(134, 135)
            Me.radClock1.TabIndex = 1
            Me.radClock1.Text = "radClock1"
            ' 
            ' radCalendar1
            ' 
            Me.radCalendar1.Location = New Point(3, 3)
            Me.radCalendar1.Name = "radCalendar1"
            Me.radCalendar1.Size = New Size(233, 190)
            Me.radCalendar1.TabIndex = 0
            Me.radCalendar1.Text = "radCalendar1"
            ' 
            ' timer1
            ' 
            Me.timer1.Enabled = True
            '			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick)
            ' 
            ' radPopupContainer2
            ' 
            Me.radPopupContainer2.Location = New Point(3, 274)
            Me.radPopupContainer2.Name = "radPopupContainer2"
            ' 
            ' radPopupContainer2.PanelContainer
            ' 
            Me.radPopupContainer2.PanelContainer.Controls.Add(Me.radChartView1)
            Me.radPopupContainer2.PanelContainer.Size = New Size(525, 287)
            Me.radPopupContainer2.Size = New Size(527, 289)
            Me.radPopupContainer2.TabIndex = 2
            Me.radPopupContainer2.Text = "radPopupContainer2"
            ' 
            ' radChartView1
            ' 
            Me.radChartView1.AreaDesign = cartesianArea2
            categoricalAxis2.IsPrimary = True
            categoricalAxis2.LabelRotationAngle = 300.0R
            categoricalAxis2.Title = ""
            linearAxis2.AxisType = Telerik.Charting.AxisType.Second
            linearAxis2.IsPrimary = True
            linearAxis2.LabelRotationAngle = 300.0R
            linearAxis2.MajorStep = 10.0R
            linearAxis2.TickOrigin = Nothing
            linearAxis2.Title = ""
            Me.radChartView1.Axes.AddRange(New Telerik.WinControls.UI.Axis() {categoricalAxis2, linearAxis2})
            Me.radChartView1.Dock = DockStyle.Fill
            Me.radChartView1.Location = New Point(0, 0)
            Me.radChartView1.Name = "radChartView1"
            categoricalDataPoint11.Category = "A"
            categoricalDataPoint11.Label = 64.0R
            categoricalDataPoint11.Value = 64.0R
            categoricalDataPoint12.Category = "B"
            categoricalDataPoint12.Label = 68.0R
            categoricalDataPoint12.Value = 68.0R
            categoricalDataPoint13.Category = "C"
            categoricalDataPoint13.Label = 56.0R
            categoricalDataPoint13.Value = 56.0R
            categoricalDataPoint14.Category = "D"
            categoricalDataPoint14.Label = 97.0R
            categoricalDataPoint14.Value = 97.0R
            categoricalDataPoint15.Category = "E"
            categoricalDataPoint15.Label = 99.0R
            categoricalDataPoint15.Value = 99.0R
            barSeries3.DataPoints.AddRange(New Telerik.Charting.DataPoint() {categoricalDataPoint11, categoricalDataPoint12, categoricalDataPoint13, categoricalDataPoint14, categoricalDataPoint15})
            barSeries3.HorizontalAxis = categoricalAxis2
            barSeries3.LabelMode = Telerik.WinControls.UI.BarLabelModes.Top
            barSeries3.LegendTitle = Nothing
            barSeries3.VerticalAxis = linearAxis2
            categoricalDataPoint16.Category = "A"
            categoricalDataPoint16.Label = 13.0R
            categoricalDataPoint16.Value = 13.0R
            categoricalDataPoint17.Category = "B"
            categoricalDataPoint17.Label = 59.0R
            categoricalDataPoint17.Value = 59.0R
            categoricalDataPoint18.Category = "C"
            categoricalDataPoint18.Label = 99.0R
            categoricalDataPoint18.Value = 99.0R
            categoricalDataPoint19.Category = "D"
            categoricalDataPoint19.Label = 27.0R
            categoricalDataPoint19.Value = 27.0R
            categoricalDataPoint20.Category = "E"
            categoricalDataPoint20.Label = 66.0R
            categoricalDataPoint20.Value = 66.0R
            barSeries4.DataPoints.AddRange(New Telerik.Charting.DataPoint() {categoricalDataPoint16, categoricalDataPoint17, categoricalDataPoint18, categoricalDataPoint19, categoricalDataPoint20})
            barSeries4.HorizontalAxis = categoricalAxis2
            barSeries4.LabelMode = Telerik.WinControls.UI.BarLabelModes.Top
            barSeries4.LegendTitle = Nothing
            barSeries4.VerticalAxis = linearAxis2
            Me.radChartView1.Series.AddRange(New Telerik.WinControls.UI.ChartSeries() {barSeries3, barSeries4})
            Me.radChartView1.ShowGrid = False
            Me.radChartView1.Size = New Size(525, 287)
            Me.radChartView1.TabIndex = 0
            Me.radChartView1.Text = "radChartView1"
            ' 
            ' northwindDataSet
            ' 
            Me.northwindDataSet.DataSetName = "NorthwindDataSet"
            Me.northwindDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
            ' 
            ' northwindDataSetBindingSource
            ' 
            Me.northwindDataSetBindingSource.DataSource = Me.northwindDataSet
            Me.northwindDataSetBindingSource.Position = 0
            ' 
            ' radPopupEditor2
            ' 
            Me.radPopupEditor2.AssociatedControl = Me.radPopupContainer2
            Me.radPopupEditor2.Location = New Point(0, 40)
            Me.radPopupEditor2.Name = "radPopupEditor2"
            Me.radPopupEditor2.ShowTextBox = False
            Me.radPopupEditor2.Size = New Size(155, 20)
            Me.radPopupEditor2.TabIndex = 3
            Me.radPopupEditor2.Text = "Trends"
            ' 
            ' radPopupContainer3
            ' 
            Me.radPopupContainer3.Location = New Point(4, 613)
            Me.radPopupContainer3.Name = "radPopupContainer3"
            ' 
            ' radPopupContainer3.PanelContainer
            ' 
            Me.radPopupContainer3.PanelContainer.Controls.Add(Me.radTrackBar3)
            Me.radPopupContainer3.PanelContainer.Controls.Add(Me.radTrackBar2)
            Me.radPopupContainer3.PanelContainer.Controls.Add(Me.radTrackBar1)
            Me.radPopupContainer3.PanelContainer.Size = New Size(446, 238)
            Me.radPopupContainer3.Size = New Size(448, 240)
            Me.radPopupContainer3.TabIndex = 4
            Me.radPopupContainer3.Text = "radPopupContainer3"
            ' 
            ' radTrackBar3
            ' 
            Me.radTrackBar3.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.radTrackBar3.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.BottomRight
            Me.radTrackBar3.Location = New Point(17, 179)
            Me.radTrackBar3.Name = "radTrackBar3"
            Me.radTrackBar3.Size = New Size(405, 45)
            Me.radTrackBar3.TabIndex = 2
            Me.radTrackBar3.Text = "radTrackBar3"
            Me.radTrackBar3.TickStyle = Telerik.WinControls.Enumerations.TickStyles.TopLeft
            Me.radTrackBar3.Value = 15.0F
            ' 
            ' radTrackBar2
            ' 
            Me.radTrackBar2.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.radTrackBar2.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.TopLeft
            Me.radTrackBar2.Location = New Point(17, 100)
            Me.radTrackBar2.Name = "radTrackBar2"
            Me.radTrackBar2.Size = New Size(405, 45)
            Me.radTrackBar2.TabIndex = 1
            Me.radTrackBar2.Text = "radTrackBar2"
            Me.radTrackBar2.TickStyle = Telerik.WinControls.Enumerations.TickStyles.BottomRight
            Me.radTrackBar2.Value = 5.0F
            ' 
            ' radTrackBar1
            ' 
            Me.radTrackBar1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.radTrackBar1.Location = New Point(17, 19)
            Me.radTrackBar1.Name = "radTrackBar1"
            Me.radTrackBar1.Size = New Size(405, 37)
            Me.radTrackBar1.TabIndex = 0
            Me.radTrackBar1.Text = "radTrackBar1"
            Me.radTrackBar1.Value = 2.0F
            ' 
            ' radPopupEditor3
            ' 
            Me.radPopupEditor3.AssociatedControl = Me.radPopupContainer3
            Me.radPopupEditor3.Location = New Point(0, 0)
            Me.radPopupEditor3.Name = "radPopupEditor3"
            Me.radPopupEditor3.ShowTextBox = False
            Me.radPopupEditor3.Size = New Size(155, 20)
            Me.radPopupEditor3.TabIndex = 5
            Me.radPopupEditor3.Text = "Settings"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = AutoScaleMode.Dpi
            Me.ClientSize = New Size(1416, 878)
            Me.Controls.Add(Me.radPopupEditor3)
            Me.Controls.Add(Me.radPopupContainer3)
            Me.Controls.Add(Me.radPopupEditor2)
            Me.Controls.Add(Me.radPopupContainer2)
            Me.Controls.Add(Me.radPopupContainer1)
            Me.Controls.Add(Me.radPopupEditor1)
            Me.Name = "Form1"
            '			Me.Load += New System.EventHandler(Me.Form1_Load)
            CType(Me.radPopupEditor1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPopupContainer1.PanelContainer.ResumeLayout(False)
            Me.radPopupContainer1.PanelContainer.PerformLayout()
            CType(Me.radPopupContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPopupContainer1.ResumeLayout(False)
            CType(Me.radClock1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPopupContainer2.PanelContainer.ResumeLayout(False)
            CType(Me.radPopupContainer2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPopupContainer2.ResumeLayout(False)
            CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.northwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPopupEditor2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPopupContainer3.PanelContainer.ResumeLayout(False)
            Me.radPopupContainer3.PanelContainer.PerformLayout()
            CType(Me.radPopupContainer3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPopupContainer3.ResumeLayout(False)
            CType(Me.radTrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPopupEditor3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private radPopupEditor1 As Telerik.WinControls.UI.RadPopupEditor
        Private WithEvents timer1 As Timer
        Private radPopupContainer1 As Telerik.WinControls.UI.RadPopupContainer
        Private radClock1 As Telerik.WinControls.UI.RadClock
        Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
        Private radPopupContainer2 As Telerik.WinControls.UI.RadPopupContainer
        Private radChartView1 As Telerik.WinControls.UI.RadChartView
        Private northwindDataSet As DataSources.NorthwindDataSet
        Private northwindDataSetBindingSource As BindingSource
        Private radPopupEditor2 As Telerik.WinControls.UI.RadPopupEditor
        Private radPopupContainer3 As Telerik.WinControls.UI.RadPopupContainer
        Private radTrackBar3 As Telerik.WinControls.UI.RadTrackBar
        Private radTrackBar2 As Telerik.WinControls.UI.RadTrackBar
        Private radTrackBar1 As Telerik.WinControls.UI.RadTrackBar
        Private radPopupEditor3 As Telerik.WinControls.UI.RadPopupEditor
    End Class
End Namespace