using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.QuickStart.WinControls;
using System.Data.SqlClient;

namespace Telerik.Examples.WinControls.Calendar.SpecialDays
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();

			this.radCalendar1.SpecialDays[0].Image = this.imageList1.Images[0];
			this.radCalendar1.SpecialDays[1].Image = this.imageList1.Images[1];
			this.radCalendar1.ShowFastNavigationButtons = false;
		}

        //protected override void OnLoad(EventArgs e)
        //{
        //    ThemeResolutionService.ApplyThemeToControlTree(this.settingsPanel, MainForm.DefaultTheme);
        //}

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);

        //    this.radCalendar1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
        //}

        protected override void WireEvents()
        {

        }
	}
}