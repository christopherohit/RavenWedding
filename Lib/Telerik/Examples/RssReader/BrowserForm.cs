using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace RssReader
{
    public partial class BrowserForm : Telerik.WinControls.UI.RadForm
    {
        public BrowserForm()
        {
            InitializeComponent();
        }

        public WebBrowser WebBrowser
        {
            get
            {
                return this.webBrowser1;
            }
        }
    }
}
