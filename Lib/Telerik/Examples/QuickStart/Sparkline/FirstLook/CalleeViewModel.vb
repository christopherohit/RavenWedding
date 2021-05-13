Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text

Namespace Telerik.Examples.WinControls.Sparkline.FirstLook
    Public Class CalleeViewModel
        Private _calls As BindingList(Of CallData)
        Private totalDuration As Integer
        Private totalHoldTime As Integer
        Private Shared ReadOnly Rand As Random = New Random()

        Public Sub New(ByVal name As String)
            Me.Name = name
            Me._calls = New BindingList(Of CallData)()
            Me.GenerateInitialCalls()
        End Sub

        Public Property Name As String

        Public ReadOnly Property Calls As BindingList(Of CallData)
            Get
                Return Me._calls
            End Get
        End Property

        Public ReadOnly Property AverageDuration As TimeSpan
            Get
                Return New TimeSpan(0, 0, CInt((Me.totalDuration / CDbl(Me.calls.Count))))
            End Get
        End Property

        Public ReadOnly Property AverageHoldTime As TimeSpan
            Get
                Return New TimeSpan(0, 0, CInt((Me.totalHoldTime / CDbl(Me.calls.Count))))
            End Get
        End Property

        Public Sub AddRandomCall()
            If Me.calls.Count >= 20 Then
                Me.totalDuration -= Me.calls(0).DurationSeconds
                Me.totalHoldTime -= Me.calls(0).HoldTimeSeconds
                Me.calls.RemoveAt(0)
            End If

            Dim [call] As CallData = New CallData With {
                .Duration = New TimeSpan(0, Rand.[Next](0, 40), Rand.[Next](1, 59)),
                .HoldTime = New TimeSpan(0, Rand.[Next](0, 20), Rand.[Next](1, 59)),
                .IssueResolved = Rand.[Next](-100, 100)
            }
            Me.calls.Add([call])
            Me.totalDuration += [call].DurationSeconds
            Me.totalHoldTime += [call].HoldTimeSeconds
        End Sub

        Private Sub GenerateInitialCalls()
            For i As Integer = 0 To 20 - 1
                Me.AddRandomCall()
            Next
        End Sub
    End Class
End Namespace
