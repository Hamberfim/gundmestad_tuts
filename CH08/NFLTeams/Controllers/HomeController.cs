using Microsoft.AspNetCore.Mvc;
using NFLTeams.Models;
using System.Diagnostics;

namespace NFLTeams.Controllers
{
    public class HomeController : Controller
    {
        // add DB context
        private TeamContext context;

        public HomeController(TeamContext ctx)
        {
            context = ctx;
        }

        // change data type from IActionResult to ViewResult
        public ViewResult Index(string activeConf = "all", string activeDiv = "all")
        {
            // storing selected conf and div ID's in view bag
            ViewBag.ActiveConf = activeConf;
            ViewBag.ActiveDiv = activeDiv;

            // storing conf/div from db into view bag
            ViewBag.Conferences = context.Conferences.ToList();
            ViewBag.Divisions = context.Divisions.ToList();

            // get teams and filter by con/div
            IQueryable<Team> query = context.Teams.OrderBy(t => t.Name);
            if(activeConf != "all")
            {
                query = query.Where(t => t.Conference.ConferenceID.ToLower() == activeConf.ToLower());
            }

            if (activeDiv != "all")
            {
                query = query.Where(t => t.Division.DivisionID.ToLower() == activeDiv.ToLower());
            }

            var teams = query.ToList();
            return View(teams);
        }

        
    }
}
