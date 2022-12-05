using SmardenV3.Data;

namespace SmardenV3.Services
{
    public class UserService : IUserService
    {
        Task<HttpResponseMessage> response;
        private readonly HttpClient httpClient;
        public UserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<UserData>> GetUsers()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<UserData>>("https://localhost:7137/api/User");
        }
        public async Task<HttpResponseMessage> PostUser(UserData user)
        {
            return await httpClient.PostAsJsonAsync("https://localhost:7137/api/User", user);
        }
        public async Task<HttpResponseMessage> EditUser(UserData user)
        {
            return await httpClient.PutAsJsonAsync("https://localhost:7137/api/User/" + user.UserID, user);
        }
        public async Task<HttpResponseMessage> EditUserPassword(int userID, string newPassword)
        {
            return await httpClient.PutAsJsonAsync("https://localhost:7137/api/User/password/" + userID + "?password=" + newPassword, newPassword);
        }
        public async Task<HttpResponseMessage> LoginUser(LoginData login)
        {
            return await httpClient.PostAsJsonAsync("https://localhost:7137/api/login", login);
        }
        public async Task<HttpResponseMessage> DeleteUser(UserData user)
        {
            return await httpClient.DeleteAsync("https://localhost:7137/api/user/" + user.UserID);
        }
    }
}