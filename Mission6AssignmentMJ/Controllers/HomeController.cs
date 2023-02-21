using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6AssignmentMJ.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6AssignmentMJ.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext MeContext { get; set; }

        public HomeController(MovieContext someName)
        {
            MeContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Categories = MeContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Movies(MovieEntry me)
        {
            if (ModelState.IsValid)
            {
                MeContext.Add(me);
                MeContext.SaveChanges();
                return View("Confirmation", me);
            }
            else
            {
                ViewBag.Categories = MeContext.Categories.ToList();

                return View(me);
            }
        }

        public IActionResult AllEntry ()
        {
            var allEntries = MeContext.MovieEntries.Include(x => x.Category).ToList();
            return View(allEntries);
        }

        [HttpGet]
        public IActionResult Edit (int entryid)
        {
            ViewBag.Categories = MeContext.Categories.ToList();

            var movie = MeContext.MovieEntries.Single(x => x.EntryID == entryid);
            return View("Movies", movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieEntry yee)
        {
            MeContext.Update(yee);
            MeContext.SaveChanges();

            return RedirectToAction("AllEntry");
        }
        
        [HttpGet]
        public IActionResult Delete(int entryid)
        {
            var movie = MeContext.MovieEntries.Single(x => x.EntryID == entryid);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(MovieEntry blah)
        {
            MeContext.MovieEntries.Remove(blah);
            MeContext.SaveChanges();

            return RedirectToAction("AllEntry");
        }

    }
}
