#if NET4
using GoogleAnalytics;
using System;
using System.Windows.Forms;

namespace MedicalApp.Analytics
{
    public class PlatformInfoProvider : IPlatformInfoProvider
    {
        private string anonymousClientId;
        private int? screenColors;
        private Dimensions? screenResolution;
        private string userAgent;
        private string userLanguage;
        private Dimensions? viewPortResolution;

        public PlatformInfoProvider()
        {
            InitializeWindow();
        }

        public string AnonymousClientId
        {
            get
            {
                return this.anonymousClientId;
            }
            private set
            {
                this.anonymousClientId = value;
            }
        }

        public int? ScreenColors
        {
            get
            {
                return this.screenColors;
            }
            private set
            {
                this.screenColors = value;
            }
        }

        public Dimensions? ScreenResolution
        {
            get
            {
                return this.screenResolution;
            }
            private set
            {
                this.screenResolution = value;
                if (ScreenResolutionChanged != null)
                {
                    ScreenResolutionChanged(this, EventArgs.Empty);
                }
            }
        }

        public string UserAgent
        {
            get
            {
                return this.userAgent;
            }
            private set
            {
                this.userAgent = value;
            }
        }

        public string UserLanguage
        {
            get
            {
                return this.userLanguage;
            }
            private set
            {
                this.userLanguage = value;
            }
        }

        public Dimensions? ViewPortResolution
        {
            get { return this.viewPortResolution; }
            private set
            {
                this.viewPortResolution = value;
                if (ViewPortResolutionChanged != null)
                {
                    ViewPortResolutionChanged(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler ScreenResolutionChanged;
        public event EventHandler ViewPortResolutionChanged;
        public void OnTracking()
        { }

        private void InitializeWindow()
        {
            this.AnonymousClientId = Guid.NewGuid().ToString();
            this.ScreenResolution = this.GetScreenResolution();
            this.UserAgent = this.GetUserAgent();//"Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko";
            this.UserLanguage = this.GetUserLanguage();
            this.ViewPortResolution = this.GetViewPortResolution();
        }

        private Dimensions? GetScreenResolution()
        {
            return new Dimensions(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private string GetUserAgent()
        {
            return Environment.OSVersion.ToString();
        }

        private string GetUserLanguage()
        {
            return System.Globalization.CultureInfo.CurrentUICulture.Name;
        }

        private Dimensions? GetViewPortResolution()
        {
            return new Dimensions(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }
    }
}
#endif