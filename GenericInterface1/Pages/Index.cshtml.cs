using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageDemo.Models;

namespace RazorPageDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageDemo.Models.productDbContext _context;

        public IndexModel(RazorPageDemo.Models.productDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
