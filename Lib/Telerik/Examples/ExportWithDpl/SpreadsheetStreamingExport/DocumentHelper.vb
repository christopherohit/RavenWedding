
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace ExportWithDpl.SpreadsheetStreamingExport
    Public NotInheritable Class DocumentHelper
        Private Sub New()
        End Sub
        Private Shared ReadOnly random As Random
        Private Shared ReadOnly StartingId As Integer = 1000
        Private Shared ReadOnly ClientNames As String() = {"Agnes Hill", "Alexandra Kennedy", "Alison Ross", "Alison Thompson", "Charles Miller", "Edward Hall", _
            "Francis Stevens", "Glenda White", "Gregory Morrison", "Hannah Watson", "Jack Sims", "James Smith", _
            "Jennie Walker", "Jerry Wright", "Joe Lawrence", "Juan Jacobs", "Kara Wood", "Keith Clark", _
            "Lynda Evans", "Marian Rodriguez", "Mark Moore", "Natasha Green", "Nora Allen", "Patty Prince", _
            "Ralph Burke", "Robyn Mason", "Roger Peters", "Samuel Green", "Scott Fox", "Scott Lewis", _
            "Terry Lawson"}

        Private Shared ReadOnly Companies As String() = {"Circuit Design", "Excella", "Integra Design", "Plan Smart", "Webcom Services", "Zig Zag Coder"}
        Private Shared ReadOnly MaximumMinutesBetweenOrders As Integer = 40

        Private Shared Clients As Client()

        Shared Sub New()
            random = New Random()
        End Sub

        Public Shared Function GenerateDocumentRow(documentRowsCount As Integer, rowIndex As Integer) As DocumentRow
            If Clients Is Nothing Then
                InitializeClients()
            End If

            Dim id As Integer = StartingId + rowIndex

            Dim minuteDelta As Integer = random.[Next](MaximumMinutesBetweenOrders)
            Dim beginingDate As DateTime = DateTime.Now.[Date].AddMinutes((documentRowsCount - rowIndex) * MaximumMinutesBetweenOrders * -1)
            Dim [date] As DateTime = beginingDate.AddMinutes(minuteDelta * -1)
            Dim time As DateTime = [date]

            Dim clinetIndex As Integer = random.[Next](Clients.Length)
            Dim client As Client = Clients(clinetIndex)

            Dim discount As Double = random.[Next](15) / 100F

            Dim shipping As Shipping = DirectCast(random.[Next]([Enum].GetValues(GetType(Shipping)).Length), Shipping)

            Dim row As New DocumentRow(id, [date], time, client, discount, shipping)

            Return row
        End Function

        Private Shared Sub InitializeClients()
            Clients = New Client(ClientNames.Length - 1) {}
            For i As Integer = 0 To Clients.Length - 1
                Dim companyIndex As Integer = random.[Next](0, Companies.Length)
                Clients(i) = New Client(ClientNames(i), Companies(companyIndex))
            Next
        End Sub
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
