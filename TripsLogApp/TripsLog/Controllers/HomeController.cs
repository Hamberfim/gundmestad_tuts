using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TripsLog.Models;

namespace TripsLog.Controllers
{
    public class HomeController : Controller
    {
        private TripLogContext _context;
        public HomeController(TripLogContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var trips = _context.Trips.ToList();
            return View(trips);
        }


    }
}
