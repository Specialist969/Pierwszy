using Filmy_5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Filmy_5.Controllers
{
    public class FilmController : Controller
    {
        private static IList<Film> filmies = new List<Film>
        {
            new Film(){ID=1, Tytul="Batman", Opis="opis1", Ocena=5 },
            new Film(){ID=2, Tytul="Avatar", Opis="opis2", Ocena=5 },
            new Film(){ID=3, Tytul="Superman", Opis="opis3", Ocena=5 },
        };
        // GET: FilmController
        public ActionResult Index()
        {
            return View(filmies);
        }

        // GET: FilmController/Details/5
        public ActionResult Details(int id)
        {
            return View(filmies.FirstOrDefault(x => x.ID == id));
        }

        // GET: FilmController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            try
            {
                film.ID = filmies.Count + 1;
                filmies.Add(film);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(filmies.FirstOrDefault(x=>x.ID == id));
        }

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Film film)
        {
            try
            {
                Film filmy = filmies.FirstOrDefault(x => x.ID == id);
                filmy.Tytul = film.Tytul;
                filmy.Opis = film.Opis;
                filmy.Ocena = film.Ocena;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FilmController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(filmies.FirstOrDefault(x => x.ID == id));
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Film film)
        {
            try
            {   
                filmies.Remove(film);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
