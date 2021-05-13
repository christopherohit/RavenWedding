using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Threading;

namespace SpellCheckAsYouType
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void radToggleButton1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radCheckBox1.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radSpellChecker1.AutoSpellCheckControl = this.textBox1;
            }
            else
            {
                this.radSpellChecker1.AutoSpellCheckControl = null;
            }

        }

        private void radToggleButton2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radCheckBox2.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radSpellChecker2.AutoSpellCheckControl = this.radTextBox1;
            }
            else
            {
                this.radSpellChecker2.AutoSpellCheckControl = null;
            }
        }

        private void radCheckBox3_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radCheckBox3.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radSpellChecker3.AutoSpellCheckControl = this.radTextBoxControl1;
            }
            else
            {
                this.radSpellChecker3.AutoSpellCheckControl = null;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {   
            this.radSpellChecker1.AutoSpellCheckControl = this.textBox1;
            this.radSpellChecker2.AutoSpellCheckControl = this.radTextBox1;
            this.radSpellChecker3.AutoSpellCheckControl = this.radTextBoxControl1;
        }

        
    }
}
