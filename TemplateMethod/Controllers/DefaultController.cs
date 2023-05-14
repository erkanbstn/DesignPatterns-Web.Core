using Microsoft.AspNetCore.Mvc;
using TemplateMethod.TemplatePattern;

namespace TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Temel Plan");
            ViewBag.v2 = netflixPlans.CountPerson(1);
            ViewBag.v3 = netflixPlans.Price(65.99);
            ViewBag.v4 = netflixPlans.Content("Film-Dizi");
            ViewBag.v5 = netflixPlans.Resolution("480px");
            return View();
        }
        public IActionResult StandartPlanIndex()
        {
            NetflixPlans netflixPlans = new StandartPlan();
            ViewBag.v6 = netflixPlans.PlanType("Standart Plan");
            ViewBag.v7 = netflixPlans.CountPerson(3);
            ViewBag.v8 = netflixPlans.Price(89.99);
            ViewBag.v9 = netflixPlans.Content("Film-Dizi-Çizgi Film");
            ViewBag.v10 = netflixPlans.Resolution("720px");
            return View();
        }
    }
}
