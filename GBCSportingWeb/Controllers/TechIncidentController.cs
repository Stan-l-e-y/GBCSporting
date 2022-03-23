using GBCSportingWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace GBCSportingWeb.Controllers
{
    public class TechIncidentController : Controller
    {

        private ApplicationDbContext context { get; set; }

        public TechIncidentController(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            return View();
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
    }
}
