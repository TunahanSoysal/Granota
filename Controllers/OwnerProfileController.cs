using Granota.Data;
using Granota.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;

namespace Granota.Controllers
{
    public class OwnerProfileController : Controller
    {

        private readonly GranotaContext _context;

        public OwnerProfileController(GranotaContext context)
        {
            _context = context;
        }
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> owner_management([Bind("ProductName,ProductDescription,ProductPrice")] Products products)
        {
            if (ModelState.IsValid)
            {
                _context.Add(products);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(owner_profile));
            }
            return View(products);
        }
    }
}
