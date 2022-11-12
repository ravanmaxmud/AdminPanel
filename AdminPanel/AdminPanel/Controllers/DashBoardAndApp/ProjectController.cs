using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers.DashBoardAndApp
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
