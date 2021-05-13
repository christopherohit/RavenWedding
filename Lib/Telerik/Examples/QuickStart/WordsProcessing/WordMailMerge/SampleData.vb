Imports System.Text

Namespace Telerik.Examples.WinControls.WordsProcessing.WordMailMerge
    Public Class Person
        'INSTANT VB NOTE: The variable firstName was renamed since Visual Basic does not allow class members with the same name:
        Private ReadOnly firstName_Renamed As String
        'INSTANT VB NOTE: The variable lastName was renamed since Visual Basic does not allow class members with the same name:
        Private ReadOnly lastName_Renamed As String

        Public Sub New(ByVal firstName As String, ByVal lastName As String)
            Me.firstName_Renamed = firstName
            Me.lastName_Renamed = lastName
        End Sub

        Public ReadOnly Property FirstName() As String
            Get
                Return Me.firstName_Renamed
            End Get
        End Property

        Public ReadOnly Property LastName() As String
            Get
                Return Me.lastName_Renamed
            End Get
        End Property

        Public Shared ReadOnly Property Persons() As IEnumerable(Of Person)
            Get
                Return New Person() {New Person("Andrew", "Fuller"), New Person("Nancy", "Davolio"), New Person("Janet", "Leverling"), New Person("Margaret", "Peacock"), New Person("Robert", "King"), New Person("Horst", "Kloss")}
            End Get
        End Property
    End Class
End Namespace
