using System;
using System.Collections.Generic;
using System.Text;
using User_Back_End.Models;
using User_Back_End.DAL;

namespace TestProject.MockContexts
{
    class MockUserContext : IUserRepository
    {
        private List<User> Users = new List<User>();

        public MockUserContext()
        {
            PopulateUsers();
        }

        public User GetUser(User user)
        {
            return Users.Find(p => p.Email == user.Email);
        }

        public User NewUser(User user)
        {
            return user;
        }
        private void PopulateUsers()
        {
            for (int i = 0; i < 4; i++)
            {
                User user = new User();
                user.ID = new Guid();
                user.Username = "Username" + i;
                user.Email = "Email" + i;
                user.Address = "Address" + i;
                user.City = "City" + i;

                Users.Add(user);

            }
        }
    }
}
