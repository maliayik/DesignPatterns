using DesignPattern.Iterator.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Iterator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> strings = new List<string>();

            //db kullanmadıgımız için buradan visit routumuza değerler atıyoruz.
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "Almanya",
                CityName = "Berlin",
                VisitPlaceName = "Berlin Kapısı",
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName="Fransa",
                CityName="Paris",
                VisitPlaceName="Eyfel",
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName="İtalya",
                CityName="Venedik",
                VisitPlaceName="Gondol"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "Çekya",
                CityName = "Prag",
                VisitPlaceName = "Meydan"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "İsviçre",
                CityName = "Bern",
                VisitPlaceName = "Zermat"
            });

            var iterator = visitRouteMover.CreateIterator();

            //burada iteratörün gideceği yeni lokasyonlar varmı varsa içerisinde dönücek.
            while(iterator.NextLocation())
            {
                strings.Add(iterator.CurrentItem.CountryName +" "+iterator.CurrentItem.CityName + " " + iterator.CurrentItem.VisitPlaceName);
            }

            ViewBag.v = strings;


            return View();
        }
    }
}
