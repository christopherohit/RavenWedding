using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.LayoutControl.Settings
{
    public partial class Form1 : ExamplesForm
    {
        LayoutControlItem lastTeamMemberItem;
        int lastTeamMemberNumber = 4;
        
        public Form1()
        {
            InitializeComponent();
            lastTeamMemberItem = this.layoutControlItem6;
        }

        private void radButtonAddMember_Click(object sender, EventArgs e)
        {
            LayoutControlItem newTeamMemberItem = new LayoutControlItem();
            newTeamMemberItem.AssociatedControl = new RadTextBoxControl() { ThemeName = this.radLayoutControl1.ThemeName };

            newTeamMemberItem.DrawText = true;
            newTeamMemberItem.Image = global::Telerik.Examples.WinControls.Properties.Resources.user;
            newTeamMemberItem.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            newTeamMemberItem.ImageLayout = System.Windows.Forms.ImageLayout.None;
            newTeamMemberItem.MaxSize = new System.Drawing.Size(0, 52);
            newTeamMemberItem.MinSize = new System.Drawing.Size(46, 52);
            newTeamMemberItem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            newTeamMemberItem.TextFixedSize = 26;
            newTeamMemberItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            newTeamMemberItem.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top;
            newTeamMemberItem.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed;
        
            newTeamMemberItem.Text = String.Format("Team Member {0}", ++lastTeamMemberNumber);

            this.radLayoutControl1.AddItem(newTeamMemberItem, lastTeamMemberItem, LayoutControlDropPosition.Bottom);
            this.lastTeamMemberItem = newTeamMemberItem;
        }

        private void radButtonCustomize_Click(object sender, EventArgs e)
        {
            this.radLayoutControl1.ShowCustomizeDialog();
        }

        private void radButtonSaveLayout_Click(object sender, EventArgs e)
        {

            OnSaveLayoutButtonClick();
        }

        private void radButtonLoadLayout_Click(object sender, EventArgs e)
        {
            OnLoadLayoutButtonClick();
        }

        protected virtual void OnSaveLayoutButtonClick()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.DefaultExt = ".xml";
                sfd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.radLayoutControl1.SaveLayout(sfd.FileName);
                }
            }
        }

        protected virtual void OnLoadLayoutButtonClick()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.DefaultExt = ".xml";
                ofd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.radLayoutControl1.LoadLayout(ofd.FileName);
                }
            }
        }

    }
}
