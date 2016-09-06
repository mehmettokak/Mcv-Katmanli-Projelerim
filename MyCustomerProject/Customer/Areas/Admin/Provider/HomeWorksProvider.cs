using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using Customer.Models.Classes;
using Customer.Areas.Admin.Models;

namespace Customer.Areas.Admin.Provider
{
    public class HomeWorksProvider
    {
        CUSTOMER_SQLEntities DBE = null;
        public HomeWorksProvider()
        {
            DBE = Helper.DataBase();
        }
        public WORK getModelForId(int? id)
        {
            var dbModel = DBE.WORK.FirstOrDefault(x => x.id == id);
            return dbModel;
        }


        public List<WorksModel> getListWorkModel()
        {
            var model = new List<WorksModel>();
            var dbModel = DBE.WORK.ToList();
            model.AddRange(dbModel.Select(s => new WorksModel()
            {
                Id = s.id,
                ImageUrl = s.imageUrl,
                Title = s.title,
                Description = s.description,
                Status = (bool)s.status,
                Order = s.order
            }));
            return model;
        }

        public WorksModel getWorksModel(int? id)
        {
            var dbmodel = getModelForId(id);
            var model = new AdminHomeViewModel();
            model.adminWorkModel = new WorksModel()
            {
                Id = dbmodel.id,
                Title = dbmodel.title,
                Description = dbmodel.description,
                ContentUrl = dbmodel.contentUrl,
                ImageUrl = dbmodel.imageUrl,
                Order = dbmodel.order,
                Status = (bool)dbmodel.status
            };
            return model.adminWorkModel;
        }
        public string setWorkModel(WorksModel model)
        {

            string err = "Başarılı.";
            try
            {
                if (model.Id == 0)//Ekle
                {
                    var myModel = new WORK()
                    {
                        id = model.Id,
                        title = model.Title,
                        description = model.Description,
                        imageUrl = model.ImageUrl,
                        order = model.Order,
                        contentUrl = model.ContentUrl,
                        status = model.Status
                    };
                    DBE.WORK.Add(myModel);
                }
                else //Güncelle
                {
                    var dbmodel = getModelForId(model.Id);
                    dbmodel.id = model.Id;
                    dbmodel.title = model.Title;
                    dbmodel.description = model.Description;
                    dbmodel.imageUrl = model.ImageUrl;
                    dbmodel.order = model.Order;
                    dbmodel.contentUrl = model.ContentUrl;
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
        public string removeWorkModel(int id)
        {
            string err = "Başarılı.";
            var model= getModelForId(id);
            
            try
            {
                DBE.WORK.Remove(model);
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