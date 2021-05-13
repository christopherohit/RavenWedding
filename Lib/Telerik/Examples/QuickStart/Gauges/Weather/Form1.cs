using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI.Gauges;

namespace Telerik.Examples.WinControls.Gauges.Weather
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        string[] resourceNames = new string[] {
            "Telerik.Examples.WinControls.Gauges.Weather.partly-cloudy.png",
            "Telerik.Examples.WinControls.Gauges.Weather.rainy.png",
            "Telerik.Examples.WinControls.Gauges.Weather.sunny.png",
            "Telerik.Examples.WinControls.Gauges.Weather.thunderstorm.png",
        };

        string[] weatherNames = new string[] {
            "Partly Cloudy",
            "Rainy",
            "Sunny",
            "Thunderstorm",
        };

        List<Bitmap> weatherImages = new List<Bitmap>(4);       
       
        public Form1()
        {
            this.LoadImages();
            InitializeComponent();

            this.pictureBox1.Image = this.weatherImages[0];
            this.UpdateIndicatorValues();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        
        private void ApplyValueToGauge(RadLinearGauge radRadialGauge,float value)
        {            
            AnimatedPropertySetting setting = new AnimatedPropertySetting(
                RadLinearGaugeElement.ValueProperty,
                radRadialGauge.Value,
                value,
                12,
                40);
            setting.ApplyEasingType = RadEasingType.Linear;
            setting.ApplyValue(radRadialGauge.GaugeElement);
        }

        private void LoadImages()
        {
            Assembly assembly = typeof(Telerik.Examples.WinControls.Gauges.Weather.Form1).Assembly;
            foreach (string imageName in this.resourceNames)
            {
                using (Stream stream = assembly.GetManifestResourceStream(imageName))
                {
                    if (stream == null)
                    {
                        break;
                    }

                    weatherImages.Add(new Bitmap(stream));
                }
            }
        }

        private void radTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            UpdateIndicatorValues();
        }
 
        private void UpdateIndicatorValues()
        {
            int index = this.GetRand(0, 3);
            
            this.pictureBox1.Image = this.weatherImages[index];
            this.labelSunny.Text = this.weatherNames[index];

            int degree = this.GetRand(15, 36);

            this.labelDegree.Text = degree.ToString();
            this.labelFeelsLike.Text = "Feels like " + (degree + this.GetRand(-8, 8)).ToString();

            this.ApplyValueToGauge(this.radLinearGauge1, degree);
            float rainFail = GetRand(0f, 3f);
            this.labelRainfall.Text = string.Format("{0:n1}mm", rainFail);
            this.ApplyValueToGauge(this.radLinearGauge2, rainFail);

            float humidity = GetRand(10f, 100f);
            this.labelHumidity.Text = string.Format("{0:p0}", humidity / 100);
            this.ApplyValueToGauge(this.radLinearGauge3, humidity);

            float pressure = GetRand(0f, 100f);
            this.labelPressure.Text = string.Format("{0:n0}hPa", pressure);
            this.ApplyValueToGauge(this.radLinearGauge4, pressure);

            float windSpeed = GetRand(0f, 9f);
            this.labelWindSpeed.Text = string.Format("{0:n0}m/s", windSpeed); 
            this.ApplyValueToGauge(this.radLinearGauge5, windSpeed);
        }

        public float GetRand(float minimum, float maximum)
        {
            Random random = new Random(DateTime.Now.Millisecond - (int)this.radTrackBar1.Value);
            return (float)( random.NextDouble() * (maximum - minimum) + minimum);
        }

        public int GetRand(int minimum, int maximum)
        {
            Random random = new Random(DateTime.Now.Millisecond + (int)this.radTrackBar1.Value);            
            return random.Next(minimum, maximum);
        }       
    }
}
