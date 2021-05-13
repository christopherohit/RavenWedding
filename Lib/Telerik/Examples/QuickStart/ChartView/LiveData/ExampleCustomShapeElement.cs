using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using System.Drawing;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.ChartView.LiveData
{
    class ExampleCustomShapeElement : LightVisualElement
    {
        LightVisualElement leftText;
        LightVisualElement rightText;

        public string LeftText
        {
            get 
            { 
                return leftText.Text;
            }
            set 
            {
                leftText.Text = value; 
            }
        }
        public string RightText
        {
            get
            { 
                return rightText.Text;
            }
            set 
            { 
                rightText.Text = value;
            }
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.BackColor = Color.FromArgb(142, 196, 65);
            this.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            this.Shape = GetShape();
            this.DrawFill = true;
            this.GradientStyle = GradientStyles.Solid;

            rightText = new LightVisualElement();
            rightText.ForeColor = Color.Black;
            rightText.TextWrap = true;
            rightText.TextAlignment = ContentAlignment.MiddleLeft;

            leftText = new LightVisualElement();
            leftText.ForeColor = Color.White;
            leftText.Font = new Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular);
            leftText.TextAlignment = ContentAlignment.MiddleRight;

            this.Children.Add(leftText);
            this.Children.Add(rightText);
        }

        private ElementShape GetShape()
        {
            List<PointF> points = new List<PointF>(){new PointF(0,30),new PointF(10,0),new PointF(200,0),new PointF(200,30)};
            CustomShape shape = new CustomShape();
            shape.CreateClosedShape(points);
            return shape;
        }

        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            SizeF result = SizeF.Empty;

            base.MeasureOverride(availableSize);

            SizeF availableRightTextSize = new SizeF(80, availableSize.Height);
            this.rightText.Measure(availableRightTextSize);

            SizeF rightTextDesiredSize = this.rightText.DesiredSize;
            SizeF availableLeftTextSize = new SizeF(availableSize.Width - rightTextDesiredSize.Width, availableSize.Height);
            this.leftText.Measure(availableLeftTextSize);

            result.Width += rightTextDesiredSize.Width + leftText.DefaultSize.Width;
            result.Height = availableSize.Height;

            return result;
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            RectangleF rect = GetClientRectangle(finalSize);

            //rightText
            RectangleF rightTextArea = new RectangleF(finalSize.Width - 85, 0, this.rightText.DesiredSize.Width, rect.Height);
            this.rightText.Arrange(rightTextArea);

            //leftText
            RectangleF leftTextArea = new RectangleF(finalSize.Width - 90 - this.leftText.DesiredSize.Width, 0, this.leftText.DesiredSize.Width, rect.Height);
            this.leftText.Arrange(leftTextArea);

            return finalSize;
        }

        



    }
}

