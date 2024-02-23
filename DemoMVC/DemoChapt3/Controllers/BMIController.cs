using Microsoft.AspNetCore.Mvc;

namespace DemoChapt3.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Height = 0;
            ViewBag.Weight = 0;
            ViewBag.BMI = 0;
            return View();
        }
    }
}
