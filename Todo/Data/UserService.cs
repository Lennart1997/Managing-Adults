using System;
using System.Collections.Generic;
using System.Linq;
using ToDo.Models;

namespace ToDo.Data
{
    public class UserService : IUserService
    {
        private List<User> users;
      
        public UserService() {
            
            users = new[] {
                new User {
                    City = "Horsens",
                    Domain = "via.dk",
                    Password = "123456",
                    Role = "Teacher",
                    BirthYear = 1986,
                    SecurityLevel = 5,
                    UserName = "Admin"
                },
                new User {
                    City = "Aarhus",
                    Domain = "hotmail.com",
                    Password = "123456",
                    Role = "Student",
                    BirthYear = 1998,
                    SecurityLevel = 3,
                    UserName = "Student"
                },

            }.ToList();
        }


        public User ValidateUser(string userName, string password) {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null) {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password)) {
                throw new Exception("Incorrect password");
            }

            return first;
        }
        
        
    }
}