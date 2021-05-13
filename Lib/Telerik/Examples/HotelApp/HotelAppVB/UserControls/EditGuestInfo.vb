Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Telerik.WinControls
Imports HotelApp
Imports Telerik.WinControls.UI
Imports HotelApp.Data

Namespace CustomControls
	Partial Public Class EditGuestInfo
		Inherits UserControl
'INSTANT VB NOTE: The variable currentGuest was renamed since Visual Basic does not allow class members with the same name:
		Private currentGuest_Renamed As Guest
'INSTANT VB NOTE: The variable booking was renamed since Visual Basic does not handle variables named the same as their type well:
		Private booking_Renamed As Booking

		Public ReadOnly Property HeaderPanel() As RadPanel
			Get
				Return Me.headerPanel_Renamed
			End Get
		End Property

		Public ReadOnly Property SaveButton() As RadButton
			Get
				Return Me.saveButton_Renamed
			End Get
		End Property

		Public Sub New()
			InitializeComponent()

			Me.headerPanel_Renamed.RootElement.EnableElementShadow = False

			Me.guestInfoLabel.RootElement.EnableElementShadow = False
			Me.guestInfoLabel.LabelElement.CustomFont = Utils.MainFontMedium
			Me.guestInfoLabel.LabelElement.CustomFontSize = 10.5f
			Me.guestInfoLabel.LabelElement.LabelText.Margin = New Padding(5, 15, 0, 0)

			Me.nameLabel.LabelElement.CustomFont = Utils.MainFont
			Me.nameLabel.LabelElement.CustomFontSize = 10.5f
			Me.nameLabel.ForeColor = Color.FromArgb(89, 89, 89)
			Me.nameLabel.TextAlignment = ContentAlignment.BottomLeft

			Me.nameTextBox.TextBoxElement.CustomFont = Utils.MainFont
			Me.nameTextBox.TextBoxElement.CustomFontSize = 10.5f
			Me.nameTextBox.ForeColor = Color.FromArgb(33, 33, 33)

			Me.idLabel.LabelElement.CustomFont = Utils.MainFont
			Me.idLabel.LabelElement.CustomFontSize = 10.5f
			Me.idLabel.ForeColor = Color.FromArgb(89, 89, 89)
			Me.idLabel.TextAlignment = ContentAlignment.BottomLeft

			Me.idTextBox.TextBoxElement.CustomFont = Utils.MainFont
			Me.idTextBox.TextBoxElement.CustomFontSize = 10.5f
			Me.idTextBox.ForeColor = Color.FromArgb(33, 33, 33)

			Me.addressLabel.LabelElement.CustomFont = Utils.MainFont
			Me.addressLabel.LabelElement.CustomFontSize = 10.5f
			Me.addressLabel.ForeColor = Color.FromArgb(89, 89, 89)
			Me.addressLabel.TextAlignment = ContentAlignment.BottomLeft

			Me.addressTextBox.TextBoxElement.CustomFont = Utils.MainFont
			Me.addressTextBox.TextBoxElement.CustomFontSize = 10.5f
			Me.addressTextBox.ForeColor = Color.FromArgb(33, 33, 33)

			Me.cityLabel.LabelElement.CustomFont = Utils.MainFont
			Me.cityLabel.LabelElement.CustomFontSize = 10.5f
			Me.cityLabel.ForeColor = Color.FromArgb(89, 89, 89)
			Me.cityLabel.TextAlignment = ContentAlignment.BottomLeft

			Me.cityTextBox.TextBoxElement.CustomFont = Utils.MainFont
			Me.cityTextBox.TextBoxElement.CustomFontSize = 10.5f
			Me.cityTextBox.ForeColor = Color.FromArgb(33, 33, 33)

			Me.phoneLabel.LabelElement.CustomFont = Utils.MainFont
			Me.phoneLabel.LabelElement.CustomFontSize = 10.5f
			Me.phoneLabel.ForeColor = Color.FromArgb(89, 89, 89)
			Me.phoneLabel.TextAlignment = ContentAlignment.BottomLeft

			Me.phoneTextBox.TextBoxElement.CustomFont = Utils.MainFont
			Me.phoneTextBox.TextBoxElement.CustomFontSize = 10.5f
			Me.phoneTextBox.ForeColor = Color.FromArgb(33, 33, 33)

			Me.creditCardNumberLabel.LabelElement.CustomFont = Utils.MainFont
			Me.creditCardNumberLabel.LabelElement.CustomFontSize = 10.5f
			Me.creditCardNumberLabel.ForeColor = Color.FromArgb(89, 89, 89)
			Me.creditCardNumberLabel.TextAlignment = ContentAlignment.BottomLeft

			Me.creditCardNumberTexBox.TextBoxElement.CustomFont = Utils.MainFont
			Me.creditCardNumberTexBox.TextBoxElement.CustomFontSize = 10.5f
			Me.creditCardNumberTexBox.ForeColor = Color.FromArgb(33, 33, 33)

			Me.validLabel.LabelElement.CustomFont = Utils.MainFont
			Me.validLabel.LabelElement.CustomFontSize = 10.5f
			Me.validLabel.ForeColor = Color.FromArgb(89, 89, 89)

			Me.validDateTimePicker.DateTimePickerElement.CustomFont = Utils.MainFont
			Me.validDateTimePicker.DateTimePickerElement.CustomFontSize = 10.5f
			Me.validDateTimePicker.DateTimePickerElement.ForeColor = Color.FromArgb(33, 33, 33)

			Me.ccvLabel.LabelElement.CustomFont = Utils.MainFont
			Me.ccvLabel.LabelElement.CustomFontSize = 10.5f
			Me.ccvLabel.ForeColor = Color.FromArgb(89, 89, 89)

			Me.ccvTextBox.TextBoxElement.CustomFont = Utils.MainFont
			Me.ccvTextBox.TextBoxElement.CustomFontSize = 10.5f
			Me.ccvTextBox.ForeColor = Color.FromArgb(33, 33, 33)

			Me.editPanel.RootElement.EnableElementShadow = False
			Me.radSplitContainer1.RootElement.EnableElementShadow = False
			For Each c As RadControl In Me.editPanel.Controls
				c.RootElement.EnableElementShadow = False
			Next c

			For Each sp As Telerik.WinControls.UI.SplitPanel In Me.radSplitContainer1.SplitPanels
				sp.RootElement.EnableElementShadow = False
				sp.SplitPanelElement.Border.Visibility = ElementVisibility.Collapsed
				For Each c As RadControl In sp.Controls
					c.RootElement.EnableElementShadow = False
				Next c
			Next sp
			Me.closeButton.RootElement.EnableElementShadow = False
			Me.closeButton.ButtonElement.Padding = New Padding(0)
			Me.closeButton.ImageAlignment = ContentAlignment.TopRight
			Me.closeButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.closeButton.Image = My.Resources.not_clean

			Me.nameLabel.LabelElement.LabelText.Margin = New Padding(5, 0, 0, 0)
			Me.idLabel.LabelElement.LabelText.Margin = New Padding(5, 0, 0, 0)
			Me.addressLabel.LabelElement.LabelText.Margin = New Padding(5, 0, 0, 0)
			Me.cityLabel.LabelElement.LabelText.Margin = New Padding(5, 0, 0, 0)
			Me.phoneLabel.LabelElement.LabelText.Margin = New Padding(5, 0, 0, 0)
			Me.creditCardNumberLabel.LabelElement.LabelText.Margin = New Padding(5, 0, 0, 0)
			Me.validLabel.LabelElement.LabelText.Margin = New Padding(5, 0, 0, 0)

			Me.validDateTimePicker.Format = DateTimePickerFormat.Custom
			Me.validDateTimePicker.CustomFormat = "MM.yyyy"
			Me.validDateTimePicker.DateTimePickerElement.CalendarSize = New Size(350, 380)
			Me.validDateTimePicker.DateTimePickerElement.TextBoxElement.Padding = New Padding(10, 0, 0, 0)
			Me.validDateTimePicker.DateTimePickerElement.ArrowButton.Margin = New Padding(0, 0, 10, 0)

			Me.ccvTextBox.TextBoxElement.Padding = New Padding(3, 0, 0, 0)

			Me.nameTextBox.TextBoxElement.Border.Visibility = ElementVisibility.Collapsed
			Me.addressTextBox.TextBoxElement.Border.Visibility = ElementVisibility.Collapsed
			Me.cityTextBox.TextBoxElement.Border.Visibility = ElementVisibility.Collapsed
			Me.idTextBox.TextBoxElement.Border.Visibility = ElementVisibility.Collapsed
			Me.phoneTextBox.TextBoxElement.Border.Visibility = ElementVisibility.Collapsed
			Me.creditCardNumberTexBox.TextBoxElement.Border.Visibility = ElementVisibility.Collapsed

			Me.nameSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209)
			Me.idSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209)
			Me.addressSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209)
			Me.citySeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209)
			Me.phoneSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209)
			Me.creditCardSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209)
			Me.validSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209)
			Me.ccvSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209)
			Me.ccvTextBox.TextBoxElement.ShowBorder = False

			Me.saveButton_Renamed.ButtonElement.CustomFont = Utils.MainFontMedium
			Me.saveButton_Renamed.ButtonElement.CustomFontSize = 10.5f
			Me.saveButton_Renamed.ButtonElement.ForeColor = Color.FromArgb(33, 33, 33)

			Me.idTextBox.NullText = "Enter ID"
			Me.nameTextBox.NullText = "Enter name"
			Me.addressTextBox.NullText = "Enter address"
			Me.cityTextBox.NullText = "Enter city"
			Me.phoneTextBox.NullText = "Enter phone"
			Me.creditCardNumberTexBox.NullText = "Enter credit card id"
			Me.validDateTimePicker.Value = Date.Today
			Me.ccvTextBox.NullText = "Enter ccv"
		End Sub

		Public ReadOnly Property CurrentGuest() As Guest
			Get
				Return Me.currentGuest_Renamed
			End Get
		End Property

		Private Sub closeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles closeButton.Click
			Dim form As HotelAppForm = TryCast(Me.FindForm(), HotelAppForm)
			If form IsNot Nothing Then
				If form.PageView.SelectedPage Is form.PageView.Pages(1) Then
					Me.Parent.Visible = False
				Else
					Me.Visible = False
					Me.Parent.Controls(0).Visible = True
				End If
			End If
		End Sub

		Friend Sub Initialize(ByVal guest As HotelApp.Guest, ByVal booking_Renamed As Booking)
			currentGuest_Renamed = guest
			Me.booking_Renamed = booking_Renamed
			If currentGuest_Renamed Is Nothing Then
				Return
			End If
			Me.guestInfoLabel.Text = "EDIT GUEST INFORMATION"
			Me.idTextBox.Text = guest.Id
			Me.nameTextBox.Text = guest.Name
			Me.addressTextBox.Text = guest.Address
			Me.cityTextBox.Text = guest.City
			Me.phoneTextBox.Text = guest.Phone
			If guest.CardDetails IsNot Nothing Then
				Me.creditCardNumberTexBox.Text = guest.CardDetails.CreditCardId
				Me.validDateTimePicker.Value = guest.CardDetails.ExpiresOn
				Me.ccvTextBox.Text = guest.CardDetails.CCV.ToString()
			End If

			If booking_Renamed IsNot Nothing AndAlso (Not booking_Renamed.Guests.Contains(guest)) Then
				booking_Renamed.Guests.Add(guest)
				booking_Renamed.Name = booking_Renamed.Guests.First().Name
			End If
		End Sub

		Private Sub saveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveButton_Renamed.Click
			If IsValidData() Then
				If currentGuest_Renamed Is Nothing Then
					currentGuest_Renamed = New Guest()
					currentGuest_Renamed.CardDetails = New CreditCard()
				End If
				Me.currentGuest_Renamed.Name = Me.nameTextBox.Text
				Me.currentGuest_Renamed.Id = Me.idTextBox.Text
				Me.currentGuest_Renamed.Address = Me.addressTextBox.Text
				Me.currentGuest_Renamed.City = Me.cityTextBox.Text
				Me.currentGuest_Renamed.Phone = Me.phoneTextBox.Text
				Me.currentGuest_Renamed.CardDetails.CreditCardId = Me.creditCardNumberTexBox.Text
				Me.currentGuest_Renamed.CardDetails.ExpiresOn = Me.validDateTimePicker.Value
				Me.currentGuest_Renamed.CardDetails.CCV = UInteger.Parse(Me.ccvTextBox.Text)
				If Not Me.booking_Renamed.Guests.Contains(Me.currentGuest_Renamed) Then
					Me.booking_Renamed.Guests.Add(Me.currentGuest_Renamed)
				End If
				booking_Renamed.Name = booking_Renamed.Guests.First().Name
				Dim form As HotelAppForm = TryCast(Me.FindForm(), HotelAppForm)
				If form IsNot Nothing AndAlso (Not form.Bookings.Contains(Me.booking_Renamed)) Then
					form.Bookings.Add(Me.booking_Renamed)
				End If
				Me.saveButton_Renamed.DialogResult = DialogResult.OK
				Me.closeButton.PerformClick()
			Else
				Me.saveButton_Renamed.DialogResult = DialogResult.Cancel
			End If
		End Sub

		Private Function IsValidData() As Boolean
			Me.errorLabel.Text = ""
			Me.errorLabel.ForeColor = Color.Red
			If Me.nameTextBox.Text = "" Then
				Me.errorLabel.Text = "Name is not allowed to be empty!"
				Return False
			End If
			If Me.idTextBox.Text = "" Then
				Me.errorLabel.Text = "Id is not allowed to be empty!"
				Return False
			End If
			If Me.addressTextBox.Text = "" Then
				Me.errorLabel.Text = "Address is not allowed to be empty!"
				Return False
			End If
			If Me.cityTextBox.Text = "" Then
				Me.errorLabel.Text = "City is not allowed to be empty!"
				Return False
			End If
			If Me.phoneTextBox.Text = "" Then
				Me.errorLabel.Text = "Phone is not allowed to be empty!"
				Return False
			End If
			If Me.creditCardNumberTexBox.Text = "" Then
				Me.errorLabel.Text = "Credit card # is not allowed to be empty!"
				Return False
			End If
			Dim ccv As UInteger = 0
			If Not UInteger.TryParse(Me.ccvTextBox.Text, ccv) Then
				Me.errorLabel.Text = "CCV is not allowed to be empty!"
				Return False
			End If
			Return True
		End Function
	End Class
End Namespace