using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string filePath = @"D:\dataset\SI\13\N0701482.jpg";
            var res = GetMd5Code(filePath);
        }

        protected string GetMd5Code(string path)
        {
            try
            {
                FileStream file = new FileStream(path, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retval = md5.ComputeHash(file);
                file.Close();
                file.Dispose();

                StringBuilder sc = new StringBuilder();
                for (int i = 0; i < retval.Length; i++)
                {
                    sc.Append(retval[i].ToString("x2"));
                }
                return sc.ToString();
            }
            catch (Exception ex)
            {
                return "";
                //return ex.Message;
            }
        }

        public int count = 0;

        [TestMethod]
        public void Test()
        {
            System.Diagnostics.Debug.WriteLine("总数："+count);
            System.Diagnostics.Debug.WriteLine("开始执行...");
            List<Task> tasks = new List<Task>();
            for(int i = 0; i < 5000; i++)
            {
                Action<object> action = new Action<object>(Out);
                tasks.Add(Task.Factory.StartNew(action, i, CancellationToken.None));
            }
            Task.WaitAll(tasks.ToArray());
            System.Diagnostics.Debug.WriteLine("总数："+count);
            System.Diagnostics.Debug.WriteLine("结束执行...");
        }

        private void Out(object n)
        {
            Thread.Sleep(1000);
            System.Diagnostics.Debug.Write(n+"  ");
            count += 1;
        }
    }
}
