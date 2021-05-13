using AdaptiveCards;
using Microsoft.Bot.Connector.DirectLine;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using WebSocketSharp;

namespace RadChatExamples.FirstLook
{
    public partial class Form1 : RadForm
    {
        private static string directLineSecret = ConfigurationManager.AppSettings["TravelAgencyDirectLineSecret"];
        private static string botId = ConfigurationManager.AppSettings["TravelAgencyBotId"];

        private Dictionary<string, Image> imageCache;
        private WebSocket webSocketClient;
        private DirectLineClient directLineClient;
        private Conversation conversation;

        public Form1()
        {
            InitializeComponent();

            radPanel2.Text = "";
            radPanel2.PanelElement.PanelFill.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            radPanel2.BackgroundImage = Properties.Resources.Skytravel_bg;
            radPanel2.BackgroundImageLayout = ImageLayout.Stretch;
           
            radButton1.ButtonElement.TextElement.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            tableLayoutPanel1.BackColor = Color.Transparent;
            radButton1.ButtonElement.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

            this.imageCache = new Dictionary<string, Image>();
            
            this.BotAuthor = new Author(Properties.Resources.avatar_vacation_bot_28x28, "Travel Agent");
            this.ClientAuthor = new Author(Properties.Resources.user, "Client", "TelerikSampleClient");

            this.radChat1.ChatElement.Author = this.ClientAuthor;
            this.WireEvents();
        }
        protected override void OnThemeChanged()
        {
            base.OnThemeChanged();
            if (radPanel1 != null)
            {
                radPanel1.BackColor = this.BackColor;
            }
          
        }

        public Author BotAuthor { get; set; }

        public Author ClientAuthor { get; set; }

        private void WireEvents()
        {
            this.radChat1.ChatElement.CardActionClicked += this.ChatElement_CardActionClicked;
            this.radChat1.ChatElement.SendMessage += this.ChatElement_SendMessage;
            this.radChat1.ChatElement.SuggestedActionClicked += this.ChatElement_SuggestedActionClicked;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radChat1.ChatElement.ShowTypingIndicator(this.BotAuthor);
            this.StartBotConversation();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.webSocketClient.OnMessage -= WebSocketClient_OnMessage;

            this.radChat1.ChatElement.CardActionClicked -= this.ChatElement_CardActionClicked;
            this.radChat1.ChatElement.SendMessage -= this.ChatElement_SendMessage;
            this.radChat1.ChatElement.SuggestedActionClicked -= this.ChatElement_SuggestedActionClicked;

            Activity userMessage = new Activity
            {
                From = new ChannelAccount((string)this.ClientAuthor.Data, this.ClientAuthor.Name),
                Type = ActivityTypes.EndOfConversation
            };

            directLineClient.Conversations.PostActivityAsync(conversation.ConversationId, userMessage);
        }

        private void StartBotConversation()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            // Obtain a token using the Direct Line secret
            Conversation tokenResponse = new DirectLineClient(directLineSecret).Tokens.GenerateTokenForNewConversation();

            // Use token to create conversation
            this.directLineClient = new DirectLineClient(tokenResponse.Token);
            this.conversation = directLineClient.Conversations.StartConversation();

            this.webSocketClient = new WebSocket(conversation.StreamUrl);
            this.webSocketClient.SslConfiguration.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12;
            this.webSocketClient.OnMessage += WebSocketClient_OnMessage;
            this.webSocketClient.Connect();
        }

        private void ChatElement_SendMessage(object sender, SendMessageEventArgs e)
        {
            this.SendMessageToServer(((ChatTextMessage)e.Message).Message);
        }

        private void ChatElement_SuggestedActionClicked(object sender, SuggestedActionEventArgs e)
        {
            this.radChat1.ChatElement.AddMessage(new ChatTextMessage(e.Action.Text, this.ClientAuthor, DateTime.Now));

            this.SendMessageToServer(e.Action.Text);
        }

        private void ChatElement_CardActionClicked(object sender, CardActionEventArgs e)
        {            
            Telerik.WinControls.RadElement element = sender as Telerik.WinControls.RadElement;
            if (element != null )                
            {
                var parent = element.FindAncestor<CarouselMessageItemElement>();
                if (parent != null && parent.Parent != null)
                {
                    if (parent.Parent.Children.IndexOf(parent) != parent.Parent.Children.Count - 1)
                    {
                        return;
                    }
                }
            }

            this.radChat1.ChatElement.AddMessage(new ChatTextMessage(e.Action.Value.ToString(), this.ClientAuthor, DateTime.Now));

            this.SendMessageToServer(e.Action.Value.ToString());
        }

        private void SendMessageToServer(string message)
        {
            this.radChat1.ChatElement.ShowTypingIndicator(this.BotAuthor);

            Activity userMessage = new Activity
            {
                From = new ChannelAccount((string)this.ClientAuthor.Data, this.ClientAuthor.Name),
                Text = message,
                Type = ActivityTypes.Message
            };

            directLineClient.Conversations.PostActivityAsync(conversation.ConversationId, userMessage);
        }

        private void WebSocketClient_OnMessage(object sender, MessageEventArgs e)
        {
            // Occasionally, the Direct Line service sends an empty message as a liveness ping. Ignore these messages.
            if (string.IsNullOrWhiteSpace(e.Data))
            {
                return;
            }
            if (this.radChat1.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { this.AddMessage(e.Data); }));
            }
            else
            {
                this.AddMessage(e.Data);
            }
        }

        private void AddMessage(string data)
        {
            var activitySet = JsonConvert.DeserializeObject<ActivitySet>(data);
            var activities = from x in activitySet.Activities
                             where x.From.Id == botId
                             select x;

            foreach (Activity activity in activities)
            {
                if (activity.Type == ActivityTypes.Message)
                {
                    this.radChat1.ChatElement.HideTypingIndicator();
                    if (activity.AttachmentLayout == "carousel")
                    {
                        this.RenderCarousel(activity);

                        return;
                    }

                    if (activity.Attachments != null && activity.Attachments.Count > 0)
                    {
                        this.RenderAttachments(activity);
                    }

                    if (!string.IsNullOrEmpty(activity.Text))
                    {
                        if (activity.Text == "When do you want your vacation to start?")
                        {
                            this.radChat1.ChatElement.AddMessage(new ChatTextMessage(activity.Text, this.BotAuthor, DateTime.Now));
                            ChatCalendarOverlay overlay = new ChatCalendarOverlay(activity.Text);
                            overlay.Calendar.RangeMinDate = DateTime.Now.AddDays(1);
                            this.radChat1.ChatElement.AddMessage(new ChatOverlayMessage(overlay, false, this.BotAuthor, DateTime.Now));
                        }
                        else
                        {
                            this.radChat1.ChatElement.AddMessage(new ChatTextMessage(activity.Text, this.BotAuthor, DateTime.Now));

                            if (activity.SuggestedActions != null)
                            {
                                List<SuggestedActionDataItem> suggestedActions = new List<SuggestedActionDataItem>();

                                foreach (CardAction action in activity.SuggestedActions.Actions)
                                {
                                    suggestedActions.Add(new SuggestedActionDataItem(action.Title, null, action.Value));
                                }

                                this.radChat1.ChatElement.AddMessage(new ChatSuggestedActionsMessage(suggestedActions, this.BotAuthor, DateTime.Now));
                            }
                        }
                    }
                }
            }
        }

        private void RenderCarousel(Activity activity)
        {
            List<ChatImageCardDataItem> cards = new List<ChatImageCardDataItem>();

            foreach (Attachment attachment in activity.Attachments)
            {
                if (attachment.ContentType != "application/vnd.microsoft.card.hero")
                {
                    continue;
                }

                HeroCard heroCard = JsonConvert.DeserializeObject<HeroCard>(attachment.Content.ToString());

                List<ChatCardAction> actions = new List<ChatCardAction>();

                foreach (var action in heroCard.Buttons)
                {
                    ChatCardAction cardAction = new ChatCardAction(action.Title, null, action.Value);
                    actions.Add(cardAction);

                    if (!string.IsNullOrEmpty(action.Image))
                    {
                        this.DownloadImageAsync(cardAction, action.Image);
                    }
                }

                ChatImageCardDataItem card = new ChatImageCardDataItem(null, heroCard.Title, heroCard.Subtitle, heroCard.Text, actions, null);
                cards.Add(card);

                if (heroCard.Images != null && heroCard.Images.Count > 0)
                {
                    this.DownloadImageAsync(card, heroCard.Images[0].Url);
                }
            }

            ChatCarouselMessage message = new ChatCarouselMessage(cards, this.BotAuthor, DateTime.Now);
            this.radChat1.ChatElement.AddMessage(message);
        }

        private void RenderAttachments(Activity activity)
        {
            foreach (Attachment attachment in activity.Attachments)
            {
                if (attachment.ContentType == "application/vnd.microsoft.card.hero")
                {
                    this.RenderHeroCard(attachment);
                }
                else if (attachment.ContentType == "application/vnd.microsoft.card.adaptive")
                {
                    this.RenderAdaptiveCard(attachment);
                }
            }
        }

        private void RenderHeroCard(Attachment attachment)
        {
            HeroCard heroCard = JsonConvert.DeserializeObject<HeroCard>(attachment.Content.ToString());

            ChatListOverlay overlay = new ChatListOverlay(heroCard.Text);
            overlay.ListView.ItemSize = new Size(0, 80);
            overlay.ListView.VisualItemFormatting += delegate (object sender, ListViewVisualItemEventArgs e)
            {
                e.VisualItem.ImageLayout = ImageLayout.Zoom;

                CardAction cardAction = e.VisualItem.Data.DataBoundItem as CardAction;

                if (cardAction != null && !string.IsNullOrEmpty(cardAction.Image))
                {
                    this.DownloadImageAsync(e.VisualItem, cardAction.Image);
                }
            };

            overlay.ListView.ValueMember = "Value";
            overlay.ListView.DisplayMember = "Title";
            overlay.ListView.DataSource = heroCard.Buttons;

            this.radChat1.ChatElement.AddMessage(new ChatTextMessage(heroCard.Text, this.BotAuthor, DateTime.Now));
            this.radChat1.ChatElement.AddMessage(new ChatOverlayMessage(overlay, true, this.BotAuthor, DateTime.Now));
        }

        private void RenderAdaptiveCard(Attachment attachment)
        {
            AdaptiveCard adaptiveCard = AdaptiveCard.FromJson(attachment.Content.ToString()).Card;

            if (adaptiveCard.AdditionalProperties["TType"].ToString() == "Flight")
            {
                string passengerName = ((AdaptiveTextBlock)adaptiveCard.Body[1]).Text;
                string outDepartureCity = ((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[3]).Columns[0].Items[0]).Text;
                string outDepartureAirport = ((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[3]).Columns[0].Items[1]).Text;
                DateTime outDepartureDateTime = DateTime.ParseExact(((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[3]).Columns[0].Items[2]).Text
                    + " " + ((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[3]).Columns[0].Items[3]).Text, "d MMM yyyy hh:mm tt", CultureInfo.InvariantCulture);
                string outArrivalCity = ((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[3]).Columns[2].Items[0]).Text;
                string outArrivalAirport = ((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[3]).Columns[2].Items[1]).Text;
                DateTime outArrivalDateTime = DateTime.ParseExact(((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[3]).Columns[2].Items[2]).Text
                    + " " + ((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[3]).Columns[2].Items[3]).Text, "d MMM yyyy hh:mm tt", CultureInfo.InvariantCulture);
                string inDepartureCity = ((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[4]).Columns[0].Items[0]).Text;
                string inDepartureAirport = ((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[4]).Columns[0].Items[1]).Text;
                DateTime inDepartureDateTime = DateTime.ParseExact(((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[4]).Columns[0].Items[2]).Text
                    + " " + ((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[4]).Columns[0].Items[3]).Text, "d MMM yyyy hh:mm tt", CultureInfo.InvariantCulture);
                string inArrivalCity = ((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[4]).Columns[2].Items[0]).Text;
                string inArrivalAirport = ((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[4]).Columns[2].Items[1]).Text;
                DateTime inArrivalDateTime = DateTime.ParseExact(((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[4]).Columns[2].Items[2]).Text
                    + " " + ((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[4]).Columns[2].Items[3]).Text, "d MMM yyyy hh:mm tt", CultureInfo.InvariantCulture);
                string total = ((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[5]).Columns[1].Items[0]).Text;

                List<FlightInfo> flights = new List<FlightInfo>()
                {
                    new FlightInfo(outDepartureCity, outDepartureAirport, outDepartureDateTime, outArrivalCity, outArrivalAirport, outArrivalDateTime),
                    new FlightInfo(inDepartureCity, inDepartureAirport, inDepartureDateTime, inArrivalCity, inArrivalAirport, inArrivalDateTime)
                };

                ChatFlightCardDataItem card = new ChatFlightCardDataItem(passengerName, flights, null, total, null);
                this.radChat1.ChatElement.AddMessage(new ChatCardMessage(card, this.BotAuthor, DateTime.Now));

                this.DownloadImageAsync(card, ((AdaptiveImage)((AdaptiveColumnSet)adaptiveCard.Body[3]).Columns[1].Items[0]).Url.ToString());
            }
            else if (adaptiveCard.AdditionalProperties["TType"].ToString() == "Summary")
            {
                
                string title = ((AdaptiveTextBlock)adaptiveCard.Body[1]).Text;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(((AdaptiveTextBlock)adaptiveCard.Body[2]).Text);
                sb.AppendLine(((AdaptiveTextBlock)adaptiveCard.Body[3]).Text);

                if (adaptiveCard.Body.Count() > 5)
                {
                    sb.AppendLine(((AdaptiveTextBlock)adaptiveCard.Body[4]).Text);
                    sb.AppendLine(((AdaptiveTextBlock)adaptiveCard.Body[5]).Text);
                    sb.AppendLine(((AdaptiveTextBlock)adaptiveCard.Body[6]).Text);
                    sb.AppendLine(((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[7]).Columns[0].Items[0]).Text + ((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[7]).Columns[1].Items[0]).Text);
                }
                else
                {
                    sb.AppendLine(((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[4]).Columns[0].Items[0]).Text + ((AdaptiveTextBlock)((AdaptiveColumnSet)adaptiveCard.Body[4]).Columns[1].Items[0]).Text);
                }

                ChatImageCardDataItem card = new ChatImageCardDataItem(null, title, null, sb.ToString(), null, null);
                this.radChat1.ChatElement.AddMessage(new ChatCardMessage(card, this.BotAuthor, DateTime.Now));

                this.DownloadImageAsync(card, ((AdaptiveImage)adaptiveCard.Body[0]).Url.ToString());
            }
        }

        private void DownloadImageAsync(object obj, string imageUrl)
        {
            if (this.imageCache.ContainsKey(imageUrl))
            {
                obj.GetType().GetProperty("Image", BindingFlags.Instance | BindingFlags.Public).SetValue(obj, this.imageCache[imageUrl]);

                return;
            }

            WebClient client = new WebClient();
            client.DownloadDataCompleted += this.Client_DownloadDataCompleted;
            client.DownloadDataAsync(new Uri(imageUrl), new object[] { obj, imageUrl });
        }

        private void Client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            Image image = null;
            string url = Convert.ToString(((object[])e.UserState)[1]);

            if (e.Error == null && !e.Cancelled)
            {
                using (MemoryStream ms = new MemoryStream(e.Result))
                {
                    image = Image.FromStream(ms);
                }
            }
            else
            {
                try
                {
                    Stream str = Assembly.GetExecutingAssembly().GetManifestResourceStream("RadChatExamples.Resources." + url.Substring(url.LastIndexOf("/") + 1));

                    if (str != null)
                    {
                        image = Image.FromStream(str);
                    }
                }
                catch (Exception)
                { }
            }

            ((object[])e.UserState)[0].GetType().GetProperty("Image", BindingFlags.Instance | BindingFlags.Public).SetValue(((object[])e.UserState)[0], image);
            this.imageCache[url] = image;
        }
        private void radButton1_Click_1(object sender, EventArgs e)
        {
            this.radChat1.ChatElement.InputTextBox.Focus();
        }
    }
}