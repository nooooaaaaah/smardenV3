using SmardenV3.Data;
public interface IEventService
{
    Task<IEnumerable<EventData>> GetEvents();
}