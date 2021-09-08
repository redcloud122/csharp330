using System;
using System.Text.Json.Serialization;

namespace UserService.Models
{
    public class User
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("date_created")]
        public DateTime DateCreated { get; set; }
    }
}
