using System.Text.Json.Serialization;

namespace SmardenV3.Data
{
    public class GardenData
    {
        [JsonPropertyName("gardenId")]
        public int GardenID { get; set; }
        [JsonPropertyName("gardenName")]
        public string Name { get; set; }
        [JsonPropertyName("userId")]
        public int UserID { get; set; }
    }
}