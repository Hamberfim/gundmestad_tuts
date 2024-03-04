using Demo1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Read/get session variable called num
            int num = HttpContext.Session.GetInt32("num") ?? 0;  // error - can't be nullable
            num += 1;
            // store/set session state back into the variable called num
            HttpContext.Session.SetInt32("num", num);
            return View();
        }
    }
}
