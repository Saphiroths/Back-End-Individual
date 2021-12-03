using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskService.Models;
using Microsoft.EntityFrameworkCore;

namespace TaskService.DAL
{
    public class ItemRepo : IItemRepo
    {
        private readonly ItemContext _context;

        public ItemRepo(ItemContext context)
        {
            _context = context;
        }

        public ICollection<Item> GetAllItems()
        {
            return _context.Item.ToList();
        }

        public Item NewItem(Item item)
        {
            _context.Item.Add(item);
            _context.SaveChanges();
            return item;
        }
    }
}
