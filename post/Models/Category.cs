﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace post.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
