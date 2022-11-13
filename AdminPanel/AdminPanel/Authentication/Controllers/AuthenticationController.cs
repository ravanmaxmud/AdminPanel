using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Authentication.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
