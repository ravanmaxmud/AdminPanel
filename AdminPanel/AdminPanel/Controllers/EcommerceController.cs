﻿using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class EcommerceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
