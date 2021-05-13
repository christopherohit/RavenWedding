Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DemoAppsHub.MagnifierExample
	Public Class Magnifier
		Inherits RadControl
		Private element_Renamed As MagnifierElement
		Private timer As Timer
		Private mousePos As Point
		Private zoomFactor_Renamed As Single = 3

		Public Sub New()
			timer = New Timer()
			AddHandler timer.Tick, AddressOf timer_Tick
			timer.Interval = 16
		End Sub

		Protected Overrides Sub OnLoad(ByVal desiredSize As Size)
			MyBase.OnLoad(desiredSize)
			Me.DisableGesture(GestureType.All)
		End Sub

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				timer.Stop()
				RemoveHandler timer.Tick, AddressOf timer_Tick
				timer.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		<RadEditItemsAction, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property Items() As RadItemOwnerCollection
			Get
				Return Element.Items
			End Get
		End Property

		<DefaultValue(3)> _
		Public Property Columns() As Integer
			Get
				Return Element.Layout.Columns
			End Get
			Set
				Element.Layout.Columns = Value
			End Set
		End Property

		Public Property DefaultCellSize() As Size
			Get
				Return Element.Layout.DefaultCellSize
			End Get
			Set
				Element.Layout.DefaultCellSize = Value
			End Set
		End Property

		<DefaultValue(3f)> _
		Public Property ZoomFactor() As Single
			Get
				Return zoomFactor_Renamed
			End Get
			Set
				zoomFactor_Renamed = Value
			End Set
		End Property

		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public ReadOnly Property Element() As MagnifierElement
			Get
				Return Me.element_Renamed
			End Get
		End Property

		Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
			MyBase.OnMouseEnter(e)
			timer.Start()
		End Sub

		Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
			MyBase.OnMouseLeave(e)
			timer.Stop()
			For Each element_Renamed As RadElement In Me.Element.Layout.Children
				If element_Renamed.ScaleTransform.Width <> 1f OrElse element_Renamed.ScaleTransform.Height <> 1f Then
					element_Renamed.ScaleTransform = New SizeF(1f, 1f)
				End If
            Next
		End Sub

		Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Dim point As Point = PointToClient(Control.MousePosition)
			If mousePos <> point Then
				Dim maxFactor As Single = 0f
				Dim topMostCandidate As RadElement = Nothing
				Dim i As Integer = 0
				Do While i < Element.Layout.Children.Count
					Dim element_Renamed As RadElement = Me.Element.Layout.Children(i)
					Dim column As Integer = i Mod Me.Element.Layout.Columns
                    Dim row As Integer = CType(i / Me.Element.Layout.Columns, Integer)

					element_Renamed.ZIndex = 0

					Dim location As Point = element_Renamed.BoundingRectangle.Location
					location.Offset(CInt(Fix(Me.Element.Viewport.PositionOffset.Width)), CInt(Fix(Me.Element.Viewport.PositionOffset.Height)))
					Dim dx As Double = location.X + element_Renamed.BoundingRectangle.Width / 2f - point.X
					Dim dy As Double = location.Y + element_Renamed.BoundingRectangle.Height / 2f - point.Y
					Dim dist As Double = Math.Sqrt(dx * dx + dy * dy)
					Dim rad As Double = 150

					If dist < rad Then
						Dim factor As Single = CSng(Math.Cos(.5 * Math.PI * Math.Abs(dist / rad))) * zoomFactor_Renamed
						If factor >= 1f Then
							element_Renamed.ScaleTransform = New SizeF(factor, factor)
						End If

						If maxFactor < factor Then
							maxFactor = Math.Max(maxFactor, factor)
							topMostCandidate = element_Renamed
						End If
					Else
						element_Renamed.ScaleTransform = New SizeF(1f, 1f)
					End If

					Dim cellSize As Size = Me.Element.Layout.DefaultCellSize
					i += 1
				Loop

				If Not topMostCandidate Is Nothing Then
					topMostCandidate.ZIndex = 1
				End If
			End If
			mousePos = point
		End Sub

		Protected Overrides Sub CreateChildItems(ByVal parent As RadElement)
			Me.element_Renamed = New MagnifierElement()
			parent.Children.Add(Me.element_Renamed)
		End Sub
	End Class
End Namespace
