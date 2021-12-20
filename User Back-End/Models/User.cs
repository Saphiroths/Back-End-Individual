using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace User_Back_End.Models
{
    public class User
    {
        [Key]
        [Required]
        public Guid ID { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public User()
        {

        }
        public User(Guid id, string email, string username, string address, string city)
        {
            ID = id;
            Email = email;
            Username = username;
            Address = address;
            City = city;
        }
        public User(string email)
        {
            Email = email;
        }
    }
}
