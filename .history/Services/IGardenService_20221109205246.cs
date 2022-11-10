using SmardenV3.Data;
public interface IGardenService
{
    Task<IEnumerable<GardenData>> GetGardens();
}