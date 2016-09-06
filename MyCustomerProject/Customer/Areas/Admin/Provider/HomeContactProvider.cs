using Customer.Models.Classes.Contact;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer.Areas.Admin.Provider
{
    public class HomeContactProvider
    {
        CUSTOMER_SQLEntities DBE = null;
          #region Constructor Method
        public HomeContactProvider()
        {
            DBE = Helper.DataBase();
        }
          #endregion

        public CONTACT getModelForId(int? id)
        {
            var dbModel = DBE.CONTACT.FirstOrDefault(x => x.id == id);
            return dbModel;
        }
        public List<ContactModel> getListContactModel()
        {
            var dbModel = DBE.CONTACT.ToList();
            var listModel = new List<ContactModel>();
            listModel.AddRange(dbModel.Select(s => new ContactModel()
            {
                Id = s.id,
                MapImage=s.mapImage,
                MapTitle=s.mapTitle,
                Adress = s.adress,
                MailAdress = s.mailadress,
                Telephone1 = s.telephone1,
                Telephone2 = s.telephone2,
                Telephone3 = s.telephone2,
                Status = (bool)s.status

            }));
            return listModel;
        }
        public ContactModel getContactModel(int? id)
        {
            var dbmodel = getModelForId(id);
           
            var myModel = new ContactModel()
            {
                Id = dbmodel.id,
                MapImage = dbmodel.mapImage,
                MapTitle = dbmodel.mapTitle,
                MailAdress = dbmodel.mailadress,
                Adress=dbmodel.adress,
                Telephone1=dbmodel.telephone1,
                Telephone2=dbmodel.telephone2,
                Telephone3=dbmodel.telephone3,
                LogoImage=dbmodel.logoImage,
               Status = (bool)dbmodel.status
            };
            return myModel;
        }
        public string setContactModel(ContactModel model)
        {

            string err = "Başarılı.";
            try
            {
                if (model.Id == 0)//Ekle
                {
                    var myModel = new CONTACT()
                    {
                        id = model.Id,
                        mapTitle = model.MapTitle,
                        mapImage = model.MapImage,
                        adress = model.Adress,
                        mailadress = model.MailAdress,
                        telephone1 = model.Telephone1,
                        telephone2=model.Telephone2,
                        telephone3=model.Telephone3,
                        logoImage=model.LogoImage,
                        status = model.Status
                    };
                    DBE.CONTACT.Add(myModel);
                }
                else //Güncelle
                {
                    var dbmodel = getModelForId(model.Id);
                    dbmodel.id = model.Id;
                    dbmodel.mapTitle = model.MapTitle;
                    dbmodel.mapImage = model.MapImage;
                    dbmodel.logoImage = model.LogoImage;
                    dbmodel.adress = model.Adress;
                    dbmodel.mailadress = model.MailAdress;
                    dbmodel.telephone1 = model.Telephone1;
                    dbmodel.telephone2 = model.Telephone2;
                    dbmodel.telephone3 = model.Telephone3;
                    dbmodel.status = model.Status;

                }
                DBE.SaveChanges();
            }
            catch (System.Exception ex)
            {
                err = ex.Message;
            }
            return err;
        }
        public string removeContactModel(int id)
        {
            string err = "Başarılı.";
            var model = getModelForId(id);

            try
            {
                DBE.CONTACT.Remove(model);
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