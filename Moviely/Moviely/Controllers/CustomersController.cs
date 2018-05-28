using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moviely.Models;

namespace Moviely.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Michael Jackson" },
                new Customer { Id = 3, Name = "Zinedine Zidane" },
                new Customer { Id = 4, Name = "Diego Maradona" }
            };
        }


        public ActionResult Details( int id)
        {
            var customers = GetCustomers();
           
            var customerFound = new Customer();

            foreach( var customer in customers)
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
           var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

                       if (customer == null)
                               return HttpNotFound();

                       return View(customer);
       }*/
    }
}