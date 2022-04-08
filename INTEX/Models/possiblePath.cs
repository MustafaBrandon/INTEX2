using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEX.Models
{
    public class possiblePath
    {
        public List<TIntersection> intersections { get; set; }

        public TIntersection worstOne { get; set; }
        public int worstScore { get; set; }

        public possiblePath(List<TIntersection> temp)
        {
            intersections = temp;
        }

        public int score()
        {
            int total = 0;
            worstOne = intersections[0];
            worstScore = 0;
            foreach (TIntersection i in intersections)
            {
                
                int currentTot = 0;
                currentTot += (i.COUNT_5 * 5);
                currentTot += (i.COUNT_4 * 4);
                currentTot += (i.COUNT_3 * 3);
                currentTot += (i.COUNT_2 * 2);
                currentTot += (i.COUNT_1 * 1);
                total += currentTot;

                if (currentTot > worstScore)
                {
                    worstOne = i;
                    worstScore = currentTot;
                }
            }
            return total;
        }
    }
}
