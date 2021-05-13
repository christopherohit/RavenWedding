Imports Microsoft.VisualBasic
Imports System.Collections.ObjectModel
Imports System.Drawing
Imports System.Text

Namespace RichTextEditor.Parsers
	Friend Class CSharpSyntaxParser
		Inherits SyntaxParser
		Private keywords As String() = New String() { "abstract", "as", "base", "break", "byte", "bool", "char", "catch", "case", "checked", "class", "continue", "const", "decimal", "default", "delegate", "double", "do", "event", "explicit", "extern", "else", "enum", "finally", "false", "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface", "is", "internal", "lock", "long", "new", "namespace", "null", "object", "operator", "out", "override", "params", "private", "protected", "public", "partial", "return", "readonly", "ref", "struct", "switch", "sbyte", "sealed", "sizeof", "short", "stackalloc", "static", "string", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", "volatile", "void", "while" }

		Protected Overrides Function LoadLanguageSyntax(ByVal languageSyntax As Collection(Of LanguageSyntaxStructure)) As Collection(Of LanguageSyntaxStructure)
			 '//Load comments
			Dim comments As String = "\G(?<comment>(\/\/[ \t\S]*\s*\s*)|(\/\*\s*[\s\S]*\s*\*/\s))"
			languageSyntax.Add(New LanguageSyntaxStructure(comments, "comment", New SolidBrush(CType(ColorConverter.ConvertFromString("#537D01"), Color))))

			 '//Load Keywords
			Dim kwrds As StringBuilder = New StringBuilder()
			kwrds.Append("\G(?<keyword>(")
			Dim i As Integer = 0
			Do While i < Me.keywords.Length
				kwrds.Append(Me.keywords(i) & "|")
				i += 1
			Loop
			kwrds.Append(Me.keywords(Me.keywords.Length - 1))
			kwrds.Append(")(?=(\.)|(\s+)))")
			languageSyntax.Add(New LanguageSyntaxStructure(kwrds.ToString(), "keyword", New SolidBrush(CType(ColorConverter.ConvertFromString("#0160E5"), Color))))

			 '//Load string
			Dim strings As String = "\G(?<string>""\s*((\\"")|[^\""])*\s*""\s*)"
			languageSyntax.Add(New LanguageSyntaxStructure(strings, "string", New SolidBrush(CType(ColorConverter.ConvertFromString("#0160E5"), Color))))

			'//Load identifier
			Dim identifier As String = "\G(?<identifier>[\w]+\s*)"
			languageSyntax.Add(New LanguageSyntaxStructure(identifier, "identifier", New SolidBrush(CType(ColorConverter.ConvertFromString("#000000"), Color))))

			'//Load other
			Dim other As String = "\G(?<other>[\s\S]\s*)"
			languageSyntax.Add(New LanguageSyntaxStructure(other, "other", New SolidBrush(CType(ColorConverter.ConvertFromString("#000000"), Color))))
			Return MyBase.LoadLanguageSyntax(languageSyntax)
		End Function

		Protected Overrides Sub SetFileExtension(ByVal extension As String)
			MyBase.SetFileExtension(".cs")
		End Sub
	End Class
End Namespace
