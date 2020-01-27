using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO; 

namespace MarathonSkills.Classes
{
    public class Images
    {
        public byte[] ConvertImageToByte(string path)
        {
            Bitmap image = new Bitmap(path);
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms , image.RawFormat);
                return ms.ToArray(); 
            }
        }

    }
}
