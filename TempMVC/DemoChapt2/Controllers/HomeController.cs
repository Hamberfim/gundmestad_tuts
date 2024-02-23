using Microsoft.AspNetCore.Mvc;

namespace DemoChapt2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // .name is a dynamic property
            ViewBag.Name = "Anthony";
            ViewBag.FV = 9999.99;
            ViewBag.Age = 57;
            return View();
        }
    }
}
