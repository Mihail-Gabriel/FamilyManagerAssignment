using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Models;

namespace FamilyManagerAssignment.Services
{
    public interface IAdultConnection
    {
        Task<HttpResponseMessage> addAdultAsync(string content);
        Task deleteAdultAsync(IList<Adult> adultList);
        Task<IList<Adult>> getAdultAsync();
        Task<IList<Adult>> getAdultByCriteriaAsync(string searched);
    }
}