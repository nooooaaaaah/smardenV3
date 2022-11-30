using SmardenV3.Data;
public interface IEventService
{
    Task<IEnumerable<EventData>> GetEvents();
    Task<IEnumerable<EventData>> GetUsersEvents(int userID);
    Task<HttpResponseMessage> PostEvent(EventData e);
    Task<HttpResponseMessage> EditEvent(EventData e);
    Task<HttpResponseMessage> DeleteEvent(int eventID);
}