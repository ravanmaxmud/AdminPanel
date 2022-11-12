using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class HospitalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
