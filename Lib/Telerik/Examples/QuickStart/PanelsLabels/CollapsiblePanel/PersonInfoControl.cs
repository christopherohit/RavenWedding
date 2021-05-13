using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using Telerik.Fixed.Legacy;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.PanelsLabels.CollapsiblePanel
{
    [ToolboxItem(true)]
    public class PersonInfoControl : RadControl
    {
        private PersonInfoElement personInfoElement;

        protected override void CreateChildItems(RadElement parent)
        {
            this.personInfoElement = new PersonInfoElement();
            parent.Children.Add(this.personInfoElement);
        }
        protected override void OnThemeChanged()
        {
            base.OnThemeChanged();
            if (TelerikHelper.IsDarkTheme(this.ThemeName))
            {
                personInfoElement.NameElement.ForeColor = Color.White;
                personInfoElement.EmailElement.ForeColor = Color.White;
                personInfoElement.PhoneElement.ForeColor = Color.White;
            }
            else
            {
                personInfoElement.NameElement.ForeColor = Color.Black;
                personInfoElement.EmailElement.ForeColor = Color.Black;
                personInfoElement.PhoneElement.ForeColor = Color.Black;
            }
        }
        protected override System.Drawing.Size DefaultSize
        {
            get
            {
                return RadControl.GetDpiScaledSize(new System.Drawing.Size(300, 130));
            }
        }

        public string PersonName
        {
            get { return this.personInfoElement.NameElement.Text; }
            set { this.personInfoElement.NameElement.Text = value; }
        }

        public string PersonEmail
        {
            get { return this.personInfoElement.EmailElement.Text; }
            set { this.personInfoElement.EmailElement.Text = value; }
        }

        public string PersonPhone
        {
            get { return this.personInfoElement.PhoneElement.Text; }
            set { this.personInfoElement.PhoneElement.Text = value; }
        }

        public Image PersonImage
        {
            get { return this.personInfoElement.ImageElement.Image; }
            set { this.personInfoElement.ImageElement.Image = value; }
        }
    }
}
