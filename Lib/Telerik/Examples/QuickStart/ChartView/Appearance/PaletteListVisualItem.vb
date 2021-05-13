Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.ChartView.Appearance
	Public Class PaletteListVisualItem
        Inherits RadListVisualItem

        Private boxes As LightVisualElement()

		Shared Sub New()
			RadListVisualItem.SynchronizationProperties.Add(PaletteListDataItem.PaletteProperty)
		End Sub

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(RadListVisualItem)
			End Get
		End Property

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

            boxes = New LightVisualElement(7) {}

			Dim boxLayout As New BoxLayout()

			Dim stack As New StackLayoutPanel()
			stack.Orientation = Orientation.Horizontal
			stack.Margin = New Padding(0, 0, 2, 0)
			stack.StretchHorizontally = False
			stack.SetValue(BoxLayout.StripPositionProperty, BoxLayout.StripPosition.Last)

			For i As Integer = 0 To 7
				Dim element As New LightVisualElement()
				stack.Children.Add(element)

				element.MinSize = New Size(13, 0)
				element.DrawFill = True
				element.GradientStyle = GradientStyles.Solid
				element.Margin = New Padding(0, 2, 0, 2)
				element.DrawBorder = True
				element.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
				element.BorderLeftWidth = 0
				element.BorderLeftColor = Color.White
				element.BorderRightColor = Color.White
				element.BorderTopColor = Color.White
				element.BorderBottomColor = Color.White
				If i = 0 Then
					element.BorderLeftWidth = 1
					element.MinSize = New Size(14, 10)
				End If
				boxes(i) = element
			Next i

			boxLayout.Children.Add(stack)
			Me.Children.Add(boxLayout)
		End Sub

		Protected Overrides Sub PropertySynchronized(ByVal [property] As RadProperty)
			Dim dataItem As PaletteListDataItem = CType(Me.Data, PaletteListDataItem)
			For i As Integer = 0 To boxes.Length - 1
				boxes(i).BackColor = dataItem.Palette.GlobalEntries(i).Fill
			Next i
		End Sub
	End Class
End Namespace
