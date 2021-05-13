using System.Drawing;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView
{
    public class TreeExampleHeaderPanel: RadPanel
    {
        protected override void OnLoad(Size desiredSize)
        {
            base.OnLoad(desiredSize);

            this.PanelElement.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.PanelElement.Padding = new System.Windows.Forms.Padding(8, 4, 2, 2);
        }

        public override string ThemeClassName
        {
            get
            {
                return typeof(RadPanel).FullName;
            }
        }
    }
}
