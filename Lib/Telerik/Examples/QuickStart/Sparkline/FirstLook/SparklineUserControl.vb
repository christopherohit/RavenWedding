Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Sparkline.FirstLook
    Partial Public Class SparklineUserControl
        Inherits UserControl

        Private _callType As CallType
        Private timer As Timer
        Private series As SparkCartesianSeries
        Private _owner As CalleeViewModel

        Public Sub New()
            InitializeComponent()
            Dim webUIFont As FontFamily = ThemeResolutionService.GetCustomFont("TelerikWebUI")
            Me.alertLabel.LabelElement.CustomFont = webUIFont.Name
            Me.alertLabel.LabelElement.CustomFontSize = 8
            Me.alertLabel.ForeColor = Color.Red
            Me.alertLabel.Text = ""
            Me.timeLabel.Font = New Font("Segoe UI", 9, FontStyle.Regular)
            Me.timer = New Timer()
            Me.timer.Interval = 750
            AddHandler Me.timer.Tick, AddressOf Me.Timer_Tick
        End Sub

        <Browsable(False)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Owner As CalleeViewModel
            Get
                Return Me._owner
            End Get
            Set(ByVal value As CalleeViewModel)

                If Me._owner IsNot value Then
                    Me._owner = value
                End If
            End Set
        End Property

        <Browsable(False)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property CallType As CallType
            Get
                Return Me._callType
            End Get
            Set(ByVal value As CallType)

                If Me._callType <> value OrElse Me.radSparkline1.Series Is Nothing Then
                    Me.timer.[Stop]()
                    Me._callType = value
                    Me.CreateSeries()
                    Me.UpdateSeriesStyles()
                    Me.timer.Start()
                End If
            End Set
        End Property

        Public Overrides Function ToString() As String
            Select Case Me.callType
                Case callType.Duration
                    Return "Call Duration"
                Case callType.HoldTime
                    Return "Hold Time"
                Case callType.ResolvedIssues
                    Return "Issues Resolved"
                Case Else
                    Return MyBase.ToString()
            End Select
        End Function

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Me.timer.Start()
        End Sub

        Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If Me.owner Is Nothing Then
                Return
            End If

            Me.owner.AddRandomCall()

            If Me.callType = callType.Duration Then
                Me.alertLabel.LabelElement.Visibility = If(Me.owner.AverageDuration.Minutes >= 20, ElementVisibility.Visible, ElementVisibility.Hidden)
                Me.timeLabel.Text = Me.owner.AverageDuration.ToString()
                Me.timeLabel.ForeColor = If(Me.owner.AverageDuration.Minutes >= 20, Color.Red, Color.Empty)
            ElseIf Me.callType = callType.HoldTime Then
                Me.alertLabel.LabelElement.Visibility = If(Me.owner.AverageHoldTime.Minutes >= 10, ElementVisibility.Visible, ElementVisibility.Hidden)
                Me.timeLabel.Text = Me.owner.AverageHoldTime.ToString()
                Me.timeLabel.ForeColor = If(Me.owner.AverageHoldTime.Minutes >= 10, Color.Red, Color.Empty)
            End If
        End Sub

        Private Sub CreateSeries()
            Me.radSparkline1.Series = Nothing
            Me.series = Me.GetSeries()
            Me.series.ValueMember = Me.GetValueMember(Me.callType)
            Me.series.DataSource = Me.owner.Calls
            Me.radSparkline1.Series = series
        End Sub

        Private Function GetSeries() As SparkCartesianSeries
            Select Case Me.callType
                Case callType.Duration, callType.HoldTime
                    Return New SparkLineSeries()
                Case callType.ResolvedIssues
                    Dim winLoss As SparkWinLossSeries = New SparkWinLossSeries()
                    winLoss.ShowNegativePointIndicators = True
                    Return winLoss
                Case Else
                    Return New SparkLineSeries()
            End Select
        End Function

        Private Function GetValueMember(ByVal callType As CallType) As String
            Select Case callType
                Case CallType.Duration
                    Return "DurationSeconds"
                Case CallType.HoldTime
                    Return "HoldTimeSeconds"
                Case CallType.ResolvedIssues
                    Return "IssueResolved"
                Case Else
                    Return String.Empty
            End Select
        End Function

        Private Sub UpdateSeriesStyles()
            If Me.callType = callType.ResolvedIssues Then
                Me.alertLabel.Visible = False
                Me.timeLabel.Visible = False
                Me.radSparkline1.View.Margin = New Padding(0, 5, 0, 5)
            Else
                Me.alertLabel.Visible = True
                Me.timeLabel.Visible = True
                Me.radSparkline1.View.Margin = New Padding(5)
            End If
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            RemoveHandler Me.timer.Tick, AddressOf Me.Timer_Tick
            MyBase.Dispose(disposing)
        End Sub
    End Class

    Public Enum CallType
        Duration
        HoldTime
        ResolvedIssues
    End Enum
End Namespace
