using SmardenV3.Data;

namespace SmardenV3.Services
{
    public class PlantService : IPlantService
    {
        private readonly HttpClient httpClient;
        public PlantService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<PlantData>> GetPlants()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<PlantData>>("https://localhost:7137/api/Plant");
        }
        public async Task<IEnumerable<PlantData>> GetPlantByUser(int userID)
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<PlantData>>("https://localhost:7137/api/Plant/user/" + userID);
        }
        public async Task<IEnumerable<PlantData>> GetPlantByGarden(int gardenID)
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<PlantData>>("https://localhost:7137/api/Plant/garden/" + gardenID);
        }
        public async Task<HttpResponseMessage> PostPlant(PlantData plant)
        {
            return await httpClient.PostAsJsonAsync("https://localhost:7137/api/Plant", plant);
        }
        public async Task<HttpResponseMessage> EditPlant(PlantData plant)
        {
            return await httpClient.PutAsJsonAsync("https://localhost:7137/api/Plant/" + plant.PlantID, plant);
        }
        public async Task<HttpResponseMessage> DeletePlant(int plantID)
        {
            return await httpClient.DeleteAsync("https://localhost:7137/api/Plant/" + plantID);
        }
    }
}