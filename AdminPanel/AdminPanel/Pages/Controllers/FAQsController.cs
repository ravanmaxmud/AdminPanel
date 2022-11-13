using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Pages.Controllers
{
    public class FAQsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
