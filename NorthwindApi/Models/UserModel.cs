﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindApi.Models
{
    public class UserModel
    {
        public string Username { get; set;}
        public string EmailAddress { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
}
