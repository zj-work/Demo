using ImageMagick;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Drawing.Magick
{
    public class MagickHandler
    {
        #region 缩略图

        /// <summary>
        /// 缩略图
        /// </summary>
        /// <param name="bmp"></param>
        public Bitmap Thumbnail(Bitmap bmp, int width, int height)
        {
            Bitmap temp = null;
            using (MagickImage image = new MagickImage())
            {
                image.Read(bmp);
                image.Resize(width, height);
                temp = image.ToBitmap();
            }
            return temp;
        }
        /// <summary>
        /// 缩略图
        /// </summary>
        /// <param name="bmp"></param>
        public Bitmap Thumbnail(string filepath, int width, int height)
        {
            Bitmap temp = null;
            using (MagickImage image = new MagickImage(filepath))
            {
                image.Resize(width, height);
                temp = image.ToBitmap();
            }
            return temp;
        }


        #endregion

        #region 调整HSL值

        public Bitmap Modulate()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
