using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.Drawing;
using Demo.Drawing.Image;

namespace Demo
{
    public partial class MainForm : Form
    {
        private Bitmap bmp = null;
        private ImageHandler model = new ImageHandler();

        public MainForm()
        {
            InitializeComponent();

            btn_FileOpen.Click += Btn_FileOpen_Click;
            tb_Color.Maximum = 255;
            tb_Color.Minimum = -255;
            tb_Color.ValueChanged += Tb_Color_ValueChanged;

            tb_saturation.Maximum = 100;
            tb_saturation.Minimum = -100;
            tb_saturation.ValueChanged += Tb_saturation_ValueChanged;
        }
        /// <summary>
        /// 调整饱和度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_saturation_ValueChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 调节图片亮度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_Color_ValueChanged(object sender, EventArgs e)
        {
            var currentValue = tb_Color.Value;
            if(bmp == null)
            {
                MessageBox.Show("请选择图片");
                return;
            }
            var bmp_temp = model.AdjustImageBrightness(bmp, currentValue);
            picShow.Image = bmp_temp;
        }

        /// <summary>
        /// 选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_FileOpen_Click(object sender, EventArgs e)
        {
            /**
             * 选择文件，并将文件路径保存到静态字段中
             * */
            OpenFileDialog fd = new OpenFileDialog();
            if(fd.ShowDialog() == DialogResult.OK)
            {
                //显示图片到PictureBox中
                FileStream fs = new FileStream(fd.FileName, FileMode.Open, FileAccess.ReadWrite);
                bmp = new Bitmap(fs);
                fs.Close();
                fs.Dispose();
                picShow.Image = bmp;
            }
        }
    }
}
