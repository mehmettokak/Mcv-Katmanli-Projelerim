
using Customer.Models.Classes;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer.BAL.Providers.IndexProvider
{
    public class WorksProvider
    {
        CUSTOMER_SQLEntities DBE = null;
        public WorksProvider()
        {
            DBE = Helper.DataBase();
        }

        public List<WorksModel> GetWorksListModel()
        {
            List<WorksModel> ListModel = new List<WorksModel>();
            var DbListModel = DBE.WORK.ToList().Where(x=>x.status==true).OrderBy(o=>o.order).Take(9);
            ListModel.AddRange(DbListModel.Select(s => new WorksModel()
            {
               Id=s.id,
               ContentUrl=s.contentUrl,
               ImageUrl=s.imageUrl,
               Title=s.title,
               Description=s.description,
               Order=s.order,
               Status=(bool) s.status
            }

                ));
            //Helper.DoIt(DbListModel,ListModel);

            return ListModel;
        }
    }
}