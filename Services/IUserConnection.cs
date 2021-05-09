using System.Net.Http;
using System.Threading.Tasks;
using Models;

namespace FamilyManagerAssignment.Services
{
    public interface IUserConnection
    {
        Task<User> getUserAsync(string username, string password);
        Task<HttpResponseMessage> registerUserAsync(string content);
    }
}