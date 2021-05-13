using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Editors.ButtonTextBox
{
    public partial class Form1 : ExamplesForm
    {
        private List<string> glyphs = new List<string>();
        
        public Form1()
        {
            this.InitializeComponent();
            this.glyphs.Add(""); // facebook
            this.glyphs.Add(""); // google
            this.glyphs.Add(""); // linkedin
            this.glyphs.Add(""); // pinterest

            this.SetupButtons();
            this.CreateButtonElement(this.glyphs[0]);
            this.radButtonTextBox1.AutoSize = false;
            this.radButtonTextBox1.Text = string.Empty;
        }

        public void SetupButtons()
        {
            foreach (string glyph in this.glyphs)
            {
                RadButton button = new RadButton();
                button.DisplayStyle = DisplayStyle.Text;
                button.ButtonElement.TextElement.CustomFont = "TelerikWebUI";
                button.ButtonElement.TextElement.CustomFontSize = 18;
                button.ButtonElement.TextElement.TextRenderingHint = TextRenderingHint.AntiAlias;
                button.Text = glyph;
                button.Size = new Size(56, 56);
                button.Margin = new Padding(12);
                this.doubleBufferedFlowLayoutPanel1.Controls.Add(button);
                button.Scale(this.radButtonTextBox1.RootElement.DpiScaleFactor);
                button.Click += Button_Click;
            }
        }

        private void CreateButtonElement(string text)
        {
            RadButtonElement radButtonElement = new RadButtonElement();
            radButtonElement.DisplayStyle = DisplayStyle.Text;
            radButtonElement.TextElement.CustomFont = "TelerikWebUI";
            radButtonElement.TextElement.CustomFontSize = 12;
            radButtonElement.TextElement.TextRenderingHint = TextRenderingHint.AntiAlias;
            radButtonElement.Text = text;
            radButtonElement.Click += RadButtonElement_Click;
            if (this.radRadioButton1.IsChecked)
            {
                this.radButtonTextBox1.RightButtonItems.Add(radButtonElement);
            }
            else
            {
                this.radButtonTextBox1.LeftButtonItems.Add(radButtonElement);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.CreateButtonElement(((RadButton)sender).Text);
        }

        private void RadButtonElement_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.google.com/search?q=" + this.radButtonTextBox1.Text.TrimEnd());
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.radButtonTextBox1.RightButtonItems.Clear();
            this.radButtonTextBox1.LeftButtonItems.Clear();
        }
    }
}