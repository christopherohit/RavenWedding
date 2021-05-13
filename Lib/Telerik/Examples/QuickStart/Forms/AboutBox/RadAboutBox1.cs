using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Forms.AboutBox
{
    partial class RadAboutBox1 : ExamplesRadForm
    {
        private Assembly executingAssembly;

        public RadAboutBox1()
        {
            InitializeComponent();

            // Initialize the AboutBox to display the product information from the assembly information.
            // Change assembly information settings for your application through either:
            // - Project -> Properties -> Application -> Assembly Information
            // - AssemblyInfo.cs
            this.Text = string.Format("About {0}", this.AssemblyTitle);
            this.radLabelProductName.Text = this.AssemblyProduct;
            this.radLabelVersion.Text = string.Format("Version {0}", this.AssemblyVersion);
            string assemblyCopyright = this.AssemblyCopyright;
            this.radLabelCopyright.Text = assemblyCopyright.Substring(0, assemblyCopyright.IndexOf("."));
            this.radLabelCompanyName.Text = this.AssemblyCompany;
            this.radTextBoxDescription.Text = 
                VersionNumber.ProductName + " includes over 140 UI controls that you can " +
                "use to easily build unique and visually stunning Line of Business applications. " +
                "Boasting a well-designed architecture and CAB support, RadControls are perfectly " +
                "suited for your Enterprise desktop development.";
            this.logoPictureBox.Image = this.GetAboutBoxImage();
        }

        public Assembly ExecutingAssembly
        {
            get
            {
                if (this.executingAssembly == null)
                {
                    this.executingAssembly = Assembly.GetExecutingAssembly();
                }

                return this.executingAssembly;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            string themeName = this.ThemeName;

            base.OnLoad(e);

            ThemeResolutionService.ApplyThemeToControlTree(this, themeName);
        }

        private Image GetAboutBoxImage()
        {
            Image img;
            Stream imageStream;
            string imageFileName = "AboutBox.png";

            imageStream = this.ExecutingAssembly.GetManifestResourceStream(
                string.Format("Telerik.Examples.WinControls.Forms.AboutBox.{0}", imageFileName));
            img = Bitmap.FromStream(imageStream);

            if (img == null)
            {
                imageStream = this.ExecutingAssembly.GetManifestResourceStream(string.Format(imageFileName));
                img = Bitmap.FromStream(imageStream);
            }

            return img;
        }

        #region Assembly Attribute Accessors

        private T GetAssemblyAttribute<T>()
        {
            object[] attributes = this.ExecutingAssembly.GetCustomAttributes(typeof(T), false);
            if (attributes.Length == 0)
            {
                return default(T);
            }

            return (T)attributes[0];
        }

        public string AssemblyTitle
        {
            get
            {                
                AssemblyTitleAttribute titleAttribute = this.GetAssemblyAttribute<AssemblyTitleAttribute>();
                if (titleAttribute != null && titleAttribute.Title != string.Empty)
                {
                    return titleAttribute.Title;
                }

                // If there was no Title attribute, or if the Title attribute was the empty string, return the .exe name
                return Path.GetFileNameWithoutExtension(this.ExecutingAssembly.CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return this.ExecutingAssembly.GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                AssemblyDescriptionAttribute attr = this.GetAssemblyAttribute<AssemblyDescriptionAttribute>();
                if (attr == null)
                {
                    return string.Empty;
                }

                // If there is a Description attribute, return its value
                return attr.Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                AssemblyProductAttribute attr = this.GetAssemblyAttribute<AssemblyProductAttribute>();
                if (attr == null)
                {
                    return string.Empty;
                }

                // If there is a Product attribute, return its value
                return attr.Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                AssemblyCopyrightAttribute attr = this.GetAssemblyAttribute<AssemblyCopyrightAttribute>();
                if (attr == null)
                {
                    return string.Empty;
                }

                // If there is a Copyright attribute, return its value
                return attr.Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                AssemblyCompanyAttribute attr = this.GetAssemblyAttribute<AssemblyCompanyAttribute>();
                if (attr == null)
                {
                    return string.Empty;
                }

                // If there is a Company attribute, return its value
                return attr.Company;
            }
        }

        #endregion
    }
}
