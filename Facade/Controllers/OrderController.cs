using Facade.DAL;
using Facade.FacadePattern;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Facade.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderFacade _orderFacade;
        private readonly Context _context;

        public OrderController(OrderFacade orderFacade, Context context)
        {
            _orderFacade = orderFacade;
            _context = context;
        }

        public IActionResult OrderIndex()
        {
            var values = _context.Orders.Include(b=>b.OrderDetails).ToList();
            return View(values);
        }
        public IActionResult OrderStart()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OrderStart(int id, int productId, int orderId, int productCount, decimal productPrice, decimal totalProductPrice)
        {
            _orderFacade.CompleteOrder(id, productId, orderId, productCount, productPrice,totalProductPrice);
            return RedirectToAction("OrderIndex");
        }
    }
}
