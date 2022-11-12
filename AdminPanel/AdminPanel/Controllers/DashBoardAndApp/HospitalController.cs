using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers.DashBoardAndApp
{
    public class HospitalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
