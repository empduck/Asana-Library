using Newtonsoft.Json;

namespace EmpDuck.AsanaLibrary.Models
{
    public class CurrentStatus
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }
    }
}