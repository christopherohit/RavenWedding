using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Telerik.Examples.WinControls.Sparkline.FirstLook
{
    public class CalleeViewModel
    {
        private BindingList<CallData> calls;
        private int totalDuration;
        private int totalHoldTime;
        private static readonly Random Rand = new Random();

        public CalleeViewModel(string name)
        {
            this.Name = name;
            this.calls = new BindingList<CallData>();
            this.GenerateInitialCalls();
        }

        public string Name { get; set; }

        public BindingList<CallData> Calls
        {
            get { return this.calls; }
        }

        public TimeSpan AverageDuration
        {
            get { return new TimeSpan(0, 0, (int)(this.totalDuration / (double)this.Calls.Count)); }
        }

        public TimeSpan AverageHoldTime
        {
            get { return new TimeSpan(0, 0, (int)(this.totalHoldTime / (double)this.Calls.Count)); }
        }

        public void AddRandomCall()
        {
            if (this.Calls.Count >= 20)
            {
                this.totalDuration -= this.Calls[0].DurationSeconds;
                this.totalHoldTime -= this.Calls[0].HoldTimeSeconds;
                this.Calls.RemoveAt(0);
            }

            CallData call = new CallData
            {
                Duration = new TimeSpan(0, Rand.Next(0, 40), Rand.Next(1, 59)),
                HoldTime = new TimeSpan(0, Rand.Next(0, 20), Rand.Next(1, 59)),
                IssueResolved = Rand.Next(-100, 100),
            };

            this.Calls.Add(call);
            this.totalDuration += call.DurationSeconds;
            this.totalHoldTime += call.HoldTimeSeconds;
        }

        private void GenerateInitialCalls()
        {
            for (int i = 0; i < 20; i++)
            {
                this.AddRandomCall();
            }
        }
    }
}
