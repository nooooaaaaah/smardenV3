using SmardenV3.Data;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace SmardenV3.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient httpClient;
        public UserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        // private IEnumerable<UserData> users = Array.Empty<UserData>();
        // private bool getuserError;
        // private bool shouldRender;
        // protected override bool ShouldRender() => shouldRender;

        // protected override async Task OnInitializedAsync()
        // {

        //     var request = new HttpRequestMessage(HttpMethod.Get,
        //     "https://localhost:7137/api/user");

        //     var client = ClientFactory.CreateClient();

        //     HttpResponseMessage response = new HttpResponseMessage();
        //     try
        //     {
        //         response = await client.SendAsync(request);
        //     }
        //     catch (Exception e)
        //     {
        //         getuserError = true;
        //     }
        //     finally
        //     {
        //         if (!getuserError)
        //         {
        //             using var responseStream = await response.Content.ReadAsStreamAsync();
        //             users = await JsonSerializer.DeserializeAsync
        //             <IEnumerable<UserData>>(responseStream);
        //         }

        //         shouldRender = true;
        //     }
        // }
    }
}