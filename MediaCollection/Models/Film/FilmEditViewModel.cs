using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Models.Film
{
    public class FilmEditViewModel
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public int Speelduur { get; set; }
        public List<SelectListItem> Regisseurs { get; set; }
        public List<string> SelectedRegisseurs { get; set; }
        public List<SelectListItem> Genres { get; set; }
        public List<string> SelectedGenre { get; set; }
    }
}
