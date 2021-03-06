using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskService.ViewModels
{
    public class ItemViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Category { get; set; }
        public int Price { get; set; }
        public string Picture { get; set; }
        public Guid UserID { get; set; }
    }
}
