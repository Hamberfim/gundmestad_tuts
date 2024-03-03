using Microsoft.AspNetCore.Mvc;
using TripsLog.Models;

namespace TripsLog.Controllers
{
    public class TripController : Controller
    {
        private readonly TripLogContext _context;

        public TripController(TripLogContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Add(string id = "")
        {
            var tripViewModel = new TripViewModel();
            // based on the value of id, send the user to different views
            switch (id)
            {
                case "1":
                    tripViewModel.PageNumber = 1;
                    return View("Add1", tripViewModel);
                case "2":
                    tripViewModel.PageNumber = 2;
                    return View("Add2", tripViewModel);
                case "3":
                    tripViewModel.PageNumber = 3;
                    return View("Add3", tripViewModel);
                default:
                    return View("Index", "Home");
            }

        }
        [HttpPost]
        public IActionResult Add(TripViewModel tripViewModel)
        {
            if (tripViewModel.PageNumber == 1)
            {
                if (ModelState.IsValid)
                {
                    TempData["Destination"] = tripViewModel.Trip.Destination;
                    TempData["Accomodation"] = tripViewModel.Trip.Accomodation;
                    TempData["StartDate"] = tripViewModel.Trip.StartDate;
                    TempData["EndDate"] = tripViewModel.Trip.EndDate;
                    return RedirectToAction("Add", new { id = "2" });
                }else { return View("Add1", tripViewModel); }
            }
            else if (tripViewModel.PageNumber == 2)
            {
                TempData["AccomodationsPhone"] = tripViewModel.Trip.AccomodationsPhone;
                TempData["AccomodationsEmail"] = tripViewModel.Trip.AccomodationsEmail;
                return RedirectToAction("Add", new { id = "3" });
            }
            else
            {
                Trip trip = new Trip()
                {
                    Destination = TempData["Destination"].ToString(),
                    Accomodation = TempData["Accomodation"].ToString(),
                    StartDate = (System.DateTime)TempData["StartDate"],
                    EndDate = (System.DateTime)TempData["EndDate"],
                    AccomodationsPhone = TempData["AccomodationsPhone"].ToString(),
                    AccomodationsEmail = TempData["AccomodationsEmail"].ToString(),
                    Activity1 = tripViewModel.Trip.Activity1,
                    Activity2 = tripViewModel.Trip.Activity2,
                    Activity3 = tripViewModel.Trip.Activity3,
                };
                _context.Trips.Add(trip);
                _context.SaveChanges();

            }

            return RedirectToAction(actionName: "Index", controllerName: "Home");
        }
    }
}
