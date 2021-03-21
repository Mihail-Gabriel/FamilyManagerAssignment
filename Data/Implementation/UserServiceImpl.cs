using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace FamilyManagerAssignment.Data.Implementation
{
    public class UserServiceImpl : IUserService
    {
        private List<User> users;

        public UserServiceImpl()
        {
            users = new[]
            {
                new User
                {
                    UserName = "Mihail",
                    Password = "12345",
                    Role = "Adult"
                },
                new User()
                {
                    UserName= "Gabriel",
                    Password = "12345",
                    Role = "Child"
                }
            }.ToList();
        }
    

    public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
    
}