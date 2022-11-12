using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.DashBoard.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
