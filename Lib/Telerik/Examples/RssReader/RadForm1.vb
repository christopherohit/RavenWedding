Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking
Imports System.Xml
Imports CS
Imports CS.RSS_Library
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.IO
Imports CS.SaveLoadMechanism
Imports System.Xml.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

Namespace CS
    Partial Public Class RadForm1
        Inherits Telerik.WinControls.UI.RadForm
        Private lastUsedDocumentWindow As DocumentWindow
        Private pageHeaderContextMenu As RadContextMenu
        Private listItemContextMenu As RadContextMenu
        Private pageHeader As RadPageViewLabelElement
        Private markAsReadFont As Font = New Font("Segoe UI", 9.25F, FontStyle.Regular)

        Public Sub New()
            InitializeComponent()
            SubscribeToEventsAndCustomizeAppearance()
            ThemeResolutionService.ApplicationThemeName = "TelerikMetro"
        End Sub

        Private Function GetApplicationDataFolder() As String
            Dim roamingPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            Dim fullPath As String = roamingPath & Convert.ToString("\Telerik\WinForms\Examples\RssReader")
            If Not Directory.Exists(fullPath) Then
                Directory.CreateDirectory(fullPath)
            End If

            Return fullPath
        End Function

        Public ReadOnly Property DockLayoutFileName() As String
            Get
                Dim fullPath As String = Me.GetApplicationDataFolder()
                Return Path.Combine(fullPath, "dockLayout.xml")
            End Get
        End Property

        Public ReadOnly Property SaveFeedsFileName() As String
            Get
                Dim fullPath As String = Me.GetApplicationDataFolder()
                Return Path.Combine(fullPath, "saveFeeds.xml")
            End Get
        End Property

#Region "Methods"

        Private Function FindDocumentWindowByName(name As String) As DocumentWindow
            For Each window As DockWindow In Me.radDock1.DockWindows
                Dim dw As DocumentWindow = TryCast(window, DocumentWindow)
                If dw IsNot Nothing AndAlso dw.Text = name Then
                    Return dw
                End If
            Next

            Return Nothing
        End Function

        Private Sub AddFeed(feedUrl As String, Optional name As String = Nothing)
            Dim feed As RssFeed = RssFeed.Load(feedUrl)
            If feed Is Nothing Then
                Return
            Else
                For Each item As RssItem In feed.Channel.Items
                    If item.Description Is Nothing Then
                        RadMessageBox.Show("Unsupported RSS feed")
                        Return
                    End If
                Next item
            End If

            Dim dw As DocumentWindow
            If Not String.IsNullOrEmpty(name) Then
                dw = Me.FindDocumentWindowByName(name)
            Else
                dw = TryCast(Me.radDock1.ActiveWindow, DocumentWindow)
            End If

            Dim splitContainer As RadSplitContainer = Me.GetSplitContainer(dw)

            Dim panel As New SplitPanel()
            panel.SizeInfo.SizeMode = SplitPanelSizeMode.Absolute
            panel.SizeInfo.AbsoluteSize = New Size(200, 0)
            splitContainer.SplitPanelElement.AutoSize = False
            splitContainer.SplitPanels.Insert(0, panel)

            Dim pageView As New RadPageView()
            pageView.Dock = DockStyle.Fill
            pageView.ViewMode = PageViewMode.Stack
            panel.Controls.Add(pageView)

            Dim page As New RadPageViewPage()
            pageView.Pages.Add(page)
            page.Item.Visibility = ElementVisibility.Collapsed

            'add close button to page view header
            Dim closePageButton As New RadButtonElement()
            closePageButton.MaxSize = New Size(20, 20)
            closePageButton.MinSize = New Size(20, 20)
            closePageButton.BorderElement.Visibility = ElementVisibility.Collapsed
            closePageButton.Margin = New Padding(0, 0, 0, 2)
            RemoveHandler closePageButton.Click, AddressOf closePageButton_Click
            AddHandler closePageButton.Click, AddressOf closePageButton_Click
            closePageButton.ImageAlignment = ContentAlignment.MiddleCenter
            closePageButton.Alignment = ContentAlignment.MiddleRight
            closePageButton.Tag = panel

            Dim stackElement As RadPageViewStackElement = TryCast(pageView.ViewElement, RadPageViewStackElement)
            stackElement.Header.Children.Add(closePageButton)
            stackElement.Tag = closePageButton
            stackElement.ContentArea.Padding = New Padding(-1)
            ChangePageViewHeaderImage(ThemeResolutionService.ApplicationThemeName)

            Dim listControl As New RadListControl()
            listControl.Dock = DockStyle.Fill
            listControl.ItemHeight = 80
            RemoveHandler listControl.MouseDown, AddressOf listControl_MouseDown
            AddHandler listControl.MouseDown, AddressOf listControl_MouseDown
            RemoveHandler listControl.DoubleClick, AddressOf listControl_DoubleClick
            AddHandler listControl.DoubleClick, AddressOf listControl_DoubleClick
            RemoveHandler listControl.CreatingVisualListItem, AddressOf listControl_CreatingVisualListItem
            AddHandler listControl.CreatingVisualListItem, AddressOf listControl_CreatingVisualListItem
            RemoveHandler listControl.SelectedIndexChanged, AddressOf listControl_SelectedIndexChanged
            AddHandler listControl.SelectedIndexChanged, AddressOf listControl_SelectedIndexChanged
            RemoveHandler listControl.VisualItemFormatting, AddressOf listControl_VisualItemFormatting
            AddHandler listControl.VisualItemFormatting, AddressOf listControl_VisualItemFormatting
            listControl.Tag = feedUrl
            page.Controls.Add(listControl)

            SetupPageHeaderAndListItemContextMenus(panel, listControl)

            listControl.DataSource = feed.Channel.Items
            listControl.DisplayMember = "Title"
            page.Tag = feed

            'after filling the feeds set the channel name in the page header
            page.Text = feed.Channel.Title

            'adding context menu for the page header item
            AddHandler stackElement.Header.MouseDown, AddressOf Header_MouseDown
            stackElement.Header.Font = New Font(stackElement.Header.Font.FontFamily, 9, FontStyle.Bold)

        End Sub

        Private Sub ChangePageViewHeaderImage(ByVal themeName As String)
            Dim img As Image = Nothing
            Select Case themeName
                Case "Office2010Silver"
                    img = My.Resources.closeButtonOffice2010Silver
                Case "Office2010Blue"
                    img = My.Resources.closeButtonOffice2010blue
                Case "Office2010Black"
                    img = My.Resources.closeButtonOffice2010black
                Case "ControlDefault"
                    img = My.Resources.closeButtonControlDefault
                Case "Telerik"
                    img = My.Resources.closeButtonOffice2010Silver
            End Select

            For Each window As DockWindow In radDock1.DockWindows
                If TypeOf window Is DocumentWindow Then
                    Dim container As RadSplitContainer = GetSplitContainer(TryCast(window, DocumentWindow))
                    If container IsNot Nothing Then
                        For Each panel As SplitPanel In container.SplitPanels
                            Dim pageView As RadPageView = TryCast(panel.Controls(0), RadPageView)
                            Dim stackElement As RadPageViewStackElement = TryCast(pageView.ViewElement, RadPageViewStackElement)
                            Dim pageViewCloseButton As RadButtonElement = TryCast(stackElement.Tag, RadButtonElement)
                            pageViewCloseButton.Image = img
                        Next panel
                    End If
                End If
            Next window
        End Sub

        Private Sub SubscribeToEventsAndCustomizeAppearance()
            AddHandler newCategoryButton.Click, AddressOf addCategoryButton_Click
            AddHandler addSubscriptionButton.Click, AddressOf addFeedButton_Click
            AddHandler radDock1.ActiveWindowChanged, AddressOf radDock1_ActiveWindowChanged
            Dim menuService As ContextMenuService = Me.radDock1.GetService(Of ContextMenuService)()
            AddHandler menuService.ContextMenuDisplaying, AddressOf menuService_ContextMenuDisplaying
            AddHandler windowButton.MouseDown, AddressOf dockWindowsButton_MouseDown
            AddHandler radDock1.PageViewInstanceCreated, AddressOf radDock1_PageViewInstanceCreated

            toolWindow1.ToolCaptionButtons = ToolStripCaptionButtons.Close
            feedContentCommandBar.Rows(0).Strips(0).OverflowButton.Visibility = ElementVisibility.Collapsed
            radLabel1.LabelElement.StretchHorizontally = True
            radLabel1.TextWrap = True

            AddHandler office2010BlackButton.Click, AddressOf changeTheme_Click
            AddHandler office2010BlueButton.Click, AddressOf changeTheme_Click
            AddHandler office2010SilverButton.Click, AddressOf changeTheme_Click
            AddHandler controlDefaultButton.Click, AddressOf changeTheme_Click
            AddHandler telerikButton.Click, AddressOf changeTheme_Click

            AddHandler refreshButton.Click, AddressOf refreshButton_Click
            AddHandler FormClosing, AddressOf RadForm1_FormClosing
            AddHandler Shown, AddressOf RadForm1_Shown
        End Sub

        Private Function AddDocumentWindow(ByVal text As String) As RadSplitContainer
            Dim window As New DocumentWindow(text)
            radDock1.AddDocument(window)
            window.TabStripItem.ShowCloseButton = True
            window.CloseAction = DockWindowCloseAction.Hide
            radDock1.ActiveWindow = window

            Dim splitContainer As New RadSplitContainer()
            splitContainer.Dock = DockStyle.Fill
            splitContainer.AutoScroll = True
            radDock1.ActiveWindow.Controls.Add(splitContainer)

            AddCommandBar(window)

            Return splitContainer
        End Function

        Private Sub AddCommandBar(ByVal window As DocumentWindow)
            Dim commandBar As New RadCommandBar()
            commandBar.Dock = DockStyle.Top
            window.Controls.Add(commandBar)

            Dim row As New CommandBarRowElement()
            commandBar.Rows.Add(row)
            Dim strip As New CommandBarStripElement()
            row.Strips.Add(strip)

            Dim addFeedButton As New CommandBarButton()
            addFeedButton.DisplayName = "Add Feed"
            addFeedButton.Image = My.Resources.feed_add
            AddHandler addFeedButton.Click, AddressOf addFeedButton_Click

            strip.Items.Add(addFeedButton)
            strip.Items.Add(New CommandBarSeparator())

            Dim showSubscriptionsButton As New CommandBarDropDownButton()
            showSubscriptionsButton.DrawText = True
            showSubscriptionsButton.TextImageRelation = TextImageRelation.ImageBeforeText
            showSubscriptionsButton.Text = "Show subscriptions"
            showSubscriptionsButton.DisplayName = "Show subscriptions"
            showSubscriptionsButton.Image = My.Resources.application_tile_horizontal
            AddHandler showSubscriptionsButton.MouseDown, AddressOf showSubscriptionsButton_MouseDown

            strip.Items.Add(showSubscriptionsButton)

            Dim scrollToSubscriptionButton As New CommandBarDropDownButton()
            scrollToSubscriptionButton.DrawText = True
            scrollToSubscriptionButton.TextImageRelation = TextImageRelation.ImageBeforeText
            scrollToSubscriptionButton.Text = "Scroll to subscription"
            scrollToSubscriptionButton.DisplayName = "Scroll to subscription"
            scrollToSubscriptionButton.Image = My.Resources.application_go
            AddHandler scrollToSubscriptionButton.MouseDown, AddressOf scrollToSubscriptionButton_MouseDown
            strip.Items.Add(scrollToSubscriptionButton)
        End Sub

        Private Sub SetupPageHeaderAndListItemContextMenus(ByVal panel As SplitPanel, ByVal listControl As RadListControl)
            listItemContextMenu = New RadContextMenu()
            Dim readFullArticleMenuItem As New RadMenuItem("Read full article")
            readFullArticleMenuItem.Tag = listControl
            RemoveHandler readFullArticleMenuItem.Click, AddressOf readFullArticleMenuItem_Click
            AddHandler readFullArticleMenuItem.Click, AddressOf readFullArticleMenuItem_Click
            listItemContextMenu.Items.Add(readFullArticleMenuItem)

            listItemContextMenu.Items.Add(New RadMenuSeparatorItem())

            Dim editFeedMenuItem As New RadMenuItem("Edit subscription")
            RemoveHandler editFeedMenuItem.Click, AddressOf editFeedMenuItem_Click
            AddHandler editFeedMenuItem.Click, AddressOf editFeedMenuItem_Click
            listItemContextMenu.Items.Add(editFeedMenuItem)

            Dim unsubscribeMenuItem As New RadMenuItem("Unsubscribe")
            unsubscribeMenuItem.Tag = panel
            RemoveHandler unsubscribeMenuItem.Click, AddressOf unsubscribeMenuItem_Click
            AddHandler unsubscribeMenuItem.Click, AddressOf unsubscribeMenuItem_Click
            listItemContextMenu.Items.Add(unsubscribeMenuItem)

            pageHeaderContextMenu = New RadContextMenu()
            Dim editFeedMenuItemInPageView As New RadMenuItem("Edit subscription")
            RemoveHandler editFeedMenuItemInPageView.Click, AddressOf editFeedMenuItem_Click
            AddHandler editFeedMenuItemInPageView.Click, AddressOf editFeedMenuItem_Click
            pageHeaderContextMenu.Items.Add(editFeedMenuItemInPageView)

            Dim unsubscribeMenuItemInPageView As New RadMenuItem("Unsubscribe")
            unsubscribeMenuItemInPageView.Tag = panel
            RemoveHandler unsubscribeMenuItemInPageView.Click, AddressOf unsubscribeMenuItem_Click
            AddHandler unsubscribeMenuItemInPageView.Click, AddressOf unsubscribeMenuItem_Click
            pageHeaderContextMenu.Items.Add(unsubscribeMenuItemInPageView)
        End Sub

        Private Function isValidUrl(ByVal url As String) As Boolean
            Try
                Dim webRequest_Renamed As WebRequest = WebRequest.Create(url)
                Dim webResponse_Renamed As WebResponse
                Try
                    webResponse_Renamed = webRequest_Renamed.GetResponse()
                Catch ex As WebException
                    RadMessageBox.Show("Url address not responding.")
                    Return False
                End Try
            Catch
                RadMessageBox.Show("Invalid url address")
                Return False
            End Try
            Return True
        End Function

        Private Function GetSplitContainer(ByVal window As DocumentWindow) As RadSplitContainer
            For Each c As Control In window.Controls
                If TypeOf c Is RadSplitContainer Then
                    Dim containter As RadSplitContainer = TryCast(c, RadSplitContainer)
                    Return containter
                End If
            Next c
            Return Nothing
        End Function

#End Region

#Region "Events"

        Private Sub RadForm1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            Try
                radDock1.SaveToXml(Me.DockLayoutFileName)
                Dim docWindows As New SaveLoadClass()
                docWindows.DocWindows = New DocWindow(radDock1.DockWindows.Count - 2) {}
                Dim i As Integer = 0

                For Each window As DockWindow In radDock1.DockWindows
                    Dim dw As DocumentWindow = TryCast(window, DocumentWindow)
                    If dw IsNot Nothing Then
                        Dim docWindow_Renamed As New DocWindow()
                        docWindow_Renamed.Text = dw.Text

                        Dim container As RadSplitContainer = GetSplitContainer(dw)
                        Dim feedNum As Integer = 0
                        docWindow_Renamed.Feeds = New Feed(container.SplitPanels.Count - 1) {}

                        For Each panel As SplitPanel In container.SplitPanels
                            Dim pageview As RadPageView = TryCast(panel.Controls(0), RadPageView)
                            Dim page As RadPageViewPage = TryCast(pageview.Pages(0), RadPageViewPage)
                            Dim listcontrol As RadListControl = TryCast(page.Controls(0), RadListControl)
                            If listcontrol IsNot Nothing AndAlso listcontrol.Tag IsNot Nothing Then
                                Dim feed_Renamed As New Feed()
                                feed_Renamed.Link = listcontrol.Tag.ToString()
                                docWindow_Renamed.Feeds(feedNum) = feed_Renamed
                                feedNum += 1
                            End If
                        Next panel
                        docWindows.DocWindows(i) = docWindow_Renamed
                        i += 1
                    End If
                Next window

                Dim serializer As New XmlSerializer(GetType(SaveLoadClass))
                Dim textWriter As New XmlTextWriter(Me.SaveFeedsFileName, Encoding.UTF8)
                serializer.Serialize(textWriter, docWindows)
                textWriter.Close()

            Catch ex As Exception
                RadMessageBox.Show(ex.Message + Environment.NewLine + "The application is now going to close. Please resolve the possible issues.")
            End Try
        End Sub

        Private Sub RadForm1_Shown(sender As Object, e As EventArgs)
            Dim dockLayoutFile As String = "dockLayout.xml"
            Dim saveFeedFile As String = "saveFeeds.xml"
            If File.Exists(Me.DockLayoutFileName) AndAlso File.Exists(Me.SaveFeedsFileName) Then
                dockLayoutFile = Me.DockLayoutFileName
                saveFeedFile = Me.SaveFeedsFileName
            End If

            If File.Exists(dockLayoutFile) AndAlso File.Exists(saveFeedFile) Then
                WaitingForm.ShowForm(Nothing)
                radDock1.LoadFromXml(dockLayoutFile)

                Dim serializer As New XmlSerializer(GetType(SaveLoadClass))
                Dim textReader As New XmlTextReader(saveFeedFile)
                Dim savedData As SaveLoadClass = TryCast(serializer.Deserialize(textReader), SaveLoadClass)
                textReader.Close()

                For Each window As DockWindow In radDock1.DockWindows
                    For Each savedWindow As DocWindow In savedData.DocWindows
                        If TypeOf window Is DocumentWindow AndAlso window.Text = savedWindow.Text Then
                            window.TabStripItem.ShowCloseButton = True
                            window.CloseAction = DockWindowCloseAction.Hide
                            radDock1.ActiveWindow = window

                            Dim splitContainer As New RadSplitContainer()
                            splitContainer.Dock = DockStyle.Fill
                            splitContainer.AutoScroll = True
                            ' when the window is hidden it will not be set as RadDock's ActiveWindow
                            window.Controls.Add(splitContainer)

                            Me.AddCommandBar(TryCast(window, DocumentWindow))

                            If savedWindow.Feeds IsNot Nothing Then
                                For Each feed_Renamed As Feed In savedWindow.Feeds
                                    If feed_Renamed IsNot Nothing Then
                                        AddFeed(feed_Renamed.Link)
                                    End If
                                Next feed_Renamed
                            End If
                        End If
                    Next savedWindow
                Next window
                WaitingForm.CloseForm()
            Else
                AddDocumentWindow("Miscellaneous")
            End If

        End Sub

        Private Sub refreshButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            WaitingForm.ShowForm(Nothing)
            For Each window As DockWindow In radDock1.DockWindows
                If TypeOf window Is DocumentWindow Then
                    Dim dw As DocumentWindow = TryCast(window, DocumentWindow)
                    Dim container As RadSplitContainer = GetSplitContainer(dw)
                    For Each panel As SplitPanel In container.SplitPanels
                        Dim pageView As RadPageView = TryCast(panel.Controls(0), RadPageView)
                        Dim page As RadPageViewPage = TryCast(pageView.Pages(0), RadPageViewPage)

                        Dim listControl As RadListControl = TryCast(page.Controls(0), RadListControl)
                        Dim feedLink As String = listControl.Tag.ToString()
                        Dim feed As RssFeed = RssFeed.Load(feedLink)
                        listControl.DataSource = feed.Channel.Items
                    Next panel
                End If
            Next window
            WaitingForm.CloseForm()
        End Sub

        Private Sub scrollToSubscriptionButton_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim dropDownButton As CommandBarDropDownButton = TryCast(sender, CommandBarDropDownButton)
            dropDownButton.Items.Clear()

            Dim containter As RadSplitContainer = GetSplitContainer(TryCast(radDock1.ActiveWindow, DocumentWindow))

            For Each panel As SplitPanel In containter.SplitPanels
                Dim pageView As RadPageView = TryCast(panel.Controls(0), RadPageView)
                Dim stackElement As RadPageViewStackElement = TryCast(pageView.ViewElement, RadPageViewStackElement)
                Dim label As RadPageViewLabelElement = TryCast(stackElement.Header, RadPageViewLabelElement)

                If panel.Collapsed = False Then
                    Dim scrollToSubscriptionItem As New RadMenuItem(label.Text)
                    scrollToSubscriptionItem.Tag = panel
                    AddHandler scrollToSubscriptionItem.Click, AddressOf scrollToSubscriptionItem_Click
                    dropDownButton.Items.Add(scrollToSubscriptionItem)
                End If
            Next panel
        End Sub

        Private Sub scrollToSubscriptionItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim panel As SplitPanel = TryCast((CType(sender, RadMenuItem)).Tag, SplitPanel)
            Dim cont As RadSplitContainer = panel.SplitContainer
            cont.ScrollControlIntoView(panel)
        End Sub

        Private Sub showSubscriptionsButton_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)


            Dim containter As RadSplitContainer = GetSplitContainer(TryCast(radDock1.ActiveWindow, DocumentWindow))
            If containter.SplitPanels.Count > 0 Then
                'TODO this should work when the visibility bug of SplitPanel is fixed.
                Dim dropDownButton As CommandBarDropDownButton = TryCast(sender, CommandBarDropDownButton)
                dropDownButton.Items.Clear()

                Dim showAll As New RadMenuItem("Show all")
                AddHandler showAll.Click, AddressOf showAll_Click
                dropDownButton.Items.Add(showAll)
                dropDownButton.Items.Add(New RadMenuSeparatorItem())

                For Each panel As SplitPanel In containter.SplitPanels
                    Dim pageView As RadPageView = TryCast(panel.Controls(0), RadPageView)
                    Dim stackElement As RadPageViewStackElement = TryCast(pageView.ViewElement, RadPageViewStackElement)
                    Dim label As RadPageViewLabelElement = TryCast(stackElement.Header, RadPageViewLabelElement)

                    Dim showSubscriptionsItem As New RadMenuItem(label.Text)
                    If panel.Collapsed = False Then
                        showSubscriptionsItem.IsChecked = True
                    Else
                        showSubscriptionsItem.IsChecked = False
                    End If
                    AddHandler showSubscriptionsItem.Click, AddressOf showSubscriptionsItem_Click
                    dropDownButton.Items.Add(showSubscriptionsItem)
                Next panel
            End If
        End Sub

        Private Sub showSubscriptionsItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As RadMenuItem = TryCast(sender, RadMenuItem)
            Dim containter As RadSplitContainer = GetSplitContainer(TryCast(radDock1.ActiveWindow, DocumentWindow))

            For Each panel As SplitPanel In containter.SplitPanels
                Dim pageView As RadPageView = TryCast(panel.Controls(0), RadPageView)
                Dim stackElement As RadPageViewStackElement = TryCast(pageView.ViewElement, RadPageViewStackElement)
                Dim label As RadPageViewLabelElement = TryCast(stackElement.Header, RadPageViewLabelElement)

                If label.Text = (CType(sender, RadMenuItem)).Text Then
                    If item.IsChecked Then
                        item.IsChecked = False
                        panel.Collapsed = True
                    Else
                        item.IsChecked = True
                        panel.Collapsed = False
                    End If
                End If
            Next panel
        End Sub

        Private Sub showAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim containter As RadSplitContainer = GetSplitContainer(TryCast(radDock1.ActiveWindow, DocumentWindow))
            For Each panel As SplitPanel In containter.SplitPanels
                panel.Collapsed = False
            Next panel
        End Sub

        Private Sub radDock1_PageViewInstanceCreated(ByVal sender As Object, ByVal e As PageViewInstanceCreatedEventArgs)
            'when tabbed document is moved in a new pageview show its buttons
            Dim element As RadPageViewStripElement = TryCast(e.PageViewElement, RadPageViewStripElement)
            element.StripButtons = StripViewButtons.Scroll
            element.NewItemVisibility = StripViewNewItemVisibility.End
            RemoveHandler element.NewItem.Click, AddressOf addCategoryButton_Click
            AddHandler element.NewItem.Click, AddressOf addCategoryButton_Click
        End Sub

        Private Sub changeTheme_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim button As CommandBarButton = TryCast(sender, CommandBarButton)
            ThemeResolutionService.ApplicationThemeName = button.Text
            ChangePageViewHeaderImage(button.Text)

        End Sub

        Private Sub dockWindowsButton_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            windowButton.Items.Clear()
            For Each window As DockWindow In radDock1.DockWindows
                Dim item As New RadMenuItem(window.Text)
                If window.DockState <> DockState.Hidden Then
                    item.IsChecked = True
                End If
                AddHandler item.Click, AddressOf item_Click
                windowButton.Items.Add(item)
            Next window

            Dim feedContentMenuItem As RadMenuItem
            Dim i As Integer = 0
            Do While i < windowButton.Items.Count
                If windowButton.Items(i).Text = "Feed content" Then
                    feedContentMenuItem = TryCast(windowButton.Items(i), RadMenuItem)
                    windowButton.Items.Remove(feedContentMenuItem)
                    windowButton.Items.Add(New RadMenuSeparatorItem())
                    windowButton.Items.Add(feedContentMenuItem)
                    Exit Do
                End If
                i += 1
            Loop
        End Sub

        Private Sub item_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As RadMenuItem = TryCast(sender, RadMenuItem)

            For Each window As DockWindow In radDock1.DockWindows
                If window.Text = (CType(sender, RadMenuItem)).Text Then
                    If Not item.IsChecked Then
                        If TypeOf window Is DocumentWindow AndAlso window.DockState <> DockState.TabbedDocument Then
                            window.DockState = DockState.TabbedDocument
                            window.TabStripItem.ShowCloseButton = True
                            radDock1.ActiveWindow = window
                        Else
                            window.DockState = DockState.Docked
                            radDock1.ActiveWindow = window
                        End If
                    Else
                        window.DockState = DockState.Hidden
                        item.IsChecked = False
                    End If
                End If
            Next window
        End Sub

        Private Sub menuService_ContextMenuDisplaying(ByVal sender As Object, ByVal e As ContextMenuDisplayingEventArgs)
            If e.MenuType = ContextMenuType.DockWindow AndAlso TypeOf e.DockWindow.DockTabStrip Is DocumentTabStrip Then
                For i As Integer = 0 To e.MenuItems.Count - 1
                    e.MenuItems(i).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
                Next i

                Dim addCategoryItem As New RadMenuItem("New category")
                addCategoryItem.Image = My.Resources.folder_feed
                RemoveHandler addCategoryItem.Click, AddressOf addCategoryButton_Click
                AddHandler addCategoryItem.Click, AddressOf addCategoryButton_Click
                e.MenuItems.Add(addCategoryItem)

                Dim renameCategoryItem As New RadMenuItem("Rename category")
                renameCategoryItem.Image = My.Resources.pencil
                RemoveHandler renameCategoryItem.Click, AddressOf renameCategoryItem_Click
                AddHandler renameCategoryItem.Click, AddressOf renameCategoryItem_Click
                e.MenuItems.Add(renameCategoryItem)

                Dim removeCategoryItem As New RadMenuItem("Remove category")
                removeCategoryItem.Image = My.Resources.cross
                RemoveHandler removeCategoryItem.Click, AddressOf removeCategoryItem_Click
                AddHandler removeCategoryItem.Click, AddressOf removeCategoryItem_Click
                e.MenuItems.Add(removeCategoryItem)

                e.MenuItems.Add(New RadMenuSeparatorItem())

                Dim addFeedItem As New RadMenuItem("Add subscription")
                addFeedItem.Image = My.Resources.feed_add
                RemoveHandler addFeedItem.Click, AddressOf addFeedButton_Click
                AddHandler addFeedItem.Click, AddressOf addFeedButton_Click
                e.MenuItems.Add(addFeedItem)
            End If
        End Sub

        Private Sub removeCategoryItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim miscellaneousWindow As DocumentWindow = Nothing
            For Each window As DockWindow In radDock1.DockWindows
                If TypeOf window Is DocumentWindow AndAlso window.Text = "Miscellaneous" Then
                    miscellaneousWindow = TryCast(window, DocumentWindow)
                    Exit For
                End If
            Next window

            If miscellaneousWindow IsNot Nothing AndAlso radDock1.ActiveWindow IsNot miscellaneousWindow AndAlso RadMessageBox.Show("Do you want to move all subscriptions from this category to the Miscellaneous category? If you select No, all subscriptions will be removed", "Remove category", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim containerToMoveFrom As RadSplitContainer = GetSplitContainer(TryCast(radDock1.ActiveWindow, DocumentWindow))
                Dim containerToMoveTo As RadSplitContainer = GetSplitContainer(miscellaneousWindow)
                For Each panel As SplitPanel In containerToMoveFrom.SplitPanels
                    containerToMoveTo.SplitPanels.Add(panel)
                Next panel
            End If
            radDock1.ActiveWindow.CloseAction = DockWindowCloseAction.CloseAndDispose
            radDock1.ActiveWindow.Close()
        End Sub

        Private Sub renameCategoryItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim form As New AddForm()
            form.Text = "Rename category"
            form.Label.Text = "Please enter the new category name:"
            form.TextBox.Text = radDock1.ActiveWindow.Text
            form.RaiseErrorOnEmptyString = True
            form.ErrorText = "Category name is required."
            If form.ShowDialog(Me) = DialogResult.OK Then
                radDock1.ActiveWindow.Text = form.TextBox.Text
            End If
        End Sub

        Private Sub radDock1_ActiveWindowChanged(ByVal sender As Object, ByVal e As DockWindowEventArgs)
            Dim window As DocumentWindow = TryCast(e.DockWindow, DocumentWindow)
            If window IsNot Nothing Then
                lastUsedDocumentWindow = window
            End If
        End Sub

        Private Sub addCategoryButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim form As New AddForm()
            form.Text = "Adding category"
            form.Label.Text = "Please enter category name:"
            form.RaiseErrorOnEmptyString = True
            form.ErrorText = "Category name is required."
            If form.ShowDialog(Me) = DialogResult.OK Then
                AddDocumentWindow(form.TextBox.Text)
            End If
        End Sub

        Private Sub addFeedButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not (TypeOf radDock1.ActiveWindow Is DocumentWindow) Then
                If lastUsedDocumentWindow IsNot Nothing Then
                    radDock1.ActiveWindow = lastUsedDocumentWindow

                End If
            End If
            If Not (TypeOf radDock1.ActiveWindow Is DocumentWindow) Then
                RadMessageBox.Show("Missing categories.")
                Return
            End If

            Dim form As New AddForm()
            form.Text = "Adding Rss"
            form.Label.Text = "Please enter RSS Url:"
            form.RaiseErrorOnEmptyString = True
            form.ErrorText = "RSS Url is required."

            If form.ShowDialog(Me) = DialogResult.OK AndAlso isValidUrl(form.TextBox.Text) Then
                WaitingForm.ShowForm(Nothing)
                AddFeed(form.TextBox.Text)
                WaitingForm.CloseForm()
            End If
        End Sub

        Private Sub listControl_VisualItemFormatting(ByVal sender As Object, ByVal args As VisualItemFormattingEventArgs)
            Dim item As RadListDataItem = args.VisualItem.Data
            If item IsNot Nothing Then
                If Convert.ToBoolean(item.Tag) Then
                    'the item is read, mark it
                    Dim el As RssItemElement = TryCast(args.VisualItem, RssItemElement)
                    el.HeaderElement.Font = markAsReadFont
                Else
                    'reset setting 
                    Dim el As RssItemElement = TryCast(args.VisualItem, RssItemElement)
                    el.HeaderElement.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local)
                End If
            End If
        End Sub

        Private Sub unsubscribeMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As RadMenuItem = TryCast(sender, RadMenuItem)
            Dim container As RadSplitContainer = GetSplitContainer(TryCast(radDock1.ActiveWindow, DocumentWindow))
            container.SplitPanels.Remove(TryCast(item.Tag, SplitPanel))
        End Sub

        Private Sub readFullArticleMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim listControl As RadListControl = TryCast((CType(sender, RadMenuItem)).Tag, RadListControl)
            Dim browserForm_Renamed As New BrowserForm()

            browserForm_Renamed.WebBrowser.Navigate((CType(listControl.SelectedItem.Value, RssItem)).Link.ToString())
            browserForm_Renamed.Show()

        End Sub

        Private Sub listControl_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Right Then
                Dim listControl As RadListControl = TryCast(sender, RadListControl)
                Dim page As RadPageViewPage = TryCast(listControl.Parent, RadPageViewPage)
                Dim strip As RadPageViewStackElement = TryCast((CType(page.Owner, RadPageView)).ViewElement, RadPageViewStackElement)
                pageHeader = strip.Header

                Dim clickedItem As RadItem = TryCast(listControl.ElementTree.GetElementAtPoint(e.Location), RadItem)
                Dim itemToSelect As RssItemElement
                If Not (TypeOf clickedItem Is RssItemElement) Then
                    itemToSelect = clickedItem.FindAncestor(Of RssItemElement)()
                Else
                    itemToSelect = TryCast(clickedItem, RssItemElement)
                End If
                listControl.SelectedItem = itemToSelect.Data
                listItemContextMenu.Show(MousePosition)
            End If
        End Sub

        Private Sub listControl_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim listControl As RadListControl = TryCast(sender, RadListControl)
            Dim browserForm_Renamed As New BrowserForm()
            browserForm_Renamed.WebBrowser.Navigate((CType(listControl.SelectedItem.Value, RssItem)).Link.ToString())
            browserForm_Renamed.Show()
        End Sub

        Private Sub closePageButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim panelToClose As SplitPanel = TryCast((TryCast(sender, RadButtonElement)).Tag, SplitPanel)
            'TODO visibility is not working
            panelToClose.Collapsed = True
        End Sub

        Private Sub editFeedMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            'change category logic
            Dim form As New ChangeCategoryForm()
            form.NameTextBox.Text = pageHeader.Text
            For Each dw As DockWindow In radDock1.DockWindows
                If TypeOf dw Is DocumentWindow AndAlso dw IsNot radDock1.ActiveWindow Then
                    Dim item As New RadListDataItem()
                    item.Text = dw.Text
                    item.Tag = dw
                    form.RadDropDownList.Items.Add(item)
                End If
            Next dw
            If form.ShowDialog(Me) = DialogResult.OK Then
                If form.CheckBox.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                    Dim container As RadSplitContainer = AddDocumentWindow(form.NewCategoryNameTextBox.Text)

                    Dim currentFeedSplitPanel As SplitPanel = TryCast(pageHeader.ElementTree.Control.Parent, SplitPanel)
                    container.SplitPanels.Add(currentFeedSplitPanel)
                ElseIf form.RadDropDownList.SelectedItem IsNot Nothing Then
                    Dim windowToMoveTo As DocumentWindow = TryCast(form.RadDropDownList.SelectedItem.Tag, DocumentWindow)
                    Dim currentFeedSplitPanel As SplitPanel = TryCast(pageHeader.ElementTree.Control.Parent, SplitPanel)
                    Dim containter As RadSplitContainer = GetSplitContainer(windowToMoveTo)

                    containter.SplitPanels.Add(currentFeedSplitPanel)
                    radDock1.ActiveWindow = windowToMoveTo
                End If

                If Not (String.IsNullOrEmpty(form.NameTextBox.Text)) Then
                    pageHeader.Text = form.NameTextBox.Text
                End If
            End If
        End Sub

        Private Sub Header_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            'assign the pageHeader used in list items context menu
            If e.Button = MouseButtons.Right Then
                pageHeaderContextMenu.Show(MousePosition.X, MousePosition.Y)
                pageHeader = TryCast(sender, RadPageViewLabelElement)
            End If
        End Sub

        Private Sub listControl_CreatingVisualListItem(ByVal sender As Object, ByVal args As CreatingVisualListItemEventArgs)
            args.VisualItem = New RssItemElement()
        End Sub

        Private Sub listControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            'assign the web browser content
            Dim item As RadListElement = TryCast(sender, RadListElement)
            Dim listControl As RadListControl = TryCast(item.ElementTree.Control, RadListControl)
            If e.Position > -1 Then
                webBrowser1.DocumentText = (CType(listControl.Items(e.Position).Value, RssItem)).Description
                radLabel1.Text = (CType(listControl.Items(e.Position).Value, RssItem)).Title
                webBrowser1.Tag = listControl
            End If

            'assign the pageHeader used in list items context menu
            Dim pageView As RadPageView = TryCast(listControl.Parent.Parent.Parent, RadPageView)
            If pageView IsNot Nothing Then
                Dim element As RadPageViewStripElement = TryCast(pageView.ViewElement, RadPageViewStripElement)
                pageHeader = element.Header
            End If

            'mark the item as read
            Dim listItem As RadListDataItem = TryCast(listControl.Items(e.Position), RadListDataItem)
            If listItem IsNot Nothing Then
                'mark the item as read
                listItem.Tag = True
            End If
        End Sub

        Private Sub scrollToPanelButon_Click(ByVal sender As Object, ByVal e As EventArgs) Handles scrollToPanelButton.Click
            Dim listControl As RadListControl = TryCast(webBrowser1.Tag, RadListControl)
            If listControl Is Nothing OrElse listControl.SelectedItem Is Nothing Then
                Return
            End If

            Dim panel As SplitPanel = TryCast(listControl.Parent.Parent.Parent, SplitPanel)
            Dim cont As RadSplitContainer = panel.SplitContainer
            For Each window As DockWindow In radDock1.DockWindows
                Dim dw As DocumentWindow = TryCast(window, DocumentWindow)
                If dw IsNot Nothing Then
                    Dim container As RadSplitContainer = GetSplitContainer(dw)
                    If cont Is container Then
                        radDock1.ActiveWindow = dw
                        cont.ScrollControlIntoView(panel)
                    End If
                End If
            Next window
        End Sub

        Private Sub openInBrowserButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles openInBrowserButton.Click
            Dim listControl As RadListControl = TryCast(webBrowser1.Tag, RadListControl)
            If listControl Is Nothing OrElse listControl.SelectedItem Is Nothing Then
                RadMessageBox.Show("Please select feed to display in browser")
                Return
            End If
            Dim browserForm_Renamed As New BrowserForm()
            browserForm_Renamed.WebBrowser.Navigate((CType(listControl.SelectedItem.Value, RssItem)).Link.ToString())
            browserForm_Renamed.Show()
        End Sub

#End Region

    End Class
End Namespace
