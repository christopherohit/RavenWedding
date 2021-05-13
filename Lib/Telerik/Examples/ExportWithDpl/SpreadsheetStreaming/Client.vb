Namespace ExportWithDpl.SpreadsheetStreaming
    Public Class Client
        Public Sub New(name As String, company As String)
            Me.Name = name
            Me.Company = company
        End Sub

        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Private Set(value As String)
                m_Name = value
            End Set
        End Property
        Private m_Name As String

        Public Property Company() As String
            Get
                Return m_Company
            End Get
            Private Set(value As String)
                m_Company = value
            End Set
        End Property
        Private m_Company As String
    End Class
End Namespace