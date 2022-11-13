using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Pages.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
