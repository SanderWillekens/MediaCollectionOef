using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Domain.Serie
{
    public class SerieAfspeellijst
    {
        public int SerieId { get; set; }
        public int AfspeellijstId { get; set; }
        public string UserId { get; set; }
    }
}
