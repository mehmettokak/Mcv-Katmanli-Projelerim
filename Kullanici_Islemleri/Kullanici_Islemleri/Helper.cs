using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using DAL.Classes;


namespace Kullanici_Islemleri
{
    public class Helper
    {
        //entity modelimizi surekli çagıracagımız ıcın metotumuzu statıc yaptık.ki kısa yoldan ulasalım.
        public static USER_SQLEntities DBEntity()
        {
            var DBE=DBProvider.DbEntity();
            return DBE;
        }
    }
}