using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using s.Models;
using shopping.ViewModels;

namespace s.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Login(string username, string password)
        {

            String result = "login successful";

            if (username == null || "".Equals(username) || password == null || "".Equals(password))
            {
                result = "login fail";
            }

            return Content(result);
        }
        public ActionResult RegisterAccount()
        {
            //return "< h2 > Resgister Account </ h2 >";

            return View();
        }

    }
}
