using DemoChapt3;
using DemoChapt3.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoChapt3.Controllers
{
    public class MPGController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.MilesDriven = 0;
            ViewBag.GallonsUsed = 0;
            ViewBag.MPG = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(MPG driverStats)
        {
            ViewBag.MPG = driverStats.CalcMpg();
            ViewBag.MilesDriven = driverStats.MilesDriven;
            ViewBag.GallonsUsed = driverStats.GallonsUsed;
            return View(driverStats);
        }
    }
}

