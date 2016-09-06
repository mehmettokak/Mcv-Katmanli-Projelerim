using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Customer.BAL.Tools
{
    public class VideoProcess
    {
        public string Save(HttpPostedFileBase fileVideo, string filePath)
        {
            string err = "";
            try
            {
                if (fileVideo != null && fileVideo.ContentLength > 0)
                {
                    FileStream fs = new FileStream(HttpContext.Current.Server.MapPath("~" + filePath), FileMode.Create);
                    if (File.Exists(filePath)) File.Delete(filePath);
                    byte[] bufferdizi = new byte[fileVideo.ContentLength];
                    fileVideo.InputStream.Read(bufferdizi, 0, fileVideo.ContentLength);
                    fs.Write(bufferdizi, 0, fileVideo.ContentLength);
                    fs.Close();


                }
            }
            catch (System.Exception ex)
            {
                err = ex.Message;
            }
            return err;
        }


    }
}