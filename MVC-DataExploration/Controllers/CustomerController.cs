using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DataExploration.Models;

namespace MVC_DataExploration.Controllers
{
    public class CustomerController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: Customer
        public ActionResult Index()
        {
            return View(db.Customers);
        }

        //GET: Create 
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //POST: Create
        [HttpPost]
        public ActionResult Create(Customer MyCustomer)
        {
            //add the new customer to my set of customers.
            db.Customers.Add(MyCustomer);
            //Updates the database
            db.SaveChanges();
            return View("Index", db.Customers);
        }
    }
}