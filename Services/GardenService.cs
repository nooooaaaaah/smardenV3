using SmardenV3.Data;
using System.Text.Json;

namespace SmardenV3.Services
{
    public class GardenService : IGardenService
    {
        private readonly HttpClient httpClient;
        public GardenService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<GardenData>> GetGardens()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<GardenData>>("https://localhost:7137/api/Garden");
        }
        public async Task<HttpResponseMessage> PostGarden(GardenData garden)
        {
            return await httpClient.PostAsJsonAsync("https://localhost:7137/api/Garden", garden);
        }
        public async Task<HttpResponseMessage> EditGarden(GardenData garden)
        {
            return await httpClient.PutAsJsonAsync("https://localhost:7137/api/Garden/"+ garden.GardenID, garden);
        }
        public async Task<HttpResponseMessage> DeleteGarden(int gardenID)
        {
            return await httpClient.DeleteAsync("https://localhost:7137/api/Garden/"+ gardenID);
        }
    }
}