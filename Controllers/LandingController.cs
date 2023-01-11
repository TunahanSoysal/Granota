using Microsoft.AspNetCore.Mvc;

namespace Granota.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult Landing_reg()
        {
            return View();
        }
        public IActionResult Landing_nonReg()
        {
            return View();
        }
        public IActionResult HomePage()
        {
            return View();
        }
        public IActionResult HomePage_admin()
        {
            return View();
        }
        public IActionResult Restaurant_menu()
        {
            return View();
        }
    }
}
