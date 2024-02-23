using Microsoft.AspNetCore.Mvc;

namespace DemoChapt3.Controllers
{
    public class MPGController1 : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.MilesDriven = 0;
            ViewBag.GallonsUsed = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(MPGController1 driverStats)
        {
            return View(driverStats);
        }
    }
}
}
