using ChainOfResponsibility.ChainReponsibility;
using ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ProcessViewModel processViewModel)
        {
            Employee treasurer = new Treasurer();
            Employee managerAssistant = new ManagerAssistant();
            Employee manager = new Manager();
            Employee areaDirector = new AreaDirector();

            treasurer.SetNextApprover(managerAssistant);
            managerAssistant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirector);

            treasurer.ProcessRequest(processViewModel);
            return View();
        }
    }
}
