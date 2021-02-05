using NLayerProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICategoryRepository categoryRepository { get; }

        IProductRepository productRepository { get; }
        Task CommitAsync();

        void Commit();
    }
}
