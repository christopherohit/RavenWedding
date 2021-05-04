using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.DTO
{
    public class ClassImage
    {
        string PlaceSave = Path.GetFullPath(@"D:\");
        public string SaveImage(string name)
        {
            int i = 1;
            try
            {
                Directory.CreateDirectory(PlaceSave + @"Lesson\RIT\C #\Winform\Raven\Database\User_Data\" + name);
                if (Directory.Exists(PlaceSave + @"Lesson\RIT\C #\Winform\Raven\Database\User_Data\" + name))
                {
                sudunglai:
                    i++;
                    Directory.CreateDirectory(PlaceSave + @"Lesson\RIT\C #\Winform\Raven\Database\User_Data\" + name + i);
                    if (Directory.Exists(PlaceSave + @"Lesson\RIT\C #\Winform\Raven\Database\User_Data\" + name + i))
                    {
                        goto sudunglai;
                    }
                    else
                    {
                        string SetFull = PlaceSave + @"Lesson\RIT\C #\Winform\Raven\Database\User_Data\" + name + i;
                        return SetFull;
                    }
                }
            }
            catch(Exception er)
            {

            }
        }
    }
}
