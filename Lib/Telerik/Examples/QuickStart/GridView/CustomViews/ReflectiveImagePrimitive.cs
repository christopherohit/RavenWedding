using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;
using System.Drawing;

namespace Telerik.Examples.WinControls.GridView.CustomViews
{
    public class ReflectiveImagePrimitive : LightVisualElement
    {
        #region Fields

        private ImagePrimitive imagePrimitive;
        private ReflectionPrimitive reflectionPrimitive;

        #endregion

        #region Properties

        public override Image Image
        {
            get
            {
                return this.imagePrimitive.Image;
            }
            set
            {
                if (this.imagePrimitive.Image != value)
                {
                    this.imagePrimitive.Image = value;
                    if (this.Parent != null)
                    {
                        this.Parent.Invalidate();
                    }
                }
            }
        }

        #endregion

        #region Initialization

        protected override void InitializeFields()
        {
            base.InitializeFields();
            this.StretchVertically = false;
            this.StretchHorizontally = false;
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.imagePrimitive = new ImagePrimitive();
            this.Children.Add(this.imagePrimitive);

            this.reflectionPrimitive = new ReflectionPrimitive(this.imagePrimitive);
            this.reflectionPrimitive.ItemReflectionPercentage = 0.5;
            this.Children.Add(this.reflectionPrimitive);
        }

        #endregion

        #region Layout

        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            base.MeasureOverride(availableSize);
            return new SizeF(this.imagePrimitive.DesiredSize.Width, this.imagePrimitive.DesiredSize.Height * (float)this.reflectionPrimitive.ItemReflectionPercentage);
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            base.ArrangeOverride(finalSize);

            this.imagePrimitive.Arrange(new RectangleF(0, 0, finalSize.Width, finalSize.Height / (float)this.reflectionPrimitive.ItemReflectionPercentage));
            this.reflectionPrimitive.Arrange(new RectangleF(0, this.imagePrimitive.DesiredSize.Height, finalSize.Width, this.reflectionPrimitive.DesiredSize.Height / 3f));

            return finalSize;
        }

        #endregion
    }
}
