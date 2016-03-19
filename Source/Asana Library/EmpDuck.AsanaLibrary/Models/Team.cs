using Newtonsoft.Json;

namespace EmpDuck.AsanaLibrary.Models
{
    public class Team
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}