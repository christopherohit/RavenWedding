using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.PanelsLabels.CollapsiblePanel
{
    public class PersonInfoElement : LightVisualElement
    {
        private DockLayoutPanel mainContainer = new DockLayoutPanel();

        private LightVisualElement imageElement;

        private RadLabelElement nameElement;
        private RadLabelElement emailElement;
        private RadLabelElement phoneElement;
        private StackLayoutPanel infoStack;

        public LightVisualElement ImageElement
        {
            get { return this.imageElement; }
        }

        public RadLabelElement NameElement
        {
            get { return this.nameElement; }
        }

        public RadLabelElement EmailElement
        {
            get { return this.emailElement; }
        }

        public RadLabelElement PhoneElement
        {
            get { return this.phoneElement; }
        }

        protected override void InitializeFields()
        {
            base.InitializeFields();

            this.Shape = new RoundRectShape(5);
            this.DrawBorder = true;
            this.BorderColor = Color.FromArgb(197, 208, 222);
            this.Padding = new System.Windows.Forms.Padding(10);
         
        }

        

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.mainContainer = new DockLayoutPanel();
            this.mainContainer.LastChildFill = true;
            this.Children.Add(this.mainContainer);

            this.imageElement = new LightVisualElement();
            this.imageElement.DrawBorder = true;
            this.imageElement.BorderColor = Color.FromArgb(224, 224, 224);
            this.mainContainer.Children.Add(imageElement);
            DockLayoutPanel.SetDock(this.imageElement, Dock.Left);

            this.infoStack = new StackLayoutPanel();
            this.infoStack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.mainContainer.Children.Add(this.infoStack);

            this.nameElement = new RadLabelElement();
            this.nameElement.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            this.nameElement.Text = "Name: ";
            this.infoStack.Children.Add(this.nameElement);

            this.emailElement = new RadLabelElement();
            this.emailElement.Text = "Email: ";
            this.infoStack.Children.Add(this.emailElement);

            this.phoneElement = new RadLabelElement();
            this.phoneElement.Text = "Phone: ";
            this.infoStack.Children.Add(this.phoneElement);
        }
    }
}
