using SmardenV3.Data;
public interface IUserService
{
    Task<List<UserData>> GetUsers();
}