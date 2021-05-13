using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Editors
{
    /// <summary>
    /// This is a base control for all RadComboBox examples.
    /// </summary>
    public partial class EditorExampleBaseForm : ExamplesForm
    {
        private bool centerPanel = false;

        public EditorExampleBaseForm()
        {
            InitializeComponent();

            this.radPanelDemoHolder.PanelElement.PanelFill.Visibility = ElementVisibility.Collapsed;
            this.radPanelDemoHolder.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            this.radPanelDemoHolder.RootElement.EnableElementShadow = false;
            this.radPanelDemoHolder.Dock = DockStyle.Fill;
            this.radPanelDemoHolder.Padding = new Padding(0);
            this.Padding = new Padding(0);
        }

        public bool CenterPanel
        {
            get
            {
                return this.centerPanel;
            }
            set
            {
                this.centerPanel = value;
                if (this.centerPanel)
                {
                    this.CenteredControl = this.radPanelDemoHolder;
                }
                else
                {
                    this.CenteredControl = null;
                    this.radPanelDemoHolder.Location = Point.Empty;
                }
            }
        }
    }
}