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
        public bool work_zone_related_True { get; set; }
        public bool pedestrian_involved_True { get; set; }
        public bool bicyclist_involved_True { get; set; }
        public bool motorcycle_involved_True { get; set; }
        public bool improper_restraint_True { get; set; }
        public bool unrestrained_True { get; set; }
        public bool dui_True { get; set; }
        public bool intersection_related_True { get; set; }
        public bool wild_animal_related_True { get; set; }
        public bool overturn_rollover_True { get; set; }
        public bool commercial_motor_veh_involved_True { get; set; }
        public bool teenage_driver_involved_True { get; set; }
        public bool older_driver_involved_True { get; set; }
        public bool single_vehicle_True { get; set; }
        public bool distracted_driving_True { get; set; }
        public bool drowsy_driving_True { get; set; }
        public bool roadway_departure_True { get; set; }
        public float Const { get; set; }
        public string CityEntry { get; set; }
        public string CountyEntry { get; set; }

        public Tensor<float> AsTensor()
        {
            //Assign City Value if-statement
            if (CityEntry == "AMERICAN FORK"){ city_AMERICAN_FORK = 1; } else if (CityEntry == "BLUFFDALE"){ city_BLUFFDALE = 1; } else if (CityEntry == "CLEARFIELD") { city_CLEARFIELD = 1; } else if (CityEntry == "CLINTON") { city_CLINTON = 1; } else if (CityEntry == "COTTONWOOD HEIGHTS") { city_COTTONWOOD_HEIGHTS = 1; } else if (CityEntry == "EAGLE MOUNTAIN") { city_EAGLE_MOUNTAIN = 1; } else if (CityEntry == "FARMINGTON") { city_FARMINGTON = 1; } else if (CityEntry == "HARRISVILLE") { city_HARRISVILLE = 1; } else if (CityEntry == "HEBER CITY") { city_HEBER_CITY = 1; } else if (CityEntry == "HIGHLAND") { city_HIGHLAND = 1; } else if (CityEntry == "HURRICANE") { city_HURRICANE = 1; } else if (CityEntry == "LAYTON") { city_LAYTON = 1; } else if (CityEntry == "LOGAN") { city_LOGAN = 1; } else if (CityEntry == "MOAB") { city_MOAB = 1; } else if (CityEntry == "OGDEN") { city_OGDEN = 1; } else if (CityEntry == "OREM") { city_OREM = 1; } else if (CityEntry == "OUTSIDE CITY LIMITS") { city_OUTSIDE_CITY_LIMITS = 1; } else if (CityEntry == "PARK CITY") { city_PARK_CITY = 1; } else if (CityEntry == "PLEASANT GROVE") { city_PLEASANT_GROVE = 1; } else if (CityEntry == "PLEASANT VIEW") { city_PLEASANT_VIEW = 1; } else if (CityEntry == "PRICE") { city_PRICE = 1; } else if (CityEntry == "PROVO") { city_PROVO = 1; } else if (CityEntry == "RIVERDALE") { city_RIVERDALE = 1; } else if (CityEntry == "RIVERTON") { city_RIVERTON = 1; } else if (CityEntry == "ROOSEVELT") { city_ROOSEVELT = 1; } else if (CityEntry == "ROY") { city_ROY = 1; } else if (CityEntry == "SALT LAKE CITY") { city_SALT_LAKE_CITY = 1; } else if (CityEntry == "SPANISH FORK") { city_SPANISH_FORK = 1; } else if (CityEntry == "SANDY") { city_SANDY = 1; } else if (CityEntry == "SANTAQUIN") { city_SANTAQUIN = 1; } else if (CityEntry == "SARATOGA SPRINGS") { city_SARATOGA_SPRINGS = 1; } else if (CityEntry == "SMITHFIELD") { city_SMITHFIELD = 1; } else if (CityEntry == "SOUTH OGDEN") { city_SOUTH_OGDEN = 1; } else if (CityEntry == "SOUTH SALT LAKE") { city_SOUTH_SALT_LAKE = 1; } else if (CityEntry == "SPRINGVILLE") { city_SPRINGVILLE = 1; } else if (CityEntry == "SUNSET") { city_SUNSET = 1; } else if (CityEntry == "SYRACUSE") { city_SYRACUSE = 1; } else if (CityEntry == "TAYLORSVILLE") { city_TAYLORSVILLE = 1; } else if (CityEntry == "TOOELE") { city_TOOELE = 1; } else if (CityEntry == "TREMONTON") { city_TREMONTON = 1; } else if (CityEntry == "WEST HAVEN") { city_WEST_HAVEN = 1; } else if (CityEntry == "WEST JORDAN") { city_WEST_JORDAN = 1; } else if (CityEntry == "WEST VALLEY CITY") { city_WEST_VALLEY_CITY = 1; } else if (CityEntry == "WILLARD") { city_WILLARD = 1; }
            
            //Assign County Value if-statement
            if (CountyEntry == "BOX ELDER") { county_name_BOX_ELDER = 1; } else if (CountyEntry == "EMERY") { county_name_EMERY = 1; } else if (CountyEntry == "GARFIELD") { county_name_GARFIELD = 1; } else if (CountyEntry == "MILLARD") { county_name_MILLARD = 1; } else if (CountyEntry == "SUMMIT") { county_name_SUMMIT = 1; } else if (CountyEntry == "TOOELE") { county_name_TOOELE = 1; } else if (CountyEntry == "UTAH") { county_name_UTAH = 1; } else if (CountyEntry == "WASATCH") { county_name_WASATCH = 1; }

            float[] data = new float[]
            {
                city_AMERICAN_FORK, city_BLUFFDALE, city_CLEARFIELD, city_CLINTON, city_COTTONWOOD_HEIGHTS, city_EAGLE_MOUNTAIN, 
                city_FARMINGTON, city_HARRISVILLE, city_HEBER_CITY ,city_HIGHLAND, city_HURRICANE, city_LAYTON, city_LOGAN, city_MOAB,
                city_OGDEN, city_OREM, city_OUTSIDE_CITY_LIMITS, city_PARK_CITY, city_PLEASANT_GROVE, city_PLEASANT_VIEW, city_PRICE, 
                city_PROVO, city_RIVERDALE, city_RIVERTON, city_ROOSEVELT, city_ROY, city_SALT_LAKE_CITY, city_SANDY, city_SANTAQUIN,
                city_SARATOGA_SPRINGS, city_SMITHFIELD, city_SOUTH_OGDEN, city_SOUTH_SALT_LAKE, city_SPANISH_FORK, city_SPRINGVILLE, 
                city_SUNSET, city_SYRACUSE, city_TAYLORSVILLE, city_TOOELE, city_TREMONTON, city_WEST_HAVEN, city_WEST_JORDAN,
                city_WEST_VALLEY_CITY, city_WILLARD, county_name_BOX_ELDER, county_name_EMERY, county_name_GARFIELD, county_name_MILLARD, 
                county_name_SUMMIT, county_name_TOOELE, county_name_UTAH, county_name_WASATCH, Convert.ToSingle(work_zone_related_True),
                Convert.ToSingle(pedestrian_involved_True), Convert.ToSingle(bicyclist_involved_True), Convert.ToSingle(motorcycle_involved_True), Convert.ToSingle(improper_restraint_True), Convert.ToSingle(unrestrained_True), Convert.ToSingle(dui_True), Convert.ToSingle(intersection_related_True), Convert.ToSingle(wild_animal_related_True), Convert.ToSingle(overturn_rollover_True),
                Convert.ToSingle(commercial_motor_veh_involved_True), Convert.ToSingle(teenage_driver_involved_True), Convert.ToSingle(older_driver_involved_True), Convert.ToSingle(single_vehicle_True), Convert.ToSingle(distracted_driving_True), Convert.ToSingle(drowsy_driving_True), Convert.ToSingle(roadway_departure_True), (Const = 1)
            };
            int[] dimensions = new int[] { 1, 70 };
            return new DenseTensor<float>(data, dimensions);
        }


    }
}
