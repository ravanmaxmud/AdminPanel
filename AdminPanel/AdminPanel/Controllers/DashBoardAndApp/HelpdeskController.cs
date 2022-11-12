using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers.DashBoardAndApp
{
    public class HelpdeskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
