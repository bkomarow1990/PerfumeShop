using DAL.Models;
using DAL.Repositories;
using System;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.Data
{
    public class UnitOfWork : IUnitOfWork
    {

        public IRepository<Category> CategoryRepository
        {
            get
            {
                this._categoryRepository ??= new CategoryRepository(_context);
                return _categoryRepository;
            }
        }

        public IRepository<Product> ProductRepository
        {
            get
            {
                this._productRepository ??= new GenericRepository<Product>(_context);
                return _productRepository;
            }
        }
        private readonly BrilliantDbContext _context;
        private IRepository<Category> _categoryRepository;
        private IRepository<Product> _productRepository;
        public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();

        public UnitOfWork(BrilliantDbContext context)
        {
            this._context = context;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
