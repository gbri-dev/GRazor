using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GRazor.Models;

namespace GRazor.Data
{
    public class GRazorContext : DbContext
    {
        public GRazorContext (DbContextOptions<GRazorContext> options)
            : base(options)
        {
        }

        public DbSet<GRazor.Models.Product> Product { get; set; } = default!;
    }
}
