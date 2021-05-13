using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TrackStatusControls.WaitingBar.Modern
{
    public partial class Form1 : ExamplesForm
    {
        private Timer timer;
        private RadPanel[] panels;
        private RadWaitingBar[] waitingBars;
        private int currentPanelIndex;
        private RadWaitingBar currentWaitingBar;

        public Form1()
        {
            InitializeComponent();

            this.SetInitialValues();
        }

        private void SetInitialValues()
        {
            this.currentWaitingBar = this.radWaitingBar1;

            this.timer = new Timer();
            this.timer.Interval = 1500;
            this.timer.Tick += timer_Tick;

            this.currentPanelIndex = 0;

            this.panels = new RadPanel[6];
            this.panels[0] = this.radPanel1;
            this.panels[1] = this.radPanel2;
            this.panels[2] = this.radPanel3;
            this.panels[3] = this.radPanel4;
            this.panels[4] = this.radPanel5;
            this.panels[5] = this.radPanel6;

            foreach (RadPanel panel in this.panels)
            {
                panel.PanelElement.PanelFill.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                panel.PanelElement.PanelBorder.ForeColor = Color.FromArgb(238, 238, 238);
            }

            this.waitingBars = new RadWaitingBar[6];
            this.waitingBars[0] = new RadWaitingBar();
            this.waitingBars[1] = new RadWaitingBar();
            this.waitingBars[2] = new RadWaitingBar();
            this.waitingBars[3] = new RadWaitingBar();
            this.waitingBars[4] = new RadWaitingBar();
            this.waitingBars[5] = new RadWaitingBar();

            for (int index = 0; index < this.waitingBars.Length; index++)
            {
                RadWaitingBar wb = this.waitingBars[index];
                wb.AssociatedControl = this.panels[index];
                wb.Size = new System.Drawing.Size(80, 80);
                wb.StartWaiting();
                this.Controls.Add(wb);
            }
        }

        private void StartLoadingImages()
        {
            this.currentPanelIndex = 0;
            this.timer.Stop();
            this.RemovePanelImages();
            for (int panelIndex = 0; panelIndex < 6; panelIndex++)
            {
                this.waitingBars[panelIndex].ThemeName = this.CurrentThemeName;
                this.waitingBars[panelIndex].WaitingSpeed = this.currentWaitingBar.WaitingSpeed;
                this.waitingBars[panelIndex].WaitingStep = this.currentWaitingBar.WaitingStep;
                this.waitingBars[panelIndex].WaitingStyle = this.currentWaitingBar.WaitingStyle;
                if (this.waitingBars[panelIndex].IsWaiting)
                {
                    this.waitingBars[panelIndex].StopWaiting();
                    this.waitingBars[panelIndex].ResetWaiting();
                }

                this.waitingBars[panelIndex].StartWaiting();
            }

            this.timer.Start();
        }

        private void RemovePanelImages()
        {
            this.radPanel1.BackgroundImage = null;
            this.radPanel2.BackgroundImage = null;
            this.radPanel3.BackgroundImage = null;
            this.radPanel4.BackgroundImage = null;
            this.radPanel5.BackgroundImage = null;
            this.radPanel6.BackgroundImage = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radWaitingBar1.StartWaiting();
            this.radWaitingBar2.StartWaiting();
            this.radWaitingBar3.StartWaiting();
            this.radWaitingBar4.StartWaiting();
            this.radWaitingBar5.StartWaiting();
            this.radWaitingBar6.StartWaiting();
            this.radWaitingBar7.StartWaiting();

            this.StartLoadingImages();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.currentPanelIndex >= this.panels.Length)
            {
                this.timer.Stop();
                this.currentPanelIndex = 0;
                return;
            }

            this.waitingBars[currentPanelIndex].StopWaiting();
            this.waitingBars[currentPanelIndex].ResetWaiting();

            Image panelImage = Image.FromFile(Application.StartupPath + @"\Resources\MealImages\240-160\meal" + (this.currentPanelIndex + 1) + ".jpg");
            this.panels[currentPanelIndex].BackgroundImage = panelImage;

            this.currentPanelIndex++;
        }

        private void radRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            RadRadioButton radioButton = sender as RadRadioButton;
            if (radioButton == this.radRadioButtonDotsLine)
            {
                this.currentWaitingBar = this.radWaitingBar1;
            }
            else if (radioButton == this.radRadioButtonDotsSpinner)
            {
                this.currentWaitingBar = this.radWaitingBar2;
            }
            else if (radioButton == this.radRadioButtonDotsRing)
            {
                this.currentWaitingBar = this.radWaitingBar3;
            }
            else if (radioButton == this.radRadioButtonFadingRing)
            {
                this.currentWaitingBar = this.radWaitingBar4;
            }
            else if (radioButton == this.radRadioButtonLineRing)
            {
                this.currentWaitingBar = this.radWaitingBar5;
            }
            else if (radioButton == this.radRadioButtonSegmentedRing)
            {
                this.currentWaitingBar = this.radWaitingBar6;
            }
            else if (radioButton == this.radRadioButtonRotatingRings)
            {
                this.currentWaitingBar = this.radWaitingBar7;
            }

            this.StartLoadingImages();
        }

        private void radButtonLoadImages_Click(object sender, EventArgs e)
        {
            this.StartLoadingImages();
        }
    }
}
