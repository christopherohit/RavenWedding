using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

using RssReader.Properties;
using RssReader.RSS_Library;
using RssReader.SaveLoadMechanism;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;

namespace RssReader
{
    public partial class RadForm1 : RadForm
    {
        private DocumentWindow lastUsedDocumentWindow;
        private RadContextMenu pageHeaderContextMenu;
        private RadContextMenu listItemContextMenu;
        private RadPageViewLabelElement pageHeader;
        private Font markAsReadFont = new Font("Segoe UI", 9.25f, FontStyle.Regular);

        public RadForm1()
        {
            InitializeComponent();
            SubscribeToEventsAndCustomizeAppearance();
            ThemeResolutionService.ApplicationThemeName = "TelerikMetro";
        }

        private string GetApplicationDataFolder()
        {
            string roamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string fullPath = roamingPath + @"\Telerik\WinForms\Examples\RssReader";
            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }

            return fullPath;
        }

        public string DockLayoutFileName
        {
            get
            {
                string fullPath = this.GetApplicationDataFolder();
                return Path.Combine(fullPath, "dockLayout.xml");
            }
        }

        public string SaveFeedsFileName
        {
            get
            {
                string fullPath = this.GetApplicationDataFolder();
                return Path.Combine(fullPath, "saveFeeds.xml");
            }
        }

        #region Methods

        private DocumentWindow FindDocumentWindowByName(string name)
        {
            foreach (var window in this.radDock1.DockWindows)
            {
                DocumentWindow dw = window as DocumentWindow;
                if (dw != null && dw.Text == name)
                {
                    return dw;
                }
            }

            return null;
        }

        private void AddFeed(string feedUrl, string name = null)
        {
            RssFeed feed = RssFeed.Load(feedUrl);
            if (feed == null)
            {
                return;
            }
            else
            {
                foreach (RssItem item in feed.Channel.Items)
                {
                    if (item.Description == null)
                    {
                        RadMessageBox.Show("Unsupported RSS feed");
                        return;
                    }
                }
            }

            DocumentWindow dw;
            if (!string.IsNullOrEmpty(name))
            {
                dw = this.FindDocumentWindowByName(name);
            }
            else
            {
                dw = this.radDock1.ActiveWindow as DocumentWindow;
            }

            RadSplitContainer splitContainer = this.GetSplitContainer(dw);

            SplitPanel panel = new SplitPanel();
            panel.SizeInfo.SizeMode = SplitPanelSizeMode.Absolute;
            panel.SizeInfo.AbsoluteSize = new Size(200, 0);
            splitContainer.SplitPanelElement.AutoSize = false;
            splitContainer.SplitPanels.Insert(0, panel);

            RadPageView pageView = new RadPageView();
            pageView.Dock = DockStyle.Fill;
            pageView.ViewMode = PageViewMode.Stack;
            panel.Controls.Add(pageView);

            RadPageViewPage page = new RadPageViewPage();
            pageView.Pages.Add(page);
            page.Item.Visibility = ElementVisibility.Collapsed;

            //add close button to page view header
            RadButtonElement closePageButton = new RadButtonElement();
            closePageButton.MaxSize = new Size(20, 20);
            closePageButton.MinSize = new Size(20, 20);
            closePageButton.BorderElement.Visibility = ElementVisibility.Collapsed;
            closePageButton.Margin = new Padding(0, 0, 0, 2);
            closePageButton.Click -= new EventHandler(closePageButton_Click);
            closePageButton.Click += new EventHandler(closePageButton_Click);
            closePageButton.ImageAlignment = ContentAlignment.MiddleCenter;
            closePageButton.Alignment = ContentAlignment.MiddleRight;
            closePageButton.Tag = panel;

            RadPageViewStackElement stackElement = pageView.ViewElement as RadPageViewStackElement;
            stackElement.Header.Children.Add(closePageButton);
            stackElement.Tag = closePageButton;
            stackElement.ContentArea.Padding = new Padding(-1);
            ChangePageViewHeaderImage(ThemeResolutionService.ApplicationThemeName);

            RadListControl listControl = new RadListControl();
            listControl.Dock = DockStyle.Fill;
            listControl.ItemHeight = 80;
            listControl.MouseDown -= new MouseEventHandler(listControl_MouseDown);
            listControl.MouseDown += new MouseEventHandler(listControl_MouseDown);
            listControl.DoubleClick -= new EventHandler(listControl_DoubleClick);
            listControl.DoubleClick += new EventHandler(listControl_DoubleClick);
            listControl.CreatingVisualListItem -= new CreatingVisualListItemEventHandler(listControl_CreatingVisualListItem);
            listControl.CreatingVisualListItem += new CreatingVisualListItemEventHandler(listControl_CreatingVisualListItem);
            listControl.SelectedIndexChanged -= new Telerik.WinControls.UI.Data.PositionChangedEventHandler(listControl_SelectedIndexChanged);
            listControl.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(listControl_SelectedIndexChanged);
            listControl.VisualItemFormatting -= new VisualListItemFormattingEventHandler(listControl_VisualItemFormatting);
            listControl.VisualItemFormatting += new VisualListItemFormattingEventHandler(listControl_VisualItemFormatting);
            listControl.Tag = feedUrl;
            page.Controls.Add(listControl);

            SetupPageHeaderAndListItemContextMenus(panel, listControl);

            listControl.DataSource = feed.Channel.Items;
            listControl.DisplayMember = "Title";
            page.Tag = feed;

            //after filling the feeds set the channel name in the page header
            page.Text = feed.Channel.Title;

            //adding context menu for the page header item
            stackElement.Header.MouseDown += new MouseEventHandler(Header_MouseDown);
            stackElement.Header.Font = new Font(stackElement.Header.Font.FontFamily, 9, FontStyle.Bold);

        }

        private void ChangePageViewHeaderImage(string themeName)
        {
            Image img = null;
            switch (themeName)
            {
                case "Office2010Silver":
                    img = Resources.closeButtonOffice2010Silver;
                    break;
                case "Office2010Blue":
                    img = Resources.closeButtonOffice2010blue;
                    break;
                case "Office2010Black":
                    img = Resources.closeButtonOffice2010black;
                    break;
                case "ControlDefault":
                    img = Resources.closeButtonControlDefault;
                    break;
                case "Telerik":
                    img = Resources.closeButtonOffice2010Silver;
                    break;
            }

            foreach (DockWindow window in radDock1.DockWindows)
            {
                if (window is DocumentWindow)
                {
                    RadSplitContainer container = GetSplitContainer(window as DocumentWindow);
                    if (container != null)
                    {
                        foreach (SplitPanel panel in container.SplitPanels)
                        {
                            RadPageView pageView = panel.Controls[0] as RadPageView;
                            RadPageViewStackElement stackElement = pageView.ViewElement as RadPageViewStackElement;
                            RadButtonElement pageViewCloseButton = stackElement.Tag as RadButtonElement;
                            pageViewCloseButton.Image = img;
                        }
                    }
                }
            }
        }

        private void SubscribeToEventsAndCustomizeAppearance()
        {
            newCategoryButton.Click += new EventHandler(addCategoryButton_Click);
            addSubscriptionButton.Click += new EventHandler(addFeedButton_Click);
            radDock1.ActiveWindowChanged += new DockWindowEventHandler(radDock1_ActiveWindowChanged);
            ContextMenuService menuService = this.radDock1.GetService<ContextMenuService>();
            menuService.ContextMenuDisplaying += new ContextMenuDisplayingEventHandler(menuService_ContextMenuDisplaying);
            windowButton.MouseDown += new MouseEventHandler(dockWindowsButton_MouseDown);
            radDock1.PageViewInstanceCreated += new PageViewInstanceCreatedEventHandler(radDock1_PageViewInstanceCreated);

            toolWindow1.ToolCaptionButtons = ToolStripCaptionButtons.Close;
            feedContentCommandBar.Rows[0].Strips[0].OverflowButton.Visibility = ElementVisibility.Collapsed;
            radLabel1.LabelElement.StretchHorizontally = true;
            radLabel1.TextWrap = true;

            office2010BlackButton.Click += new EventHandler(changeTheme_Click);
            office2010BlueButton.Click += new EventHandler(changeTheme_Click);
            office2010SilverButton.Click += new EventHandler(changeTheme_Click);
            controlDefaultButton.Click += new EventHandler(changeTheme_Click);
            telerikButton.Click += new EventHandler(changeTheme_Click);

            refreshButton.Click += new EventHandler(refreshButton_Click);
            this.FormClosing += new FormClosingEventHandler(RadForm1_FormClosing);
            this.Shown += new EventHandler(RadForm1_Shown);
        }

        private RadSplitContainer AddDocumentWindow(string text)
        {
            DocumentWindow window = new DocumentWindow(text);
            radDock1.AddDocument(window);
            window.TabStripItem.ShowCloseButton = true;
            window.CloseAction = DockWindowCloseAction.Hide;
            radDock1.ActiveWindow = window;

            RadSplitContainer splitContainer = new RadSplitContainer();
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.AutoScroll = true;
            radDock1.ActiveWindow.Controls.Add(splitContainer);

            AddCommandBar(window);

            return splitContainer;
        }

        private void AddCommandBar(DocumentWindow window)
        {
            RadCommandBar commandBar = new RadCommandBar();
            commandBar.Dock = DockStyle.Top;
            window.Controls.Add(commandBar);

            CommandBarRowElement row = new CommandBarRowElement();
            commandBar.Rows.Add(row);
            CommandBarStripElement strip = new CommandBarStripElement();
            row.Strips.Add(strip);

            CommandBarButton addFeedButton = new CommandBarButton();
            addFeedButton.Image = Resources.feed_add;
            addFeedButton.DisplayName = "Add Feed";
            addFeedButton.Click += new EventHandler(addFeedButton_Click);

            strip.Items.Add(addFeedButton);
            strip.Items.Add(new CommandBarSeparator() { DisplayName = "commandBarSeparator1" });

            CommandBarDropDownButton showSubscriptionsButton = new CommandBarDropDownButton();
            showSubscriptionsButton.DrawText = true;
            showSubscriptionsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            showSubscriptionsButton.Text = "Show subscriptions";
            showSubscriptionsButton.DisplayName = "Show subscriptions";
            showSubscriptionsButton.Image = Resources.application_tile_horizontal;
            showSubscriptionsButton.MouseDown += new MouseEventHandler(showSubscriptionsButton_MouseDown);

            strip.Items.Add(showSubscriptionsButton);

            CommandBarDropDownButton scrollToSubscriptionButton = new CommandBarDropDownButton();
            scrollToSubscriptionButton.DrawText = true;
            scrollToSubscriptionButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            scrollToSubscriptionButton.Text = "Scroll to subscription";
            scrollToSubscriptionButton.DisplayName = "Scroll to subscription";
            scrollToSubscriptionButton.Image = Resources.application_go;
            scrollToSubscriptionButton.MouseDown += new MouseEventHandler(scrollToSubscriptionButton_MouseDown);
            strip.Items.Add(scrollToSubscriptionButton);
        }

        private void SetupPageHeaderAndListItemContextMenus(SplitPanel panel, RadListControl listControl)
        {
            listItemContextMenu = new RadContextMenu();
            RadMenuItem readFullArticleMenuItem = new RadMenuItem("Read full article");
            readFullArticleMenuItem.Tag = listControl;
            readFullArticleMenuItem.Click -= new EventHandler(readFullArticleMenuItem_Click);
            readFullArticleMenuItem.Click += new EventHandler(readFullArticleMenuItem_Click);
            listItemContextMenu.Items.Add(readFullArticleMenuItem);

            listItemContextMenu.Items.Add(new RadMenuSeparatorItem());

            RadMenuItem editFeedMenuItem = new RadMenuItem("Edit subscription");
            editFeedMenuItem.Click -= new EventHandler(editFeedMenuItem_Click);
            editFeedMenuItem.Click += new EventHandler(editFeedMenuItem_Click);
            listItemContextMenu.Items.Add(editFeedMenuItem);

            RadMenuItem unsubscribeMenuItem = new RadMenuItem("Unsubscribe");
            unsubscribeMenuItem.Tag = panel;
            unsubscribeMenuItem.Click -= new EventHandler(unsubscribeMenuItem_Click);
            unsubscribeMenuItem.Click += new EventHandler(unsubscribeMenuItem_Click);
            listItemContextMenu.Items.Add(unsubscribeMenuItem);

            pageHeaderContextMenu = new RadContextMenu();
            RadMenuItem editFeedMenuItemInPageView = new RadMenuItem("Edit subscription");
            editFeedMenuItemInPageView.Click -= new EventHandler(editFeedMenuItem_Click);
            editFeedMenuItemInPageView.Click += new EventHandler(editFeedMenuItem_Click);
            pageHeaderContextMenu.Items.Add(editFeedMenuItemInPageView);

            RadMenuItem unsubscribeMenuItemInPageView = new RadMenuItem("Unsubscribe");
            unsubscribeMenuItemInPageView.Tag = panel;
            unsubscribeMenuItemInPageView.Click -= new EventHandler(unsubscribeMenuItem_Click);
            unsubscribeMenuItemInPageView.Click += new EventHandler(unsubscribeMenuItem_Click);
            pageHeaderContextMenu.Items.Add(unsubscribeMenuItemInPageView);
        }

        private bool isValidUrl(string url)
        {
            try
            {
                WebRequest webRequest = WebRequest.Create(url);
                WebResponse webResponse;
                try
                {
                    webResponse = webRequest.GetResponse();
                }
                catch (WebException)
                {
                    RadMessageBox.Show("Url address not responding.");
                    return false;
                }
            }
            catch
            {
                RadMessageBox.Show("Invalid url address");
                return false;
            }
            return true;
        }

        private RadSplitContainer GetSplitContainer(DocumentWindow window)
        {
            foreach (Control c in window.Controls)
            {
                if (c is RadSplitContainer)
                {
                    RadSplitContainer containter = c as RadSplitContainer;
                    return containter;
                }
            }

            return null;
        }

        #endregion

        #region Events

        void RadForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                radDock1.SaveToXml(this.DockLayoutFileName);
                SaveLoadClass docWindows = new SaveLoadClass();
                docWindows.DocWindows = new DocWindow[radDock1.DockWindows.Count - 1];
                int i = 0;

                foreach (DockWindow window in radDock1.DockWindows)
                {
                    DocumentWindow dw = window as DocumentWindow;
                    if (dw != null)
                    {
                        DocWindow docWindow = new DocWindow();
                        docWindow.Text = dw.Text;

                        RadSplitContainer container = GetSplitContainer(dw);
                        int feedNum = 0;
                        docWindow.Feeds = new Feed[container.SplitPanels.Count];

                        foreach (SplitPanel panel in container.SplitPanels)
                        {
                            RadPageView pageview = panel.Controls[0] as RadPageView;
                            RadPageViewPage page = pageview.Pages[0] as RadPageViewPage;
                            RadListControl listcontrol = page.Controls[0] as RadListControl;
                            if (listcontrol != null && listcontrol.Tag != null)
                            {
                                Feed feed = new Feed();
                                feed.Link = listcontrol.Tag.ToString();
                                docWindow.Feeds[feedNum++] = feed;
                            }
                        }
                        docWindows.DocWindows[i++] = docWindow;
                    }
                }

                XmlSerializer serializer = new XmlSerializer(typeof(SaveLoadClass));
                XmlTextWriter textWriter = new XmlTextWriter(this.SaveFeedsFileName, Encoding.UTF8);
                serializer.Serialize(textWriter, docWindows);
                textWriter.Close();
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message + Environment.NewLine + "The application is now going to close. Please resolve the possible issues.");
            }
        }

        void RadForm1_Shown(object sender, EventArgs e)
        {
            string dockLayoutFile = @"dockLayout.xml";
            string saveFeedFile = @"saveFeeds.xml";
            if (File.Exists(this.DockLayoutFileName) && File.Exists(this.SaveFeedsFileName))
            {
                dockLayoutFile = this.DockLayoutFileName;
                saveFeedFile = this.SaveFeedsFileName;
            }

            if (File.Exists(dockLayoutFile) && File.Exists(saveFeedFile))
            {
                WaitingForm.ShowForm(null);
                radDock1.LoadFromXml(dockLayoutFile);

                XmlSerializer serializer = new XmlSerializer(typeof(SaveLoadClass));
                XmlTextReader textReader = new XmlTextReader(saveFeedFile);
                SaveLoadClass savedData = serializer.Deserialize(textReader) as SaveLoadClass;
                textReader.Close();

                foreach (DockWindow window in radDock1.DockWindows)
                {
                    foreach (DocWindow savedWindow in savedData.DocWindows)
                    {
                        if (window is DocumentWindow && window.Text == savedWindow.Text)
                        {
                            window.TabStripItem.ShowCloseButton = true;
                            window.CloseAction = DockWindowCloseAction.Hide;
                            radDock1.ActiveWindow = window;

                            RadSplitContainer splitContainer = new RadSplitContainer();
                            splitContainer.Dock = DockStyle.Fill;
                            splitContainer.AutoScroll = true;
                            // when the window is hidden it will not be set as RadDock's ActiveWindow
                            window.Controls.Add(splitContainer);

                            this.AddCommandBar(window as DocumentWindow);

                            if (savedWindow.Feeds != null)
                            {
                                foreach (Feed feed in savedWindow.Feeds)
                                {
                                    if (feed != null)
                                    {
                                        AddFeed(feed.Link, savedWindow.Text);
                                    }
                                }
                            }
                        }
                    }
                }
                WaitingForm.CloseForm();
            }
            else
            {
                AddDocumentWindow("Miscellaneous");
            }
        }

        void refreshButton_Click(object sender, EventArgs e)
        {
            WaitingForm.ShowForm(null);
            foreach (DockWindow window in radDock1.DockWindows)
            {
                if (window is DocumentWindow)
                {
                    DocumentWindow dw = window as DocumentWindow;
                    RadSplitContainer container = GetSplitContainer(dw);
                    foreach (SplitPanel panel in container.SplitPanels)
                    {
                        RadPageView pageView = panel.Controls[0] as RadPageView;
                        RadPageViewPage page = pageView.Pages[0] as RadPageViewPage;

                        RadListControl listControl = page.Controls[0] as RadListControl;
                        string feedLink = listControl.Tag.ToString();
                        RssFeed feed = RssFeed.Load(feedLink);
                        listControl.DataSource = feed.Channel.Items;
                    }
                }
            }
            WaitingForm.CloseForm();
        }

        void scrollToSubscriptionButton_MouseDown(object sender, MouseEventArgs e)
        {
            CommandBarDropDownButton dropDownButton = sender as CommandBarDropDownButton;
            dropDownButton.Items.Clear();

            RadSplitContainer containter = GetSplitContainer(radDock1.ActiveWindow as DocumentWindow);

            foreach (SplitPanel panel in containter.SplitPanels)
            {
                RadPageView pageView = panel.Controls[0] as RadPageView;
                RadPageViewStackElement stackElement = pageView.ViewElement as RadPageViewStackElement;
                RadPageViewLabelElement label = stackElement.Header as RadPageViewLabelElement;

                if (!panel.Collapsed)
                {
                    RadMenuItem scrollToSubscriptionItem = new RadMenuItem(label.Text);
                    scrollToSubscriptionItem.Tag = panel;
                    scrollToSubscriptionItem.Click += new EventHandler(scrollToSubscriptionItem_Click);
                    dropDownButton.Items.Add(scrollToSubscriptionItem);
                }
            }
        }

        void scrollToSubscriptionItem_Click(object sender, EventArgs e)
        {
            SplitPanel panel = ((RadMenuItem)sender).Tag as SplitPanel;
            RadSplitContainer cont = panel.SplitContainer;
            cont.ScrollControlIntoView(panel);
        }

        void showSubscriptionsButton_MouseDown(object sender, MouseEventArgs e)
        {
            RadSplitContainer containter = GetSplitContainer(radDock1.ActiveWindow as DocumentWindow);
            if (containter.SplitPanels.Count > 0)
            {
                CommandBarDropDownButton dropDownButton = sender as CommandBarDropDownButton;
                dropDownButton.Items.Clear();

                RadMenuItem showAll = new RadMenuItem("Show all");
                showAll.Click += new EventHandler(showAll_Click);
                dropDownButton.Items.Add(showAll);
                dropDownButton.Items.Add(new RadMenuSeparatorItem());

                foreach (SplitPanel panel in containter.SplitPanels)
                {
                    RadPageView pageView = panel.Controls[0] as RadPageView;
                    RadPageViewStackElement stackElement = pageView.ViewElement as RadPageViewStackElement;
                    RadPageViewLabelElement label = stackElement.Header as RadPageViewLabelElement;

                    RadMenuItem showSubscriptionsItem = new RadMenuItem(label.Text);
                    if (!panel.Collapsed)
                    {
                        showSubscriptionsItem.IsChecked = true;
                    }
                    else
                    {
                        showSubscriptionsItem.IsChecked = false;
                    }
                    showSubscriptionsItem.Click += new EventHandler(showSubscriptionsItem_Click);
                    dropDownButton.Items.Add(showSubscriptionsItem);
                }
            }
        }

        void showSubscriptionsItem_Click(object sender, EventArgs e)
        {
            RadMenuItem item = sender as RadMenuItem;
            RadSplitContainer containter = GetSplitContainer(radDock1.ActiveWindow as DocumentWindow);

            foreach (SplitPanel panel in containter.SplitPanels)
            {
                RadPageView pageView = panel.Controls[0] as RadPageView;
                RadPageViewStackElement stackElement = pageView.ViewElement as RadPageViewStackElement;
                RadPageViewLabelElement label = stackElement.Header as RadPageViewLabelElement;

                if (label.Text == ((RadMenuItem)sender).Text)
                {
                    if (item.IsChecked)
                    {
                        item.IsChecked = false;
                        panel.Collapsed = true;
                    }
                    else
                    {
                        item.IsChecked = true;
                        panel.Collapsed = false;
                    }
                }
            }
        }

        void showAll_Click(object sender, EventArgs e)
        {
            RadSplitContainer containter = GetSplitContainer(radDock1.ActiveWindow as DocumentWindow);
            foreach (SplitPanel panel in containter.SplitPanels)
            {
                panel.Collapsed = false;
            }
        }

        void radDock1_PageViewInstanceCreated(object sender, PageViewInstanceCreatedEventArgs e)
        {
            //when tabbed document is moved in a new pageview show its buttons
            RadPageViewStripElement element = e.PageViewElement as RadPageViewStripElement;
            element.StripButtons = StripViewButtons.Scroll;
            element.NewItemVisibility = StripViewNewItemVisibility.End;
            element.NewItem.Click -= new EventHandler(addCategoryButton_Click);
            element.NewItem.Click += new EventHandler(addCategoryButton_Click);
        }

        void changeTheme_Click(object sender, EventArgs e)
        {
            CommandBarButton button = sender as CommandBarButton;
            ThemeResolutionService.ApplicationThemeName = button.Text;
            ChangePageViewHeaderImage(button.Text);

        }

        void dockWindowsButton_MouseDown(object sender, MouseEventArgs e)
        {
            windowButton.Items.Clear();
            foreach (DockWindow window in radDock1.DockWindows)
            {
                RadMenuItem item = new RadMenuItem(window.Text);
                if (window.DockState != DockState.Hidden)
                {
                    item.IsChecked = true;
                }
                item.Click += new EventHandler(item_Click);
                windowButton.Items.Add(item);
            }

            RadMenuItem feedContentMenuItem;
            for (int i = 0; i < windowButton.Items.Count; i++)
            {
                if (windowButton.Items[i].Text == "Feed content")
                {
                    feedContentMenuItem = windowButton.Items[i] as RadMenuItem;
                    windowButton.Items.Remove(feedContentMenuItem);
                    windowButton.Items.Add(new RadMenuSeparatorItem());
                    windowButton.Items.Add(feedContentMenuItem);
                    break;
                }
            }
        }

        void item_Click(object sender, EventArgs e)
        {
            RadMenuItem item = sender as RadMenuItem;

            foreach (DockWindow window in radDock1.DockWindows)
            {
                if (window.Text == ((RadMenuItem)sender).Text)
                {
                    if (!item.IsChecked)
                    {
                        if (window is DocumentWindow && window.DockState != DockState.TabbedDocument)
                        {
                            window.DockState = DockState.TabbedDocument;
                            window.TabStripItem.ShowCloseButton = true;
                            radDock1.ActiveWindow = window;
                        }
                        else
                        {
                            window.DockState = DockState.Docked;
                            radDock1.ActiveWindow = window;
                        }
                    }
                    else
                    {
                        window.DockState = DockState.Hidden;
                        item.IsChecked = false;
                    }
                }
            }
        }

        void menuService_ContextMenuDisplaying(object sender, ContextMenuDisplayingEventArgs e)
        {
            if (e.MenuType == ContextMenuType.DockWindow &&
                e.DockWindow.DockTabStrip is DocumentTabStrip)
            {
                for (int i = 0; i < e.MenuItems.Count; i++)
                {
                    e.MenuItems[i].Visibility = ElementVisibility.Collapsed;
                }

                RadMenuItem addCategoryItem = new RadMenuItem("New category");
                addCategoryItem.Image = Resources.folder_feed;
                addCategoryItem.Click -= new EventHandler(addCategoryButton_Click);
                addCategoryItem.Click += new EventHandler(addCategoryButton_Click);
                e.MenuItems.Add(addCategoryItem);

                RadMenuItem renameCategoryItem = new RadMenuItem("Rename category");
                renameCategoryItem.Image = Resources.pencil;
                renameCategoryItem.Click -= new EventHandler(renameCategoryItem_Click);
                renameCategoryItem.Click += new EventHandler(renameCategoryItem_Click);
                e.MenuItems.Add(renameCategoryItem);

                RadMenuItem removeCategoryItem = new RadMenuItem("Remove category");
                removeCategoryItem.Image = Resources.cross;
                removeCategoryItem.Click -= new EventHandler(removeCategoryItem_Click);
                removeCategoryItem.Click += new EventHandler(removeCategoryItem_Click);
                e.MenuItems.Add(removeCategoryItem);

                e.MenuItems.Add(new RadMenuSeparatorItem());

                RadMenuItem addFeedItem = new RadMenuItem("Add subscription");
                addFeedItem.Image = Resources.feed_add;
                addFeedItem.Click -= new EventHandler(addFeedButton_Click);
                addFeedItem.Click += new EventHandler(addFeedButton_Click);
                e.MenuItems.Add(addFeedItem);
            }
        }

        void removeCategoryItem_Click(object sender, EventArgs e)
        {
            DocumentWindow miscellaneousWindow = null;
            foreach (DockWindow window in radDock1.DockWindows)
            {
                if (window is DocumentWindow && window.Text == "Miscellaneous")
                {
                    miscellaneousWindow = window as DocumentWindow;
                    break;
                }
            }

            if (miscellaneousWindow != null &&
                radDock1.ActiveWindow != miscellaneousWindow &&
                RadMessageBox.Show("Do you want to move all subscriptions from this category to the Miscellaneous category? If you select No, all subscriptions will be removed", "Remove category", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RadSplitContainer containerToMoveFrom = GetSplitContainer(radDock1.ActiveWindow as DocumentWindow);
                RadSplitContainer containerToMoveTo = GetSplitContainer(miscellaneousWindow);
                foreach (SplitPanel panel in containerToMoveFrom.SplitPanels)
                {
                    containerToMoveTo.SplitPanels.Add(panel);
                }
            }
            radDock1.ActiveWindow.CloseAction = DockWindowCloseAction.CloseAndDispose;
            radDock1.ActiveWindow.Close();
        }

        void renameCategoryItem_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.Text = "Rename category";
            form.Label.Text = "Please enter the new category name:";
            form.TextBox.Text = radDock1.ActiveWindow.Text;
            form.RaiseErrorOnEmptyString = true;
            form.ErrorText = "Category name is required.";
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                radDock1.ActiveWindow.Text = form.TextBox.Text;
            }
        }

        void radDock1_ActiveWindowChanged(object sender, DockWindowEventArgs e)
        {
            DocumentWindow window = e.DockWindow as DocumentWindow;
            if (window != null)
            {
                lastUsedDocumentWindow = window;
            }
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.Text = "Adding category";
            form.Label.Text = "Please enter category name:";
            form.RaiseErrorOnEmptyString = true;
            form.ErrorText = "Category name is required.";
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                AddDocumentWindow(form.TextBox.Text);
            }
        }

        private void addFeedButton_Click(object sender, EventArgs e)
        {
            if (!(radDock1.ActiveWindow is DocumentWindow))
            {
                if (lastUsedDocumentWindow != null)
                {
                    radDock1.ActiveWindow = lastUsedDocumentWindow;

                }
            }
            if (!(radDock1.ActiveWindow is DocumentWindow))
            {
                RadMessageBox.Show("Missing categories.");
                return;
            }

            AddForm form = new AddForm();
            form.Text = "Adding Rss";
            form.Label.Text = "Please enter RSS Url:";
            form.RaiseErrorOnEmptyString = true;
            form.ErrorText = "RSS Url is required.";

            if (form.ShowDialog(this) == DialogResult.OK && isValidUrl(form.TextBox.Text))
            {
                WaitingForm.ShowForm(null);
                AddFeed(form.TextBox.Text);
                WaitingForm.CloseForm();
            }
        }

        void listControl_VisualItemFormatting(object sender, VisualItemFormattingEventArgs args)
        {
            RadListDataItem item = args.VisualItem.Data;
            if (item != null)
            {
                if (Convert.ToBoolean(item.Tag))
                {
                    //the item is read, mark it
                    RssItemElement el = args.VisualItem as RssItemElement;
                    el.HeaderElement.Font = markAsReadFont;
                }
                else
                {
                    //reset setting 
                    RssItemElement el = args.VisualItem as RssItemElement;
                    el.HeaderElement.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local);
                }
            }
        }

        void unsubscribeMenuItem_Click(object sender, EventArgs e)
        {
            RadMenuItem item = sender as RadMenuItem;
            RadSplitContainer container = GetSplitContainer(radDock1.ActiveWindow as DocumentWindow);
            container.SplitPanels.Remove(item.Tag as SplitPanel);
        }

        void readFullArticleMenuItem_Click(object sender, EventArgs e)
        {
            RadListControl listControl = ((RadMenuItem)sender).Tag as RadListControl;
            BrowserForm browserForm = new BrowserForm();

            browserForm.WebBrowser.Navigate(((RssItem)listControl.SelectedItem.Value).Link.ToString());
            browserForm.Show();

        }

        void listControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RadListControl listControl = sender as RadListControl;
                RadPageViewPage page = listControl.Parent as RadPageViewPage;
                RadPageViewStackElement strip = ((RadPageView)page.Owner).ViewElement as RadPageViewStackElement;
                pageHeader = strip.Header;

                RadItem clickedItem = listControl.ElementTree.GetElementAtPoint(e.Location) as RadItem;
                RssItemElement itemToSelect;
                if (!(clickedItem is RssItemElement))
                {
                    itemToSelect = clickedItem.FindAncestor<RssItemElement>();
                }
                else
                {
                    itemToSelect = clickedItem as RssItemElement;
                }
                listControl.SelectedItem = itemToSelect.Data;
                listItemContextMenu.Show(MousePosition);
            }
        }

        void listControl_DoubleClick(object sender, EventArgs e)
        {
            RadListControl listControl = sender as RadListControl;
            BrowserForm browserForm = new BrowserForm();
            browserForm.WebBrowser.Navigate(((RssItem)listControl.SelectedItem.Value).Link.ToString());
            browserForm.Show();
        }

        void closePageButton_Click(object sender, EventArgs e)
        {
            SplitPanel panelToClose = (sender as RadButtonElement).Tag as SplitPanel;
            //TODO visibility is not working
            panelToClose.Collapsed = true;
        }

        void editFeedMenuItem_Click(object sender, EventArgs e)
        {
            //change category logic
            ChangeCategoryForm form = new ChangeCategoryForm();
            form.NameTextBox.Text = pageHeader.Text;
            foreach (DockWindow dw in radDock1.DockWindows)
            {
                if (dw is DocumentWindow && dw != radDock1.ActiveWindow)
                {
                    RadListDataItem item = new RadListDataItem();
                    item.Text = dw.Text;
                    item.Tag = dw;
                    form.RadDropDownList.Items.Add(item);
                }
            }
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                if (form.CheckBox.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                {
                    RadSplitContainer container = AddDocumentWindow(form.NewCategoryNameTextBox.Text);

                    SplitPanel currentFeedSplitPanel = pageHeader.ElementTree.Control.Parent as SplitPanel;
                    container.SplitPanels.Add(currentFeedSplitPanel);
                }
                else if (form.RadDropDownList.SelectedItem != null)
                {
                    DocumentWindow windowToMoveTo = form.RadDropDownList.SelectedItem.Tag as DocumentWindow;
                    SplitPanel currentFeedSplitPanel = pageHeader.ElementTree.Control.Parent as SplitPanel;
                    RadSplitContainer containter = GetSplitContainer(windowToMoveTo);

                    containter.SplitPanels.Add(currentFeedSplitPanel);
                    radDock1.ActiveWindow = windowToMoveTo;
                }

                if (!(string.IsNullOrEmpty(form.NameTextBox.Text)))
                {
                    pageHeader.Text = form.NameTextBox.Text;
                }
            }
        }

        void Header_MouseDown(object sender, MouseEventArgs e)
        {
            //assign the pageHeader used in list items context menu
            if (e.Button == MouseButtons.Right)
            {
                pageHeaderContextMenu.Show(MousePosition.X, MousePosition.Y);
                pageHeader = sender as RadPageViewLabelElement;
            }
        }

        void listControl_CreatingVisualListItem(object sender, CreatingVisualListItemEventArgs args)
        {
            args.VisualItem = new RssItemElement();
        }

        void listControl_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            //assign the web browser content
            RadListElement item = sender as RadListElement;
            RadListControl listControl = item.ElementTree.Control as RadListControl;
            if (e.Position > -1)
            {
                webBrowser1.DocumentText = ((RssItem)listControl.Items[e.Position].Value).Description;
                radLabel1.Text = ((RssItem)listControl.Items[e.Position].Value).Title;
                webBrowser1.Tag = listControl;
            }

            //assign the pageHeader used in list items context menu
            RadPageView pageView = listControl.Parent.Parent.Parent as RadPageView;
            if (pageView != null)
            {
                RadPageViewStripElement element = pageView.ViewElement as RadPageViewStripElement;
                pageHeader = element.Header;
            }

            //mark the item as read
            if (e.Position > -1)
            {
                RadListDataItem listItem = listControl.Items[e.Position] as RadListDataItem;
                if (listItem != null)
                {
                    //mark the item as read
                    listItem.Tag = true;
                }
            }
        }

        private void scrollToPanelButon_Click(object sender, EventArgs e)
        {
            RadListControl listControl = webBrowser1.Tag as RadListControl;
            if (listControl == null || listControl.SelectedItem == null)
            {
                return;
            }

            SplitPanel panel = listControl.Parent.Parent.Parent as SplitPanel;
            RadSplitContainer cont = panel.SplitContainer;
            foreach (DockWindow window in radDock1.DockWindows)
            {
                DocumentWindow dw = window as DocumentWindow;
                if (dw != null)
                {
                    RadSplitContainer container = GetSplitContainer(dw);
                    if (cont == container)
                    {
                        radDock1.ActiveWindow = dw;
                        cont.ScrollControlIntoView(panel);
                    }
                }
            }
        }

        private void openInBrowserButton_Click(object sender, EventArgs e)
        {
            RadListControl listControl = webBrowser1.Tag as RadListControl;
            if (listControl == null || listControl.SelectedItem == null)
            {
                RadMessageBox.Show("Please select feed to display in browser");
                return;
            }
            BrowserForm browserForm = new BrowserForm();
            browserForm.WebBrowser.Navigate(((RssItem)listControl.SelectedItem.Value).Link.ToString());
            browserForm.Show();
        }

        #endregion

    }
}
