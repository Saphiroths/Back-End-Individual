using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.Models
{
    public class Item
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Item(int iD, string title, string description)
        {
            ID = iD;
            Title = title;
            Description = description;
        }

        public Item()
        {

        }

    }   
}
