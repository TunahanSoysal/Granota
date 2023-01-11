using Microsoft.AspNetCore.Mvc;

namespace Granota.Controllers
{
    public class OwnerProfileController : Controller
    {
        public IActionResult owner_orderHistory()
        {
            return View();
        }
        public IActionResult owner_profile()
        {
            return View();
        }
        public IActionResult owner_settings()
        {
            return View();
        }
        public IActionResult owner_management()
        {
            return View();
        }
    }
}
