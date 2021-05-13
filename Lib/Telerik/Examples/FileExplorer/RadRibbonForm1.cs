using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using FileExplorer.Properties;
using Telerik.WinControls.Data;
using Telerik.WinControls.Layouts;
using System.Threading;

namespace FileExplorer
{
    public partial class RadRibbonForm1 : Telerik.WinControls.UI.RadRibbonForm
    {
        #region Fields

        Stack<RadTreeNode> backCollection = new Stack<RadTreeNode>();
        Stack<RadTreeNode> forwardCollection = new Stack<RadTreeNode>();
        bool navigateOperationInProgress = false;
        CustomButton searchButton;
        AutoCompleteStringCollection autoCompleteDataSource = new AutoCompleteStringCollection();
        CustomToggleButton detailsToggleButton;
        CustomToggleButton iconsToggleButton;
        List<ListViewDataItem> copySource = null;
        enum IconSize { Small, Medium, Large, ExtraLarge }
        IconSize iconSize = IconSize.Medium;

        #endregion

        #region Constructor

        public RadRibbonForm1()
        {
            InitializeComponent();

            ThemeResolutionService.ApplicationThemeName = "TelerikMetro";

            SetupListView();

            this.AllowAero = false;
            radPanel1.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            splitPanel1.BorderStyle = BorderStyle.None;
            splitPanel2.BorderStyle = BorderStyle.None;

            Telerik.WinControls.UI.InnerItem item = RibbonBar.RibbonBarElement.QuickAccessToolBar.InnerItem;
            item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

            radTreeView1.LazyMode = false;
            AddNodes();
            radTreeView1.SelectedNodeChanged += new RadTreeView.RadTreeViewEventHandler(radTreeView1_SelectedNodeChanged);
            radTreeView1.NodesNeeded += new NodesNeededEventHandler(radTreeView1_NodesNeeded);
            radTreeView1.KeyDown += new KeyEventHandler(radTreeView1_KeyDown);
            radTreeView1.NodeFormatting += new TreeNodeFormattingEventHandler(radTreeView1_NodeFormatting);
            radTreeView1.SelectedNode = radTreeView1.Nodes["My Computer"];

            radBreadCrumb1.DefaultTreeView = radTreeView1;

            AddButtonToTextBox();
            radTextBox1.TextChanged += new EventHandler(radTextBox1_TextChanged);
            radTextBox1.AutoCompleteCustomSource = autoCompleteDataSource;

            AddButtonsToStatusStrip();

            historyButton.ShowArrow = false;

            pasteAsShortcutMenuItem.Click += new EventHandler(pasteAsShortcutMenuItem_Click);
            pasteMenuItem.Click += new EventHandler(pasteMenuItem_Click);

            deleteSelectionMenuItem.Click += new EventHandler(deleteSelectionMenuItem_Click);
            deleteAllMenuItem.Click += new EventHandler(deleteAllMenuItem_Click);

            cutButton.Click += new EventHandler(copyButton_Click);

            sortByNameMenuItem.Click += new EventHandler(sortBy_Click);
            sortByDateModifiedMenuItem.Click += new EventHandler(sortBy_Click);
            sortByTypeMenuItem.Click += new EventHandler(sortBy_Click);
            sortBySizeMenuItem.Click += new EventHandler(sortBy_Click);

            office2010BlackButton.Click += new EventHandler(changeThemes);
            office2010BlueButton.Click += new EventHandler(changeThemes);
            office2010SilverButton.Click += new EventHandler(changeThemes);
            controlDefaultButton.Click += new EventHandler(changeThemes);
            telerikMetroButton.Click += new EventHandler(changeThemes);

            this.radRibbonBar1.StartButtonImage = Telerik.WinControls.ResFinder.MenuIcon;
        }

        #endregion

        #region Methods

        private void AddNodes()
        {
            RadTreeNode favorites = new RadTreeNode();
            favorites.Text = "Favorites";
            favorites.Image = Resources.favorites;
            radTreeView1.Nodes.Add(favorites);

            RadTreeNode desktop = new RadTreeNode();
            desktop.Tag = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            desktop.Text = "Desktop";
            favorites.Nodes.Add(desktop);

            RadTreeNode libraries = new RadTreeNode();
            libraries.Text = "Libraries";
            libraries.Image = Resources.documents;
            radTreeView1.Nodes.Add(libraries);

            RadTreeNode documents = new RadTreeNode("Documents");
            documents.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            libraries.Nodes.Add(documents);

            RadTreeNode music = new RadTreeNode("Music");
            music.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            libraries.Nodes.Add(music);

            RadTreeNode pictures = new RadTreeNode("Pictures");
            pictures.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            libraries.Nodes.Add(pictures);

            RadTreeNode myComputerNode = new RadTreeNode("My Computer");
            myComputerNode.Image = Resources.computer;

            string[] drives = Directory.GetLogicalDrives();
            for (int i = 0; i < drives.Length; i++)
            {
                RadTreeNode node = new RadTreeNode(drives[i]);
                node.Tag = drives[i];
                myComputerNode.Nodes.Add(node);
            }
            radTreeView1.Nodes.Add(myComputerNode);
        }

        private void SetupListView()
        {
            radListView1.ItemMouseDoubleClick += new ListViewItemEventHandler(radListView1_ItemMouseDoubleClick);
            radListView1.KeyDown += new KeyEventHandler(radListView1_KeyDown);
            radListView1.ViewTypeChanged += new EventHandler(radListView1_ViewTypeChanged);
            radListView1.VisualItemFormatting += new ListViewVisualItemEventHandler(radListView1_VisualItemFormatting);
            radListView1.CellFormatting += new ListViewCellFormattingEventHandler(radListView1_CellFormatting);
            radListView1.SelectedItemsChanged += new EventHandler(radListView1_SelectedItemsChanged);
            radListView1.ItemValidating += new ListViewItemValidatingEventHandler(radListView1_ItemValidating);
            radListView1.ItemEdited += new ListViewItemEditedEventHandler(radListView1_ItemEdited);
            radListView1.ItemEditing += new ListViewItemEditingEventHandler(radListView1_ItemEditing);

            radListView1.EnableFiltering = true;
            radListView1.EnableSorting = true;
            radListView1.MultiSelect = true;
            radListView1.FullRowSelect = false;
            radListView1.AllowRemove = false;

            radListView1.Columns.Add(new ListViewDetailColumn("Name"));
            radListView1.Columns.Add(new ListViewDetailColumn("Date Modified"));
            radListView1.Columns.Add(new ListViewDetailColumn("Type"));
            radListView1.Columns.Add(new ListViewDetailColumn("Size"));
        }

        private void UpdateView(RadTreeNode node)
        {
            radListView1.Items.Clear();

            if (node.Tag == null && (node.Text == "Favorites" || node.Text == "Libraries" || node.Text == "My Computer"))
            {
                foreach (RadTreeNode childNode in node.Nodes)
                {
                    ListViewDataItem item = new ListViewDataItem();
                    radListView1.Items.Add(item);
                    item.Text = childNode.Text;
                    item["Name"] = childNode.Text;
                    item.Tag = childNode.Tag;

                    IntPtr hImgLarge = SHGetFileInfo(childNode.Tag.ToString(), 0, ref shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_SMALLICON);
                    item.Image = System.Drawing.Icon.FromHandle(shinfo.hIcon).ToBitmap();
                }
                return;
            }

            if (node.Tag != null)
            {
                string[] directories = Directory.GetDirectories(node.Tag.ToString());
                string[] files = Directory.GetFiles(node.Tag.ToString());

                foreach (string directory in directories)
                {
                    ListViewDataItem item = new ListViewDataItem();
                    radListView1.Items.Add(item);
                    item.Text = Path.GetFileName(directory);
                    item.Tag = directory;
                    item["Name"] = Path.GetFileName(directory);
                    item["Date Modified"] = Directory.GetLastWriteTime(directory);
                    item["Type"] = "File folder";
                    item["Size"] = "";

                    IntPtr hImgLarge = SHGetFileInfo(directory, 0, ref shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_SMALLICON);
                    item.Image = System.Drawing.Icon.FromHandle(shinfo.hIcon).ToBitmap();
                }

                foreach (string file in files)
                {
                    ListViewDataItem item = new ListViewDataItem();
                    radListView1.Items.Add(item);
                    item.Tag = file;
                    item.Text = Path.GetFileName(file);
                    item["Name"] = Path.GetFileName(file);
                    item["Date Modified"] = System.IO.File.GetLastWriteTime(file);
                    item["Type"] = "File folder";
                    FileInfo fi = new FileInfo(file);
                    item["Size"] = GetFileSize(fi.Length);

                    IntPtr hImgLarge = SHGetFileInfo(file, 0, ref shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_SMALLICON);
                    item.Image = System.Drawing.Icon.FromHandle(shinfo.hIcon).ToBitmap();
                }
            }
        }

        private void NavigateBack()
        {
            if (backCollection.Count > 0)
            {
                if (backCollection.Peek() == radTreeView1.SelectedNode)
                {
                    forwardCollection.Push(backCollection.Pop());
                }
                navigateOperationInProgress = true;
                radTreeView1.SelectedNode = backCollection.Peek();
                forwardCollection.Push(backCollection.Pop());
                navigateOperationInProgress = false;
            }
        }

        private void NavigateForward()
        {
            if (forwardCollection.Count > 0)
            {
                if (forwardCollection.Peek() == radTreeView1.SelectedNode)
                {
                    backCollection.Push(forwardCollection.Pop());
                }

                navigateOperationInProgress = true;
                radTreeView1.SelectedNode = forwardCollection.Peek();
                backCollection.Push(forwardCollection.Pop());
                navigateOperationInProgress = false;
            }
        }

        private void AddButtonToTextBox()
        {
            searchButton = new CustomButton();
            searchButton.Image = Resources.search;
            searchButton.ImageAlignment = ContentAlignment.MiddleCenter;
            searchButton.ShouldHandleMouseInput = false;
            searchButton.MaxSize = new System.Drawing.Size(16, 16);
            searchButton.MinSize = new System.Drawing.Size(16, 16);
            searchButton.ButtonFillElement.BackColor = Color.Transparent;
            searchButton.ButtonFillElement.BackColor2 = Color.Transparent;
            searchButton.ButtonFillElement.BackColor3 = Color.Transparent;
            searchButton.ButtonFillElement.BackColor4 = Color.Transparent;
            searchButton.BorderElement.Visibility = ElementVisibility.Collapsed;
            searchButton.Click += new EventHandler(searchButton_Click);

            RadTextBoxItem textBoxItem = this.radTextBox1.TextBoxElement.TextBoxItem;
            textBoxItem.Alignment = ContentAlignment.MiddleLeft;

            this.radTextBox1.TextBoxElement.Children.Remove(textBoxItem);

            DockLayoutPanel.SetDock(textBoxItem, Telerik.WinControls.Layouts.Dock.Left);
            DockLayoutPanel.SetDock(searchButton, Telerik.WinControls.Layouts.Dock.Right);

            DockLayoutPanel dockLayoutPanel = new DockLayoutPanel();

            dockLayoutPanel.Children.Add(searchButton);
            dockLayoutPanel.Children.Add(textBoxItem);

            this.radTextBox1.TextBoxElement.Children.Add(dockLayoutPanel);
        }

        private void AddButtonsToStatusStrip()
        {
            detailsToggleButton = new CustomToggleButton();
            detailsToggleButton.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            detailsToggleButton.Image = Resources.detailsViewIcon;
            detailsToggleButton.BorderElement.Visibility = ElementVisibility.Collapsed;
            detailsToggleButton.ButtonFillElement.BackColor = Color.Transparent;
            detailsToggleButton.ButtonFillElement.BackColor2 = Color.Transparent;
            detailsToggleButton.ButtonFillElement.BackColor3 = Color.Transparent;
            detailsToggleButton.ButtonFillElement.BackColor4 = Color.Transparent;
            detailsToggleButton.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            detailsToggleButton.ToolTipText = "Details View";
            radStatusStrip1.Items.Add(detailsToggleButton);
            detailsToggleButton.ToggleStateChanged += new StateChangedEventHandler(detailsToggleButton_ToggleStateChanged);


            iconsToggleButton = new CustomToggleButton();
            iconsToggleButton.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iconsToggleButton.Image = Resources.iconsViewIcon;
            iconsToggleButton.BorderElement.Visibility = ElementVisibility.Collapsed;
            iconsToggleButton.ButtonFillElement.BackColor = Color.Transparent;
            iconsToggleButton.ButtonFillElement.BackColor2 = Color.Transparent;
            iconsToggleButton.ButtonFillElement.BackColor3 = Color.Transparent;
            iconsToggleButton.ButtonFillElement.BackColor4 = Color.Transparent;
            iconsToggleButton.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            iconsToggleButton.ToolTipText = "Icons View";
            iconsToggleButton.ToggleStateChanged += new StateChangedEventHandler(iconsToggleButton_ToggleStateChanged);
            radStatusStrip1.Items.Add(iconsToggleButton);

        }

        public void DirectoryCopy(string sourceDir, string targetDir)
        {
            DirectoryInfo source = new DirectoryInfo(sourceDir);
            DirectoryInfo target = new DirectoryInfo(targetDir);
            // Check if the target directory exists, if not, create it.
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            // Copy each file into it’s new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);

                DirectoryCopy(diSourceSubDir.FullName, nextTargetSubDir.FullName);
            }
        }

        public bool DeleteDirectory(string target_dir)
        {
            bool result = false;

            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                System.IO.File.SetAttributes(file, FileAttributes.Normal);
                System.IO.File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);

            return result;
        }

        #endregion

        #region Events

        void radListView1_ItemValidating(object sender, ListViewItemValidatingEventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(e.NewValue)))
            {
                e.Cancel = true;
            }
        }

        void radListView1_ItemEditing(object sender, ListViewItemEditingEventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(e.Item.Tag.ToString());
            if (di.Parent == null)
            {
                RadMessageBox.Show("Cannot change drive name");
                e.Cancel = true;
            }
        }

        void radListView1_ItemEdited(object sender, ListViewItemEditedEventArgs e)
        {
            string sourcePath = e.VisualItem.Data.Tag.ToString();
            string destinationPath = Path.GetDirectoryName(sourcePath) + "\\" + e.VisualItem.Text;

            if (!(string.Equals(sourcePath, destinationPath)))
            {
                if (System.IO.File.Exists(sourcePath))
                {
                    System.IO.File.Move(sourcePath, destinationPath);
                }
                else if (System.IO.Directory.Exists(sourcePath))
                {
                    System.IO.Directory.Move(sourcePath, destinationPath);
                }
            }
        }

        void radListView1_CellFormatting(object sender, ListViewCellFormattingEventArgs e)
        {
            e.CellElement.TextAlignment = ContentAlignment.MiddleLeft;
            e.CellElement.TextImageRelation = TextImageRelation.ImageBeforeText;
            e.CellElement.ImageAlignment = ContentAlignment.MiddleLeft;
        }

        void radListView1_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            if (radListView1.ViewType == ListViewType.ListView)
            {
                e.VisualItem.TextAlignment = ContentAlignment.MiddleLeft;
                e.VisualItem.TextImageRelation = TextImageRelation.ImageBeforeText;
                if (e.VisualItem.Data.Tag != null)
                {
                    IntPtr hImgLarge = SHGetFileInfo(e.VisualItem.Data.Tag.ToString(), 0, ref shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_SMALLICON);
                    try
                    {
                        e.VisualItem.Image = System.Drawing.Icon.FromHandle(shinfo.hIcon).ToBitmap();
                    }
                    catch { }
                    DestroyIcon(shinfo.hIcon);
                }
            }

            if (radListView1.ViewType == ListViewType.IconsView)
            {
                e.VisualItem.TextAlignment = ContentAlignment.MiddleCenter;
                e.VisualItem.TextImageRelation = TextImageRelation.ImageAboveText;
                e.VisualItem.ImageAlignment = ContentAlignment.MiddleCenter;
                if (e.VisualItem.Data.Tag != null)
                {
                    switch (iconSize)
                    {
                        case IconSize.Small:
                            e.VisualItem.TextAlignment = ContentAlignment.MiddleLeft;
                            e.VisualItem.TextImageRelation = TextImageRelation.ImageBeforeText;
                            e.VisualItem.ImageAlignment = ContentAlignment.MiddleLeft;

                            IntPtr small = SHGetFileInfo(e.VisualItem.Data.Tag.ToString(), 0, ref shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_SMALLICON);
                            try
                            {
                                e.VisualItem.Image = System.Drawing.Icon.FromHandle(shinfo.hIcon).ToBitmap();
                            }
                            catch (ArgumentException) { }
                            break;
                        case IconSize.Medium:
                            IntPtr medium = SHGetFileInfo(e.VisualItem.Data.Tag.ToString(), 0, ref shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_LARGEICON);
                            try
                            {
                                e.VisualItem.Image = System.Drawing.Icon.FromHandle(shinfo.hIcon).ToBitmap();
                            }
                            catch (ArgumentException) { }
                            break;
                    }
                }
            }
        }

        void radListView1_SelectedItemsChanged(object sender, EventArgs e)
        {
            selectedItemInfoLabel.Text = radListView1.SelectedItems.Count == 1 ? "1 item selected" : radListView1.SelectedItems.Count + " items selected";
        }

        void radListView1_ViewTypeChanged(object sender, EventArgs e)
        {
            switch (radListView1.ViewType)
            {
                case ListViewType.DetailsView:
                    radListView1.AllowArbitraryItemWidth = false;
                    radListView1.AllowArbitraryItemHeight = true;
                    radListView1.ItemSize = new Size(64, 64);
                    break;
                case ListViewType.IconsView:
                    radListView1.AllowArbitraryItemWidth = false;
                    radListView1.AllowArbitraryItemHeight = true;
                    radListView1.ItemSize = new Size(64, 64);
                    break;
                case ListViewType.ListView:
                    radListView1.FullRowSelect = false;

                    break;
                default:
                    break;
            }
        }

        void radListView1_ItemMouseDoubleClick(object sender, ListViewItemEventArgs e)
        {
            foreach (RadTreeNode node in radTreeView1.SelectedNode.Nodes)
            {
                if (e.Item.Text == node.Text)
                {
                    radTreeView1.SelectedNode = node;
                    return;
                }
            }
            Process.Start(e.Item.Tag.ToString());
        }

        void radListView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Back)
            {
                NavigateBack();
            }
            if (e.KeyData == Keys.Delete)
            {
                deleteSelectionMenuItem_Click(null, null);
            }
            if (e.KeyData == Keys.Enter && radListView1.SelectedItem != null)
            {
                foreach (RadTreeNode node in radTreeView1.SelectedNode.Nodes)
                {
                    if (radListView1.SelectedItem.Text == node.Text)
                    {
                        radTreeView1.SelectedNode = node;
                        return;
                    }
                }
                Process.Start(radListView1.SelectedItem.Tag.ToString());
            }
        }

        void radTreeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Back)
            {
                NavigateBack();
            }
        }

        void radTreeView1_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            if (e.Node == null)
            {
                return;
            }
            try
            {
                //this checks for access exceptions
                if (e.Node.Tag != null)
                {
                    string[] directories = Directory.GetDirectories(e.Node.Tag.ToString());
                }

                //add the node to history
                if (!(navigateOperationInProgress))
                {
                    backCollection.Push(e.Node);
                }

                //update view
                UpdateView(e.Node);

                //updates status strip labels
                if (radListView1.Items.Count == 1)
                {
                    directoryInfoLabel.Text = radListView1.Items.Count + " item";
                }
                else
                {
                    directoryInfoLabel.Text = radListView1.Items.Count + " items";
                }

                if (e.Node.Nodes.Count > 0 && e.Node.Expanded == false)
                {
                    e.Node.Expanded = true;
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                RadMessageBox.Show(ex.Message.ToString());
            }
            catch (IOException ex2)
            {
                RadMessageBox.Show(ex2.Message.ToString());
            }
        }

        void radTreeView1_NodesNeeded(object sender, NodesNeededEventArgs e)
        {
            if (e.Parent.Tag != null)
            {
                string directoryPath = e.Parent.Tag.ToString();
                if (Directory.Exists(directoryPath))
                {
                    try
                    {
                        string[] directories = Directory.GetDirectories(directoryPath);

                        for (int i = 0; i < directories.Length; i++)
                        {
                            RadTreeNode node = new RadTreeNode(Path.GetFileName(directories[i]));
                            node.Tag = directories[i];
                            e.Nodes.Add(node);
                        }
                    }
                    catch (UnauthorizedAccessException) { }
                    catch (IOException) { }
                }
            }
        }

        void radTreeView1_NodeFormatting(object sender, TreeNodeFormattingEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                IntPtr hImgLarge = SHGetFileInfo(e.Node.Tag.ToString(), 0, ref shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_SMALLICON);
                e.NodeElement.ImageElement.Image = System.Drawing.Icon.FromHandle(shinfo.hIcon).ToBitmap();
            }
        }

        void forwardButton_Click(object sender, EventArgs e)
        {
            NavigateForward();
        }

        void backButton_Click(object sender, EventArgs e)
        {
            NavigateBack();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            if (radTreeView1.SelectedNode != null && radTreeView1.SelectedNode.Parent != null)
            {
                radTreeView1.SelectedNode = radTreeView1.SelectedNode.Parent;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (radTreeView1.SelectedNode != null)
            {
                RadTreeNode savedNode = radTreeView1.SelectedNode;
                radTreeView1.SelectedNode = new RadTreeNode();
                radTreeView1.SelectedNode = savedNode;
            }
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            historyButton.Items.Clear();
            foreach (RadTreeNode node in backCollection)
            {
                if (node != radTreeView1.SelectedNode)
                {
                    RadMenuItem historyDropDownItem = new RadMenuItem();
                    historyDropDownItem.Text = node.Text;
                    historyDropDownItem.Tag = node;
                    historyDropDownItem.Click += new EventHandler(historyDropDownItem_Click);
                    historyButton.Items.Add(historyDropDownItem);
                }
            }
            if (historyButton.Items.Count > 0)
            {
                historyButton.ShowDropDown();
            }
        }

        void historyDropDownItem_Click(object sender, EventArgs e)
        {
            RadMenuItem item = sender as RadMenuItem;
            radTreeView1.SelectedNode = item.Tag as RadTreeNode;
        }

        void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(radTextBox1.Text))
            {
                searchButton.Image = Resources.search;
                searchButton.ShouldHandleMouseInput = false;
                radListView1.FilterDescriptors.Clear();
            }
            else
            {
                searchButton.Image = Resources.cross;
                searchButton.ShouldHandleMouseInput = true;

                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = "Text";
                filter.Operator = FilterOperator.StartsWith;
                filter.Value = radTextBox1.Text;
                radListView1.FilterDescriptors.Add(filter);

                autoCompleteDataSource.Add(radTextBox1.Text);
            }
        }

        void searchButton_Click(object sender, EventArgs e)
        {
            radTextBox1.Text = "";
        }

        void iconsToggleButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                detailsToggleButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
                detailsToggleButton.ToolTipText = "Details View";
                iconsToggleButton.ToolTipText = "List View";
                radListView1.ViewType = ListViewType.IconsView;
            }
            else
            {
                radListView1.ViewType = ListViewType.ListView;
                detailsToggleButton.ToolTipText = "Details View";
                iconsToggleButton.ToolTipText = "Icons View";
            }
        }

        void detailsToggleButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                iconsToggleButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
                radListView1.ViewType = ListViewType.DetailsView;
                detailsToggleButton.ToolTipText = "List View";
                iconsToggleButton.ToolTipText = "Icons View";
            }
            else
            {
                radListView1.ViewType = ListViewType.ListView;
                detailsToggleButton.ToolTipText = "Details View";
                iconsToggleButton.ToolTipText = "Icons View";
            }
        }

        private void copyAsPathButton_Click(object sender, EventArgs e)
        {
            if (radListView1.SelectedItem.Tag != null)
            {
                Clipboard.SetText(radListView1.SelectedItem.Tag.ToString());
            }
        }

        private void newFolderButton_Click(object sender, EventArgs e)
        {
            if (radTreeView1.SelectedNode.Tag != null)
            {
                if (!(Directory.Exists(radTreeView1.SelectedNode.Tag.ToString() + "New Folder")))
                {
                    Directory.CreateDirectory(radTreeView1.SelectedNode.Tag.ToString() + "New Folder");
                    UpdateView(radTreeView1.SelectedNode);
                    foreach (ListViewDataItem item in radListView1.Items)
                    {
                        if (item.Text == "New Folder")
                        {
                            radListView1.SelectedItem = item;
                        }
                    }
                }
                else
                {
                    int i = 0;
                    foreach (ListViewDataItem item in radListView1.Items)
                    {
                        if (item.Text.Contains("New Folder"))
                        {
                            i++;
                        }
                    }

                    Directory.CreateDirectory(radTreeView1.SelectedNode.Tag.ToString() + "New Folder (" + i + ")");
                    UpdateView(radTreeView1.SelectedNode);

                    foreach (ListViewDataItem item in radListView1.Items)
                    {
                        if (item.Text == "New Folder (" + i + ")")
                        {
                            radListView1.SelectedItem = item;
                        }
                    }
                    radListView1.ListViewElement.BeginEdit();
                }
            }
        }

        void deleteSelectionMenuItem_Click(object sender, EventArgs e)
        {
            if (RadMessageBox.Show("Are you sure that you want to delete the selected items?", "Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (ListViewDataItem item in radListView1.SelectedItems)
                {
                    if (item.Tag != null)
                    {
                        if (System.IO.File.Exists(item.Tag.ToString()))
                        {
                            System.IO.File.Delete(item.Tag.ToString());
                        }
                        else
                        {
                            DeleteDirectory(item.Tag.ToString());
                        }
                    }
                }
                UpdateView(radTreeView1.SelectedNode);
            }
        }

        void deleteAllMenuItem_Click(object sender, EventArgs e)
        {
            if (RadMessageBox.Show("Are you sure that you want to delete all files and folders in the directory?", "Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (ListViewDataItem item in radListView1.Items)
                {
                    if (item.Tag != null)
                    {
                        if (System.IO.File.Exists(item.Tag.ToString()))
                        {
                            System.IO.File.Delete(item.Tag.ToString());
                        }
                        else
                        {
                            DeleteDirectory(item.Tag.ToString());
                        }
                    }
                }
                UpdateView(radTreeView1.SelectedNode);
            }
        }

        void pasteMenuItem_Click(object sender, EventArgs e)
        {
            if (copySource != null)
            {
                WaitingForm.ShowForm(null);

                foreach (ListViewDataItem item in copySource)
                {
                    if (item.Tag != null && radTreeView1.SelectedNode.Tag != null)
                    {
                        if (System.IO.File.Exists(item.Tag.ToString()))
                        {
                            System.IO.File.Move(item.Tag.ToString(), radTreeView1.SelectedNode.Tag.ToString() + "\\" + Path.GetFileName(item.Tag.ToString()));
                        }
                        else
                        {
                            DirectoryCopy(item.Tag.ToString(), radTreeView1.SelectedNode.Tag.ToString() + "\\" + Path.GetFileName(item.Tag.ToString()));
                        }
                    }
                }
                UpdateView(radTreeView1.SelectedNode);
                WaitingForm.CloseForm();
            }
        }

        void pasteAsShortcutMenuItem_Click(object sender, EventArgs e)
        {
           //this functionality is not implemented since it requires IWishRuntimeLibrary
        }

       

        private void copyButton_Click(object sender, EventArgs e)
        {
            copySource = new List<ListViewDataItem>();
            foreach (ListViewDataItem item in radListView1.SelectedItems)
            {
                if (item.Tag != null && (System.IO.File.Exists(item.Tag.ToString()) || Directory.Exists(item.Tag.ToString())))
                {
                    copySource.Add(item);
                }
            }
        }

        private void copyToFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                WaitingForm.ShowForm(null);
                Thread.Sleep(1000);
                foreach (ListViewDataItem item in radListView1.SelectedItems)
                {
                    if (item.Tag != null)
                    {
                        if (System.IO.File.Exists(item.Tag.ToString()))
                        {
                            if (System.IO.File.Exists(folderBrowserDialog1.SelectedPath + "\\" + Path.GetFileName(item.Tag.ToString())))
                            {
                                if (RadMessageBox.Show("The file with the same name already exists in the specified location. Do you want to override it?", "File exists", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    System.IO.File.Copy(item.Tag.ToString(), folderBrowserDialog1.SelectedPath + "\\" + Path.GetFileName(item.Tag.ToString()), true);
                                }
                            }
                            else
                            {
                                System.IO.File.Copy(item.Tag.ToString(), folderBrowserDialog1.SelectedPath + "\\" + Path.GetFileName(item.Tag.ToString()));
                            }
                        }
                        else
                        {
                            if (Directory.Exists(folderBrowserDialog1.SelectedPath + "\\" + Path.GetFileName(item.Tag.ToString())))
                            {
                                if (RadMessageBox.Show("Directory with the same name already exists in the specified location. Do you want to override it?", "File exists", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    DirectoryCopy(item.Tag.ToString(), folderBrowserDialog1.SelectedPath + "\\" + Path.GetFileName(item.Tag.ToString()));
                                }
                            }
                            else
                            {
                                DirectoryCopy(item.Tag.ToString(), folderBrowserDialog1.SelectedPath + "\\" + Path.GetFileName(item.Tag.ToString()));
                            }
                        }
                    }
                }
                WaitingForm.CloseForm();
            }
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            radListView1.ListViewElement.BeginEdit();
        }

        private void detailsGaleryItem_Click(object sender, EventArgs e)
        {
            radListView1.ViewType = ListViewType.DetailsView;
        }

        private void smallIconsGaleryItem_Click(object sender, EventArgs e)
        {
            radListView1.ViewType = ListViewType.IconsView;
            radListView1.AllowArbitraryItemWidth = true;
            radListView1.AllowArbitraryItemHeight = true;
            iconSize = IconSize.Small;
            radListView1.ListViewElement.SynchronizeVisualItems();
            radListView1.ListViewElement.ViewElement.Orientation = Orientation.Horizontal;
        }

        private void mediumIconsGaleryItem_Click(object sender, EventArgs e)
        {
            radListView1.ViewType = ListViewType.IconsView;
            radListView1.AllowArbitraryItemWidth = true;
            radListView1.AllowArbitraryItemHeight = true;
            iconSize = IconSize.Medium;
            radListView1.ListViewElement.SynchronizeVisualItems();
            radListView1.ListViewElement.ViewElement.Orientation = Orientation.Vertical;
        }

        private void listGaleryItem_Click(object sender, EventArgs e)
        {
            radListView1.ViewType = ListViewType.ListView;
        }

        void sortBy_Click(object sender, EventArgs e)
        {

            RadMenuItem clickedItem = sender as RadMenuItem;
            if (radListView1.SortDescriptors.Count > 0 && radListView1.SortDescriptors[0].PropertyName == clickedItem.Text)
            {
                clickedItem.IsChecked = false;
                radListView1.SortDescriptors.Clear();
            }
            else
            {
                radListView1.SortDescriptors.Clear();
                SortDescriptor descriptor = new SortDescriptor(clickedItem.Text, ListSortDirection.Ascending);
                radListView1.SortDescriptors.Add(descriptor);

                foreach (RadMenuItem item in sortByButton.Items)
                {
                    item.IsChecked = false;
                }
                clickedItem.IsChecked = true;
            }
        }

        void changeThemes(object sender, EventArgs e)
        {
            RadGalleryItem element = sender as RadGalleryItem;
            ThemeResolutionService.ApplicationThemeName = element.Text;
            radRibbonBar1.StartButtonImage = Telerik.WinControls.ResFinder.MenuIcon;           
        }

        #endregion

        #region Helpers

        #region GetAssociatedFileIcon

        [DllImport("user32.dll")]
        private static extern bool DestroyIcon(IntPtr handle);

        //how to the the image
        //IntPtr hImgSmall = SHGetFileInfo(e.VisualItem.Data.Tag.ToString(), 0, ref shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_SMALLICON);
        //IntPtr hImgLarge = SHGetFileInfo(e.VisualItem.Data.Tag.ToString(), 0, ref shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_LARGEICON);

        SHFILEINFO shinfo = new SHFILEINFO();

        // Constants that we need in the function call
        private const int SHGFI_ICON = 0x100;
        private const int SHGFI_SMALLICON = 0x1;
        private const int SHGFI_LARGEICON = 0x0;

        // This structure will contain information about the file
        public struct SHFILEINFO
        {
            // Handle to the icon representing the file
            public IntPtr hIcon;
            // Index of the icon within the image list
            public int iIcon;
            // Various attributes of the file
            public uint dwAttributes;
            // Path to the file
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string szDisplayName;
            // File type
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        // The signature of SHGetFileInfo (located in Shell32.dll)
        [DllImport("Shell32.dll")]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, int cbFileInfo, uint uFlags);
        #endregion

        private string GetFileSize(double byteCount)
        {
            string size = "0 Bytes";
            if (byteCount >= 1073741824.0)
                size = String.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
            else if (byteCount >= 1048576.0)
                size = String.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
            else if (byteCount >= 1024.0)
                size = String.Format("{0:##.##}", byteCount / 1024.0) + " KB";
            else if (byteCount > 0 && byteCount < 1024.0)
                size = byteCount.ToString() + " Bytes";

            return size;
        }

        private Image ImageResize(Image img, Size size)
        {
            //get the height and width of the image
            int originalW = img.Width;
            int originalH = img.Height;

            //get the new size based on the percentage change
            int resizedW = size.Width;
            int resizedH = size.Height;

            //create a new Bitmap the size of the new image
            Bitmap bmp = new Bitmap(resizedW, resizedH);
            //create a new graphic from the Bitmap
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //draw the newly resized image
            graphic.DrawImage(img, 0, 0, resizedW, resizedH);
            //dispose and free up the resources
            graphic.Dispose();
            //return the image
            return (Image)bmp;
        }


        #endregion

    }
}
