using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Scheduler.CustomElements
{
    public class MySchedulerCellElement : SchedulerCellElement
    {
        LightVisualElement hoverElemnt;
       
        public MySchedulerCellElement(RadScheduler scheduler, SchedulerView view) : base(scheduler, view)
        {
            scheduler.ContextMenuOpening += scheduler_ContextMenuOpening;
        }

        void scheduler_ContextMenuOpening(object sender, SchedulerContextMenuOpeningEventArgs e)
        {
            if (!(e.Element is AppointmentElement))
            {
                e.Cancel = true;
            }
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            hoverElemnt = new LightVisualElement();
            hoverElemnt.ShouldHandleMouseInput = true;
            hoverElemnt.NotifyParentOnMouseInput = false;
            hoverElemnt.StretchHorizontally = true;
            hoverElemnt.Text = "";
            hoverElemnt.TextAlignment = ContentAlignment.MiddleLeft;
            hoverElemnt.DrawFill = true;
            hoverElemnt.ForeColor = ColorTranslator.FromHtml("#FFB452");
            hoverElemnt.GradientStyle = GradientStyles.Solid;
          
            hoverElemnt.MouseEnter += buttonElemnt_MouseEnter;
            hoverElemnt.MouseLeave += buttonElemnt_MouseLeave;
            hoverElemnt.Click += hoverElemnt_Click;
         
            this.Children.Add(hoverElemnt);
        }

        void hoverElemnt_Click(object sender, EventArgs e)
        {
            DateTime end = this.Date + this.Duration;

            DateTimeInterval interval = new DateTimeInterval(this.Date, end);
            this.Scheduler.AddNewAppointmentWithDialog(interval, false, null);
        }

        void buttonElemnt_MouseLeave(object sender, EventArgs e)
        {
            hoverElemnt.BackColor = Color.Transparent;        
            hoverElemnt.Text = "";
        }

        void buttonElemnt_MouseEnter(object sender, EventArgs e)
        {
            hoverElemnt.BackColor = ColorTranslator.FromHtml("#FFFBD8");           
            hoverElemnt.Text = "Click here to add event";
        }
        
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(SchedulerCellElement);
            }
        }
    }
}