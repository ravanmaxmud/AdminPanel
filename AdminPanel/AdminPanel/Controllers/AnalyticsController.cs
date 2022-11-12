using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class AnalyticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Customers()
        {
            return View();
        }
    }
}
