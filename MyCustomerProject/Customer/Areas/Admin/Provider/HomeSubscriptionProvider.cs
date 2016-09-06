using Customer.Models.Classes;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer.Areas.Admin.Provider
{
    public class HomeSubscriptionProvider
    {
           CUSTOMER_SQLEntities DBE = null;
           public HomeSubscriptionProvider()
        {
            DBE = Helper.DataBase();
        }
        public NEWSLETTER getModelForId(int? id)
        {
            var dbModel = DBE.NEWSLETTER.FirstOrDefault(x => x.id == id);
            return dbModel;
        }
        public List<NewsLetterModel> getListSubscriptionModel()
        {
            var dbModel = DBE.NEWSLETTER.ToList();
            var listModel = new List<NewsLetterModel>();
            listModel.AddRange(dbModel.Select(s => new NewsLetterModel()
            {
                Id = s.id,
               Email=s.email,
               CreateTime=DateTime.Now
            }));
            return listModel;
        }
        public string RemoveSubscriptionsModel(int id)
        {
            string err = "Başarılı.";
            var model = getModelForId(id);

            try
            {
                DBE.NEWSLETTER.Remove(model);
                DBE.SaveChanges();
            }
            catch (System.Exception ex)
            {
                err = ex.Message;
            }
            return err;

        }
    }
}