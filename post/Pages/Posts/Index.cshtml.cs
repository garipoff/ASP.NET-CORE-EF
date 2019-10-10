﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using post.Models;

namespace post.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly post.Models.postContext _context;

        public IndexModel(post.Models.postContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; }

        public async Task OnGetAsync(string sortOrder)
        {
            Post = await _context.Post
                .Include(p => p.Category)
                .Include(p => p.User)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
