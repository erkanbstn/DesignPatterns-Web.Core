using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Observer.DAL;
using Observer.Models;
using Observer.ObserverPattern;
using System.Threading.Tasks;

namespace Observer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject _observerObject;

        public DefaultController(UserManager<AppUser> userManager, ObserverObject observerObject)
        {
            _userManager = userManager;
            _observerObject = observerObject;
        }

        public IActionResult RegisterIndex()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegisterIndex(RegisterViewModel registerViewModel)
        {
            var appUser = new AppUser()
            {
                Name = registerViewModel.Name,
                Email = registerViewModel.Email,
                Surname = registerViewModel.Surname,
                UserName = registerViewModel.Username
            };
            var result = await _userManager.CreateAsync(appUser,registerViewModel.Password);
            if (result.Succeeded)
            {
                _observerObject.NotifyObserver(appUser);
                return View();
            }
            return View();
        }
    }
}
