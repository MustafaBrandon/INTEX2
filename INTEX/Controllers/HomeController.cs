using INTEX.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Amazon.Lambda;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using INTEX.Models.ViewModels;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.IO;

namespace INTEX.Controllers
{
    // Only allows authorized users to use controller - option, use another controller for authorized material
    //[Authorize]
    public class HomeController : Controller
    {
        private ICrashRepository _repo { get; set; }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ICrashRepository temp)
        {
            _logger = logger;
            _repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("CrashInfo/{pageNum:int?}")]
        [HttpGet]
        public IActionResult CrashInfo(int pageNum = 1)
        {
            ViewBag.post = false;
            int pageSize = 20;

            ViewBag.PageInfo = new PageInfo
            {
                TotalNumCrashes = _repo.Utah_Crashes.Count(),
                CrashesPerPage = pageSize,
                CurrentPage = pageNum
            };  

            //Get the correct crashes for the correct page
            ViewBag.crashes = _repo.Utah_Crashes.Skip((pageNum - 1) * pageSize).Take(pageSize);

            //Get the cities and counties for the dropdown filters
            ViewBag.Cities = _repo.Utah_Crashes.Select(x => x.CITY).Distinct().OrderBy(x => x).ToList();
            ViewBag.Counties = _repo.Utah_Crashes.Select(x => x.COUNTY_NAME).Distinct().OrderBy(x => x).ToList();

            return View();
        }

        [Route("CrashInfo/{pageNum:int}")]
        [HttpPost]
        public IActionResult CrashInfo(Filter f, int pageNum = 1)
        {
            ViewBag.post = true;

            int pageSize = 20;
            var crashes = _repo.Utah_Crashes;

            // Date Filtering
            if (f.CRASH_DATETIME != null)
            {
                var date = DateTime.Parse(f.CRASH_DATETIME);
                crashes = crashes.Where(x => x.CRASH_DATETIME.Date == date);
            }

            // Severity Filtering - if none are selected filter nothing out, otherwise filter out the non selected ones
            if (!f.CRASH_SEVERITY_1 && !f.CRASH_SEVERITY_2 && !f.CRASH_SEVERITY_3 && !f.CRASH_SEVERITY_4 && !f.CRASH_SEVERITY_5) { }
            else
            {
                if (!f.CRASH_SEVERITY_1)
                {
                    crashes = crashes.Where(x => x.CRASH_SEVERITY_ID != 1);
                }
                if (!f.CRASH_SEVERITY_2)
                {
                    crashes = crashes.Where(x => x.CRASH_SEVERITY_ID != 2);
                }
                if (!f.CRASH_SEVERITY_3)
                {
                    crashes = crashes.Where(x => x.CRASH_SEVERITY_ID != 3);
                }
                if (!f.CRASH_SEVERITY_4)
                {
                    crashes = crashes.Where(x => x.CRASH_SEVERITY_ID != 4);
                }
                if (!f.CRASH_SEVERITY_5)
                {
                    crashes = crashes.Where(x => x.CRASH_SEVERITY_ID != 5);
                }
            }

            // Location Filtering
            if (f.CITY != null)
            {
                crashes = crashes.Where(x => x.CITY == f.CITY);
            }
            if (f.COUNTY_NAME != null)
            {
                crashes = crashes.Where(x => x.COUNTY_NAME == f.COUNTY_NAME);
            }

            // Flag Filtering - for each flag selected, filter out any results not including that flag. For multiple flags, filter out all results not including all selected flags
            if (f.MAIN_ROAD_NAME != null)
            {
                crashes = crashes.Where(x => x.MAIN_ROAD_NAME.Contains(f.MAIN_ROAD_NAME));
            }
            if (f.BICYCLIST_INVOLVED)
            {
                crashes = crashes.Where(x => x.BICYCLIST_INVOLVED);
            }
            if (f.COMMERCIAL_MOTOR_VEH_INVOLVED)
            {
                crashes = crashes.Where(x => x.COMMERCIAL_MOTOR_VEH_INVOLVED);
            }
            if (f.DISTRACTED_DRIVING)
            {
                crashes = crashes.Where(x => x.DISTRACTED_DRIVING);
            }
            if (f.DOMESTIC_ANIMAL_RELATED)
            {
                crashes = crashes.Where(x => x.DOMESTIC_ANIMAL_RELATED);
            }
            if (f.DROWSY_DRIVING)
            {
                crashes = crashes.Where(x => x.DROWSY_DRIVING);
            }
            if (f.DUI)
            {
                crashes = crashes.Where(x => x.DUI);
            }
            if (f.IMPROPER_RESTRAINT)
            {
                crashes = crashes.Where(x => x.IMPROPER_RESTRAINT);
            }
            if (f.INTERSECTION_RELATED)
            {
                crashes = crashes.Where(x => x.INTERSECTION_RELATED);
            }
            if (f.MOTORCYCLE_INVOLVED)
            {
                crashes = crashes.Where(x => x.MOTORCYCLE_INVOLVED);
            }
            if (f.NIGHT_DARK_CONDITION)
            {
                crashes = crashes.Where(x => x.NIGHT_DARK_CONDITION);
            }
            if (f.OLDER_DRIVER_INVOLVED)
            {
                crashes = crashes.Where(x => x.OLDER_DRIVER_INVOLVED);
            }
            if (f.OVERTURN_ROLLOVER)
            {
                crashes = crashes.Where(x => x.OVERTURN_ROLLOVER);
            }
            if (f.PEDESTRIAN_INVOLVED)
            {
                crashes = crashes.Where(x => x.PEDESTRIAN_INVOLVED);
            }
            if (f.ROADWAY_DEPARTURE)
            {
                crashes = crashes.Where(x => x.ROADWAY_DEPARTURE);
            }
            if (f.SINGLE_VEHICLE)
            {
                crashes = crashes.Where(x => x.SINGLE_VEHICLE);
            }
            if (f.TEENAGE_DRIVER_INVOLVED)
            {
                crashes = crashes.Where(x => x.TEENAGE_DRIVER_INVOLVED);
            }
            if (f.UNRESTRAINED)
            {
                crashes = crashes.Where(x => x.UNRESTRAINED);
            }
            if (f.WILD_ANIMAL_RELATED)
            {
                crashes = crashes.Where(x => x.WILD_ANIMAL_RELATED);
            }
            if (f.WORK_ZONE_RELATED)
            {
                crashes = crashes.Where(x => x.WORK_ZONE_RELATED);
            }

            ViewBag.PageInfo = new PageInfo
            {
                TotalNumCrashes = crashes.Count(),
                CrashesPerPage = pageSize,
                CurrentPage = pageNum
            };

            ViewBag.crashes = crashes.Skip((pageNum - 1) * pageSize).Take(pageSize);

            ViewBag.Cities = _repo.Utah_Crashes.Select(x => x.CITY).Distinct().OrderBy(x => x).ToList();
            ViewBag.Counties = _repo.Utah_Crashes.Select(x => x.COUNTY_NAME).Distinct().OrderBy(x => x).ToList();

            return View();
        }

        [HttpGet]
        public IActionResult CrashDetails(int id)
        {
            //Get the crash to display the details for
            var crash = _repo.Utah_Crashes.FirstOrDefault(x => x.CRASH_ID == id);
            ViewBag.Severities = _repo.Severity.ToList();

            return View(crash);
        }

        [HttpGet]
        public IActionResult SafeRoute()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SafeRoute(SafeRouteInput sri)
        {
            //Determine the safest route out of the suggested google routes from one destination to another
            //After determinging the safest route, pass it's data to the view to display maps of this safe route
            sri.origin = sri.origin.Replace(", ", ",").Replace(" ", "+");
            sri.destination = sri.destination.Replace(", ", ",").Replace(" ", "+");

            string url = String.Format(
                "https://maps.googleapis.com/maps/api/directions/json?destination=" +
                sri.destination+
                "&origin="+
                sri.origin+
                "&alternatives=true&key=AIzaSyDbMfrJkOsAaEwi7fHIYoq8vTRhdvpDE3A");
            WebRequest requestObjGet = WebRequest.Create(url);
            requestObjGet.Method = "GET";
            HttpWebResponse response = null;
            response = (HttpWebResponse)requestObjGet.GetResponse();

            string result = null;
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                result = sr.ReadToEnd();
                sr.Close();
            }

            var directionResponse = DirectionResponse.FromJson(result);
            var data = _repo.Intersections.ToList();

            List<possiblePath> paths = new List<possiblePath>();

            //FOR EACH ROUTE IN ROUTES
            foreach (Route r in directionResponse.Routes)
            {
                var intersections = new List<Coordinates>();
                intersections.Add(new Coordinates(r.Legs[0].StartLocation.Lat, r.Legs[0].StartLocation.Lng));
                //append all end locs of legs
                foreach (Leg leg in r.Legs)
                {
                    intersections.Add(new Coordinates(leg.EndLocation.Lat, leg.EndLocation.Lng));
                }
                //loop through data and sum all baddies
                List<TIntersection> badIntersections = new List<TIntersection>();
                const double THRESHOLD = 0.0005;
                int[] count = new int[] { 0, 0, 0, 0, 0 };
                foreach (Coordinates coords in intersections)
                {
                    //reset count
                    count[0] = 0;
                    count[1] = 0;
                    count[2] = 0;
                    count[3] = 0;
                    count[4] = 0;
                    foreach (Intersection i in data)
                    {
                        //check if its close, if so, increase the count

                        if (Math.Abs((double)(i.lat - coords.lat)) <= THRESHOLD)
                        {
                            if (Math.Abs((double)(i.lng - coords.lng)) <= THRESHOLD)
                            {
                                count[0] += i.COUNT_5;
                                count[1] += i.COUNT_4;
                                count[2] += i.COUNT_3;
                                count[3] += i.COUNT_2;
                                count[4] += i.COUNT_1;
                            }
                        }
                    }
                    //Add the in total info
                    badIntersections.Add(new TIntersection(0, (double)coords.lat, (double)coords.lng, count[0], count[1], count[2], count[3], count[4]));
                }

                paths.Add(new possiblePath(badIntersections));

            }

            List<int> scores = new List<int>();

            foreach (possiblePath p in paths)
            {
                scores.Add(p.score());
            }

            int index = 0;
            int bestScore = 0;
            //Find the route with the best score
            if (paths.Count() != 0)
            {
                int lowestIndex = 0;
                int lowestScore = scores[0];
                for (int i = 0; i < scores.Count();i++) 
                {
                    if(scores[i] < lowestScore)
                    {
                        lowestIndex = i;
                        lowestScore = scores[i];
                    }
                }
                index = lowestIndex;
            }
            possiblePath bestPath = paths[index];
            bestScore = scores[index];
            bool only = scores.Count() == 1;
            string mapUrl;
            string viewUrl;
            
            //Set bounds of the map that we will use
            double rightBound = (double)directionResponse.Routes[index].Bounds.Northeast.Lat;
            double topBound = (double)directionResponse.Routes[index].Bounds.Northeast.Lng;
            double leftBound = (double)directionResponse.Routes[index].Bounds.Southwest.Lat;
            double lowerBound = (double)directionResponse.Routes[index].Bounds.Southwest.Lng;
            List<Coordinates> accidents = new List<Coordinates>();
            foreach (Intersection i in data)
            {
                if (i.lat < rightBound && i.lat > leftBound)
                {
                    if (i.lng < topBound && i.lng > lowerBound)
                    {
                        accidents.Add(new Coordinates( i.lat,i.lng));
                    }
                }
            }

            mapUrl = "https://www.google.com/maps/embed/v1/directions?key=AIzaSyDbMfrJkOsAaEwi7fHIYoq8vTRhdvpDE3A" +
                        "&origin=" + sri.origin.ToString() +
                        "&destination=" + sri.destination.ToString() +
                        "&mode=driving";

            //craft marker list
            string markers = "";
            string point = "";
            foreach (Coordinates c in accidents)
            {
                markers += "|" + c.lat + "," + c.lng;
                point += ","+c.lat + "," + c.lng;
                
            }
            point = point.Substring(1);

            //put markers on intersections
            string markerUrl = "https://maps.googleapis.com/maps/api/staticmap?key=AIzaSyDbMfrJkOsAaEwi7fHIYoq8vTRhdvpDE3A " +
                        "&size=400x400 &markers=" + markers +
                        "&maptype = roadmap";


            viewUrl = "https://www.google.com/maps/embed/v1/streetview?key=AIzaSyDbMfrJkOsAaEwi7fHIYoq8vTRhdvpDE3A " +
                       "&location=" + bestPath.worstOne.lat.ToString() + "," + bestPath.worstOne.lng.ToString() +
                       "&heading=210" +
                       "&pitch=10" +
                       "&fov=90";

            var lcenter = (rightBound+leftBound) / 2;
            var vcenter = (topBound + lowerBound) / 2;

            //for the best path
            string intPath = "";
            var myBestPathWithWeirdName = directionResponse.Routes[index];

            var encodedPolyline = myBestPathWithWeirdName.OverviewPolyline.Points;
            foreach (TIntersection ti in bestPath.intersections)
            {
                intPath += "," + ti.lat + "," + ti.lng;
            }
            intPath = intPath.Substring(1);
            ViewBag.pathing = intPath;
            ViewBag.viewUrl = viewUrl;
            ViewBag.mapUrl = mapUrl;
            ViewBag.markerUrl = markerUrl;
            ViewBag.only = only;
            ViewBag.score = bestScore;
            ViewBag.routesUsed = paths.Count();
            ViewBag.accidents = point;
            ViewBag.scenter = vcenter;
            ViewBag.wcenter = lcenter;
            ViewBag.poly = encodedPolyline;


            //At this point we have all the goods
            

            return View();
        }

        [HttpGet]
        public IActionResult CrashStats()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return RedirectToPage("AccessDenied");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
