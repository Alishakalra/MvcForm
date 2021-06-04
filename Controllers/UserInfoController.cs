using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserInfoController : Controller
    {
        MvcFormDBEntities1 dbObj = new MvcFormDBEntities1();
        // GET: Home
        public ActionResult UserInfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddInfo(UserInfoTable model)
        {
            UserInfoTable info = new UserInfoTable();
            if (ModelState.IsValid)
            {
                info.firstname = model.firstname;
                info.lastname = model.lastname;
                info.email = model.email;

                dbObj.UserInfoTables.Add(info);
                dbObj.SaveChanges();
                return View();


            }

            return View("UserInfo");

            
            
        }
    }
}