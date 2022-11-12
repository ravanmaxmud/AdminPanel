using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
