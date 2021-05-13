Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls
Imports HotelApp.Data

Namespace CustomControls
	Partial Public Class DateNavigator
		Inherits UserControl
		#Region "fields"
		Private calendarGlyph As New TextPrimitive()
		#End Region

		#Region "Constructors"
		Public Sub New()
			InitializeComponent()

			Me.BackColor = Color.Transparent
			Me.navigatorDateTimePicker.BackColor = Color.Transparent

			Me.navigatorDateTimePicker.DateTimePickerElement.TextBoxElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			Dim imagePrimitive_Renamed As ImagePrimitive = Me.navigatorDateTimePicker.DateTimePickerElement.ArrowButton.FindDescendant(Of ImagePrimitive)()
			imagePrimitive_Renamed.Visibility = ElementVisibility.Collapsed

			Me.navigatorDateTimePicker.DateTimePickerElement.ArrowButton.Children.Add(calendarGlyph)
			calendarGlyph.Text = ChrW(&He108).ToString()
			calendarGlyph.CustomFont = "TelerikWebUI"
			calendarGlyph.CustomFontSize = 20

			Me.navigatorDateTimePicker.DateTimePickerElement.ArrowButton.Alignment = ContentAlignment.MiddleRight
			Me.navigatorDateTimePicker.DateTimePickerElement.ArrowButton.Padding = New Padding(0)
			Me.navigatorDateTimePicker.DateTimePickerElement.ArrowButton.Margin = New Padding(5, 15, 5, 15)

			AddHandler Me.navigatorDateTimePicker.ValueChanged, AddressOf navigatorDateTimePicker_ValueChanged

			Me.leftNavigationButton_Renamed.RootElement.EnableElementShadow = False
			Me.rightNavigationButton_Renamed.RootElement.EnableElementShadow = False
			Me.navigatorDateTimePicker.RootElement.EnableElementShadow = False

			Me.leftNavigationButton_Renamed.ButtonElement.Text = ""
			Me.leftNavigationButton_Renamed.ButtonElement.CustomFont = "TelerikWebUI"
			Me.leftNavigationButton_Renamed.ButtonElement.CustomFontSize = 20
			Me.leftNavigationButton_Renamed.ButtonElement.ForeColor = Color.Gray
			Me.leftNavigationButton_Renamed.ButtonElement.Padding = New Padding(0, 5, 0, 0)
			Me.leftNavigationButton_Renamed.ButtonElement.Margin = New Padding(0, 15, 0, 15)
			Me.leftNavigationButton_Renamed.ButtonElement.EnableElementShadow = False

			Me.rightNavigationButton_Renamed.ButtonElement.Text = ""
			Me.rightNavigationButton_Renamed.ButtonElement.CustomFont = "TelerikWebUI"
			Me.rightNavigationButton_Renamed.ButtonElement.CustomFontSize = 20
			Me.rightNavigationButton_Renamed.ButtonElement.ForeColor = Color.Gray
			Me.rightNavigationButton_Renamed.ButtonElement.Padding = New Padding(0, 5, 0, 0)
			Me.rightNavigationButton_Renamed.ButtonElement.Margin = New Padding(0, 15, 0, 15)
			Me.rightNavigationButton_Renamed.ButtonElement.EnableElementShadow = False

			Me.dateLabel_Renamed.LabelElement.CustomFont = Utils.MainFont
			Me.dateLabel_Renamed.LabelElement.CustomFontSize = 14
			Me.dateLabel_Renamed.LabelElement.CustomFontStyle = FontStyle.Regular
			Me.dateLabel_Renamed.TextAlignment = ContentAlignment.MiddleLeft
			Me.dateLabel_Renamed.Margin = New Padding(-10, 0, 0, 0)
			Me.dateLabel_Renamed.LabelElement.LabelText.Margin = New Padding(0, 5, 0, 0)

			Dim calendar As RadDateTimePickerCalendar = TryCast(Me.navigatorDateTimePicker.DateTimePickerElement.CurrentBehavior, RadDateTimePickerCalendar)
			If calendar IsNot Nothing Then
				calendar.DateTimePickerElement.FindDescendant(Of StackLayoutElement)().StretchHorizontally = False
				calendar.Calendar.ShowFooter = True
			End If
			AddHandler Me.leftNavigationButton_Renamed.Click, AddressOf leftNavigationButton_Click
			AddHandler Me.rightNavigationButton_Renamed.Click, AddressOf rightNavigationButton_Click
			Me.navigatorDateTimePicker.Value = Date.Today

			Me.navigatorDateTimePicker.DateTimePickerElement.CalendarSize = New Size(340, 420)
		End Sub
		#End Region

		#Region "Events"
		Private Sub navigatorDateTimePicker_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.dateLabel_Renamed.Text = Me.navigatorDateTimePicker.Value.ToString("dd.MM.yyyy")
			If Me.navigatorDateTimePicker.Value = Date.Today Then
				Me.dateLabel_Renamed.Text &= " Today"
			End If
		End Sub

		Private Sub rightNavigationButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.navigatorDateTimePicker.Value = Me.navigatorDateTimePicker.Value.AddDays(1)
		End Sub

		Private Sub leftNavigationButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.navigatorDateTimePicker.Value = Me.navigatorDateTimePicker.Value.AddDays(-1)
		End Sub
		#End Region

		#Region "Properties"
		Public ReadOnly Property CurrentDate() As Date
			Get
				Return Me.navigatorDateTimePicker.Value
			End Get
		End Property

		Public ReadOnly Property LeftNavigationButton() As RadButton
			Get
				Return Me.leftNavigationButton_Renamed
			End Get
		End Property

		Public ReadOnly Property RightNavigationButton() As RadButton
			Get
				Return Me.rightNavigationButton_Renamed
			End Get
		End Property

		Public ReadOnly Property DateLabel() As RadLabel
			Get
				Return Me.dateLabel_Renamed
			End Get
		End Property

		Public ReadOnly Property DateTimePicker() As RadDateTimePicker
			Get
				Return Me.navigatorDateTimePicker
			End Get
		End Property

		#End Region

		#Region "Overrides"
		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			MyBase.OnPaint(e)
			calendarGlyph.ForeColor = Utils.MainThemeColor
		End Sub
		#End Region
	End Class
End Namespace