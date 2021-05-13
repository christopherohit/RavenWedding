using GoogleAnalytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.Analytics;

namespace ERP.Client.Analytics
{
    public class GoogleAnalyticsMonitor : ITraceMonitor
    {
        private Tracker tracker;
        private IDictionary<string, DateTime> featureTimings;

        public GoogleAnalyticsMonitor()
        {
            this.CreateGoogleTracker();
            this.featureTimings = new Dictionary<string, DateTime>();
        }

        public void CreateGoogleTracker()
        {
            var trackerManager = new TrackerManager(new PlatformInfoProvider());
            tracker = trackerManager.CreateTracker("UA-111455-55");
            tracker.AnonymizeIP = true;
            tracker.AppName = "WinForms ERP";
        }

        public void TrackAtomicFeature(string feature)
        {
            string category;
            string eventAction;
            this.SplitFeatureName(feature, out category, out eventAction);
            var data = HitBuilder.CreateCustomEvent(category, eventAction + " event", feature.ToString(), 1).Build();
            tracker.Send(data);
        }

        public void TrackError(string feature, Exception exception)
        {
            var data = HitBuilder.CreateException(feature + ":" + exception.ToString(), true).Build();
            tracker.Send(data);
        }
        public void TrackFeatureCancel(string feature)
        {
            string category;
            string eventAction;
            this.SplitFeatureName(feature, out category, out eventAction);
            if (this.featureTimings.ContainsKey(eventAction))
            {
                this.featureTimings.Remove(eventAction);
            }

            var data = HitBuilder.CreateCustomEvent(category, eventAction + " event.Cancelled", feature.ToString(), 1).Build();
            tracker.Send(data);
        }


        public void TrackFeatureStart(string feature)
        {
            // Measuring timings provides a native way to measure a period of time in Google Analytics. 
            // This can be useful to measure resource load times, for example.
            //TimeSpan ts = TimeSpan.FromSeconds(2.2);
            string category;
            string eventAction;
            this.SplitFeatureName(feature, out category, out eventAction);
            if (!this.featureTimings.ContainsKey(eventAction))
            {
                this.featureTimings.Add(eventAction, DateTime.Now);
            }
            else
            {
                this.featureTimings[eventAction] = DateTime.Now;
            }

            var loadTiming = HitBuilder.CreateTiming(category, eventAction, TimeSpan.FromSeconds(0)).Build();
            tracker.Send(loadTiming);
        }

        public void TrackFeatureEnd(string feature)
        {
            string category;
            string eventAction;
            this.SplitFeatureName(feature, out category, out eventAction);
            TimeSpan? timing = null;
            if (this.featureTimings.ContainsKey(eventAction))
            {
                timing = DateTime.Now - this.featureTimings[eventAction];
                this.featureTimings.Remove(eventAction);
            }

            var unLoadTiming = HitBuilder.CreateTiming(category, eventAction, timing).Build();
            tracker.Send(unLoadTiming);
        }

        public void TrackValue(string feature, long value)
        {
            string category;
            string eventAction;
            this.SplitFeatureName(feature, out category, out eventAction);
            var data = HitBuilder.CreateCustomEvent(category, eventAction + " event", feature.ToString(), value).Build();
            tracker.Send(data);
        }

        private void SplitFeatureName(string feature, out string category, out string eventAction)
        {
            string[] parameters = feature.Split('.');
            category = parameters[0];
            eventAction = parameters[1];
        }
    }
}
