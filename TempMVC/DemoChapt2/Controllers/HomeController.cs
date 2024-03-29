﻿using Microsoft.AspNetCore.Mvc;
using DemoChapt2.Models;

namespace DemoChapt2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // .FV is a dynamic property
            ViewBag.FV = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateFutureValue();
            }
            else
            {
                ViewBag.FV = 0;
            }

            return View(model);
        }
    }
}
