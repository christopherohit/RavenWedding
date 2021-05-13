using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace DemoAppsHub.GridExample
{
    public class GridCustomRowElement : GridDataRowElement
    {
        static Font contentFont = new Font("Segoe UI", 9f, FontStyle.Regular);

        LightVisualElement detailsContent;

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridDataRowElement);
            }
        }

        public override void Attach(GridViewRowInfo row, object context)
        {
            base.Attach(row, context);

            string firstName = row.Cells["FirstName"].Value.ToString();
            string lastName = row.Cells["LastName"].Value.ToString();
            string title = row.Cells["Title"].Value.ToString();
            string country = row.Cells["Country"].Value.ToString();
            string description = row.Cells["Notes"].Value.ToString();

            detailsContent.Text = string.Format("<html><b>{0},{1}</b> - <i>{2},{3}</i><br><br>{4}", lastName, firstName, title, country, description);
			//detailsContent.ClipText = true;
			//detailsContent.ClipDrawing = true;

			//this.ClipDrawing = true;

            byte[] bytes = (byte[])row.Cells["Photo"].Value;
            detailsContent.Image = GetImageFromBytes(bytes);
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            detailsContent = new LightVisualElement();
            detailsContent.TextAlignment = ContentAlignment.MiddleLeft;
            detailsContent.TextImageRelation = TextImageRelation.ImageBeforeText;
            detailsContent.ImageAlignment = ContentAlignment.MiddleLeft;
            detailsContent.Padding = new Padding(10);
            detailsContent.ImageLayout = ImageLayout.Zoom;
            detailsContent.TextWrap = true;
            detailsContent.DisableHTMLRendering = false;
            detailsContent.Font = contentFont;
            this.Children.Add(detailsContent);
        }

        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            if (availableSize.Height > 60)
            {
                this.Children[1].Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                detailsContent.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            }
            else
            {
                this.Children[1].Visibility = Telerik.WinControls.ElementVisibility.Visible;
                detailsContent.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }
            SizeF desiredSize = base.MeasureOverride(availableSize);

            detailsContent.Measure(new SizeF(availableSize.Width - 100, availableSize.Height - 10));

            return desiredSize;
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            if (detailsContent.Visibility == Telerik.WinControls.ElementVisibility.Visible)
            {
                detailsContent.Arrange(new RectangleF(50, 5, 
                    Math.Min(detailsContent.DesiredSize.Width, finalSize.Width - 100),
                    Math.Min(detailsContent.DesiredSize.Height, finalSize.Height - 10)));
            }
            else
            {
                base.ArrangeOverride(finalSize);
            }

            return finalSize;
        }

        private const int OleHeaderSize = 78;

        private Image GetImageFromBytes(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
            {
                return null;
            }
            Image result = null;
            MemoryStream stream = null;
            try
            {
                int count;
                int start;

                if (IsOleContainer(bytes))
                {
                    count = bytes.Length - OleHeaderSize;
                    start = OleHeaderSize;
                }
                else
                {
                    count = bytes.Length;
                    start = 0;
                }
                stream = new MemoryStream(bytes, start, count);
                result = Image.FromStream(stream);
            }
            catch
            {
                result = null;
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
            return result;
        }

        private bool IsOleContainer(byte[] imageData)
        {
            return (imageData != null && imageData[0] == 0x15 && imageData[1] == 0x1C);
        }
    }
}
