﻿using Microsoft.AspNetCore.Mvc;

namespace Task.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
