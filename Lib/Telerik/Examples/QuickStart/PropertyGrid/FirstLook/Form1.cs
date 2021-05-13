using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using System.Drawing;
using Telerik.WinControls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Telerik.Examples.WinControls.PropertyGrid.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        //protected override void OnSizeChanged(EventArgs e)
        //{
        //    base.OnSizeChanged(e);
        //    if (this.radSplitContainer1 != null)
        //    {
        //        int width = this.ClientSize.Width;
        //        int height = this.ClientSize.Height;
        //        this.radSplitContainer1.Location = new Point((width - radSplitContainer1.Size.Width) / 2, (height - radSplitContainer1.Size.Height) / 2);
        //    }
        //}


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            RadButtonElement button = new RadButtonElement();
            button.Text = "button";
            button.MinSize = new System.Drawing.Size(button.MinSize.Width, 24);
            surface1.BackColor = Color.Transparent;
            surface1.Element.Children.Add(new SurfaceObject(65, 154, button));
            surface1.Element.CurrentObjectChanged += new EventHandler(Element_CurrentObjectChanged);
            surface1.Element.CurrentObject = (SurfaceObject)surface1.Element.Children[0];

            radButtonRemove.Enabled = false;
        }

        void Element_CurrentObjectChanged(object sender, EventArgs e)
        {
            SurfaceObject currentObject = ((SurfaceElement)sender).CurrentObject;
            this.radPropertyGrid1.SelectedObject = new RadElementWrapper(currentObject, (RadItem)currentObject.Children[0]);
        }

        private void radMenuItem1_Click_1(object sender, EventArgs e)
        {
            RadButtonElement button = new RadButtonElement();
            button.Text = "button";
            button.MinSize = new System.Drawing.Size(button.MinSize.Width, 24);
            surface1.Element.Children.Add(new SurfaceObject(10, 10, button));
            radButtonRemove.Enabled = true;
            surface1.Element.CurrentObject = (SurfaceObject)surface1.Element.Children[surface1.Element.Children.Count - 1];
        }

        private void radMenuItem2_Click_1(object sender, EventArgs e)
        {
            RadLabelElement label = new RadLabelElement();
            label.Text = "label";
            surface1.Element.Children.Add(new SurfaceObject(10, 10, label));
            radButtonRemove.Enabled = true;
            surface1.Element.CurrentObject = (SurfaceObject)surface1.Element.Children[surface1.Element.Children.Count - 1];
        }

        private void radMenuItem3_Click_1(object sender, EventArgs e)
        {
            RadCheckBoxElement checkbox = new RadCheckBoxElement();
            checkbox.Text = "checkbox";
            surface1.Element.Children.Add(new SurfaceObject(10, 10, checkbox));
            radButtonRemove.Enabled = true;
            surface1.Element.CurrentObject = (SurfaceObject)surface1.Element.Children[surface1.Element.Children.Count - 1];
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            RadRadioButtonElement radioButton = new RadRadioButtonElement();
            radioButton.Text = "radio button";
            surface1.Element.Children.Add(new SurfaceObject(10, 10, radioButton));
            radButtonRemove.Enabled = true;
            surface1.Element.CurrentObject = (SurfaceObject)surface1.Element.Children[surface1.Element.Children.Count - 1];
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            RadScrollBarElement scrollbar = new RadScrollBarElement();
            surface1.Element.Children.Add(new SurfaceObject(10, 10, scrollbar));
            radButtonRemove.Enabled = true;
            surface1.Element.CurrentObject = (SurfaceObject)surface1.Element.Children[surface1.Element.Children.Count - 1];
        }

        private void radButtonRemove_Click(object sender, EventArgs e)
        {
            if (surface1.Element.Children.Count > 1)
            {
                surface1.Element.Children.Remove(surface1.Element.CurrentObject);
                surface1.Element.CurrentObject = (SurfaceObject)surface1.Element.Children[surface1.Element.Children.Count - 1];
                surface1.Element.Invalidate();
            }

            radButtonRemove.Enabled = surface1.Element.Children.Count > 1;
        }

        protected override void WireEvents()
        {
            this.radMenuItem1.Click += new System.EventHandler(this.radMenuItem1_Click_1);
            this.radMenuItem2.Click += new System.EventHandler(this.radMenuItem2_Click_1);
            this.radMenuItem3.Click += new System.EventHandler(this.radMenuItem3_Click_1);
            this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click);
            this.radMenuItem5.Click += new System.EventHandler(this.radMenuItem5_Click);
            this.radButtonRemove.Click += new System.EventHandler(this.radButtonRemove_Click);
        }
    }
}
