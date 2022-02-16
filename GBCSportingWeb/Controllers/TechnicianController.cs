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

            return View(Technicians);
        }
        [HttpGet]
        public IActionResult Add()
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
    }

}
