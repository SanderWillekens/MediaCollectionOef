using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Models.Muziek
{
    public class AlbumCreateViewModel
    {
        public string Naam { get; set; }
        public IFormFile Foto { get; set; }
    }
}
