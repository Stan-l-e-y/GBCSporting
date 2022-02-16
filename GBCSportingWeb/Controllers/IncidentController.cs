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
            ViewBag.Products = context.Products.OrderBy(p => p.ProductId).ToList();
            ViewBag.Customers = context.Customers.OrderBy(c => c.CustomerId).ToList();
            ViewBag.Technicians = context.Technicians.OrderBy(t => t.TechnicianId).ToList();

            return View("Edit", new Incident());
        }

        [HttpPost]
        public IActionResult Edit(Incident incident)
        {
            if (ModelState.IsValid)
            {
                if(incident.IncidentId == 0)
                {
                    context.Incidents.Add(incident);
                }
                else
                {
                    context.Incidents.Update(incident);
                }
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Action = (incident.IncidentId == 0) ? "Add" : "Edit";
                ViewBag.Products = context.Products.OrderBy(p => p.ProductId).ToList();
                ViewBag.Customers = context.Customers.OrderBy(c => c.CustomerId).ToList();
                ViewBag.Technicians = context.Technicians.OrderBy(t => t.TechnicianId).ToList();

                return View(incident);
            }
        }
    }
}
