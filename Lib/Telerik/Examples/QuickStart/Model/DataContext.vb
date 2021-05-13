Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports My

Namespace Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational
    Public Class DataContext
        'INSTANT VB NOTE: The variable artists was renamed since Visual Basic does not allow class members with the same name:
        Private Shared artists As List(Of Artist) = Nothing
        'INSTANT VB NOTE: The variable topArtists was renamed since Visual Basic does not allow class members with the same name:
        Private Shared topArtists As List(Of Artist) = Nothing

        Protected Sub New()

        End Sub

        Public Shared ReadOnly Property Artists1() As List(Of Artist)
            Get
                If artists Is Nothing Then
                    Using stream As New MemoryStream(Resources.ChinookModel)
                        Dim formatter As New BinaryFormatter()
                        artists = CType(formatter.Deserialize(stream), List(Of Artist))
                    End Using
                End If

                Return artists
            End Get
        End Property

        Public Shared ReadOnly Property TopArtists1() As List(Of Artist)
            Get
                If topArtists Is Nothing Then
                    Using stream As New MemoryStream(Resources.ChinookModel)
                        Dim formatter As New BinaryFormatter()
                        topArtists = CType(formatter.Deserialize(stream), List(Of Artist))

                        Do While topArtists.Count > 50
                            topArtists.RemoveAt(topArtists.Count - 1)
                        Loop
                    End Using
                End If

                Return topArtists
            End Get
        End Property
    End Class
End Namespace
