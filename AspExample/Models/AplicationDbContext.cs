using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspExample.Models
{
    public class AplicationDbContext :DbContext
    {
        public AplicationDbContext (DbContextOptions<AplicationDbContext> options) : base (options)
        {}
        public DbSet<Product> Products { get; set; }
    }
}
