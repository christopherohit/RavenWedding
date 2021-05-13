using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Editors.TextBoxControl
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
    
        public Form1()
        {
            InitializeComponent();
            this.radPanel1.PanelElement.PanelFill.Visibility = ElementVisibility.Hidden;
            this.radTextBoxControl1.TextBoxElement.BackgroundImageLayout = ImageLayout.Stretch;
        }

        protected override void WireEvents()
        {
            this.radBtnSetBackgroundImage.Click += this.radBtnSetBackgroundImage_Click;
            this.radButtonSearch.Click += this.radButtonSearch_Click;
        }

        private void radBtnSetBackgroundImage_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Multiselect = false;
                fileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF;*.PNG;";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image image = Image.FromStream(fileDialog.OpenFile());
                    this.radTextBoxControl1.TextBoxElement.BackgroundImage = image;
                }
            }
        }

        private void radButtonSearch_Click(object sender, System.EventArgs e)
        {
            string text = this.radTextBoxControl1.Text;

            if (!TelerikHelper.StringIsNullOrWhiteSpace(text))
            {
                string query = string.Format("http://www.bing.com/search?q={0}", text);
                Process.Start(query);
            }
        }
    }
}
