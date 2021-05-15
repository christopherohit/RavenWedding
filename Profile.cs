using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raven
{
    public partial class Profile : DevExpress.XtraEditors.XtraForm
    {
        public PictureBox SetImage { get { return this.image; } }
        public TextBox SetDes { get { return this.desc; } }
        public DevExpress.XtraEditors.TextEdit GetMails { get { return this.mails; } }
        public DevExpress.XtraEditors.TextEdit GetRegency { get { return this.regency; } }
        public DevExpress.XtraEditors.TextEdit Geticm { get { return this.icm; } }
        public Telerik.WinControls.UI.RadDateTimePicker GetBirth { get { return this.birth; } }
        public DevExpress.XtraEditors.TextEdit GetName { get { return this.name; } }
        public DevExpress.XtraEditors.TextEdit GetPhone { get { return this.phone; } }
        public DevExpress.XtraEditors.TextEdit GetGender { get { return this.gender; } }
        public DevExpress.XtraEditors.TextEdit GetAddress { get { return this.address; } }

        public Profile()
        {
            InitializeComponent();
        }
        private void radDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void windowsUIButtonPanelCloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit6_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void address_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}