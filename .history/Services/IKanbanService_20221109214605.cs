using SmardenV3.Data;
public interface IKanbanService
{
    Task<IEnumerable<KanbanData>> GetKanbans();
}