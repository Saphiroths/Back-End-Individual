using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskService.Models
{
    public class UserItem
    {
        [Key]
        public Guid ID { get; set; }
        public int ItemID { get; set; }
        public Guid UserID { get; set; }
        public virtual Item Items { get; set; }
    }
}
