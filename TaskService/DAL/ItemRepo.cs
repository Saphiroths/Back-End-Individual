using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace back_end.DAL
{
    public class ItemRepo : IItemRepo
    {
        private readonly ItemContext _context;

        public ItemRepo(ItemContext context)
        {
            _context = context;
        }

        public IEnumerable<Item> GetAllItems()
        {
            return _context.Item;
        }
    }
}
