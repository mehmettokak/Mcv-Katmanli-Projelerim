using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
namespace BAL.Tools
{
   public class Settings
    {
       public static string GetSetting(string key)
       {
           return WebConfigurationManager.AppSettings[key].ToString();//Webconfigte tanımlı olan bılgıler burdan cagırılır.
       }
    }
}
