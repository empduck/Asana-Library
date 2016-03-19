using Newtonsoft.Json;
using System;

namespace AsanaLibrary.Models
{
    public class Project
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public User Owner { get; set; }

        [JsonProperty("current_status")]
        public CurrentStatus CurrentStatus { get; set; }

        [JsonProperty("due_date")]
        public DateTime? DueDate { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreateAt { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("members")]
        public User[] Members { get; set; }

        [JsonProperty("followers")]
        public User[] Followers { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("workspace")]
        public Workspace Workspace { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }
    }
}
