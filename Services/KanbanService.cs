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
        public async Task<HttpResponseMessage> PostKanban(KanbanData kanban)
        {
            return await httpClient.PostAsJsonAsync("https://localhost:7137/api/Job", kanban);
        }
        public async Task<HttpResponseMessage> EditKanban(KanbanData kanban)
        {
            return await httpClient.PutAsJsonAsync("https://localhost:7137/api/Job/" + kanban.KanbanId, kanban);
        }
        public async Task<HttpResponseMessage> DeleteKanban(int kanbanID)
        {
            return await httpClient.DeleteAsync("https://localhost:7137/api/Job/" + kanbanID);
        }
    }
}