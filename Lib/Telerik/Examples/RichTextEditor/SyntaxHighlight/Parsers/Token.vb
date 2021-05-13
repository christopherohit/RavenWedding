Imports Microsoft.VisualBasic
Imports System.Drawing
Imports Telerik.WinControls.RichTextEditor.UI
Imports Telerik.WinForms.Documents.Model

Namespace RichTextEditor.Parsers
    Friend Class Token
        Public Sub New(ByVal value As String, ByVal color As Brush)
            Me.New(value, color, False, False)
        End Sub

        Public Sub New(ByVal value As String, ByVal color As Brush, ByVal isBold As Boolean, ByVal isItalic As Boolean)
            Me.Value = value
            Me.Color = color
            Me.IsBold = isBold
            Me.IsItalic = isItalic
        End Sub

        Public Enum TokenType
            ''' <summary>
            ''' 
            ''' </summary>
            KeyWord

            ''' <summary>
            ''' 
            ''' </summary>
            Comment

            ''' <summary>
            ''' 
            ''' </summary>
            [String]

            ''' <summary>
            ''' 
            ''' </summary>
            Identifier

            ''' <summary>
            ''' 
            ''' </summary>
            Other

            ''' <summary>
            ''' 
            ''' </summary>
            None
        End Enum

        Private _Value As String
        Public Property Value() As String
            Get
                Return _Value
            End Get
            Private Set(value As String)
                _Value = Value
            End Set
        End Property

        Private _Color As Brush
        Public Property Color() As Brush
            Get
                Return _Color
            End Get
            Private Set(value As Brush)
                _Color = Value
            End Set
        End Property

        Private _IsBold As Boolean
        Public Property IsBold() As Boolean
            Get
                Return _IsBold
            End Get
            Private Set(value As Boolean)
                _IsBold = Value
            End Set
        End Property

        Private _IsItalic As Boolean
        Public Property IsItalic() As Boolean
            Get
                Return _IsItalic
            End Get
            Private Set(value As Boolean)
                _IsItalic = Value
            End Set
        End Property

        Public Function GetRun() As Run
            Return New Run() With { _
     .Text = Me.Value, _
     .Foreground = DirectCast(Me.Color, SolidBrush), _
     .FontWeight = If(Me.IsBold, FontWeights.ExtraBlack, FontWeights.Normal), _
     .FontStyle = If(Me.IsItalic, FontStyles.Italic, FontStyles.Normal) _
}

        End Function


        Public Function GetSpan() As Span
            Return New Span() With { _
                 .Text = Me.Value, _
                 .ForeColor = DirectCast(Me.Color, SolidBrush).Color, _
                 .FontWeight = If(Me.IsBold, FontWeights.ExtraBlack, FontWeights.Normal), _
                 .FontStyle = If(Me.IsItalic, FontStyles.Italic, FontStyles.Normal) _
            }
        End Function

        Public Function GetSpanStyle() As Span
            Return New Span() With { _
                 .ForeColor = DirectCast(Me.Color, SolidBrush).Color, _
                 .FontWeight = If(Me.IsBold, FontWeights.ExtraBlack, FontWeights.Normal), _
                 .FontStyle = If(Me.IsItalic, FontStyles.Italic, FontStyles.Normal) _
            }
        End Function

    End Class
End Namespace
