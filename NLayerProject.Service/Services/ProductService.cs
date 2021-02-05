using NLayerProject.Core.Models;
using NLayerProject.Core.Repositories;
using NLayerProject.Core.Services;
using NLayerProject.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IGenericRepository<Product> _repository):
            base(unitOfWork,_repository)
        {

        }
        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await _unitOfWork.productRepository.GetWithCategoryByIdAsync(productId);
        }
    }
}
