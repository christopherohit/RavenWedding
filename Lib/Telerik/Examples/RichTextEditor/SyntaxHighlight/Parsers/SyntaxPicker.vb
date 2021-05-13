Imports Microsoft.VisualBasic
Imports System.Collections.Generic

Namespace RichTextEditor.Parsers
	Friend Class SyntaxPicker
		Private parsers As List(Of SyntaxParser) = New List(Of SyntaxParser)()

		Friend Sub New()
			Me.AddParser(New CSharpSyntaxParser())
			Me.AddParser(New XamlSyntaxParser())
		End Sub

		Friend Sub AddParser(ByVal parser As SyntaxParser)
			Me.parsers.Add(parser)
		End Sub

		Friend Function FindParserByExtension(ByVal extension As String) As SyntaxParser
			For Each parser As SyntaxParser In Me.parsers
				If parser.GetExtension = extension Then
					Return parser
				End If
			Next parser
			Return Nothing
		End Function
	End Class
End Namespace
