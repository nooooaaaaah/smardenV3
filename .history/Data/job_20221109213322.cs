using System.Text.Json.Serialization;

namespace SmardenV3.Data
{
    public class Job
    {
        [JsonPropertyName("jobId")]
        public int JobId { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("summary")]
        public string Summary { get; set; }
    }
}