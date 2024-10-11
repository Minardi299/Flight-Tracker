using Newtonsoft.Json;

namespace FlightTracker.Model
{
    public class Airline
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("iata")]
        public string AirlineIata { get; set; }
        [JsonProperty("icao")]
        public string AirlineIcao { get; set; }
    }
}
