using Microsoft.AspNetCore.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Domain.Film
{
    public class Film
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public int Speelduur { get; set; }
        public byte[] Foto { get; set; }
        public ICollection<FilmGenre> Genres { get; set; }
        public ICollection<FilmRegisseur> Regisseurs { get; set; }
        public ICollection<FilmReview> Reviews { get; set; }
        public ICollection<FilmFavorite> FilmFavorites { get; set; }
        public ICollection<FilmAfspeellijst> FilmAfspeellijsten { get; set; }
        public ICollection<FilmGezienStatus> FilmGezienStatuses { get; set; }
    }
}
