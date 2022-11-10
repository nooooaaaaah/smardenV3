using SmardenV3.Data;
public interface IPlantService
{
    Task<IEnumerable<PlantData>> GetPlants();
    Task<HttpResponseMessage> PostGarden(PlantData plant);

}