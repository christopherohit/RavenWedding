
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace ExportWithDpl.SpreadsheetStreamingExport
    Public Class DocumentRow
        Public Sub New(id As Integer, [date] As DateTime, time As DateTime, client As Client, discount As Double, shipping As Shipping)
            Me.Id = id
            Me.[Date] = [date]
            Me.Time = time
            Me.Client = client.Name
            Me.Company = client.Company
            Me.Discount = discount
            Me.Shipping = shipping
        End Sub

        Public Property Id() As Integer
            Get
                Return m_Id
            End Get
            Private Set
                m_Id = Value
            End Set
        End Property
        Private m_Id As Integer

        Public Property [Date]() As DateTime
            Get
                Return m_Date
            End Get
            Private Set
                m_Date = Value
            End Set
        End Property
        Private m_Date As DateTime
        Public Property Time() As DateTime
            Get
                Return m_Time
            End Get
            Private Set
                m_Time = Value
            End Set
        End Property
        Private m_Time As DateTime
        Public Property Client() As String
            Get
                Return m_Client
            End Get
            Private Set
                m_Client = Value
            End Set
        End Property
        Private m_Client As String
        Public Property Company() As String
            Get
                Return m_Company
            End Get
            Private Set
                m_Company = Value
            End Set
        End Property
        Private m_Company As String
        Public Property Discount() As Double
            Get
                Return m_Discount
            End Get
            Private Set
                m_Discount = Value
            End Set
        End Property
        Private m_Discount As Double
        Public Property Shipping() As Shipping
            Get
                Return m_Shipping
            End Get
            Private Set
                m_Shipping = Value
            End Set
        End Property
        Private m_Shipping As Shipping
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
