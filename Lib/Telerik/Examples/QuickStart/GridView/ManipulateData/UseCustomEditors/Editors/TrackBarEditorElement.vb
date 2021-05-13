Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.ManipulateData.UseCustomEditors
	Public Class TrackBarEditorElement
		Inherits RadTrackBarElement
		Private editor As TrackBarEditor

		Public Sub New(ByVal editor As TrackBarEditor)
			Me.CanFocus = True
			Me.editor = editor
			Me.Maximum = 100
			Me.TickStyle = Telerik.WinControls.Enumerations.TickStyles.Both
			Me.SmallTickFrequency = 5
			Me.LargeTickFrequency = 20
			Me.BodyElement.ScaleContainerElement.TopScaleElement.StretchVertically = True
			Me.BodyElement.ScaleContainerElement.BottomScaleElement.StretchVertically = True
			Me.StretchVertically = False
		End Sub

		Public Event TrackPositionChanged As EventHandler

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(RadTrackBarElement)
			End Get
		End Property

		Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
			MyBase.OnKeyDown(e)

			Dim grid As RadGridView = TryCast(Me.ElementTree.Control, RadGridView)
			If grid IsNot Nothing Then
				Select Case e.KeyCode
					Case Keys.Escape, Keys.Enter, Keys.Up, Keys.Down
						grid.GridBehavior.ProcessKeyDown(e)

					Case Keys.Left
						If Me.Value > Me.Minimum Then
							Me.Value -= 1
						End If

					Case Keys.Right
						If Me.Value < Me.Maximum Then
							Me.Value += 1
						End If

					Case Keys.Home
						Me.Value = Me.Minimum

					Case Keys.End
						Me.Value = Me.Maximum
				End Select
			End If
		End Sub

		Protected Overrides Overloads Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
			Dim desiredHeight As Integer = 40
			For Each element As RadElement In Me.Children
				element.Measure(New SizeF(availableSize.Width, desiredHeight))
			Next element
			Return New SizeF(1, desiredHeight)
		End Function

		Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
			Dim size As SizeF = finalSize
			size.Width -= 40
			Return MyBase.ArrangeOverride(size)
		End Function

		Public Overrides Sub OnValueChanged(ByVal e As EventArgs)
			MyBase.OnValueChanged(e)
			If Me.Parent IsNot Nothing AndAlso Me.TrackPositionChangedEvent IsNot Nothing Then
				RaiseEvent TrackPositionChanged(Me, EventArgs.Empty)
			End If
		End Sub
	End Class
End Namespace
