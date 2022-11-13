using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Pages.Controllers
{
    public class StarterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
