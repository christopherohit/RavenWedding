using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.PropertyGrid.FirstLook
{
    public class RadElementWrapper
    {
        RadItem element;
        SurfaceObject owner;

        public RadElementWrapper(SurfaceObject owner, RadItem element)
        {
            this.element = element;
            this.owner = owner;
        }

        #region Properties

        [Description("Gets or sets the text displayed in the control.")]
        [Category("Text")]
        [DefaultValue("RadPropertyGrid")]
        [Browsable(true)]
        public string Text
        {
            get
            {
                return this.element.Text;
            }
            set
            {
                this.element.Text = value;
            }
        }

        [Description("Gets or sets the size of the text displayed in the control.")]
        [Category("Text")]
        [DefaultValue(12)]
        [Browsable(true)]
        public float FontSize
        {
            get
            {
                return this.element.Font.Size;
            }
            set
            {
                this.element.Font = new Font(this.element.Font.FontFamily, value);
            }
        }

        [Description("Gets or sets the width of the control border.")]
        [Category("Border")]
        [DefaultValue(2.0f)]
        [Browsable(true)]
        public float BorderWidth
        {
            get
            {
                LightVisualElement lve = element as LightVisualElement;
                if (lve != null)
                {
                    return lve.BorderWidth;
                }
                BorderPrimitive border = element.FindDescendant<BorderPrimitive>();
                if (border != null)
                {
                    return border.Width;
                }
                return 1;
            }
            set
            {
                LightVisualElement lve = element as LightVisualElement;
                if (lve != null)
                {
                    lve.BorderWidth = value;
                }
                BorderPrimitive border = element.FindDescendant<BorderPrimitive>();
                if (border != null)
                {
                    border.Width = value;
                }
            }
        }

        [Description("Gets or sets the color of the control border.")]
        [Category("Border")]
        [DefaultValue(null)]
        [Browsable(true)]
        public Color BorderColor
        {
            get
            {
                LightVisualElement lve = element as LightVisualElement;
                if (lve != null)
                {
                    return lve.BorderColor;
                }
                BorderPrimitive border = element.FindDescendant<BorderPrimitive>();
                if (border != null)
                {
                    return border.ForeColor;
                }
                return Color.Black;
            }
            set
            {
                LightVisualElement lve = element as LightVisualElement;
                if (lve != null)
                {
                    lve.BorderColor = value;
                }
                BorderPrimitive border = element.FindDescendant<BorderPrimitive>();
                if (border != null)
                {
                    border.Width = Math.Max(1, border.Width);
                    border.BoxStyle = BorderBoxStyle.SingleBorder;
                    border.GradientStyle = GradientStyles.Solid;
                    border.Visibility = ElementVisibility.Visible;
                    border.ForeColor = value;
                    border.ShouldPaint = true;
                }
            }
        }

        [Description("Gets or sets the color of the fill of the control border.")]
        [Category("Background")]
        [DefaultValue(null)]
        [Browsable(true)]
        public Color BackColor
        {
            get
            {
                LightVisualElement lve = element as LightVisualElement;
                if (lve != null)
                {
                    return lve.BackColor;
                }
                FillPrimitive fill = element.FindDescendant<FillPrimitive>();
                if (fill != null)
                {
                    return fill.BackColor;
                }
                return Color.Black;
            }
            set
            {
                LightVisualElement lve = element as LightVisualElement;
                if (lve != null)
                {
                    lve.BackColor = value;
                }
                FillPrimitive fill = element.FindDescendant<FillPrimitive>();
                if (fill != null)
                {
                    fill.Visibility = ElementVisibility.Visible;
                    fill.ShouldPaint = true;
                    fill.GradientStyle = GradientStyles.Solid;
                    fill.BackColor = value;
                }
            }
        }

        [Description("Gets or sets the color of the text of the control border.")]
        [Category("Text")]
        [DefaultValue(null)]
        [Browsable(true)]
        public Color ForeColor
        {
            get
            {
                return this.element.ForeColor;
            }
            set
            {
                this.element.ForeColor = value;
            }
        }

        [Description("Gets or sets location of the control.")]
        [Category("Layout")]
        [DefaultValue(null)]
        [Browsable(true)]
        public Point Location
        {
            get
            {
                return this.owner.Offset;
            }
            set
            {
                this.owner.Offset = value;
            }
        }

        [Description("Gets or sets padding of the control.")]
        [Category("Layout")]
        [DefaultValue(null)]
        [Browsable(true)]
        public Padding Padding
        {
            get
            {
                return this.element.Padding;
            }
            set
            {
                this.element.Padding = value;
                this.owner.InvalidateMeasure(true);
            }
        }

        #endregion
    }
}
