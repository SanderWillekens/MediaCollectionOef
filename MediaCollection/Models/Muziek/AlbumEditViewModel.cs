using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Models.Muziek
{
    public class AlbumEditViewModel
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public byte[] Foto { get; set; }
        public string ImageSource
        {
            get
            {
                string mimeType = "png";
                string base64 = Convert.ToBase64String(Foto);
                return string.Format("data:{0};base64,{1}", mimeType, base64);
            }
        }
        public IFormFile FotoAanpassen { get; set; }
    }
}
