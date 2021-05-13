using System;
using System.ComponentModel;

namespace Telerik.Examples.WinControls.Sparkline.FirstLook
{
    public class CallData : INotifyPropertyChanged
    {
        private TimeSpan duration;
        private TimeSpan holdTime;
        private double issueResolved;
        private DateTime timeInterval;
        private int abandonments;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        public int Abandonments
        {
            get
            {
                return this.abandonments;
            }
            set
            {
                this.abandonments = value;
                this.OnPropertyChanged("Abandonments");
            }
        }

        public DateTime TimeInverval
        {
            get
            {
                return this.timeInterval;
            }
            set
            {
                this.timeInterval = value;
                this.OnPropertyChanged("TimeInverval");
            }
        }

        public int DurationSeconds
        {
            get
            {
                return (int)this.Duration.TotalSeconds;
            }
        }

        public int DurationMinutes
        {
            get
            {
                return (int)this.Duration.TotalMinutes;
            }
        }

        public TimeSpan Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
                this.OnPropertyChanged("Duration");
            }
        }

        public TimeSpan HoldTime
        {
            get
            {
                return this.holdTime;
            }
            set
            {
                this.holdTime = value;
                this.OnPropertyChanged("HoldTime");
            }
        }

        public int HoldTimeMinutes
        {
            get
            {
                return (int)this.HoldTime.TotalMinutes;
            }
        }

        public int HoldTimeSeconds
        {
            get
            {
                return (int)this.HoldTime.TotalSeconds;
            }
        }

        public double IssueResolved
        {
            get
            {
                return this.issueResolved;
            }
            set
            {
                this.issueResolved = value;
                this.OnPropertyChanged("IssueResolved");
            }
        }
    }
}
