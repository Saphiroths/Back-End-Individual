using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskService.Models;

namespace TaskService.DAL
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Item> Item { get; set; }
        public DbSet<UserItem> User_Item { get; set; }

    }
}
