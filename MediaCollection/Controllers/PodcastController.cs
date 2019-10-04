using MediaCollection.Data;
using MediaCollection.Domain.Podcast;
using MediaCollection.Models.Podcast;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Controllers
{
    public class PodcastController:Controller
    {
        private readonly ApplicationDbContext _context;

        public PodcastController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<PodcastListViewModel> models = new List<PodcastListViewModel>();
            foreach (var item in _context.Podcasts)
            {
                models.Add(new PodcastListViewModel() { Id = item.Id, Titel = item.Titel,Host=item.Host });
            }
            return View(models);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PodcastCreateViewModel model)
        {
            _context.Podcasts.Add(new Podcast() { Titel = model.Titel,Host=model.Host });
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            Podcast podcast = _context.Podcasts.Include(aflevering => aflevering.PodcastAfleveringen).FirstOrDefault(x => x.Id == id);
            PodcastDetailViewModel model = new PodcastDetailViewModel()
            {
                Titel = podcast.Titel,
                Host = podcast.Host
            };
            foreach (var item in podcast.PodcastAfleveringen)
            {
                model.Afleveringen.Add(new PodcastAfleveringListViewModel() { Titel = item.Titel,Id=item.Id});
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            Podcast podcastFromDb = _context.Podcasts.FirstOrDefault(x => x.Id == id);
            PodcastEditViewModel model = new PodcastEditViewModel()
            {
                Id = podcastFromDb.Id,
                Titel = podcastFromDb.Titel,
                Host=podcastFromDb.Host
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(PodcastEditViewModel model)
        {
            Podcast podcastToEdit = _context.Podcasts.FirstOrDefault(x => x.Id == model.Id);
            podcastToEdit.Titel = model.Titel;
            podcastToEdit.Host = model.Host;
            _context.SaveChanges();
            return RedirectToAction("Details", new { id = model.Id });
        }
        public IActionResult Delete(int id)
        {
            Podcast podcast = _context.Podcasts.FirstOrDefault(x => x.Id == id);
            _context.PodcastAfleveringen.RemoveRange(_context.PodcastAfleveringen.Where(x => x.PodcastId == id));
            _context.Podcasts.Remove(podcast);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult AddAflevering(int id)
        {
            PodcastAfleveringCreateViewModel model = new PodcastAfleveringCreateViewModel() { PodcastId = id };
            return View(model);
        }
        [HttpPost]
        public IActionResult AddAflevering(PodcastAfleveringCreateViewModel model)
        {
            _context.PodcastAfleveringen.Add(new PodcastAflevering() { Titel = model.Titel,Guests=model.Guests,PodcastId=model.PodcastId });
            _context.SaveChanges();
            return RedirectToAction("Details", new { id = model.PodcastId });
        }
    }
}
