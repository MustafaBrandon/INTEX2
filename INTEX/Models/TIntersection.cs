using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace INTEX.Models
{
    public class TIntersection
    {
        [Key]
        public int id { get; set; }

        public double lat { get; set; }

        public double lng { get; set; }

        public int COUNT_5 { get; set; }

        public int COUNT_4 { get; set; }

        public int COUNT_3 { get; set; }
        public int COUNT_2 { get; set; }

        public int COUNT_1 { get; set; }

        public TIntersection(int _id, double _lat, double _long, int c5, int c4, int c3, int c2, int c1)
        {
            id = _id;
            lat = _lat;
            lng = _long;
            COUNT_5 = c5;
            COUNT_4 = c4;
            COUNT_3 = c3;
            COUNT_2 = c2;
            COUNT_1 = c1;
        }
    }


}
