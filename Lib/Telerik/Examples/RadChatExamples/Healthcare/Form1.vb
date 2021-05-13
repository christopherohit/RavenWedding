Imports AdaptiveCards
Imports Microsoft.Bot.Connector.DirectLine
Imports Newtonsoft.Json
Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports WebSocketSharp

Namespace RadChatExamples.Healthcare

    Partial Public Class Form1
        Inherits RadForm

        Private Shared directLineSecret As String = ConfigurationSettings.AppSettings("HealthCareDirectLineSecret")

        Private Shared botId As String = ConfigurationSettings.AppSettings("HealthCareBotId")

        Private imageCache As Dictionary(Of String, Image)

        Private webSocketClient As WebSocket

        Private directLineClient As DirectLineClient

        Private conversation As Conversation

        Public Sub New()
            InitializeComponent()
            Me.BackgroundImage = My.Resources.Health_Care_bg
            Me.BackgroundImageLayout = ImageLayout.Center
            Me.imageCache = New Dictionary(Of String, Image)()
            Me.BotAuthor = New Author(My.Resources.avatar_health_care_bot_28x28, "HealthCare Assistant")
            Me.ClientAuthor = New Author(My.Resources.user, "Client", "TelerikSampleClient")
            Me.radChat1.ChatElement.Author = Me.ClientAuthor
            Me.WireEvents()
        End Sub

        Public Property BotAuthor As Author

        Public Property ClientAuthor As Author

        Private Sub WireEvents()
            AddHandler Me.radChat1.ChatElement.CardActionClicked, AddressOf Me.ChatElement_CardActionClicked
            AddHandler Me.radChat1.ChatElement.SendMessage, AddressOf Me.ChatElement_SendMessage
            AddHandler Me.radChat1.ChatElement.SuggestedActionClicked, AddressOf Me.ChatElement_SuggestedActionClicked
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Me.radChat1.ChatElement.ShowTypingIndicator(Nothing)
            Me.StartBotConversation()
        End Sub

        Private Sub StartBotConversation()
            Dim tokenResponse As Conversation = New DirectLineClient(directLineSecret).Tokens.GenerateTokenForNewConversation()
            Me.directLineClient = New DirectLineClient(tokenResponse.Token)
            Me.conversation = directLineClient.Conversations.StartConversation()
            Me.webSocketClient = New WebSocket(conversation.StreamUrl)
            AddHandler Me.webSocketClient.OnMessage, AddressOf WebSocketClient_OnMessage
            Me.webSocketClient.Connect()
        End Sub

        Private Sub ChatElement_SendMessage(ByVal sender As Object, ByVal e As SendMessageEventArgs)
            Me.SendMessageToServer((CType(e.Message, ChatTextMessage)).Message)
        End Sub

        Private Sub ChatElement_SuggestedActionClicked(ByVal sender As Object, ByVal e As SuggestedActionEventArgs)
            Me.radChat1.ChatElement.AddMessage(New ChatTextMessage(e.Action.Text, Me.ClientAuthor, DateTime.Now))
            Me.SendMessageToServer(e.Action.Text)
        End Sub

        Private Sub ChatElement_CardActionClicked(ByVal sender As Object, ByVal e As CardActionEventArgs)
            Me.radChat1.ChatElement.AddMessage(New ChatTextMessage(e.Action.Value.ToString(), Me.ClientAuthor, DateTime.Now))
            Me.SendMessageToServer(e.Action.Value.ToString())
        End Sub

        Private Sub SendMessageToServer(ByVal message As String)
            Me.radChat1.ChatElement.ShowTypingIndicator(Nothing)
            Dim userMessage As Activity = New Activity With {.From = New ChannelAccount(CStr(Me.ClientAuthor.Data), Me.ClientAuthor.Name), .Text = message, .Type = ActivityTypes.Message}
            directLineClient.Conversations.PostActivity(conversation.ConversationId, userMessage)
        End Sub

        Private Sub WebSocketClient_OnMessage(ByVal sender As Object, ByVal e As MessageEventArgs)
            If String.IsNullOrWhiteSpace(e.Data) Then
                Return
            End If

            If Me.radChat1.InvokeRequired Then
                Me.Invoke(DirectCast(Sub()
                                         Me.AddMessage(e.Data)
                                     End Sub, MethodInvoker))
            Else
                Me.AddMessage(e.Data)
            End If
        End Sub

        Private Sub AddMessage(ByVal data As String)
            Dim activitySet = JsonConvert.DeserializeObject(Of ActivitySet)(data)
            Dim activities = From x In activitySet.Activities Where x.From.Id = botId Select x
            For Each activity As Activity In activities
                If activity.Type = ActivityTypes.Message Then
                    If activity.AttachmentLayout = "carousel" Then
                        Me.RenderCarousel(activity)
                        Me.radChat1.ChatElement.HideTypingIndicator()
                        Return
                    End If

                    If activity.Attachments IsNot Nothing AndAlso activity.Attachments.Count > 0 Then
                        Me.RenderAttachments(activity)
                    End If

                    If Not String.IsNullOrEmpty(activity.Text) OrElse (activity.SuggestedActions IsNot Nothing AndAlso activity.SuggestedActions.Actions.Count() > 0) Then
                        If activity.Text.StartsWith("Please choose a date for visiting") Then
                            Me.radChat1.ChatElement.AddMessage(New ChatTextMessage(activity.Text, Me.BotAuthor, DateTime.Now))
                            Dim overlay As ChatCalendarOverlay = New ChatCalendarOverlay(activity.Text)
                            Me.radChat1.ChatElement.AddMessage(New ChatOverlayMessage(overlay, False, Me.BotAuthor, DateTime.Now))
                        Else
                            If Not String.IsNullOrEmpty(activity.Text) Then
                                Me.radChat1.ChatElement.AddMessage(New ChatTextMessage(activity.Text, Me.BotAuthor, DateTime.Now))
                            End If

                            If activity.SuggestedActions IsNot Nothing Then
                                Dim suggestedActions As List(Of SuggestedActionDataItem) = New List(Of SuggestedActionDataItem)()
                                For Each action As CardAction In activity.SuggestedActions.Actions
                                    suggestedActions.Add(New SuggestedActionDataItem(action.Title, Nothing, action.Value))
                                Next

                                Me.radChat1.ChatElement.AddMessage(New ChatSuggestedActionsMessage(suggestedActions, Me.BotAuthor, DateTime.Now))
                            End If
                        End If
                    End If
                End If
            Next

            Me.radChat1.ChatElement.HideTypingIndicator()
        End Sub

        Private Sub RenderCarousel(ByVal activity As Activity)
            Dim cards As List(Of ChatImageCardDataItem) = New List(Of ChatImageCardDataItem)()
            For Each attachment As Attachment In activity.Attachments
                If attachment.ContentType <> "application/vnd.microsoft.card.hero" Then
                    Continue For
                End If

                Dim heroCard As HeroCard = JsonConvert.DeserializeObject(Of HeroCard)(attachment.Content.ToString())
                Dim actions As List(Of ChatCardAction) = New List(Of ChatCardAction)()
                For Each action In heroCard.Buttons
                    Dim cardAction As ChatCardAction = New ChatCardAction(action.Title, Nothing, action.Value)
                    actions.Add(cardAction)
                    If Not String.IsNullOrEmpty(action.Image) Then
                        Me.DownloadImageAsync(cardAction, action.Image)
                    End If
                Next

                Dim card As ChatImageCardDataItem = New ChatImageCardDataItem(Nothing, heroCard.Title, heroCard.Subtitle, heroCard.Text, actions, Nothing)
                cards.Add(card)
                If heroCard.Images IsNot Nothing AndAlso heroCard.Images.Count > 0 Then
                    Me.DownloadImageAsync(card, heroCard.Images(0).Url)
                End If
            Next

            Dim message As ChatCarouselMessage = New ChatCarouselMessage(cards, Me.BotAuthor, DateTime.Now)
            Me.radChat1.ChatElement.AddMessage(message)
        End Sub

        Private Sub RenderAttachments(ByVal activity As Activity)
            For Each attachment As Attachment In activity.Attachments
                If attachment.ContentType = "application/vnd.microsoft.card.hero" Then
                    Me.RenderHeroCard(attachment)
                ElseIf attachment.ContentType = "application/vnd.microsoft.card.adaptive" Then
                    Me.RenderAdaptiveCard(attachment)
                End If
            Next
        End Sub

        Private Sub RenderHeroCard(ByVal attachment As Attachment)
            Dim heroCard As HeroCard = JsonConvert.DeserializeObject(Of HeroCard)(attachment.Content.ToString())
            Dim overlay As ChatListOverlay = New ChatListOverlay(heroCard.Text)
            overlay.ListView.ItemSize = New Size(0, 80)
            AddHandler overlay.ListView.VisualItemFormatting, AddressOf ListViewItemFormatting
            If heroCard.Text.Contains("Company") Then
                overlay.ListView.ViewType = ListViewType.IconsView
                overlay.ListView.ItemSize = New Size(168, 100)
            Else
                overlay.ListView.ItemSize = New Size(0, 40)
            End If

            overlay.ListView.DisplayMember = "Title"
            overlay.ListView.ValueMember = "Value"
            overlay.ListView.DataSource = heroCard.Buttons
            Me.radChat1.ChatElement.AddMessage(New ChatTextMessage(heroCard.Text, Me.BotAuthor, DateTime.Now))
            Me.radChat1.ChatElement.AddMessage(New ChatOverlayMessage(overlay, True, Me.BotAuthor, DateTime.Now))
        End Sub

        Private Sub ListViewItemFormatting(sender As Object, e As ListViewVisualItemEventArgs)
            e.VisualItem.ImageLayout = ImageLayout.Zoom
            Dim cardAction As CardAction = TryCast(e.VisualItem.Data.DataBoundItem, CardAction)
            If cardAction IsNot Nothing AndAlso Not String.IsNullOrEmpty(cardAction.Image) Then
                Me.DownloadImageAsync(e.VisualItem, cardAction.Image)
            End If

            If TypeOf e.VisualItem Is IconListViewVisualItem Then
                e.VisualItem.DrawText = False
            End If
        End Sub

        Private Sub RenderAdaptiveCard(ByVal attachment As Attachment)
            Dim adaptiveCard As AdaptiveCard = adaptiveCard.FromJson(attachment.Content.ToString()).Card
            If Not adaptiveCard.AdditionalProperties.ContainsKey("TType") Then
                Return
            End If

            Dim type As String = adaptiveCard.AdditionalProperties("TType").ToString()
            If type = "Summary" Then
                Dim title As String = (CType(adaptiveCard.Body(1), AdaptiveTextBlock)).Text
                Dim subtitle As String = (CType(adaptiveCard.Body(2), AdaptiveTextBlock)).Text
                Dim sb As StringBuilder = New StringBuilder()
                sb.AppendLine((CType(adaptiveCard.Body(4), AdaptiveTextBlock)).Text)
                sb.AppendLine((CType(adaptiveCard.Body(3), AdaptiveTextBlock)).Text)
                sb.AppendLine()
                sb.AppendLine((CType(adaptiveCard.Body(5), AdaptiveTextBlock)).Text)
                sb.AppendLine()
                sb.AppendLine((CType(adaptiveCard.Body(8), AdaptiveTextBlock)).Text)
                sb.AppendLine(String.Format("{0} {1}", (CType(adaptiveCard.Body(6), AdaptiveTextBlock)).Text, (CType(adaptiveCard.Body(7), AdaptiveTextBlock)).Text))
                Dim card As ChatImageCardDataItem = New ChatImageCardDataItem(Nothing, title, subtitle, sb.ToString(), Nothing, Nothing)
                Me.radChat1.ChatElement.AddMessage(New ChatCardMessage(card, Me.BotAuthor, DateTime.Now))
                Me.DownloadImageAsync(card, (CType(adaptiveCard.Body(0), AdaptiveImage)).Url.ToString())
            End If
        End Sub

        Private Sub DownloadImageAsync(ByVal obj As Object, ByVal imageUrl As String)
            If Me.imageCache.ContainsKey(imageUrl) Then
                obj.[GetType]().GetProperty("Image", BindingFlags.Instance Or BindingFlags.[Public]).SetValue(obj, Me.imageCache(imageUrl))
                Return
            End If

            Dim client As WebClient = New WebClient()
            AddHandler client.DownloadDataCompleted, AddressOf Me.Client_DownloadDataCompleted
            client.DownloadDataAsync(New Uri(imageUrl), New Object() {obj, imageUrl})
        End Sub

        Private Sub Client_DownloadDataCompleted(ByVal sender As Object, ByVal e As DownloadDataCompletedEventArgs)
            Dim image As Image = Nothing
            Dim url As String = Convert.ToString((CType(e.UserState, Object()))(1))
            If e.[Error] Is Nothing AndAlso Not e.Cancelled Then
                Using ms As MemoryStream = New MemoryStream(e.Result)
                    image = image.FromStream(ms)
                End Using
            Else
                Try
                    Dim str As Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("RadChatExamples.Resources." & url.Substring(url.LastIndexOf("/") + 1))
                    If str IsNot Nothing Then
                        image = image.FromStream(str)
                    End If
                Catch __unusedException1__ As Exception
                End Try
            End If

            CType(e.UserState, Object())(0).[GetType]().GetProperty("Image", BindingFlags.Instance Or BindingFlags.[Public]).SetValue((CType(e.UserState, Object()))(0), image)
            Me.imageCache(url) = image
        End Sub

        Private Sub RadButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radChat1.ChatElement.InputTextBox.Focus()
        End Sub
    End Class
End Namespace
