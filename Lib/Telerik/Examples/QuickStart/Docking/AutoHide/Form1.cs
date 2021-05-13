using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Docking.AutoHide
{
	public partial class Form1 : ExamplesForm
	{
	    private int nextWindowToChange = 0;
        private DockState newWindowState = Telerik.WinControls.UI.Docking.DockState.AutoHide;
        private int demoMode = 0;

	    public Form1()
		{
			InitializeComponent();

            this.WireEvents();
		}

        protected override void OnLoad(EventArgs e)
        {
            //ThemeResolutionService.ApplyThemeToControlTree(this.settingsPanel, MainForm.DefaultTheme);
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DockWindow[] toolWindows = this.radDock1.DockWindows.ToolWindows;
            if (nextWindowToChange >= toolWindows.Length)
            {
                this.timer1.Stop();
                nextWindowToChange = 0;
                EnableButtons(true);
                return;
            }

            if (demoMode == 0)
            {
                toolWindows[nextWindowToChange].DockState = newWindowState;
            }
            else if (demoMode == 1)
            {
                //if (nextWindowToChange > 0)
                //{
                //    this.radDock1.HideWindow(toolWindows[nextWindowToChange - 1]);
                //}

                this.radDock1.DisplayWindow(toolWindows[nextWindowToChange]);
            }

            if (demoMode == 2)
            {
                this.radDock1.CloseWindow(toolWindows[nextWindowToChange]);
            }

            nextWindowToChange++;
        }

        private void StartDemo(int demoMode, DockState dockState)
        {
            if (timer1.Enabled)
            {
                return;
            }

            EnableButtons(false);

            this.demoMode = demoMode;
            this.newWindowState = dockState;
            this.timer1.Start();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            StartDemo(0, DockState.Hidden);
        }

	    private void radButton2_Click(object sender, EventArgs e)
        {
            StartDemo(1, DockState.Docked);
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            StartDemo(0, DockState.Docked);            
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            StartDemo(0, DockState.AutoHide);
        }

        private void EnableButtons(bool enabledState)
        {
            this.radButton1.Enabled = enabledState;
            this.radButton2.Enabled = enabledState;
            this.radButton3.Enabled = enabledState;
            this.radButton4.Enabled = enabledState;
        }

        protected override void WireEvents()
        {
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            this.radButton4.Click += new System.EventHandler(this.radButton4_Click);
        }
	}
}