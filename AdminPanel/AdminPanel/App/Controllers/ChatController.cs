using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.App.Controllers
{

    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
