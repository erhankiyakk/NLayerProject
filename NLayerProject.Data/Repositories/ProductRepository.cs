using Microsoft.EntityFrameworkCore;
using NLayerProject.Core.Models;
using NLayerProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context):base(context)
        {

        }
        private AppDbContext appDbContext { get => context as AppDbContext; }
        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await appDbContext.Products.Include(x => x.Category).
                SingleOrDefaultAsync(x => x.Id == productId);

        }

    }
}
