using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Category> CategoryRepository { get; }
        IRepository<Product> ProductRepository { get; }
        Task<int> SaveChangesAsync();
    }
}
