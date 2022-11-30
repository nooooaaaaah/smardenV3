using SmardenV3.Data;
public interface IPlantService
{
    Task<IEnumerable<PlantData>> GetPlants();
    Task<HttpResponseMessage> PostPlant(PlantData plant);
    Task<IEnumerable<PlantData>> GetPlantByUser(int gardenID);
    Task<IEnumerable<PlantData>> GetPlantByGarden(int gardenID);
    Task<HttpResponseMessage> EditPlant(PlantData Plant);
    Task<HttpResponseMessage> DeletePlant(int plantID);
}