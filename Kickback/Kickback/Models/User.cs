﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kickback.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Gamertag { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}