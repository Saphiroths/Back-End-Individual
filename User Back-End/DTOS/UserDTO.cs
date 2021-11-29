﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User_Back_End.DTOS
{
    public class UserDTO
    {
        public Guid ID { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}
