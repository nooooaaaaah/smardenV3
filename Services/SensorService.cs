using SmardenV3.Data;

namespace Smarden.Services
{
    public class SensorService : ISensorService
    {
        Task<HttpResponseMessage> response;
        private readonly HttpClient httpClient;
        public SensorService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<HttpResponseMessage> DeleteSensor(SensorData sensor)
        {
            return await httpClient.DeleteAsync("https://localhost:7137/api/sensor/" + sensor.UserID);
        }

        public async Task<HttpResponseMessage> EditSensor(SensorData Sensor)
        {
            return await httpClient.PutAsJsonAsync("https://localhost:7137/api/Sensor/" + Sensor.SensorID, Sensor);
        }

        public async Task<IEnumerable<SensorData>> GetSensorByUser(int userID)
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<SensorData>>("https://localhost:7137/api/Sensor/user/" + userID);
        }

        public async Task<IEnumerable<SensorData>> GetSensors()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<SensorData>>("https://localhost:7137/api/Sensor");
        }

        public async Task<HttpResponseMessage> PostSensor(SensorData sensor)
        {
            return await httpClient.PostAsJsonAsync("https://localhost:7137/api/sensor", sensor);
        }
    }
}