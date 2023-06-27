using Diplom.DataAccess.DbPatterns.Interfaces;
using Diplom.DataAccess.DbPatterns;
using Diplom.DataAccess.Entity;
using Diplom.Services.Interfaces;

namespace Diplom.Services.Service
{
    public class CategoryService : ServiceConstructor, ICategoryServices
    {
        public CategoryService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public async Task<Category> CreateCategory(Category category)
        {
            return await UnitOfWork.Categorys.Create(category);
        }

        public async Task<Category> GetCategory(string categoryName)
        {
            IList<Category> items = await UnitOfWork.Categorys.GetAll();
            return items.FirstOrDefault(x => x.Name == categoryName);
        }

        public async Task UpdateCategory(Category category)
        {
            await UnitOfWork.Categorys.Update(category);
        }

        public async Task<IList<Category>> GetAllCategorys()
        {
            IList<Category> categorys = await UnitOfWork.Categorys.GetAll();
            return categorys;
        }
    }
}
