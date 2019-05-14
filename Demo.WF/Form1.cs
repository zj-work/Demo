using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.WF
{
    public partial class Form1 : Form
    {
        private string remoteServer = ConfigurationManager.AppSettings["remoteServer"].ToString();
        private string remoteServerUser = ConfigurationManager.AppSettings["remoteServerUser"].ToString();
        private string remoteServerPwd = ConfigurationManager.AppSettings["remoteServerPwd"].ToString();
        private string remoteServerFilePath = ConfigurationManager.AppSettings["remoteServerFilePath"].ToString();

        public Form1()
        {
            InitializeComponent();

            btn_upload.Click += Btn_upload_Click;
            btn_uploadDir.Click += Btn_uploadDir_Click;
        }
        /// <summary>
        /// 选择文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_uploadDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                var directoryPath = fbd.SelectedPath;
                DirectoryInfo folder = new DirectoryInfo(directoryPath);
                List<string> fileNames = new List<string>();
                foreach(var file in folder.GetFiles())
                {
                    fileNames.Add(file.FullName);
                }
                var errorPaths = new List<string>();
                lb_History.Items.Add("开始校验文件...");
                if (FileValidate(fileNames.ToArray(),ref errorPaths))
                {
                    lb_History.Items.Add("文件校验成功，开始上传...");
                    uploadFiles(fileNames.ToArray());
                }
                else
                {
                    lb_History.Items.Add("文件校验失败,有问题的文件如下：");
                    foreach (var item in errorPaths)
                    {
                        lb_History.Items.Add(item);
                    }
                }
            }
        }

        /// <summary>
        /// 选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                var filePaths = ofd.FileNames;
                var errorPaths = new List<string>();
                lb_History.Items.Add("开始校验文件...");
                if (FileValidate(filePaths,ref errorPaths))
                {
                    lb_History.Items.Add("文件校验成功，开始上传...");
                    pb_upload.Value = 0;
                    uploadFiles(filePaths);
                }
                else
                {
                    lb_History.Items.Add("文件校验失败,有问题的文件如下：");
                    foreach(var item in errorPaths)
                    {
                        lb_History.Items.Add(item);
                    }
                }
            }
        }

        /// <summary>
        /// 文件校验
        /// </summary>
        /// <param name="filePaths"></param>
        private bool FileValidate(string[] filePaths,ref List<string> errorPaths)
        {
            //判断文件是否图片文件
            //图片文件，转换为Bitmap类型，校验其宽高以及其他属性
            //非图片文件，跳过
            var imageExtension = new string[] { "jpg", "jpeg", "png", "gif" };
            var errorNum = 0;
            foreach(var item in filePaths)
            {
                var extension = Path.GetExtension(item);
                if (imageExtension.Contains(extension))
                {
                    Bitmap bmp = new Bitmap(item);
                    if(bmp.Width < 300 && Height < 300)
                    {
                        errorNum++;
                        errorPaths.Add(item);
                    }
                }
            }
            if(errorNum * 0.1 / filePaths.Length > 0.2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="filePaths"></param>
        private async void uploadFiles(string[] filePaths)
        {
            pb_upload.Maximum = filePaths.Length;
            var tasks = new List<Task>();
            foreach(var item in filePaths)
            {
                tasks.Add(Task.Factory.StartNew((s) =>
                {
                    UploadFile(Convert.ToString(s));
                }, item, System.Threading.CancellationToken.None));
            }
            await Task.WhenAll(tasks);
            lb_History.Items.Add("上传结束");
            MessageBox.Show("上传完成");
        }

        /// <summary> 
        /// 将本地文件上传到指定的服务器(HttpWebRequest方法) 
        /// </summary> 
        /// <param name="address">文件上传到的服务器</param> 
        /// <param name="fileNamePath">要上传的本地文件（全路径）</param> 
        /// <param name="saveName">文件上传后的名称</param> 
        /// <param name="progressBar">上传进度条</param> 
        /// <returns>成功返回1，失败返回0</returns> 
        private bool UploadFile(string fileName)
        {
            try
            {
                System.Threading.Thread.Sleep(1000);
                WebClient wc = new WebClient();
                wc.UploadFile(remoteServer, fileName);
                this.Invoke(new Action<string>((str) =>
                {
                    lb_History.Items.Add(str + "_上传成功");
                    pb_upload.Value += 1;
                }), fileName);
                return true;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
