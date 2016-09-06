using Customer.Models.Classes;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Customer.Areas.Admin.Provider
{
    public class HomeSliderProvider
    {
         CUSTOMER_SQLEntities DBE = null;
         public HomeSliderProvider()
        {
            DBE = Helper.DataBase();
        }
        public SLIDER getModelForId(int id)
        {
            return DBE.SLIDER.FirstOrDefault(x => x.id == id);
        }
        public object getIcon()
        {
            var icon = new SelectList(DBE.ICONS, "id", "iconname");
            return icon;
        }
        public SliderModel GetSliderModel()
        {
            var DbModel = DBE.SLIDER.FirstOrDefault();
            if (true)
            {
                
            }
            var model = new SliderModel() { 
            id=DbModel.id,
            imageDescription=DbModel.imageDescription,
            filePath=DbModel.imageUrl
            };
          
            return model;

        }
        public List<SliderModel> GetSliderListModel()
        {
            var DbModel = DBE.SLIDER.ToList();
            var listModel = new List<SliderModel>();
            listModel.AddRange(DbModel.Select(s => new SliderModel()
            {
                id = s.id,
                filePath = s.imageUrl,
                imageDescription = s.imageDescription,
                imageStatus = (bool)s.imageStatus

            }));


            return listModel;

        }
        public string SetSliderProvider(SliderModel model)
        {
            var dbModel = new SLIDER();
            string err = "Başarılı.";
            try
            {
               
                if (model.id == 0)
                {
                    dbModel.imageDescription = model.imageDescription;
                    dbModel.imageUrl = model.filePath;
                    dbModel.imageStatus = model.imageStatus;
                    DBE.SLIDER.Add(dbModel);
                }
                else
                {
                    dbModel = getModelForId(model.id);
                    dbModel.imageDescription = model.imageDescription;
                     dbModel.imageUrl = model.filePath; 
                   dbModel.imageStatus = model.imageStatus;
                }

                DBE.SaveChanges();
            }
            catch (System.Exception ex)
            {
                err = ex.Message;
            }
            return err;
        }
        public string removeSliderModel(int id)
        {
            string err = "Başarılı.";
            var model = getModelForId(id);

            try
            {
                DBE.SLIDER.Remove(model);
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