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

        public Item UpdateItem(Item item)
        {
            Item updateitem = _context.Item.SingleOrDefault(i => i.ID == item.ID);
            updateitem.Title = item.Title;
            updateitem.Description = item.Description;
            updateitem.Category = item.Category;
            updateitem.Price = item.Price;
            updateitem.Picture = item.Picture;
            _context.Item.Update(updateitem);
            _context.SaveChanges();
            return item;
        }

        public void DeleteItem(int id)
        {
            Item deleteitem = _context.Item.SingleOrDefault(i => i.ID == id);
            _context.Item.Remove(deleteitem);
            _context.SaveChanges();

        }

    }
}
