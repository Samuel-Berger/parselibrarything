using System.Text.Json.Serialization;

namespace ParseLibraryThingy
{
    class Authors
    {
        [JsonPropertyName("lf")]
        public string LastFirstName { get; set; }

        [JsonPropertyName("fl")]
        public string FirstLastName { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }
    }
}