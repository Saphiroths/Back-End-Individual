using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskService.Models
{
    public class Item
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Category { get; set; }
        public int Price { get; set; }
        public string Picture { get; set; }
        public Guid UserID { get; set; }

        public Item()
        {

        }

    }   
}
