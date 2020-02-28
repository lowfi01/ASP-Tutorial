using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_Tutorial.Models;
using ASP_Tutorial.ViewModel;

namespace ASP_Tutorial.Controllers
{
    public class CustomersController : Controller
    {

        private Customer _context;

        public CustomersController()
        {
            _context = new Customer();
        }

        public ActionResult New()
        {
            return View();
        }

        public ViewResult Index()
        {
            //var customers = (from c in _context.
            //    select c).ToList();

            List<Customer> customers = null;

            var context = new Entities();
            customers = context.Customers.ToList();
            context = new Entities();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            List<Customer> customers = null;
            using (var context = new Entities())
            {
                customers = (from c in context.Customers
                    select c).ToList();
            }

            var customer = customers.SingleOrDefault(c => c.Id == id);

            return View(customer);
        }

       
    }

}