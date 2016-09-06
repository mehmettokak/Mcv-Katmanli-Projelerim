using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace CompanyWeb.Tool
{
    public class Settings
    {
        public static string GetSetting(string key)
        {
            return WebConfigurationManager.AppSettings[key].ToString();
        }
    }
}
