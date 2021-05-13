using System;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace RssReader
{
    public partial class ChangeCategoryForm : RadForm
    {
        public ChangeCategoryForm()
        {
            InitializeComponent();
            radDropDownList1.DropDownStyle = RadDropDownStyle.DropDownList;
        }

        public RadCheckBox CheckBox
        {
            get
            {
                return this.radCheckBox1;
            }
        }

        public RadDropDownList RadDropDownList
        {
            get
            {
                return this.radDropDownList1;
            }
        }

        public RadTextBox NewCategoryNameTextBox
        {
            get
            {
                return this.radTextBox1;
            }
        }

        public RadTextBox NameTextBox
        {
            get
            {
                return this.radTextBox2;
            }
        }
        
        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                radTextBox1.Enabled = true;
                radDropDownList1.Enabled = false;
            }
            else
            {
                radTextBox1.Enabled = false;
                radDropDownList1.Enabled = true;
            }
        }

        public string ErrorText { get; set; }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (radCheckBox1.ToggleState == ToggleState.On && string.IsNullOrEmpty(this.radTextBox1.Text))
            {
                errorProvider1.SetIconAlignment(this.radTextBox1, ErrorIconAlignment.MiddleLeft);
                errorProvider1.SetError(this.radTextBox1, this.ErrorText);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.NameTextBox.TextBoxElement.TextBoxItem.HostedControl.Focus();
        }       
    }
}
