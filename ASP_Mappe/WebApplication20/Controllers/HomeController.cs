using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication20.Models;

namespace WebApplication20.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Formular()
            
        {
            //Formular wird zum Clienten geschickt => user soll seine Daten eingeben und sie verschicken
            return View();
        }

       /*public string VerarbeiteFormularGET()
        {
            string vorname = HttpContext.Request.Query["vorname"];
            string nachname = HttpContext.Request.Query["nachname"];
            int alter =Convert.ToInt32( HttpContext.Request.Query["alter"]);
            int telefon =Convert.ToInt32 (HttpContext.Request.Query["telefon"]);
           

            // return "Antwort vom Server: " + "Sie heißen " + vorname +"!";
           return Json(new { vorname = vorname, nachname = nachname, alter = alter, telefon = telefon, });
        } */

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
