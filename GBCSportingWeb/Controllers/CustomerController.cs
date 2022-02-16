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
        public IActionResult Index()  //TODO wtf is the error here, I'm logging off bye
        {
            var customers = context.Customers
                            .Include(c => c.FirstName)
                            .Include(c => c.LastName)
                            .Include(c => c.Email)
                            .Include(c => c.City)
                            .OrderBy(c => c.FirstName).ThenBy(c => c.LastName)
                            .ToList();

            return View(customers);
        }

        //[HttpGet]
        //public IActionResult Create()
        //{
        //    ViewBag.Action = "Add";
        //    ViewBag.Products = context.Products.OrderBy(p => p.ProductId).ToList();
        //    ViewBag.Customers = context.Customers.OrderBy(c => c.CustomerId).ToList();
        //    ViewBag.Technicians = context.Technicians.OrderBy(t => t.TechnicianId).ToList();

        //    return View("Edit", new Customer());
        //}
    }
}
