using SmardenV3.Data;
public interface IKanbanService
{
    Task<IEnumerable<KanbanData>> GetKanbans();
    Task<HttpResponseMessage> PostKanban(KanbanData plant);
    Task<HttpResponseMessage> EditKanban(KanbanData Kanban);
    Task<HttpResponseMessage> DeleteKanban(int plantID);
}