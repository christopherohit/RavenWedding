using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using System.Diagnostics;

namespace Telerik.Examples.WinControls.DropDownListAndListControl.Performance
{
    public partial class Form1 : ExamplesForm
    {
        const int itemsCount = 150000;
        string[] items;

        public Form1()
        {
            InitializeComponent();

            this.CreateBindingList(100);
            this.radListControl1.DataSource = items;
            this.radDropDownList1.DataSource = items;
            this.radSpinEditor1.Value = itemsCount;
            this.radLabelElapsed.Text = "Press Bind Button to measure binding time with " + this.radSpinEditor1.Value + " items.";           
        }

        private void CreateBindingList(int count)
        {            
            items = new string[count];
            for (int i = 0; i < count; ++i)
            {
                items[i] = "Item " + i;
            }
        }

        private void button_Bind_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            this.CreateBindingList((int)this.radSpinEditor1.Value);            
            stopWatch.Stop();
            this.radLabelElapsed.Text = "Time needed to create the BindingList: " + stopWatch.ElapsedMilliseconds + " ms";
            stopWatch.Reset();
            stopWatch.Start();
            this.radListControl1.DataSource = items;
            stopWatch.Stop();
            this.radLabelElapsedListControl.Text = "Time needed to databind RadListControl: " + stopWatch.ElapsedMilliseconds + " ms";
            stopWatch.Reset();
            stopWatch.Start();
            this.radDropDownList1.DataSource = items;
            this.radDropDownList1.ShowDropDown();
            stopWatch.Stop();
            this.radLabelElapsedDropDownList.Text = "Time neededto databind RadDropDownList: " + stopWatch.ElapsedMilliseconds + " ms";
            
            this.button_Bind.Text = "Bind Again";
        }

        void radSpinEditor1_ValueChanged(object sender, System.EventArgs e)
        {
            this.radLabelElapsed.Text = "Press the Bind button to measure the binding time with " + this.radSpinEditor1.Value + " items.";     
        }

        protected override void WireEvents()
        {
            this.button_Bind.Click += new System.EventHandler(this.button_Bind_Click);
            this.radSpinEditor1.ValueChanged += new System.EventHandler(this.radSpinEditor1_ValueChanged);
        }
    }
}
