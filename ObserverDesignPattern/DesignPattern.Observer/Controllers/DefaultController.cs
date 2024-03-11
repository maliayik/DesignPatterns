using DesignPattern.Observer.DAL;
using DesignPattern.Observer.Models;
using DesignPattern.Observer.ObserverPattern;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverOBject _observerOBject;

        public DefaultController(UserManager<AppUser> userManager, ObserverOBject observerOBject)
        {
            _userManager = userManager;
            _observerOBject = observerOBject;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            var appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                UserName = model.Username
            };
            var result = await _userManager.CreateAsync(appUser, model.Password);
            if(result.Succeeded)
            {
                _observerOBject.NotifyObserver(appUser);
                return View();
            }
            return View();
        }
    }
}
