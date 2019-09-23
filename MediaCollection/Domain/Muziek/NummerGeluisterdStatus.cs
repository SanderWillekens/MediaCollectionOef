using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Domain.Muziek
{
    public class NummerGeluisterdStatus
    {
        public int NummerId { get; set; }
        public int GeluisterdId { get; set; }
        public string UserId { get; set; }
    }
}
