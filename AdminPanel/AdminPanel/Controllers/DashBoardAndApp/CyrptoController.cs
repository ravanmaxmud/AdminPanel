using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers.DashBoardAndApp
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
    }
}
