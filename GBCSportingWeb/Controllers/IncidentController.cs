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
            return View();
        }
    }
}
