using System;
using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.DropDownListAndListControl.FontDropDownList
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.SetupLayout();
        }

        private void Element_PreviewFontChanged(object sender, EventArgs e)
        {
            this.SetFont(radFontDropDownList1.FontDropDownList.PreviewFont);
        }

        private void RadFontDropDownList1_SelectedFontChanged(object sender, EventArgs e)
        {
            this.SetFont(radFontDropDownList1.FontDropDownList.SelectedFont);
        }

        public void SetFont(string fontName)
        {
            FontFamily ff = new FontFamily(fontName);
            if (ff.IsStyleAvailable(FontStyle.Regular))
            {
                Font font = new Font(ff.Name, 10, FontStyle.Regular);
                this.radLabel1.Font = font;
            }
            else
            {
                foreach (FontStyle style in Enum.GetValues(typeof(FontStyle)))
                {
                    if (ff.IsStyleAvailable(style))
                    {
                        Font font = new Font(ff.Name, 10, style);
                        this.radLabel1.Font = font;
                        break;
                    }
                }
            }
        }

        private void radCheckBox1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radFontDropDownList1.FontDropDownList.ShowRecentlyUsedFonts = radCheckBox1.Checked;
        }

        private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            this.radFontDropDownList1.FontDropDownList.RecentlyUsedItemsCount = (int)this.radSpinEditor1.Value;
        }

        private void radCheckBox2_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radFontDropDownList1.FontDropDownList.SelectOnHover = this.radCheckBox2.Checked;
        }

        public void SetupLayout()
        {
            this.radFontDropDownList1.FontDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown;
            this.radFontDropDownList1.FontDropDownList.SelectedFontChanged += RadFontDropDownList1_SelectedFontChanged;
            this.radFontDropDownList1.FontDropDownList.SelectedFont = "Segoe UI";

            this.radFontDropDownList1.FontDropDownList.PreviewFontChanged += Element_PreviewFontChanged;
            this.radFontDropDownList1.FontDropDownList.SelectOnHover = true;

            this.commandBarButton1.CustomFont = "TelerikWebUI";
            this.commandBarButton2.CustomFont = "TelerikWebUI";
            this.commandBarButton5.CustomFont = "TelerikWebUI";
            this.commandBarButton6.CustomFont = "TelerikWebUI";
            this.commandBarButton7.CustomFont = "TelerikWebUI";

            this.commandBarStripElement1.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.OnThemeChanged();
        }

        public override void OnThemeChanged()
        {
            base.OnThemeChanged();
            switch (this.CurrentThemeName)
            {
                case "Crystal":
                    SetColor(Color.FromArgb(0, 96, 207), Color.FromArgb(180, 0, 0, 0), Color.FromArgb(45, 45, 45), Color.FromArgb(0, 96, 207), Color.FromArgb(230, 241, 247), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(211, 211, 211), Color.FromArgb(234, 234, 234));
                    break;
                case "CrystalDark":
                    SetColor(Color.FromArgb(0, 96, 207), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), Color.FromArgb(124, 183, 249), Color.FromArgb(52, 52, 52), Color.FromArgb(255, 255, 255), Color.FromArgb(37, 37, 37), Color.FromArgb(77, 77, 77), Color.FromArgb(52, 52, 52));
                    break;
                case "FluentDark":
                    SetColor(Color.FromArgb(0, 153, 188), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), Color.FromArgb(0, 191, 232), Color.FromArgb(43, 43, 43), Color.FromArgb(255, 255, 255), Color.FromArgb(0, 0, 0), Color.FromArgb(76, 76, 76), Color.FromArgb(0, 0, 0));
                    break;
                case "ControlDefault":
                    SetColor(Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 191, 232), Color.FromArgb(255, 255, 255), Color.FromArgb(0, 0, 0), Color.FromArgb(233, 240, 249), Color.FromArgb(110, 153, 210), Color.FromArgb(191, 219, 255));
                    break;
                case "Fluent":
                    SetColor(Color.FromArgb(0, 153, 188), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 191, 232), Color.FromArgb(242, 242, 242), Color.FromArgb(0, 0, 0), Color.FromArgb(249, 249, 249), Color.FromArgb(197, 197, 197), Color.FromArgb(197, 197, 197));
                    break;
                case "Aqua":
                    SetColor(Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(45, 137, 220), Color.FromArgb(255, 255, 255), Color.FromArgb(0, 0, 0), Color.FromArgb(236, 236, 236), Color.FromArgb(114, 114, 114), Color.FromArgb(139, 139, 139));
                    break;
                case "Office2013Dark":
                case "Office2013Light":
                    SetColor(Color.FromArgb(0, 114, 198), Color.FromArgb(0, 0, 0), Color.FromArgb(68, 68, 68), Color.FromArgb(0, 114, 198), Color.FromArgb(205, 230, 247), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(198, 198, 198), Color.FromArgb(255, 255, 255));
                    break;

                case "Breeze":
                    SetColor(Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 50, 152), Color.FromArgb(240, 246, 254), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(207, 207, 207), Color.FromArgb(255, 255, 255));
                    break;
                case "Windows8":
                    SetColor(Color.FromArgb(0, 102, 204), Color.FromArgb(0, 0, 0), Color.FromArgb(68, 68, 68), Color.FromArgb(0, 102, 204), Color.FromArgb(209, 232, 255), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(217, 217, 217), Color.FromArgb(239, 239, 239));
                    break;
                case "VisualStudio2012Dark":
                    SetColor(Color.FromArgb(241, 241, 241), Color.FromArgb(255, 255, 255), Color.FromArgb(241, 241, 241), Color.FromArgb(0, 122, 204), Color.FromArgb(62, 62, 66), Color.FromArgb(241, 241, 241), Color.FromArgb(45, 45, 48), Color.FromArgb(63, 63, 70), Color.FromArgb(37, 37, 38));
                    break;
                case "VisualStudio2012Light":
                    SetColor(Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 122, 204), Color.FromArgb(239, 239, 242), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(204, 206, 219), Color.FromArgb(239, 239, 242));
                    break;
                case "TelerikMetro":
                    SetColor(Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(87, 89, 82), Color.FromArgb(128, 181, 2), Color.FromArgb(244, 246, 236), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(196, 199, 182), Color.FromArgb(255, 255, 255));
                    break;
                case "TelerikMetroTouch":
                    SetColor(Color.FromArgb(128, 181, 2), Color.FromArgb(0, 0, 0), Color.FromArgb(87, 89, 82), Color.FromArgb(128, 181, 2), Color.FromArgb(244, 246, 236), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(196, 199, 182), Color.FromArgb(255, 255, 255));
                    break;
                case "TelerikMetroBlue":
                    SetColor(Color.FromArgb(27, 161, 226), Color.FromArgb(0, 0, 0), Color.FromArgb(87, 89, 82), Color.FromArgb(27, 161, 226), Color.FromArgb(243, 248, 255), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(196, 199, 182), Color.FromArgb(255, 255, 255));
                    break;
                case "Office2010Black":
                    SetColor(Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(216, 80, 0), Color.FromArgb(224, 224, 224), Color.FromArgb(0, 0, 0), Color.FromArgb(207, 207, 207), Color.FromArgb(110, 110, 110), Color.FromArgb(146, 146, 146));
                    break;
                case "Office2010Silver":
                    SetColor(Color.FromArgb(39, 45, 52), Color.FromArgb(0, 0, 0), Color.FromArgb(39, 45, 52), Color.FromArgb(216, 80, 0), Color.FromArgb(246, 247, 248), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(183, 187, 192), Color.FromArgb(225, 228, 232));
                    break;
                case "HighContrastBlack":
                    SetColor(Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), Color.FromArgb(0, 128, 0), Color.FromArgb(169, 169, 169), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(0, 0, 0));
                    break;
                case "Windows7":
                    SetColor(Color.FromArgb(0, 51, 153), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 51, 153), Color.FromArgb(32, 136, 220), Color.FromArgb(225, 234, 245), Color.FromArgb(0, 0, 0), Color.FromArgb(250, 254, 255), Color.FromArgb(157, 178, 199), Color.FromArgb(255, 255, 255));
                    break;
                case "Material":
                    SetColor(Color.FromArgb(63, 81, 181), Color.FromArgb(0, 0, 0), Color.FromArgb(63, 81, 181), Color.FromArgb(255, 145, 0), Color.FromArgb(244, 244, 244), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255));
                    break;
                case "Office2007Silver":
                    SetColor(Color.FromArgb(0, 28, 85), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 28, 85), Color.FromArgb(251, 105, 0), Color.FromArgb(220, 224, 231), Color.FromArgb(0, 0, 0), Color.FromArgb(243, 246, 251), Color.FromArgb(185, 188, 194), Color.FromArgb(220, 224, 231));
                    break;
                case "Office2007Black":
                    SetColor(Color.FromArgb(86, 87, 91), Color.FromArgb(0, 0, 0), Color.FromArgb(86, 87, 91), Color.FromArgb(251, 105, 0), Color.FromArgb(220, 224, 231), Color.FromArgb(0, 0, 0), Color.FromArgb(227, 229, 234), Color.FromArgb(77, 77, 77), Color.FromArgb(240, 241, 242));
                    break;
                case "Desert":
                    SetColor(Color.FromArgb(74, 72, 58), Color.FromArgb(74, 72, 58), Color.FromArgb(74, 72, 58), Color.FromArgb(196, 97, 36), Color.FromArgb(246, 246, 237), Color.FromArgb(74, 72, 58), Color.FromArgb(255, 255, 255), Color.FromArgb(138, 137, 119), Color.FromArgb(221, 221, 208));
                    break;
                case "Office2010Blue":
                    SetColor(Color.FromArgb(15, 76, 144), Color.FromArgb(0, 0, 0), Color.FromArgb(15, 76, 144), Color.FromArgb(216, 80, 0), Color.FromArgb(239, 246, 255), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(191, 215, 245), Color.FromArgb(239, 246, 255));
                    break;
                case "MaterialTeal":
                    SetColor(Color.FromArgb(0, 150, 136), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 150, 136), Color.FromArgb(255, 82, 82), Color.FromArgb(244, 244, 244), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.Transparent, Color.FromArgb(255, 255, 255));
                    break;
                case "MaterialPink":
                    SetColor(Color.FromArgb(233, 30, 99), Color.FromArgb(0, 0, 0), Color.FromArgb(233, 30, 99), Color.FromArgb(68, 138, 255), Color.FromArgb(244, 244, 244), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.Transparent, Color.FromArgb(255, 255, 255));
                    break;
                case "MaterialBlueGrey":
                    SetColor(Color.FromArgb(96, 125, 139), Color.FromArgb(0, 0, 0), Color.FromArgb(96, 125, 139), Color.FromArgb(0, 230, 118), Color.FromArgb(244, 244, 244), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255), Color.Transparent, Color.FromArgb(255, 255, 255));
                    break;

            }
            if (TelerikHelper.IsMaterialTheme(this.CurrentThemeName))
            {
                this.doubleBufferedTableLayoutPanel1.RowStyles[6].Height = 1F;
            }
        }

        public void SetColor(Color mainLabel, Color secondLabel, Color thirdLabel, Color fourtLabel, Color textBackColor, Color textForeColor, Color panelColor, Color borderColor, Color paddingColor)
        {
            this.radLabel3.ForeColor = mainLabel;
            this.radLabel4.ForeColor = secondLabel;
            this.radLabel5.ForeColor = thirdLabel;
            this.radLabel1.BackColor = textBackColor;
            this.radLabel6.ForeColor = fourtLabel;
            this.radLabel1.ForeColor = textForeColor;
            this.doubleBufferedTableLayoutPanel1.BackColor = panelColor;
            this.borderPanel.PanelElement.PanelBorder.ForeColor = borderColor;
        }
    }
}