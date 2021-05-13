using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Scheduler.CustomElements
{
    public class MyElementProvider : SchedulerElementProvider
    {
        public MyElementProvider(RadScheduler scheduler)
            : base(scheduler)
        {
        }

        protected override T CreateElement<T>(SchedulerView view, object context)
        {
            if (typeof(T) == typeof(AppointmentElement))
            {
                return new MyAppointmentElement(this.Scheduler, view, (IEvent)context) as T;
            }
            if (typeof(T) == typeof(SchedulerCellElement))
            {
                return new MySchedulerCellElement(this.Scheduler, view) as T;
            }

            return base.CreateElement<T>(view, context);
        }

        public override RulerPrimitive CreateRulerPrimitive(DayViewAppointmentsArea area, SchedulerTimeZone timeZone)
        {
            return new MyRulerPrimitive(this.Scheduler, area);
        }
    }
}
