using Iterator.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace Iterator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult IteratorIndex()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> strings = new List<string>();
            visitRouteMover.AddVisitRoute(new VisitorRoute
            {
                City = "Berlin",
                Country = "Almanya",
                VisitPlace = "Berlin Kapısı"
            });
            visitRouteMover.AddVisitRoute(new VisitorRoute
            {
                City = "Paris",
                Country = "Fransa",
                VisitPlace = "Eyfel Kulesi"
            });
            visitRouteMover.AddVisitRoute(new VisitorRoute
            {
                City = "Venedik",
                Country = "İtalya",
                VisitPlace = "Gondol"
            }); visitRouteMover.AddVisitRoute(new VisitorRoute
            {
                City = "Roma",
                Country = "İtalya",
                VisitPlace = "Kolezyum"
            });
            visitRouteMover.AddVisitRoute(new VisitorRoute
            {
                City = "Prag",
                Country = "Çek Cumhuriyeti",
                VisitPlace = "Meydan"
            });
            var iterator = visitRouteMover.CreateIterator();
            while (iterator.NextLocation())
            {
                strings.Add(iterator.CurrentItem.Country + " " + iterator.CurrentItem.City + " " + iterator.CurrentItem.VisitPlace);
            }
            ViewBag.v = strings;
            return View();
        }
    }
}
