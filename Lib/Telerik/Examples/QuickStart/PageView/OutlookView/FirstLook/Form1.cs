using Telerik.QuickStart.WinControls;
using Telerik.Examples.WinControls.Properties;

namespace Telerik.Examples.WinControls.PageView.OutlookView.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.radPageViewPage1.Image = Resources.OutlookViewNotes;
            this.radPageViewPage2.Image = Resources.OutlookViewTasks;
            this.radPageViewPage3.Image = Resources.OutlookViewContacts;
            this.radPageViewPage4.Image = Resources.OutlookViewCalendar;
            this.radPageViewPage6.Image = Resources.OutlookViewMail;
        }

        protected override void WireEvents()
        {
        }
    }
}
