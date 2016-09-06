using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace Customer.BAL.Tools
{
    public class ImageProcess
    {
        public string Save(HttpPostedFileBase fileResim, string filePath)
        {
            string err = "";
            try
            {
                if (fileResim != null && fileResim.ContentLength > 0)
                {
                    filePath = HttpContext.Current.Server.MapPath("~" + filePath);
                    if (File.Exists(filePath)) File.Delete(filePath);
                    fileResim.SaveAs(filePath);
                }
            }
            catch (System.Exception ex)
            {
                err = ex.Message;
            }
            return err;
        }

        public static void SaveCropFile(byte[] content, string path, string photopath)
        {
            string filePath = GetCropFileFullPath(path);
            if (File.Exists(path)) File.Delete(path);

            //Save file
            using (FileStream str = File.Create(filePath))
            {
                str.Write(content, 0, content.Length);
            }
        }

        public static string GetCropFileFullPath(string path)
        {
            string relName = path.StartsWith("~") ? path : path.StartsWith("/") ? string.Concat("~", path) : path;

            string filePath = relName.StartsWith("~") ? HostingEnvironment.MapPath(relName) : relName;

            return filePath;
        }
    }
}