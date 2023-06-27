using Diplom.DataAccess.Entity;

namespace Diplom.DataAccess.DbPatterns.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> Users { get; }
        IGenericRepository<Item> Items { get; }
        IGenericRepository<Storage> Storages { get; }
        IGenericRepository<Category> Categorys { get; }

    }
}
