using MediaCollection.Data;
using MediaCollection.Domain.Film;
using MediaCollection.Models;
using MediaCollection.Models.Film;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
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
                model.Genres.Add(new CheckboxViewModel() {Naam=item.Genrenaam,Id=item.Id});
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(FilmCreateViewModel model, bool regisseur)
        {
            if (regisseur == true)
            {
                if (string.IsNullOrEmpty(model.RegisseurToevoegen))
                {
                    _context.Regisseurs.Add(new Regisseur() { Naam = model.RegisseurToevoegen });
                    _context.SaveChanges();
                }
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
                using (MemoryStream stream = new MemoryStream())
                {
                    model.Foto.CopyTo(stream);
                    film.Foto= stream.ToArray();
                }
                _context.Films.Add(film);
                _context.SaveChanges();
                foreach (var item in model.SelectedRegisseurs)
                {
                    _context.FilmRegisseurs.Add(new FilmRegisseur() { FilmId = film.Id, RegisseurId = int.Parse(item) });
                }
                foreach (var item in model.Genres.Where(x=>x.Checked==true))
                {
                    _context.FilmGenres.Add(new FilmGenre() { FilmId = film.Id,GenreId=item.Id});
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
            model.Foto = filmFromDb.Foto;
            foreach (var item in filmFromDb.Regisseurs)
            {
                model.Regisseurs.Add(_context.Regisseurs.FirstOrDefault(x => x.Id == item.RegisseurId).Naam);
            }
            foreach (var item in filmFromDb.Genres)
            {
                model.Genres.Add(_context.GenreFilms.FirstOrDefault(y => y.Id == item.GenreId).Genrenaam);
            }
            //model.Reviews = filmFromDb.Reviews.ToList();
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
            model.Foto = filmFromDb.Foto;
            model.Regisseurs = new List<SelectListItem>();
            model.Genres = new List<CheckboxViewModel>();
            foreach (var item in _context.Regisseurs)
            {
                SelectListItem listItem = new SelectListItem(item.Naam, item.Id.ToString());
                model.Regisseurs.Add(listItem);
                if (_context.FilmRegisseurs.Where(x=>x.FilmId==filmFromDb.Id).FirstOrDefault(y=>y.RegisseurId==item.Id)!=null)
                {
                    listItem.Selected = true;
                }
            }
            foreach (var item in _context.GenreFilms)
            {
                model.Genres.Add(new CheckboxViewModel() { Id = item.Id, Naam = item.Genrenaam });
                if (_context.FilmGenres.Where(x => x.FilmId == filmFromDb.Id).FirstOrDefault(y => y.GenreId == item.Id) != null)
                {
                    model.Genres.Last().Checked = true;
                }
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(FilmEditViewModel model,bool regisseur)
        {
            if (string.IsNullOrEmpty(model.RegisseurToevoegen))
            {
                if (model.RegisseurToevoegen != "")
                {
                    _context.Regisseurs.Add(new Regisseur() { Naam = model.RegisseurToevoegen });
                    _context.SaveChanges();
                }
                return RedirectToAction("Create", model);
            }
            else
            {
                Film aanTePassenFilm = _context.Films.FirstOrDefault(x => x.Id == model.Id);
                aanTePassenFilm.Speelduur = model.Speelduur;
                aanTePassenFilm.Titel = model.Titel;
                aanTePassenFilm.Beschrijving = model.Beschrijving;
                if (model.FotoAanpassen != null)
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        model.FotoAanpassen.CopyTo(stream);
                        aanTePassenFilm.Foto = stream.ToArray();
                    }
                }
                _context.FilmGenres.RemoveRange(_context.FilmGenres.Where(x => x.FilmId == model.Id));
                _context.FilmRegisseurs.RemoveRange(_context.FilmRegisseurs.Where(y => y.FilmId == model.Id));
                foreach (var item in model.Genres.Where(c => c.Checked == true))
                {
                    _context.FilmGenres.Add(new FilmGenre() { FilmId = model.Id, GenreId = item.Id });
                }
                foreach (var item in model.SelectedRegisseurs)
                {
                    _context.FilmRegisseurs.Add(new FilmRegisseur() { FilmId = model.Id, RegisseurId = int.Parse(item) });
                }
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = model.Id });
            }
        }
    }
}
