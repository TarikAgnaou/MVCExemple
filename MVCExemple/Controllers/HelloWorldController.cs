using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCExemple.Models;

namespace MVCExemple.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        public IActionResult Identity(string nom, string prenom, int id)
        {
            Identity Identity = new Identity
            {
                Id = id,
                Nom = nom,
                Prenom = prenom
            };

            return View(Identity);
        }
    }
}
