using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Domain.Serie
{
    public class SerieReview
    {
        public string UserId { get; set; }
        public int SerieId { get; set; }
        public string Titel { get; set; }
        public int Score { get; set; }
        public string Review { get; set; }
    }
}
