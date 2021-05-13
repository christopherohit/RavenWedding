using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RichTextEditor
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            this.radWaitingBar1.ThemeName = Program.ThemeName;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.radWaitingBar1.StartWaiting();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.radWaitingBar1.StopWaiting();
        }

    }
}
