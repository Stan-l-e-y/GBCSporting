using Microsoft.AspNetCore.Mvc;
using GBCSportingWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace GBCSportingWeb.Controllers
{
    public class RegistrationController : Controller
    {

        private ApplicationDbContext context { get; set; }

        public RegistrationController(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult ShowCustomers()
        {
            ViewBag.Customers = context.Customers.OrderBy(c => c.CustomerId).ToList();

            return View("Customers");
        }

        [HttpPost]
        public IActionResult RegistrationsByCustomer(Customer customer)
        {
            if (customer.CustomerId == 0)
            {
                TempData["Error"] = "Please select a Customer";
                return RedirectToAction("ShowCustomers");
            }

            int id = customer.CustomerId;

            var cus = context.Customers.Find(id);

            string name = cus.FirstName + " " + cus.LastName;

            HttpContext.Session.SetInt32("CustomerId", id);
            HttpContext.Session.SetString("CustomerName", name);
            ViewData["id"] = HttpContext.Session.GetInt32("CustomerId");

            ViewBag.Products = context.Products.OrderBy(p => p.ProductId).ToList();
            ViewBag.Registrations = context.Registrations.Where(c => c.CustomerId == customer.CustomerId).Include(p => p.Product).ToList();
            //var reg = context.Registrations.Where(c => c.CustomerId == customer.CustomerId).Include(p => p.Product).ToList();



            return View("Registrations");
        }

        [HttpPost]
        public IActionResult Register(Registration registration)
        {
            int customerId = (int)HttpContext.Session.GetInt32("CustomerId");

            var cus = context.Customers.Find(customerId);

            if(registration.ProductId == 0)
            {
                TempData["Error"] = "Please select a Product";
                return RegistrationsByCustomer(cus);
            }

            context.Registrations.Add(registration);
            context.SaveChanges();

            return RegistrationsByCustomer(cus);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var registration = context.Registrations.Find(id);
            context.Registrations.Remove(registration);
            context.SaveChanges();

            int customerId = (int)HttpContext.Session.GetInt32("CustomerId");

            var cus = context.Customers.Find(customerId);

            return RegistrationsByCustomer(cus);
        }
    }
}
