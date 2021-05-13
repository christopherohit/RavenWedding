Imports System.Collections.Generic
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.SyntaxEditor.Core.Tagging
Imports System.Runtime.InteropServices
Imports Telerik.WinForms.Controls.SyntaxEditor.Taggers

Namespace Telerik.Examples.WinControls.SyntaxEditor.CustomLanguage
    Public Class PythonTagger
        Inherits WordTaggerBase

        Private Shared ReadOnly Keywords As String() = New String() {"False", "None", "True", "and", "as", "assert", "break", "class", "continue", "def", "del", "elif", "else", "except", "for", "from", "global", "if", "import", "in", "is", "lambda", "nonlocal", "not", "print", "or", "pass", "raise", "finally", "return", "try", "while", "with", "yield"}
        Private Shared ReadOnly Comments As String() = New String() {"#"}
        Private Shared ReadOnly Operators As String() = New String() {"+", "-", "", "/"}
        Public Shared ReadOnly FruitsClassificationType As ClassificationType = New ClassificationType("Fruits")
        Private Shared ReadOnly Fruits As String() = New String() {"apple", "banana", "cherry"}
        Private Shared ReadOnly WordsToClassificationType As Dictionary(Of String, ClassificationType) = New Dictionary(Of String, ClassificationType)()

        Shared Sub New()
            WordsToClassificationType = New Dictionary(Of String, ClassificationType)()

            For Each keyword As String In Keywords
                WordsToClassificationType.Add(keyword, ClassificationTypes.Keyword)
            Next

            For Each preprocessor As String In Operators
                WordsToClassificationType.Add(preprocessor, ClassificationTypes.[Operator])
            Next

            For Each comment As String In Comments
                WordsToClassificationType.Add(comment, ClassificationTypes.Comment)
            Next

            For Each comment As String In Fruits
                WordsToClassificationType.Add(comment, FruitsClassificationType)
            Next
        End Sub

        Public Sub New(ByVal editor As RadSyntaxEditorElement)
            MyBase.New(editor)
        End Sub

        Protected Overrides Function GetWordsToClassificationTypes() As Dictionary(Of String, ClassificationType)
            Return PythonTagger.WordsToClassificationType
        End Function

        Protected Overrides Function TryGetClassificationType(ByVal word As String, <Out> ByRef classificationType As ClassificationType) As Boolean
            Dim number As Integer

            If Integer.TryParse(word, number) Then
                classificationType = ClassificationTypes.NumberLiteral
                Return True
            End If

            Return MyBase.TryGetClassificationType(word, classificationType)
        End Function
    End Class
End Namespace
