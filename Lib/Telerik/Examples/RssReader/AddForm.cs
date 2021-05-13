using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RssReader
{
    public partial class AddForm : Telerik.WinControls.UI.RadForm
    {
        public AddForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            radTextBox1.Focus();
        }

        public RadLabel Label
        {
            get
            {
                return this.radLabel1;
            }
        }

        public bool RaiseErrorOnEmptyString { get; set; }

        string errorText;
        public string ErrorText
        {
            get
            {
                return this.errorText;
            }

            set
            {
                this.errorText = value;
            }
        }

        public RadTextBox TextBox
        {
            get
            {
                return this.radTextBox1;
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (RaiseErrorOnEmptyString && string.IsNullOrEmpty(radTextBox1.Text))
            {
                errorProvider1.SetIconAlignment(radTextBox1, ErrorIconAlignment.MiddleLeft);
                errorProvider1.SetError(this.radTextBox1, errorText);
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
