using Microsoft.AspNetCore.Mvc;

namespace Granota.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Forget_password()
        {
            return View();
        }
        public IActionResult Reset_password()
        {
            return View();
        }
    }
}
