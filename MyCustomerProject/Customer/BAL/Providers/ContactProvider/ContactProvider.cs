using Customer.Models;
using Customer.Models.Classes;
using Customer.Models.Classes.Contact;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Customer.BAL.Providers.ContactProvider
{
    public class ContactProvider
    {
         CUSTOMER_SQLEntities DBE = null;
          #region Constructor Method
         public ContactProvider()
        {
            DBE = Helper.DataBase();
        }
          #endregion
        #region Get Contact Model For Status
        public CONTACT GetContactModelForStatus()
        {
            var dbModel = DBE.CONTACT.FirstOrDefault();
            return dbModel;
        }
        #endregion

        #region Get Contact Slider Model
        public SliderModel GetContactSliderModel()
        {
            var model = new SliderModel();
            var DbModel = GetContactModelForStatus();
            model.filePath = DbModel.mapImage;
            model.imageDescription = DbModel.mapTitle;
            return model;
        }
        #endregion
        #region Get Contact Footer Model
        public ContactModel GetContactFooterModel()
        {
            var model = new ContactModel();
            var DbModel = DBE.CONTACT.FirstOrDefault();
            model.MailAdress= DbModel.mailadress;
            model.Adress = DbModel.adress;
            model.Telephone1 = DbModel.telephone1;
           return model;
        }
        #endregion
    }
}