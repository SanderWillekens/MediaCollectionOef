using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Domain.Film
{
    public class FilmReview
    {
        public int UserId { get; set; }
        public int FilmId { get; set; }
        public string ReviewTitel { get; set; }
        public int Score { get; set; }
        public string Review { get; set; }
    }
}
