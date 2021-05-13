Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Text
Imports System.Text.RegularExpressions

Namespace RichTextEditor.Parsers
	Friend Class Tokenizer
		Private Shared codeSyntax As Regex
		Private tokens As List(Of Token) = New List(Of Token)()
		Private picker As SyntaxPicker = New SyntaxPicker()
		Private languageStructure As Collection(Of LanguageSyntaxStructure)

		Public Enum ParserType
			''' <summary>
			''' 
			''' </summary>
			CSharp

			''' <summary>
			''' 
			''' </summary>
			VisualBasic

			''' <summary>
			''' 
			''' </summary>
			XAML
		End Enum

		Public Function TokenizeCode(ByVal code As String, ByVal extension As String) As List(Of Token)
			Me.tokens.Clear()

			Dim syntaxPicker As SyntaxParser = Me.picker.FindParserByExtension(extension)
			If syntaxPicker Is Nothing Then
				Throw New ArgumentException("No Syntax Parser found that can parse this file!", "extension")
			End If

			Me.languageStructure = syntaxPicker.GenerateLanguageSyntaxPatterns()

			codeSyntax = New Regex(Me.GenerateLanguageSyntaxRegularExpression(), RegexOptions.IgnoreCase Or RegexOptions.ExplicitCapture)

			Dim matches As MatchCollection = codeSyntax.Matches(code)

			If matches.Count <> 0 Then
				Dim i As Integer = 0
				Do While i < matches.Count
					Dim t As Token = Me.Tokenize(matches(i))
					Me.tokens.Add(t)
					i += 1
				Loop
			End If

			Return Me.tokens
		End Function

		Private Function GenerateLanguageSyntaxRegularExpression() As String
			Dim regEx As StringBuilder = New StringBuilder()
			regEx.Append("\s*")
			If Me.languageStructure.Count > 0 Then
				Dim i As Integer = 0
				Do While i < Me.languageStructure.Count - 1
					regEx.AppendFormat("{0}|", Me.languageStructure(i).RegexString)
					i += 1
				Loop
				regEx.AppendFormat("{0}", Me.languageStructure(Me.languageStructure.Count - 1).RegexString)
			End If
			regEx.Append("\s*")
			Return regEx.ToString()
		End Function

		Private Function Tokenize(ByVal match As Match) As Token
			Dim i As Integer = 0
			Do While i < Me.languageStructure.Count
				If match.Groups(Me.languageStructure(i).Description).Success Then
					Return New Token(match.Groups(Me.languageStructure(i).Description).Value, Me.languageStructure(i).Color)
				End If
				i += 1
			Loop
			Return New Token(Nothing, Nothing)
		End Function
	End Class
End Namespace
