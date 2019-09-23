using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Domain.Muziek
{
    public class NummerAfspeellijst
    {
        public int NummerId { get; set; }
        public int AfspeellijstId { get; set; }
        public string UserId { get; set; }
    }
}
