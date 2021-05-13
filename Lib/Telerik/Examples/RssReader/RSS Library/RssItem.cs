using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Drawing;
using System.Threading;
using System.ComponentModel;



namespace RssReader.RSS_Library
{
    public delegate void ImageDownloadedEventHandler(object sender, EventArgs e);

    [XmlType("item")]
    public class RssItem
    {
        Image image;
        public event ImageDownloadedEventHandler ImageDownloaded;

        public RssItem()
        {
           
        }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("link")]
        public string Link { get; set; }

        [XmlElement("pubDate")]
        public string PubDate { get; set; }

        [XmlElement("enclosure")]
        public RssItemImage ImageUrl { get; set; }

        public Image GetImage()
        {
            EnsureImage();
            return image;
        }

        void DownloadImage(object state)
        {
            string url = this.ImageUrl.Url;
            Image tmpImage = null;

            try
            {
                // Open a connection
                System.Net.HttpWebRequest httpWebRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url);

                httpWebRequest.AllowWriteStreamBuffering = true;

                // You can also specify additional header values like the user agent or the referer: (Optional)
                httpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)";
                httpWebRequest.Referer = "http://www.google.com/";

                // set timeout for 20 seconds (Optional)
                httpWebRequest.Timeout = 20000;

                // Request response:
                System.Net.WebResponse webResponse = httpWebRequest.GetResponse();

                // Open data stream:
                System.IO.Stream webStream = webResponse.GetResponseStream();

                // convert webstream to image
                tmpImage = Image.FromStream(webStream);

                // Cleanup
                webResponse.Close();
                webStream.Close();
            }
            catch (Exception _Exception)
            {
                // Error
                Console.WriteLine("Exception caught in process: {0}", _Exception.ToString());
                this.image =  null;
            }

            if (tmpImage != null)
            {
                this.image = tmpImage.GetThumbnailImage(75, 75, delegate { return true; }, IntPtr.Zero);

                OnImageDownloaded(this, EventArgs.Empty);
            }
        }

        private void EnsureImage()
        {
            if (this.image == null && this.ImageUrl != null &&!string.IsNullOrEmpty(this.ImageUrl.Url))
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(DownloadImage));
            }
        }

        protected virtual void OnImageDownloaded (object obj, EventArgs e)
        {
            if (ImageDownloaded != null)
                ImageDownloaded(this, e);
        }

    }
}
