using DemoChapt3.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoChapt3.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
