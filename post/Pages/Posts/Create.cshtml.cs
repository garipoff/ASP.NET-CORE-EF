using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using post.Models;

namespace post.Pages.Posts
{
    public class CreateModel : PageModel
    {
        private readonly post.Models.postContext _context;

        public CreateModel(post.Models.postContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryName");
            ViewData["UserID"] = new SelectList(_context.User, "ID", "UserName");
            return Page();
        }

        [BindProperty]
        public Post Post { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var emptyPost = new Post();

            if (await TryUpdateModelAsync<Post>(
                 emptyPost,
                 "post",
                 p => p.PostID, p => p.UserID, p => p.CategoryID, p => p.PostContent))
            {
                _context.Post.Add(emptyPost);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return Page();
        }
    }
}