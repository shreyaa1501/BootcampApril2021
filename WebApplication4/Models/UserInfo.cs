﻿using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class UserInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
    }
}
