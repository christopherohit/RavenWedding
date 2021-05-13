Imports System.Drawing
Imports System.IO
Imports System.Text
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinForms.Controls.SyntaxEditor.UI
Imports Telerik.WinForms.SyntaxEditor.Core.Tagging
Imports Telerik.WinForms.SyntaxEditor.Core.Text

Namespace Telerik.Examples.WinControls.SyntaxEditor.CustomLanguage
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Public Sub New()
            InitializeComponent()
            Dim file As String = "script.py"

            Using stream As Stream = GetType(Form1).Assembly.GetManifestResourceStream(file)
                Dim reader As StreamReader = New StreamReader(stream, Encoding.UTF8)
                Me.syntaxEditor.Document = New TextDocument(reader)
            End Using

            Dim pythonTagger As PythonTagger = New PythonTagger(Me.syntaxEditor.SyntaxEditorElement)

            If Not Me.syntaxEditor.TaggersRegistry.IsTaggerRegistered(pythonTagger) Then
                Me.syntaxEditor.TaggersRegistry.RegisterTagger(pythonTagger)
            End If

            Me.syntaxEditor.TextFormatDefinitions.AddLast(ClassificationTypes.NumberLiteral, New TextFormatDefinition(New SolidBrush(Color.Red)))
            Me.syntaxEditor.TextFormatDefinitions.AddLast(ClassificationTypes.[Operator], New TextFormatDefinition(New SolidBrush(Color.YellowGreen)))
            Me.syntaxEditor.TextFormatDefinitions.AddLast(PythonTagger.FruitsClassificationType, New TextFormatDefinition(New SolidBrush(Color.LightCoral)))
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Me.syntaxEditor.Focus()
        End Sub
    End Class
End Namespace
