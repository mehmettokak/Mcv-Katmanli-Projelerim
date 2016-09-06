using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Classes;
using DAL;
using System.Data.Entity.Validation;
namespace BAL.Provider
{
    public class UserProvider
    {
        public USER_SQLEntities DBE = DBProvider.DbEntity();
        #region Method Overloading-Email veya id-Password ' a Göre Kullanıcı bilgileri Getir
        public USER getUser(string email)
        {
            var userDb = DBE.USER.FirstOrDefault(x => x.email == email);
            return userDb;
        }
        public USER getUser(int id, string password)
        {
            var userDb = DBE.USER.FirstOrDefault(x => x.id == id && x.password == password);
            return userDb;
        }
        #endregion

        #region AktivasyonKey ine göre kullanıcı getir
        public USER getUserWithActivationKey(string key)
        {//dısardan gelen aktivasyon koduna gore kullanıcı bilgileri cekilecek
            return DBE.USER.Where(x => x.activasyonkey == key).FirstOrDefault();
        }
        #endregion

        #region Id ye göre kullanıcı bilgileri getir
        public USER GetWithId(int id)
        {
            return DBE.USER.Where(x => x.id == id).FirstOrDefault();
        }
        #endregion

        #region Gelen USER Modelimi Kaydet
        public int setUser(USER user)
        {
            int counter = 0;
            var dbUser = DBE.USER.FirstOrDefault(x => x.id == user.id);
            if (dbUser != null)
            {
                dbUser.name = user.name;
                dbUser.surname = user.surname ?? "";
                dbUser.status = user.status;
                dbUser.password = user.password;
                dbUser.createdate = user.createdate;
                dbUser.activasyonkey = user.activasyonkey;
                dbUser.activasyondate = user.activasyondate;
                //Burada activation key ve date yi guncellememiz yeterliydi fakat bu metotu kullanıcı guncelleme de tekrar kullanıcagımız için hepsini yazdık.ki sifre yenilemede kullanmıs olduk tekrar
                try
                {
                    counter = DBE.SaveChanges();
                }
                catch (DbEntityValidationException err)
                {

                    throw err;
                }

            }
            return counter;
        }
        #endregion

    }
}