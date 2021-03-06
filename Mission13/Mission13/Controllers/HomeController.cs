using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission13.Models;

namespace Mission13.Controllers
{
    public class HomeController : Controller
    {
        private BowlersDbContext daContext { get; set; }

        private IBowlersRepository _repo { get; set; }

        //Constructor
        //public HomeController(IBowlersRepository temp)
        //{
        //    _repo = temp;
        //}

        public HomeController(BowlersDbContext temp)
        {
            daContext = temp;
        }

        public IActionResult Index(string teamName)
        {
            ViewBag.name = RouteData?.Values["teamName"];
            ////repository method
            //var temporaryList = _repo.Bowlers
            //    //.Where(x => x.Team == bowlerTeam || bowlerTeam == null)
            //    .Include(x => x.Team)
            //    .OrderBy(x => x.BowlerLastName)
            //    .ToList();

            //Context method
            var temporaryList = daContext.Bowlers
                .FromSqlRaw("SELECT * FROM Bowlers")
                .Include(x => x.Team)
                .Where(t => t.Team.TeamName == teamName || teamName == null)
                .OrderBy(x => x.BowlerLastName)
                .ToList();

            return View(temporaryList);
        }

        public IActionResult Manage()
        {
            var temporaryList = daContext.Bowlers
                .ToList();

            return View(temporaryList);
        }

        [HttpGet]
        public IActionResult Edit(int bowlerid)
        {
            var addition = daContext.Bowlers.Single(x => x.BowlerID == bowlerid);
            ViewBag.Teams = daContext.Teams.ToList();
            ViewBag.form = "edit";

            return View("Add", addition);
        }

        [HttpPost]
        public IActionResult Edit(Bowler b)
        {
            daContext.Update(b);
            daContext.SaveChanges();

            return RedirectToAction("Manage");
        }

        [HttpGet]
        public IActionResult Delete(int bowlerid)
        {
            var addition = daContext.Bowlers.Single(x => x.BowlerID == bowlerid);

            return View(addition);
        }

        [HttpPost]
        public IActionResult Delete(Bowler b)
        {
            daContext.Remove(b);
            daContext.SaveChanges();

            return RedirectToAction("Manage");
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Teams = daContext.Teams.ToList();
            ViewBag.form = "add";

            return View();
        }

        [HttpPost]
        public IActionResult Add(Bowler b)
        {

            if (ModelState.IsValid)
            {
                if (b.BowlerID == 0) { 
                    daContext.Add(b);
                }
                else
                {
                    daContext.Update(b);

                }
                daContext.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Teams = daContext.Teams.ToList();

                return View();
            }
        }

    }
}
