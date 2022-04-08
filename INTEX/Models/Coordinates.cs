using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEX.Models
{
    
    public class Coordinates
    {

        public Coordinates(double? a, double? b)
        {
            lat = a;
            lng = b;
        }
        public double? lat { get; set; }
        public double? lng {get; set; }
    }

}
