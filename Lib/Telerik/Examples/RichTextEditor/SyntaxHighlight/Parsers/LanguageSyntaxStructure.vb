Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing

Namespace RichTextEditor.Parsers
	Friend Class LanguageSyntaxStructure
		Private regexString_Renamed As String = Nothing
		Private segmentColor As Brush = Nothing
		Private description_Renamed As String

		Public Sub New(ByVal regularExpression As String, ByVal description_Renamed As String, ByVal color As Brush)
			Me.regexString_Renamed = regularExpression
			Me.segmentColor = color
			Me.description_Renamed = description_Renamed
		End Sub

		Public ReadOnly Property RegexString() As String
			Get
				Return Me.regexString_Renamed
			End Get
		End Property

		Public ReadOnly Property Description() As String
			Get
				Return Me.description_Renamed
			End Get
		End Property

		Public ReadOnly Property Color() As Brush
			Get
				Return Me.segmentColor
			End Get
		End Property
	End Class
End Namespace
