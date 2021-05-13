using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace RadChatExamples.CarInsurance
{
    public partial class Form1 : RadForm
    {
        private static string accessToken = ConfigurationManager.AppSettings["AccessToken"];

        private DialogFlowBotService botService;
        private Dictionary<string, Image> imageCache;

        public Form1()
        {
            InitializeComponent();

            radPanel1.Text = "";
            radPanel1.PanelElement.PanelFill.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            radPanel1.BackgroundImage = Properties.Resources.Insurance_bg;
            radPanel1.BackgroundImageLayout = ImageLayout.Stretch;
           
            tableLayoutPanel1.BackColor = Color.Transparent;
            radButton1.ButtonElement.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed; 

            this.imageCache = new Dictionary<string, Image>();

            this.Bot = new Author(Properties.Resources.avatar_car_insurance_28x28, "Botty McBot");
            this.Client = new Author(Properties.Resources.user, "Client", "TelerikSampleClient");

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
        public Author Bot { get; set; }

        public Author Client { get; set; }

        private void WireEvents()
        {
            this.radChat1.ChatElement.SendMessage += this.ChatElement_SendMessage;
            this.radChat1.ChatElement.SuggestedActionClicked += this.ChatElement_SuggestedActionClicked;
            this.radChat1.ChatElement.CardActionClicked += this.ChatElement_CardActionClicked;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.botService = new DialogFlowBotService(accessToken);

            this.radChat1.ChatElement.Author = this.Client;
            this.SendMessage("restart");
        }

        private void ChatElement_CardActionClicked(object sender, CardActionEventArgs e)
        {
            this.radChat1.ChatElement.AddMessage(new ChatTextMessage(e.Action.Text, this.Client, DateTime.Now));
            this.SendMessage(Convert.ToString(e.Action.Value));
        }

        private void ChatElement_SuggestedActionClicked(object sender, SuggestedActionEventArgs e)
        {
            this.radChat1.ChatElement.AddMessage(new ChatTextMessage(e.Action.Text, this.Client, DateTime.Now));

            this.SendMessage(e.Action.Text);
        }

        private void ChatElement_SendMessage(object sender, SendMessageEventArgs e)
        {
            this.SendMessage(((ChatTextMessage)e.Message).Message);
        }

        private async void SendMessage(string message)
        {
            try
            {
                this.radChat1.ChatElement.ShowTypingIndicator(null);
                Response response = await this.botService.SendMessageAsync(message);

                if (response.Result != null && response.Result.Fulfillment != null)
                {
                    DateTime timestamp = response.Timestamp.ToLocalTime();
                    this.RenderMessages(response, timestamp);

                    if (response.Result.Fulfillment.Data != null)
                    {
                        JToken data = ((JObject)response.Result.Fulfillment.Data).GetValue("null");

                        this.RenderAttachments(data, timestamp);

                        this.RenderSuggestedActions(data, timestamp);
                    }
                }
            }
            catch { }
        }

        private void RenderMessages(Response response, DateTime timestamp)
        {
            var fulfillment = response.Result.Fulfillment;
            List<object> messages = fulfillment.Messages;

            foreach (JObject message in messages)
            {
                if (message.Value<int>("type") == 0)
                {
                    string msg = message.Value<string>("speech");

                    if (!string.IsNullOrEmpty(msg))
                    {
                        if (msg == "When do you want your insurance to start?")
                        {
                            this.radChat1.ChatElement.AddMessage(new ChatTextMessage(msg, this.Bot, DateTime.Now));
                            ChatCalendarOverlay overlay = new ChatCalendarOverlay(msg);
                            overlay.Calendar.RangeMinDate = DateTime.Now;
                            this.radChat1.ChatElement.AddMessage(new ChatOverlayMessage(overlay, false, this.Bot, DateTime.Now));
                        }
                        else
                        {
                            this.radChat1.ChatElement.HideTypingIndicator();
                            this.radChat1.ChatElement.AddMessage(new ChatTextMessage(msg, this.Bot, timestamp));
                        }
                    }
                }
            }
        }

        private void RenderAttachments(JToken data, DateTime timestamp)
        {
            JToken attachments = data["attachments"];

            if (attachments == null || attachments.Count() == 0)
            {
                return;
            }

            if (attachments.Count() > 1)
            {
                string layout = Convert.ToString(data["attachmentLayout"]);

                if (layout == "carousel")
                {
                    List<ChatImageCardDataItem> cards = new List<ChatImageCardDataItem>();

                    foreach (JToken attachment in attachments)
                    {
                        List<ChatCardAction> actions = new List<ChatCardAction>();

                        foreach (var action in attachment["buttons"])
                        {
                            actions.Add(new ChatCardAction(Convert.ToString(action["title"]), null, action["value"]));
                        }

                        ChatImageCardDataItem card = new ChatImageCardDataItem(null, Convert.ToString(attachment["title"]), Convert.ToString(attachment["subtitle"]), null, actions, null);
                        cards.Add(card);

                        var images = attachment["images"];

                        if (images != null && images.Count() > 0)
                        {
                            this.DownloadImageAsync(card, Convert.ToString(images[0]["url"]));
                        }
                    }

                    ChatCarouselMessage message = new ChatCarouselMessage(cards, this.Bot, timestamp);
                    this.radChat1.ChatElement.AddMessage(message);
                }
            }
            else
            {
                JToken attachment = attachments[0];
                string type = Convert.ToString(attachment["type"]);
                StringBuilder sb = new StringBuilder();

                if (type == "quote")
                {
                    sb.AppendLine(string.Format("Type:{1}{0}Car model:{2} {3}{0}Car cost:{4}{0}Start date:{5}",
                        Environment.NewLine, attachment["coverage"], attachment["make"], attachment["model"], attachment["worth"], attachment["startDate"]));
                }
                else if (type == "payment_plan")
                {
                    foreach (var row in attachment["rows"])
                    {
                        sb.AppendLine(string.Format("{0} {1}", row["text"], row["value"]));
                    }
                }

                ChatImageCardDataItem card = new ChatImageCardDataItem(null, string.Format("Total:{0}", attachment["premium"]), null, sb.ToString(), null, null);

                this.radChat1.ChatElement.AddMessage(new ChatCardMessage(card, this.Bot, DateTime.Now));
            }
        }

        private void RenderSuggestedActions(JToken data, DateTime timestamp)
        {
            JToken suggestedActions = data["suggestedActions"];

            if (suggestedActions == null)
            {
                return;
            }

            List<SuggestedActionDataItem> actions = new List<SuggestedActionDataItem>();

            foreach (var action in suggestedActions)
            {
                actions.Add(new SuggestedActionDataItem(Convert.ToString(action["title"]), null, action["value"]));
            }

            this.radChat1.ChatElement.AddMessage(new ChatSuggestedActionsMessage(actions, this.Bot, timestamp));
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
