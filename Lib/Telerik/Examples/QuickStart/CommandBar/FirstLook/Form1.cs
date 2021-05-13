using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.CommandBar.FirstLook
{
    public partial class Form1 : ExamplesRadForm, ISupportThemeName
    {
        public Form1()
        {
            InitializeComponent();

            ImagePrimitive icon = new ImagePrimitive();
            icon.Image = new Bitmap(ResFinder.ProgressIcon.ToBitmap(), new Size(14, 14));
            icon.Padding = new Padding(0, 2, 2, 0);

            RadTextBoxElement addressBox = radCommandBarDropDownListItem1.DropDownListElement.EditableElement.TextBox;
            radCommandBarDropDownListItem1.DropDownListElement.EditableElement.DrawText = false;
            this.AddIconToTextBoxElement(addressBox, icon, Telerik.WinControls.Layouts.Dock.Left);

            ImagePrimitive searchIcon = new ImagePrimitive();
            searchIcon.Image = global::Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.search3;
            searchIcon.Alignment = ContentAlignment.MiddleRight;
            searchIcon.MouseDown += new MouseEventHandler(searchIcon_MouseDown);

            searchIcon.ShouldHandleMouseInput = true;
            this.AddIconToTextBoxElement(this.radCommandBarTextBoxItem1.TextBoxElement, searchIcon, Telerik.WinControls.Layouts.Dock.Right);

            this.radCommandBarTextBoxItem1.TextBoxElement.Alignment = ContentAlignment.TopLeft;
            this.radCommandBarTextBoxItem1.TextBoxElement.TextBoxItem.Alignment = ContentAlignment.TopLeft;
            this.radCommandBarTextBoxItem1.TextBoxElement.TextBoxItem.KeyDown += new KeyEventHandler(radCommandBarTextBoxItem1_KeyDown);

            radCommandBarDropDownListItem1.PropertyChanged += new PropertyChangedEventHandler(radCommandBarDropDownListItem1_PropertyChanged);
            radCommandBarTextBoxItem1.PropertyChanged += new PropertyChangedEventHandler(radCommandBarTextBoxItem1_PropertyChanged);
            radCommandBarDropDownListItem1.DropDownListElement.EditableElement.TextBox.TextBoxItem.KeyDown += new KeyEventHandler(radCommandBarDropDownListItem1_KeyDown);

            (radPageView1.ViewElement as RadPageViewStripElement).NewItemVisibility = StripViewNewItemVisibility.End;
            radPageView1.NewPageRequested += new EventHandler(radPageView1_NewPageRequested);
            radPageView1.PageAdded += new EventHandler<RadPageViewEventArgs>(radPageView1_PageAdded);

            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("www.telerik.com");
        }

        protected override void WireEvents()
        {
            this.radPageView1.SelectedPageChanged += new EventHandler(this.radPageView1_SelectedPageChanged);
            this.radMenuItem14.Click += new EventHandler(this.radMenuItem14_Click);
            this.radMenuItem30.Click += new EventHandler(this.radMenuItem30_Click);
            this.radMenuItem31.Click += new EventHandler(this.radMenuItem31_Click);
            this.radMenuItem32.Click += new EventHandler(this.radMenuItem32_Click);
            this.radCommandBarButtonItem1.Click += new EventHandler(this.radCommandBarButtonItem1_Click);
            this.radCommandBarButtonItem1.MouseDown += new MouseEventHandler(this.radCommandBarButtonItem1_MouseDown);
            this.radCommandBarButtonItem1.MouseUp += new MouseEventHandler(this.radCommandBarButtonItem1_MouseUp);
            this.radCommandBarButtonItem1.MouseEnter += new EventHandler(this.radCommandBarButtonItem1_MouseEnter);
            this.radCommandBarButtonItem1.MouseLeave += new EventHandler(this.radCommandBarButtonItem1_MouseLeave);
            this.radCommandBarButtonItem2.Click += new EventHandler(this.radCommandBarButtonItem2_Click);
            this.radCommandBarButtonItem2.MouseDown += new MouseEventHandler(this.radCommandBarButtonItem2_MouseDown);
            this.radCommandBarButtonItem2.MouseUp += new MouseEventHandler(this.radCommandBarButtonItem2_MouseUp);
            this.radCommandBarButtonItem2.MouseEnter += new EventHandler(this.radCommandBarButtonItem2_MouseEnter);
            this.radCommandBarButtonItem2.MouseLeave += new EventHandler(this.radCommandBarButtonItem2_MouseLeave);
            this.webBrowser1.Navigated += new WebBrowserNavigatedEventHandler(this.browser_Navigated);
            this.webBrowser1.Navigating += new WebBrowserNavigatingEventHandler(this.browser_Navigating);
            this.radCommandBarButtonItem5.Click += new EventHandler(this.radCommandBarButtonItem5_Click);
            this.radCommandBarDropDownListItem1.KeyDown += new KeyEventHandler(this.radCommandBarDropDownListItem1_KeyDown);
            this.radCommandBarButtonItem3.Click += new EventHandler(this.radCommandBarButtonItem3_Click);
            this.radCommandBarButtonItem4.Click += new EventHandler(this.radCommandBarButtonItem4_Click);
        }

        private void AddIconToTextBoxElement(RadTextBoxElement textElement, ImagePrimitive icon, Telerik.WinControls.Layouts.Dock dock)
        {
            RadTextBoxItem item = textElement.TextBoxItem;

            textElement.Children.Remove(item);

            icon.SetValue(DockLayoutPanel.DockProperty, dock);

            DockLayoutPanel dockPanel = new DockLayoutPanel();
            dockPanel.LastChildFill = true;

            dockPanel.Children.Add(icon);
            dockPanel.Children.Add(item);

            textElement.Children.Add(dockPanel);
        }

        void radPageView1_PageAdded(object sender, RadPageViewEventArgs e)
        {
            e.Page.Item.MaxSize = new Size(200, 40);
        }

        void radPageView1_NewPageRequested(object sender, EventArgs e)
        {
            WebBrowser browser = new WebBrowser();
            browser.Dock = DockStyle.Fill;
            browser.ScriptErrorsSuppressed = true;
            browser.Navigating += new WebBrowserNavigatingEventHandler(browser_Navigating);
            browser.Navigated += new WebBrowserNavigatedEventHandler(browser_Navigated);
            browser.Navigate("www.telerik.com");
            RadPageViewPage page = new RadPageViewPage();
            page.Controls.Add(browser);
            page.Text = "New Tab";

            radPageView1.Pages.Add(page);
            radPageView1.SelectedPage = page;
        }

        void radCommandBarTextBoxItem1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.OpenSearch(radCommandBarTextBoxItem1.Text);
            }
        }

        void searchIcon_MouseDown(object sender, MouseEventArgs e)
        {
            this.OpenSearch(radCommandBarTextBoxItem1.Text);
        }

        void OpenSearch(string searchString)
        {
            WebBrowser browser = new WebBrowser();
            browser.Dock = DockStyle.Fill;
            browser.Navigating += new WebBrowserNavigatingEventHandler(browser_Navigating);
            browser.Navigated += new WebBrowserNavigatedEventHandler(browser_Navigated);
            browser.Navigate("http://www.bing.com/search?q=" + searchString);
            RadPageViewPage page = new RadPageViewPage();
            page.Controls.Add(browser);
            page.Text = "Search";
            radPageView1.Pages.Add(page);
            radPageView1.SelectedPage = page;
        }

        void radCommandBarTextBoxItem1_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Bounds")
            {
                radCommandBarTextBoxItem1.TextBoxElement.TextBoxItem.HostedControl.MaximumSize =
                    new Size(radCommandBarTextBoxItem1.Size.Width - 28, 0);
            }
        }

        void radCommandBarDropDownListItem1_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Bounds")
            {
                radCommandBarDropDownListItem1.DropDownListElement.EditableElement.TextBox.TextBoxItem.HostedControl.MaximumSize =
                    new Size(radCommandBarDropDownListItem1.Size.Width - 40, 0);
            }
        }

        private void radCommandBarButtonItem5_Click(object sender, EventArgs e)
        {
            this.NavigateTo(radCommandBarDropDownListItem1.DropDownListElement.EditableElement.TextBox.Text);
        }

        private void radCommandBarDropDownListItem1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.NavigateTo(radCommandBarDropDownListItem1.DropDownListElement.EditableElement.TextBox.Text);
            }
        }

        private void NavigateTo(string address)
        {
            if (radPageView1.SelectedPage != null)
            {
                WebBrowser browser = (radPageView1.SelectedPage.Controls[0] as WebBrowser);
                browser.Navigate(address);
            }
        }

        private void browser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            Control parentControl = (sender as WebBrowser).Parent;
            if (parentControl == null)
            {
                return;
            }

            (sender as WebBrowser).Parent.Text = "Loading...";
        }

        private void browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            WebBrowser senderBrowser = sender as WebBrowser;
            senderBrowser.Parent.Text = (String.IsNullOrEmpty(senderBrowser.DocumentTitle)) ? "New Tab" : senderBrowser.DocumentTitle;

            string pageText = senderBrowser.Parent.Text;
            if (pageText.Length > 20)
            {
                senderBrowser.Parent.Text = pageText.Substring(0, 20) + "...";
            }

            if (radCommandBarDropDownListItem1.Items.Count > 50)
            {
                radCommandBarDropDownListItem1.Items.RemoveAt(radCommandBarDropDownListItem1.Items.Count - 1);
            }

            radCommandBarDropDownListItem1.Items.Insert(0, new RadListDataItem(senderBrowser.Url.AbsoluteUri));

            radCommandBarDropDownListItem1.Text = senderBrowser.Url.AbsoluteUri;
        }

        private void radCommandBarButtonItem1_Click(object sender, EventArgs e)
        {
            if (radPageView1.SelectedPage != null)
            {
                WebBrowser browser = (radPageView1.SelectedPage.Controls[0] as WebBrowser);
                browser.GoBack();
            }
        }

        private void radCommandBarButtonItem2_Click(object sender, EventArgs e)
        {
            if (radPageView1.SelectedPage != null)
            {
                WebBrowser browser = (radPageView1.SelectedPage.Controls[0] as WebBrowser);
                browser.GoForward();
            }
        }

        private void radCommandBarButtonItem3_Click(object sender, EventArgs e)
        {
            if (radPageView1.SelectedPage != null)
            {
                WebBrowser browser = (radPageView1.SelectedPage.Controls[0] as WebBrowser);
                browser.Refresh();
            }
        }

        private void radCommandBarButtonItem4_Click(object sender, EventArgs e)
        {
            if (radPageView1.SelectedPage != null)
            {
                WebBrowser browser = (radPageView1.SelectedPage.Controls[0] as WebBrowser);
                browser.Stop();
                browser.Parent.Text = "Stopped";
            }
        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (radPageView1.SelectedPage == null)
            {
                radCommandBarDropDownListItem1.Text = "";
                return;
            }

            WebBrowser browser = (radPageView1.SelectedPage.Controls[0] as WebBrowser);
            if (browser != null && browser.Url != null)
            {
                radCommandBarDropDownListItem1.Text = (radPageView1.SelectedPage.Controls[0] as WebBrowser).Url.AbsoluteUri;
            }
        }

        private void radMenuItem14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radMenuItem30_Click(object sender, EventArgs e)
        {
            //Telerik
            this.NavigateTo("http://www.telerik.com/products/winforms.aspx");
        }

        private void radMenuItem31_Click(object sender, EventArgs e)
        {
            this.NavigateTo("http://docs.telerik.com/");
        }

        private void radMenuItem32_Click(object sender, EventArgs e)
        {
            this.NavigateTo("http://www.telerik.com/community.aspx");
        }

        private void radCommandBarButtonItem1_MouseDown(object sender, MouseEventArgs e)
        {
            radCommandBarButtonItem1.Image = global::Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.arrow_left_pressed;
        }

        private void radCommandBarButtonItem1_MouseUp(object sender, MouseEventArgs e)
        {
            radCommandBarButtonItem1.Image = global::Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.arrow_left_hover;
        }

        private void radCommandBarButtonItem1_MouseEnter(object sender, EventArgs e)
        {
            radCommandBarButtonItem1.Image = global::Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.arrow_left_hover;
        }

        private void radCommandBarButtonItem1_MouseLeave(object sender, EventArgs e)
        {
            radCommandBarButtonItem1.Image = global::Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.arrow_left;
        }


        private void radCommandBarButtonItem2_MouseDown(object sender, MouseEventArgs e)
        {
            radCommandBarButtonItem2.Image = global::Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.arrow_right_pressed;
        }

        private void radCommandBarButtonItem2_MouseUp(object sender, MouseEventArgs e)
        {
            radCommandBarButtonItem2.Image = global::Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.arrow_right_hover;
        }

        private void radCommandBarButtonItem2_MouseEnter(object sender, EventArgs e)
        {
            radCommandBarButtonItem2.Image = global::Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.arrow_right_hover;
        }

        private void radCommandBarButtonItem2_MouseLeave(object sender, EventArgs e)
        {
            radCommandBarButtonItem2.Image = global::Telerik.Examples.WinControls.CommandBar.FirstLook.Resource1.arrow_right;
        }

        public void ApplyTheme(string themeName)
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, themeName);
        }
    }
}
