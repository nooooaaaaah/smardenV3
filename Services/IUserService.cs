using SmardenV3.Data;
public interface IUserService
{
    Task<IEnumerable<UserData>> GetUsers();
    Task<HttpResponseMessage> PostUser(UserData user);
    Task<HttpResponseMessage> LoginUser(LoginData login);
    Task<HttpResponseMessage> EditUser(UserData user);
    Task<HttpResponseMessage> EditUserPassword(int userID, string newPassword);
    Task<HttpResponseMessage> DeleteUser(UserData user);


}