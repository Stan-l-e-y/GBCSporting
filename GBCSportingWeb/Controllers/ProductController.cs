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

        public IActionResult Index()
        {
            var products = context.Products
                .OrderBy(p => p.ProductName)
                .ToList();

            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Product());
        }

        [HttpGet]
        public IActionResult Edit(int id)
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
                if (product.ProductId == 0)
                {
                    context.Products.Add(product);
                }
                else
                {
                    context.Products.Update(product);
                    
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
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(id);
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

