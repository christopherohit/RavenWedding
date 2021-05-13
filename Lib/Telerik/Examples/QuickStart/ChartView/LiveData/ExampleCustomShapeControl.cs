using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls;
using System.Drawing;
using System.ComponentModel;

namespace Telerik.Examples.WinControls.ChartView.LiveData
{
    [ToolboxItem(true)]
    class ExampleCustomShapeControl : RadControl
    {
        private ExampleCustomShapeElement element;

        public ExampleCustomShapeElement Element
        {
            get { return element; }
        }

        public string LeftText 
        {
            get 
            {
                return this.element.LeftText;
            }
            set 
            {
                this.element.LeftText = value;
            }
        }

        public string RightText
        {
            get
            {
                return this.element.RightText;
            }
            set
            {
                this.element.RightText = value;
            }
        }

        public ExampleCustomShapeControl() 
        {

        }

        protected override Size DefaultSize
        {
            get
            {
                return new Size(200, 30);
            }
        }

        protected override void CreateChildItems(RadElement parent)
        {
            this.element = new ExampleCustomShapeElement();
            this.RootElement.Children.Add(element);
            base.CreateChildItems(parent);
        }
    }
}
