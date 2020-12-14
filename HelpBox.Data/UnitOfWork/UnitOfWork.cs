using HelpBox.Core.Repositories;
using HelpBox.Core.UnitOfWork;
using HelpBox.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpBox.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        private ProductRepository _productRepository;

        //productRepository varsa onu al eğer null ise yeni bir productRepository oluştur.
        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);

        public ICategoryRepository Categories => throw new NotImplementedException();

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }
    }
}
