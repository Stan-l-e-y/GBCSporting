using GBCSportingWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace GBCSportingWeb.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext context { get; set; }

        public ProductController(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public ViewResult Index()
        {
            var products = context.Products
                .OrderBy(p => p.ProductName)
                .ToList();

            //Sets a session cookie for storing the active nav link
            HttpContext.Session.SetString("Active", "Products");

            return View(products);
        }

        [HttpGet]
        public ViewResult Create()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Product());
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            ViewBag.Action = "Edit";

            var product = context.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                //Using TempData to store a success message 
                if (product.ProductId == 0)
                {
                    context.Products.Add(product);
                    TempData["message"] = $"{product.ProductName} was added.";
                }
                else
                {
                    context.Products.Update(product);
                    TempData["message"] = $"{product.ProductName} was succefully updated.";

                }
                context.SaveChanges();
                return RedirectToAction("Index", "Product");
            }
            else
            {
                ViewBag.Action = (product.ProductId == 0) ? "Add" : "Edit";
                return View(product);
            }
        }

        [HttpGet]
        public RedirectToActionResult Delete(int id)
        {
            var product = context.Products.Find(id);
            context.Products.Remove(product);
            context.SaveChanges();
            TempData["message"] = $"{product.ProductName} was deleted.";
            return RedirectToAction("Index");
        }
    }
}

