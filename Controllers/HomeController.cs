using CLDV_Part_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;

namespace CLDV_Part_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly KhumaloCraftContext _context;

        public HomeController(KhumaloCraftContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
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
        public IActionResult PlaceOrder(int productId)
        {
            var userId = User.Identity.Name;
            if (userId == null)
            {
                return Unauthorized();
            }

            var order = new Order { ProductId = productId, UserId = userId, OrderDate = DateTime.Now };
            _context.Orders.Add(order);
            _context.SaveChanges();
            return RedirectToAction("MyWork");
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
