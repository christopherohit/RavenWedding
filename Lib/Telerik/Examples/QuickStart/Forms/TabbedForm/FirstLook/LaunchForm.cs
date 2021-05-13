using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Forms.TabbedForm.FirstLook
{
    public class LaunchForm : ExamplesLauncherForm
    {
        private RadTabbedForm TabbedForm
        {
            get { return this.Form as RadTabbedForm; }
        }
        
        public override void OnThemeChanged()
        {
            base.OnThemeChanged();

            if (this.TabbedForm != null && this.TabbedForm.TabbedFormControl != null)
            {
                this.SyncTheme(this.TabbedForm);
            }
        }
        
        private void SyncTheme(RadTabbedForm form)
        {
            this.TabbedForm.ThemeName = this.CurrentThemeName;
            this.TabbedForm.TabbedFormControl.ThemeName = this.CurrentThemeName;
        }
    }
}
