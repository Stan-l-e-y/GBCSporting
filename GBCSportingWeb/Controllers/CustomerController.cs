using GBCSportingWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

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

            HttpContext.Session.SetString("Active", "Customers");

            return View(customers);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Add";
            var countries = context.Countries.OrderBy(c => c.CountryId).ToList();

            ViewBag.Countries = countries;



            return View("Edit", new Customer());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var countries = context.Countries.OrderBy(c => c.CountryId).ToList();
            var customer = context.Customers.Find(id);
            ViewBag.Countries = countries;
            return View(customer);
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            

            if (ModelState.IsValid)
            {
                if (customer.CustomerId == 0)
                {
                    //The folllowing code checks if the email entered is already in the system

                    string key = nameof(Customer.Email);

                    if (ModelState.GetValidationState(key) == ModelValidationState.Valid)
                    {
                        var email = customer.Email;
                        var customers = context.Customers.ToList();
                        bool inSystem = false;
                        foreach (var cus in customers)
                        {
                            if (email == cus.Email)
                            {
                                inSystem = true; break;
                            }
                        }
                        if (inSystem)
                        {
                            ModelState.AddModelError(key, "Email is already in use.");
                        }
                        else
                        {
                            context.Customers.Add(customer);
                        }
                    }

                }
                else
                {
                    context.Customers.Update(customer);
                    
                }
                context.SaveChanges();
                return RedirectToAction("Index");
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
