using System;
using System.Collections.Generic;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Chat.Settings
{
    public partial class Form1 : ExamplesForm
    {
        Dictionary<string, BaseChatCardDataItem> cards;

        private Author author1;
        private Author author2;

        public Form1()
        {
            InitializeComponent();
            this.CenteredControl = this.radChat1;

            this.author1 = new Author(Properties.Resources.bot, "John Doe");
            this.author2 = new Author(Properties.Resources.user, "Ben Davis");

            this.radChat1.Author = author2;

            this.AddTextMessageExchange();
            this.BuildCards();
        }

        private void BuildCards()
        {
            this.cards = new Dictionary<string, BaseChatCardDataItem>();

            List<ChatCardAction> actions = new List<ChatCardAction>();
            actions.Add(new ChatCardAction("IM"));
            actions.Add(new ChatCardAction("Call"));

            ChatImageCardDataItem chatImageCard = new ChatImageCardDataItem(Properties.Resources.architect, "Benjamin Vilanders", "Senior Architect",
                "As a Senior Architect his experience in the industry allows him to take on increased responsibility. Like other architects, he design buildings " +
                "and makes sure they are structurally sound. Due to his track record of quality performance, Benjamin also serves as a manager, a mentor, an advisor and coordinator.", actions, null);

            this.cards.Add("Image", chatImageCard);

            List<FlightInfo> flights = new List<FlightInfo>();

            flights.Add(new FlightInfo("Los Angelis", "LAX", DateTime.Now.AddDays(7), "New York", "JFK", DateTime.Now.AddDays(7).AddHours(5.5)));
            flights.Add(new FlightInfo("New York", "JFK", DateTime.Now.AddDays(14).AddHours(3), "Los Angelis", "LAX", DateTime.Now.AddDays(14).AddHours(9.1)));

            ChatFlightCardDataItem chatFlightCard = new ChatFlightCardDataItem("Andrew Fuller", flights, Properties.Resources.CardPlane, "$341", null);

            this.cards.Add("Flight", chatFlightCard);

            actions = new List<ChatCardAction>();
            actions.Add(new ChatCardAction("Browse packages"));
            actions.Add(new ChatCardAction("Gift cards"));

            ChatProductCardDataItem chatProductCard = new ChatProductCardDataItem(Properties.Resources.propertyStoreCars, "Arrive & Drive", "",
                "With our Arrive & Drive Packages, the only thing you will have to think about is driving. We make it simple for you to get more of what you love. We streamline the " +
                "entire process and have everything ready for you when you arrive at the track so you can get straight to racing.", "Packages from $340", actions, null);

            this.cards.Add("Product", chatProductCard);

            ChatWeatherCardDataItem chatWeatherCard = new ChatWeatherCardDataItem("Barcelona", Properties.Resources.sunny, "33°C", "Humidity: 76%", "Dew: 31°C", "Pressure: 1031 mb", "Wind Speed: 15 km/h NW");

            this.cards.Add("Weather", chatWeatherCard);
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.radCheckBoxShowAvatars.ToggleStateChanged += this.RadCheckBoxShowAvatars_ToggleStateChanged;
            this.radCheckBoxOneSidedMessages.ToggleStateChanged += this.RadCheckBoxOneSidedMessages_ToggleStateChanged;

            this.radButtonTextMessages.Click += this.RadButtonTextMessages_Click;
            this.radButtonMediaMessages.Click += this.RadButtonMediaMessages_Click;
            this.radButtonSuggestedActions.Click += this.RadButtonSuggestedActions_Click;

            this.radButtonImageCard.Click += this.RadButtonImageCard_Click;
            this.radButtonFlightCard.Click += this.RadButtonFlightCard_Click;
            this.radButtonProductCard.Click += this.RadButtonProductCard_Click;
            this.radButtonWeatherCard.Click += this.RadButtonWeatherCard_Click;
            this.radButtonCarousel.Click += this.RadButtonCarousel_Click;

            this.radButtonListOverlay.Click += this.RadButtonListOverlay_Click;
            this.radButtonTimeOverlay.Click += this.RadButtonTimeOverlay_Click;
            this.radButtonCalendarOverlay.Click += this.RadButtonCalendarOverlay_Click;
            this.radButtonDateTimeOverlay.Click += this.RadButtonDateTimeOverlay_Click;
        }

        private void ClearChat()
        {
            this.radChat1.ChatElement.MessagesViewElement.Items.Clear();
            this.radChat1.HideOverlay();
        }

        private void AddTextMessageExchange()
        {
            this.radChat1.AddMessage(new ChatTextMessage("Hello", author2, DateTime.Now));
            this.radChat1.AddMessage(new ChatTextMessage("Hi there", author1, DateTime.Now));
            this.radChat1.AddMessage(new ChatTextMessage("How can I help you?", author1, DateTime.Now));
            this.radChat1.AddMessage(new ChatTextMessage("I'm looking for a killer WinForms UI components suite.", author2, DateTime.Now));
            this.radChat1.AddMessage(new ChatTextMessage("You've come to the right place!", author1, DateTime.Now));
        }

        private void RadCheckBoxShowAvatars_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radChat1.ChatElement.MessagesViewElement.ShowAvatars = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void RadCheckBoxOneSidedMessages_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radChat1.ChatElement.MessagesViewElement.ShowMessagesOnOneSide = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void RadButtonTextMessages_Click(object sender, EventArgs e)
        {
            this.AddTextMessageExchange();
        }

        private void RadButtonMediaMessages_Click(object sender, EventArgs e)
        {
            this.radChat1.AddMessage(new ChatTextMessage("Hello", author2, DateTime.Now));
            this.radChat1.AddMessage(new ChatTextMessage("I'm looking for a new car.", author2, DateTime.Now));
            this.radChat1.AddMessage(new ChatTextMessage("Hi there! What do you think of this one?", author1, DateTime.Now));
            this.radChat1.AddMessage(new ChatMediaMessage(Properties.Resources.TV_car, new System.Drawing.Size(200, 150), author1, DateTime.Now, null));
        }

        private void RadButtonSuggestedActions_Click(object sender, EventArgs e)
        {
            this.radChat1.AddMessage(new ChatTextMessage("Hello, here are the choices", author1, DateTime.Now));

            List<SuggestedActionDataItem> actions = new List<SuggestedActionDataItem>();

            for (int i = 0; i < 7; i++)
            {
                actions.Add(new SuggestedActionDataItem("Option " + (i + 1))); 
            }

            this.radChat1.AddMessage(new ChatSuggestedActionsMessage(actions, author1, DateTime.Now));
        }

        private void RadButtonImageCard_Click(object sender, EventArgs e)
        {
            this.radChat1.AddMessage(new ChatCardMessage(this.cards["Image"], this.author1, DateTime.Now));
        }

        private void RadButtonFlightCard_Click(object sender, EventArgs e)
        {
            this.radChat1.AddMessage(new ChatCardMessage(this.cards["Flight"], this.author1, DateTime.Now));
        }

        private void RadButtonProductCard_Click(object sender, EventArgs e)
        {
            this.radChat1.AddMessage(new ChatCardMessage(this.cards["Product"], this.author1, DateTime.Now));
        }

        private void RadButtonWeatherCard_Click(object sender, EventArgs e)
        {
            this.radChat1.AddMessage(new ChatCardMessage(this.cards["Weather"], this.author1, DateTime.Now));
        }

        private void RadButtonCarousel_Click(object sender, EventArgs e)
        {
            this.radChat1.AddMessage(new ChatCarouselMessage(this.cards.Values, this.author1, DateTime.Now));
        }

        private void RadButtonListOverlay_Click(object sender, EventArgs e)
        {
            ChatListOverlay chatListOverlay = new ChatListOverlay("List overlay");

            for (int i = 0; i < 10; i++)
            {
                chatListOverlay.ListView.Items.Add("Item " + i); 
            }

            this.radChat1.AddMessage(new ChatOverlayMessage(chatListOverlay, !this.radRadioButtonShowAsOverlay.IsChecked, author1, DateTime.Now));
        }

        private void RadButtonTimeOverlay_Click(object sender, EventArgs e)
        {
            ChatTimeOverlay chatTimeOverlay = new ChatTimeOverlay("Choose time", DateTime.Now);
            
            this.radChat1.AddMessage(new ChatOverlayMessage(chatTimeOverlay, !this.radRadioButtonShowAsOverlay.IsChecked, author1, DateTime.Now));
        }

        private void RadButtonCalendarOverlay_Click(object sender, EventArgs e)
        {
            ChatCalendarOverlay chatCalendarOverlay = new ChatCalendarOverlay("Choose a date", DateTime.Now);

            this.radChat1.AddMessage(new ChatOverlayMessage(chatCalendarOverlay, !this.radRadioButtonShowAsOverlay.IsChecked, author1, DateTime.Now));
        }

        private void RadButtonDateTimeOverlay_Click(object sender, EventArgs e)
        {
            ChatDateTimeOverlay chatDateTimeOverlay = new ChatDateTimeOverlay("Choose time & date", DateTime.Now);
            
            this.radChat1.AddMessage(new ChatOverlayMessage(chatDateTimeOverlay, !this.radRadioButtonShowAsOverlay.IsChecked, author1, DateTime.Now));
        }
    }
}
