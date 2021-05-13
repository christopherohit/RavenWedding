Imports System.Collections.Generic
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Net
Imports System.IO
Imports Telerik.WinControls
Imports System.Threading

Namespace CS.RSS_Library
    <XmlRoot("rss")> _
    Public Class RssFeed
        <XmlElement("channel")> _
        Public Property Channel() As RssChannel
            Get
                Return m_Channel
            End Get
            Set(value As RssChannel)
                m_Channel = value
            End Set
        End Property
        Private m_Channel As RssChannel

        Public Sub New()
        End Sub

        Public Shared Function Load(url As String) As RssFeed
            Try
                Dim serializer As New XmlSerializer(GetType(RssFeed))
                Using textReader As New XmlTextReader(url)
                    Dim feed As RssFeed = TryCast(serializer.Deserialize(textReader), RssFeed)
                    Return feed
                End Using
            Catch ex As Exception
                Dim feed As RssFeed = LoadAtomFeed(url)
                If feed Is Nothing Then
                    RadMessageBox.Show("Unsupported RSS feed version " + ex.Message)
                End If
                Return feed
            End Try
        End Function

        Private Shared Function LoadAtomFeed(url As String) As RssFeed
            Try
                Dim urlAddress As String = url
                Dim data As String = ""
                Dim request As HttpWebRequest = DirectCast(WebRequest.Create(urlAddress), HttpWebRequest)
                Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                If response.StatusCode = HttpStatusCode.OK Then
                    Dim receiveStream As Stream = response.GetResponseStream()
                    Dim readStream As StreamReader = Nothing
                    If String.IsNullOrEmpty(response.CharacterSet) Then
                        readStream = New StreamReader(receiveStream)
                    Else
                        readStream = New StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet))
                    End If
                    data = readStream.ReadToEnd()

                    response.Close()
                    readStream.Close()
                End If

                Dim xml As New XmlDocument()
                xml.LoadXml(data)

                Dim root As XmlElement = xml.DocumentElement
                If root.Name.ToLower() <> "feed" OrElse Not root.NamespaceURI.Contains("www.w3.org/2005/Atom") Then
                    Return Nothing
                End If

                Dim entries As XmlNodeList = root.GetElementsByTagName("entry")
                Dim atomFeed As New RssFeed()
                Dim channel As New RssChannel()
                channel.Title = root("title").InnerText

                atomFeed.Channel = channel
                Dim rssItems As New List(Of RssItem)()

                For Each entry As XmlElement In entries
                    Dim rssItem As New RssItem()
                    Dim description As String = ""
                    Dim title As String = entry("title").InnerText
                    Dim pubDate As String = entry("published").InnerText
                    Dim link As String = entry("link").Attributes("href").Value

                    If entry("media:group") IsNot Nothing Then
                        If entry("media:group")("media:description") IsNot Nothing Then
                            description = entry("media:group")("media:description").InnerText
                        End If
                        If entry("media:group")("media:thumbnail") IsNot Nothing AndAlso entry("media:group")("media:thumbnail").Attributes("url") IsNot Nothing Then
                            Dim imageUrl As New RssItemImage()
                            imageUrl.Url = entry("media:group")("media:thumbnail").Attributes("url").Value
                            rssItem.ImageUrl = imageUrl
                            Dim width As Integer = 50
                            If entry("media:group")("media:thumbnail").Attributes("width") IsNot Nothing Then
                                width = Integer.Parse(entry("media:group")("media:thumbnail").Attributes("width").Value)
                            End If
                            Dim height As Integer = 50
                            If entry("media:group")("media:thumbnail").Attributes("height") IsNot Nothing Then
                                height = Integer.Parse(entry("media:group")("media:thumbnail").Attributes("height").Value)
                            End If

                            description += "<br>" & "<a href=""" & link & """>" & "<img src=""" & imageUrl.Url & """ width=""" & width & """ height=""" & height & """ border=""0"" >" & "</a>"
                        End If
                    End If

                    If String.IsNullOrEmpty(description) AndAlso entry("content") IsNot Nothing Then
                        description = entry("content").InnerText
                    End If

                    If String.IsNullOrEmpty(description) AndAlso entry("summary") IsNot Nothing Then
                        description = entry("summary").InnerText
                    End If

                    rssItem.Description = description
                    rssItem.Title = title
                    rssItem.PubDate = pubDate
                    rssItem.Link = link
                    rssItems.Add(rssItem)
                Next

                channel.Items = rssItems.ToArray()
                Return atomFeed
            Catch generatedExceptionName As Exception
                Return Nothing
            End Try
        End Function
    End Class
End Namespace