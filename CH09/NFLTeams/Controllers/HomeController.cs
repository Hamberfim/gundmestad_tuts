using Microsoft.AspNetCore.Mvc;
using NFLTeams.Models;
using System.Text.Json;

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
        //public ViewResult Index(string activeConf = "all", string activeDiv = "all")
        public ViewResult Index(TeamViewModel model)
        {
            //Team team = new Team { TeamID = "sea", Name = "Seattle Seahawks" };
            //string teamJson = JsonSerializer.Serialize(team);
            //// set the session variable
            //HttpContext.Session.SetString("team", teamJson);
            var teams = HttpContext.Session.GetObject<List<Team>>("teams") ?? new List<Team>();
            teams.Add(new Team { TeamID = "gb", Name = "Green Bay Packers" });
            teams.Add(new Team { TeamID = "sea", Name = "Seatle Seahawks" });
            // write the session variable as list of teams
            HttpContext.Session.SetObject("teams", teams);

            // storing selected conf and div ID's in view bag
            //ViewBag.ActiveConf = activeConf;
            //ViewBag.ActiveDiv = activeDiv;

            // using Team View Mode instead of ViewBag
            model.Conferences = context.Conferences.ToList();
            model.Divisions = context.Divisions.ToList();

            // storing conf/div from db into view bag
            ViewBag.Conferences = context.Conferences.ToList();
            ViewBag.Divisions = context.Divisions.ToList();

            // get teams and filter by con/div
            //IQueryable<Team> query = context.Teams.OrderBy(t => t.Name);
            //if(activeConf != "all")
            //{
            //    query = query.Where(t => t.Conference.ConferenceID.ToLower() == activeConf.ToLower());
            //}

            //if (activeDiv != "all")
            //{
            //    query = query.Where(t => t.Division.DivisionID.ToLower() == activeDiv.ToLower());
            //}

            //var teams = query.ToList();  // execute the query
            //return View(teams);

            // using Team View Model replacing above IQerable
            IQueryable<Team> query = context.Teams.OrderBy(t => t.Name);
            if (model.ActiveConf != "all")
            {
                query = query.Where(t => t.Conference.ConferenceID.ToLower() == model.ActiveConf.ToLower());
            }

            if (model.ActiveDiv != "all")
            {
                query = query.Where(t => t.Division.DivisionID.ToLower() == model.ActiveDiv.ToLower());
            }

            model.Teams = query.ToList();  // execute the query
            return View(model);
        }


    }
}
