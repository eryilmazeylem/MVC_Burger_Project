﻿using Microsoft.AspNetCore.Mvc;

namespace MVC_Project_Group_4.Areas.YoneticiPaneli.Controllers
{
    [Area("YoneticiPaneli")]
    public class HamburgerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hamburgerler()
        {
            return View();
        }
    }
}
