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
    }
}