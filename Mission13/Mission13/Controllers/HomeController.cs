using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
                .ToList();

            //Context method
            //var temporaryList = _context.Recipes
            //    .FromSqlRaw("SELECT * FROM Recipes WHERE RecipeTitle LIKE 'a%'")
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
            //b.BowlerID = 0;
            //b.BowlerFirstName = null;
            //b.BowlerMiddleInit = null;
            //b.BowlerLastName = null;
            //b.BowlerAddress = null;
            //b.BowlerCity = null;
            //b.BowlerState = null;
            //b.BowlerZip = null;
            //b.BowlerPhoneNumber = null;

            daContext.Update(b);
            daContext.SaveChanges();

            return RedirectToAction("Manage");
        }

        [HttpGet]
        public IActionResult Add()
        {

            //var addition = daContext.Bowlers.Single(x => x.BowlerID == bowlerid);

            return View();
        }

        [HttpPost]
        public IActionResult Add(Bowler b)
        {

            if (ModelState.IsValid)
            {
                daContext.Update(b);
                daContext.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Bowlers = daContext.Bowlers.ToList();

                return View();
            }
        }

    }
}
