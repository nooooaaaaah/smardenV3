using SmardenV3.Data;
public interface IKanbanService
{
    Task<IEnumerable<KanbanData>> GetKanbans();
    Task<IEnumerable<KanbanData>> GetKanbanByUser(int UserID);
    Task<HttpResponseMessage> PostKanban(KanbanData kanban);
    Task<HttpResponseMessage> EditKanban(KanbanData Kanban);
    Task<HttpResponseMessage> DeleteKanban(int kanbanID);
}