using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers.DashBoardAndApp
{
    public class EcommerceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
