
Imports Telerik.WinForms.Documents.Model

Namespace RichTextEditor.StructuredContent
    Public Class RecipeRangeStart
        Inherits AnnotationRangeStart
#Region "Properties"

        <XamlSerializable> _
        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(value As String)
                m_Name = Value
            End Set
        End Property
        Private m_Name As String

        Public Sub New(name As String)
            Me.Name = name
        End Sub

        Public Overrides ReadOnly Property SkipPositionBefore() As Boolean
            Get
                Return True
            End Get
        End Property

#End Region

#Region "constructors"

        Public Sub New()
        End Sub

#End Region

#Region "Methods"

        Protected Overrides Sub CopyContentFromOverride(fromElement As DocumentElement)
            Me.Name = DirectCast(fromElement, RecipeRangeStart).Name
        End Sub

        Protected Overrides Function CreateNewElementInstance() As DocumentElement
            Return New RecipeRangeStart()
        End Function

#End Region
    End Class
End Namespace
