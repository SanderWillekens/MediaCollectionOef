using MediaCollection.Data;
using MediaCollection.Domain.Muziek;
using MediaCollection.Models;
using MediaCollection.Models.Muziek;
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
    public class MuziekController:Controller
    {
        private readonly ApplicationDbContext _context;

        public MuziekController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<AlbumListViewModel> model = new List<AlbumListViewModel>();
            foreach (var item in _context.Albums.Include(x=>x.Nummers))
            {
                model.Add(new AlbumListViewModel() { Id = item.Id,Foto=item.AlbumFoto, Naam = item.Naam,
                    AantalNummers =_context.NummerAlbums.Where(y=>y.AlbumId==item.Id).Count()});
            }
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AlbumCreateViewModel model)
        {
            Album album = new Album
            {
                Naam = model.Naam
            };
            using (MemoryStream stream = new MemoryStream())
            {
                model.Foto.CopyTo(stream);
                album.AlbumFoto = stream.ToArray();
            }
            _context.Albums.Add(album);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Detail(int id)
        {
            Album albumFromDb = _context.Albums.Include(album=>album.Nummers).FirstOrDefault(x => x.Id == id);
            AlbumDetailViewModel model = new AlbumDetailViewModel() { Id = id, Naam = albumFromDb.Naam, Foto = albumFromDb.AlbumFoto };
            foreach (var item in albumFromDb.Nummers)
            {
                Nummer nummer = _context.Nummers.Include(x=>x.NummerReviews).FirstOrDefault(x => x.Id == item.NummerId);
                model.Nummers.Add(new NummerListViewModel() { Titel=nummer.Naam,Id=nummer.Id,Score=0 });
                if (nummer.NummerReviews.Count!=0)
                {
                    model.Nummers.Last().Score = nummer.NummerReviews.Select(n => n.Score).Sum() / nummer.NummerReviews.Count;
                }
            }
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            Album album = _context.Albums.Include(x => x.Nummers).FirstOrDefault(y => y.Id == id);
            AlbumEditViewModel model = new AlbumEditViewModel() { Foto = album.AlbumFoto, Naam = album.Naam,Id=id };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(AlbumEditViewModel model,int id)
        {
            Album album = _context.Albums.FirstOrDefault(y => y.Id == id);
            album.Naam = model.Naam;
            if (model.FotoAanpassen!=null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    model.FotoAanpassen.CopyTo(stream);
                    album.AlbumFoto = stream.ToArray();
                }
            }
            _context.SaveChanges();
            return RedirectToAction("Detail", new { id = model.Id });
        }
        public IActionResult Delete(int id)
        {
            Album album = _context.Albums.Include(nummer=>nummer.Nummers).FirstOrDefault(x => x.Id == id);
            _context.NummerAlbums.RemoveRange(_context.NummerAlbums.Where(y => y.AlbumId == id));
            foreach (var item in album.Nummers)
            {
                _context.Nummers.Remove(_context.Nummers.FirstOrDefault(y=>y.Id==item.NummerId));
            }
            _context.Albums.Remove(album);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult AddNummer(int id,NummerCreateViewModel ingegevenModel)
        {
            NummerCreateViewModel model = new NummerCreateViewModel();
            if (ingegevenModel==null)
            {
                model = ingegevenModel;
                id = model.AlbumId;
            }
            else
            {
                foreach (var item in _context.GenreNummers)
                {
                    model.Genres.Add(new CheckboxViewModel() { Id = item.Id, Naam = item.Naam });
                }
            }
            foreach (var item in _context.Artiesten)
            {
                model.Artisten.Add(new SelectListItem() { Text = item.Naam, Value = item.Id.ToString() });
            }
            model.AlbumId = id;
            return View(model);
        }
        [HttpPost]
        public IActionResult AddNummer(NummerCreateViewModel model,bool artist,int id)
        {
            if (artist == true)
            {
                model.AlbumId = id;
                _context.Artiesten.Add(new Artiest() { Naam = model.ArtistToevoegen });
                _context.SaveChanges();
                model.ArtistToevoegen = "";
                return RedirectToAction("AddNummer", model);
            }
            else
            {
                Nummer nummer = new Nummer() { Naam = model.Titel, Speeltijd = model.Speeltijd };
                _context.Nummers.Add(nummer);
                _context.SaveChanges();
                foreach (var item in model.SelectedArtisten)
                {
                    _context.NummerArtiesten.Add(new NummerArtiest() { ArtiestId = int.Parse(item), NummerId = nummer.Id });
                }
                foreach (var item in model.Genres.Where(x=>x.Checked==true))
                {
                    _context.NummerGenres.Add(new NummerGenre() { NummerId = nummer.Id, GenreId = item.Id });
                }
                _context.NummerAlbums.Add(new NummerAlbum() { AlbumId = id, NummerId = nummer.Id });
                _context.SaveChanges();
                return RedirectToAction("Detail",new { id=id});
            }
        }
        public IActionResult DetailsNummer(int id)
        {
            NummerDetailViewModel model = new NummerDetailViewModel();
            Nummer nummerFromDb = _context.Nummers.Include(artist=>artist.NummerArtiests).Include(genre=>genre.NummerGenres).FirstOrDefault(x => x.Id == id);
            model.Titel = nummerFromDb.Naam;
            model.Speeltijd = nummerFromDb.Speeltijd;
            foreach (var item in nummerFromDb.NummerGenres)
            {
                model.Genres.Add(_context.GenreNummers.FirstOrDefault(x => x.Id == item.GenreId).Naam);
            }
            foreach (var item in nummerFromDb.NummerArtiests)
            {
                model.Artisten.Add(_context.Artiesten.FirstOrDefault(x => x.Id == item.ArtiestId).Naam);
            }
            return View(model);
        }
        public IActionResult DeleteNummer(int id,int albumId)
        {
            _context.Nummers.Remove(_context.Nummers.FirstOrDefault(x => x.Id == id));
            _context.SaveChanges();
            return RedirectToAction("Detail", new { id = albumId });
        }
    }
}
