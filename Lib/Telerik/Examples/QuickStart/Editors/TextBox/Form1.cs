using System;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Editors.TextBox
{
    /// <summary>
    /// example form         
    /// </summary>
	public partial class Form1 : EditorExampleBaseForm
	{
		public Form1()
		{
			InitializeComponent();
		}    

        protected override void WireEvents()
        {
            this.radTxtDemo2.TextChanging += new TextChangingEventHandler(this.radTextBox2_TextChanging);
            this.radTxtNullText.TextChanged += new EventHandler(this.radTxtNullText_TextChanged);
            this.radCheckBoxShowClearButton.ToggleStateChanged += radCheckBoxShowClearButton_ToggleStateChanged;
        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			radTxtDemo1.NullText = this.radTxtNullText.Text;
		}

		private void radTextBox2_TextChanging(object sender, TextChangingEventArgs e)
		{
			e.Cancel = this.radCheckCancel.Checked;            
			this.radLblOldValue.Text = "Old Value: " + e.OldValue;
			this.radLblNewValue.Text = "New Value: " + e.NewValue;
		}

        private void radTxtNullText_TextChanged(object sender, EventArgs e)
        {
            radTxtDemo1.NullText = this.radTxtNullText.Text;
            radTxtDemo2.NullText = this.radTxtNullText.Text;
        }

        private void radCheckBoxShowClearButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radTxtDemo1.ShowClearButton = this.radCheckBoxShowClearButton.IsChecked;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radTxtDemo2.AcceptsReturn = true;
        }
	}
}