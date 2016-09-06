using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CompanyWeb.Tool.CropImage
{
    public class ImageProcess
    {
        public string SaveImage(byte[] file, string folderPath, string fileName)
        {
            MemoryStream ms = new MemoryStream(file, 0, file.Length);
            ms.Write(file, 0, file.Length);
            var img = Image.FromStream(ms, true);
            var serverFolderPath = System.Web.HttpContext.Current.Server.MapPath(folderPath);
            DirectoryInfo di = new DirectoryInfo(serverFolderPath);
            if (!di.Exists) di.Create();

            string filePath = serverFolderPath + "/" + fileName;

            FileInfo fi = new FileInfo(filePath);
            if (fi.Exists)
            {
                fileName = Guid.NewGuid() + "_" + fileName;
                filePath = serverFolderPath + "/" + fileName;
            }

            img.Save(filePath);

            return folderPath + "/" + fileName;
        }

        public string SaveImage(HttpPostedFileBase files, string folderPath)
        {
            try
            {
                if (!Directory.Exists(HttpContext.Current.Server.MapPath("~" + folderPath)))
                    Directory.CreateDirectory(HttpContext.Current.Server.MapPath("~" + folderPath));

                var filePath = folderPath + files.FileName;
                if (File.Exists(HttpContext.Current.Server.MapPath("~" + filePath)))
                    File.Delete(HttpContext.Current.Server.MapPath("~" + filePath));

                files.SaveAs(HttpContext.Current.Server.MapPath("~" + filePath));
                return filePath;
            }
            catch (Exception ex) 
            {
                throw;
            }
        }
    }
}
