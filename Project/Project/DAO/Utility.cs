using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.DAO
{
    class Utility
    {
        private static Utility instance;

        public static Utility Instance
        {
            get { if (instance == null) instance = new Utility(); return instance; }
            private set { instance = value; }
        }

        private Utility() { }

        //
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        //
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
        }
    }
}
