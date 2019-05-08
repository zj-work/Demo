using Demo.Common;
using Demo.Drawing.Image;
using Demo.Drawing.Magick;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ImageOperate
{
    class Program
    {
        private static ImageHandler model = new ImageHandler();

        private static MagickHandler magicModel = new MagickHandler();

        static void Main(string[] args)
        {
            Thumbnail();
            //DrawPicture();
            Console.ReadKey();
        }

        /// <summary>
        /// 缩略图
        /// </summary>
        static void Thumbnail()
        {
            var bmp = Tool.ReadImageFromPath(@"E:\Images\02.png");
            bmp = magicModel.Thumbnail(bmp, 30, 30);
            Tool.SaveBitmap2File(bmp, @"E:\Images\02_Thumbnail.png", ImageFormat.Png);
        }

        /// <summary>
        /// 图片画框以及添加文字
        /// </summary>
        static void DrawPicture()
        {
            /**
             * 1.读取文件 并转变为Bitmap
             * 2.在图片上画框
             * 3.保存图片
             */
            Bitmap bitmap = Tool.ReadImageFromPath("E:\\Images\\01.jpg");

            bitmap = model.DrawRectangleInPicture(bitmap, new Point(10, 10), new Point(100, 500), Color.Black, 2);
            bitmap = model.DrawString(bitmap, "测试文字", new Point(50, 50), Color.Red, 5,new Font("宋体",32));

            Tool.SaveBitmap2File(bitmap, "E://01.Jpeg", ImageFormat.Jpeg);
        }
    }
}
