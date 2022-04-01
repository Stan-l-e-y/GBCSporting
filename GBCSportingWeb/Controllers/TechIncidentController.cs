using GBCSportingWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace GBCSportingWeb.Controllers
{
    public class TechIncidentController : Controller
    {

        private ApplicationDbContext context { get; set; }

        public TechIncidentController(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult ShowTechnicians()
        {
            ViewBag.Technicians = context.Technicians.OrderBy(t => t.TechnicianId).ToList();

            return View("Technicians");
        }

        [HttpPost]
        public IActionResult IncidentsByTechnician(Technician technician)
        {
            if (technician.TechnicianId == 0)
            {
                TempData["Error"] = "Please select a Technician";
                return RedirectToAction("ShowTechnicians");
            }

            int id = technician.TechnicianId;

            HttpContext.Session.SetInt32("TechId", id);

            //Filter for incidents with technician id that equals one in argument 
            var incidents = context.Incidents.OrderBy(i => i.IncidentId).Where(t => t.TechnicianId == technician.TechnicianId).Where(t => t.DateClosed == null).ToList();
            ViewBag.Technician = context.Technicians.Find(technician.TechnicianId);
            ViewBag.Products = context.Products.OrderBy(p => p.ProductId).ToList();
            ViewBag.Customers = context.Customers.OrderBy(c => c.CustomerId).ToList();


            return View("IncidentsByTechnician", incidents);

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var incident = context.Incidents.Find(id);
            ViewBag.CustomerName = context.Customers.Find(incident.CustomerId).FirstName;
            ViewBag.CustomerName += " " + context.Customers.Find(incident.CustomerId).LastName;
            ViewBag.TechnicianName = context.Technicians.Find(incident.TechnicianId).Name;
            ViewBag.ProductName = context.Products.Find(incident.ProductId).ProductName;
            ViewBag.Title = incident.Title;            
            ViewBag.DateOpened = incident.DateOpened;
            return View(incident);
        }

        [HttpPost]
        public IActionResult Edit(Incident incident)
        {
            if (ModelState.IsValid)
            {
                
                context.Incidents.Update(incident);
                context.SaveChanges();
                int num = (int)HttpContext.Session.GetInt32("TechId");
                var technician = context.Technicians.Find(num);
                return IncidentsByTechnician(technician);
            }
            else
            {
                return Edit(incident.IncidentId);
            }
        }

        [HttpGet]
        public IActionResult Cancel()
        {
            int num = (int)HttpContext.Session.GetInt32("TechId");
            var technician = context.Technicians.Find(num);
            return IncidentsByTechnician(technician);
        }
    }
}
