Imports System
Imports System.Collections.Generic
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Chat.Settings
    Partial Public Class Form1
        Inherits ExamplesForm

        Private cards As Dictionary(Of String, BaseChatCardDataItem)
        Private author1 As Author
        Private author2 As Author

        Public Sub New()
            InitializeComponent()
            Me.CenteredControl = Me.radChat1

            Me.author1 = New Author(My.Resources.bot, "John Doe")
            Me.author2 = New Author(My.Resources.user, "Ben Davis")

            Me.radChat1.Author = author2

            Me.AddTextMessageExchange()
            Me.BuildCards()
        End Sub

        Private Sub BuildCards()
            Me.cards = New Dictionary(Of String, BaseChatCardDataItem)()
            Dim actions As List(Of ChatCardAction) = New List(Of ChatCardAction)()
            actions.Add(New ChatCardAction("IM"))
            actions.Add(New ChatCardAction("Call"))

            Dim chatImageCard As ChatImageCardDataItem = New ChatImageCardDataItem(My.Resources.architect, "Benjamin Vilanders", "Senior Architect", "As a Senior Architect his experience in the industry allows him to take on increased responsibility. Like other architects, he design buildings " & "and makes sure they are structurally sound. Due to his track record of quality performance, Benjamin also serves as a manager, a mentor, an advisor and coordinator.", actions, Nothing)

            Me.cards.Add("Image", chatImageCard)

            Dim flights As List(Of FlightInfo) = New List(Of FlightInfo)()
            flights.Add(New FlightInfo("Los Angelis", "LAX", DateTime.Now.AddDays(7), "New York", "JFK", DateTime.Now.AddDays(7).AddHours(5.5)))
            flights.Add(New FlightInfo("New York", "JFK", DateTime.Now.AddDays(14).AddHours(3), "Los Angelis", "LAX", DateTime.Now.AddDays(14).AddHours(9.1)))

            Dim chatFlightCard As ChatFlightCardDataItem = New ChatFlightCardDataItem("Andrew Fuller", flights, My.Resources.CardPlane, "$341", Nothing)
            Me.cards.Add("Flight", chatFlightCard)

            actions = New List(Of ChatCardAction)()
            actions.Add(New ChatCardAction("Browse packages"))
            actions.Add(New ChatCardAction("Gift cards"))

            Dim chatProductCard As ChatProductCardDataItem = New ChatProductCardDataItem(My.Resources.propertyStoreCars, "Arrive & Drive", "", "With our Arrive & Drive Packages, the only thing you will have to think about is driving. We make it simple for you to get more of what you love. We streamline the " & "entire process and have everything ready for you when you arrive at the track so you can get straight to racing.", "Packages from $340", actions, Nothing)
            Me.cards.Add("Product", chatProductCard)

            Dim chatWeatherCard As ChatWeatherCardDataItem = New ChatWeatherCardDataItem("Barcelona", My.Resources.sunny, "33°C", "Humidity: 76%", "Dew: 31°C", "Pressure: 1031 mb", "Wind Speed: 15 km/h NW")
            Me.cards.Add("Weather", chatWeatherCard)
        End Sub

        Protected Overrides Sub WireEvents()
            MyBase.WireEvents()
            AddHandler Me.radCheckBoxShowAvatars.ToggleStateChanged, AddressOf Me.RadCheckBoxShowAvatars_ToggleStateChanged
            AddHandler Me.radCheckBoxOneSidedMessages.ToggleStateChanged, AddressOf Me.RadCheckBoxOneSidedMessages_ToggleStateChanged

            AddHandler Me.radButtonTextMessages.Click, AddressOf Me.RadButtonTextMessages_Click
            AddHandler Me.radButtonMediaMessages.Click, AddressOf Me.RadButtonMediaMessages_Click
            AddHandler Me.radButtonSuggestedActions.Click, AddressOf Me.RadButtonSuggestedActions_Click

            AddHandler Me.radButtonImageCard.Click, AddressOf Me.RadButtonImageCard_Click
            AddHandler Me.radButtonFlightCard.Click, AddressOf Me.RadButtonFlightCard_Click
            AddHandler Me.radButtonProductCard.Click, AddressOf Me.RadButtonProductCard_Click
            AddHandler Me.radButtonWeatherCard.Click, AddressOf Me.RadButtonWeatherCard_Click
            AddHandler Me.radButtonCarousel.Click, AddressOf Me.RadButtonCarousel_Click

            AddHandler Me.radButtonListOverlay.Click, AddressOf Me.RadButtonListOverlay_Click
            AddHandler Me.radButtonTimeOverlay.Click, AddressOf Me.RadButtonTimeOverlay_Click
            AddHandler Me.radButtonCalendarOverlay.Click, AddressOf Me.RadButtonCalendarOverlay_Click
            AddHandler Me.radButtonDateTimeOverlay.Click, AddressOf Me.RadButtonDateTimeOverlay_Click
        End Sub

        Private Sub ClearChat()
            Me.radChat1.ChatElement.MessagesViewElement.Items.Clear()
            Me.radChat1.HideOverlay()
        End Sub

        Private Sub AddTextMessageExchange()
            Me.radChat1.AddMessage(New ChatTextMessage("Hello", author2, DateTime.Now))
            Me.radChat1.AddMessage(New ChatTextMessage("Hi there", author1, DateTime.Now))
            Me.radChat1.AddMessage(New ChatTextMessage("How can I help you?", author1, DateTime.Now))
            Me.radChat1.AddMessage(New ChatTextMessage("I'm looking for a killer WinForms UI components suite.", author2, DateTime.Now))
            Me.radChat1.AddMessage(New ChatTextMessage("You've come to the right place!", author1, DateTime.Now))
        End Sub

        Private Sub RadCheckBoxShowAvatars_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radChat1.ChatElement.MessagesViewElement.ShowAvatars = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        End Sub

        Private Sub RadCheckBoxOneSidedMessages_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radChat1.ChatElement.MessagesViewElement.ShowMessagesOnOneSide = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        End Sub

        Private Sub RadButtonTextMessages_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.AddTextMessageExchange()
        End Sub

        Private Sub RadButtonMediaMessages_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radChat1.AddMessage(New ChatTextMessage("Hello", author2, DateTime.Now))
            Me.radChat1.AddMessage(New ChatTextMessage("I'm looking for a new car.", author2, DateTime.Now))
            Me.radChat1.AddMessage(New ChatTextMessage("Hi there! What do you think of this one?", author1, DateTime.Now))
            Me.radChat1.AddMessage(New ChatMediaMessage(My.Resources.TV_car, New System.Drawing.Size(200, 150), author1, DateTime.Now, Nothing))
        End Sub

        Private Sub RadButtonSuggestedActions_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radChat1.AddMessage(New ChatTextMessage("Hello, here are the choices", author1, DateTime.Now))
            Dim actions As List(Of SuggestedActionDataItem) = New List(Of SuggestedActionDataItem)()

            For i As Integer = 0 To 7 - 1
                actions.Add(New SuggestedActionDataItem("Option " & (i + 1)))
            Next

            Me.radChat1.AddMessage(New ChatSuggestedActionsMessage(actions, author1, DateTime.Now))
        End Sub

        Private Sub RadButtonImageCard_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radChat1.AddMessage(New ChatCardMessage(Me.cards("Image"), Me.author1, DateTime.Now))
        End Sub

        Private Sub RadButtonFlightCard_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radChat1.AddMessage(New ChatCardMessage(Me.cards("Flight"), Me.author1, DateTime.Now))
        End Sub

        Private Sub RadButtonProductCard_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radChat1.AddMessage(New ChatCardMessage(Me.cards("Product"), Me.author1, DateTime.Now))
        End Sub

        Private Sub RadButtonWeatherCard_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radChat1.AddMessage(New ChatCardMessage(Me.cards("Weather"), Me.author1, DateTime.Now))
        End Sub

        Private Sub RadButtonCarousel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radChat1.AddMessage(New ChatCarouselMessage(Me.cards.Values, Me.author1, DateTime.Now))
        End Sub

        Private Sub RadButtonListOverlay_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim chatListOverlay As ChatListOverlay = New ChatListOverlay("List overlay")

            For i As Integer = 0 To 10 - 1
                chatListOverlay.ListView.Items.Add("Item " & i)
            Next

            Me.radChat1.AddMessage(New ChatOverlayMessage(chatListOverlay, Not Me.radRadioButtonShowAsOverlay.IsChecked, author1, DateTime.Now))
        End Sub

        Private Sub RadButtonTimeOverlay_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim chatTimeOverlay As ChatTimeOverlay = New ChatTimeOverlay("Choose time", DateTime.Now)
            Me.radChat1.AddMessage(New ChatOverlayMessage(chatTimeOverlay, Not Me.radRadioButtonShowAsOverlay.IsChecked, author1, DateTime.Now))
        End Sub

        Private Sub RadButtonCalendarOverlay_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim chatCalendarOverlay As ChatCalendarOverlay = New ChatCalendarOverlay("Choose a date", DateTime.Now)
            Me.radChat1.AddMessage(New ChatOverlayMessage(chatCalendarOverlay, Not Me.radRadioButtonShowAsOverlay.IsChecked, author1, DateTime.Now))
        End Sub

        Private Sub RadButtonDateTimeOverlay_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim chatDateTimeOverlay As ChatDateTimeOverlay = New ChatDateTimeOverlay("Choose time & date", DateTime.Now)
            Me.radChat1.AddMessage(New ChatOverlayMessage(chatDateTimeOverlay, Not Me.radRadioButtonShowAsOverlay.IsChecked, author1, DateTime.Now))
        End Sub
    End Class
End Namespace
