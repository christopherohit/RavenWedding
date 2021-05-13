Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.PropertyGrid.FirstLook
	Public Class SurfaceObject
		Inherits LightVisualElement
'INSTANT VB NOTE: The variable offset was renamed since Visual Basic does not allow class members with the same name:
		Private offset_Renamed As Point

		Public Property Offset() As Point
			Get
				Return offset_Renamed
			End Get
			Set(ByVal value As Point)
				If offset_Renamed <> value Then
					If Me.Parent IsNot Nothing Then
						If value.X < 0 Then
							value.X = 1
						End If
						If value.Y < 1 Then
							value.Y = 1
						End If
						If value.X + Me.Size.Width + 1 > Me.Parent.Size.Width Then
							value.X = Me.Parent.Size.Width - Me.Size.Width - 1
						End If
						If value.Y + Me.Size.Height + 1 > Me.Parent.Size.Height Then
							value.Y = Me.Parent.Size.Height - Me.Size.Height - 1
						End If
					End If
					offset_Renamed = value
					If Me.Parent IsNot Nothing Then
						Me.Parent.InvalidateMeasure()
						Me.Parent.UpdateLayout()
					End If
				End If
			End Set
		End Property

		Public ReadOnly Property IsCurrent() As Boolean
			Get
				Return FindAncestor(Of SurfaceElement)().CurrentObject Is Me
			End Get
		End Property

		Public Sub New(ByVal x As Integer, ByVal y As Integer, ByVal content As RadElement)
			Me.Offset = New Point(x, y)
			content.ShouldHandleMouseInput = False
			content.NotifyParentOnMouseInput = True
			Me.Children.Add(content)
		End Sub

		Protected Overrides Sub InitializeFields()
			MyBase.InitializeFields()
			'this.AutoSize = false;
			Me.MinSize = New Size(100, 20)
		End Sub

		Private mouseDownPoint As Point
		Private mouseDownLocation As Point
		Private dragging As Boolean
		Private mouseIsDown As Boolean

		Private Function IsRealDrag(ByVal location As Point) As Boolean
			Return location.X - mouseDownPoint.X > SystemInformation.DragSize.Width OrElse location.Y - mouseDownPoint.Y > SystemInformation.DragSize.Height
		End Function

		Private Sub DragTo(ByVal location As Point)
			Dim delta As New Point(location.X - mouseDownPoint.X, location.Y - mouseDownPoint.Y)
			Me.Offset = New Point(mouseDownLocation.X + delta.X, mouseDownLocation.Y + delta.Y)
		End Sub

		Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			If e.Button = MouseButtons.Left Then
				FindAncestor(Of SurfaceElement)().CurrentObject = Me
				mouseDownPoint = e.Location
				mouseDownLocation = Offset
				mouseIsDown = True
				Me.Capture = True
			End If
		End Sub

		Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.Capture = False
			mouseIsDown = False
		End Sub

		Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.ElementTree.Control.Cursor = Cursors.Hand
		End Sub

		Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.ElementTree.Control.Cursor = Cursors.Arrow
		End Sub

		Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			If e.Button = MouseButtons.Left AndAlso mouseIsDown Then
				If dragging Then
					DragTo(e.Location)
				ElseIf IsRealDrag(e.Location) Then
					DragTo(e.Location)
					dragging = True
				End If
			End If
		End Sub

		Protected Overrides Sub PaintElement(ByVal graphics As Telerik.WinControls.Paint.IGraphics, ByVal angle As Single, ByVal scale As SizeF)
			MyBase.PaintElement(graphics, angle, scale)

			If IsCurrent Then
				Dim g As Graphics = CType(graphics.UnderlayGraphics, Graphics)
				Using pen As New Pen(Color.Black)
					Dim rect As New Rectangle(-1, -1, Me.Size.Width + 1, Me.Size.Height + 1)
					pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
					g.DrawRectangle(pen, rect)
				End Using
			End If
		End Sub
	End Class
End Namespace
