using Newtonsoft.Json;

namespace FlightTracker.Model
{
    public class Airport
    {
        [JsonProperty("airport")]
        public string? Name { get; set; }
        [JsonProperty("timezone")]
        public string? TimeZone { get; set; }
        [JsonProperty("iata")]
        public string? AirportIata { get; set; }
        [JsonProperty("icao")]
        public string? AirportIcao { get; set; }
        [JsonProperty("terminal")]
        public string? Terminal { get; set; }
        [JsonProperty("gate")]
        public string? Gate{ get; set; }
        [JsonProperty("delay")]
        public int? Delay { get; set; }
        [JsonProperty("scheduled")]
        public DateTime? Scheduled { get; set; }

        [JsonProperty("estimated")]
        public DateTime? Estimated { get; set; }
        [JsonProperty("actual")]
        public DateTime? Actual { get; set; }

        [JsonProperty("estimated_runway")]
        public DateTime? EstimatedRunway { get; set; }

        [JsonProperty("actual_runway")]
        public DateTime? ActualRunway { get; set; }
    }
}
