using NLayerProject.Core.Repositories;
using NLayerProject.Core.UnitOfWork;
using NLayerProject.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;
        public ICategoryRepository categoryRepository => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);

        public IProductRepository productRepository => _productRepository = _productRepository ?? new ProductRepository(_context);

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;

        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
