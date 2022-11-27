using System.Text.Json.Serialization;

namespace SmardenV3.Data
{
    public class UserData
    {
        [JsonPropertyName("userId")]
        public int UserID { get; set; }
        [JsonPropertyName("userName")]
        public string? Name { get; set; }
        [JsonPropertyName("userPassword")]
        public string? Password { get; set; }
        [JsonPropertyName("customerName")]
        public string? CustomerName { get; set; }
        [JsonPropertyName("customerAddress")]
        public string? CustomerAddress { get; set; }
    }
}