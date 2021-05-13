using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using System.Data;
using Telerik.WinControls;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.Primitives;

namespace Telerik.Examples.WinControls.TreeView.Customize.CustomNodes
{
    public class CustomContentElement : TreeNodeContentElement
    {
        LightVisualElement imageElement;
        LinePrimitive lineElement;
        LightVisualElement textElement;
        LightVisualElement descriptionElement;

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(TreeNodeContentElement);
            }
        }        

        public override void Synchronize()
        {
            this.StretchHorizontally = true;
            this.Padding = new Padding(10);
            this.Margin = new Padding(0, 5, 0, 5);
            this.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.TextWrap = true;

            TreeNodeElement treeNodeElement = this.NodeElement;
            RadTreeNode node = treeNodeElement.Data;
            DataRowView rowView = (DataRowView)node.DataBoundItem;

            this.textElement.Text = "<html><b>" + rowView["LastName"] + ", " + rowView["FirstName"] + " - <i>" + rowView["Title"];
            this.descriptionElement.Text = (string)rowView["Notes"];
            this.imageElement.Image = ImageHelper.GetImageFromBytes((byte[])rowView["Photo"]);

            this.DrawBorder = true;
            this.DrawFill = true;
            this.BorderColor = Color.FromArgb(110, 153, 210);
            this.ForeColor = Color.Black;
            this.GradientStyle = GradientStyles.Linear;
            this.NumberOfColors = 2;

            if (node.Level == 0)
            {
                this.BackColor = Color.FromArgb(248, 248, 248);
                this.BackColor2 = Color.FromArgb(233, 233, 233);
            }
            else if (node.Level == 1)
            {
                this.BackColor = Color.FromArgb(230, 239, 255);
                this.BackColor2 = Color.FromArgb(225, 228, 235);
            }
            else 
            {
                this.BackColor = Color.FromArgb(174, 190, 217);
                this.BackColor2 = Color.FromArgb(168, 183, 210);
            }
        }

        protected override void InitializeFields()
        {
            base.InitializeFields();
        }

        protected override void CreateChildElements()
        {
            imageElement = new LightVisualElement();
            imageElement.MaxSize = new Size(105, 120);
            imageElement.MinSize = new Size(105, 120);
            imageElement.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            imageElement.ImageAlignment = ContentAlignment.BottomCenter;
            imageElement.Margin = new Padding(0, 0, 4, 0);
            imageElement.DrawBorder = true;
            imageElement.BorderColor = Color.Gray;
            imageElement.DrawFill = true;
            imageElement.BackColor = Color.White;
            imageElement.GradientStyle = GradientStyles.Solid;                 
            imageElement.BorderGradientStyle = GradientStyles.Solid;
            imageElement.ImageAlignment = ContentAlignment.TopLeft;
            this.Children.Add(imageElement);

            lineElement = new LinePrimitive();
            lineElement.BackColor = Color.Black;
            this.Children.Add(lineElement);

            textElement = new LightVisualElement();
            this.textElement.DisableHTMLRendering = false;
            this.textElement.TextAlignment = ContentAlignment.TopLeft;
            this.textElement.TextWrap = true;
            this.Children.Add(textElement);

            descriptionElement = new LightVisualElement();
            descriptionElement.TextAlignment = ContentAlignment.TopLeft;
            this.descriptionElement.TextWrap = true;
            this.descriptionElement.AutoEllipsis = true;
            this.Children.Add(descriptionElement);

            this.Shape = new RoundRectShape(2);
            this.StretchHorizontally = true;
        }

        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            base.MeasureOverride(availableSize);

            availableSize.Width -= Padding.Horizontal;
            availableSize.Height -= Padding.Vertical;

            this.imageElement.Measure(availableSize);

            availableSize.Width -= this.imageElement.DesiredSize.Width;

            this.textElement.Measure(availableSize);

            this.descriptionElement.Measure(availableSize);

            SizeF desiredSize = SizeF.Empty;

            desiredSize.Height += this.textElement.DesiredSize.Height + 4;
            desiredSize.Height += this.lineElement.DesiredSize.Height + 4;
            desiredSize.Height += this.descriptionElement.DesiredSize.Height;
            desiredSize.Height += this.Padding.Vertical;
            desiredSize.Height = Math.Max(desiredSize.Height, this.imageElement.DesiredSize.Height + 20);

            desiredSize.Width = Math.Max(this.textElement.DesiredSize.Width, this.descriptionElement.DesiredSize.Width);
            desiredSize.Width += this.imageElement.DesiredSize.Width;

            return desiredSize;
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            RectangleF clientRect = GetClientRectangle(finalSize);

            float offset = (clientRect.Height - this.imageElement.DesiredSize.Height) / 2;
            this.imageElement.Arrange(new RectangleF(clientRect.X, clientRect.Y, this.imageElement.DesiredSize.Width, this.imageElement.DesiredSize.Height));

            float imageWidth = this.imageElement.DesiredSize.Width + 5;
            clientRect.X += imageWidth;
            clientRect.Width -= imageWidth;

            this.textElement.Arrange(new RectangleF(clientRect.X, clientRect.Y, clientRect.Width, this.textElement.DesiredSize.Height));

            float textHeight = this.textElement.DesiredSize.Height + 2;
            clientRect.Y += textHeight;
            clientRect.Height -= textHeight;

            this.lineElement.Arrange(new RectangleF(clientRect.X, clientRect.Y, clientRect.Width - 5, this.lineElement.DesiredSize.Height));

            float lineHeight = this.lineElement.DesiredSize.Height + 2;
            clientRect.Y += lineHeight;
            clientRect.Height -= lineHeight;

            this.descriptionElement.Arrange(new RectangleF(clientRect.X, clientRect.Y, clientRect.Width, this.descriptionElement.DesiredSize.Height));

            return finalSize;
        }
    }
}
