using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using BookShelf.Properties;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using System.Xml.Serialization;
using System.IO;
using System.Drawing.Drawing2D;
using BookShelf.Custom_Elements;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.RadControlSpy;

namespace BookShelf
{
    public partial class MainForm : RadForm
    {
        #region Fields

        bool updatingDropDownList = false;
        bool updatingToggleState = false;
        bool zoomHandled = false;
        bool waiting = false;

        RadWaitingBar waitingBar;
        StackLayoutPanel buttonsPanel;
        CustomShape elementShape = new CustomShape();
        RadImageShape imageShape = new RadImageShape();
        RadButtonElement searchButtonElement;

        #endregion

        #region Initialization

        public MainForm()
        {
            //Settings.Default.UseCache = false;

            InitializeComponent();

            BookShelfApp.Instance.Form = this;

            elementShape.AsString = "20,20,200,100:20,20,False,0,0,0,0,0:220,20,False,0,0,0,0,0:220,120,False,0,0,0,0,0:20,120,False,0,0,0,0,0:45.29914,68.46154,False,0,0,0,0,0:";
            imageShape.Image = Resources.bg_pattern;
            imageShape.PaintMode = ImagePaintMode.StretchYTileX;

            InitializeForm();
            InitializeUpperPanel();
            InitializeListView();
            InitializePanorama();
            InitializeBottomPanel();
            InitializeButtonsAndLabels();
            InitializeBottomButtons();
            InitializeSearchPanel();
            InitializeWaitingBar();

            SubscribeToEvents();
        }

        void InitializeForm()
        {
            this.FormBehavior = new MyFormBehavior(this, true);
            this.FormElement.Border.ForeColor = Color.FromArgb(217, 71, 0);
            this.FormElement.TitleBar.MaxSize = new Size(0, 1);
            this.Text = "";
        }

        void InitializeUpperPanel()
        {
            LightVisualElement el = new LightVisualElement();
            el.BackgroundShape = imageShape;
            upperPanel.PanelElement.Children.Add(el);
            upperPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
        }

        void InitializeListView()
        {
            radListView1.ListViewElement.DrawFill = false;
            radListView1.ListViewElement.DrawBorder = false;
            radListView1.ListViewElement.BackgroundShape = imageShape;
            radListView1.ListViewElement.Margin = new System.Windows.Forms.Padding(0, 0, 0, -1);
            radListView1.ViewType = ListViewType.IconsView;
            radListView1.AllowArbitraryItemWidth = true;
            radListView1.Font = BookShelfApp.SegoeUI25Bold;
            radListView1.AllowEdit = false;
            radListView1.ListViewElement.Padding = new System.Windows.Forms.Padding(105, 0, 0, 0);
            radListView1.ItemSpacing = 10;
            radListView1.Visible = false;
        }

        void InitializePanorama()
        {
            radPanorama1.EnableZooming = false;
            radPanorama1.PanoramaElement.DrawFill = false;
            radPanorama1.BackgroundImage = null;
            radPanorama1.PanoramaElement.BackgroundImagePrimitive.Visibility = ElementVisibility.Collapsed;
            radPanorama1.PanoramaElement.BackgroundShape = imageShape;

            radPanorama1.ScrollBarThickness = 0;
            radPanorama1.ShowGroups = true;
            radPanorama1.AllowDragDrop = false;

            radPanorama1.PanoramaElement.Margin = new System.Windows.Forms.Padding(0, 0, 0, -1);

            AddButtonsPanelToPanorama();
            buttonsPanel.Visibility = ElementVisibility.Collapsed;
        }

        void InitializeBottomPanel()
        {
            RadImageShape shape2 = new RadImageShape();
            shape2.Image = Resources.app_bar_bg;
            shape2.PaintMode = ImagePaintMode.StretchYTileX;

            LightVisualElement el2 = new LightVisualElement();
            el2.BackgroundShape = shape2;
            bottomPanel.PanelElement.Children.Add(el2);
            bottomPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            bottomPanel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);

            BottomPanel.Visible = false;
        }

        void InitializeButtonsAndLabels()
        {
            //search button 
            searchBtn.Image = Resources.search_btn;
            searchBtn.ButtonElement.ButtonFillElement.Visibility = ElementVisibility.Collapsed;
            searchBtn.BackColor = Color.Transparent;
            searchBtn.ButtonElement.ShowBorder = false;
            searchBtn.Text = "";
            searchBtn.Visible = false;

            //labels
            selectCategoryLabel.BackColor = Color.Transparent;
            logoLabel.BackColor = Color.Transparent;
            bookShelfLabel.BackColor = Color.Transparent;
            searchForLabel.BackColor = Color.Transparent;

            radDropDownList1.DropDownStyle = RadDropDownStyle.DropDownList;
            radDropDownList1.ListElement.Font = BookShelfApp.SegoeUI12;
            radDropDownList1.AutoSizeItems = true;
            radDropDownList1.DropDownMinSize = new Size(0, 252);
            radDropDownList1.BackColor = Color.White;
            ((BorderPrimitive)radDropDownList1.DropDownListElement.Children[0]).Visibility = ElementVisibility.Collapsed;
            ((ImagePrimitive)radDropDownList1.DropDownListElement.ArrowButton.Children[4]).Image = Resources.arrow_drop_down;
            radDropDownList1.DropDownListElement.ArrowButton.Arrow.Visibility = ElementVisibility.Collapsed;
            radDropDownList1.DropDownListElement.ArrowButton.Border.Visibility = ElementVisibility.Collapsed;
            radDropDownList1.DropDownListElement.ArrowButton.Fill.Visibility = ElementVisibility.Collapsed;
            radDropDownList1.Visible = false;
            selectCategoryLabel.Visible = false;
        }

        void InitializeBottomButtons()
        {
            backBtn.ButtonElement.ButtonFillElement.Visibility = ElementVisibility.Collapsed;
            backBtn.BackColor = Color.Transparent;
            backBtn.ButtonElement.BorderElement.Visibility = ElementVisibility.Collapsed;
            backBtn.ButtonElement.ForeColor = Color.White;
            backBtn.ButtonElement.TextElement.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            backBtn.SetImages(Resources.back, Resources.back_pressed, Resources.back_hover);

            homeBtn.BackColor = Color.Transparent;
            homeBtn.ButtonElement.ButtonFillElement.Visibility = ElementVisibility.Collapsed;
            homeBtn.ButtonElement.BorderElement.Visibility = ElementVisibility.Collapsed;
            homeBtn.ButtonElement.ForeColor = Color.White;
            homeBtn.ButtonElement.TextElement.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            homeBtn.SetImages(Resources.home, Resources.home_pressed, Resources.home_hover);

            allCategoriesBtn.BackColor = Color.Transparent;
            allCategoriesBtn.ButtonElement.ButtonFillElement.Visibility = ElementVisibility.Collapsed;
            allCategoriesBtn.ButtonElement.BorderElement.Visibility = ElementVisibility.Collapsed;
            allCategoriesBtn.ButtonElement.ForeColor = Color.White;
            allCategoriesBtn.ButtonElement.TextElement.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            allCategoriesBtn.SetImages(Resources.all_categories, Resources.all_categories_pressed, Resources.all_categories_hover);

            showAllItemsButton.BackColor = Color.Transparent;
            showAllItemsButton.ButtonElement.ButtonFillElement.Visibility = ElementVisibility.Collapsed;
            showAllItemsButton.ButtonElement.BorderElement.Visibility = ElementVisibility.Collapsed;
            showAllItemsButton.ButtonElement.Margin = new Padding(0, 20, 0, 0);
        }

        void InitializeSearchPanel()
        {
            LightVisualElement searchPanelElement = new LightVisualElement();
            searchPanelElement.BackgroundShape = imageShape;
            searchPanel.PanelElement.Children.Add(searchPanelElement);
            searchPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            searchPanel.Visible = false;

            searchTextBox.TextBoxElement.Border.Visibility = ElementVisibility.Collapsed;

            AddButtonToTextBox();
        }

        void InitializeWaitingBar()
        {
            waitingBar = new RadWaitingBar();
            waitingBar.Size = new Size(300, 8);
            this.Controls.Add(waitingBar);
            waitingBar.Visible = false;

            waitingBar.WaitingBarElement.WaitingIndicators[0].GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            waitingBar.WaitingBarElement.WaitingIndicators[0].BackColor = Color.FromArgb(217, 71, 0);
            waitingBar.WaitingBarElement.WaitingIndicators[1].GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            waitingBar.WaitingBarElement.WaitingIndicators[1].BackColor = Color.FromArgb(217, 71, 0);

            waitingBar.WaitingBarElement.BorderWidth = 0;
            waitingBar.WaitingBarElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            waitingBar.WaitingBarElement.BackColor = Color.White;
            waitingBar.BackColor = Color.White;

            waitingBar.WaitingSpeed = 70;
        }

        void SubscribeToEvents()
        {
            radPanorama1.ZoomGesture += new ZoomGestureEventHandler(radPanorama1_ZoomGesture);
            radPanorama1.PanoramaElement.ScrollBar.ValueChanged += new EventHandler(ScrollBar_ValueChanged);
            radPanorama1.PanoramaElement.GroupLayout.ChildrenChanged += new ChildrenChangedEventHandler(GroupLayout_ChildrenChanged);

            radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDropDownList1_SelectedIndexChanged);

            radListView1.VisualItemFormatting += new ListViewVisualItemEventHandler(radListView1_VisualItemFormatting);
            radListView1.ListViewElement.ItemMouseDown += new ListViewItemMouseEventHandler(ListViewElement_ItemMouseDown);
            radListView1.ZoomGesture += new ZoomGestureEventHandler(radListView1_ZoomGesture);

            showAllItemsButton.Click += new EventHandler(showAllItemsButton_Click);
            backBtn.Click += new EventHandler(backBtn_Click);
            homeBtn.Click += new EventHandler(default_Click);
            allCategoriesBtn.Click += new EventHandler(allCategoriesBtn_Click);
            logoLabel.Click += new EventHandler(default_Click);
            bookShelfLabel.Click += new EventHandler(default_Click);

            searchTextBox.KeyDown += new KeyEventHandler(searchTextBox_KeyDown);
            this.SizeChanged += MainForm_SizeChanged;
        }

        void AddButtonToTextBox()
        {
            RadButtonElement searchButton = new RadButtonElement();
            searchButton.Image = Resources.search_icon;
            searchButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            searchButton.ButtonFillElement.BackColor = Color.Transparent;
            searchButton.ButtonFillElement.BackColor2 = Color.Transparent;
            searchButton.ButtonFillElement.BackColor3 = Color.Transparent;
            searchButton.ButtonFillElement.BackColor4 = Color.Transparent;
            searchButton.BorderElement.Visibility = ElementVisibility.Collapsed;
            searchButton.Click += new EventHandler(searchButton_Click);

            RadTextBoxItem textBoxItem = this.searchTextBox.TextBoxElement.TextBoxItem;
            textBoxItem.Alignment = ContentAlignment.MiddleLeft;

            this.searchTextBox.TextBoxElement.Children.Remove(textBoxItem);

            DockLayoutPanel.SetDock(textBoxItem, Telerik.WinControls.Layouts.Dock.Left);
            DockLayoutPanel.SetDock(searchButton, Telerik.WinControls.Layouts.Dock.Right);

            DockLayoutPanel dockLayoutPanel = new DockLayoutPanel();

            dockLayoutPanel.Children.Add(searchButton);
            dockLayoutPanel.Children.Add(textBoxItem);

            this.searchTextBox.TextBoxElement.Children.Add(dockLayoutPanel);

            this.searchButtonElement = searchButton;
        }

        void AddButtonsPanelToPanorama()
        {
            buttonsPanel = new StackLayoutPanel();
            buttonsPanel.Orientation = Orientation.Vertical;
            buttonsPanel.Margin = new System.Windows.Forms.Padding(75, 54, 60, 0);
            buttonsPanel.StretchHorizontally = false;
            buttonsPanel.MinSize = new System.Drawing.Size(150, 0);

            RadToggleButtonElement otherButton = new RadToggleButtonElement(); otherButton.Text = "#";
            RadToggleButtonElement aeButton = new RadToggleButtonElement(); aeButton.Text = "A-E";
            RadToggleButtonElement gkButton = new RadToggleButtonElement(); gkButton.Text = "F-J";
            RadToggleButtonElement lpButton = new RadToggleButtonElement(); lpButton.Text = "K-O";
            RadToggleButtonElement quButton = new RadToggleButtonElement(); quButton.Text = "P-T";
            RadToggleButtonElement vzButton = new RadToggleButtonElement(); vzButton.Text = "U-Z";

            buttonsPanel.Children.Add(otherButton);
            buttonsPanel.Children.Add(aeButton);
            buttonsPanel.Children.Add(gkButton);
            buttonsPanel.Children.Add(lpButton);
            buttonsPanel.Children.Add(quButton);
            buttonsPanel.Children.Add(vzButton);

            foreach (RadToggleButtonElement el in buttonsPanel.Children)
            {
                el.StretchHorizontally = false;
                el.Alignment = ContentAlignment.MiddleRight;
                el.MinSize = new Size(120, 50);
                el.BorderElement.Width = 3;
                el.ButtonFillElement.GradientStyle = GradientStyles.Solid;
                el.TextAlignment = ContentAlignment.BottomLeft;
                el.Font = BookShelfApp.SegoeUI22Bold;
                el.Margin = new Padding(0, 0, 0, 10);
                el.ForeColor = Color.Black;
                el.Shape = null;
                el.ToggleStateChanged += new StateChangedEventHandler(toggleButtons_ToggleStateChanged);
            }

            radPanorama1.PanoramaElement.Children.Add(buttonsPanel);
        }

        #endregion

        #region Properties

        public PageID CurrentScreen
        {
            get
            {
                return BookShelfApp.Instance.CurrentPageID;
            }
            set
            {
                BookShelfApp.Instance.CurrentPageID = value;
            }
        }

        public RadPanorama Panorama
        {
            get { return this.radPanorama1; }
        }

        public RadTextBox SearchTextBox
        {
            get { return this.searchTextBox; }
        }

        public RadButton SearchButton
        {
            get { return this.searchBtn; }
        }

        public RadLabel SearchForLabel
        {
            get { return searchForLabel; }
        }

        public RadButtonElement SearchButtonElement
        {
            get { return searchButtonElement; }
        }

        public RadButton ShowAllItemsButton
        {
            get { return this.showAllItemsButton; }
        }

        public RadLabel Logo
        {
            get { return this.logoLabel; }
        }

        public RadLabel BookShelfLabel
        {
            get { return bookShelfLabel; }
        }

        public RadListView ListView
        {
            get { return this.radListView1; }
        }

        public RadDropDownList DropDownList
        {
            get { return this.radDropDownList1; }
        }

        public RadPanel SearchPanel
        {
            get { return this.searchPanel; }
        }

        public RadPanel BottomPanel
        {
            get { return this.bottomPanel; }
        }

        public StackLayoutPanel ButtonsPanelElement
        {
            get { return this.buttonsPanel; }
        }

        public RadWaitingBar WaitingBar
        {
            get { return this.waitingBar; }
        }

        #endregion

        #region Methods

        public void StartWaiting()
        {
            if (waiting)
            {
                return;
            }

            waiting = true;
            BottomPanel.Visible = false;

            waitingBar.Location = new Point((this.Width - waitingBar.Width) / 2, (this.Height - waitingBar.Height) / 2);
            waitingBar.Visible = true;
            waitingBar.BringToFront();
            waitingBar.StartWaiting();
        }

        public void StopWaiting()
        {
            if (!waiting)
            {
                return;
            }

            waiting = false;

            waitingBar.StopWaiting();
            waitingBar.Visible = false;

            BottomPanel.Visible = true;
        }

        public void UpdateDropDownListSelectedItem(string category)
        {
            foreach (RadListDataItem item in BookShelfApp.Instance.Form.DropDownList.Items)
            {
                if (item.Text.ToLower() == category.ToLower())
                {
                    updatingDropDownList = true;
                    item.Selected = true;
                    updatingDropDownList = false;
                    return;
                }
            }
        }

        #endregion

        #region Event handlers

        void MainForm_SizeChanged(object sender, EventArgs e)
        {
            int offset = (radPanorama1.PanoramaElement.Size.Height - (int)radPanorama1.PanoramaElement.GroupLayout.Size.Height) /2 ;
            radPanorama1.Padding = new Padding(0, offset, 0, 0);
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            StopWaiting();
            base.OnClosing(e);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            
            this.RootElement.Shape = new RoundRectShape(0);
            this.FormElement.Border.Shape = new RoundRectShape(0);

            StartWaiting();

            BookShelfApp.Instance.CategoryListLoaded += new EventHandler(CategoryListLoaded);
            BookShelfApp.Instance.LoadComplete += new EventHandler(DataLoadComplete);

            BookShelfApp.Instance.LoadData();
        }

        void CategoryListLoaded(object sender, EventArgs empty)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                radDropDownList1.Items.Add("None");
                foreach (Category c in BookShelfApp.Instance.Categories.Values)
                {
                    RadListDataItem listDataItem = new RadListDataItem(c.Name);
                    listDataItem.Value = c;
                    radDropDownList1.Items.Add(listDataItem);

                    ListViewDataItem item = new ListViewDataItem(c.Name);
                    item.Tag = c;
                    radListView1.Items.Add(item);
                }
            }));
        }

        void DataLoadComplete(object sender, EventArgs empty)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                StopWaiting();

                radDropDownList1.Visible = true;
                selectCategoryLabel.Visible = true;
                searchBtn.Visible = true;
                BottomPanel.Visible = true;

                CurrentScreen = PageID.Main;
                BookShelfApp.Instance.Pages[PageID.Main].SetupPage(this);
            }));
        }

        void default_Click(object sender, EventArgs e)
        {
            if (!waiting)
            {
                CurrentScreen = PageID.Main;
            }
        }

        void searchButton_Click(object sender, EventArgs e)
        {
            if (!waiting)
            {
                PerformSearchAndFillItems();
            }
        }

        void searchBtn_Click(object sender, EventArgs e)
        {
            if (waiting)
            {
                return;
            }

            if (CurrentScreen != PageID.Search)
            {
                CurrentScreen = PageID.Search;
            }
            else
            {
                BookShelfApp.Instance.GoBack();
            }
        }

        void allCategoriesBtn_Click(object sender, EventArgs e)
        {
            if (waiting)
            {
                return;
            }

            CurrentScreen = PageID.AllCategories;
        }

        void backBtn_Click(object sender, EventArgs e)
        {
            if (waiting)
            {
                return;
            }

            BookShelfApp.Instance.GoBack();
        }

        void showAllItemsButton_Click(object sender, EventArgs e)
        {
            if (waiting)
            {
                return;
            }

            CurrentScreen = PageID.AllCategories;
        }

        void radListView1_ZoomGesture(object sender, ZoomGestureEventArgs e)
        {
            if (waiting)
            {
                return;
            }

            if (CurrentScreen == PageID.AllCategoriesZoomedOut && e.ZoomFactor > 1)
            {
                CurrentScreen = PageID.AllCategories;
            }
        }

        void radPanorama1_ZoomGesture(object sender, ZoomGestureEventArgs e)
        {
            if (waiting)
            {
                return;
            }

            if (e.IsBegin)
            {
                zoomHandled = false;
            }

            if (zoomHandled)
            {
                return;
            }

            if (e.ZoomFactor < 1)
            {
                //zoom out
                if (CurrentScreen == PageID.AllCategories ||
                    CurrentScreen == PageID.SingleCategoryZommedOut ||
                    CurrentScreen == PageID.SingleCategory)
                {
                    CurrentScreen = PageID.AllCategoriesZoomedOut;
                    zoomHandled = true;
                }
                else if (CurrentScreen == PageID.Details)
                {
                    BookShelfApp.Instance.CurrentCategory = (Category)radDropDownList1.SelectedValue;
                    CurrentScreen = PageID.SingleCategory;
                    zoomHandled = true;
                }
            }
            else if (e.ZoomFactor > 1)
            {
                //zoom in
                if (CurrentScreen == PageID.AllCategoriesZoomedOut)
                {
                    CurrentScreen = PageID.AllCategories;
                    zoomHandled = true;
                }
                else if (CurrentScreen == PageID.SingleCategory)
                {
                    AllCategoriesGroupElement group = radPanorama1.ElementTree.GetElementAtPoint(e.Location) as AllCategoriesGroupElement;
                    if (group != null)
                    {
                        //TODO ShowSingleCategoryZoomedOut(group);
                        //CurrentScreen = Screens.ScreenSingleCategoryZommedOut;
                        zoomHandled = true;
                    }
                }
            }
            e.Handled = true;
        }

        void ListViewElement_ItemMouseDown(object sender, ListViewItemMouseEventArgs e)
        {
            if (waiting)
            {
                return;
            }

            BookShelfApp.Instance.CurrentCategory = (Category)e.Item.Tag;
            CurrentScreen = PageID.SingleCategory;
        }

        void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (waiting)
            {
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                PerformSearchAndFillItems();
            }
        }

        void GroupLayout_ChildrenChanged(object sender, ChildrenChangedEventArgs e)
        {
            if (e.Child is TileGroupElement)
            {
                if (CurrentScreen == PageID.SingleCategoryZommedOut)
                {
                    radPanorama1.Groups[0].Margin = new Padding(280, 0, 0, 0);
                }
                else
                {
                    radPanorama1.Groups[0].Margin = new Padding(95, 0, 60, 0);
                }
            }
        }

        void toggleButtons_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            UpdateToggleButtons(sender as RadToggleButtonElement, args.ToggleState);
        }

        void ScrollBar_ValueChanged(object sender, EventArgs e)
        {
            //scroll the buttons panel together with the tiles.
            buttonsPanel.PositionOffset = new SizeF(-radPanorama1.PanoramaElement.ScrollBar.Value, 0);
        }

        void radListView1_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            e.VisualItem.BackColor = BookShelfApp.Instance.GetColor(e.VisualItem.Data.Text);
            e.VisualItem.GradientStyle = GradientStyles.Solid;
            e.VisualItem.Text = e.VisualItem.Text.ToUpper();
        }

        void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (!updatingDropDownList && e.Position >= 0)
            {
                BookShelfApp.Instance.CurrentCategory = (Category)radDropDownList1.Items[e.Position].Value;
                CurrentScreen = PageID.SingleCategory;
            }
        }

        #endregion

        #region Implementation

        void PerformSearchAndFillItems()
        {
            radPanorama1.Items.Clear();

            radPanorama1.PanoramaElement.SuspendLayout(true);
            StartWaiting();
            string matchString = searchTextBox.Text.ToLower();
            foreach (Book book in BookShelfApp.Instance.Books.Values)
            {
                if (book.Title.ToLower().Contains(matchString))
                {
                    HorizontalTileElement tile = new HorizontalTileElement(book, 80);
                    tile.Row = radPanorama1.Items.Count % radPanorama1.RowsCount;
                    tile.Column = radPanorama1.Items.Count / radPanorama1.RowsCount;
                    radPanorama1.Items.Add(tile);
                    if (radPanorama1.Items.Count > 100)
                    {
                        break;
                    }
                }
            }
            radPanorama1.PanoramaElement.ResumeLayout(true, true);
            StopWaiting();
        }

        void EnableButton(char firstLetter)
        {
            foreach (RadToggleButtonElement btn in buttonsPanel.Children)
            {
                if (btn.Text == "#")
                {
                    if (!char.IsLetter(firstLetter))
                    {
                        btn.Enabled = true;
                        btn.ButtonFillElement.Visibility = ElementVisibility.Visible;
                        btn.ButtonFillElement.BackColor = BookShelfApp.Instance.GetColor(radDropDownList1.SelectedItem.Text);
                        btn.ForeColor = Color.Black;
                        return;

                    }
                }
                else if (char.ToLower(firstLetter) >= char.ToLower(btn.Text[0]) && char.ToLower(firstLetter) <= char.ToLower(btn.Text[2]))
                {
                    btn.Enabled = true;
                    btn.ButtonFillElement.Visibility = ElementVisibility.Visible;
                    btn.ButtonFillElement.BackColor = BookShelfApp.Instance.GetColor(radDropDownList1.SelectedItem.Text);
                    btn.ForeColor = Color.Black;
                    return;

                }
            }
        }

        void UpdateToggleButtons(RadToggleButtonElement element, ToggleState state)
        {
            // REFACTOR THIS !!!!

            if (updatingToggleState)
            {
                return;
            }

            if (state == ToggleState.On)
            {
                element.MinSize = new System.Drawing.Size(150, 50);
                element.TextElement.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
                element.Shape = elementShape;

                AllCategoriesGroupElement group = radPanorama1.Groups[0] as AllCategoriesGroupElement;
                group.Items.Clear();
                radPanorama1.PanoramaElement.SuspendLayout(true);

                Category cat = BookShelfApp.Instance.Categories[group.Text];
                foreach (Book book in cat.Books)
                {
                    HorizontalTileElement tile = new HorizontalTileElement(book, 80);
                    tile.Row = group.Items.Count % group.RowsCount;
                    tile.Column = group.Items.Count / group.RowsCount;

                    if (element.Text == "#")
                    {
                        if (!char.IsLetter(book.Title[0]))
                        {
                            group.Items.Add(tile);
                        }
                    }
                    else if (char.ToLower(book.Title[0]) >= char.ToLower(element.Text[0])
                        && char.ToLower(book.Title[0]) <= char.ToLower(element.Text[2]))
                    {
                        group.Items.Add(tile);
                    }

                    //enable buttons
                    EnableButton(book.Title[0]);

                }
                radPanorama1.PanoramaElement.ResumeLayout(true, true);
            }

            foreach (RadToggleButtonElement tb in buttonsPanel.Children)
            {
                if (tb != element)
                {
                    updatingToggleState = true;
                    tb.ToggleState = ToggleState.Off;
                    updatingToggleState = false;
                    tb.MinSize = new Size(120, 50);
                    tb.TextElement.Margin = new System.Windows.Forms.Padding(0);
                    tb.Shape = null;
                }
            }
        }

        #endregion
    }
}
