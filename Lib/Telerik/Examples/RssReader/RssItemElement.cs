using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using RssReader.RSS_Library;
using System.Drawing;
using System.Text.RegularExpressions;

namespace RssReader
{
    public class RssItemElement : RadListVisualItem
    {

        #region Fields

        LightVisualElement imageElement;
        LightVisualElement headerElement;
        LightVisualElement descriptionElement;
        LightVisualElement pubDateElement;
        StackLayoutElement stackElement;
        bool supportedRssFeed = true;

        #endregion

        #region Overrides

        protected override void InitializeFields()
        {
            base.InitializeFields();
            this.ClipDrawing = true;
        }

        protected override void CreateChildElements()
        {
            imageElement = new LightVisualElement();
            imageElement.StretchHorizontally = false;
            imageElement.StretchVertically = true;
            imageElement.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            imageElement.Margin = new System.Windows.Forms.Padding(0,1,0,1);
            imageElement.NotifyParentOnMouseInput = true;
            this.Children.Add(imageElement);

            stackElement = new StackLayoutElement();
            stackElement.StretchVertically = true;
            stackElement.FitInAvailableSize = true;
            stackElement.Orientation = System.Windows.Forms.Orientation.Vertical;
            stackElement.StretchVertically = true;
            stackElement.NotifyParentOnMouseInput = true;
            this.Children.Add(stackElement);

            headerElement = new LightVisualElement();
            headerElement.StretchVertically = false;
            headerElement.TextAlignment = ContentAlignment.MiddleLeft;
            headerElement.Font = new System.Drawing.Font("Segoe UI", 9.25f, FontStyle.Bold);
            headerElement.TextWrap = true;
            headerElement.NotifyParentOnMouseInput = true;
            stackElement.Children.Add(headerElement);

            descriptionElement = new LightVisualElement();
            descriptionElement.StretchVertically = false;
            descriptionElement.Font = new System.Drawing.Font("Segoe UI", 9.25f);
            descriptionElement.TextAlignment = ContentAlignment.MiddleLeft;
            descriptionElement.TextWrap = true;
            descriptionElement.NotifyParentOnMouseInput = true;
            descriptionElement.AutoEllipsis = true;
            stackElement.Children.Add(descriptionElement);

            pubDateElement = new LightVisualElement();
            pubDateElement.Font = new System.Drawing.Font("Segoe UI", 9.25f);
            pubDateElement.NotifyParentOnMouseInput = true;
            pubDateElement.StretchVertically = false;
            pubDateElement.TextAlignment = ContentAlignment.MiddleLeft ;
            stackElement.Children.Add(pubDateElement);
        }

        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            SizeF originalAvailableSize = availableSize;
            SizeF desiredSize = SizeF.Empty;

            System.Windows.Forms.Padding borderThickness = this.GetBorderThickness(false);
            availableSize.Width -= borderThickness.Horizontal + this.Padding.Horizontal;
            availableSize.Height -= borderThickness.Vertical + this.Padding.Vertical;

            imageElement.Measure(availableSize);
            availableSize.Width -= imageElement.DesiredSize.Width;

            stackElement.Measure(availableSize);

            desiredSize.Width = imageElement.DesiredSize.Width + stackElement.DesiredSize.Width;
            desiredSize.Height = Math.Max(imageElement.DesiredSize.Height, stackElement.DesiredSize.Height);

            desiredSize.Width += borderThickness.Horizontal + this.Padding.Horizontal;
            desiredSize.Height += borderThickness.Vertical + this.Padding.Vertical;

            desiredSize.Width = Math.Min(desiredSize.Width, originalAvailableSize.Width);
            desiredSize.Height = Math.Min(desiredSize.Height, originalAvailableSize.Height);

            return desiredSize;
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            RectangleF clientRect = GetClientRectangle(finalSize);
            float x = clientRect.X;

            imageElement.Arrange(new RectangleF(x, clientRect.Y, imageElement.DesiredSize.Width, imageElement.DesiredSize.Height));
            x += imageElement.DesiredSize.Width;
            stackElement.Arrange(new RectangleF(x, clientRect.Y, stackElement.DesiredSize.Width, stackElement.DesiredSize.Height));

            return finalSize;
        }

        public override void Synchronize()
        {
            base.Synchronize();

            RssItem item = (RssItem)this.Data.DataBoundItem;
            this.imageElement.Image = item.GetImage();
            this.headerElement.Text = item.Title;
            
            DateTime pubdate;
            DateTime.TryParse(item.PubDate, out pubdate);
            if (pubdate != DateTime.MinValue)
            {
                this.pubDateElement.Text = pubdate.ToShortDateString();
            }
            else
            {
                this.pubDateElement.Text = String.Format("{0:g}", item.PubDate);
            }
            

            if (item.Description != null)
            {
                this.descriptionElement.Text = Regex.Replace(item.Description, "<[^>]*>", "");
                this.descriptionElement.Text = this.descriptionElement.Text.Replace("&#160;", "");
                this.descriptionElement.Text = this.descriptionElement.Text.Replace("&nbsp;", "");
            }
            else
            {
                supportedRssFeed = false;
            }

            //TODO
            //Regex reg = new Regex("<.*?[^>]+>", RegexOptions.Multiline);
            //string text = reg.Replace(HTMLText, "");
            //text = text.Replace("&nbsp;", "");
        }

        public override void Attach(RadListDataItem data, object context)
        {
            //occurs when attached to the data source
            base.Attach(data, context);

            RssItem item = (RssItem)this.Data.DataBoundItem;
            item.ImageDownloaded += new ImageDownloadedEventHandler(item_ImageDownloaded);
        }

        public override void Detach()
        {
            RssItem item = (RssItem)this.Data.DataBoundItem;
            item.ImageDownloaded -= new ImageDownloadedEventHandler(item_ImageDownloaded);
            base.Detach();
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(RadListVisualItem);
            }
        }

        #endregion

        #region Methods

        void item_ImageDownloaded(object sender, EventArgs e)
        {
            //when the image is downloaded, synchromize the content
            Synchronize();
            RssItem item = sender as RssItem;
            item.ImageDownloaded -= new ImageDownloadedEventHandler(item_ImageDownloaded);
        }

        #endregion

        #region Properties

        public bool SupportedRssFeed
        {
            get
            {
                return this.supportedRssFeed;
            }
        }

        public LightVisualElement HeaderElement
        {
            get
            {
                return this.headerElement;
            }
        }
        
        #endregion

    }
}
