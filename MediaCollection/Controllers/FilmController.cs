using MediaCollection.Data;
using MediaCollection.Domain.Film;
using MediaCollection.Models.Film;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Controllers
{
    public class FilmController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FilmController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<FilmListViewModel> films = new List<FilmListViewModel>();
            foreach (var item in _context.Films)
            {
                FilmListViewModel film = new FilmListViewModel();
                film.Id = item.Id;
                film.Titel = item.Titel;
                if (_context.FilmReviews.Where(c => c.FilmId == item.Id).Count() != 0)
                {
                    film.Score = _context.FilmReviews.Where(x => x.FilmId == item.Id).Select(y => y.Score).Sum() / _context.FilmReviews.Where(y => y.FilmId == item.Id).Count();

                }
                else film.Score = 0;
                films.Add(film);
            }
            return View(films);
        }
        public IActionResult Create(FilmCreateViewModel modelInput)
        {

            FilmCreateViewModel model = modelInput;
            model.Genres = new List<CheckboxViewModel>();
            foreach (var item in _context.Regisseurs)
            {
                model.Regisseurs.Add(new SelectListItem(item.Naam, item.Id.ToString()));
            }
            foreach (var item in _context.GenreFilms)
            {
                model.Genres.Add(new CheckboxViewModel() {Naam=item.Genrenaam});
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(FilmCreateViewModel model, int id)
        {
            if (id == 1)
            {
                _context.Regisseurs.Add(new Regisseur() { Naam = model.RegisseurToevoegen });
                _context.SaveChanges();
                return RedirectToAction("Create", model);
            }
            else
            {
                Film film = new Film()
                {
                    Titel = model.Titel,
                    Speelduur = model.Speelduur,
                    Beschrijving = model.Beschrijving
                };
                _context.Films.Add(film);
                _context.SaveChanges();
                foreach (var item in model.SelectedRegisseurs)
                {
                    _context.FilmRegisseurs.Add(new FilmRegisseur() { FilmId = film.Id, RegisseurId = int.Parse(item) });
                }
                foreach (var item in model.Genres.Where(x=>x.Checked==true))
                {
                    _context.FilmGenres.Add(new FilmGenre() { FilmId = film.Id});
                }
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
        public IActionResult Details(int id)
        {
            FilmDetailViewModel model = new FilmDetailViewModel();
            Film filmFromDb = _context.Films.Include(film => film.Reviews).Include(reg=>reg.Regisseurs).Include(genre=>genre.Genres).FirstOrDefault(x => x.Id == id);
            model.Id = filmFromDb.Id;
            model.Titel = filmFromDb.Titel;
            model.Beschrijving = filmFromDb.Beschrijving;
            model.Speelduur = filmFromDb.Speelduur;
            foreach (var item in filmFromDb.Regisseurs)
            {
                model.Regisseurs.Add(_context.Regisseurs.FirstOrDefault(x => x.Id == item.RegisseurId).Naam);
            }
            foreach (var item in filmFromDb.Genres)
            {
                model.Genres.Add(_context.GenreFilms.FirstOrDefault(y => y.Id == item.GenreId).Genrenaam);
            }
            model.Reviews = filmFromDb.Reviews.ToList();
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            _context.Films.Remove(_context.Films.FirstOrDefault(x => x.Id == id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            FilmEditViewModel model = new FilmEditViewModel();
            Film filmFromDb = _context.Films.Include(genre=>genre.Genres).Include(reg=>reg.Regisseurs).FirstOrDefault(x => x.Id == id);
            model.Id = filmFromDb.Id;
            model.Speelduur = filmFromDb.Speelduur;
            model.Beschrijving = filmFromDb.Beschrijving;
            model.Titel = filmFromDb.Titel;
            model.Regisseurs = new List<SelectListItem>();
            model.Genres = new List<SelectListItem>();
            foreach (var item in _context.Regisseurs)
            {
                model.Regisseurs.Add(new SelectListItem(item.Naam, item.Id.ToString()));
                if (_context.FilmRegisseurs.Where(x=>x.FilmId==filmFromDb.Id).FirstOrDefault(y=>y.RegisseurId==item.Id)!=null)
                {
                    model.Regisseurs.Last().Selected = true;
                }
            }
            foreach (var item in _context.GenreFilms)
            {
                model.Genres.Add(new SelectListItem(item.Genrenaam, item.Id.ToString()));
                if (_context.FilmGenres.Where(x => x.FilmId == filmFromDb.Id).FirstOrDefault(y => y.GenreId == item.Id) != null)
                {
                    model.Genres.Last().Selected = true;
                }
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(FilmEditViewModel model)
        {
            Film aanTePassenFilm = _context.Films.FirstOrDefault(x => x.Id == model.Id);
            aanTePassenFilm.Speelduur = model.Speelduur;
            aanTePassenFilm.Titel = model.Titel;
            aanTePassenFilm.Beschrijving = model.Beschrijving;
            _context.SaveChanges();
            return RedirectToAction("Details", new { id = model.Id });
        }
        public IActionResult CreateRegisseur()
        {
            return View();
        }
    }
}
