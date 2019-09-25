using MediaCollection.Domain.Film;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Models.Film
{
    public class FilmDetailViewModel
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public int Speelduur { get; set; }
        public List<string> Regisseurs { get; set; } = new List<string>();
        public List<string> Genres { get; set; } = new List<string>();
        public List<FilmReviewViewModel> Reviews { get; set; } = new List<FilmReviewViewModel>();
        public byte[] Foto { get; set; }
        public string ImageSource {
            get
            {
                string mimeType = "png";
                string base64 = Convert.ToBase64String(Foto);
                return string.Format("data:{0};base64,{1}", mimeType, base64);
            }
        }
    }
}
