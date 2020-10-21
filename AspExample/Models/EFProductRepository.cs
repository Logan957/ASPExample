using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspExample.Models
{
    public class EFProductRepository : IProductRepository
    {
        private AplicationDbContext context;
        public EFProductRepository (AplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}
