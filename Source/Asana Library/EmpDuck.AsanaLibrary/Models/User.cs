using Newtonsoft.Json;

namespace EmpDuck.AsanaLibrary.Models
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string EmailAddress { get; set; }

        [JsonProperty("workspaces")]
        public Workspace[] Workspaces { get; set; }
    }
}