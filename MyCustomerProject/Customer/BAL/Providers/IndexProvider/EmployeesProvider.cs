
using Customer.Models.Classes;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer.BAL.Providers.IndexProvider
{
    public class EmployeesProvider
    {
         CUSTOMER_SQLEntities DBE = null;
         public EmployeesProvider()
        {
            DBE = Helper.DataBase();
        }

        public List<EmployeesModel> GetEmployeesListModel()
        {
            List<EmployeesModel> ListModel = new List<EmployeesModel>();
            var DbListModel = DBE.EMPLOYEES.ToList().Where(x=>x.status==true).OrderBy(o=>o.order).Take(4);
            ListModel.AddRange(DbListModel.Select(s => new EmployeesModel()
            {
                Id = s.id,
                Name=s.name,
                SurName=s.surname,
                Email=s.email,
                Telephone=s.telephone,
                Image=s.image,
                Title = s.title,
                Description = s.description,
                Order = s.order,
                Status = (bool)s.status,
                Facebook=s.facebook,
                Twitter=s.twitter
            }

                ));
         

            return ListModel;
        }
    }
}