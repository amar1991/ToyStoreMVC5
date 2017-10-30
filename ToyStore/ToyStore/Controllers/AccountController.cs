using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToyStore.Context;
using ToyStore.Models;

namespace ToyStore.Controllers
{
    public class AccountController : Controller
    {

        [HttpGet]
        public ActionResult Register()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Register(Customer user)
        {
            using (ProductDBContext _db = new ProductDBContext())
            {

                if (ModelState.IsValid)
                {
                    _db.customers.Add(user);
                    _db.SaveChanges();
                    ViewBag.Message = user.FirstName + " " + user.LastName + "  account created";
                    return View();
                }
            }

            return View();
        }



        public ActionResult Login()
        {

            return View();
        }      



  
    }
}