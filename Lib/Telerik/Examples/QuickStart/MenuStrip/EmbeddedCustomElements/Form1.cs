using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.MenuStrip.EmbeddedCustomElements
{
    public partial class Form1 : ExamplesForm
    {
        private RadDropDownList sizeDropDownList;
        private RadDropDownList fontDropDownList;
        private RadPageView pageView;
        private RadCommandBar commandBar;

        public Form1()
        {
            InitializeComponent();

            this.radMenuDemo.ThemeNameChanged += new ThemeNameChangedEventHandler(radMenuDemo_ThemeNameChanged);
            this.radMenuItem1.DropDown.MinimumSize = new Size(300, 0);
            this.radMenuItem2.DropDown.MinimumSize = new Size(300, 0);
        }

        void radMenuDemo_ThemeNameChanged(object source, ThemeNameChangedEventArgs args)
        {
            if (pageView != null)
            {
                pageView.ThemeName = this.radMenuDemo.ThemeName;
                sizeDropDownList.ThemeName = this.radMenuDemo.ThemeName;
                fontDropDownList.ThemeName = this.radMenuDemo.ThemeName;
                commandBar.ThemeName = this.radMenuDemo.ThemeName;
                if (this.radMenuDemo.ThemeName == "Office2007Black")
                {
                    radMenuDemo.MenuElement.ForeColor = Color.White;
                }
                else
                {
                    radMenuDemo.MenuElement.ResetValue(RadItem.ForeColorProperty, ValueResetFlags.Local);
                }
            }
        }


        void AddToolStrip()
        {
            commandBar = new RadCommandBar();
            commandBar.ThemeName = this.radMenuDemo.ThemeName;
            commandBar.ImageList = this.imageList1;
            commandBar.CommandBarElement.BackColor = Color.Transparent;

            CommandBarRowElement element = new CommandBarRowElement();
            element.BackColor = Color.Transparent;
            element.AllowDrag = false;
            element.StretchVertically = false;
            commandBar.Rows.Add(element);

            CommandBarStripElement toolStripItem = new CommandBarStripElement();
            toolStripItem.BackColor = Color.Transparent;
            toolStripItem.AllowDrag = false;
            toolStripItem.OverflowButton.Visibility = ElementVisibility.Collapsed;
            toolStripItem.StretchHorizontally = true;
            element.Strips.Add(toolStripItem);

            CommandBarButton button1 = new CommandBarButton();
            button1.ImageIndex = 0;
            toolStripItem.Items.Add(button1);

            CommandBarButton button2 = new CommandBarButton();
            button2.ImageIndex = 1;
            toolStripItem.Items.Add(button2);

            CommandBarButton button3 = new CommandBarButton();
            button3.ImageIndex = 2;
            toolStripItem.Items.Add(button3);

            CommandBarButton button4 = new CommandBarButton();
            button4.ImageIndex = 3;
            toolStripItem.Items.Add(button4);

            CommandBarButton button5 = new CommandBarButton();
            button5.ImageIndex = 4;
            toolStripItem.Items.Add(button5);

            commandBar.EndInit();

            RadMenuContentItem item = new RadMenuContentItem();
            item.BackColor = Color.Transparent;
            item.ContentElement = new RadHostItem(commandBar);
            item.MinSize = new Size(205, 65);
            item.MaxSize = new Size(250, 65);

            this.radMenuItem1.Items.Add(item);
        }

        void AddTabStrip()
        {
            fontDropDownList = new RadDropDownList();
            fontDropDownList.ThemeName = this.radMenuDemo.ThemeName;
            fontDropDownList.Margin = new Padding(25, 5, 5, 5);
            fontDropDownList.Text = "Select Font";
            fontDropDownList.Items.Add(new RadListDataItem("Arial"));
            fontDropDownList.Items.Add(new RadListDataItem("Tahoma"));
            fontDropDownList.Items.Add(new RadListDataItem("Times New Roman"));
            fontDropDownList.Items.Add(new RadListDataItem("Verdana"));

            sizeDropDownList = new RadDropDownList();
            sizeDropDownList.ThemeName = this.radMenuDemo.ThemeName;
            sizeDropDownList.Margin = new Padding(25, 5, 5, 5);
            sizeDropDownList.Text = "8";
            sizeDropDownList.Items.Add(new RadListDataItem("7"));
            sizeDropDownList.Items.Add(new RadListDataItem("8"));
            sizeDropDownList.Items.Add(new RadListDataItem("9"));
            sizeDropDownList.Items.Add(new RadListDataItem("10"));
            sizeDropDownList.Items.Add(new RadListDataItem("11"));
            sizeDropDownList.Items.Add(new RadListDataItem("12"));

            pageView = new RadPageView();
            pageView.ThemeName = this.radMenuDemo.ThemeName;
            RadPageViewPage fontPage = new RadPageViewPage();
            fontPage.Text = "Font";
            fontPage.Controls.Add(fontDropDownList);
            pageView.Pages.Add(fontPage);
            RadPageViewPage sizePage = new RadPageViewPage();
            sizePage.Text = "Size";
            sizePage.Controls.Add(sizeDropDownList);
            pageView.Pages.Add(sizePage);

            RadMenuContentItem contentItem = new RadMenuContentItem();
            contentItem.ContentElement = new RadHostItem(pageView);
            contentItem.MinSize = new Size(250, 120);
            contentItem.MaxSize = new Size(250, 120);

            this.radMenuItem2.Items.Insert(6, contentItem);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            AddToolStrip();
            AddTabStrip();
        }

        
    }
}