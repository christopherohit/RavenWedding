Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Paint
Imports My

Namespace Telerik.Examples.WinControls.ListView.CustomItems
	Public Class RatingElement
		Inherits LightVisualElement
		Public Shared starOnInternal As Bitmap
		Public Shared starOffInternal As Bitmap

'INSTANT VB NOTE: The variable rating was renamed since Visual Basic does not allow class members with the same name:
		Private rating_Renamed As Integer

		Private privateStarOn As Bitmap
		Public Property StarOn() As Bitmap
			Get
				Return privateStarOn
			End Get
			Set(ByVal value As Bitmap)
				privateStarOn = value
			End Set
		End Property
		Private privateStarOff As Bitmap
		Public Property StarOff() As Bitmap
			Get
				Return privateStarOff
			End Get
			Set(ByVal value As Bitmap)
				privateStarOff = value
			End Set
		End Property

		Private privateStars As Integer
		Public Property Stars() As Integer
			Get
				Return privateStars
			End Get
			Set(ByVal value As Integer)
				privateStars = value
			End Set
		End Property

		Public Property Rating() As Integer
			Get
				Return rating_Renamed
			End Get
			Set(ByVal value As Integer)
				If rating_Renamed <> value Then
					rating_Renamed = value
					Invalidate()
				End If
			End Set
		End Property

		Private privateStarSpacing As Integer
		Public Property StarSpacing() As Integer
			Get
				Return privateStarSpacing
			End Get
			Set(ByVal value As Integer)
				privateStarSpacing = value
			End Set
		End Property

		Shared Sub New()
			starOnInternal = Resources.starOn
			starOffInternal = Resources.starOff
		End Sub

		Public Sub New()
			Stars = 10
			StarOn = starOnInternal
			StarOff = starOffInternal
		End Sub

		Protected Overrides Sub InitializeFields()
			MyBase.InitializeFields()
			Me.StretchHorizontally = True
		End Sub

		Protected Overrides Overloads Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
			Dim desiredSize As SizeF = SizeF.Empty

			Dim star As Bitmap = StarOn

			Dim border As Padding = GetBorderThickness(False)
			desiredSize.Height = star.Height + border.Vertical + Padding.Vertical
			desiredSize.Width = (star.Width + StarSpacing) * Stars + border.Horizontal + Padding.Horizontal

			desiredSize.Width += 40

			Return desiredSize
		End Function

		Protected Overrides Sub PaintElement(ByVal graphics As IGraphics, ByVal angle As Single, ByVal scale As SizeF)
			Dim clientRect As RectangleF = GetClientRectangle(Me.Size)
			Dim x As Integer = CInt(Fix(clientRect.X))
			Dim y As Integer = CInt(Fix(clientRect.Y))
			Dim i As Integer = 0
			Do While i < Rating
				graphics.DrawBitmap(StarOn, x, y)
				x += starOnInternal.Width + StarSpacing
				i += 1
			Loop
			Do While i < Stars
				graphics.DrawBitmap(StarOff, x, y)
				x += starOnInternal.Width + StarSpacing
				i += 1
			Loop

			Dim g As Graphics = CType(graphics.UnderlayGraphics, Graphics)
			Using brush As New SolidBrush(Me.ForeColor)
				y += 3
				g.DrawString(String.Format("{0}/{1}", Rating, Stars), Me.Font, brush, New PointF(x + 4, y - 2))
			End Using
		End Sub
	End Class
End Namespace
