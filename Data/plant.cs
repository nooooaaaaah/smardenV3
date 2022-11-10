using System.Text.Json.Serialization;

public class PlantData
{
    [JsonPropertyName("plantId")]
    public int PlantID { get; set; }
    [JsonPropertyName("plantName")]
    public string Name { get; set; }
    [JsonPropertyName("plantVariety")]
    public string Variety { get; set; }
    [JsonPropertyName("gardenId")]
    public int GardenID { get; set; }
}