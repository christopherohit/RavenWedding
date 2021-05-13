using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RssReader.RSS_Library
{
    [XmlType("enclosure")]
    public class RssItemImage
    {
        public RssItemImage()
        {

        }

        [XmlAttribute("url")]
        public string Url { get; set; }

    }
}
