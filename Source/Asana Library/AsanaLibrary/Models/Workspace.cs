using Newtonsoft.Json;

namespace AsanaLibrary.Models
{
    public class Workspace
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("is_organization")]
        public bool IsOrganization { get; set; }
    }
}
