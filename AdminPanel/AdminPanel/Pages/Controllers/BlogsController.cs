﻿using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Pages.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
