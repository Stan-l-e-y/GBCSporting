using GBCSportingWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace GBCSportingWeb.Controllers
{
    public class TechnicianController : Controller
    {
        private ApplicationDbContext context { get; set; }

        public TechnicianController(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var Technicians = context.Technicians
                            .OrderBy(t => t.Name)
                            .ToList();

            HttpContext.Session.SetString("Active", "Technicians");

            return View(Technicians);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Technician());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            
            var technician = context.Technicians.Find(id);
            return View(technician);
        }

        [HttpPost]
        public IActionResult Edit(Technician technician)
        {
            if (ModelState.IsValid)
            {
                if (technician.TechnicianId == 0)
                    context.Technicians.Add(technician);
                else
                    context.Technicians.Update(technician);
                context.SaveChanges();
                return RedirectToAction("Index", "Technician");
            }
            else
            {
                ViewBag.Action = (technician.TechnicianId == 0) ? "Add" : "Edit";
                return View(technician);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var technician = context.Technicians.Find(id);

            //Have to load incidents if we want to cascade down and remove technicians from incidents 
            var incidents = context.Incidents.ToList();
            context.Technicians.Remove(technician);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }

}
