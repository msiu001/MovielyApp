using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moviely2.Models;

namespace Moviely2.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ViewResult Index()
        {
            var customers = _context.Customers.ToList();

            return View(customers);
        }



        public ActionResult Details(int id)
        {
            var customers = _context.Customers.ToList();

            var customerFound = new Customer();

            foreach (var customer in customers)
            {
                if (id == customer.Id)
                {
                    customerFound.Id = id;
                    customerFound.Name = customer.Name;
                }
            }
            if (customerFound.Id != id)
                return HttpNotFound();

            return View(customerFound);
        }
        //Mosh's Solution
        /*{
           var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

                       if (customer == null)
                               return HttpNotFound();

                       return View(customer);
       }*/
    }
}