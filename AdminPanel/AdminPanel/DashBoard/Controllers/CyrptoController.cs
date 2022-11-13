using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{

    public class CyrptoController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
        public IActionResult Exchange()
        {
            return View();
        }
        public IActionResult Wallet()
        {
            return View();
        }
    }
}
