using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FlightTracker.Model
{
    public class Flight
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("iata")]
        public string Iata { get; set; }

        [JsonProperty("icao")]
        public string Icao { get; set; }

        [JsonProperty("codeshared")]
        public object CodeShared { get; set; }

        [JsonProperty("departure")]
        public Airport Departure { get; set; }

        [JsonProperty("arrival")]
        public Airport Arrival { get; set; }

        [JsonProperty("airline")]
        public Airline Airline { get; set; }

        [JsonProperty("aircraft")]
        private JObject AircraftData { get; set; }

        // Create a property to get just the 'iata' code
        [JsonIgnore]
        public string AircraftIata => AircraftData?["iata"]?.ToString();
        [JsonProperty("flight_date")]
        public DateOnly Flight_date { get; set; }

        [JsonProperty("flight_status")]
        public string Flight_status { get; set; }
    }
}
