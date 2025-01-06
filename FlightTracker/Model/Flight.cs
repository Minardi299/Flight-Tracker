using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FlightTracker.Model
{
    public class Flight
    {
        [JsonProperty("flight")]
        private JObject FlightData { get; set; }
        [JsonIgnore]
        public string? Number => FlightData?["number"]?.ToString();

        public string? Iata => FlightData?["iata"]?.ToString();

        public string? Icao => FlightData?["icao"]?.ToString();

        public object CodeShared => FlightData?["codeshared"]?.ToString();

        [JsonProperty("departure")]
        public Airport? Departure { get; set; }

        [JsonProperty("arrival")]
        public Airport? Arrival { get; set; }

        [JsonProperty("airline")]
        public Airline? Airline { get; set; }

        [JsonProperty("aircraft")]
        private JObject? AircraftData { get; set; }

        // Create a property to get just the 'iata' code
        [JsonIgnore]
        public string? AircraftIata => AircraftData?["iata"]?.ToString();
        [JsonProperty("flight_date")]
        public DateOnly? Flight_date { get; set; }

        [JsonProperty("flight_status")]
        public string? Flight_status { get; set; }
        public  override string ToString()
        {
            return $"{this?.Number} is the flight number and airline is {this.Airline.Name}";
        }
    }
}
