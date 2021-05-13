Imports System.Text
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.PageView
	Friend Class PageViewImages
		Public Shared Images() As Image
		Public Shared Names() As String

		Shared Sub New()
            Names = New String() {"Alarm Clock.png", "Calendar.png", "E-book Reader.png", "Fire.png", "Home.png", "Light Bulb.png", "Megaphone.png", "Television.png", "Webcam.png"}

			Dim type As Type = GetType(PageViewImages)
            Images = New Image(8) {}

            For i As Integer = 0 To 8
                Images(i) = ResourceHelper.ImageFromResource(type, Names(i))
            Next i
		End Sub
	End Class
End Namespace
