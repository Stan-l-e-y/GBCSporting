using GBCSportingWeb.Models;
using Microsoft.AspNetCore.Mvc;

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
            var incidents = context.Incidents.ToList();

            return View(incidents);
        }
    }
}
