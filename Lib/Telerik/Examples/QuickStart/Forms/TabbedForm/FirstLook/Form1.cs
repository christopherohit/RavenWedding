using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Forms.TabbedForm.FirstLook
{
    public partial class Form1 : RadTabbedForm, ISupportThemeName
    {
        public Form1()
        {
            InitializeComponent();
            this.AllowAero = false;
            this.TabbedFormControl.TabbedFormControlElement.ItemDragService.TabbedFormShown += ItemDragService_TabbedFormShown;
        }

        private void ItemDragService_TabbedFormShown(object sender, TabbedFormShownEventArgs e)
        {
            e.TabbedForm.TabbedFormControlCreating -= TabbedForm_TabbedFormControlCreating;
            e.TabbedForm.TabbedFormControlCreating += TabbedForm_TabbedFormControlCreating;
        }

        private void TabbedForm_TabbedFormControlCreating(object sender, TabbedFormControlCreatingEventArgs e)
        {
            e.TabbedFormControl.Tabs[0].Controls.Clear();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (this.radTabbedFormControl1.SelectedTab != null && this.radTabbedFormControl1.SelectedTab.Controls.Count == 0)
            {
                this.AddUserControl();
            }
        }
        
        void SetTexts()
        {
            SetText(this.radButtonElement1, "\ue501");
            radButtonElement1.TextElement.CustomFontSize = 12;          
        }

        public static void SetText(RadButtonElement buttonElement, string text)
        {
            buttonElement.TextElement.CustomFontSize = 18;
            buttonElement.TextElement.CustomFont = "TelerikWebUI";
            buttonElement.Text = text;
            buttonElement.TextElement.TextRenderingHint = TextRenderingHint.AntiAlias;
        }

        private void radTabbedFormControl1_SelectedTabChanged(object sender, EventArgs e)
        {
            if(this.radTabbedFormControl1.SelectedTab !=null && this.radTabbedFormControl1.SelectedTab.Controls.Count==0)
            {
                this.AddUserControl();
            }
        }

        private void AddUserControl()
        {
            QSFTabbedFormUserControl qSFTabbedFormUserControl = new QSFTabbedFormUserControl();
            qSFTabbedFormUserControl.ApplyTheme(this.ThemeName);
            this.radTabbedFormControl1.SelectedTab.Controls.Add(qSFTabbedFormUserControl);
            qSFTabbedFormUserControl.SetupVisibility();
            qSFTabbedFormUserControl.CenterControl(this);
        }

        public void ApplyTheme(string themeName)
        {
            this.ThemeName = themeName;
            ThemeResolutionService.ApplyThemeToControlTree(this, themeName);
        }

        private void radTabbedFormControl1_TabAdded(object sender, RadTabbedFormControlEventArgs e)
        {
            if (e.Tab.Controls.Count == 0)
            {
                QSFTabbedFormUserControl qSFTabbedFormUserControl = new QSFTabbedFormUserControl();
                qSFTabbedFormUserControl.ApplyTheme(this.ThemeName);
                e.Tab.Controls.Add(qSFTabbedFormUserControl);
                e.Tab.Owner.SelectedTab = e.Tab;
                qSFTabbedFormUserControl.SetupVisibility();
                qSFTabbedFormUserControl.CenterControl(this);
            }
        }
    }
}
