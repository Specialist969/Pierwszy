using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pierwszy.Models;

namespace Pierwszy.Controllers
{
    public class FilmController : Controller
    {
        private static IList<Filmy> filmies = new List<Filmy>
        {
            new Filmy(){Id=1,Tytul="Film1", Opis="Opis1",Ocena=3},
            new Filmy(){Id=2,Tytul="Film2", Opis="Opis2",Ocena=6},
            new Filmy(){Id=3,Tytul="Film3", Opis="Opis3",Ocena=2},

        };

        // GET: FilmController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FilmController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FilmController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
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
            return View();
        }

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
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
            return View();
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
