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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Products = context.Products.OrderBy(p => p.ProductId).ToList();
            ViewBag.Customers = context.Customers.OrderBy(c => c.CustomerId).ToList();
            ViewBag.Technicians = context.Technicians.OrderBy(t => t.TechnicianId).ToList();
            var incident = context.Incidents.Find(id);
            return View(incident);
        }

        [HttpPost]
        public IActionResult Edit(Incident incident)
        {
            if (ModelState.IsValid)
            {
                if(incident.IncidentId == 0)
                {
                    context.Incidents.Add(incident);
                    context.SaveChanges();
                }
                else
                {
                    context.Incidents.Update(incident);
                    context.SaveChanges();
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
        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    var incident = context.Incidents.Find(id);
        //    return View(incident);
        //}
        [HttpPost]
        public IActionResult Delete(Incident incident)
        {
            //var incident = context.Incidents.Find(id);
            context.Incidents.Remove(incident);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
