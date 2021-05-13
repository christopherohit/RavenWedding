Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.ChartView.LiveData
	Friend Class ExampleCustomShapeElement
		Inherits LightVisualElement
'INSTANT VB NOTE: The variable leftText was renamed since Visual Basic does not allow class members with the same name:
		Private leftText_Renamed As LightVisualElement
'INSTANT VB NOTE: The variable rightText was renamed since Visual Basic does not allow class members with the same name:
		Private rightText_Renamed As LightVisualElement

		Public Property LeftText() As String
			Get
				Return leftText_Renamed.Text
			End Get
			Set(ByVal value As String)
				leftText_Renamed.Text = value
			End Set
		End Property
		Public Property RightText() As String
			Get
				Return rightText_Renamed.Text
			End Get
			Set(ByVal value As String)
				rightText_Renamed.Text = value
			End Set
		End Property

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

			Me.BackColor = Color.FromArgb(142, 196, 65)
			Me.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias

			Me.Shape = GetShape()
			Me.DrawFill = True
			Me.GradientStyle = GradientStyles.Solid

			rightText_Renamed = New LightVisualElement()
			rightText_Renamed.ForeColor = Color.Black
			rightText_Renamed.TextWrap = True
			rightText_Renamed.TextAlignment = ContentAlignment.MiddleLeft

			leftText_Renamed = New LightVisualElement()
			leftText_Renamed.ForeColor = Color.White
			leftText_Renamed.Font = New Font("Segoe UI", 22F, FontStyle.Regular)
			leftText_Renamed.TextAlignment = ContentAlignment.MiddleRight

			Me.Children.Add(leftText_Renamed)
			Me.Children.Add(rightText_Renamed)
		End Sub

		Private Function GetShape() As ElementShape
			Dim points As New List(Of PointF)() From {New PointF(0,30), New PointF(10,0), New PointF(200,0), New PointF(200,30)}
			Dim shape As New CustomShape()
			shape.CreateClosedShape(points)
			Return shape
		End Function

		Protected Overrides Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
			Dim result As SizeF = SizeF.Empty

			MyBase.MeasureOverride(availableSize)

			Dim availableRightTextSize As New SizeF(80, availableSize.Height)
			Me.rightText_Renamed.Measure(availableRightTextSize)

			Dim rightTextDesiredSize As SizeF = Me.rightText_Renamed.DesiredSize
			Dim availableLeftTextSize As New SizeF(availableSize.Width - rightTextDesiredSize.Width, availableSize.Height)
			Me.leftText_Renamed.Measure(availableLeftTextSize)

			result.Width += rightTextDesiredSize.Width + leftText_Renamed.DefaultSize.Width
			result.Height = availableSize.Height

			Return result
		End Function

		Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
			Dim rect As RectangleF = GetClientRectangle(finalSize)

			'rightText
			Dim rightTextArea As New RectangleF(finalSize.Width - 85, 0, Me.rightText_Renamed.DesiredSize.Width, rect.Height)
			Me.rightText_Renamed.Arrange(rightTextArea)

			'leftText
			Dim leftTextArea As New RectangleF(finalSize.Width - 90 - Me.leftText_Renamed.DesiredSize.Width, 0, Me.leftText_Renamed.DesiredSize.Width, rect.Height)
			Me.leftText_Renamed.Arrange(leftTextArea)

			Return finalSize
		End Function





	End Class
End Namespace

