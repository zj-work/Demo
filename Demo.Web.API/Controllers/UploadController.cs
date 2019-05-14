using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Demo.Web.API.Controllers
{
    public class UploadController : ApiController
    {
        public void UploadFile()
        {
            var files = HttpContext.Current.Request.Files;
            var floder = @"D:\Upload\";
            foreach (var item in files.AllKeys)
            {
                HttpPostedFile file = files[item];
                if (!System.IO.Directory.Exists(floder))
                {
                    System.IO.Directory.CreateDirectory(floder);
                }
                file.SaveAs(floder + file.FileName);
            }

        }
    }
}
