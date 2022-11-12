using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class ContractListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
