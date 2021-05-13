using System;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Docking.CommandManager
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.InitCustomCommands();
            this.BuildCommandList();
        }

        private void InitCustomCommands()
        {
            CustomCommand command = new CustomCommand(this.radDock1);
            command.Name = "Custom Command 1";
            this.radDock1.CommandManager.RegisterCommand(command);
        }

        private void BuildCommandList()
        {
            this.commandList.BeginUpdate();
            this.commandList.Items.Clear();

            foreach (RadDockCommand command in this.radDock1.CommandManager.Commands)
            {
                RadListDataItem item = new RadListDataItem(command.Name, command);
                this.commandList.Items.Add(item);
            }

            if (this.commandList.Items.Count > 0)
            {
                this.commandList.SelectedIndex = 0;
            }

            this.commandList.EndUpdate();
        }

        private void enableManager_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radDock1.CommandManager.Enabled = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void executeCommand_Click(object sender, EventArgs e)
        {
            RadDockCommand command = this.SelectedCommand;
            if (command != null)
            {
                this.radDock1.CommandManager.ExecuteCommand(command.Name);
            }
        }

        private RadDockCommand SelectedCommand
        {
            get
            {
                RadListDataItem item = this.commandList.SelectedItem as RadListDataItem;
                if (item != null)
                {
                    return item.Value as RadDockCommand;
                }

                return null;
            }
        }

        protected override void WireEvents()
        {
            this.enableManager.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.enableManager_ToggleStateChanged);
            this.executeCommand.Click += new System.EventHandler(this.executeCommand_Click);
        }

        #region Nested Types

        private class CustomCommand : RadDockCommand
        {
            private RadDock owner;
            public CustomCommand(RadDock owner)
            {
                this.owner = owner;
                this.Shortcuts.Add(new RadShortcut(Keys.Alt, Keys.R));
            }

            public override object Execute(params object[] settings)
            {
                MessageBox.Show("Displayed custom command.", "RadDock.CommandManager");
                return null;
            }
        }

        #endregion


    }
}
