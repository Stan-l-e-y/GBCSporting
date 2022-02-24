using GBCSportingWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GBCSportingWeb.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext context { get; set; }

        public CustomerController(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()  
        {
            var customers = context.Customers
                            .OrderBy(c => c.FirstName).ThenBy(c => c.LastName)
                            .ToList();

            return View(customers);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Add";
            ViewBag.Countries = context.Countries.OrderBy(c => c.CountryId).ToList();
            return View("Edit", new Customer());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Countries = context.Countries.OrderBy(c => c.CountryId).ToList();
            var customer = context.Customers.Find(id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (customer.CustomerId == 0)
                {
                    context.Customers.Add(customer);
                }
                else
                {
                    context.Customers.Update(customer);
                    
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Customer");
            }
            else
            {
                ViewBag.Action = (customer.CustomerId == 0) ? "Add" : "Edit";
                ViewBag.Countries = context.Countries.OrderBy(c => c.CountryId).ToList();
                return View(customer);
            }   
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var customer = context.Customers.Find(id);
            context.Customers.Remove(customer);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
