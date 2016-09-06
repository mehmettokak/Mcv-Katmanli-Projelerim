using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using Customer.Models.Classes;


namespace Customer.BAL.Providers.IndexProvider
{
    public class NavigationProvider
    {
        CUSTOMER_SQLEntities DBE = null;
        public NavigationProvider()
        {
            DBE = Helper.DataBase();
        }

        public List<NavigationModel> GetNavigationListModel()
        {
            List<NavigationModel> ListModel = new List<NavigationModel>();
            var DbListModel = DBE.MENU.ToList().OrderBy(x=>x.order);
            ListModel.AddRange(DbListModel.Select(s => new NavigationModel()
            {
                Id = s.id,
                Name = s.name,
                Order = s.order,
                Url=s.url
            }

                ));
          //Helper.DoIt(DbListModel,ListModel);

            return ListModel;
        }
    }
}