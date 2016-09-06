using CompanyWeb.BAL.Provider;
using CompanyWeb.Entity.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CompanyWeb.Admin
{
    public static class Helper
    {
        public static int ToInt(this object item)
        {
            int result = 0;
            try { result = Convert.ToInt32(item); } catch { }
            return result;
        }

        public static User ToUser(this System.Security.Principal.IPrincipal user)
        {
            User rUser = HttpContext.Current.Session["User"] as User;
            if (rUser == null && user == null) return null;
            else if (rUser != null && user != null && rUser.Email == user.Identity.Name) return rUser;
            else if (user.Identity.Name != null)
            {
                var up = new DbProvider<User>();
                rUser = up.Get(x => x.Email == user.Identity.Name);
                HttpContext.Current.Session["User"] = rUser;
            }
            return rUser;
        }

        public static string GetSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

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
    }
}