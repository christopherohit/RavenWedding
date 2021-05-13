using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Scheduler.CustomAppointmentDialog
{
    public class CustomAppointmentFactory : IAppointmentFactory
    {
        #region IAppointmentFactory Members

        public IEvent CreateNewAppointment()
        {
            return new OutlookLikeAppointment();
        }

        #endregion
    }
}
