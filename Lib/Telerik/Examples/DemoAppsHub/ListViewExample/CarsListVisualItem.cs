using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls.Layouts;
using System.Drawing;
using System.Windows.Forms;

namespace DemoAppsHub.ListViewExample
{
    public class CarsListVisualItem : SimpleListViewVisualItem
    {
        private LightVisualElement element1;
        private LightVisualElement element2;
        private LightVisualElement element3;
        private LightVisualElement element4;
        private StackLayoutPanel layout;

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.layout = new StackLayoutPanel();
            this.layout.EqualChildrenWidth = true;
            this.layout.Margin = new Padding(180, 30, 0, 0);

            this.element1 = new LightVisualElement();
            element1.TextAlignment = ContentAlignment.MiddleLeft;
            element1.MinSize = new Size(170, 0);
            element1.NotifyParentOnMouseInput = true;
            element1.ShouldHandleMouseInput = false;
            this.layout.Children.Add(this.element1);

            this.element2 = new LightVisualElement();
            element2.TextAlignment = ContentAlignment.MiddleLeft;
            element2.MinSize = new Size(170, 0);
            element2.NotifyParentOnMouseInput = true;
            element2.ShouldHandleMouseInput = false;
            this.layout.Children.Add(this.element2);

            this.element3 = new LightVisualElement();
            element3.TextAlignment = ContentAlignment.MiddleLeft;
            element3.MinSize = new Size(170, 0);
            element3.NotifyParentOnMouseInput = true;
            element3.ShouldHandleMouseInput = false;
            this.layout.Children.Add(this.element3);

            this.element4 = new LightVisualElement();
            element4.TextAlignment = ContentAlignment.MiddleLeft;
            element4.MinSize = new Size(170, 0);
            element4.NotifyParentOnMouseInput = true;
            element4.ShouldHandleMouseInput = false;
            this.layout.Children.Add(this.element4);

            this.Children.Add(this.layout);
        }

        private bool ContainsFeature(ListViewDataItem item, string feature)
        {
            return item[feature] != null && Convert.ToInt32(item[feature]) != 0;
        }

        protected override void SynchronizeProperties()
        {
            base.SynchronizeProperties();

            this.Text = "<html><span style=\"color:#141718;font-size:14.5pt;\">" + this.Data["Make"] + " " + this.Data["Model"] + "</span>";

            this.element1.Text = "<html><span style=\"color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;\">" +
                "Manufactured:<span style=\"color:#13224D;font-family:Segoe UI;\">" + this.Data["CarYear"] + "</span>" +
                "<br>Category:<span style=\"color:#13224D;font-family:Segoe UI;\">" + this.Data["CategoryName"] + "</span></span>";

            this.element2.Text = "<html><span style=\"color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;\">" +
                "ABS:" + (this.ContainsFeature(this.Data, "ABS") ? "<span style=\"color:#13224D;font-family:Segoe UI;\">YES" : "<span style=\"color:#D71B0E;\">NO") + "</span>" +
                "<br>ESR:" + (this.ContainsFeature(this.Data, "ESR") ? "<span style=\"color:#13224D;font-family:Segoe UI;\">YES" : "<span style=\"color:#D71B0E;\">NO") + "</span>" + "</span>";

            this.element3.Text = "<html><span style=\"color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;\">" +
                "MP3 Player:" + (this.ContainsFeature(this.Data, "Mp3Player") ? "<span style=\"color:#13224D;font-family:Segoe UI;\">YES" : "<span style=\"color:#D71B0E;\">NO") + "</span>" +
                "<br>DVD Player:" + (this.ContainsFeature(this.Data, "DVDPlayer") ? "<span style=\"color:#13224D;font-family:Segoe UI;\">YES" : "<span style=\"color:#D71B0E;\">NO") + "</span>" + "</span>";

            this.element4.Text = "<html><span style=\"color:#010102;font-size:10.5pt;font-family:Segoe UI Semibold;\">" +
                "Air Conditioner:" + (this.ContainsFeature(this.Data, "AirConditioner") ? "<span style=\"color:#13224D;font-family:Segoe UI;\">YES" : "<span style=\"color:#D71B0E;\">NO") + "</span>" +
                "<br>Navigation:" + (this.ContainsFeature(this.Data, "Navigation") ? "<span style=\"color:#13224D;font-family:Segoe UI;\">YES" : "<span style=\"color:#D71B0E;\">NO") + "</span>" + "</span>";

            this.TextAlignment = ContentAlignment.TopLeft;
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(SimpleListViewVisualItem);
            }
        }
    }
}
