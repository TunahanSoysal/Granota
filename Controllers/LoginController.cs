using Granota.Data;
using Granota.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Granota.Controllers
{
    public class LoginController : Controller
    {

        private readonly GranotaContext _context;

        public LoginController(GranotaContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("Id,Name,Password,Email,Phone,Address")] Buyer buyer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(buyer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Login));
            }
            return View(buyer);
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
