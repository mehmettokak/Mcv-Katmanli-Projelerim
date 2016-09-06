using CompanyWeb.BAL.Provider;
using CompanyWeb.Entity.Model;
using CompanyWeb.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace CompanyWeb.Web.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        private readonly DbProvider<Employee> _dbEmployeModel = new DbProvider<Employee>();
        public ActionResult Index(int id)
        {
            #region EmployeeViewModel 
            var dbModel = _dbEmployeModel.GetById(id);
            var dbListModel = _dbEmployeModel.GetAll().Include(s => s.EmployeeLangs.Select(x => x.Employee));

            var employeeModel = new EmployeeViewModel();

            employeeModel = new EmployeeViewModel()
            {
                ID = dbModel.ID,
                FirstName = dbModel.FirstName,
                LastName = dbModel.LastName,
                AvatarURL = dbModel.AvatarURL,
                RowNumber = dbModel.RowNumber,
                IsActive = dbModel.IsActive,
                Email = dbModel.Email,
                MobilePhone = dbModel.MobilePhone,
                SocialLinks = dbModel.SocialLinks,
                
                
            };
            var dbEmployeeLang = dbModel.EmployeeLangs.FirstOrDefault(x => x.LanguageId == Helper.LangId);
            if (dbEmployeeLang != null)
            {
                employeeModel.Title = dbEmployeeLang.Title;
                employeeModel.Description = dbEmployeeLang.Description;
                employeeModel.Content = dbEmployeeLang.Content;
                employeeModel.Employees = dbListModel;
            }
            #endregion
            return View(employeeModel);
        }
    }
}