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
        public HomeController(IBowlersRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            //repository method
            var temporaryList = _repo.Bowlers
                //.Where(x => x.Team == bowlerTeam || bowlerTeam == null)
                .Include(x => x.Team)
                .OrderBy(x => x.BowlerLastName)
                .ToList();

            //Context method
            //var temporaryList = daContext.Bowlers
            //    .FromSqlRaw("SELECT * FROM Bowlers INNER JOIN Teams on Bowlers.BowlerID = Teams.TeamID")
            //    //.Where(x => x.Team == bowlerTeam || bowlerTeam == null)
            //    .OrderBy(x => x.BowlerLastName)
            //    .ToList();

            return View(temporaryList);
        }

        public IActionResult Manage()
        {
            var temporaryList = _repo.Bowlers
                .ToList();

            return View(temporaryList);
        }

        [HttpGet]
        public IActionResult Edit(int bowlerid)
        {
            var addition = daContext.Bowlers.Single(x => x.BowlerID == bowlerid);

            return View("Manage", addition);
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

            daContext.Update(b);
            daContext.SaveChanges();

            return RedirectToAction("Manage");
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Teams = daContext.Teams.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Add(Bowler b)
        {

            if (ModelState.IsValid)
            {
                daContext.Add(b);
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
