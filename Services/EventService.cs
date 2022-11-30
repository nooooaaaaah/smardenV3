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
        public async Task<IEnumerable<EventData>> GetUsersEvents(int userID)
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<EventData>>("https://localhost:7137/api/Event/user/" + userID);
        }
        public async Task<HttpResponseMessage> PostEvent(EventData e)
        {
            return await httpClient.PostAsJsonAsync("https://localhost:7137/api/Event", e);
        }
        public async Task<HttpResponseMessage> EditEvent(EventData e)
        {
            return await httpClient.PutAsJsonAsync("https://localhost:7137/api/Event/" + e.EventId, e);
        }
        public async Task<HttpResponseMessage> DeleteEvent(int eventID)
        {
            return await httpClient.DeleteAsync("https://localhost:7137/api/Event/" + eventID);
        }
    }
}