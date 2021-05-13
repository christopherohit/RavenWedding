using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.FirstLook
{
    public class MovieDurationTimeSpanPickerComponent : MinuteTimeSpanPickerComponent
    {
        public MovieDurationTimeSpanPickerComponent(ITimeSpanPickerContentElement owner)
            : base(owner)
        {
        }

        protected override void InitializeFields()
        {
            base.InitializeFields();
            this.DefaultSize = new System.Drawing.Size(120, 200);
        }

        public override BaseTimeSpanPickerUIComponent CreateVisualElement()
        {
            return new MovieDurationTimeSpanPickerUIComponent(this);
        }
    }
}