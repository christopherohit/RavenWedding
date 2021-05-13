Imports System.Drawing
Namespace RichTextEditor.Parsers
    Friend NotInheritable Class ColorConverter
        Private Sub New()
        End Sub
        Public Shared Function ConvertFromString(argb As String) As Color
            Dim result As UInteger
            If UInteger.TryParse(argb.TrimStart("#"c, "0"c), System.Globalization.NumberStyles.HexNumber, Nothing, result) Then
                Dim a As UInteger = &HFF
                Dim r As UInteger = (result >> 16) And &HFF
                Dim g As UInteger = (result >> 8) And &HFF
                Dim b As UInteger = result And &HFF

                Return Color.FromArgb(CByte(a), CByte(r), CByte(g), CByte(b))
            End If
            Return Color.Black
        End Function
    End Class
End Namespace