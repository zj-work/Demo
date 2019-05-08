using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Common
{
    public class Tool
    {
        /// <summary>
        /// 根据图片路径读取图片
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static Bitmap ReadImageFromPath(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open);
            byte[] imageBuffer = new byte[fs.Length];
            fs.Read(imageBuffer, 0, imageBuffer.Length);
            fs.Close();
            MemoryStream ms = new MemoryStream(imageBuffer);
            Bitmap bitmap = new Bitmap(ms);
            ms.Close();
            fs.Dispose();
            ms.Dispose();
            return bitmap;
        }

        /// <summary>
        /// 将图片保存到指定位置
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="filePath"></param>
        public static void SaveBitmap2File(Bitmap bmp, string filePath, ImageFormat format)
        {
            bmp.Save(filePath, format);
        }
    }
}
