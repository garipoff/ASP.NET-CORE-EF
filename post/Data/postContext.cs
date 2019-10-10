using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace post.Models
{
    public class postContext : DbContext
    {
        public postContext (DbContextOptions<postContext> options)
            : base(options)
        {
        }

        public DbSet<post.Models.User> User { get; set; }
        public DbSet<post.Models.Category> Category { get; set; }
        public DbSet<post.Models.Post> Post { get; set; }
    }
}
