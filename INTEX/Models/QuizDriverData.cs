using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEX.Models
{
    public class QuizDriverData
    {
        // Data for quiz view
        public float city_AMERICAN_FORK { get; set; }
        public float city_BLUFFDALE { get; set; }
        public float city_CLEARFIELD { get; set; }
        public float city_CLINTON { get; set; }
        public float city_COTTONWOOD_HEIGHTS { get; set; }
        public float city_EAGLE_MOUNTAIN { get; set;}
        public float city_FARMINGTON { get; set; }
        public float city_HARRISVILLE { get; set; }
        public float city_HEBER_CITY { get; set; }
        public float city_HIGHLAND { get; set; }
        public float city_HURRICANE { get; set; }
        public float city_LAYTON { get; set; }
        public float city_LOGAN { get; set; }
        public float city_MOAB { get; set; }
        public float city_OGDEN { get; set; }
        public float city_OREM { get; set; }
        public float city_OUTSIDE_CITY_LIMITS { get; set; }
        public float city_PARK_CITY { get; set; }
        public float city_PLEASANT_GROVE { get; set; }
        public float city_PLEASANT_VIEW { get; set; }
        public float city_PRICE { get; set; }
        public float city_PROVO { get; set; }
        public float city_RIVERDALE { get; set; }
        public float city_RIVERTON { get; set; }
        public float city_ROOSEVELT { get; set; }
        public float city_ROY { get; set; }
        public float city_SALT_LAKE_CITY { get; set; }
        public float city_SANDY { get; set; }
        public float city_SANTAQUIN { get; set; }
        public float city_SARATOGA_SPRINGS { get; set; }
        public float city_SMITHFIELD { get; set; }
        public float city_SOUTH_OGDEN { get; set; }
        public float city_SOUTH_SALT_LAKE { get; set; }
        public float city_SPANISH_FORK { get; set; }
        public float city_SPRINGVILLE { get; set; }
        public float city_SUNSET { get; set; }
        public float city_SYRACUSE { get; set; }
        public float city_TAYLORSVILLE { get; set; }
        public float city_TOOELE { get; set; }
        public float city_TREMONTON { get; set; }
        public float city_WEST_HAVEN { get; set; }
        public float city_WEST_JORDAN { get; set; }
        public float city_WEST_VALLEY_CITY { get; set; }
        public float city_WILLARD { get; set; }
        public float county_name_BOX_ELDER { get; set; }
        public float county_name_EMERY { get; set; }
        public float county_name_GARFIELD { get; set; }
        public float county_name_MILLARD { get; set; }
        public float county_name_SUMMIT { get; set; }
        public float county_name_TOOELE { get; set; }
        public float county_name_UTAH { get; set; }
        public float county_name_WASATCH { get; set; }
        public float work_zone_related_True { get; set; }
        public float pedestrian_involved_True { get; set; }
        public float bicyclist_involved_True { get; set; }
        public float motorcycle_involved_True { get; set; }
        public float improper_restraint_True { get; set; }
        public float unrestrained_True { get; set; }
        public float dui_True { get; set; }
        public float intersection_related_True { get; set; }
        public float wild_animal_related_True { get; set; }
        public float overturn_rollover_True { get; set; }
        public float commercial_motor_veh_involved_True { get; set; }
        public float teenage_driver_involved_True { get; set; }
        public float older_driver_involved_True { get; set; }
        public float single_vehicle_True { get; set; }
        public float distracted_driving_True { get; set; }
        public float drowsy_driving_True { get; set; }
        public float roadway_departure_True { get; set; }
        public float Const { get; set; }

        public Tensor<float> AsTensor()
        {
            float[] data = new float[]
            {
                city_AMERICAN_FORK, city_BLUFFDALE, city_CLEARFIELD, city_CLINTON, city_COTTONWOOD_HEIGHTS, city_EAGLE_MOUNTAIN, city_FARMINGTON, city_HARRISVILLE, city_HEBER_CITY ,city_HIGHLAND, city_HURRICANE, city_LAYTON, city_LOGAN, city_MOAB,
                city_OGDEN, city_OREM, city_OUTSIDE_CITY_LIMITS, city_PARK_CITY, city_PLEASANT_GROVE, city_PLEASANT_VIEW, city_PRICE, city_PROVO, city_RIVERDALE, city_RIVERTON, city_ROOSEVELT, city_ROY, city_SALT_LAKE_CITY, city_SANDY, city_SANTAQUIN,
                city_SARATOGA_SPRINGS, city_SMITHFIELD, city_SOUTH_OGDEN, city_SOUTH_SALT_LAKE, city_SPANISH_FORK, city_SPRINGVILLE, city_SUNSET, city_SYRACUSE, city_TAYLORSVILLE, city_TOOELE, city_TREMONTON, city_WEST_HAVEN, city_WEST_JORDAN,
                city_WEST_VALLEY_CITY, city_WILLARD, county_name_BOX_ELDER, county_name_EMERY, county_name_GARFIELD, county_name_MILLARD, county_name_SUMMIT, county_name_TOOELE, county_name_UTAH, county_name_WASATCH, work_zone_related_True,
                pedestrian_involved_True, bicyclist_involved_True, motorcycle_involved_True, improper_restraint_True, unrestrained_True, dui_True, intersection_related_True, wild_animal_related_True, overturn_rollover_True,
                commercial_motor_veh_involved_True, teenage_driver_involved_True, older_driver_involved_True, single_vehicle_True, distracted_driving_True, drowsy_driving_True, roadway_departure_True, Const
            };
            int[] dimensions = new int[] { 1, 70 };
            return new DenseTensor<float>(data, dimensions);
        }


    }
}
