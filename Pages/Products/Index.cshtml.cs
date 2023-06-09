﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GRazor.Models;

namespace GRazor.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly GRazor.Data.GRazorContext _context;

        public IndexModel(GRazor.Data.GRazorContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Product != null)
            {
                Product = await _context.Product.ToListAsync();
            }
        }
    }
}
