using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DataExploration.Controllers
{
    public class ProductController : Controller
    {
        
        private grocertogo db = new grocertogo();

        // GET: Customer
        public ActionResult Index()
        {
            return View(db.Product);
        }

        //GET: Create 
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //POST: Create
        [HttpPost]
        public ActionResult Create(Product MyProduct)
        {
            //add the new customer to my set of customers.
            db.Product.Add(MyProduct);
            //Updates the database
            db.SaveChanges();
            return View("Index", db.Product);
        }
    }
}