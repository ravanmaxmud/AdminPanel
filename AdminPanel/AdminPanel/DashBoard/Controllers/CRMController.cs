using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{

    public class CRMController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
