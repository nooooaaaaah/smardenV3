using SmardenV3.Data;
public interface IGardenService
{
    Task<IEnumerable<GardenData>> GetGardens();
    Task<IEnumerable<GardenData>> GetUsersGardens(int userID);
    Task<HttpResponseMessage> PostGarden(GardenData garden);
    Task<HttpResponseMessage> EditGarden(GardenData garden);
    Task<HttpResponseMessage> DeleteGarden(int gardenID);
}