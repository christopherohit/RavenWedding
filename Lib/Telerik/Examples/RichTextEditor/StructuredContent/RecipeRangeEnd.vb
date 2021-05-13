Imports Microsoft.VisualBasic
Imports System
Imports Telerik.WinForms.Documents.Model

Namespace RichTextEditor.StructuredContent
	Public Class RecipeRangeEnd
		Inherits AnnotationRangeEnd
		#Region "Properties"

		Public Overrides ReadOnly Property SkipPositionBefore() As Boolean
			Get
				Return False
			End Get
		End Property

		#End Region

		#Region "Methods"

		Protected Overrides Function CreateRangeStartInstance() As AnnotationRangeStart
			Return New RecipeRangeStart()
		End Function

		Protected Overrides Function CreateNewElementInstance() As DocumentElement
			Return New RecipeRangeEnd()
		End Function

		Protected Overrides Sub CopyContentFromOverride(ByVal fromElement As DocumentElement)
		End Sub

		#End Region
	End Class
End Namespace
