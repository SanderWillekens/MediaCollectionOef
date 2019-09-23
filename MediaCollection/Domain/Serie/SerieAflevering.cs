using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Domain.Serie
{
    public class SerieAflevering
    {
        public int Id { get; set; }
        public int SerieId { get; set; }
        public int Titel { get; set; }
    }
}
