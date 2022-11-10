using SmardenV3.Data;

namespace SmardenV3.Services
{
    public class KanbanService : IKanbanService
    {
        private readonly HttpClient httpClient;
        public KanbanService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<KanbanData>> GetKanbans()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<KanbanData>>("https://localhost:7137/api/Job");
        }
    }
}