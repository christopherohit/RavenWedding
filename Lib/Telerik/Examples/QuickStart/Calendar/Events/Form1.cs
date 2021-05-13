using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Calendar.Events
{
	public partial class Form1 : ExamplesForm
	{
        int insertIndex = 0;
        DateTimeCollection oldSelections;

		public Form1()
		{
			InitializeComponent();

			this.SelectedControl = this.radCalendar1;
            (this.radCalendar1.CalendarElement.CalendarVisualElement as MonthViewElement).TitleElement.Visibility = ElementVisibility.Collapsed;         

		}

        #region Helper Methods

        private void AddEventRoot(string text)
        {
            RadListDataItem item = new RadListDataItem();
            item.Text = text;
            this.AddEventRoot(item);
        }

        private void AddEventRoot(RadListDataItem item)
        {
            insertIndex = 0;
            item.Font = 
                new System.Drawing.Font("Microsoft Sans Serif", 
                                        8.25F, 
                                        System.Drawing.FontStyle.Bold, 
                                        System.Drawing.GraphicsUnit.Point, 
                                        ((byte)(204)));
            radListBoxEvents.Items.Insert(insertIndex, item);
            insertIndex++;
        }

        private void AddTextToListBox(RadListDataItem item)
        {
            if (radListBoxEvents.Items.Count > 100)
            {
                radListBoxEvents.Items.Clear();
                insertIndex = 0;
            }
            radListBoxEvents.Items.Insert(insertIndex, item);
            insertIndex++;
        }

        private void AddTextToListBox(string text)
        {
            RadListDataItem label = new RadListDataItem();
            label.Text = text;
            AddTextToListBox(label);
        }

        #endregion

        #region Event Handlers
        private void radButton1_Click(object sender, EventArgs e)
        {
            radListBoxEvents.Items.Clear();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radCalendar1.FocusedDate = DateTime.Now;
        }

        void radCalendar1_ViewChanged(object sender, EventArgs e)
        {
            AddEventRoot("ViewChanged");
            AddTextToListBox(string.Format("    Changed to range: {0} - {1}", 
                this.radCalendar1.DefaultView.ViewStartDate.ToShortDateString(), 
                this.radCalendar1.DefaultView.ViewEndDate.ToShortDateString()));
        }

        void radCalendar1_ViewChanging(object sender, ViewChangingEventArgs e)
        {
            AddEventRoot("ViewChanging");
            AddTextToListBox(string.Format("    Changing to {0} - {1}",
                e.View.ViewStartDate.ToShortDateString(), 
                e.View.ViewEndDate.ToShortDateString()));
        }

        void radCalendar1_SelectionChanged(object sender, EventArgs e)
        {
            AddEventRoot("SelectionChanged");
            AddTextToListBox("    The following dates have been added to\n    SelectedDates collection in RadCalendar:");
            for (int i = 0; i < this.radCalendar1.SelectedDates.Count; i++)
            {
                if (!oldSelections.Contains(this.radCalendar1.SelectedDates[i]))
                {
                    AddTextToListBox("    " + this.radCalendar1.SelectedDates[i]);
                }
            }
            if (oldSelections != null)
            {
                // Remove if to reproduce exception. Click erratically on the Calendar and oldSelections becomes null.
                // SelectionChanged fires before SelectionChanging?
                oldSelections.BeginUpdate();
                oldSelections.Clear();
                oldSelections.EndUpdate();
            }
            oldSelections = null;
        }

        void radCalendar1_SelectionChanging(object sender, SelectionEventArgs e)
        {
            AddEventRoot("SelectionChanging");
            AddTextToListBox("     new dates are added to SelectedDates\n     collection in RadCalendar.");
            oldSelections = this.radCalendar1.SelectedDates.Clone();
        }
        #endregion

        protected override void WireEvents()
        {
            this.radButtonClear.Click += new System.EventHandler(this.radButton1_Click);
            this.radCalendar1.SelectionChanging += new SelectionEventHandler(radCalendar1_SelectionChanging);
            this.radCalendar1.SelectionChanged += new EventHandler(radCalendar1_SelectionChanged);
            this.radCalendar1.ViewChanging += new ViewChangingEventHandler(radCalendar1_ViewChanging);
            this.radCalendar1.ViewChanged += new EventHandler(radCalendar1_ViewChanged);
        }
    }
}