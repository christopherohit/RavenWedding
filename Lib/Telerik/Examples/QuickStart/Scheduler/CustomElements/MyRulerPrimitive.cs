using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Scheduler.CustomElements
{
    public class MyRulerPrimitive : RulerPrimitive
    {
        public MyRulerPrimitive(RadScheduler scheduler, DayViewAppointmentsArea area) : base(scheduler, area)
        {
            this.RulerRenderer = new MyRullerRender(this);
            this.ForeColor = Color.Black;
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(RulerPrimitive);
            }
        }
    }

    public class MyRullerRender : RulerRenderer
    {
        public MyRullerRender(RulerPrimitive ruler) : base(ruler)
        {
        }

        public override void RenderHour(Telerik.WinControls.Paint.IGraphics g, int hour, RectangleF bounds)
        {
            if (hour < 9 || hour > 17)
            {
                g.FillRectangle(bounds, ColorTranslator.FromHtml("#EBECE8"));
            }
            else
            {
                g.FillRectangle(bounds, ColorTranslator.FromHtml("#E6F6A5"));
            }
            base.RenderHour(g, hour, bounds);
        }

        public override void RenderSubHour(Telerik.WinControls.Paint.IGraphics g, int hour, int sectionIndex, RectangleF bounds)
        {
            if (hour < 9 || hour > 17)
            {
                g.FillRectangle(bounds, ColorTranslator.FromHtml("#EBECE8"));
            }
            else
            {
                g.FillRectangle(bounds, ColorTranslator.FromHtml("#E6F6A5"));
            }
            base.RenderSubHour(g, hour, sectionIndex, bounds);
        }
    }
}