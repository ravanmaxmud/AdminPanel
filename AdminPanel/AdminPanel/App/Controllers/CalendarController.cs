using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.App.Controllers
{

    public class CalendarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
