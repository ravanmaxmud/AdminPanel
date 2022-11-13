using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Pages.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
