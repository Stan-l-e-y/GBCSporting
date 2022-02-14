using GBCSportingWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GBCSportingWeb.Controllers
{
    public class IncidentController : Controller
    {

        private ApplicationDbContext context { get; set; }

        public IncidentController(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var incidents = context.Incidents
                            .Include(i => i.Product)
                            .Include(i => i.Customer)
                            .Include(i => i.Technician)
                            .OrderBy(i => i.DateOpened)
                            .ToList();

            return View(incidents);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Add";
            ViewBag.Products = context.Product


            return View();
        }
    }
}
