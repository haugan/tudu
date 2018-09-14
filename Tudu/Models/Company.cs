using Newtonsoft.Json;

namespace Tudu.Models
{
    public class Company
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("catchPhrase")]
        public string CatchPhrase { get; set; }

        [JsonProperty("bs")]
        public string BusinessSolution { get; set; }
    }
}
