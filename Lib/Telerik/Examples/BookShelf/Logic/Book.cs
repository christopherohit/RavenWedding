using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;
using System.Drawing.Imaging;
using  FindingAPI_WebApp_Sample.com.ebay.developer;
using System.Threading;
using System.ComponentModel;

namespace BookShelf
{
    public class Book
    {
        #region Fields

        Category category;
        Bitmap image;
        Color color;
        bool isFavorite;
        bool isImageLoaded;
        string title;
        int bidCount;
        DateTime startTime;
        string galleryUrl;

        #endregion

        #region Initialization

        public Book()
        {
        }

        public Book(Category category, SearchItem item)
        {
            this.bidCount = item.sellingStatus.bidCount;
            this.startTime = item.listingInfo.startTime;
            this.title = item.title;
            this.category = category;
            this.galleryUrl = item.galleryURL;
            this.color = BookShelfApp.Instance.GetColor(category.Name);
            ThreadPool.QueueUserWorkItem(LoadDataWorkItem);
        }

        #endregion

        #region Properties

        [XmlIgnore]
        public Bitmap Image
        {
            get
            {
                return image;
            }
        }

        [XmlIgnore]
        public Category Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }      

        [XmlIgnore]
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        [XmlAttribute]
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public int BidCount
        {
            get
            {
                return bidCount;
            }
            set
            {
                bidCount = value;
            }
        }

        public DateTime StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
            }
        }

        public bool IsFavorite 
        {
            get 
            {
                return isFavorite; 
            }
            set 
            {
                isFavorite = value; 
            } 
        }

        public bool IsImageLoaded
        {
            get 
            {
                return isImageLoaded;
            }
            set
            {
                isImageLoaded = value;
            }
        }

        public byte[] SerializedImage
        {
            get
            {
                if (image == null || !isImageLoaded)
                {
                    return null;
                }
                lock (image)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, ImageFormat.Png);
                        return ms.ToArray();
                    }
                }
            }
            set
            { 
                if (value != null)
                {
                    using (MemoryStream ms = new MemoryStream(value))
                    {
                        image = new Bitmap(ms);
                    }
                }
            }
        }

        [XmlElement("SerializedColor")]
        public int SerializedColor
        {
            get
            { 
                return color.ToArgb();
            }
            set
            { 
                this.color = Color.FromArgb(value);
            }
        }

        #endregion

        #region Events

        [XmlIgnore]
        public EventHandler LoadComplete;

        protected virtual void OnLoadComplete()
        {
            EventHandler handler = LoadComplete;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }            
        }

        #endregion

        #region Methods

        public Bitmap LoadImageFromUrl(string url)
        {
            Bitmap bmp = null;
            
            try
            {
                HttpWebRequest request = (HttpWebRequest)System.Net.HttpWebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                bmp = System.Drawing.Image.FromStream(response.GetResponseStream()) as Bitmap;
                response.Close();
            }
            catch { }

            return bmp;
        }

        #endregion

        #region Event handlers

        private void LoadDataWorkItem(object state)
        {
            BookShelfApp.Instance.LoadingImages++;
            this.image = LoadImageFromUrl(galleryUrl);
            BookShelfApp.Instance.LoadingImages--;
            this.isImageLoaded = true;
            OnLoadComplete();
        }

        #endregion
    }
}
