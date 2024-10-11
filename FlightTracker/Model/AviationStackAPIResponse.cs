using Newtonsoft.Json;

namespace FlightTracker.Model
{
    public class AviationStackAPIResponse
    {
        [JsonProperty("data")]
        public List<Flight> Data { get; set; }
    }
}
