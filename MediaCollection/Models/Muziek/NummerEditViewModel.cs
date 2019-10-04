using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Models.Muziek
{
    public class NummerEditViewModel
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public int Speelduur { get; set; }
        public string RegisseurToevoegen { get; set; }
        public List<SelectListItem> Artisten { get; set; } = new List<SelectListItem>();
        public List<string> SelectedArtisten { get; set; }
        public List<CheckboxViewModel> Genres { get; set; } = new List<CheckboxViewModel>();
    }
}
