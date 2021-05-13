
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading

Namespace Telerik.Examples.WinControls.Sparkline.FirstLook
    Public Class ExampleViewModel
        Private _callees As List(Of CalleeViewModel)
        Private _calls As BindingList(Of CallData)
        Private rand As Random

        Public Sub New()
            Me._callees = Me.GetCalleeViewModels()
            Me._calls = New BindingList(Of CallData)()
            Me.rand = New Random()
            Me.GenerateCalls()
        End Sub

        Public ReadOnly Property Callees As List(Of CalleeViewModel)
            Get
                Return Me._callees
            End Get
        End Property

        Public ReadOnly Property Calls As BindingList(Of CallData)
            Get
                Return Me._calls
            End Get
        End Property

        Public Sub GenerateCalls()
            Dim callData As CallData
            Dim dateCall As DateTime = New DateTime(2010, 12, 12, 10, 0, 0)

            For i As Integer = 0 To 24 - 1
                callData = New CallData With {
                    .Duration = New TimeSpan(0, Me.rand.[Next](0, 100), Me.rand.[Next](1, 59)),
                    .HoldTime = New TimeSpan(0, Me.rand.[Next](0, 100), Me.rand.[Next](1, 59)),
                    .Abandonments = Me.rand.[Next](0, 50),
                    .TimeInverval = dateCall
                }

                dateCall = dateCall.AddHours(1)
                Me.calls.Add(callData)
            Next
        End Sub

        Private Function GetCalleeViewModels() As List(Of CalleeViewModel)
            Dim callees As List(Of CalleeViewModel) = New List(Of CalleeViewModel)()
            callees.Add(New CalleeViewModel("Sam"))
            callees.Add(New CalleeViewModel("John"))
            callees.Add(New CalleeViewModel("Mike"))
            Return callees
        End Function
    End Class
End Namespace

