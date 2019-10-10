﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace post.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public string PostContent { get; set; }

        public User User { get; set; }
        public Category Category { get; set; }
    }
}
