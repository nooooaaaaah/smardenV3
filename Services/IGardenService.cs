using SmardenV3.Data;
public interface IGardenService
{
    Task<IEnumerable<GardenData>> GetGardens();
    Task<HttpResponseMessage> PostGarden(GardenData garden);
    Task<HttpResponseMessage> EditGarden(GardenData garden);
    Task<HttpResponseMessage> DeleteGarden(int gardenID);
}