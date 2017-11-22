using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class Utility
    {
        /// <summary>
        /// Convert từ Img sang mảng byte
        /// </summary>
        /// <param name="imageIn"></param>
        /// <returns></returns>
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        /// <summary>
        /// Convert từ mảng byte sang Img
        /// </summary>
        /// <param name="byteArrayIn"></param>
        /// <returns></returns>
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        /// <summary>
        /// Nếu nó rỗng trả về false có sẽ trả về true
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool CheckTextBoxEmpty(TextBox textBox)
        {
            if (textBox.Text == null || textBox.Text == "")
                return false;
            return true;
        }

        /// <summary>
        /// Nếu truyền vào 1 một radioButton Nam, sẽ trả về true nếu là Nam và false nếu là Nữ
        /// </summary>
        /// <param name="radioButton"></param>
        /// <returns></returns>
        public static Boolean ConvertSexToBoolean(RadioButton radioButton)
        {
            if (radioButton.Checked == true)
                return true;
            return false;
        }


    }
}
