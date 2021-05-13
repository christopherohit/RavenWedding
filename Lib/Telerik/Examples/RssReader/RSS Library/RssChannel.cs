using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RssReader.RSS_Library
{
    [XmlType("channel")]
    public class RssChannel
    {
        public RssChannel()
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

        [XmlElement("item")]
        public RssItem[] Items { get; set; }

        [XmlElement("image")]
        public RssChannelImage Image { get; set; }
    }
}
