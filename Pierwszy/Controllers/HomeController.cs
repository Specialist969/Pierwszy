using Microsoft.AspNetCore.Mvc;
using NuGet.LibraryModel;
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

        public IActionResult Urodziny(UrodzinyModel urodzinyModel)
        {
            ViewBag.Informacja = $"Witaj {urodzinyModel.Imie} {urodzinyModel.Nazwisko}";
            ViewBag.Informacja2 = $"Masz {DateTime.Now.Year - urodzinyModel.Rok}";

            return View();
        }

        public IActionResult KalkulatorForm()
        {
            return View();
        }

        public IActionResult Wynik(Kalkulator kalkulator)
        {
            int wynik = 0;
            string wynik1 = "";
            //if (kalkulator.Dzialanie == "d") wynik = kalkulator.Liczba1 + kalkulator.Liczba2;
            //if (kalkulator.Dzialanie == "0") wynik = kalkulator.Liczba1 - kalkulator.Liczba2;
            //if (kalkulator.Dzialanie == "m") wynik = kalkulator.Liczba1 * kalkulator.Liczba2;
            //if (kalkulator.Dzialanie == "dz") wynik = kalkulator.Liczba1 / kalkulator.Liczba2;

            switch (kalkulator.Dzialanie)
            {
                case "d":
                     wynik = kalkulator.Liczba1 + kalkulator.Liczba2;
                    break;
                case "o":
                    wynik = kalkulator.Liczba1 - kalkulator.Liczba2;
                    break;
                case "m":                
                        wynik = kalkulator.Liczba1 / kalkulator.Liczba2;

                    break;
                case "dz":
                        wynik = kalkulator.Liczba1 / kalkulator.Liczba2;

                    break;
                default:
                    break;
            }

            
            ViewBag.Wynik = wynik;
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}