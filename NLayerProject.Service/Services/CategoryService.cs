using NLayerProject.Core.Models;
using NLayerProject.Core.Repositories;
using NLayerProject.Core.Services;
using NLayerProject.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IGenericRepository<Category> _repository):
            base(unitOfWork,_repository)
        {

        }
        public async Task<Category> GetWithProductByIdAsync(int categoryId)
        {
            return await _unitOfWork.categoryRepository.GetWithProductByIdAsync(categoryId);
        }
    }
}
