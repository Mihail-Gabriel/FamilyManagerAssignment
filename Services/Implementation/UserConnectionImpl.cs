using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace FamilyManagerAssignment.Services.Implementation
{
    public class UserConnectionImpl : IUserConnection
    {
        private HttpClient client = new HttpClient();
        private string apiUrl = @"http://localhost:5001/User";
        
        public async Task<User> getUserAsync(string username, string password)
        {
           return await client.GetFromJsonAsync<User>(apiUrl+"?userName="+username+"&password="+password);
        }

        public async Task<HttpResponseMessage> registerUserAsync(string content)
        {
            StringContent httpcontent = new StringContent(content, Encoding.UTF8, "application/json");
            return await client.PostAsync(apiUrl, httpcontent);
        }
    }
}