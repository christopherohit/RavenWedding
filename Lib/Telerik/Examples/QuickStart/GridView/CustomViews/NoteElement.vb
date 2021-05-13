Imports System.Text
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.CustomViews
	Public Class NoteElement
		Inherits LightVisualElement
		Protected Overrides Sub InitializeFields()
			MyBase.InitializeFields()
			Me.StretchHorizontally = True
			Me.StretchVertically = True
			Me.ForeColor = Color.Black
			Me.TextAlignment = ContentAlignment.TopLeft
			Me.TextWrap = True
			Me.DisableHTMLRendering = False
			Me.ClipDrawing = True
			Me.BypassLayoutPolicies = True
		End Sub

		Protected Overrides Overloads Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
			MyBase.MeasureOverride(availableSize)
			Return New SizeF(1, 1)
		End Function
	End Class
End Namespace
