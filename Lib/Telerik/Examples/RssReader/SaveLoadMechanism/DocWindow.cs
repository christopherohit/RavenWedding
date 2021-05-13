using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI.Docking;
using System.Xml.Serialization;

namespace RssReader.SaveLoadMechanism
{
    public class DocWindow
    {
        public DocWindow()
        {

        }

        public Feed[] Feeds { get; set; }

        public string Text { get; set; }
    }
}
