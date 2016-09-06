using Customer.Models.Classes.About;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer.Areas.Admin.Provider
{
    public class HomeAboutProvider
    {
        CUSTOMER_SQLEntities DBE = null;
         #region Constructor Method
        public HomeAboutProvider()
        {
            DBE = Helper.DataBase();
        }
          #endregion
        #region GetModelForId
        public ABOUT getModelForId(int? id)
        {
            var dbModel = DBE.ABOUT.FirstOrDefault(x => x.id == id);
            return dbModel;
        }
        #endregion
        #region GetListModel
        public List<ABOUT> getListModel()
        {
            var ListDbModel = DBE.ABOUT.ToList();
            return ListDbModel;
        }
        #endregion
        public List<AboutModel> getListAboutModel()
        {
            var dbModel = getListModel();
            var listModel = new List<AboutModel>();
            listModel.AddRange(dbModel.Select(s => new AboutModel()
            {
                Id = s.id,
                FilePath = s.sliderimage,
                Title = s.title,
                Description = s.description,
                VideoUrl=s.videoUrl,
                StatusViedo=(bool)s.statusVideo,
                Status = (bool)s.status

            }));
            return listModel;
        }
        public AboutModel getAboutModel(int? id)
        {
            var dbmodel = getModelForId(id);

            var myModel = new AboutModel()
            {
                Id = dbmodel.id,
                FilePath = dbmodel.sliderimage,
                Title = dbmodel.title,
                Description = dbmodel.description,
                VideoUrl=dbmodel.videoUrl,
                Status = (bool)dbmodel.status
            };
            return myModel;
        }
        public string setAboutModel(AboutModel model)
        {

            string err = "Başarılı.";
            try
            {
                if (model.Id == 0)//Ekle
                {
                    var myModel = new ABOUT()
                    {
                        id = model.Id,
                        sliderimage = model.FilePath,
                        title = model.Title,
                        description = model.Description,
                        status = model.Status,
                        videoUrl=model.VideoUrl
                    };
                    DBE.ABOUT.Add(myModel);
                }
                else //Güncelle
                {
                    var dbmodel = getModelForId(model.Id);
                    dbmodel.id = model.Id;
                    dbmodel.sliderimage = model.FilePath;
                    dbmodel.title = model.Title;
                    dbmodel.description = model.Description;
                    dbmodel.status = model.Status;
                    dbmodel.videoUrl = model.VideoUrl;

                }
                DBE.SaveChanges();
            }
            catch (System.Exception ex)
            {
                err = ex.Message;
            }
            return err;
        }
        public string removeAboutModel(int id)
        {
            string err = "Başarılı.";
            var model = getModelForId(id);

            try
            {
                DBE.ABOUT.Remove(model);
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