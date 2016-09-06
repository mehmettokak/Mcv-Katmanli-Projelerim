
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer.BAL.Providers.IndexProvider
{
    public class NewsLetterProvider
    {
         CUSTOMER_SQLEntities DBE = null;
        public NewsLetterProvider()
        {
            DBE = Helper.DataBase();
        }

       
        public NEWSLETTER getEmail(string email)
        {
            var model = DBE.NEWSLETTER.FirstOrDefault(x=>x.email==email);
            return model;     
        }
       
        #region Save and Delete Email

        public string NewsletterAdd(string email)
        {
            string err = "";
            var dbModel = new NEWSLETTER();
            try
            {
                dbModel.email = email;
                dbModel.datetime = DateTime.Now;
                DBE.NEWSLETTER.Add(dbModel);
                DBE.SaveChanges();
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            return err;
        }
        public string NewsletterRemove(string email)
        {
            string err = "";
            try
            {
                var Model = getEmail(email);
                DBE.NEWSLETTER.Remove(Model);
                DBE.SaveChanges();
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            return err;
        }
        #endregion
    }
}