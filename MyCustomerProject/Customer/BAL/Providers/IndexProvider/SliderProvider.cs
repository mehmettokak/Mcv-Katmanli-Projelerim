using Customer.Models;
using Customer.Models.Classes;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer.BAL.Providers.IndexProvider
{
    public class SliderProvider
    {
        CUSTOMER_SQLEntities DBE = null;
        public SliderProvider()
        {
            DBE = Helper.DataBase();
        }

        public SliderModel GetSliderModel()
        {
            SliderModel model = new SliderModel();
           
            var DbModel = DBE.SLIDER.FirstOrDefault(x=>x.imageStatus==true);
            if (DbModel!=null)
            {
                model.id = DbModel.id;
                model.imageDescription = DbModel.imageDescription;
                model.imageStatus = (bool)DbModel.imageStatus;
                model.filePath = DbModel.imageUrl;
                model.VideoUrl = DbModel.videoUrl;  
            }
            else
            {
                model = new SliderModel();
            }

            //Helper.DoIt(DbModel,model);
            return model;
        }
    }
}