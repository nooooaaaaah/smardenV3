using SmardenV3.Data;
public interface IJobService
{
    Task<IEnumerable<KanbanData>> GetKanbans();
}