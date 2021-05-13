Imports Microsoft.VisualBasic
Imports System

Namespace ExportWithDpl.SpreadsheetStreaming
    Public Class DocumentHelper
        Private Shared Clients As Client()
        Private Shared ReadOnly random As Random
        Private Shared ReadOnly StartingId As Integer = 1000
        Private Shared ReadOnly MaximumMinutesBetweenOrders As Integer = 40
        Private Shared ReadOnly Companies As String() = {"Circuit Design", "Excella", "Integra Design", "Plan Smart", "Webcom Services", "Zig Zag Coder"}
        Private Shared ReadOnly ClientNames As String() = {"Agnes Hill", "Alexandra Kennedy", "Alison Ross", "Alison Thompson", "Charles Miller", "Edward Hall", "Francis Stevens", "Glenda White", "Gregory Morrison", "Hannah Watson", "Jack Sims", "James Smith", "Jennie Walker", "Jerry Wright", "Joe Lawrence", "Juan Jacobs", "Kara Wood", "Keith Clark", "Lynda Evans", "Marian Rodriguez", "Mark Moore", "Natasha Green", "Nora Allen", "Patty Prince", "Ralph Burke", "Robyn Mason", "Roger Peters", "Samuel Green", "Scott Fox", "Scott Lewis", "Terry Lawson"}

        Private Sub New()
        End Sub
        Shared Sub New()
            random = New Random()
        End Sub

        Public Shared Function GenerateDocumentRow(ByVal documentRowsCount As Integer, ByVal rowIndex As Integer) As DocumentRow
            If Clients Is Nothing Then
                InitializeClients()
            End If

            Dim id As Integer = StartingId + rowIndex

            Dim minuteDelta As Integer = random.Next(MaximumMinutesBetweenOrders)
            Dim beginingDate As DateTime = DateTime.Now.Date.AddMinutes((documentRowsCount - rowIndex) * MaximumMinutesBetweenOrders * -1)
            Dim [date] As DateTime = beginingDate.AddMinutes(minuteDelta * -1)
            Dim time As DateTime = [date]

            Dim clinetIndex As Integer = random.Next(Clients.Length)
            Dim client As Client = Clients(clinetIndex)

            Dim discount As Double = random.Next(15) / 100.0F

            Dim shipping1 As Shipping = CType(random.Next(System.Enum.GetValues(GetType(Shipping)).Length), Shipping)

            Dim row As DocumentRow = New DocumentRow(id, [date], time, client, discount, shipping1)

            Return row
        End Function

        Private Shared Sub InitializeClients()
            Clients = New Client(ClientNames.Length - 1) {}

            Dim i As Integer = 0
            Do While i < Clients.Length
                Dim companyIndex As Integer = random.Next(0, Companies.Length)
                Clients(i) = New Client(ClientNames(i), Companies(companyIndex))
                i += 1
            Loop
        End Sub
    End Class
End Namespace
