using SmardenV3.Data;

namespace SmardenV3.Services
{
    public class EventService : IEventService
    {
        private readonly HttpClient httpClient;
        public EventService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<EventData>> GetEvents()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<EventData>>("https://localhost:7137/api/Event");
        }
    }
}