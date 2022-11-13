using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{

    public class HelpdeskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
