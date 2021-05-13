
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace ExportWithDpl.SpreadsheetStreamingExport
	Public Class Client
		Public Sub New(name As String, company As String)
			Me.Name = name
			Me.Company = company
		End Sub

		Public Property Name() As String
			Get
				Return m_Name
			End Get
			Private Set
				m_Name = Value
			End Set
		End Property
		Private m_Name As String

		Public Property Company() As String
			Get
				Return m_Company
			End Get
			Private Set
				m_Company = Value
			End Set
		End Property
		Private m_Company As String
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
