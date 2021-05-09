using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace FamilyManagerAssignment.Services.Implementation
{
    public class AdultConnectionImpl : IAdultConnection
    {
        private string apiUrl = @"http://localhost:5001/Adult";
        private HttpClient client = new HttpClient();
        public async Task<HttpResponseMessage> addAdultAsync(string content)
        {
            StringContent httpcontent = new StringContent(content, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(apiUrl, httpcontent);
            return response;
        }

        public async Task deleteAdultAsync(IList<Adult> adultList)
        {
            client.PutAsJsonAsync(apiUrl,adultList);
        }

        public async Task<IList<Adult>> getAdultAsync()
        {
           return await client.GetFromJsonAsync<IList<Adult>>(apiUrl);
        }

        public async Task<IList<Adult>> getAdultByCriteriaAsync(string searched)
        {
            return await client.GetFromJsonAsync<IList<Adult>>(apiUrl += "/"+ searched);        
        }
        
    }
}