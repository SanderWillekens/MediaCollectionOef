using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Domain.Film
{
    public class FilmAfspeellijst
    {
        public string UserId { get; set; }
        public int FilmId { get; set; }
        public int AfspeellijstId { get; set; }
    }
}
