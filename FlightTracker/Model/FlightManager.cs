using Newtonsoft.Json;
namespace FlightTracker.Model
{
    public class FlightManager
    {
        public FlightManager() { }
        public string mockFlight = "{\r\n    \"pagination\": {\r\n        \"limit\": 1,\r\n        \"offset\": 0,\r\n        \"count\": 1,\r\n        \"total\": 1\r\n    },\r\n    \"data\": [\r\n        {\r\n            \"flight_date\": \"2024-09-26\",\r\n            \"flight_status\": \"landed\",\r\n            \"departure\": {\r\n                \"airport\": \"Pierre Elliott Trudeau International\",\r\n                \"timezone\": \"America/Montreal\",\r\n                \"iata\": \"YUL\",\r\n                \"icao\": \"CYUL\",\r\n                \"terminal\": null,\r\n                \"gate\": \"C80\",\r\n                \"delay\": 17,\r\n                \"scheduled\": \"2024-09-26T08:00:00+00:00\",\r\n                \"estimated\": \"2024-09-26T08:00:00+00:00\",\r\n                \"actual\": \"2024-09-26T08:17:00+00:00\",\r\n                \"estimated_runway\": \"2024-09-26T08:17:00+00:00\",\r\n                \"actual_runway\": \"2024-09-26T08:17:00+00:00\"\r\n            },\r\n            \"arrival\": {\r\n                \"airport\": \"San Francisco International\",\r\n                \"timezone\": \"America/Los_Angeles\",\r\n                \"iata\": \"SFO\",\r\n                \"icao\": \"KSFO\",\r\n                \"terminal\": \"2\",\r\n                \"gate\": \"D3\",\r\n                \"baggage\": \"4\",\r\n                \"delay\": null,\r\n                \"scheduled\": \"2024-09-26T11:16:00+00:00\",\r\n                \"estimated\": \"2024-09-26T11:16:00+00:00\",\r\n                \"actual\": \"2024-09-26T10:49:00+00:00\",\r\n                \"estimated_runway\": \"2024-09-26T10:49:00+00:00\",\r\n                \"actual_runway\": \"2024-09-26T10:49:00+00:00\"\r\n            },\r\n            \"airline\": {\r\n                \"name\": \"Air Canada\",\r\n                \"iata\": \"AC\",\r\n                \"icao\": \"ACA\"\r\n            },\r\n            \"flight\": {\r\n                \"number\": \"761\",\r\n                \"iata\": \"AC761\",\r\n                \"icao\": \"ACA761\",\r\n                \"codeshared\": null\r\n            },\r\n            \"aircraft\": {\r\n                \"registration\": \"C-GVUN\",\r\n                \"iata\": \"BCS3\",\r\n                \"icao\": \"BCS3\",\r\n                \"icao24\": \"C07E32\"\r\n            },\r\n            \"live\": null\r\n        }\r\n    ]\r\n}";
        public Flight GetFlightByNameMock(string name)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Populate
            };
            AviationStackAPIResponse data = JsonConvert.DeserializeObject<AviationStackAPIResponse>(mockFlight,settings);

            Console.WriteLine(data);

            //if (data == null)
            //{
            //    throw new NullReferenceException("Deserialized response is null.");
            //}

            //if (data.Data == null || data.Data.Count == 0)
            //{
            //    throw new NullReferenceException("Data array is null or empty.");
            //}

            //Flight f = data.Data[0];
            //return f;
            return null; 
        }
    }
}
