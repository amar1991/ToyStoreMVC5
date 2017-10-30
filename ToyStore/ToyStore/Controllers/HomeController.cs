using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ToyStore.Context;
using ToyStore.Models;

namespace ToyStore.Controllers
{
    public class HomeController : Controller
    {
        ProductDBContext _db = new ProductDBContext();
        // GET: Home
        
        public ActionResult Index()
        {
            Products product = new Products();
            
            return View(_db.products.ToList());
        }

        [HttpPost]
        public ActionResult Index(string Search)
        {

            if (ModelState.IsValid)
            {
                var SearchBar = from search in _db.products
                                where search.ProductName == Search
                                select search;
               
                return View(SearchBar);
             
            }

            return View();

        }



        public ActionResult Order(int id)
        {

            return View();
        }



    }
}