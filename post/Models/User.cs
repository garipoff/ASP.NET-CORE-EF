﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace post.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
