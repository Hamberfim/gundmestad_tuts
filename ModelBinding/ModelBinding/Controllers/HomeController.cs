using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        /* model binding is a process of mapping the HTTP request data coming from the client to the action method parameters. */
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Three ways to bind data to an action method parameter and it's also the order in which the model binder looks for data
        // 1. HTTP body of a post request
        [HttpPost]
        public IActionResult Index(Record record)
        {
            return View(record);
        }

        // bind only the id and name properties of the Musician object but not the description property
        [HttpPost]
        public IActionResult AddMusician([Bind("Id", "Name")]Musician m)
        {
            return Content($"The musician id is {m.Id} and the name is {m.Name}.");
        }

        // 2 and 3 are interchangeable
        // 2. The Route values in the url (via get)
        [Route("/records/{id?}/{name?}")]
        public IActionResult GetRecord(Record r)
        {
            // route example -> /records/2/SomeRecord
            return Content($"The record id is {r.Id} and the name is {r.Name}.");
        }

        // 3. The Query string parameters in the url
        [Route("/query/{id?}/{name?}")]
        public IActionResult QueryRecord(Record r)
        {
            // route example -> /query?id=12&name=someRecord
            return Content($"The queried record id is {r.Id} and the name is {r.Name}.");
        }

        // binding to an array
        [HttpPost]
        public IActionResult AddData(string[] studentNames)
        {
            string results = "";
            foreach (var name in studentNames)
            {
                results += name + " ";
            }
            return Content(results);
        }

    }
}
