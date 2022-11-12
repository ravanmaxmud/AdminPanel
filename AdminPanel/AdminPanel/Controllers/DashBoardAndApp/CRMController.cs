using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers.DashBoardAndApp
{
    public class CRMController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
