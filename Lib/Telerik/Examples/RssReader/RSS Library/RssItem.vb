Imports System.Text
Imports System.Xml.Serialization
Imports System.Threading
Imports System.ComponentModel



Namespace CS.RSS_Library
	Public Delegate Sub ImageDownloadedEventHandler(ByVal sender As Object, ByVal e As EventArgs)

	<XmlType("item")>
	Public Class RssItem
'INSTANT VB NOTE: The variable image was renamed since Visual Basic does not handle variables named the same as their type well:
		Private image_Renamed As Image
		Public Event ImageDownloaded As ImageDownloadedEventHandler

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

		<XmlElement("enclosure")>
		Public Property ImageUrl() As RssItemImage

		Public Function GetImage() As Image
			EnsureImage()
			Return image_Renamed
		End Function

		Private Sub DownloadImage(ByVal state As Object)
			Dim url As String = Me.ImageUrl.Url
			Dim tmpImage As Image = Nothing

			Try
				' Open a connection
				Dim httpWebRequest As System.Net.HttpWebRequest = CType(System.Net.HttpWebRequest.Create(url), System.Net.HttpWebRequest)

				httpWebRequest.AllowWriteStreamBuffering = True

				' You can also specify additional header values like the user agent or the referer: (Optional)
				httpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)"
				httpWebRequest.Referer = "http://www.google.com/"

				' set timeout for 20 seconds (Optional)
				httpWebRequest.Timeout = 20000

				' Request response:
				Dim webResponse As System.Net.WebResponse = httpWebRequest.GetResponse()

				' Open data stream:
				Dim webStream As System.IO.Stream = webResponse.GetResponseStream()

				' convert webstream to image
				tmpImage = Image.FromStream(webStream)

				' Cleanup
				webResponse.Close()
				webStream.Close()
			Catch _Exception As Exception
				' Error
				Console.WriteLine("Exception caught in process: {0}", _Exception.ToString())
				Me.image_Renamed = Nothing
			End Try

			If tmpImage IsNot Nothing Then
				Me.image_Renamed = tmpImage.GetThumbnailImage(75, 75, Function() True, IntPtr.Zero)

				OnImageDownloaded(Me, EventArgs.Empty)
			End If
		End Sub

		Private Sub EnsureImage()
			If Me.image_Renamed Is Nothing AndAlso Me.ImageUrl IsNot Nothing AndAlso (Not String.IsNullOrEmpty(Me.ImageUrl.Url)) Then
				ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf DownloadImage))
			End If
		End Sub

		Protected Overridable Sub OnImageDownloaded(ByVal obj As Object, ByVal e As EventArgs)
			RaiseEvent ImageDownloaded(Me, e)
		End Sub

	End Class
End Namespace
