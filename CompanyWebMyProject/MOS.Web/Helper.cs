using System.Configuration;
using System.Web;
using CompanyWeb.BAL.Provider;
using CompanyWeb.Entity.Model;

namespace CompanyWeb.Web
{
    public static class Helper
    {
        private static int _langId;
        private static string _langCode;

        public static int LangId
        {
            get
            {
                var httpCookie = HttpContext.Current.Request.Cookies["lang"];

                if (_langId != 0 && _langCode == httpCookie.Value) return _langId;

                var langCode = httpCookie.Value;
                var db = new DbProvider<Language>();
                var lang = db.Get(x => x.Code == langCode);
                _langId = lang.ID;
                _langCode = lang.Code;

                return _langId;
            }
        }

        public static string GetSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static string ToSetFilePath(this string filePath)
        {
            var reFilePath = "";

            if (!string.IsNullOrEmpty(filePath))
            {
                var imageServerPath = GetSetting("ImageServerUrl");
                reFilePath = imageServerPath + filePath;
            }

            return reFilePath;
        }
    }
}