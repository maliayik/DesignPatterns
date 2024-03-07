using DesignPattern.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            //Burada abstract classı newleyemediğimiz için abstract clası inherit eden clası newliyoruz.
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Temel Plan");
            ViewBag.v2 = netflixPlans.CountPerson(1);
            ViewBag.v3 = netflixPlans.Price(65.99);
            ViewBag.v4 = netflixPlans.Content("Film-Dizi");
            ViewBag.v5 = netflixPlans.Resolution("720p");
            return View();
        }

        public IActionResult StandardPlanIndex()
        {
            //Burada abstract classı newleyemediğimiz için abstract clası inherit eden clası newliyoruz.
            NetflixPlans netflixPlans = new StandardPlan();
            ViewBag.v1 = netflixPlans.PlanType("Standat Plan");
            ViewBag.v2 = netflixPlans.CountPerson(2);
            ViewBag.v3 = netflixPlans.Price(99);
            ViewBag.v4 = netflixPlans.Content("Film-Dizi-Belgesel");
            ViewBag.v5 = netflixPlans.Resolution("1080p");
            return View();
        }

        public IActionResult UltraPlanIndex()
        {
            //Burada abstract classı newleyemediğimiz için abstract clası inherit eden clası newliyoruz.
            NetflixPlans netflixPlans = new UltraPlan();
            ViewBag.v1 = netflixPlans.PlanType("Ultra Plan");
            ViewBag.v2 = netflixPlans.CountPerson(4);
            ViewBag.v3 = netflixPlans.Price(129);
            ViewBag.v4 = netflixPlans.Content("Film-Dizi-Belgesel-Fulbol");
            ViewBag.v5 = netflixPlans.Resolution("2040p");
            return View();
        }
    }
}
