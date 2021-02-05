using Microsoft.EntityFrameworkCore;
using NLayerProject.Core.Models;
using NLayerProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Data.Repositories
{
    public class CategoryRepository:Repository<Category>,ICategoryRepository
    {
        public CategoryRepository(AppDbContext context):base(context)
        {

        }
        private AppDbContext appDbContext { get => context as AppDbContext; }

        public async Task<Category> GetWithProductByIdAsync(int categoryId)
        {
            return await appDbContext.Categories.Include(x => x.Products).
                SingleOrDefaultAsync(x => x.Id == categoryId);
        }
    }
}
