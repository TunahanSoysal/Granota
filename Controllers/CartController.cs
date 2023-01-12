using Microsoft.AspNetCore.Mvc;

namespace Granota.Controllers
{
    public class CartController : Controller
    {
        public IActionResult cart()
        {
            return View();
        }
    }
}
