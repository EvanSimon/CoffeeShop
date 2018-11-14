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

            CoffeeShopDBEntities datebase = new CoffeeShopDBEntities();
            ViewBag.Test = datebase.Items.ToList<Item>();
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

        public ActionResult Welcome(User newUser)
        {

            if (ModelState.IsValid)
            {
                CoffeeShopDBEntities database = new CoffeeShopDBEntities();
                database.Users.Add(newUser);
                database.SaveChanges();
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

        public ActionResult Test()
        {
            return View();
        }

       

    }
}