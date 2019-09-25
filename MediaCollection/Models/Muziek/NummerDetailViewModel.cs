using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Models.Muziek
{
    public class NummerDetailViewModel
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public int Speeltijd { get; set; }
        public List<string> Artisten { get; set; } = new List<string>();
        public List<string> Genres { get; set; } = new List<string>();
        public List<NummerReviewViewModel> Reviews { get; set; } = new List<NummerReviewViewModel>();
    }
}
