using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
