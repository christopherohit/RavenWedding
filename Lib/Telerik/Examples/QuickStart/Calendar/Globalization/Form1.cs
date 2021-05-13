using System;
using Telerik.QuickStart.WinControls;
using System.Collections;
using System.Globalization;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Calendar.Globalization
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.SelectedControl = this.radCalendar1;
        }

        #region Event Handlers
        void radComboCultureList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radCalendar1.Culture = radComboCultureList.SelectedValue as CultureInfo;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SortedList cultures = new SortedList();

            CultureInfo temp;
            for (int i = 0; i < CultureInfo.GetCultures(CultureTypes.SpecificCultures).Length; i++)
            {
                temp = CultureInfo.GetCultures(CultureTypes.SpecificCultures)[i];

                if (!cultures.ContainsKey(temp.EnglishName))
                {
                    cultures.Add(temp.EnglishName, temp);
                }
            }

            IEnumerator ie = cultures.Keys.GetEnumerator();
            while (ie.MoveNext())
            {
                string name = (string)ie.Current;
                RadListDataItem item = new RadListDataItem(name);
                item.Value = cultures[name];
                radComboCultureList.Items.Add(item);
            }
            radCalendar1.Culture = CultureInfo.CurrentCulture;
            radComboCultureList.SelectedIndex = radComboCultureList.FindString(CultureInfo.CurrentCulture.EnglishName);
            radCalendar1.FocusedDate = DateTime.Now;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            (this.radCalendar1.RootElement.Children[0] as RadCalendarElement).CalendarNavigationElement.Text = this.radTextBox1.Text;
            this.radCalendar1.Invalidate();
        }
        #endregion

        protected override void WireEvents()
        {
            this.radComboCultureList.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radComboCultureList_SelectedIndexChanged);
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
        }
    }
}