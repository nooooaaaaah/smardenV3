using System.Text.Json.Serialization;

namespace SmardenV3.Data
{
    public class EventData
    {
        [JsonPropertyName("eventId")]
        public int EventId { get; set; }
        [JsonPropertyName("subject")]
        public string Subject { get; set; }
        [JsonPropertyName("location")]
        public string Location { get; set; }
        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; set; }
        [JsonPropertyName("endTime")]
        public DateTime EndTime { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("isAllDay")]
        public bool IsAllDay { get; set; }
        [JsonPropertyName("recurrenceRule")]
        public string RecurrenceRule { get; set; }
        [JsonPropertyName("recurrenceException")]
        public string RecurrenceException { get; set; }
        [JsonPropertyName("recurrenceID")]
        public Nullable<int> RecurrenceID { get; set; }
    }
}