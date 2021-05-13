Imports Microsoft.VisualBasic
Imports System.Collections.ObjectModel
Imports System.Drawing

Namespace RichTextEditor.Parsers
	Friend Class XamlSyntaxParser
		Inherits SyntaxParser
		Protected Overrides Function LoadLanguageSyntax(ByVal languageSyntax As Collection(Of LanguageSyntaxStructure)) As Collection(Of LanguageSyntaxStructure)
			'//Load attributes
			Dim attributes As String = "\G(?<attribute>[a-zA-Z][a-zA-Z0-9.:*_]*\s*(?==))"
			languageSyntax.Add(New LanguageSyntaxStructure(attributes, "attribute", New SolidBrush(CType(ColorConverter.ConvertFromString("#FF004E"), Color))))

			'//Load elements
			Dim elements As String = "\G(?<element>(?<=(<)|(</))[a-zA-Z][a-zA-Z0-9.:*_]*\s*)"
			languageSyntax.Add(New LanguageSyntaxStructure(elements, "element", New SolidBrush(CType(ColorConverter.ConvertFromString("#000000"), Color))))

			'//Load comments
			Dim comments As String = "\G(?<comment><!--\s*[\s\S]*\s*-->\s*)"
			languageSyntax.Add(New LanguageSyntaxStructure(comments, "comment", New SolidBrush(CType(ColorConverter.ConvertFromString("#537D01"), Color))))

			'//Load tags
			Dim tags As String = "\G(?<tag>(</|<|/>|>)\s*)"
			languageSyntax.Add(New LanguageSyntaxStructure(tags, "tag", New SolidBrush(CType(ColorConverter.ConvertFromString("#0160E5"), Color))))

			'//Load attribute strings
			Dim strings As String = "\G(?<string>=\s*""[_=#{}a-zA-Z0-9.:;\s-/,*]*\s*""\s*)"
			languageSyntax.Add(New LanguageSyntaxStructure(strings, "string", New SolidBrush(CType(ColorConverter.ConvertFromString("#0160E5"), Color))))

			'//Load content
			Dim content As String = "\G(?<content>[^<]+\s*)"
			languageSyntax.Add(New LanguageSyntaxStructure(content, "content", New SolidBrush(CType(ColorConverter.ConvertFromString("#0160E5"), Color))))
			Return MyBase.LoadLanguageSyntax(languageSyntax)
		End Function

		Protected Overrides Sub SetFileExtension(ByVal extension As String)
			MyBase.SetFileExtension(".xaml")
		End Sub
	End Class
End Namespace
