Imports System.Text
Imports System.Xml.Serialization

Namespace CS.RSS_Library
	Public Class RssChannelImage
		Public Sub New()

		End Sub

		<XmlElement("url")>
		Public Property ImageUrl() As String

		<XmlElement("title")>
		Public Property Title() As String

		<XmlElement("link")>
		Public Property Link() As String

		Public ReadOnly Property Image() As Image
			Get
				Return DownloadImage(Me.ImageUrl)
			End Get
		End Property

		Public Function DownloadImage(ByVal _URL As String) As Image
			Dim _tmpImage As Image = Nothing

			Try
				' Open a connection
				Dim _HttpWebRequest As System.Net.HttpWebRequest = CType(System.Net.HttpWebRequest.Create(_URL), System.Net.HttpWebRequest)

				_HttpWebRequest.AllowWriteStreamBuffering = True

				' You can also specify additional header values like the user agent or the referer: (Optional)
				_HttpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)"
				_HttpWebRequest.Referer = "http://www.google.com/"

				' set timeout for 20 seconds (Optional)
				_HttpWebRequest.Timeout = 20000

				' Request response:
				Dim _WebResponse As System.Net.WebResponse = _HttpWebRequest.GetResponse()

				' Open data stream:
				Dim _WebStream As System.IO.Stream = _WebResponse.GetResponseStream()

				' convert webstream to image
				_tmpImage = Image.FromStream(_WebStream)

				' Cleanup
				_WebResponse.Close()
				_WebResponse.Close()
			Catch _Exception As Exception
				' Error
				Console.WriteLine("Exception caught in process: {0}", _Exception.ToString())
				Return Nothing
			End Try

			Return _tmpImage.GetThumbnailImage(75, 25, Function() True, IntPtr.Zero)


		End Function
	End Class
End Namespace
