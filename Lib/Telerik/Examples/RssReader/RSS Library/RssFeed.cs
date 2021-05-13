using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Net;
using System.IO;
using Telerik.WinControls;
using System.Threading;

namespace RssReader.RSS_Library
{
    [XmlRoot("rss")]
    public class RssFeed
    {
        [XmlElement("channel")]
        public RssChannel Channel { get; set; }

        public RssFeed()
        {

        }

        public static RssFeed Load(string url)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(RssFeed));
                using (XmlTextReader textReader = new XmlTextReader(url))
                {
                    RssFeed feed = serializer.Deserialize(textReader) as RssFeed;
                    return feed;
                }
            }
            catch (Exception ex)
            {
                RssFeed feed = LoadAtomFeed(url);
                if (feed == null)
                {
                    RadMessageBox.Show("Unsupported RSS feed version " + ex.Message);
                }
                return feed;
            }
        }

        private static RssFeed LoadAtomFeed(string url)
        {
            try
            {
                string urlAddress = url;
                string data = "";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;
                    if (string.IsNullOrEmpty(response.CharacterSet))
                        readStream = new StreamReader(receiveStream);
                    else
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    data = readStream.ReadToEnd();

                    response.Close();
                    readStream.Close();
                }

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(data);

                XmlElement root = xml.DocumentElement;
                if (root.Name.ToLower() != "feed" || !root.NamespaceURI.Contains("www.w3.org/2005/Atom"))
                {
                    return null;
                }

                XmlNodeList entries = root.GetElementsByTagName("entry");
                RssFeed atomFeed = new RssFeed();
                RssChannel channel = new RssChannel();
                channel.Title = root["title"].InnerText;

                atomFeed.Channel = channel;
                List<RssItem> rssItems = new List<RssItem>();

                foreach (XmlElement entry in entries)
                {
                    RssItem rssItem = new RssItem();
                    string description = "";
                    string title = entry["title"].InnerText;
                    string pubDate = entry["published"].InnerText;
                    string link = entry["link"].Attributes["href"].Value;

                    if (entry["media:group"] != null)
                    {
                        if (entry["media:group"]["media:description"] != null)
                        {
                            description = entry["media:group"]["media:description"].InnerText;
                        }
                        if(entry["media:group"]["media:thumbnail"] != null &&
                            entry["media:group"]["media:thumbnail"].Attributes["url"] != null)
                        {
                            RssItemImage imageUrl = new RssItemImage();
                            imageUrl.Url = entry["media:group"]["media:thumbnail"].Attributes["url"].Value;
                            rssItem.ImageUrl = imageUrl;
                            int width = 50;
                            if (entry["media:group"]["media:thumbnail"].Attributes["width"] != null)
                            {
                                width = int.Parse(entry["media:group"]["media:thumbnail"].Attributes["width"].Value);
                            }
                            int height = 50;
                            if (entry["media:group"]["media:thumbnail"].Attributes["height"] != null)
                            {
                                height = int.Parse(entry["media:group"]["media:thumbnail"].Attributes["height"].Value);
                            }

                            description += "<br>" +
                                            "<a href=\"" + link + "\">" +
                                                "<img src=\"" + imageUrl.Url + "\" width=\"" + width + "\" height=\"" + height + "\" border=\"0\" >" +
                                            "</a>";
                        }
                    }

                    if (string.IsNullOrEmpty(description) && entry["content"] != null)
                    {
                        description = entry["content"].InnerText;
                    }

                    if (string.IsNullOrEmpty(description) && entry["summary"] != null)
                    {
                        description = entry["summary"].InnerText;
                    }

                    rssItem.Description = description;
                    rssItem.Title = title;
                    rssItem.PubDate = pubDate;
                    rssItem.Link = link;
                    rssItems.Add(rssItem);
                }

                channel.Items = rssItems.ToArray();
                return atomFeed;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
