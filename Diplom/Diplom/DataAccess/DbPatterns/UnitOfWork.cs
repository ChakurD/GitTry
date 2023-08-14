using Diplom.DataAccess.DbPatterns.Interfaces;
using Diplom.DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace Diplom.DataAccess.DbPatterns
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext _context;

        public UnitOfWork(MyDbContext context)
        {
            _context = context;
        }
        public IGenericRepository<User> Users => new GenericRepository<User>(_context);

        public IGenericRepository<Item> Items => new GenericRepository<Item>(_context);

        public IGenericRepository<Storage> Storages => new GenericRepository<Storage>(_context);

        public IGenericRepository<Category> Categorys => new GenericRepository<Category>(_context);
    }
}
