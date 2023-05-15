using Facade.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Facade.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }
        public IActionResult CustomerIndex()
        {
            var values = _context.Customers.ToList();
            return View(values);
        }

        public IActionResult AddNewCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("CustomerIndex");
        }
        public IActionResult UpdateCustomer(int id)
        {
            var value = _context.Customers.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            var value = _context.Customers.Find(customer.CustomerId);
            value.Name = customer.Name;
            value.Surname = customer.Surname;
            value.Address = customer.Address;
            value.City = customer.City;
            _context.SaveChanges();
            return RedirectToAction("CustomerIndex");
        }
        public IActionResult DeleteCustomer(int id)
        {
            var value = _context.Customers.Find(id);
            _context.Customers.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("CustomerIndex");
        }
    }
}
