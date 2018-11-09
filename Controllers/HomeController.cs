using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShopApp.Models;

namespace CoffeeShopApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult RegistrationPage()
        {
            return View();
        }

        public ActionResult Confirn()
        {
            return View();
        }

        public ActionResult Welcome(UserInfo newUser)
        {

            if (ModelState.IsValid)
            {
              
                ViewBag.ConfMessage = "Thanks " + newUser.FirstName;

                return View("Confirn");
            }

            else
            {
                return View("Error");
            }
        }
    
        public ActionResult Confirm(UserInfo NewName)
        {
            return View();
        }


    }
}