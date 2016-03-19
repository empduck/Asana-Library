using Newtonsoft.Json;

namespace AsanaLibrary.Models
{
    public class Team
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
