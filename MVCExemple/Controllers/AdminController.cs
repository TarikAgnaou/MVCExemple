using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCExemple.Models;

namespace MVCExemple.Controllers
{
    public class AdminController : Controller
    {
        private List<Menu> _menu = new List<Menu>();
        public AdminController()
        {
            _menu.Add(new Menu
            {
                Icone = "fa fa-desktop",
                Nom = "Dashbord",
                Controller = "Admin",
                Methode = "Index"
            });
            _menu.Add(new Menu
            {
                Icone = "fa fa-home",
                Nom = "Modifier l'accueil",
                Controller = "Admin",
                Methode = "Index"
            });
            _menu.Add(new Menu
            {
                Icone = "fa fa-users",
                Nom = "Gérer les inscriptions",
                Controller = "Admin",
                Methode = "Index"
            });
            _menu.Add(new Menu
            {
                Icone = "fa fa-calendar",
                Nom = "Agenda",
                Controller = "Admin",
                Methode = "Index"
            });
            _menu.Add(new Menu
            {
                Icone = "fa fa-cubes",
                Nom = "Gérer les packs",
                Controller = "Admin",
                Methode = "Index"
            });
            _menu.Add(new Menu
            {
                Icone = "fa fa-film",
                Nom = "Gérer les vidéos",
                Controller = "Admin",
                Methode = "Index"
            });
            _menu.Add(new Menu
            {
                Icone = "fab fa-android",
                Nom = "Gérer l'application",
                Controller = "Admin",
                Methode = "Index"
            });
        }
        public IActionResult Index()
        {
            ViewData["Menu"] = _menu;
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}