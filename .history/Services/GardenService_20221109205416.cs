using SmardenV3.Data;

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
    }
}