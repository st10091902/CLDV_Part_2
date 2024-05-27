using CLDV_Part_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLDV_Part_2.Controllers
{
    public class ProductController : Controller
    {
        private readonly KhumaloCraftContext _context;

        public ProductController(KhumaloCraftContext context)
        {
            _context = context;
        }

        public IActionResult MyWork()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("MyWork");
            }
            return View("MyWork", _context.Products.ToList());
        }

        [HttpPost]
        public IActionResult OrderProduct(int productId)
        {
            // Add order processing logic here
            return RedirectToAction("MyWork");
        }
    }
}
