using Microsoft.AspNetCore.Mvc;

namespace DemoChapt3.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
