using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using System.Drawing;
using System.Drawing.Drawing2D;
using BookShelf.Properties;

namespace BookShelf.Custom_Elements
{
    public class BaseTileElement : RadTileElement
    {
        public static Bitmap fav_empty = Resources.fav_empty;
        public static Bitmap fav_full = Resources.fav_full;
        public static string SampleText = Resources.SampleText;

        Book book;

        public BaseTileElement(Book book)
        {
            this.book = book;
        }

        public Book Book
        {
            get
            {
                return this.book;
            }
        }

        public static Image ResizeImage(Image img, double percentage)
        {
            //get the height and width of the image
            int originalW = img.Width;
            int originalH = img.Height;

            //get the new size based on the percentage change
            int resizedW = (int)(originalW * percentage);
            int resizedH = (int)(originalH * percentage);

            Bitmap bmp = new Bitmap(resizedW, resizedH);
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphic.DrawImage(img, 0, 0, resizedW, resizedH);
            graphic.Dispose();

            return (Image)bmp;
        }

        protected virtual Image ResizeImage()
        {
            return book.Image;
        }

        protected virtual void SetImage()
        {            
            if (Book == null)
            {
                return;
            }
            lock (Book)
            {
                if (Book.IsImageLoaded)
                {
                    if (Book.Image != null)
                    {
                        lock (book.Image)
                        {
                            this.Image = ResizeImage();
                        }
                    }
                }
                else
                {
                    Book.LoadComplete += new EventHandler(Book_LoadComplete);
                }
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            BookShelfApp.Instance.CurrentBook = Book;
            BookShelfApp.Instance.CurrentPageID = PageID.Details;
        }

        private void Book_LoadComplete(object sender, EventArgs args)
        {
            Book.LoadComplete -= new EventHandler(Book_LoadComplete);
            SetImage();
        }
    }
}
