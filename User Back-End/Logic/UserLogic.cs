using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Back_End.DAL;
using User_Back_End.Models;

namespace User_Back_End.Logic
{
    public class UserLogic
    {
        IUserRepository _repository;
        public UserLogic(IUserRepository repository)
        {
            _repository = repository;
        }

        public User GetUser(User user)
        {
            return _repository.GetUser(user);
        }

        public User NewUser(User user)
        {
            return _repository.NewUser(user);
        }
    }
}
