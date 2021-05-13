using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;

namespace Telerik.Examples.WinControls.Sparkline.FirstLook
{
    public class ExampleViewModel
    {
        private List<CalleeViewModel> callees;
        private BindingList<CallData> calls;
        private Random rand;

        public ExampleViewModel()
        {
            this.callees = this.GetCalleeViewModels();
            this.calls = new BindingList<CallData>();
            this.rand = new Random();
            this.GenerateCalls();
        }

        public List<CalleeViewModel> Callees
        {
            get
            {
                return this.callees;
            }
        }

        public BindingList<CallData> Calls
        {
            get
            {
                return this.calls;
            }
        }

        public void GenerateCalls()
        {
            CallData callData;
            DateTime date = new DateTime(2010, 12, 12, 10, 0, 0);
            for (int i = 0; i < 24; i++)
            {
                callData = new CallData
                {
                    Duration = new TimeSpan(0, this.rand.Next(0, 100), this.rand.Next(1, 59)),
                    HoldTime = new TimeSpan(0, this.rand.Next(0, 100), this.rand.Next(1, 59)),
                    Abandonments = this.rand.Next(0, 50),
                    TimeInverval = date
                };

                date = date.AddHours(1);

                this.calls.Add(callData);
            }
        }

        private List<CalleeViewModel> GetCalleeViewModels()
        {
            List<CalleeViewModel> callees = new List<CalleeViewModel>();
            callees.Add(new CalleeViewModel("Sam"));
            callees.Add(new CalleeViewModel("John"));
            callees.Add(new CalleeViewModel("Mike"));

            return callees;
        }
    }
}
