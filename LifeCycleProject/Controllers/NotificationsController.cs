﻿using Microsoft.AspNetCore.Mvc;

namespace LifeCycleProject.Controllers
{
    public class NotificationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
