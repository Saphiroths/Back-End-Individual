using AutoMapper;
using User_Back_End.Models;
using User_Back_End.ViewModels;

namespace User_Back_End.Profiles


{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserViewModel, User>().ReverseMap();
        }
    }
}
