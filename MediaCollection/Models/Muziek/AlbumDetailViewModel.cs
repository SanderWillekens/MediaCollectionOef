using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Models.Muziek
{
    public class AlbumDetailViewModel
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public byte[] Foto { get; set; }
        public List<NummerListViewModel> Nummers { get; set; } = new List<NummerListViewModel>();
        public string ImageSource
        {
            get
            {
                string mimeType = "png";
                string base64 = Convert.ToBase64String(Foto);
                return string.Format("data:{0};base64,{1}", mimeType, base64);
            }
        }
    }
}
