using AutoMapper;
using TaskService.Models;
using TaskService.ViewModels;

namespace back_end.Profiles
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<ItemViewModel, Item>().ReverseMap();
        }
    }
}
