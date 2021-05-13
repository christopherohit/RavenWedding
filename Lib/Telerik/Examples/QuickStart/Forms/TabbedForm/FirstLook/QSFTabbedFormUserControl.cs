using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Forms.TabbedForm.FirstLook
{
    public partial class QSFTabbedFormUserControl : UserControl, ISupportThemeName
    {
        public QSFTabbedFormUserControl()
        {
            InitializeComponent();
            this.SetTexts();
            radButtonElement2.Click += RadButtonElement2_Click;
        }

        public void SetupVisibility()
        {
            RadTabbedFormControlTab tab = this.Parent as RadTabbedFormControlTab;
            if (tab == null || tab.Owner == null) return;

            RadTabbedFormControl tabbedControl = tab.Owner;
            int tabCount = tabbedControl.Tabs.Count;

            this.radButton2.Visible =
                this.radLabel2.Visible = tabCount >= 2;

            this.radButton3.Visible =
                this.radLabel3.Visible = tabCount >= 3;

            this.radButton5.Visible =
                this.radLabel4.Visible = tabCount >= 4;

            this.radButton4.Visible =
                this.radLabel5.Visible = tabCount >= 5;

        }

        void SetTexts()
        {
            SetText(this.radButtonElement2, "\ue80d");
            radButtonElement2.TextElement.CustomFontSize = 12;
            SetText(this.radButtonElement3, "\ue81f");
            radButtonElement3.TextElement.CustomFontSize = 12;
            SetText(this.radButtonElement4, "\ue80b");
            radButtonElement4.TextElement.CustomFontSize = 12;

            SetText(this.radButton1.ButtonElement, "\ue80d");
            this.radLabel1.Text = "google";
            SetText(this.radButton2.ButtonElement, "\ue91b");//, "\ue81f");
            this.radLabel2.Text = "new tab 1";
            SetText(this.radButton3.ButtonElement, "\ue91b");//, "\ue80b");
            this.radLabel3.Text = "new tab 2";
            SetText(this.radButton4.ButtonElement, "\ue91b");
            this.radLabel4.Text = "new tab3";
            SetText(this.radButton5.ButtonElement, "\ue91b");
            this.radLabel5.Text = "new tab4";
        }

        public static void SetText(RadButtonElement buttonElement, string text)
        {
            buttonElement.TextElement.CustomFontSize = 18;
            buttonElement.TextElement.CustomFont = "TelerikWebUI";
            buttonElement.Text = text;
            buttonElement.TextElement.TextRenderingHint = TextRenderingHint.AntiAlias;
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);

            this.CenterControl(this.Parent);
            RadTabbedFormControlTab tab = this.Parent as RadTabbedFormControlTab;
            if (tab != null)
            {
                RadTabbedFormControl tabbedControl = tab.Owner;
                tabbedControl.TabAdded -= RadTabbedFormControl1_TabAdded;
                tabbedControl.TabRemoved -= RadTabbedFormControl1_TabRemoved;
                tabbedControl.TabAdded += RadTabbedFormControl1_TabAdded;
                tabbedControl.TabRemoved += RadTabbedFormControl1_TabRemoved;
                if (tabbedControl.FindForm() != null)
                {
                    tabbedControl.FindForm().SizeChanged += QSFTabbedFormUserControl_SizeChanged;
                }
            }
        }

        private void QSFTabbedFormUserControl_SizeChanged(object sender, EventArgs e)
        {
            this.CenterControl(this.FindForm());
        }

        private void RadButtonElement2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.radButtonTextBox1.Text))
                {
                    System.Diagnostics.Process.Start("https://www.google.com/search?q=" + this.radButtonTextBox1.Text);
                }
            }
            catch { }
        }

        private void RadTabbedFormControl1_TabRemoved(object sender, Telerik.WinControls.UI.RadTabbedFormControlEventArgs e)
        {
            this.SetupVisibility();
        }

        private void RadTabbedFormControl1_TabAdded(object sender, Telerik.WinControls.UI.RadTabbedFormControlEventArgs e)
        {
            this.SetupVisibility();
        }

        public void CenterControl(Control parent)
        {
            if (parent == null)
            {
                return;
            }

            Point location = new Point(parent.ClientSize.Width / 2 - this.Size.Width / 2,
                parent.ClientSize.Height / 2 - this.Size.Height / 2);
            if (location.X < 0)
            {
                location.X = 0;
            }
            if (location.Y < 0)
            {
                location.Y = 0;
            }

            this.Location = location;
        }

        public void ApplyTheme(string themeName)
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, themeName);
        }
    }
}
