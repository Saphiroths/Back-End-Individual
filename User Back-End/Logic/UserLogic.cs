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
        IMapper _mapper;
        IUserRepository _repository;
        public UserLogic(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public UserViewModel GetUser(UserViewModel userViewModel)
        {
            User user = _mapper.Map<User>(userViewModel);
            userViewModel = _mapper.Map<UserViewModel>(_repository.GetUser(user));
            return userViewModel;
        }

        public UserViewModel NewUser(UserViewModel userViewModel)
        {
            userViewModel.ID = Guid.NewGuid();
            User user = _mapper.Map<User>(userViewModel);
            userViewModel = _mapper.Map<UserViewModel>(_repository.NewUser(user));
            return userViewModel;
        }
    }
}
