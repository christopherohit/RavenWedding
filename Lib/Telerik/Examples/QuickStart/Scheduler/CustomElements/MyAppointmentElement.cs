using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Scheduler.CustomElements
{
    public class MyAppointmentElement : AppointmentElement
    {
        LightVisualElement icon;

        public MyAppointmentElement(RadScheduler scheduler, SchedulerView view, IEvent appointment) : base(scheduler, view, appointment)
        {
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(AppointmentElement);
            }
        }

        protected override void InitializeAppointment()
        {
            base.InitializeAppointment();

            this.BackColor = ColorTranslator.FromHtml("#FFFCD9");
            this.GradientStyle = Telerik.WinControls.GradientStyles.Solid;

            this.BorderColor = ColorTranslator.FromHtml("#C4C7B6");          
            this.BorderWidth = 3;
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            
            this.icon = new LightVisualElement();

            this.icon.ShouldHandleMouseInput = false;
            this.icon.NotifyParentOnMouseInput = true;
            this.icon.Alignment = ContentAlignment.BottomRight;
            this.icon.StretchHorizontally = false;
            this.icon.StretchVertically = false;

            this.Children.Add(icon);
        }

        public override void Synchronize()
        {
            base.Synchronize();
            Appointment apointment = this.Appointment as Appointment;
            TimeSpan timeToAppoinmet = this.Appointment.Start - DateTime.Now;
            if (apointment.Reminder != null)
            {
                if (apointment.MasterEvent != null)
                {
                    icon.Margin = new System.Windows.Forms.Padding(0, 0, 10, -4);
                }
                else
                {
                    icon.Margin = new System.Windows.Forms.Padding(0);
                }
                icon.Image = Image.FromFile(@"..\Resources\reminder-icon.png");
                this.icon.ToolTipText = string.Format("Time to apportionment {0} hours and {1} minutes.", timeToAppoinmet.Hours, timeToAppoinmet.Minutes);
            }
            else
            {
                icon.Image = null;
            }
        }
    }
}