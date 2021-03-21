using Models;

namespace FamilyManagerAssignment.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
    }
}