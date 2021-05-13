Imports System
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.Sparkline.FirstLook
    Public Class CallData
        Implements INotifyPropertyChanged

        Private _duration As TimeSpan
        Private _holdTime As TimeSpan
        Private _issueResolved As Double
        Private timeInterval As DateTime
        Private _abandonments As Integer
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Public Sub OnPropertyChanged(ByVal PropertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(PropertyName))
        End Sub

        Public Property Abandonments As Integer
            Get
                Return Me._abandonments
            End Get
            Set(ByVal value As Integer)
                Me._abandonments = value
                Me.OnPropertyChanged("Abandonments")
            End Set
        End Property

        Public Property TimeInverval As DateTime
            Get
                Return Me.timeInterval
            End Get
            Set(ByVal value As DateTime)
                Me.timeInterval = value
                Me.OnPropertyChanged("TimeInverval")
            End Set
        End Property

        Public ReadOnly Property DurationSeconds As Integer
            Get
                Return CInt(Me.duration.TotalSeconds)
            End Get
        End Property

        Public ReadOnly Property DurationMinutes As Integer
            Get
                Return CInt(Me.duration.TotalMinutes)
            End Get
        End Property

        Public Property Duration As TimeSpan
            Get
                Return Me._duration
            End Get
            Set(ByVal value As TimeSpan)
                Me._duration = value
                Me.OnPropertyChanged("Duration")
            End Set
        End Property

        Public Property HoldTime As TimeSpan
            Get
                Return Me._holdTime
            End Get
            Set(ByVal value As TimeSpan)
                Me._holdTime = value
                Me.OnPropertyChanged("HoldTime")
            End Set
        End Property

        Public ReadOnly Property HoldTimeMinutes As Integer
            Get
                Return CInt(Me.holdTime.TotalMinutes)
            End Get
        End Property

        Public ReadOnly Property HoldTimeSeconds As Integer
            Get
                Return CInt(Me.holdTime.TotalSeconds)
            End Get
        End Property

        Public Property IssueResolved As Double
            Get
                Return Me._issueResolved
            End Get
            Set(ByVal value As Double)
                Me._issueResolved = value
                Me.OnPropertyChanged("IssueResolved")
            End Set
        End Property
    End Class
End Namespace
