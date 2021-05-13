Imports System.ComponentModel
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.PageView.StripView.ItemButtons
	''' <summary>
	''' Example beautifying 
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Private imageIndex As Integer
		Private pageIndex As Integer

		Public Sub New()
			InitializeComponent()

			Me.closeButtonCheck.Checked = True
			Me.radPageView1.ViewElement.ShowItemCloseButton = True

			For i As Integer = 0 To 4
				Dim page As New RadPageViewPage()
				page.Text = PageViewImages.Names(i)
				page.Image = PageViewImages.Images(i)

				Me.radPageView1.Pages.Add(page)
			Next i

			Me.pageIndex = 6
		End Sub

		Private Sub closeButtonCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radPageView1.ViewElement.ShowItemCloseButton = Me.closeButtonCheck.Checked
		End Sub

		Private Sub addButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.imageIndex = PageViewImages.Images.Length Then
				Me.imageIndex = 0
			End If

			Dim page As New RadPageViewPage()
            page.Text = "Page " & Me.pageIndex
            Me.pageIndex += 1
			page.Image = PageViewImages.Images(Me.imageIndex)
			Me.imageIndex += 1

			Me.radPageView1.Pages.Add(page)
			Me.radPageView1.SelectedPage = page
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler closeButtonCheck.ToggleStateChanged, AddressOf closeButtonCheck_ToggleStateChanged
			AddHandler addButton.Click, AddressOf addButton_Click
		End Sub
	End Class
End Namespace