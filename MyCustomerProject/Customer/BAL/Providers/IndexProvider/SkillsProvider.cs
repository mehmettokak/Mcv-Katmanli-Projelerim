
using Customer.Models.Classes;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer.BAL.Providers.IndexProvider
{
    public class SkillsProvider
    {
        CUSTOMER_SQLEntities DBE = null;
        public SkillsProvider()
        {
            DBE = Helper.DataBase();
        }

        public List<SkillsModel> GetWorksListModel()
        {
            List<SkillsModel> ListModel = new List<SkillsModel>();
            var DbListModel = DBE.SKILL.ToList().Where(x=>x.status==true).OrderBy(o=>o.order).Take(9);
            ListModel.AddRange(DbListModel.Select(s => new SkillsModel()
            {
                Id = s.id,
                IconName=s.iconName,
                Title = s.title,
                Description = s.description,
                Order = s.order,
                Status = (bool)s.status
            }

                ));
            //Helper.DoIt(DbListModel,ListModel);

            return ListModel;
        }
    }
}