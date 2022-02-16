using GBCSportingWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace GBCSportingWeb.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext context { get; set; }

        public ProductController(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
