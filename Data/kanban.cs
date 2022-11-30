using System.Text.Json.Serialization;

namespace SmardenV3.Data
{
    public class KanbanData
    {
        [JsonPropertyName("jobId")]
        public int KanbanId { get; set; }
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        [JsonPropertyName("summary")]
        public string? Summary { get; set; }
        [JsonPropertyName("userId")]
        public int UserID { get; set; }
    }
}