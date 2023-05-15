using Facade.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Facade.Controllers
{
    public class ProductController : Controller
    {
        private readonly Context _context;

        public ProductController(Context context)
        {
            _context = context;
        }

        public IActionResult ProductIndex()
        {
            var values = _context.Products.Include(b=>b.Category).ToList();
            return View(values);
        }

        public IActionResult AddNewProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewProduct(Product Product)
        {
            _context.Products.Add(Product);
            _context.SaveChanges();
            return RedirectToAction("ProductIndex");
        }
        public IActionResult UpdateProduct(int id)
        {
            var value = _context.Products.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product Product)
        {
            var value = _context.Products.Find(Product.ProductId);
            value.Name = Product.Name;
            value.Stock = Product.Stock;
            value.Price= Product.Price;
            value.Category = Product.Category;
            _context.SaveChanges();
            return RedirectToAction("ProductIndex");
        }
        public IActionResult DeleteProduct(int id)
        {
            var value = _context.Products.Find(id);
            _context.Products.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ProductIndex");
        }
    }
}
