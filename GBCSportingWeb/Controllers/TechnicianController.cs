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


    }
}
