using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEX.Models
// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var directionResponse = DirectionResponse.FromJson(jsonString);

{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class DirectionResponse
    {
        [JsonProperty("geocoded_waypoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<GeocodedWaypoint> GeocodedWaypoints { get; set; }

        [JsonProperty("routes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Route> Routes { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }

    public partial class GeocodedWaypoint
    {
        [JsonProperty("geocoder_status", NullValueHandling = NullValueHandling.Ignore)]
        public string GeocoderStatus { get; set; }

        [JsonProperty("place_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlaceId { get; set; }

        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Types { get; set; }
    }

    public partial class Route
    {
        [JsonProperty("bounds", NullValueHandling = NullValueHandling.Ignore)]
        public Bounds Bounds { get; set; }

        [JsonProperty("copyrights", NullValueHandling = NullValueHandling.Ignore)]
        public string Copyrights { get; set; }

        [JsonProperty("legs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Leg> Legs { get; set; }

        [JsonProperty("overview_polyline", NullValueHandling = NullValueHandling.Ignore)]
        public Polyline OverviewPolyline { get; set; }

        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public string Summary { get; set; }

        [JsonProperty("warnings", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Warnings { get; set; }

        [JsonProperty("waypoint_order", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> WaypointOrder { get; set; }
    }

    public partial class Bounds
    {
        [JsonProperty("northeast", NullValueHandling = NullValueHandling.Ignore)]
        public Northeast Northeast { get; set; }

        [JsonProperty("southwest", NullValueHandling = NullValueHandling.Ignore)]
        public Northeast Southwest { get; set; }
    }

    public partial class Northeast
    {
        [JsonProperty("lat", NullValueHandling = NullValueHandling.Ignore)]
        public double? Lat { get; set; }

        [JsonProperty("lng", NullValueHandling = NullValueHandling.Ignore)]
        public double? Lng { get; set; }
    }

    public partial class Leg
    {
        [JsonProperty("distance", NullValueHandling = NullValueHandling.Ignore)]
        public Distance Distance { get; set; }

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public Distance Duration { get; set; }

        [JsonProperty("end_address", NullValueHandling = NullValueHandling.Ignore)]
        public string EndAddress { get; set; }

        [JsonProperty("end_location", NullValueHandling = NullValueHandling.Ignore)]
        public Northeast EndLocation { get; set; }

        [JsonProperty("start_address", NullValueHandling = NullValueHandling.Ignore)]
        public string StartAddress { get; set; }

        [JsonProperty("start_location", NullValueHandling = NullValueHandling.Ignore)]
        public Northeast StartLocation { get; set; }

        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<Step> Steps { get; set; }

        [JsonProperty("traffic_speed_entry", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> TrafficSpeedEntry { get; set; }

        [JsonProperty("via_waypoint", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> ViaWaypoint { get; set; }
    }

    public partial class Distance
    {
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }
    }

    public partial class Step
    {
        [JsonProperty("distance", NullValueHandling = NullValueHandling.Ignore)]
        public Distance Distance { get; set; }

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public Distance Duration { get; set; }

        [JsonProperty("end_location", NullValueHandling = NullValueHandling.Ignore)]
        public Northeast EndLocation { get; set; }

        [JsonProperty("html_instructions", NullValueHandling = NullValueHandling.Ignore)]
        public string HtmlInstructions { get; set; }

        [JsonProperty("maneuver", NullValueHandling = NullValueHandling.Ignore)]
        public string Maneuver { get; set; }

        [JsonProperty("polyline", NullValueHandling = NullValueHandling.Ignore)]
        public Polyline Polyline { get; set; }

        [JsonProperty("start_location", NullValueHandling = NullValueHandling.Ignore)]
        public Northeast StartLocation { get; set; }

        [JsonProperty("travel_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string TravelMode { get; set; }
    }

    public partial class Polyline
    {
        [JsonProperty("points", NullValueHandling = NullValueHandling.Ignore)]
        public string Points { get; set; }
    }

    public partial class DirectionResponse
    {
        public static DirectionResponse FromJson(string json) => JsonConvert.DeserializeObject<DirectionResponse>(json, INTEX.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this DirectionResponse self) => JsonConvert.SerializeObject(self, INTEX.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
