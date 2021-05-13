Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.Drawing
Imports Telerik.WinControls.Layouts
Imports System.Drawing.Drawing2D

Namespace PhotoAlbumVB
    Class PhotoElement
		Inherits RadButtonElement
		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(RadButtonElement)
			End Get
		End Property

		Protected Overrides Sub OnGesture(args As Telerik.WinControls.GestureEventArgs)
			MyBase.OnGesture(args)

			If args.IsBegin Then
				Me.BringToFront()
			End If

			If args.GestureType = Telerik.WinControls.GestureType.Pan AndAlso Not args.IsBegin AndAlso Not args.IsEnd Then
				Dim panArgs As PanGestureEventArgs = DirectCast(args, PanGestureEventArgs)
				Dim offset As Size = panArgs.Offset

				If Me.ControlBoundingRectangle.X + offset.Width < 0 AndAlso offset.Width < 0 Then
					offset.Width = -Me.ControlBoundingRectangle.X
				End If
				If Me.ControlBoundingRectangle.Right + offset.Width > Me.Parent.ControlBoundingRectangle.Right AndAlso offset.Width > 0 Then
					offset.Width = Me.Parent.ControlBoundingRectangle.Right - Me.ControlBoundingRectangle.Right
				End If

				If Me.ControlBoundingRectangle.Y + offset.Height < 0 AndAlso offset.Height < 0 Then
					offset.Height = -Me.ControlBoundingRectangle.Y
				End If
				If Me.ControlBoundingRectangle.Bottom + offset.Height > Me.Parent.ControlBoundingRectangle.Bottom AndAlso offset.Height > 0 Then
					offset.Height = Me.Parent.ControlBoundingRectangle.Bottom - Me.ControlBoundingRectangle.Bottom
				End If

				Me.Location = New System.Drawing.Point(Me.Location.X + offset.Width, Me.Location.Y + offset.Height)
				

			End If

			If args.GestureType = GestureType.Rotate Then
				Dim rotateArgs As RotateGestureEventArgs = DirectCast(args, RotateGestureEventArgs)
				Console.WriteLine(CSng(rotateArgs.Angle * 180.0 / Math.PI))
				Dim newAngle As Single = Me.AngleTransform - CSng(rotateArgs.Angle * 180.0 / Math.PI)

				Dim setting As New PropertySetting(RadElement.AngleTransformProperty, newAngle)
				setting.ApplyValue(Me)
			End If

			If args.GestureType = GestureType.Zoom Then
				Dim zoomArgs As ZoomGestureEventArgs = DirectCast(args, ZoomGestureEventArgs)
				Me.ScaleTransform = New System.Drawing.SizeF(Me.ScaleTransform.Width * CSng(zoomArgs.ZoomFactor), Me.ScaleTransform.Height * CSng(zoomArgs.ZoomFactor))

				Dim oldDir As New PointF(Me.Location.X - zoomArgs.Center.X, Me.Location.Y - zoomArgs.Center.Y)
				Dim newDir As New PointF(oldDir.X * CSng(zoomArgs.ZoomFactor), oldDir.Y * CSng(zoomArgs.ZoomFactor))
				Dim offset As New PointF(newDir.X - oldDir.X, newDir.Y - oldDir.Y)

				Me.Location = New Point(Me.Location.X + CInt(offset.X), Me.Location.Y + CInt(offset.Y))
			End If

			args.Handled = True
		End Sub

		Protected Overrides Function PerformPaintTransformation(ByRef matrix As RadMatrix) As Boolean
			Dim res As Boolean = False
			Dim angleTransform As Single = Me.AngleTransform

			If angleTransform <> 0F Then
				res = True
				Dim bounds As New RectangleF(PointF.Empty, Me.Bounds.Size)
				TelerikHelper.PerformCenteredRotation(matrix, bounds, angleTransform)
			End If

			Dim scaleTransform As SizeF = Me.ScaleTransform
			If (scaleTransform.Width > 0) AndAlso (scaleTransform.Height > 0) Then
				If (scaleTransform.Width <> 1) OrElse (scaleTransform.Height <> 1) Then
					res = True
					matrix.Scale(scaleTransform.Width, scaleTransform.Height, MatrixOrder.Append)
				End If
			End If

			Dim posOffset As SizeF = Me.PositionOffset
			If posOffset <> SizeF.Empty Then
				res = True
				matrix.Translate(If(Me.RightToLeft, -posOffset.Width, posOffset.Width), posOffset.Height, MatrixOrder.Append)
			End If

			Return res
		End Function
	End Class
End Namespace
