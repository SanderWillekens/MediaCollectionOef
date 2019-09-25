using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Models.Muziek
{
    public class NummerEditViewModel
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public int Speelduur { get; set; }
        public string RegisseurToevoegen { get; set; }
        public List<SelectListItem> Artisten { get; set; }
        public List<string> SelectedArtisten { get; set; }
        public List<CheckboxViewModel> Genres { get; set; }
        public byte[] Foto { get; set; }
        public IFormFile FotoAanpassen { get; set; }
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
