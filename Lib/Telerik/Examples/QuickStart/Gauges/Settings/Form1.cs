using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Gauges;

namespace Telerik.Examples.WinControls.Gauges.Settings
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private float step = 0.18f;

        public Form1()
        {
            this.InitializeComponent();
            this.radDropDownList1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Interval = 100;
            this.timer1.Tick += this.timer1_Tick;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.radialGaugeNeedle1.Value + this.step >= this.radRadialGauge1.RangeEnd ||
                this.radialGaugeNeedle1.Value + this.step <= this.radRadialGauge1.RangeStart)
            {
                this.step = -this.step;
            }
            this.radialGaugeNeedle1.Value += this.step;
        }

        private void spinNeedleLenght_ValueChanged(object sender, EventArgs e)
        {
            this.radialGaugeNeedle1.LenghtPercentage = (double)this.spinNeedleLenght.Value;
        }

        private void spinNeedleThickness_ValueChanged(object sender, EventArgs e)
        {
            this.radialGaugeNeedle1.Thickness = (double)this.spinNeedleThickness.Value;
        }

        private void spinInnerPointRadiusPercentage_ValueChanged(object sender, EventArgs e)
        {
            this.radialGaugeNeedle1.InnerPointRadiusPercentage = (double)this.spinInnerPointRadiusPercentage.Value;
        }

        private void spinPointRadiusPercentage_ValueChanged(object sender, EventArgs e)
        {
            this.radialGaugeNeedle1.PointRadiusPercentage = (double)this.spinPointRadiusPercentage.Value;
        }

        private void spinTicksCount_ValueChanged(object sender, EventArgs e)
        {
            this.radialGaugeTicks1.TicksCount = (int)this.spinTicksCount.Value - 1;
        }

        private void spinTickTickness_ValueChanged(object sender, EventArgs e)
        {
            this.radialGaugeTicks1.TickThickness = (float)this.spinTickTickness.Value;
        }

        private void spinTicksLenght_ValueChanged(object sender, EventArgs e)
        {
            this.radialGaugeTicks1.TicksLenghtPercentage = (float)this.spinTicksLenght.Value;
        }

        private void radLabelCount_ValueChanged(object sender, EventArgs e)
        {
            this.radialGaugeLabels1.LabelsCount = (int)this.spinLabelCount.Value - 1;
        }

        private void spinLabelRadius_ValueChanged(object sender, EventArgs e)
        {
            this.radialGaugeLabels1.LabelRadiusPercentage = (float)this.spinLabelRadius.Value;
        }

        private void spinArc1Width_ValueChanged(object sender, EventArgs e)
        {
            switch(this.radDropDownList1.SelectedIndex)
            {
                case 0:
                    this.radialGaugeArc1.Width = (double)this.spinArc1Width.Value;
                    break;
                case 1:
                    this.radialGaugeArc2.Width = (double)this.spinArc1Width.Value;
                    break;
                case 2:
                    this.radialGaugeArc3.Width = (double)this.spinArc1Width.Value;
                    break;
            }
        }

        private void spinArc1Radius_ValueChanged(object sender, EventArgs e)
        {
            switch (this.radDropDownList1.SelectedIndex)
            {
                case 0:
                    this.radialGaugeArc1.Radius = (double)this.spinArc1Radius.Value;
                    break;
                case 1:
                    this.radialGaugeArc2.Radius = (double)this.spinArc1Radius.Value;
                    break;
                case 2:
                    this.radialGaugeArc3.Radius = (double)this.spinArc1Radius.Value;
                    break;
            }
        }
        
        private void colorBoxTicks_ValueChanged(object sender, EventArgs e)
        {
            this.radialGaugeTicks1.TickColor= this.colorBoxTicks.Value;
        }

        private void colorBoxArc_ValueChanged(object sender, System.EventArgs e)
        {
            switch (this.radDropDownList1.SelectedIndex)
            {
                case 0:
                    this.radialGaugeArc1.BackColor2 =
                    this.radialGaugeArc1.BackColor = this.colorBoxArc.Value;
                    break;
                case 1:
                    this.radialGaugeArc2.BackColor2 =
                    this.radialGaugeArc2.BackColor = this.colorBoxArc.Value;
                    break;
                case 2:
                    this.radialGaugeArc3.BackColor2 =
                    this.radialGaugeArc3.BackColor = this.colorBoxArc.Value;
                    break;
            }
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (this.radDropDownList1.SelectedIndex)
            {
                case 0:
                    this.colorBoxArc.Value = this.radialGaugeArc1.BackColor;
                    this.spinArc1Radius.Value = (decimal)this.radialGaugeArc1.Radius;
                    this.spinArc1Width.Value = (decimal)this.radialGaugeArc1.Width;
                    break;
                case 1:
                    this.colorBoxArc.Value = this.radialGaugeArc2.BackColor;
                    this.spinArc1Radius.Value = (decimal)this.radialGaugeArc2.Radius;
                    this.spinArc1Width.Value = (decimal)this.radialGaugeArc2.Width;
                    break;
                case 2:
                    this.colorBoxArc.Value = this.radialGaugeArc3.BackColor;
                    this.spinArc1Radius.Value = (decimal)this.radialGaugeArc3.Radius;
                    this.spinArc1Width.Value = (decimal)this.radialGaugeArc3.Width;
                    break;
            }
        }

        public void SaveLayout(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.radRadialGauge1.SaveLayout(saveFileDialog.FileName);
            }
        }

        public void LoadLayout(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.radRadialGauge1.LoadLayout(openFileDialog.FileName);
                DisableEditors();
            }
        }

        private void DisableEditors()
        {
            foreach (Control cnt in this.radRadialGauge1.Parent.Controls)
            {
                if (cnt is RadRadialGauge || cnt is RadButton || cnt is RadLabel)
                {
                    continue;
                }

                cnt.Enabled = false;
            }
        }
    }
}