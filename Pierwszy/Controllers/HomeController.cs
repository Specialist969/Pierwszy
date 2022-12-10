using Microsoft.AspNetCore.Mvc;
using Pierwszy.Models;
using System.Diagnostics;

namespace Pierwszy.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            ViewBag.Powitanie = "To jest informacja z Kontrolera";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Imie = "Paweł";
            //ViewBag.Godzina = DateTime.Now.Hour;
            ViewBag.godzina = DateTime.Now.Hour;
            ViewBag.info = ViewBag.godzina > 18 ? "Dobry Wierczór" : "Dobry Dzień";

            DaneModel[] osoby =
            {
                new DaneModel{Imię="Paweł",Nazwisko="Musiał"},
                new DaneModel{Imię="Piotr",Nazwisko="Nowak"},
                new DaneModel{Imię="Adam",Nazwisko="Miłek"}
            };

            return View(osoby);
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}