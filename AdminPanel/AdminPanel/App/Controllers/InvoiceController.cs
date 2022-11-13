using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.App.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
