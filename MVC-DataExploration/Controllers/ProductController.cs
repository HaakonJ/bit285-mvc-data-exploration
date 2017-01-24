using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DataExploration.Models;

namespace MVC_DataExploration.Controllers
{
    public class ProductController : Controller
    {
        
        private grocertogoEntities db = new grocertogoEntities();

        // GET: Customer
        public ActionResult Index()
        {
            return View(db.Products);
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
            db.Products.Add(MyProduct);
            //Updates the database
            db.SaveChanges();
            return View("Index", db.Products);
        }
    }
}