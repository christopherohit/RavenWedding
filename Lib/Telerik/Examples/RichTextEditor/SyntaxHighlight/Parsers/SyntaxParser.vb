Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.ObjectModel

Namespace RichTextEditor.Parsers
	Friend Class SyntaxParser
		Implements IDisposable
		Private defaultExtension As String = ".default"

		Private languageSyntaxList As Collection(Of LanguageSyntaxStructure) = New Collection(Of LanguageSyntaxStructure)()

		<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")> _
		Public Sub New()
			Me.SetFileExtension(Me.defaultExtension)
		End Sub

		Public ReadOnly Property GetExtension() As String
			Get
				Return Me.defaultExtension
			End Get
		End Property

		Public Sub Dispose() Implements IDisposable.Dispose
			GC.SuppressFinalize(Me)
		End Sub

		Public Function GenerateLanguageSyntaxPatterns() As Collection(Of LanguageSyntaxStructure)
			Return Me.LoadLanguageSyntax(Me.languageSyntaxList)
		End Function

		Protected Overridable Sub SetFileExtension(ByVal extension As String)
			If (Not extension.StartsWith(".", StringComparison.OrdinalIgnoreCase)) Then
				Throw New ArgumentException("File Extension must start with a '.'!", "extension")
			End If
			Me.defaultExtension = extension
		End Sub

		Protected Overridable Function LoadLanguageSyntax(ByVal languageSyntax As Collection(Of LanguageSyntaxStructure)) As Collection(Of LanguageSyntaxStructure)
			Return languageSyntax
		End Function
	End Class
End Namespace
