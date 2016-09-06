using Customer.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Customer.Areas.Admin.Models;

namespace Customer.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: Admin/Account
        public ActionResult Login()
        {
            var model = new LoginVievModel();
          
            return View(model);
        }
    }
}