using Newtonsoft.Json;

namespace Tudu.Models
{
    public class GeoLocation
    {
        [JsonProperty("lat")]
        public string Latitude { get; set; }

        [JsonProperty("lng")]
        public string Longitude { get; set; }

    }
}
