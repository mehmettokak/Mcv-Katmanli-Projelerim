using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using Customer.Models.Classes;
using Customer.Areas.Admin.Models;

namespace Customer.Areas.Admin.Provider
{
    public class HomeEmployeesProvider
    {
        CUSTOMER_SQLEntities DBE = null;
        public HomeEmployeesProvider()
        {
            DBE = Helper.DataBase();
        }
        public EMPLOYEES getModelForId(int? id)
        {
            var dbModel = DBE.EMPLOYEES.FirstOrDefault(x => x.id == id);
            return dbModel;
        }
        public List<EmployeesModel> getListEmployesModel()
        {
            var dbModel = DBE.EMPLOYEES.ToList().OrderBy(x=>x.order);
            var listModel=new List<EmployeesModel>();
            listModel.AddRange(dbModel.Select(s => new EmployeesModel() { 
            Id=s.id,
            Image = s.image,
            Name=s.name,
            SurName=s.surname,
            Title=s.title,
           Description=s.description,
           Telephone=s.telephone,
           Email=s.email,
           Facebook=s.facebook,
           Twitter=s.twitter,
           Order=s.order,
           Status=(bool)s.status
                     }));
            return listModel;
        }

        public EmployeesModel getEmployeesModel(int? id)
        {
            var dbmodel = getModelForId(id);
            var model = new AdminHomeViewModel();
            model.adminEmployeesModel = new EmployeesModel()
            {
                Id = dbmodel.id,
                Image = dbmodel.image,
                Name = dbmodel.name,
                SurName = dbmodel.surname,
                Title = dbmodel.title,
                Description = dbmodel.description,
                Telephone = dbmodel.telephone,
                Email = dbmodel.email,
                Facebook = dbmodel.facebook,
                Twitter = dbmodel.twitter,
                Order = dbmodel.order,
                Status = (bool)dbmodel.status
            };
            return model.adminEmployeesModel;
        }

        public string setEmployeesModel(EmployeesModel model)
        {

            string err = "Başarılı.";
            try
            {
                if (model.Id == 0)//Ekle
                {
                    var myModel = new EMPLOYEES ()
                    {
                        id = model.Id,
                        image = model.Image,
                        name = model.Name,
                        surname = model.SurName,
                        title = model.Title,
                        description = model.Description,
                        telephone = model.Telephone,
                        email = model.Email,
                        facebook = model.Facebook,
                        twitter = model.Twitter,
                        order = model.Order,
                        status = (bool)model.Status
                    };
                    DBE.EMPLOYEES.Add(myModel);
                }
                else //Güncelle
                {
                    var dbmodel = getModelForId(model.Id);
                    dbmodel.id = model.Id;
                    dbmodel.image = model.Image;
                    dbmodel.name = model.Name;
                    dbmodel.surname = model.SurName;
                    dbmodel.title = model.Title;
                    dbmodel.description = model.Description;
                    dbmodel.telephone = model.Telephone;
                    dbmodel.email = model.Email;
                    dbmodel.facebook = model.Facebook;
                    dbmodel.twitter = model.Twitter;
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
        public string removeEmployeesModel(int id)
        {
            string err = "Başarılı.";
            var model = getModelForId(id);

            try
            {
                DBE.EMPLOYEES.Remove(model);
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