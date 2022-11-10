using SmardenV3.Data;
public interface IPlantService
{
    Task<IEnumerable<PlantData>> GetPlants();
    Task<HttpResponseMessage> PostPlant(PlantData plant);

}