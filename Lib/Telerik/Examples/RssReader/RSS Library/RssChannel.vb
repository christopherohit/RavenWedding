Imports System.Text
Imports System.Xml.Serialization
Imports System.Web.UI.WebControls

Namespace CS.RSS_Library
	<XmlType("channel")>
	Public Class RssChannel
		Public Sub New()

		End Sub

		<XmlElement("title")>
		Public Property Title() As String

		<XmlElement("description")>
		Public Property Description() As String

		<XmlElement("link")>
		Public Property Link() As String

		<XmlElement("pubDate")>
		Public Property PubDate() As String

		<XmlElement("item")>
		Public Property Items() As RssItem()

		<XmlElement("image")>
		Public Property Image() As RssChannelImage
	End Class
End Namespace
