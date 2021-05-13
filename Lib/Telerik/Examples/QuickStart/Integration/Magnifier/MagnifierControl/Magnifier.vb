Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Integration.Magnifier
    Public Class Magnifier
        Inherits RadControl

        Private element_Field As MagnifierElement
        Private timer As Timer
        Private mousePos As Point
        Private zoomFactor_Field As Single = 3

        Public Sub New()
            Me.timer = New Timer()
            AddHandler Me.timer.Tick, AddressOf Me.Timer_Tick
            Me.timer.Interval = 16
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                Me.timer.[Stop]()
                RemoveHandler Me.timer.Tick, AddressOf Me.Timer_Tick
                Me.timer.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        <RadEditItemsAction>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public ReadOnly Property Items As RadItemOwnerCollection
            Get
                Return Me.Element.Items
            End Get
        End Property

        <DefaultValue(3)>
        Public Property Columns As Integer
            Get
                Return Me.Element.Layout.Columns
            End Get
            Set(ByVal value As Integer)
                Me.Element.Layout.Columns = value
            End Set
        End Property

        Public Property DefaultCellSize As Size
            Get
                Return Me.Element.Layout.DefaultCellSize
            End Get
            Set(ByVal value As Size)
                Me.Element.Layout.DefaultCellSize = value
            End Set
        End Property

        <DefaultValue(3.0F)>
        Public Property ZoomFactor As Single
            Get
                Return Me.zoomFactor_Field
            End Get
            Set(ByVal value As Single)
                Me.zoomFactor_Field = value
            End Set
        End Property

        <Browsable(False)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Element As MagnifierElement
            Get
                Return Me.element_Field
            End Get
        End Property

        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            MyBase.OnMouseEnter(e)
            Me.timer.Start()
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            Me.timer.[Stop]()

            For Each element As RadElement In Me.Element.Layout.Children

                If element.ScaleTransform.Width <> 1.0F OrElse element.ScaleTransform.Height <> 1.0F Then
                    element.ScaleTransform = New SizeF(1.0F, 1.0F)
                End If
            Next
        End Sub

        Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Dim point As Point = Me.PointToClient(Control.MousePosition)

            If Me.mousePos <> point Then
                Dim maxFactor As Single = 0.0F
                Dim topMostCandidate As RadElement = Nothing
                Dim halfPi As Double = 0.5 * Math.PI

                For Each element As RadElement In Me.Element.Layout.Children
                    element.ZIndex = 0
                    Dim boundingRect As Rectangle = element.BoundingRectangle
                    Dim dx As Double = boundingRect.X + boundingRect.Width / 2.0F - point.X
                    Dim dy As Double = boundingRect.Y + boundingRect.Height / 2.0F - point.Y
                    Dim dist As Double = Math.Sqrt(dx * dx + dy * dy)
                    Dim rad As Double = 150

                    If dist < rad Then
                        Dim factor As Single = CSng(Math.Cos(halfPi * (dist / rad))) * Me.ZoomFactor

                        If factor >= 1.0F Then
                            element.ScaleTransform = New SizeF(factor, factor)
                        End If

                        If maxFactor < factor Then
                            maxFactor = factor
                            topMostCandidate = element
                        End If
                    Else
                        element.ScaleTransform = New SizeF(1.0F, 1.0F)
                    End If
                Next

                If topMostCandidate IsNot Nothing Then
                    topMostCandidate.ZIndex = 1
                End If
            End If

            Me.mousePos = point
        End Sub

        Protected Overrides Sub CreateChildItems(ByVal parent As RadElement)
            Me.element_Field = New MagnifierElement()
            parent.Children.Add(Me.element_Field)
        End Sub
    End Class
End Namespace
