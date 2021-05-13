using System;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Editors.BrowseEditor.Settings
{
    public partial class Form1 : EditorExampleBaseForm
    {
        private bool suspendUpdate;

        public Form1()
        {
            InitializeComponent();

            this.CenterPanel = true;
            this.CenteredControl = this.radBrowseEditor1;

            this.radDropDownList1.DataSource = Enum.GetValues(typeof(BrowseEditorDialogType));
            this.radDropDownList1.SelectedIndexChanged += this.RadDropDownList1_SelectedIndexChanged;
        }

        private void RadDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radBrowseEditor1.DialogType = (BrowseEditorDialogType)e.Position;
        }

        private void ReadOnlyCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.suspendUpdate)
            {
                return;
            }

            this.suspendUpdate = true;
            this.radBrowseEditor1.ReadOnly ^= true;
            if (this.radBrowseEditor1.ReadOnly)
            {
                this.clearButtonCheckBox.Checked = false;
                this.radBrowseEditor1.BrowseElement.ShowClearButton = false;
            }

            this.suspendUpdate = false;
        }

        private void ClearButtonCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.suspendUpdate)
            {
                return;
            }

            this.suspendUpdate = true;
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radBrowseEditor1.ReadOnly = false;                
                this.readOnlyCheckBox.Checked = false;
                this.radBrowseEditor1.BrowseElement.ShowClearButton = true;
            }
            else
            {
                this.radBrowseEditor1.BrowseElement.ShowClearButton = false;
            }

            this.suspendUpdate = false;
        }
    }
}
