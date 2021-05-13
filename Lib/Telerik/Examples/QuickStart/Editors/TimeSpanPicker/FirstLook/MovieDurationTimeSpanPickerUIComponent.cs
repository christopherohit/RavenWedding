using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.FirstLook
{
    public class MovieDurationTimeSpanPickerUIComponent : ListTimeSpanPickerUIComponent
    {
        public MovieDurationTimeSpanPickerUIComponent(ITimeSpanPickerComponent owner)
            : base(owner)
        {
        }

        protected override void CreateItemsSource()
        {
            int minutes = 30;
            for (int i = 0; i <= 10; i++)
            {
                RadListDataItem item = new RadListDataItem(minutes + " minutes", minutes);
                if (minutes >= 90 && minutes < 180)
                {
                    minutes += 15;
                }
                else
                {
                    minutes += 30;
                    if (minutes > 240)
                    {
                        minutes = 240;
                    }
                }

                this.ListElement.Items.Add(item);
            }
        }
    }
}