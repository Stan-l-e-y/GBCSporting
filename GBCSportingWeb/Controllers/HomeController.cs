using GBCSportingWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GBCSportingWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Sets a session cookie for storing the active nav link
            HttpContext.Session.SetString("Active", "Home");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            //Sets a session cookie for storing the active nav link
            HttpContext.Session.SetString("Active", "About");
            return View();
        } 


    }
}