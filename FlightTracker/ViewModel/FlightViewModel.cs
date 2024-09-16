using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FlightTracker.ViewModel
{
    public class FlightViewModel
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly string baseURL = "https://api.aviationstack.com/v1/flights";
        private readonly string accessKey  ;
        public string FlightId { get; set; }
       
        
        public FlightViewModel(string FlightId)
        {
            
            this.FlightId = FlightId;
            this.accessKey = Environment.GetEnvironmentVariable("AviationStackAPIKey");
            if (string.IsNullOrEmpty(accessKey))
            {
                throw new InvalidOperationException("AviationStackAPIKey is not set in environment variables.");
            }
        }
        private string BuildApiUrl()
        {
            
            string queryString = $"?access_key={accessKey}";

            if (!string.IsNullOrEmpty(FlightId))
            {
                queryString += $"&flight_id={FlightId}";
            }

            
            return baseURL + queryString;
        }
        public  async Task<string> GetApiData()
        {
            string apiUrl = BuildApiUrl();

            // Sending the GET request
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            // Ensure the request was successful
            response.EnsureSuccessStatusCode();

            // Read the response content as a string
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
}
