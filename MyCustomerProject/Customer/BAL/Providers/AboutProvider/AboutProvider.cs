
using Customer.Models.Classes;
using Customer.Models.Classes.About;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer.BAL.Providers.AboutProvider
{
    public class AboutProvider
    {
          CUSTOMER_SQLEntities DBE = null;
          #region Constructor Method
          public AboutProvider()
        {
            DBE = Helper.DataBase();
        }
          #endregion

          #region Get About Model For Status
          public ABOUT GetAboutModelForStatus()
          {
              var dbModel = DBE.ABOUT.FirstOrDefault(x => x.status == true);
              return dbModel;
          }
          #endregion

          #region Get About Slider Model
          public SliderModel GetAboutSliderModel()
        {
            var model = new SliderModel();
            var DbModel = GetAboutModelForStatus();
            model.filePath = DbModel.sliderimage;
            model.imageDescription = DbModel.title;
            return model;
        }
          #endregion

          #region Get About Content Model
          public AboutModel GetAboutContentModel()
          {
              var model = new AboutModel();
              var DbModel = GetAboutModelForStatus();
              model.Description = DbModel.description;
              return model;
          }
          #endregion
    }
}