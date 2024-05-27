using CLDV_Part_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CLDV_Part_2.Controllers
{
    public class OrderController : Controller
    {
        private readonly KhumaloCraftContext _context;

        public OrderController(KhumaloCraftContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult OrderHistory()
        {
            var userId = User.Identity.Name;
            var orders = _context.Orders.Include(o => o.Product).Where(o => o.UserId == userId).ToList();
            return View(orders);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult ProcessOrders()
        {
            var orders = _context.Orders.Include(o => o.Product).Where(o => !o.IsProcessed).ToList();
            return View(orders);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult ProcessOrder(int orderId)
        {
            var order = _context.Orders.Find(orderId);
            if (order != null)
            {
                order.IsProcessed = true;
                _context.SaveChanges();
            }
            return RedirectToAction("ProcessOrders");
        }
    }
}
