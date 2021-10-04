using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Models;

namespace back_end.DAL
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Item> Item { get; set; }


    }
}
