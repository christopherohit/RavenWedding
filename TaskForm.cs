using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.Docking2010;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;

namespace Raven
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }



        private void pagerEvents1_CustomizePagerItem_1(object sender, CustomizePagerItemEventArgs e)
        {
            WindowsUIButton btn = e.Item as WindowsUIButton;
            WindowsUIButtonPanel btnPanel = btn.GetOwner() as WindowsUIButtonPanel;
            NavigationPage page = e.Page as NavigationPage;
            if (btn == null || btnPanel == null || page == null)
            {
                int index = btnPanel.Buttons.IndexOf(btn);
                btn.Caption = page.ToString();
                btn.UseCaption = true;
                btn.ImageOptions.ImageIndex = index;
            }
        }

        private void windowsUIButtonPanelMain_Click(object sender, ButtonEventArgs e)
        {
            string tag = ((WindowsUIButton)e.Button).Caption.ToString();
            switch (tag)
            {
                case "Home":
                    Main ea = new Main();
                    ea.Show();
                    this.Hide();
                    break;
                case "Task":
                    
                    break;
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
