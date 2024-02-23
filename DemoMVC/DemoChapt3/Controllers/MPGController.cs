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
            return View();
        }

        [HttpPost]
        public IActionResult Index(MPGController driverStats)
        {
            return View(driverStats);
        }
    }
}

