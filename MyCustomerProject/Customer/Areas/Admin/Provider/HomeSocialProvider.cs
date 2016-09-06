using Customer.Models.Classes.Footer;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer.Areas.Admin.Provider
{
    public class HomeSocialProvider
    {
          CUSTOMER_SQLEntities DBE = null;
         #region Constructor Method
          public HomeSocialProvider()
        {
            DBE = Helper.DataBase();
            
        }
          #endregion
        #region GetModelForId
        public SOCIALS getModelForId(int? id)
        {
            var dbModel = DBE.SOCIALS.FirstOrDefault(x => x.id == id);
            return dbModel;
        }
        #endregion
       
     

        public List<SocialModel> getListSocialModel()
        {
            var dbModel = DBE.SOCIALS.ToList().OrderBy(x => x.order);
            var listModel = new List<SocialModel>();
            listModel.AddRange(dbModel.Select(s => new SocialModel()
            {
                Id = s.id,
                SocialUrl = s.socialUrl,
                SocialName = s.socialName,
                Order = s.order,
                Status = (bool)s.status

            }));
            return listModel;
        }
        public SocialModel getSocialModel(int? id)
        {
            var dbmodel = getModelForId(id);
            var myModel = new SocialModel()
            {
                Id = dbmodel.id,
                SocialName = dbmodel.socialName,
                SocialUrl = dbmodel.socialUrl,
                Order = dbmodel.order,
                Status = (bool)dbmodel.status
            };
            return myModel;
        }
        public string setSocialModel(SocialModel model)
        {

            string err = "Başarılı.";
            try
            {
                if (model.Id == 0)//Ekle
                {
                    var myModel = new SOCIALS()
                    {
                        id = model.Id,
                        socialName = model.SocialName,
                        socialUrl = model.SocialUrl,
                        order = model.Order,
                        status = (bool)model.Status
                    };
                    DBE.SOCIALS.Add(myModel);
                }
                else //Güncelle
                {
                    var dbmodel = getModelForId(model.Id);
                    dbmodel.id = model.Id;
                    dbmodel.socialName = model.SocialName;
                    dbmodel.socialUrl = model.SocialUrl;
                    dbmodel.order = model.Order;
                    dbmodel.status = model.Status;
                }
                DBE.SaveChanges();//Gunceller ve kaydeder
            }
            catch (System.Exception ex)
            {
                err = ex.Message;
            }
            return err;
        }
        public string removeSocialModel(int id)
        {
            string err = "Başarılı.";
            var model = getModelForId(id);

            try
            {
                DBE.SOCIALS.Remove(model);
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