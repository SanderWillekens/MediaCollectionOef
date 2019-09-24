using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Models.Film
{
    public class FilmCreateViewModel
    {
        public string Titel { get; set; }
        public int Speelduur { get; set; }
        public string Beschrijving { get; set; }
        public List<SelectListItem> Regisseurs { get; set; } = new List<SelectListItem>();
        public List<string> SelectedRegisseurs { get; set; } = new List<string>();
        public string RegisseurToevoegen { get; set; }
        public List<CheckboxViewModel> Genres { get; set; }
    }
}
