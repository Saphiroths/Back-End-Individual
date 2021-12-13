using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskService.Models;

namespace TaskService.DAL
{
    public interface IItemRepo
    {
        ICollection<Item> GetAllItems();
        Item NewItem(Item item);
        Item UpdateItem(Item item);
        void DeleteItem(int id);
    }
}
