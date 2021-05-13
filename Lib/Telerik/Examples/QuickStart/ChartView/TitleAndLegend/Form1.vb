Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Tests
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.TitleAndLegend
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private customShape As CustomShape

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radChartView1.ShowTitle = True
			Me.radChartView1.ShowLegend = True
			Me.radChartView1.Title = "OS Platform Statistics Q1 2012"
			Me.radTextBoxControlTitle.Text = Me.radChartView1.Title
			Me.radChartView1.LegendTitle = "Legend"
			Me.radChartView1.ChartElement.LegendElement.Alignment = ContentAlignment.TopCenter
			Me.radDropDownListTitlePosition.DataSource = System.Enum.GetValues(GetType(TitlePosition))
			Me.radDropDownListLegendPosition.DataSource = System.Enum.GetValues(GetType(LegendPosition))

			Dim [set] As New DataSet()

			Dim windowsXPTable As New DataTable("WindowsXP")
			Dim windows7Table As New DataTable("Windows7")
			Dim linuxTable As New DataTable("Linux")
			Dim macTable As New DataTable("Mac")

			[set].Tables.Add(windowsXPTable)
			[set].Tables.Add(windows7Table)
			[set].Tables.Add(linuxTable)
			[set].Tables.Add(macTable)

			For Each table As DataTable In [set].Tables
				table.Columns.Add("Month")
				table.Columns.Add("Usage", GetType(Double))
			Next table

			windowsXPTable.Rows.Add("January", 31.4)
			windowsXPTable.Rows.Add("February", 24.0)
			windowsXPTable.Rows.Add("March", 18.9)

			windows7Table.Rows.Add("January", 27.1)
			windows7Table.Rows.Add("February", 35.7)
			windows7Table.Rows.Add("March", 43.9)

			linuxTable.Rows.Add("January", 6.9)
			linuxTable.Rows.Add("February", 13.0)
			linuxTable.Rows.Add("March", 8.9)

			macTable.Rows.Add("January", 8.0)
			macTable.Rows.Add("February", 12.1)
			macTable.Rows.Add("March", 9.9)

			Me.radChartView1.DataSource = [set]

			Dim windowsXPSeries As New BarSeries("Usage", "Month")
			windowsXPSeries.DataMember = "WindowsXP"
			windowsXPSeries.LegendTitle = "Windows XP"
			Dim windows7Series As New BarSeries("Usage", "Month")
			windows7Series.DataMember = "Windows7"
			windows7Series.LegendTitle = "Windows 7"
			Dim linuxSeries As New BarSeries("Usage", "Month")
			linuxSeries.DataMember = "Linux"
			linuxSeries.LegendTitle = "Linux"
			Dim macSeries As New BarSeries("Usage", "Month")
			macSeries.DataMember = "Mac"
			macSeries.LegendTitle = "Mac"

			Me.radChartView1.Series.AddRange(windowsXPSeries, windows7Series, linuxSeries, macSeries)

			Me.customShape = New CustomShape()
			Me.customShape.CreateClosedShape(CreateInitialShape(5, 100, 60))

			Dim item As New RadListDataItem("CustomShape")
			item.Value = GetType(CustomShape)
			Me.radDropDownListShapes.Items.Add(item)
			item = New RadListDataItem("RectangleShape")
			item.Value = GetType(RoundRectShape)
			Me.radDropDownListShapes.Items.Add(item)
			item = New RadListDataItem("RoundRectShape")
			item.Value = GetType(RoundRectShape)
			Me.radDropDownListShapes.Items.Add(item)
			item = New RadListDataItem("EllipseShape")
			item.Value = GetType(EllipseShape)
			Me.radDropDownListShapes.Items.Add(item)
			item = New RadListDataItem("DonutShape")
			item.Value = GetType(DonutShape)
			Me.radDropDownListShapes.Items.Add(item)
			Me.radDropDownListShapes.SelectedIndex = 1

            Me.radChartView1.Controllers.Add(New LassoZoomController())
        End Sub

		Private Function CreateInitialShape(ByVal vertices As Integer, ByVal radius1 As Double, ByVal radius2 As Double) As List(Of PointF)
			Dim pts As New List(Of PointF)()

			For i As Integer = 0 To vertices - 1
				Dim angle1 As Double = ((4.0 * i - vertices) * Math.PI) / (2.0f * vertices)
				Dim angle2 As Double = ((4.0 * i - vertices + 2) * Math.PI) / (2.0f * vertices)
				pts.Add(New PointF(CSng(Math.Cos(angle1) * radius1), CSng(Math.Sin(angle1) * radius1)))
				pts.Add(New PointF(CSng(Math.Cos(angle2) * radius2), CSng(Math.Sin(angle2) * radius2)))
			Next i

			Return pts
		End Function

		Private Sub ApplyShapeToPoints(ByVal shape As ElementShape)
			For Each legendItem As LegendItemElement In Me.radChartView1.ChartElement.LegendElement.StackElement.Children
				legendItem.MarkerElement.Shape = shape
			Next legendItem
		End Sub

		Private Sub radDropDownListTitlePosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radChartView1.ChartElement.TitlePosition = CType(Me.radDropDownListTitlePosition.SelectedValue, TitlePosition)
		End Sub

		Private Sub radRadioButtonTitleOrientation_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If sender Is Me.radRadioButtonHorizontalTitle Then
				If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
					Me.radChartView1.ChartElement.TitleElement.TextOrientation = Orientation.Horizontal
				Else
					Me.radChartView1.ChartElement.TitleElement.TextOrientation = Orientation.Vertical
				End If
			End If
		End Sub

		Private Sub radDropDownListLegendPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim position As LegendPosition = CType(Me.radDropDownListLegendPosition.SelectedValue, LegendPosition)
			Me.radChartView1.ChartElement.LegendPosition = position

            If position = LegendPosition.Float Then
                Me.radSpinEditorLegendX.Enabled = True
                Me.radSpinEditorLegendY.Enabled = True
            Else
                Me.radSpinEditorLegendX.Enabled = False
				Me.radSpinEditorLegendY.Enabled = False
			End If
		End Sub

		Private Sub radSpinEditorFloatingLegendPosition_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If sender Is Me.radSpinEditorLegendX Then
				Me.radChartView1.ChartElement.LegendOffset = New Point(CInt(Fix(Me.radSpinEditorLegendX.Value)), Me.radChartView1.ChartElement.LegendOffset.Y)
			Else
				Me.radChartView1.ChartElement.LegendOffset = New Point(Me.radChartView1.ChartElement.LegendOffset.X, CInt(Fix(Me.radSpinEditorLegendY.Value)))
			End If
		End Sub

		Private Sub radRadioButtonLegendOrientation_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If sender Is Me.radRadioButtonHorizontalLegend Then
				If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
					Me.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal
				Else
					Me.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Vertical
				End If
			End If
		End Sub

		Private Sub radTextBoxControlTitle_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radChartView1.Title = Me.radTextBoxControlTitle.Text
		End Sub

		Private Sub radCheckBoxFlipText_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radChartView1.ChartElement.TitleElement.FlipText = Me.radCheckBoxFlipText.Checked
			Me.radChartView1.ChartElement.TitleElement.Invalidate()
		End Sub

		Private Sub radDropDownListMarkerShape_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Select Case Me.radDropDownListShapes.SelectedIndex
				Case 0
					Me.ApplyShapeToPoints(Me.customShape)
					Me.radButtonEditShape.Enabled = True
				Case 1
					Me.ApplyShapeToPoints(New RoundRectShape(0))
					Me.radButtonEditShape.Enabled = False
				Case 2
					Me.ApplyShapeToPoints(New RoundRectShape(2))
					Me.radButtonEditShape.Enabled = False
				Case 3
					Me.ApplyShapeToPoints(New EllipseShape())
					Me.radButtonEditShape.Enabled = False
				Case 4
					Me.ApplyShapeToPoints(New DonutShape())
					Me.radButtonEditShape.Enabled = False
				Case 5
					Me.ApplyShapeToPoints(New TabOffice12Shape())
					Me.radButtonEditShape.Enabled = False
				Case 6
					Me.ApplyShapeToPoints(New TabVsShape())
					Me.radButtonEditShape.Enabled = False
			End Select
		End Sub

		Private Sub radButtonEditShape_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.radDropDownListShapes.SelectedIndex = 0 Then
				Dim editor As New CustomShapeEditorForm()
				Me.customShape = editor.EditShape(Me.customShape)
				Me.ApplyShapeToPoints(Me.customShape)
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radCheckBoxFlipText.ToggleStateChanged, AddressOf radCheckBoxFlipText_ToggleStateChanged
			AddHandler radTextBoxControlTitle.TextChanged, AddressOf radTextBoxControlTitle_TextChanged
			AddHandler radDropDownListTitlePosition.SelectedIndexChanged, AddressOf radDropDownListTitlePosition_SelectedIndexChanged
			AddHandler radRadioButtonHorizontalTitle.ToggleStateChanged, AddressOf radRadioButtonTitleOrientation_ToggleStateChanged
			AddHandler radRadioButtonVerticalTitle.ToggleStateChanged, AddressOf radRadioButtonTitleOrientation_ToggleStateChanged
			AddHandler radButtonEditShape.Click, AddressOf radButtonEditShape_Click
			AddHandler radDropDownListShapes.SelectedIndexChanged, AddressOf radDropDownListMarkerShape_SelectedIndexChanged
			AddHandler radDropDownListLegendPosition.SelectedIndexChanged, AddressOf radDropDownListLegendPosition_SelectedIndexChanged
			AddHandler radSpinEditorLegendX.ValueChanged, AddressOf radSpinEditorFloatingLegendPosition_ValueChanged
			AddHandler radRadioButtonVerticalLegend.ToggleStateChanged, AddressOf radRadioButtonLegendOrientation_ToggleStateChanged
			AddHandler radSpinEditorLegendY.ValueChanged, AddressOf radSpinEditorFloatingLegendPosition_ValueChanged
			AddHandler radRadioButtonHorizontalLegend.ToggleStateChanged, AddressOf radRadioButtonLegendOrientation_ToggleStateChanged
		End Sub
	End Class
End Namespace
