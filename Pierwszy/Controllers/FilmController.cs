using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pierwszy.Models;

namespace Pierwszy.Controllers
{
    public class FilmController : Controller
    {

        private readonly FilmDbContext _contex;
        public FilmController(FilmDbContext contex)
        {
            _contex = contex;
        }


        //private static IList<Filmy> filmies = new List<Filmy>
        //{
        //    new Filmy(){Id=1,Tytul="Film1", Opis="Opis1",Ocena=3},
        //    new Filmy(){Id=2,Tytul="Film2", Opis="Opis2",Ocena=4},
        //    new Filmy(){Id=3,Tytul="Film3", Opis="Opis3",Ocena=1},

        //};

        // GET: FilmController
        /*public ActionResult Index()
        {
            //return View(filmies);
            return View(_contex.Films.ToList());
        }

        // GET: FilmController/Details/5
        public ActionResult Details(int id)
        {

            // return View(filmies.FirstOrDefault(x=>x.Id==id));
            return View(_contex.Films.Find());
        }

        // GET: FilmController/Create
        public ActionResult Create()
        {
            return View(new Filmy());
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Filmy filmy)
        {
            try
            {
                filmy.Id = filmies.Count + 1;
                filmies.Add(filmy);
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
        public ActionResult Edit(int id, Filmy filmy)
        {
            try
            {
                Filmy film = filmies.FirstOrDefault(x => x.Id == id);
                filmy.Tytul = filmy.Tytul;
                filmy.Opis = filmy.Opis;
                filmy.Ocena = filmy.Ocena;

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
            return View(filmies.FirstOrDefault(x => x.Id == id));
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Filmy filmy)
        {
            try
            {
                Filmy film = filmies.FirstOrDefault(x => x.Id == id);
                filmies.Remove(film);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}
