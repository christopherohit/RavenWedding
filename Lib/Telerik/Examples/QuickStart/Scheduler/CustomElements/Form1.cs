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

namespace Telerik.Examples.WinControls.Scheduler.CustomElements
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
         
            radScheduler1.ElementProvider = new MyElementProvider(radScheduler1);
            radScheduler1.GetDayView().StartDate = DateTime.Now.AddDays(-1);
            radScheduler1.GetDayView().AutoScrollToWorkTime = true;
            radScheduler1.Appointments.Add(new Appointment(DateTime.Now.AddHours(-5).AddDays(-1), DateTime.Now.AddHours(-3).AddDays(-1), "WinForms Q2 release\n", "", ""));
            radScheduler1.Appointments.Add(new Appointment(DateTime.Now.AddHours(-4).AddDays(0), DateTime.Now.AddHours(-2).AddDays(0), "DevCraft official release\n", "", ""));
            radScheduler1.Appointments.Add(new Appointment(DateTime.Now.AddDays(1), DateTime.Now.AddDays(1).AddHours(2), "DevCraft keynote\n", "", "Boston"));
            foreach (Appointment item in radScheduler1.Appointments)
            {
                 TimeSpan reminder = TimeSpan.FromMinutes( 15 );

                 item.Reminder = reminder;
            }
        }
    }
}