using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Camera;

namespace Raven.DTO
{
    public class cameraControl
    {
        string ParentPath = Path.GetFullPath("/Raven/Database/User_Data/");
        public static cameraControl instance 
        {
            get { if (instance == null) instance = new cameraControl(); return instance; }
            private set => instance = value;
        }
        private cameraControl() { }

        public void CreatePathForUsers(string username , string PathImage)
        {
            TakePictureDialog dialog = new TakePictureDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image i = dialog.Image;
                if (Directory.Exists(ParentPath + username))
                {
                    try
                    {

                    }
                    catch (Exception )
                    {

                    }
                }
            }
            
        }
    }
}
