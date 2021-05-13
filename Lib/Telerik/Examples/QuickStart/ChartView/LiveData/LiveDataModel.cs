using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace Telerik.Examples.WinControls.ChartView.LiveData
{
    class LiveDataModel : INotifyPropertyChanged
    {
        public BindingList<ChartBusinessObject> data;
        public BindingList<ChartBusinessObject> data2;
        private string fps;
        private string messagesPerSecond;
        private string messagesPerMinute;
        private int tickCountSecond;
        private int tickCountMinute;
        private Timer timer;
        private DateTime lastDate;
        private Random random = new Random();
        private DateTime tmpDateTime = DateTime.MinValue;
        private int count = 0;

        public LiveDataModel()
        {
            this.timer = new Timer();
            this.timer.Interval = 1;
            this.timer.Tick += this.OnTimer;

            this.FillData();
            this.FillData2();
            this.MessagesPerSecond = this.random.Next(800, 1800).ToString("#,#");
            this.MessagesPerMinute = this.random.Next(50000, 55000).ToString("#,#");
        }

        public string FPS
        {
            get
            {
                return this.fps;
            }
            set
            {
                if (this.fps != value)
                {
                    this.fps = value;
                    this.OnPropertyChanged("FPS");
                }
            }
        }

        public string MessagesPerSecond
        {
            get
            {
                return this.messagesPerSecond;
            }
            set
            {
                if (this.messagesPerSecond != value)
                {
                    this.messagesPerSecond = value;
                    this.OnPropertyChanged("MessagesPerSecond");
                }
            }
        }

        public string MessagesPerMinute
        {
            get
            {
                return this.messagesPerMinute;
            }
            set
            {
                if (this.messagesPerMinute != value)
                {
                    this.messagesPerMinute = value;
                    this.OnPropertyChanged("MessagesPerMinute");
                }
            }
        }

        public BindingList<ChartBusinessObject> Data
        {
            get
            {
                return this.data;
            }
            set
            {
                if (this.data != value)
                {
                    this.data = value;
                    this.OnPropertyChanged("Data");
                }
            }
        }

        public BindingList<ChartBusinessObject> Data2
        {
            get
            {
                return this.data2;
            }
            set
            {
                if (this.data2 != value)
                {
                    this.data2 = value;
                    this.OnPropertyChanged("Data2");
                }
            }
        }

        public void StartTimer()
        {
            this.timer.Start();
        }

        public void StopTimer()
        {
            this.timer.Stop();
        }

        public void UpdateTimer(double interval)
        {
            this.timer.Interval = (int)interval;
        }

        private void FillData()
        {
            BindingList<ChartBusinessObject> collection = new BindingList<ChartBusinessObject>();
            this.lastDate = DateTime.Now;

            for (int i = 0; i < 50; i++)
            {
                this.lastDate = this.lastDate.AddMilliseconds(200);
                collection.Add(this.CreateBusinessObject());
            }

            this.Data = collection;
        }

        private void FillData2()
        {
            BindingList<ChartBusinessObject> collection = new BindingList<ChartBusinessObject>();
            DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            for (int i = 0; i < 24; i++)
                collection.Add(this.CreateBusinessObject2(date.AddHours(i)));

            this.Data2 = collection;
        }

        private void OnTimer(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if ((now - tmpDateTime).TotalSeconds > 1)
            {
                tmpDateTime = now;
                if (count != 0)
                {
                    this.FPS = (count / 1).ToString();
                }

                count = 0;
            }
            else
            {
                count++;
            }

            this.lastDate = this.lastDate.AddMilliseconds(200);
            this.Data.RemoveAt(0);
            this.Data.Add(this.CreateBusinessObject());
            this.UpdateMetrics();
        }

        private void UpdateMetrics()
        {
            this.tickCountSecond++;
            this.tickCountMinute++;

            if (this.tickCountSecond == 5)
            {
                this.tickCountSecond = 0;
                this.MessagesPerSecond = this.random.Next(800, 1800).ToString("#,#");
            }

            if (this.tickCountMinute == 100)
            {
                this.tickCountMinute = 0;
                this.MessagesPerMinute = this.random.Next(50000, 55000).ToString("#,#");
            }
        }

        private ChartBusinessObject CreateBusinessObject()
        {
            ChartBusinessObject obj = new ChartBusinessObject();

            obj.Value = this.random.Next(800, 1800);
            obj.Category = this.lastDate;

            return obj;
        }

        private ChartBusinessObject CreateBusinessObject2(DateTime date)
        {
            ChartBusinessObject obj = new ChartBusinessObject();

            obj.Value = this.random.Next(3300, 3800);
            obj.Category = date;

            return obj;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
