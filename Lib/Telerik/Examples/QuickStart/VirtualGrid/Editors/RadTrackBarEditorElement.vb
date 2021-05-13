Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.VirtualGrid.Editors
	Public Class RadTrackBarEditorElement
		Inherits RadTrackBarElement
		Private editor As VirtualGridTrackBarEditor

		Public Sub New(ByVal editor As VirtualGridTrackBarEditor)
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

		Protected Overrides Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
			For Each element As RadElement In Me.Children
				element.Measure(New SizeF(availableSize.Width, availableSize.Height))
			Next element

			Return New SizeF(1, availableSize.Height)
		End Function

		Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
			Dim size As SizeF = finalSize
			size.Width -= 40

			Return MyBase.ArrangeOverride(size)
		End Function

		Public Overrides Sub OnValueChanged(ByVal e As EventArgs)
			MyBase.OnValueChanged(e)

			If Not Me.Parent Is Nothing AndAlso Not Me.TrackPositionChangedEvent Is Nothing Then
				RaiseEvent TrackPositionChanged(Me, EventArgs.Empty)
			End If
		End Sub
	End Class
End Namespace
