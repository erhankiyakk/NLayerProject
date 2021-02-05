using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Repositories
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        Task<Category> GetWithProductByIdAsync(int categoryId);

    }
}
