using SmardenV3.Data;

public interface ISensorService
{
    Task<IEnumerable<SensorData>> GetSensors();
    Task<HttpResponseMessage> PostSensor(SensorData sensor);
    Task<IEnumerable<SensorData>> GetSensorByUser(int userID);
    Task<HttpResponseMessage> EditSensor(SensorData sensor);
    Task<HttpResponseMessage> DeleteSensor(SensorData sensor);
}