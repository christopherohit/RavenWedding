Imports System.Text
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Integration.BubbleBar
	''' <summary>
	''' Behavior class defining the OnMouseOver behavior of the BubbleBar
	''' </summary>
	Public Class BubbleBarMouseOverBehavior
		Inherits PropertyChangeBehavior
		Public Sub New()
			MyBase.New(RadItem.IsMouseOverProperty)
		End Sub

		Public Overrides Sub OnPropertyChange(ByVal element As RadElement, ByVal e As RadPropertyChangedEventArgs)
			If CBool(e.NewValue) = True Then
				element.ResetValue(RadElement.ScaleTransformProperty)

				Dim animatedExpand As New AnimatedPropertySetting(RadElement.ScaleTransformProperty, New SizeF(0.65f, 0.65f), New SizeF(1f, 1f), 5, 30)

				animatedExpand.ApplyValue(element)
			Else
				Dim animatedExpand As New AnimatedPropertySetting(RadElement.ScaleTransformProperty, Nothing, New SizeF(0.65f, 0.65f), 5, 30)

				animatedExpand.ApplyValue(element)
			End If
		End Sub
	End Class
End Namespace
