using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls;
using System.Drawing;

namespace Telerik.Examples.WinControls.PageView
{
    class PageViewImages
    {
        public static Image[] Images;
        public static string[] Names;

        static PageViewImages()
        {
            Names = new string[] { 
                "Alarm Clock.png", "Calendar.png", "E-book Reader.png", 
                "Fire.png", "Home.png", "Light Bulb.png", 
                "Megaphone.png", "Television.png", "Webcam.png" };

            Type type = typeof(PageViewImages);
            string path = "Telerik.Examples.WinControls.PageView.Resources.";
            Images = new Image[9];

            for (int i = 0; i < 9; i++)
            {
                Images[i] = ResourceHelper.ImageFromResource(type, path + Names[i]);
            }
        }
    }
}
