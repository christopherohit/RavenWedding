using System;
using System.ComponentModel;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.Events
{
    public partial class Form1 : EditorExampleBaseForm
    {
        private Timer showDropDownTimeout;

        public Form1()
        {
            InitializeComponent();
            this.radComboDropDownStyle.SelectedIndexChanged += comboDropDownStyle_SelectedIndexChanged;
            this.radComboSort.SelectedIndexChanged += radComboSort_SelectedIndexChanged;

            this.radComboDemo.PopupClosing += this.radComboDemo_DropDownClosing;
            this.radComboDemo.PopupClosed += this.radComboDemo_DropDownClosed;
            this.radComboDemo.PopupOpening += this.radComboDemo_DropDownOpening;
            this.radComboDemo.PopupOpened += this.radComboDemo_DropDownOpened;
            this.radComboDemo.SelectedIndexChanged += this.radComboDemo_SelectedIndexChanged;
            this.radComboDemo.SortStyleChanged += this.radComboDemo_SortedChanged;
            this.radComboDemo.TextChanged += this.radComboDemo_TextChanged;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radComboSort.SelectedText = "None";
            this.radComboDropDownStyle.SelectedIndex = 0;
            this.SelectedControl = this.radComboDemo;

            this.showDropDownTimeout = new Timer(this.components);
            this.showDropDownTimeout.Tick += new EventHandler(showDropDownTimeout_Tick);
            this.showDropDownTimeout.Interval = 1000;
            this.showDropDownTimeout.Start();
        }

        private void showDropDownTimeout_Tick(object sender, EventArgs e)
        {
            this.radComboDemo.Focus();
            this.radComboDemo.ShowDropDown();
            this.showDropDownTimeout.Stop();
        }

        protected override void WireEvents()
        {
            this.radCheckCase.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chBoxCaseSensitive_CheckedChanged);
        }

        private void comboDropDownStyle_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)        
        {
            if (e.Position == -1)
            {
                return;
            }

            this.radComboDemo.DropDownStyle = (RadDropDownStyle)Enum.Parse(typeof(RadDropDownStyle), this.radComboDropDownStyle.SelectedItem.Text);
        }

        private void radComboSort_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (e.Position == -1)
            {
                return;
            }

            this.radComboDemo.SortStyle = (SortStyle)Enum.Parse(typeof(SortStyle), this.radComboSort.SelectedItem.Text);
        }

        private void radComboDemo_DropDownOpened(object sender, EventArgs e)
        {
            ShowEventMessage("DropDownOpened");
        }

        private void radComboDemo_DropDownClosed(object sender, Telerik.WinControls.UI.RadPopupClosedEventArgs e)
        {
            ShowEventMessage("DropDownClosed");
        }

        private void radComboDemo_DropDownClosing(object sender, RadPopupClosingEventArgs args)
        {
            ShowEventMessage("DropDownClosing");
        }

        private void radComboDemo_DropDownOpening(object sender, CancelEventArgs args)
        {
            ShowEventMessage("DropDownOpening");
        }

        void radComboDemo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ShowEventMessage("SelectedIndexChanged");
        }

        private void radComboDemo_SortedChanged(object sender, EventArgs e)
        {
            ShowEventMessage("SortedChanged");
        }

        private void radComboDemo_TextChanged(object sender, EventArgs e)
        {
            ShowEventMessage("TextChanged");
        }

        private void ShowEventMessage(string eventName)
        {
            this.radTxtEvents.Text += string.Format("{0} fired" + Environment.NewLine, eventName);
            this.radTxtEvents.SelectionStart = this.radTxtEvents.Text.Length;
            this.radTxtEvents.ScrollToCaret();
        }

        private void chBoxCaseSensitive_CheckedChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            radComboDemo.CaseSensitive = this.radCheckCase.Checked;
        }
    }
}