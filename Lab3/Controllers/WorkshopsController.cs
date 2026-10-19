using Microsoft.AspNetCore.Mvc;
using Lab3.Models;
using System.Collections.Generic;

namespace Lab3.Controllers
{
    public class WorkshopsController : Controller
    {
        private static List<Rsvp> registrations = new List<Rsvp>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Confirm(Rsvp model)
        {
            registrations.Add(model);

            ViewData["Message"] =
                "Thanks for registering, " + model.FullName + "!";

            return View(model);
        }

        public IActionResult Registrations()
        {
            return View(registrations);
        }
    }
}
