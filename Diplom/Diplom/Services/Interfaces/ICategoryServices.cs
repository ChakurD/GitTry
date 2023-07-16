using Diplom.DataAccess.Entity;

namespace Diplom.Services.Interfaces
{
    public interface ICategoryServices
    {
        Task<Category> GetCategory(int? categoryId);
        Task<Category> CreateCategory(Category category);
        Task UpdateCategory(Category category);
        Task<IList<Category>> GetAllCategorys();
    }
}
