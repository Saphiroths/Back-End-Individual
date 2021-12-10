using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskService.Models;
using TaskService.DAL;


namespace TaskService.Logic
{
    public class ItemLogic
    {
        IItemRepo _repository;
        public ItemLogic(IItemRepo repository)
        {
            _repository = repository;
        }

        public Item NewItem(Item item)
        {
            return _repository.NewItem(item);
        }

        public ICollection<Item> GetAllItems()
        {
            return _repository.GetAllItems();
        }

        public Item UpdateItem(Item item)
        {
            return _repository.UpdateItem(item);
        }
    }
}
