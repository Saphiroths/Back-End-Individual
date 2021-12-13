using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Back_End.DAL;
using User_Back_End.Models;
using AutoMapper;
using User_Back_End.ViewModels;

namespace User_Back_End.Logic
{
    public class UserLogic
    {
        IMapper mapper;
        IUserRepository _repository;
        public UserLogic(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            this.mapper = mapper;
        }

        public UserViewModel GetUser(UserViewModel user)
        {
            return mapper.Map<UserViewModel>(_repository.GetUser(mapper.Map<User>(user)));
        }

        public UserViewModel NewUser(UserViewModel user)
        {
            return mapper.Map<UserViewModel>(_repository.NewUser(mapper.Map<User>(user)));
        }
    }
}
