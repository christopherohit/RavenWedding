Imports System.Text
Imports System.Xml.Serialization

Namespace CS.RSS_Library
	<XmlType("enclosure")>
	Public Class RssItemImage
		Public Sub New()

		End Sub

		<XmlAttribute("url")>
		Public Property Url() As String

	End Class
End Namespace
