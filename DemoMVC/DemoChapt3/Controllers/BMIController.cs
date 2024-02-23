using DemoChapt3.Models;
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

        [HttpPost]
        public IActionResult Index(BMI userBMI)
        {   
            ViewBag.Height = userBMI.Height;
            ViewBag.Weight = userBMI.Weight;
            ViewBag.BMI = userBMI.CalcBmi();
            ViewBag.Category = userBMI.GetCategory();
            return View(userBMI);
        }
    }
}
