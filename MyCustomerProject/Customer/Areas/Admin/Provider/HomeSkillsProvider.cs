using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using Customer.Models.Classes;
using Customer.Areas.Admin.Models;

namespace Customer.Areas.Admin.Provider
{
    public class HomeSkillsProvider
    {
        CUSTOMER_SQLEntities DBE = null;
        public HomeSkillsProvider()
        {
            DBE = Helper.DataBase();
        }
        public SKILL getModelForId(int? id)
        {
            var dbModel = DBE.SKILL.FirstOrDefault(x => x.id == id);
            return dbModel;
        }
        public List<SkillsModel> getListSkillsModel()
        {
            var dbModel = DBE.SKILL.ToList().OrderBy(x => x.order);
            var listModel = new List<SkillsModel>();
            listModel.AddRange(dbModel.Select(s => new SkillsModel()
            {
                Id = s.id,
                Title = s.title,
                Description = s.description,
                IconName = s.iconName,
                Order = s.order,
                Status = (bool)s.status

            }));
            return listModel;
        }
        public SkillsModel getSkillsModel(int? id)
        {
            var dbmodel = getModelForId(id);
            var myModel = new SkillsModel()
            {
                Id = dbmodel.id,
                Title = dbmodel.title,
                Description = dbmodel.description,
                IconName = dbmodel.iconName,
                Order = dbmodel.order,
                Status = (bool)dbmodel.status
            };
            return myModel;
        }
        public string setSkillsModel(SkillsModel model)
        {

            string err = "Başarılı.";
            try
            {
                if (model.Id == 0)//Ekle
                {
                    var myModel = new SKILL()
                    {
                        id = model.Id,
                        title = model.Title,
                        description = model.Description,
                        iconName = model.IconName,
                        order = model.Order,
                        status = (bool)model.Status
                    };
                    DBE.SKILL.Add(myModel);
                }
                else //Güncelle
                {
                    var dbmodel = getModelForId(model.Id);
                    dbmodel.id = model.Id;
                    dbmodel.title = model.Title;
                    dbmodel.description = model.Description;
                    dbmodel.iconName = model.IconName;
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
        public string removeSkillsModel(int id)
        {
            string err = "Başarılı.";
            var model = getModelForId(id);

            try
            {
                DBE.SKILL.Remove(model);
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