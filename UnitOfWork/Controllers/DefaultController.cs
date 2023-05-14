using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UnitOfWork.Models;

namespace UnitOfWork.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerService _customerService;

        public DefaultController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult UnitOfIndex()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UnitOfIndex(CustomerViewModel customerViewModel)
        {
            var value1 = _customerService.TGetById(customerViewModel.SenderId);
            var value2 = _customerService.TGetById(customerViewModel.Receiver);
            value1.Balance -= customerViewModel.Amount;
            value2.Balance += customerViewModel.Amount;
            List<Customer> modifiedCustomers = new List<Customer>()
            {
                value1,value2
            };
            _customerService.TMultiUpdate(modifiedCustomers);
            return View();
        }
    }
}
