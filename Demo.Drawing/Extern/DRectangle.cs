using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Drawing.Extern
{
    public class DRectangle
    {
        /// <summary>
        /// 设置矩形的相关参数
        /// </summary>
        /// <param name="_pStart">开始坐标</param>
        /// <param name="_pEnd">结束坐标</param>
        public static Rectangle GenerateRectangle(Point _pStart,Point _pEnd)
        {
            var rect = new Rectangle();

            #region 确定矩形的起始位置（左上角）

            if (_pStart.X > _pEnd.X && _pStart.Y < _pEnd.Y)
            {//由右到左 向下
                rect.Location = new Point(_pEnd.X, _pStart.Y);
            }
            else if (_pStart.X < _pEnd.X && _pStart.Y > _pEnd.Y)
            {//由左到右 向上
                rect.Location = new Point(_pStart.X, _pEnd.Y);
            }
            else if (_pStart.X > _pEnd.X && _pStart.Y > _pEnd.Y)
            {//由右到左 向上
                rect.Location = _pEnd;
            }
            else
            {//由左到右 向下
                rect.Location = _pStart;
            }

            #endregion

            //设置矩形的宽高
            rect.Width = Math.Abs(_pStart.X - _pEnd.X);
            rect.Height = Math.Abs(_pStart.Y - _pEnd.Y);

            return rect;
        }

    }
}
