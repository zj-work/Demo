using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Drawing.Image
{
    public class ImageHandler
    {
        /// <summary>
        /// 在图片上画框
        /// </summary>
        /// <param name="bmp">原始图</param>
        /// <param name="p0">起始点</param>
        /// <param name="p1">终止点</param>
        /// <param name="RectColor">矩形框颜色</param>
        /// <param name="LineWidth">矩形框边界</param>
        /// <returns></returns>
        public Bitmap DrawRectangleInPicture(Bitmap bmp, Point p0, Point p1, Color RectColor, int LineWidth)
        {
            if (bmp == null) return null;
            //创建画布
            Graphics g = Graphics.FromImage(bmp);
            //设置画刷
            Brush brush = new SolidBrush(RectColor);
            //设置线条
            Pen pen = new Pen(brush, LineWidth);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            //开画
            //g.DrawRectangle(pen, new Rectangle(400, 300, Math.Abs(p0.X - p1.X), Math.Abs(p0.Y - p1.Y)));
            g.DrawRectangle(pen, 497, 252, 300, 300);
            g.Dispose();

            return bmp;
        }

        /// <summary>
        /// 在图片上添加文字
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="content"></param>
        /// <param name="pStart"></param>
        /// <param name="color"></param>
        /// <param name="LineWidth"></param>
        /// <returns></returns>
        public Bitmap DrawString(Bitmap bmp, string content, Point pStart, Color RectColor, int LineWidth,Font font)
        {
            if (bmp == null) return null;


            Graphics g = Graphics.FromImage(bmp);

            Brush brush = new SolidBrush(RectColor);
            Pen pen = new Pen(brush, LineWidth);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            //Font font = new Font("宋体", 32);

            //g.DrawRectangle(pen, new Rectangle(p0.X, p0.Y, Math.Abs(p0.X - p1.X), Math.Abs(p0.Y - p1.Y)));
            g.DrawString(content, font, brush, pStart);
            g.Dispose();

            return bmp;
        }

        /// <summary>
        /// 调整色差
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public Bitmap AdjustImageBrightness(Bitmap src, int brightness)
        {
            int width = src.Width;
            int height = src.Height;
            Bitmap back = new Bitmap(width, height);
            Rectangle rect = new Rectangle(0, 0, width, height);
            //这种速度最快
            BitmapData bmpData = src.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);//24位rgb显示一个像素，即一个像素点3个字节，每个字节是BGR分量。Format32bppRgb是用4个字节表示一个像素
            unsafe
            {
                byte* ptr = (byte*)(bmpData.Scan0);
                for (int j = 0; j < height; j++)
                {
                    for (int i = 0; i < width; i++)
                    {
                        //ptr[2]为r值，ptr[1]为g值，ptr[0]为b值
                        int red = ptr[2] + brightness; if (red > 255) red = 255; if (red < 0) red = 0;
                        int green = ptr[1] + brightness; if (green > 255) green = 255; if (green < 0) green = 0;
                        int blue = ptr[0] + brightness; if (blue > 255) blue = 255; if (blue < 0) blue = 0;
                        back.SetPixel(i, j, Color.FromArgb(red, green, blue));
                        ptr += 3; //Format24bppRgb格式每个像素占3字节
                    }
                    ptr += bmpData.Stride - bmpData.Width * 3;//每行读取到最后“有用”数据时，跳过未使用空间XX
                }
            }
            src.UnlockBits(bmpData);
            return back;
        }
    }
}
