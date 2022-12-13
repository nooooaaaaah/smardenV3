using System.Text.Json.Serialization;

namespace SmardenV3.Data
{
    public class SensorData
    {
        [JsonPropertyName("sensorId")]
        public int SensorID { get; set; }
        [JsonPropertyName("sensorType")]
        public string? SensorType { get; set; }
        [JsonPropertyName("sensorData")]
        public string? Data { get; set; }
        [JsonPropertyName("userId")]
        public int UserID { get; set; }
        [JsonPropertyName("gardenId")]
        public int GardenID { get; set; }
        [JsonPropertyName("plantId")]
        public int PlantID { get; set; }
    }
}