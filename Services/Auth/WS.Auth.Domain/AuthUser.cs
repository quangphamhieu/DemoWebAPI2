﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS.Auth.Domain
{
    public class AuthUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? CustomerId { get; set; }
    }
}
