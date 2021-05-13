Imports Telerik.WinControls.UI
Imports System.Collections.Generic

Public Class ExampleGanttViewTimelineBehavior
    Inherits BaseGanttViewTimelineBehavior

    Public Overrides ReadOnly Property AdjustedTimelineStart As Date
        Get
            If Me.GraphicalViewElement.TimelineRange <> TimeRange.Custom Then
                Return MyBase.AdjustedTimelineStart
            End If

            Return New DateTime(Me.GraphicalViewElement.TimelineStart.Year, 1, 1)
        End Get
    End Property

    Public Overrides ReadOnly Property AdjustedTimelineEnd As Date
        Get
            If Me.GraphicalViewElement.TimelineRange <> TimeRange.Custom Then
                Return MyBase.AdjustedTimelineEnd
            End If

            Return New DateTime(Me.GraphicalViewElement.TimelineEnd.Year + 1, 1, 1)
        End Get
    End Property

    Public Overrides Function BuildTimelineDataItems(range As TimeRange) As IList(Of GanttViewTimelineDataItem)
        If range <> TimeRange.Custom Then
            Return MyBase.BuildTimelineDataItems(range)
        End If

        Return Me.BuildTimelineDataItemsForDecadesRange()
    End Function

    Public Function BuildTimelineDataItemsForDecadesRange() As IList(Of GanttViewTimelineDataItem)
        Dim result As New List(Of GanttViewTimelineDataItem)()

        Dim adjustedStart As DateTime = Me.AdjustedTimelineStart
        Dim adjustedEnd As DateTime = Me.AdjustedTimelineEnd

        Dim currentDate As DateTime = adjustedStart.Date
        Dim currentYearNumber As Integer = currentDate.Year
        Dim newYearNumber As Integer = currentYearNumber
        Dim item As GanttViewTimelineDataItem = New GanttViewTimelineDataItem(currentDate.Date, currentDate.AddYears(1), Me.GraphicalViewElement.TimelineRange, Me.GraphicalViewElement.OnePixelTime)
        result.Add(item)

        While (currentDate < adjustedEnd)
            item.End = currentDate.AddYears(1)
            currentDate = currentDate.AddYears(1)
            newYearNumber = currentDate.Year

            If (newYearNumber <> currentYearNumber AndAlso newYearNumber Mod 10 = 0 AndAlso currentDate <= adjustedEnd) Then
                currentYearNumber = newYearNumber
                item = New GanttViewTimelineDataItem(currentDate, currentDate, Me.GraphicalViewElement.TimelineRange, Me.GraphicalViewElement.OnePixelTime)
                result.Add(item)
            End If
            End While

        Return result
    End Function

    Public Overrides Function GetTimelineCellInfoForItem(item As GanttViewTimelineDataItem, range As TimeRange) As GanttTimelineCellsInfo
        If range <> TimeRange.Custom Then
            Return MyBase.GetTimelineCellInfoForItem(item, range)
        End If

        Return Me.GetTimelineCellInfoForDecadeRange(item)
    End Function

    Public Function GetTimelineCellInfoForDecadeRange(item As GanttViewTimelineDataItem) As GanttTimelineCellsInfo
        Dim years As Integer = 10

        If (item.Start = Me.AdjustedTimelineStart) Then
            If (item.Start.Year Mod 10 > 0) Then
                years = 10 - (item.Start.Year Mod 10)
            End If
        End If

        If (item.End = Me.AdjustedTimelineEnd) Then
            If (item.End.Year Mod 10 > 0) Then
                years = item.End.Year Mod 10
            End If
        End If

        Return New GanttTimelineCellsInfo(years)
    End Function

    Public Overrides Function GetTimelineTopElementText(item As Telerik.WinControls.UI.GanttViewTimelineDataItem) As String
        If item.Range <> TimeRange.Custom Then
            Return MyBase.GetTimelineTopElementText(item)
        End If

        Dim format As String = "{0:yyyy} - {1:yyyy}"
        Return String.Format(System.Threading.Thread.CurrentThread.CurrentUICulture, format, item.Start, item.End.AddYears(-1))
    End Function

    Public Overrides Function GetTimelineBottomElementText(item As GanttViewTimelineDataItem, index As Integer) As String
        If item.Range <> TimeRange.Custom Then
            Return MyBase.GetTimelineBottomElementText(item, index)
        End If

        Dim format As String = "{0:yyyy}"
        Return String.Format(System.Threading.Thread.CurrentThread.CurrentCulture, format, New DateTime(item.Start.Year + index, 1, 1))
    End Function

End Class
