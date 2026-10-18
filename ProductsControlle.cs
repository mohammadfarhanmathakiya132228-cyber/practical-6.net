using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductsController : Controller
    {
        static List<Product> products = new List<Product>();

        // Product List
        public IActionResult Index()
        {
            return View(products);
        }

        // Create Page
        public IActionResult Create()
        {
            return View();
        }

        // Save Product
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                product.Id = products.Count + 1;

                products.Add(product);

                return RedirectToAction("Index");
            }

            return View(product);
        }
    }
}
