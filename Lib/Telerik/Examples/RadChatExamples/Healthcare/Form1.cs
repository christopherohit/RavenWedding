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
using System.Windows.Forms;
using Telerik.WinControls.UI;
using WebSocketSharp;

namespace RadChatExamples.Healthcare
{
    public partial class Form1 : RadForm
    {
        private static string directLineSecret = ConfigurationManager.AppSettings["HealthCareDirectLineSecret"];
        private static string botId = ConfigurationManager.AppSettings["HealthCareBotId"];

        private Dictionary<string, Image> imageCache;
        private WebSocket webSocketClient;
        private DirectLineClient directLineClient;
        private Conversation conversation;

        public Form1()
        {
            InitializeComponent();

            radPanel1.Text = "";
            radPanel1.PanelElement.PanelFill.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            radPanel1.BackgroundImage = Properties.Resources.Health_Care_bg;
            radPanel1.BackgroundImageLayout = ImageLayout.Stretch;
           
            tableLayoutPanel1.BackColor = Color.Transparent;
            radButton1.ButtonElement.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

            this.imageCache = new Dictionary<string, Image>();
            
            this.BotAuthor = new Author(Properties.Resources.avatar_health_care_bot_28x28, "HealthCare Assistant");
            this.ClientAuthor = new Author(Properties.Resources.user, "Client", "TelerikSampleClient");

            this.radChat1.ChatElement.Author = this.ClientAuthor;
            this.WireEvents();
        }
        protected override void OnThemeChanged()
        {
            base.OnThemeChanged();
            if (radPanel2 != null)
            {
                radPanel2.BackColor = this.BackColor;
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
            this.radChat1.ChatElement.ShowTypingIndicator(null);
            this.StartBotConversation();
        }
        
        protected override void OnClosing(CancelEventArgs e)
        {
            if (this.directLineClient != null)
            {
                Activity userMessage = new Activity
                {
                    From = new ChannelAccount((string)this.ClientAuthor.Data, this.ClientAuthor.Name),
                    Type = ActivityTypes.EndOfConversation
                };

                this.directLineClient.Conversations.PostActivityAsync(conversation.ConversationId, userMessage);
            }

            if (this.webSocketClient != null)
            {
                this.webSocketClient.OnMessage -= WebSocketClient_OnMessage;
            }

            base.OnClosing(e);

            this.radChat1.ChatElement.CardActionClicked -= this.ChatElement_CardActionClicked;
            this.radChat1.ChatElement.SendMessage -= this.ChatElement_SendMessage;
            this.radChat1.ChatElement.SuggestedActionClicked -= this.ChatElement_SuggestedActionClicked;
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
            this.radChat1.ChatElement.AddMessage(new ChatTextMessage(e.Action.Value.ToString(), this.ClientAuthor, DateTime.Now));

            this.SendMessageToServer(e.Action.Value.ToString());
        }

        private void SendMessageToServer(string message)
        {
            this.radChat1.ChatElement.ShowTypingIndicator(null);
            Activity userMessage = new Activity
            {
                From = new ChannelAccount((string)this.ClientAuthor.Data, this.ClientAuthor.Name),
                Text = message,
                Type = ActivityTypes.Message
            };

            directLineClient.Conversations.PostActivity(conversation.ConversationId, userMessage);
        }

        private void WebSocketClient_OnMessage(object sender, MessageEventArgs e)
        {
            // Occasionally, the Direct Line service sends an empty message as a liveness ping. Ignore these messages.
            if (string.IsNullOrWhiteSpace(e.Data))
            {
                return;
            }

            try
            {
                if (this.radChat1.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { this.AddMessage(e.Data); }));
                }
                else
                {
                    this.AddMessage(e.Data);
                }
            }
            catch { }
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
                    if (activity.AttachmentLayout == "carousel")
                    {
                        this.RenderCarousel(activity);
                        this.radChat1.ChatElement.HideTypingIndicator();

                        return;
                    }

                    if (activity.Attachments != null && activity.Attachments.Count > 0)
                    {
                        this.RenderAttachments(activity);
                    }

                    if (!string.IsNullOrEmpty(activity.Text) || (activity.SuggestedActions != null && activity.SuggestedActions.Actions.Count() > 0))
                    {
                        if (activity.Text.StartsWith("Please, choose a date for visiting"))
                        {
                            this.radChat1.ChatElement.AddMessage(new ChatTextMessage(activity.Text, this.BotAuthor, DateTime.Now));
                            ChatCalendarOverlay overlay = new ChatCalendarOverlay(activity.Text);
                            overlay.Calendar.RangeMinDate = DateTime.Now;
                            this.radChat1.ChatElement.AddMessage(new ChatOverlayMessage(overlay, false, this.BotAuthor, DateTime.Now));
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(activity.Text))
                            {
                                this.radChat1.ChatElement.AddMessage(new ChatTextMessage(activity.Text, this.BotAuthor, DateTime.Now)); 
                            }

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

            this.radChat1.ChatElement.HideTypingIndicator();
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

                if (e.VisualItem is IconListViewVisualItem)
                {
                    e.VisualItem.DrawText = false;
                }
            };

            if (heroCard.Text.Contains("Company"))
            {
                overlay.ListView.ViewType = ListViewType.IconsView;
                overlay.ListView.ItemSize = new Size(168, 100);                
            }
            else
            {
                overlay.ListView.ItemSize = new Size(0, 40);
            }
            
            overlay.ListView.DisplayMember = "Title";
            overlay.ListView.ValueMember = "Value";
            overlay.ListView.DataSource = heroCard.Buttons;

            this.radChat1.ChatElement.AddMessage(new ChatTextMessage(heroCard.Text, this.BotAuthor, DateTime.Now));
            this.radChat1.ChatElement.AddMessage(new ChatOverlayMessage(overlay, true, this.BotAuthor, DateTime.Now));
        }

        private void RenderAdaptiveCard(Attachment attachment)
        {
            AdaptiveCard adaptiveCard = AdaptiveCard.FromJson(attachment.Content.ToString()).Card;

            if (!adaptiveCard.AdditionalProperties.ContainsKey("TType"))
            {
                return;
            }

            string type = adaptiveCard.AdditionalProperties["TType"].ToString();

            if (type == "Summary")
            {                
                string title = ((AdaptiveTextBlock)adaptiveCard.Body[1]).Text;
                string subtitle = ((AdaptiveTextBlock)adaptiveCard.Body[2]).Text;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(((AdaptiveTextBlock)adaptiveCard.Body[4]).Text);
                sb.AppendLine(((AdaptiveTextBlock)adaptiveCard.Body[3]).Text);
                sb.AppendLine();
                sb.AppendLine(((AdaptiveTextBlock)adaptiveCard.Body[5]).Text);
                sb.AppendLine();
                sb.AppendLine(((AdaptiveTextBlock)adaptiveCard.Body[8]).Text);
                sb.AppendLine(string.Format("{0} {1}", ((AdaptiveTextBlock)adaptiveCard.Body[6]).Text, ((AdaptiveTextBlock)adaptiveCard.Body[7]).Text));

                ChatImageCardDataItem card = new ChatImageCardDataItem(null, title, subtitle, sb.ToString(), null, null);
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