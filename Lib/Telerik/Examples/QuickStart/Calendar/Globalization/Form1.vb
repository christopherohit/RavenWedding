Imports Telerik.QuickStart.WinControls
Imports System.Collections
Imports System.Globalization
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Calendar.Globalization
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radCalendar1
		End Sub

		#Region "Event Handlers"
		Private Sub radComboCultureList_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radCalendar1.Culture = TryCast(radComboCultureList.SelectedValue, CultureInfo)
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Dim cultures As New SortedList()

			Dim temp As CultureInfo
			For i As Integer = 0 To CultureInfo.GetCultures(CultureTypes.SpecificCultures).Length - 1
				temp = CultureInfo.GetCultures(CultureTypes.SpecificCultures)(i)

				If Not cultures.ContainsKey(temp.EnglishName) Then
					cultures.Add(temp.EnglishName, temp)
				End If
			Next i

			Dim ie As IEnumerator = cultures.Keys.GetEnumerator()
			Do While ie.MoveNext()
				Dim name As String = CStr(ie.Current)
				Dim item As New RadListDataItem(name)
				item.Value = cultures(name)
				radComboCultureList.Items.Add(item)
			Loop
			radCalendar1.Culture = CultureInfo.CurrentCulture
			radComboCultureList.SelectedIndex = radComboCultureList.FindString(CultureInfo.CurrentCulture.EnglishName)
			radCalendar1.FocusedDate = Date.Now
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			TryCast(Me.radCalendar1.RootElement.Children(0), RadCalendarElement).CalendarNavigationElement.Text = Me.radTextBox1.Text
			Me.radCalendar1.Invalidate()
		End Sub
		#End Region

		Protected Overrides Sub WireEvents()
			AddHandler radComboCultureList.SelectedIndexChanged, AddressOf radComboCultureList_SelectedIndexChanged
			AddHandler radButton1.Click, AddressOf radButton1_Click
		End Sub
	End Class
End Namespace