using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Models;

namespace back_end.DAL
{
    public interface IItemRepo
    {
        IEnumerable<Item> GetAllItems();

    }
}
