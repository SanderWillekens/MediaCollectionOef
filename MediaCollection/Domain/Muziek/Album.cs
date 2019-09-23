using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Domain.Muziek
{
    public class Album
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public byte[] AlbumFoto { get; set; }
        public ICollection<Nummer> Nummers { get; set; }
    }
}
