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
                            .OrderBy(c => c.FirstName).ThenBy(c => c.LastName)
                            .ToList();

            return View(customers);
        }
    }
}
