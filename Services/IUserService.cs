using SmardenV3.Data;
public interface IUserService
{
    Task<IEnumerable<UserData>> GetUsers();
    Task<HttpResponseMessage> LoginUser(LoginData login);
}