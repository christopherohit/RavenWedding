Imports ApiAiSDK
Imports ApiAiSDK.Model
Imports Newtonsoft.Json.Linq
Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Reflection
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace RadChatExamples.CarInsurance

    Partial Public Class Form1
        Inherits RadForm

        Private Shared accessToken As String = ConfigurationSettings.AppSettings("AccessToken")

        Private apiAi As ApiAi

        Private imageCache As Dictionary(Of String, Image)

        Public Sub New()

            InitializeComponent()
            Me.BackgroundImage = My.Resources.Insurance_bg
            Me.BackgroundImageLayout = ImageLayout.Center
            Me.imageCache = New Dictionary(Of String, Image)()
            Me.Bot = New Author(My.Resources.avatar_car_insurance_28x28, "Botty McBot")
            Me.Client = New Author(My.Resources.user, "Client", "TelerikSampleClient")
            Me.WireEvents()
        End Sub

        Public Property Bot As Author

        Public Property Client As Author

        Private Sub WireEvents()
            AddHandler Me.radChat1.ChatElement.SendMessage, AddressOf Me.ChatElement_SendMessage
            AddHandler Me.radChat1.ChatElement.SuggestedActionClicked, AddressOf Me.ChatElement_SuggestedActionClicked
            AddHandler Me.radChat1.ChatElement.CardActionClicked, AddressOf Me.ChatElement_CardActionClicked
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Dim config = New AIConfiguration(accessToken, SupportedLanguage.English)
            apiAi = New ApiAi(config)
            Me.radChat1.ChatElement.Author = Me.Client
            Me.radChat1.ChatElement.ShowTypingIndicator(Nothing)
            Me.radChat1.ChatElement.AddMessage(New ChatTextMessage("Hi there! I’m am Botty McBotFace, your virtual car insurance assistant at Motor Insurance Company.", Me.Bot, DateTime.Now))
            Me.radChat1.ChatElement.AddMessage(New ChatTextMessage("You can ask me any questions about our car insurance policies and I’ll do my best to help you.", Me.Bot, DateTime.Now))
            Me.radChat1.ChatElement.AddMessage(New ChatTextMessage("If you get lost, type 'restart' to start from the beginning.", Me.Bot, DateTime.Now))
            Me.radChat1.ChatElement.AddMessage(New ChatTextMessage("How can I help you?", Me.Bot, DateTime.Now))
            Me.radChat1.ChatElement.AddMessage(New ChatSuggestedActionsMessage(New List(Of SuggestedActionDataItem)() From {New SuggestedActionDataItem("Get a Quote", Nothing), New SuggestedActionDataItem("Get a Renewal", Nothing)}, Me.Bot, DateTime.Now))
            Me.radChat1.ChatElement.HideTypingIndicator()
        End Sub

        Private Sub ChatElement_CardActionClicked(ByVal sender As Object, ByVal e As CardActionEventArgs)
            Me.radChat1.ChatElement.AddMessage(New ChatTextMessage(e.Action.Text, Me.Client, DateTime.Now))
            Me.SendMessage(Convert.ToString(e.Action.Value))
        End Sub

        Private Sub ChatElement_SuggestedActionClicked(ByVal sender As Object, ByVal e As SuggestedActionEventArgs)
            Me.radChat1.ChatElement.AddMessage(New ChatTextMessage(e.Action.Text, Me.Client, DateTime.Now))
            Me.SendMessage(e.Action.Text)
        End Sub

        Private Sub ChatElement_SendMessage(ByVal sender As Object, ByVal e As SendMessageEventArgs)
            Me.SendMessage((CType(e.Message, ChatTextMessage)).Message)
        End Sub

        Private Sub SendMessage(ByVal message As String)
            Me.radChat1.ChatElement.ShowTypingIndicator(Nothing)
            Dim response = apiAi.TextRequest(message)
            If response.Result IsNot Nothing AndAlso response.Result.Fulfillment IsNot Nothing Then
                Dim timestamp As DateTime = response.Timestamp.ToLocalTime()
                Me.RenderMessages(response, timestamp)
                If response.Result.Fulfillment.Data IsNot Nothing Then
                    Dim data As JToken = (CType(response.Result.Fulfillment.Data, JObject)).GetValue("null")
                    Me.RenderAttachments(data, timestamp)
                    Me.RenderSuggestedActions(data, timestamp)
                End If
            End If
        End Sub

        Private Sub RenderMessages(ByVal response As AIResponse, ByVal timestamp As DateTime)
            Dim fulfillment = response.Result.Fulfillment
            Dim messages As List(Of Object) = fulfillment.Messages
            For Each message As JObject In messages
                If message.Value(Of Integer)("type") = 0 Then
                    Dim msg As String = message.Value(Of String)("speech")
                    If Not String.IsNullOrEmpty(msg) Then
                        Me.radChat1.ChatElement.HideTypingIndicator()
                        Me.radChat1.ChatElement.AddMessage(New ChatTextMessage(msg, Me.Bot, timestamp))
                    End If
                End If
            Next
        End Sub

        Private Sub RenderAttachments(ByVal data As JToken, ByVal timestamp As DateTime)
            Dim attachments As JToken = data("attachments")
            If attachments Is Nothing OrElse attachments.Count() = 0 Then
                Return
            End If

            If attachments.Count() > 1 Then
                Dim layout As String = Convert.ToString(data("attachmentLayout"))
                If layout = "carousel" Then
                    Dim cards As List(Of ChatImageCardDataItem) = New List(Of ChatImageCardDataItem)()
                    For Each attachment As JToken In attachments
                        Dim actions As List(Of ChatCardAction) = New List(Of ChatCardAction)()
                        For Each action In attachment("buttons")
                            actions.Add(New ChatCardAction(Convert.ToString(action("title")), Nothing, action("value")))
                        Next

                        Dim card As ChatImageCardDataItem = New ChatImageCardDataItem(Nothing, Convert.ToString(attachment("title")), Convert.ToString(attachment("subtitle")), Nothing, actions, Nothing)
                        cards.Add(card)
                        Dim images = attachment("images")
                        If images IsNot Nothing AndAlso images.Count() > 0 Then
                            Me.DownloadImageAsync(card, Convert.ToString(images(0)("url")))
                        End If
                    Next

                    Dim message As ChatCarouselMessage = New ChatCarouselMessage(cards, Me.Bot, timestamp)
                    Me.radChat1.ChatElement.AddMessage(message)
                End If
            Else
                Dim attachment As JToken = attachments(0)
                Dim type As String = Convert.ToString(attachment("type"))
                Dim sb As StringBuilder = New StringBuilder()
                If type = "quote" Then
                    sb.AppendLine(String.Format("Type:{1}{0}Car model:{2} {3}{0}Car cost:{4}{0}Start date:{5}", Environment.NewLine, attachment("coverage"), attachment("make"), attachment("model"), attachment("worth"), attachment("startDate")))
                ElseIf type = "payment_plan" Then
                    For Each row In attachment("rows")
                        sb.AppendLine(String.Format("{0} {1}", row("text"), row("value")))
                    Next
                End If

                Dim card As ChatImageCardDataItem = New ChatImageCardDataItem(Nothing, String.Format("Total:{0}", attachment("premium")), Nothing, sb.ToString(), Nothing, Nothing)
                Me.radChat1.ChatElement.AddMessage(New ChatCardMessage(card, Me.Bot, DateTime.Now))
            End If
        End Sub

        Private Sub RenderSuggestedActions(ByVal data As JToken, ByVal timestamp As DateTime)
            Dim suggestedActions As JToken = data("suggestedActions")
            If suggestedActions Is Nothing Then
                Return
            End If

            Dim actions As List(Of SuggestedActionDataItem) = New List(Of SuggestedActionDataItem)()
            For Each action In suggestedActions
                actions.Add(New SuggestedActionDataItem(Convert.ToString(action("title")), Nothing, action("value")))
            Next

            Me.radChat1.ChatElement.AddMessage(New ChatSuggestedActionsMessage(actions, Me.Bot, timestamp))
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
                    image = Image.FromStream(ms)
                End Using
            Else
                Try
                    Dim str As Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("RadChatExamples.Resources." & url.Substring(url.LastIndexOf("/") + 1))
                    If str IsNot Nothing Then
                        image = Image.FromStream(str)
                    End If
                Catch __unusedException1__ As Exception
                End Try
            End If

            CType(e.UserState, Object())(0).GetType.GetProperty("Image", (BindingFlags.Instance Or BindingFlags.Public)).SetValue(CType(e.UserState, Object())(0), image)
            Me.imageCache(url) = image
        End Sub

        Private Sub RadButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radChat1.ChatElement.InputTextBox.Focus()
        End Sub
    End Class
End Namespace
