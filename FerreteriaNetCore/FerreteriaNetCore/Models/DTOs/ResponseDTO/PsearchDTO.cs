using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FerreteriaNetCore.Models.DTOs.ResponseDTO
{
    public class PsearchDTO
    {
        public string Product { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
    }
}
