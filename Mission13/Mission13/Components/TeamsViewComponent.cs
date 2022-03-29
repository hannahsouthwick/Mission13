using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mission13.Models;

namespace Mission13.Components
{
    public class TeamsViewComponent : ViewComponent
    {
        //private IBowlersRepository repo { get; set }

        //public TeamsViewComponent (IBowlersRepository temp)
        //{
        //    repo = temp;
        //}

        //Loads a dataset
        private BowlersDbContext daContext { get; set; }

        public TeamsViewComponent (BowlersDbContext temp)
        {
            daContext = temp;
        }

        public IViewComponentResult Invoke()
        {
            //grabbing something from the URL and it might be null ?
            ViewBag.SelectedTeam = RouteData?.Values["teamName"];

            var teams = daContext.Teams
                .Select(x => x.TeamName)
                .Distinct()
                .OrderBy(x => x);

            return View(teams);
        }
    }
}
