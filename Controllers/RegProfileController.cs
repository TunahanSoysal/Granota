using Microsoft.AspNetCore.Mvc;

namespace Granota.Controllers
{
    public class RegProfileController : Controller
    {
        public IActionResult reg_profile()
        {
            return View();
        }
        public IActionResult reg_orderHistory()
        {
            return View();
        }
        public IActionResult reg_settings()
        {
            return View();
        }
    }
}
