Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Calendar.ElementRenderEvent
	Partial Public Class Form1
		Inherits ExamplesForm
		Private daysInMonth As Integer = 30

		Public Sub New()
			InitializeComponent()

			Me.radCalendar1.FocusedDate = Date.Now
			Me.SelectedControl = Me.radCalendar1
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.PopulateCombo()
			Me.PopulateColors()
		End Sub

		#Region "Event Handlers"
		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.DatesList.SelectedValue IsNot Nothing Then
				Me.radCalendar1.FocusedDate = CDate(Me.DatesList.SelectedValue)
				Me.radCalendar1.InvalidateCalendar()
			End If
		End Sub
		#End Region

		Protected Sub PopulateCombo()
			Dim temp As Date = radCalendar1.DefaultView.ViewStartDate
			Dim year As Integer = radCalendar1.CurrentCalendar.GetYear(radCalendar1.DefaultView.ViewStartDate)
			Dim month As Integer = radCalendar1.CurrentCalendar.GetMonth(radCalendar1.DefaultView.ViewStartDate)
			Me.daysInMonth = radCalendar1.CurrentCalendar.GetDaysInMonth(year, month)
			For i As Integer = 0 To Me.daysInMonth - 1
				temp = radCalendar1.CurrentCalendar.AddDays(temp, 1)
				Dim item As New RadListDataItem(temp.ToShortDateString())
				item.Value = temp
				Me.DatesList.Items.Add(item)
			Next i

			Me.DatesList.DropDownStyle = RadDropDownStyle.DropDownList
		End Sub

		Protected Sub PopulateColors()
			Dim item As New RadListDataItem(Color.WhiteSmoke.ToString())
			item.Value = Color.WhiteSmoke
			Me.ColorList.Items.Add(item)

			item = New RadListDataItem(Color.Yellow.ToString())
			item.Value = Color.Yellow
			Me.ColorList.Items.Add(item)

			item = New RadListDataItem(Color.Orange.ToString())
			item.Value = Color.Orange
			Me.ColorList.Items.Add(item)

			item = New RadListDataItem(Color.Pink.ToString())
			item.Value = Color.Pink
			Me.ColorList.Items.Add(item)

			item = New RadListDataItem(Color.Magenta.ToString())
			item.Value = Color.Magenta
			Me.ColorList.Items.Add(item)

			item = New RadListDataItem(Color.Red.ToString())
			item.Value = Color.Red
			Me.ColorList.Items.Add(item)

			item = New RadListDataItem(Color.Purple.ToString())
			item.Value = Color.Purple
			Me.ColorList.Items.Add(item)

			item = New RadListDataItem(Color.Blue.ToString())
			item.Value = Color.Blue
			Me.ColorList.Items.Add(item)

			item = New RadListDataItem(Color.Cyan.ToString())
			item.Value = Color.Cyan
			Me.ColorList.Items.Add(item)

			item = New RadListDataItem(Color.Green.ToString())
			item.Value = Color.Green
			Me.ColorList.Items.Add(item)

			item = New RadListDataItem(Color.Gray.ToString())
			item.Value = Color.Gray
			Me.ColorList.Items.Add(item)

			item = New RadListDataItem(Color.Brown.ToString())
			item.Value = Color.Brown
			Me.ColorList.Items.Add(item)
		End Sub

		Private cellBackColor As Color = Color.Empty

		Private Sub radCalendar1_ElementRender(ByVal sender As Object, ByVal e As RenderElementEventArgs)
			If Me.DatesList.SelectedItem Is Nothing Then
				Return
			End If

			Dim renderDate As Date = CDate(Me.DatesList.SelectedValue)
			If renderDate.Equals(e.Day.Date) Then
				If Me.ColorList.SelectedItem IsNot Nothing Then
					e.Element.Text = Me.radTextBox1.Text
					e.Element.DrawFill = True

					If cellBackColor = Color.Empty Then
						cellBackColor = e.Element.BackColor
					End If

					e.Element.BackColor = CType(Me.ColorList.SelectedValue, Color)
					e.Element.Invalidate()
				End If
			Else
				e.Element.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
				e.Element.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radCalendar1.ElementRender, AddressOf radCalendar1_ElementRender
			AddHandler radButton1.Click, AddressOf radButton1_Click
		End Sub

	End Class
End Namespace