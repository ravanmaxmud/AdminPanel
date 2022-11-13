using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Pages.Controllers
{
    public class TimelineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
