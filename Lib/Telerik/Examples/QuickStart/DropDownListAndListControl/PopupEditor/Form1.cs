using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.DropDownListAndListControl.PopupEditor
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            this.InitializeComponent();
            this.radCalendar1.SelectedDate = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.radPopupEditor1.Text = string.Format("{0} {1}", this.radCalendar1.FocusedDate.Date.ToString("yyyy/MM/dd"), DateTime.Now.ToString("HH:mm:ss"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
           
        }      
    }
}