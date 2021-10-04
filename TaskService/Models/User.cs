using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.Models
{
    public class User
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public User(int iD, string name, string address, string city)
        {
            ID = iD;
            Name = name;
            Address = address;
            City = city;
        }

        public User()
        {

        }
    }
}
