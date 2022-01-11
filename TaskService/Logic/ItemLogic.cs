using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskService.Models;
using TaskService.DAL;
using AutoMapper;
using TaskService.ViewModels;

namespace TaskService.Logic
{
    public class ItemLogic
    {
        IMapper mapper;
        IItemRepo _repository;
        public ItemLogic(IItemRepo repository, IMapper mapper)
        {
            _repository = repository;
            this.mapper = mapper;
        }

        public ItemViewModel NewItem(ItemViewModel item)
        {
            return mapper.Map<ItemViewModel>(_repository.NewItem(mapper.Map<Item>(item)));
        }

        public ICollection<ItemViewModel> GetAllItems()
        {
            return mapper.Map<ICollection<ItemViewModel>>(_repository.GetAllItems());
        }

        public ItemViewModel UpdateItem(ItemViewModel item)
        {
            return mapper.Map<ItemViewModel>(_repository.UpdateItem(mapper.Map<Item>(item)));
        }

        public void DeleteItem(int id)
        {
            _repository.DeleteItem(id);
        }

        //public List<ItemViewModel> getItemsByUser(Guid id)
        //{
        //    return mapper.Map<List<ItemViewModel>>(_repository.getItemsByUser(id));
        //}

        public List<ItemViewModel> getItemsByUserId(Guid id)
        {
            return mapper.Map<List<ItemViewModel>>(_repository.getItemsByUserId(id));
        }

    }
}
