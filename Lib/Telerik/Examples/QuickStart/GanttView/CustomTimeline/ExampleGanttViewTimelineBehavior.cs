using System;
using System.Collections.Generic;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GanttView.CustomTimeline
{
    public class ExampleGanttViewTimelineBehavior : BaseGanttViewTimelineBehavior
    {
        public override DateTime AdjustedTimelineStart
        {
            get
            {
                if (this.GraphicalViewElement.TimelineRange != TimeRange.Custom)
                {
                    return base.AdjustedTimelineStart;
                }

                return new DateTime(this.GraphicalViewElement.TimelineStart.Year, 1, 1);
            }
        }

        public override DateTime AdjustedTimelineEnd
        {
            get
            {
                if (this.GraphicalViewElement.TimelineRange != TimeRange.Custom)
                {
                    return base.AdjustedTimelineEnd;
                }

                return new DateTime(this.GraphicalViewElement.TimelineEnd.Year + 1, 1, 1);
            }
        }

        public override IList<GanttViewTimelineDataItem> BuildTimelineDataItems(TimeRange range)
        {
            if (range != TimeRange.Custom)
            {
                return base.BuildTimelineDataItems(range);
            }

            return this.BuildTimelineDataItemsForDecadesRange();
        }

        public IList<GanttViewTimelineDataItem> BuildTimelineDataItemsForDecadesRange()
        {
            List<GanttViewTimelineDataItem> result = new List<GanttViewTimelineDataItem>();

            DateTime adjustedStart = this.AdjustedTimelineStart;
            DateTime adjustedEnd = this.AdjustedTimelineEnd;

            DateTime currentDate = adjustedStart.Date;
            int currentYearNumber = currentDate.Year;
            int newYearNumber = currentYearNumber;
            GanttViewTimelineDataItem item = new GanttViewTimelineDataItem(currentDate.Date, currentDate.AddYears(1), this.GraphicalViewElement.TimelineRange, this.GraphicalViewElement.OnePixelTime);
            result.Add(item);

            while (currentDate < adjustedEnd)
            {
                item.End = currentDate.AddYears(1);

                currentDate = currentDate.AddYears(1);
                newYearNumber = currentDate.Year;

                if (newYearNumber != currentYearNumber && newYearNumber % 10 == 0 && currentDate <= adjustedEnd)
                {
                    currentYearNumber = newYearNumber;
                    item = new GanttViewTimelineDataItem(currentDate, currentDate, this.GraphicalViewElement.TimelineRange, this.GraphicalViewElement.OnePixelTime);
                    result.Add(item);
                }
            }

            return result;
        }

        public override GanttTimelineCellsInfo GetTimelineCellInfoForItem(GanttViewTimelineDataItem item, TimeRange range)
        {
            if (range != TimeRange.Custom)
            {
                return base.GetTimelineCellInfoForItem(item, range);
            }

            return this.GetTimelineCellInfoForDecadeRange(item);
        }

        public GanttTimelineCellsInfo GetTimelineCellInfoForDecadeRange(GanttViewTimelineDataItem item)
        {
            int years = 10;

            if (item.Start == this.AdjustedTimelineStart)
            {
                if (item.Start.Year % 10 > 0)
                {
                    years = 10 - (item.Start.Year % 10);
                }
            }

            if (item.End == this.AdjustedTimelineEnd)
            {
                if (item.End.Year % 10 > 0)
                {
                    years = item.End.Year % 10;
                }
            }

            return new GanttTimelineCellsInfo(years);
        }

        public override string GetTimelineTopElementText(GanttViewTimelineDataItem item)
        {
            if (item.Range != TimeRange.Custom)
            {
                return base.GetTimelineTopElementText(item);
            }

            string format = "{0:yyyy} - {1:yyyy}";
            return string.Format(System.Threading.Thread.CurrentThread.CurrentUICulture, format, item.Start, item.End.AddYears(-1));
        }

        public override string GetTimelineBottomElementText(GanttViewTimelineDataItem item, int index)
        {
            if (item.Range != TimeRange.Custom)
            {
                return base.GetTimelineBottomElementText(item, index);
            }

            string format = "{0:yyyy}";
            return string.Format(System.Threading.Thread.CurrentThread.CurrentCulture, format, new DateTime(item.Start.Year + index, 1, 1));
        }
    }
}
