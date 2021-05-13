Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Namespace Telerik.Examples.WinControls.ChartView.CartesianAnnotations
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private currentCompany As String = "Google Inc."
		Private model As DataModel
		Private series As AreaSeries

		Private googleEvents As List(Of CartesianGridLineAnnotation)
		Private microsoftEvents As List(Of CartesianGridLineAnnotation)
		Private appleEvents As List(Of CartesianGridLineAnnotation)
		Private adobeEvents As List(Of CartesianGridLineAnnotation)

		Private googleAverage As CartesianGridLineAnnotation
		Private microsoftAverage As CartesianGridLineAnnotation
		Private appleAverage As CartesianGridLineAnnotation
		Private adobeAverage As CartesianGridLineAnnotation

		Private googleRange As CartesianPlotBandAnnotation
		Private microsoftRange As CartesianPlotBandAnnotation
		Private appleRange As CartesianPlotBandAnnotation
		Private adobeRange As CartesianPlotBandAnnotation

		Public Sub New()
			InitializeComponent()

			Me.model = New DataModel()

			Dim axis As New DateTimeContinuousAxis()
			axis.MajorStepUnit = Charting.TimeInterval.Month
			axis.MajorStep = 3
			axis.LabelFormatProvider = New DateTimeFormatProvider()

			Me.series = New AreaSeries()
			Me.series.HorizontalAxis = axis
			Me.series.ValueMember = "Value"
			Me.series.CategoryMember = "Date"
			series.BorderColor = Color.FromArgb(27, 157, 222)
			series.BackColor = Color.FromArgb(80, 27, 157, 222)
			Me.radChartView1.Series.Add(series)
			Me.radChartView1.ShowGrid = True

			Me.googleEvents = New List(Of CartesianGridLineAnnotation)()
			Me.microsoftEvents = New List(Of CartesianGridLineAnnotation)()
			Me.appleEvents = New List(Of CartesianGridLineAnnotation)()
			Me.adobeEvents = New List(Of CartesianGridLineAnnotation)()

			For Each ev As CompanyEvent In Me.model.GetGoogleEventData()
				Dim ann As New CartesianGridLineAnnotation(CType(Me.radChartView1.Axes(0), CartesianAxis), ev.TimeOfEvent)
				ann.Label = ev.EventDescription
				ann.PositonOffset = ev.Offset
				Me.googleEvents.Add(ann)
			Next ev

			For Each ev As CompanyEvent In Me.model.GetMicrosoftEventData()
				Dim ann As New CartesianGridLineAnnotation(CType(Me.radChartView1.Axes(0), CartesianAxis), ev.TimeOfEvent)
				ann.Label = ev.EventDescription
				ann.PositonOffset = ev.Offset
				Me.microsoftEvents.Add(ann)
			Next ev

			For Each ev As CompanyEvent In Me.model.GetAppleEventData()
				Dim ann As New CartesianGridLineAnnotation(CType(Me.radChartView1.Axes(0), CartesianAxis), ev.TimeOfEvent)
				ann.Label = ev.EventDescription
				ann.PositonOffset = ev.Offset
				Me.appleEvents.Add(ann)
			Next ev

			For Each ev As CompanyEvent In Me.model.GetAdobeEventData()
				Dim ann As New CartesianGridLineAnnotation(CType(Me.radChartView1.Axes(0), CartesianAxis), ev.TimeOfEvent)
				ann.Label = ev.EventDescription
				ann.PositonOffset = ev.Offset
				Me.adobeEvents.Add(ann)
			Next ev

			Me.googleAverage = New CartesianGridLineAnnotation(CType(Me.radChartView1.Axes(1), CartesianAxis), 515.25R)
			Me.googleAverage.BorderColor = Color.LimeGreen
			Me.googleAverage.BorderWidth = 2
			Me.googleAverage.Label = "515.25 AVG value"
			Me.googleAverage.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid

			Me.microsoftAverage = New CartesianGridLineAnnotation(CType(Me.radChartView1.Axes(1), CartesianAxis), 26.85R)
			Me.microsoftAverage.BorderColor = Color.LimeGreen
			Me.microsoftAverage.BorderWidth = 2
			Me.microsoftAverage.Label = "26.85 AVG value"
			Me.microsoftAverage.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid

			Me.appleAverage = New CartesianGridLineAnnotation(CType(Me.radChartView1.Axes(1), CartesianAxis), 225.74R)
			Me.appleAverage.BorderColor = Color.LimeGreen
			Me.appleAverage.BorderWidth = 2
			Me.appleAverage.Label = "225.74 AVG value"
			Me.appleAverage.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid

			Me.adobeAverage = New CartesianGridLineAnnotation(CType(Me.radChartView1.Axes(1), CartesianAxis), 33.35R)
			Me.adobeAverage.BorderColor = Color.LimeGreen
			Me.adobeAverage.BorderWidth = 2
			Me.adobeAverage.Label = "33.35 AVG value"
			Me.adobeAverage.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid

			Me.googleRange = New CartesianPlotBandAnnotation(CType(Me.radChartView1.Axes(1), CartesianAxis), 257.44, 741.79)
			Me.microsoftRange = New CartesianPlotBandAnnotation(CType(Me.radChartView1.Axes(1), CartesianAxis), 15.15, 37.06)
			Me.appleRange = New CartesianPlotBandAnnotation(CType(Me.radChartView1.Axes(1), CartesianAxis), 636.23, 78.2)
			Me.adobeRange = New CartesianPlotBandAnnotation(CType(Me.radChartView1.Axes(1), CartesianAxis), 15.98, 48)

			Me.SelectedCompanyChnaged()
		End Sub

		Protected Overrides Sub WireEvents()
			MyBase.WireEvents()

			AddHandler Me.radRadioButton1.ToggleStateChanged, AddressOf radRadioButton_ToggleStateChanged
			AddHandler Me.radRadioButton2.ToggleStateChanged, AddressOf radRadioButton_ToggleStateChanged
			AddHandler Me.radRadioButton3.ToggleStateChanged, AddressOf radRadioButton_ToggleStateChanged
			AddHandler Me.radRadioButton4.ToggleStateChanged, AddressOf radRadioButton_ToggleStateChanged

			AddHandler Me.radCheckBoxCompanyEvents.ToggleStateChanged, AddressOf radCheckBoxCompanyEvents_ToggleStateChanged
			AddHandler Me.radCheckBoxAveragePrice.ToggleStateChanged, AddressOf radCheckBoxAveragePrice_ToggleStateChanged
			AddHandler Me.radCheckBoxPriceRange.ToggleStateChanged, AddressOf radCheckBoxPriceRange_ToggleStateChanged
		End Sub

		Private Sub radCheckBoxPriceRange_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Select Case currentCompany
				Case "Google Inc."
					If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
						Me.radChartView1.Area.Annotations.Add(Me.googleRange)
					Else
						Me.radChartView1.Area.Annotations.Remove(Me.googleRange)
					End If
				Case "Microsoft Corporation"
					If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
						Me.radChartView1.Area.Annotations.Add(Me.microsoftRange)
					Else
						Me.radChartView1.Area.Annotations.Remove(Me.microsoftRange)
					End If
				Case "Apple Inc."
					If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
						Me.radChartView1.Area.Annotations.Add(Me.appleRange)
					Else
						Me.radChartView1.Area.Annotations.Remove(Me.appleRange)
					End If
				Case "Adobe Systems Inc."
					If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
						Me.radChartView1.Area.Annotations.Add(Me.adobeRange)
					Else
						Me.radChartView1.Area.Annotations.Remove(Me.adobeRange)
					End If
			End Select
		End Sub

		Private Sub radCheckBoxAveragePrice_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Select Case currentCompany
				Case "Google Inc."
					If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
						Me.radChartView1.Area.Annotations.Add(Me.googleAverage)
					Else
						Me.radChartView1.Area.Annotations.Remove(Me.googleAverage)
					End If
				Case "Microsoft Corporation"
					If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
						Me.radChartView1.Area.Annotations.Add(Me.microsoftAverage)
					Else
						Me.radChartView1.Area.Annotations.Remove(Me.microsoftAverage)
					End If
				Case "Apple Inc."
					If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
						Me.radChartView1.Area.Annotations.Add(Me.appleAverage)
					Else
						Me.radChartView1.Area.Annotations.Remove(Me.appleAverage)
					End If
				Case "Adobe Systems Inc."
					If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
						Me.radChartView1.Area.Annotations.Add(Me.adobeAverage)
					Else
						Me.radChartView1.Area.Annotations.Remove(Me.adobeAverage)
					End If
			End Select
		End Sub

		Private Sub radCheckBoxCompanyEvents_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Select Case currentCompany
				Case "Google Inc."
					For Each ev As CartesianGridLineAnnotation In Me.googleEvents
						If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
							Me.radChartView1.Area.Annotations.Add(ev)
						Else
							Me.radChartView1.Area.Annotations.Remove(ev)
						End If
					Next ev
				Case "Microsoft Corporation"
					For Each ev As CartesianGridLineAnnotation In Me.microsoftEvents
						If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
							Me.radChartView1.Area.Annotations.Add(ev)
						Else
							Me.radChartView1.Area.Annotations.Remove(ev)
						End If
					Next ev
				Case "Apple Inc."
					For Each ev As CartesianGridLineAnnotation In Me.appleEvents
						If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
							Me.radChartView1.Area.Annotations.Add(ev)
						Else
							Me.radChartView1.Area.Annotations.Remove(ev)
						End If
					Next ev
				Case "Adobe Systems Inc."
					For Each ev As CartesianGridLineAnnotation In Me.adobeEvents
						If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
							Me.radChartView1.Area.Annotations.Add(ev)
						Else
							Me.radChartView1.Area.Annotations.Remove(ev)
						End If
					Next ev
			End Select
		End Sub

		Private Sub SelectedCompanyChnaged()
			Me.radChartView1.Area.Annotations.Clear()
			Me.series.DataSource = Me.model.GetData().Tables(currentCompany)

			Select Case currentCompany
				Case "Google Inc."
					If Me.radCheckBoxCompanyEvents.IsChecked Then
						For Each ev As CartesianGridLineAnnotation In Me.googleEvents
							Me.radChartView1.Area.Annotations.Add(ev)
						Next ev
					End If

					If Me.radCheckBoxAveragePrice.IsChecked Then
						Me.radChartView1.Area.Annotations.Add(Me.googleAverage)
					End If

					If Me.radCheckBoxPriceRange.IsChecked Then
						Me.radChartView1.Area.Annotations.Add(Me.googleRange)
					End If
				Case "Microsoft Corporation"
					If Me.radCheckBoxCompanyEvents.IsChecked Then
						For Each ev As CartesianGridLineAnnotation In Me.microsoftEvents
							Me.radChartView1.Area.Annotations.Add(ev)
						Next ev
					End If

					If Me.radCheckBoxAveragePrice.IsChecked Then
						Me.radChartView1.Area.Annotations.Add(Me.microsoftAverage)
					End If

					If Me.radCheckBoxPriceRange.IsChecked Then
						Me.radChartView1.Area.Annotations.Add(Me.microsoftRange)
					End If
				Case "Apple Inc."
					If Me.radCheckBoxCompanyEvents.IsChecked Then
						For Each ev As CartesianGridLineAnnotation In Me.appleEvents
							Me.radChartView1.Area.Annotations.Add(ev)
						Next ev
					End If

					If Me.radCheckBoxAveragePrice.IsChecked Then
						Me.radChartView1.Area.Annotations.Add(Me.appleAverage)
					End If

					If Me.radCheckBoxPriceRange.IsChecked Then
						Me.radChartView1.Area.Annotations.Add(Me.appleRange)
					End If
				Case "Adobe Systems Inc."
					If Me.radCheckBoxCompanyEvents.IsChecked Then
						For Each ev As CartesianGridLineAnnotation In Me.adobeEvents
							Me.radChartView1.Area.Annotations.Add(ev)
						Next ev
					End If

					If Me.radCheckBoxAveragePrice.IsChecked Then
						Me.radChartView1.Area.Annotations.Add(Me.adobeAverage)
					End If

					If Me.radCheckBoxPriceRange.IsChecked Then
						Me.radChartView1.Area.Annotations.Add(Me.adobeRange)
					End If
			End Select
		End Sub

		Private Sub radRadioButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				currentCompany = (CType(sender, RadRadioButton)).Text
				Me.SelectedCompanyChnaged()
			End If
		End Sub
	End Class
End Namespace