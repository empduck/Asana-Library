using System;
using Newtonsoft.Json;

namespace EmpDuck.AsanaLibrary.Models
{
    public class Tag
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreateAt { get; set; }

        [JsonProperty("followers")]
        public User[] Followers { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("workspace")]
        public Workspace Workspace { get; set; }
    }
}