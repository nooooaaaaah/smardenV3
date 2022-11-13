using SmardenV3.Data;

namespace SmardenV3.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient httpClient;
        public UserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<UserData>> GetUsers()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<UserData>>("https://localhost:7137/api/User");
        }

        public async Task<HttpResponseMessage> LoginUser(LoginData login)
        {
            return await httpClient.PostAsJsonAsync("https://localhost:7137/api/login", login);
        }
    }
}