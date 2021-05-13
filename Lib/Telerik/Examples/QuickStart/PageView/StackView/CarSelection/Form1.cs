
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.PageView.StackView.CarSelection
{
    public partial class Form1 : ExamplesForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();

            this.AddPriceText();
            this.AttachEvents();

            RadListDataItem item = new RadListDataItem("Base MSRP \t$29, 400");
            item.Font = new Font(new FontFamily("Arial"), 8.25F, FontStyle.Bold);
            this.radListOptions.Items.Add(item);
        }

        private void AddPriceText()
        {
        }

        private void AttachEvents()
        {
            foreach (Control child in ControlHelper.EnumChildControls(this.radPageView1, true))
            {
                RadCheckBox check = child as RadCheckBox;
                if (check != null)
                {
                    check.ToggleStateChanged += OnCheck_ToggleStateChanged;
                }
            }
        }

        #endregion

        #region Events Handlers

        private void OnCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            RadCheckBox check = sender as RadCheckBox;

            if (check.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                RadListDataItem item = new RadListDataItem(check.Text);
                check.Tag = item;
                this.radListOptions.Items.Add(item);
            }
            else
            {
                this.radListOptions.Items.Remove(check.Tag as RadListDataItem);
            }
        }

        #endregion

        protected override void WireEvents()
        {
        }
    }
}